using Application_Layer;
using Application_Layer.Repos;
using Domain_Layer.DTOs;
using Domain_Layer.DTOs.services;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepo _itemAppService;
        private readonly AppDbContext _appContext;

        public ServiceController(IServiceRepo itemAppService, AppDbContext appContext)
        {
            _itemAppService = itemAppService;
            _appContext = appContext;

        }


        [HttpGet("search")]
            public IActionResult Search(
            Guid ID,
            string? Name = null,
            string? CategoryName = null,
            
            int ExpectedSalary = 0,
            string OrderBy = "ExpectedSalary",
            bool IsAscending = false,
            int PageSize = 6,
            int PageIndex = 1
            )
        {
            try
            {
                var items = _itemAppService.Search(ID,Name,CategoryName,ExpectedSalary, OrderBy,IsAscending,PageSize,PageIndex);
                // Assuming PaginationViewModel has a property named Items that contains the list of Servicesviewmodel
                foreach (var item in items.Data)
                {
                    if (!System.IO.File.Exists(item.filepath))
                    {
                        return NotFound("File not found");
                    }

                    // Read the file content into a byte array
                    byte[] fileBytes = System.IO.File.ReadAllBytes(item.filepath);

                    // Determine the content type based on the file extension
                    string contentType = "application/octet-stream"; // Default content type
                    var fileExtension = Path.GetExtension(item.filepath);
                    if (!string.IsNullOrEmpty(fileExtension))
                    {
                        contentType = GetContentType(fileExtension);
                    }

                    item.file= File(fileBytes, contentType, Path.GetFileName(item.filepath));
                }

                return Ok(items);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        private string GetContentType(string fileExtension)
        {
            // You can add more content type mappings as needed
            switch (fileExtension.ToLower())
            {
                case ".txt":
                    return "text/plain";
                case ".pdf":
                    return "application/pdf";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                default:
                    return "application/octet-stream";
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var items = _itemAppService.GetAllServices();
                foreach (var item in items)
                {
                    if (!System.IO.File.Exists(item.filepath))
                    {
                        return NotFound("File not found");
                    }

                    // Read the file content into a byte array
                    byte[] fileBytes = System.IO.File.ReadAllBytes(item.filepath);

                    // Determine the content type based on the file extension
                    string contentType = "application/octet-stream"; // Default content type
                    var fileExtension = Path.GetExtension(item.filepath);
                    if (!string.IsNullOrEmpty(fileExtension))
                    {
                        contentType = GetContentType(fileExtension);
                    }

                    item.file = File(fileBytes, contentType, Path.GetFileName(item.filepath));
                }
                return Ok(items);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpGet("cat")]
        public IActionResult Getcat()
        {
            try
            {
                List<catDTO> items = _appContext.ServiceCategorie
                                                  .Select(c => new catDTO
                                                  {
                                                      ID = c.ID,
                                                      Name = c.Name,
                                                      // Map other properties as needed
                                                  })
                                                  .ToList();
                return Ok(items);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var item = _itemAppService.GetItemById(id);
                if (item == null)
                {
                    return NotFound();
                }
               
                
                    if (!System.IO.File.Exists(item.filepath))
                    {
                        return NotFound("File not found");
                    }

                    // Read the file content into a byte array
                    byte[] fileBytes = System.IO.File.ReadAllBytes(item.filepath);

                    // Determine the content type based on the file extension
                    string contentType = "application/octet-stream"; // Default content type
                    var fileExtension = Path.GetExtension(item.filepath);
                    if (!string.IsNullOrEmpty(fileExtension))
                    {
                        contentType = GetContentType(fileExtension);
                    }

                    item.file = File(fileBytes, contentType, Path.GetFileName(item.filepath));
                
                return Ok(item);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }

        }
        private static string _uploadFolder = "Content"; // The folder where you want to save the files

        [HttpPost("file")]
         public async Task<IActionResult> UploadFile([FromForm] ServicesDTO serviceDTO)
        {
            if (serviceDTO.file == null || serviceDTO.file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), _uploadFolder);
            Directory.CreateDirectory(uploadPath); // Create the folder if it doesn't exist

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(serviceDTO.file.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await serviceDTO.file.CopyToAsync(stream);
            }

            if (serviceDTO == null)
            {
                return BadRequest("Invalid data received");
            }

            try
            {
                _itemAppService.AddNewItem(serviceDTO, filePath);

                return CreatedAtAction(nameof(Get), new { ID = serviceDTO.ID }, serviceDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            } // Return the file path if needed
        }
     

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(Guid id, [FromForm] ServicesDTO serviceDTO)
        {
            if (serviceDTO.file == null || serviceDTO.file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), _uploadFolder);
            Directory.CreateDirectory(uploadPath); // Create the folder if it doesn't exist

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(serviceDTO.file.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await serviceDTO.file.CopyToAsync(stream);
            }
            try
            {
                // Retrieve the item from the database based on the provided ID

                if (serviceDTO == null)
                {
                    return NotFound(); // If the item with the provided ID does not exist
                }

                _itemAppService.UpdateItem(id, serviceDTO,filePath);

                return Ok("Item updated successfully"); // Return the updated item as a response
            }
            catch (Exception ex)
            {
                // Log the error
                return StatusCode(500, "Internal server error");
            }
        }
       [HttpPut("rempve/{id}")]
        public IActionResult RemoveItem(Guid id)
        {
            try
            {

                if (id == null)
                {
                    return NotFound(); // If the item with the provided ID does not exist
                }

                _itemAppService.RemoveItem(id);

                return Ok("Item Deleted successfully"); // Return the updated item as a response
            }
            catch (Exception ex)
            {
                // Log the error
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
