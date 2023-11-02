using Application_Layer;
using Application_Layer.Repos;
using Application_Layer.Services;
using AutoMapper;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sermart_Api.Helpers;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public ProductController(IProduct product, IUnitOfWork unitOfWork, IMapper mapper,AppDbContext dbContext)
        {

            _product = product;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _dbContext = dbContext;
        }
        //GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {

            var result = await _product.GetAllProduct();
            var mapper = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(result);

            _unitOfWork.CommitChanges();
            return Ok(mapper);

        }

        //GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductViewModel>> GetByid(Guid id)
        {
            var result = await _product.GetProductByid(id);
            var mapper = _mapper.Map<Product, ProductViewModel>(result);
            _unitOfWork.CommitChanges();
            return Ok(mapper);
        }

        //POST api/<ProductController>
        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult<ProductViewModel>> Addproduct(ProductViewModel productVM)
        {

            productVM.ProviderId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                //foreach (IFormFile file in productVM.Images)
                //{
                //    FileStream fileStream = new FileStream(
                //        Path.Combine(
                //            Directory.GetCurrentDirectory(), "wwwroot", "Image", file.FileName),
                //        FileMode.Create);
                //    file.CopyTo(fileStream);
                //    fileStream.Position = 0;
                //    productVM.ImagesURL.Add(file.FileName);
                //}


                var mapper = _mapper.Map<ProductViewModel, Product>(productVM);
                await _product.Add(mapper);
                _unitOfWork.CommitChanges();

                return Ok(mapper);
            }
            return (productVM);
        }

        //PUT api/<ProductController>/5
        [HttpPut()]

        public ProductViewModel Update(ProductViewModel productVM)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var mapper = _mapper.Map<ProductViewModel, Product>(productVM);
                    _product.Update(mapper);
                    _unitOfWork.CommitChanges();
                    
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                }

            }

            return productVM;
        }

        //DELETE api/<ProductController>/5
        [HttpDelete()]

        public ActionResult Delete(ProductViewModel productVM)
        {



            if (ModelState.IsValid)
            {
                try
                {
                    var mapper = _mapper.Map<ProductViewModel, Product>(productVM);
                    _product.Delete(mapper);
                    _unitOfWork.CommitChanges();
                    return Ok(mapper);
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }

            return Ok();

        }
        
        ////////[HttpDelete]
        ////////public ActionResult GetAll( Product Cator)
        ////////{
          
        ////////     _dbContext.Product.Remove(Cator);
        ////////    return Ok();
        ////////}


       
       
   

    }
}
