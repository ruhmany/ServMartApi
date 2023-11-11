using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Chat");

            migrationBuilder.EnsureSchema(
                name: "Address");

            migrationBuilder.EnsureSchema(
                name: "Product");

            migrationBuilder.EnsureSchema(
                name: "Request");

            migrationBuilder.EnsureSchema(
                name: "Service");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorate",
                schema: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorate", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "Product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Catagory = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategory",
                schema: "Service",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                    table.ForeignKey(
                        name: "FK_City_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Address",
                        principalTable: "Governorate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Gender = table.Column<bool>(type: "bit", maxLength: 128, nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Address",
                        principalTable: "City",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Address",
                        principalTable: "Governorate",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Address",
                        principalTable: "City",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Address",
                        principalTable: "Governorate",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Product",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stoke = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "Product",
                        principalTable: "ProductCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                schema: "Request",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ExpectedSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateValue = table.Column<float>(type: "real", nullable: false),
                    RateMassage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDirect = table.Column<bool>(type: "bit", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Request_AspNetUsers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Address",
                        principalTable: "City",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Request_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Address",
                        principalTable: "Governorate",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Service",
                schema: "Service",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    ExpectedSalary = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Service_AspNetUsers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_ServiceCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "Service",
                        principalTable: "ServiceCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qauntety = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Product",
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ToltalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Product",
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "ProductMedia",
                schema: "Product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MeadiUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMedia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductMedia_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Product",
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductRate",
                schema: "Product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductRate_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductRate_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Product",
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                schema: "Chat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chat_AspNetUsers_SecondUserId",
                        column: x => x.SecondUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chat_Request_RequestID",
                        column: x => x.RequestID,
                        principalSchema: "Request",
                        principalTable: "Request",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestMedia",
                schema: "Request",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMedia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RequestMedia_Request_RequestID",
                        column: x => x.RequestID,
                        principalSchema: "Request",
                        principalTable: "Request",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RequestOffer",
                schema: "Request",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    State = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    RequestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ExpectSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestOffer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RequestOffer_AspNetUsers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestOffer_Request_RequestID",
                        column: x => x.RequestID,
                        principalSchema: "Request",
                        principalTable: "Request",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceMedia",
                schema: "Service",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ServiceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceMedia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceMedia_Service_ID",
                        column: x => x.ID,
                        principalSchema: "Service",
                        principalTable: "Service",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceRate",
                schema: "Service",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NominateToOthers = table.Column<float>(type: "real", nullable: false),
                    WorkQuality = table.Column<float>(type: "real", nullable: false),
                    RespectDeliveryTime = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceRate_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRate_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalSchema: "Service",
                        principalTable: "Service",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                schema: "Chat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Message_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_Chat_ChatId",
                        column: x => x.ChatId,
                        principalSchema: "Chat",
                        principalTable: "Chat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageMedia",
                schema: "Chat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MessageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageMedia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MessageMedia_Message_MessageID",
                        column: x => x.MessageID,
                        principalSchema: "Chat",
                        principalTable: "Message",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f882022-a9e5-4371-9db3-955344b876de", null, "Customer", "CUSTOMER" },
                    { "6da2327c-c585-482b-874c-88d5aaa46a77", null, "Vendor", "VENDOR" },
                    { "892e96ec-dc8e-4ad2-aea1-ea16fd1676f0", null, "Admin", "ADMIN" },
                    { "d81c75b8-2883-49d7-9954-82c3e36add2b", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Address",
                table: "Governorate",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "القاهرة", "Cairo" },
                    { 2, "الجيزة", "Giza" },
                    { 3, "الأسكندرية", "Alexandria" },
                    { 4, "الدقهلية", "Dakahlia" },
                    { 5, "البحر الأحمر", "Red Sea" },
                    { 6, "البحيرة", "Beheira" },
                    { 7, "الفيوم", "Fayoum" },
                    { 8, "الغربية", "Gharbiya" },
                    { 9, "الإسماعلية", "Ismailia" },
                    { 10, "المنوفية", "Menofia" },
                    { 11, "المنيا", "Minya" },
                    { 12, "القليوبية", "Qaliubiya" },
                    { 13, "الوادي الجديد", "New Valley" },
                    { 14, "السويس", "Suez" },
                    { 15, "اسوان", "Aswan" },
                    { 16, "اسيوط", "Assiut" },
                    { 17, "بني سويف", "Beni Suef" },
                    { 18, "بورسعيد", "Port Said" },
                    { 19, "دمياط", "Damietta" },
                    { 20, "الشرقية", "Sharkia" },
                    { 21, "جنوب سيناء", "South Sinai" },
                    { 22, "كفر الشيخ", "Kafr Al sheikh" },
                    { 23, "مطروح", "Matrouh" },
                    { 24, "الأقصر", "Luxor" },
                    { 25, "قنا", "Qena" },
                    { 26, "شمال سيناء", "North Sinai" },
                    { 27, "سوهاج", "Sohag" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("00fc362b-13af-4b4b-902e-b07b06372c07"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("03d9fffd-44da-4667-94ad-aa126b5d32ea"), "المكتبات", "Libraries" },
                    { new Guid("0b203b6b-860f-429f-8d04-c710d5574908"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("1567d54c-dba6-4725-bfcc-e7670783a2a9"), "خدمات التجميل", "Beauty services" },
                    { new Guid("18737824-1753-4ee3-a16b-be4f6e6d164f"), "ضيافة", "Hospitality" },
                    { new Guid("20676595-fa69-464a-b4c1-7f8bb67156e1"), "نجارة", "Carpenter " },
                    { new Guid("2df10f44-068f-45ae-a423-f112a4df43dd"), "خدمات الترجمة", "Translation services" },
                    { new Guid("2e34c6a1-0d42-4cb6-9566-b18a3b172395"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("2e7c12e4-02b7-4ec1-a517-2e184beb8462"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("355bb5e6-32c6-4abe-aa70-d95271d4bad8"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("393dfe14-e479-4d11-a1f4-511a6f12f189"), "العناية بالحديقة", "Garden care" },
                    { new Guid("3c23bf7d-5a8c-47bb-9c10-17e1ebdc580a"), "ترفيه", "Entertainment" },
                    { new Guid("3fa261db-6a3d-442e-9d17-777e110f2b46"), "خدمات قانونية", "Legal services" },
                    { new Guid("4866a6a8-383d-4075-b86f-87071d61534a"), "تسقيف", "Roofing" },
                    { new Guid("49965607-88fa-4cfe-937e-e4c586e81d7c"), "تأمين", "Insurance" },
                    { new Guid("5297f22d-eae4-4837-b04e-09aa4f1fc791"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("5783f3fe-9968-4882-80ff-bd77e4d8b395"), "رعاية الأطفال", "Childcare" },
                    { new Guid("58c3f1ef-b7b0-4439-baab-23def7347f7e"), "الرياضة", "Sports" },
                    { new Guid("5c41e3da-35f2-4df6-8e2d-8353694c12bf"), "سباكة", "Plumbing" },
                    { new Guid("61afb109-437c-4fdc-b968-caca2d5fd195"), "البناء", "Construction" },
                    { new Guid("6be5c022-3bea-44d7-b5ea-3011d8a3e80a"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("718c1855-a184-4b7a-a2c0-c8ae72005742"), "إستشارات", "Consulting " },
                    { new Guid("7541b2e2-efe8-46d3-a9f0-67d5f6a79afc"), "التكييف", "Air conditioning" },
                    { new Guid("79a83c4f-12d6-4854-8d93-ff081a1b0c16"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("7cbc0e93-1c74-4a0c-af48-84b2946637b1"), "تقديم الطعام", "Catering " },
                    { new Guid("809c9784-92ee-4716-af9a-ee3545ac498c"), "المحاسبة", "Accounting" },
                    { new Guid("92b8f48c-291b-4882-8090-3b5a2d94e31e"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("9964b333-6bee-4d3e-9a01-3451b9cc4573"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("9b4bfabb-2e39-45dc-8f64-bb8cfc51e362"), "إدارة المكاتب", "Office management" },
                    { new Guid("9fdc10df-234e-4971-9cc8-f1957bdbb221"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("a20a25d0-8979-4315-8145-18a8764ed72a"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("a29e5a3c-4363-439b-bfc2-a580daaf6aef"), "الخدمات المالية", "Financial services" },
                    { new Guid("a40b2ece-9569-4dd9-b92d-428dbedc13ef"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("a4b0a1b4-140a-43f3-9bf7-799f3663aae1"), "الخدمات الطبية", "Medical services" },
                    { new Guid("ae3f5fd1-c9e9-46ca-ad75-0c27fe77c544"), "نقاشة", "Painter" },
                    { new Guid("b150714f-9f5c-480f-8f36-af0424b5ae92"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("b1c3f373-d4e3-41b0-8c3b-a5206a4da8a1"), "خدمات حكومية", "Government services" },
                    { new Guid("b584661b-e4a6-4a20-b609-14b0c61a0536"), "خدمات أخرى", "Other services" },
                    { new Guid("ba408b6d-3638-4c4a-a8a9-dd1f04bd15ff"), "العقارات", "Real estate" },
                    { new Guid("c08f7265-4858-4988-b98f-51d125b571bd"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("c1fe7ad8-62c0-4e5a-92a3-9396643d4150"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("c4165f8a-6473-4118-a22e-6a612fb02410"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c588f650-0301-42d0-bcd8-e260def0653f"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("cf6075a6-ec6f-4327-8e66-5de205c7318c"), "كهرباء", "Electricity" },
                    { new Guid("daf1c0bb-5ab5-4de0-968a-33faef5e0030"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("dcfa7f1b-39e3-4cc2-aa8b-727858f9f3aa"), "خدمات النقل", "Transportation services" },
                    { new Guid("e2b857dc-fd2f-4b9a-b842-122a82e9b62a"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("ece162ce-f2cf-4756-83ab-e45cdef4509c"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" }
                });

            migrationBuilder.InsertData(
                schema: "Address",
                table: "City",
                columns: new[] { "ID", "GovernorateId", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, 1, "15 مايو", "15 May" },
                    { 2, 1, "الازبكية", "Al Azbakeyah" },
                    { 3, 1, "البساتين", "Al Basatin" },
                    { 4, 1, "التبين", "Tebin" },
                    { 5, 1, "الخليفة", "El-Khalifa" },
                    { 6, 1, "الدراسة", "El darrasa" },
                    { 7, 1, "الدرب الاحمر", "Aldarb Alahmar" },
                    { 8, 1, "الزاوية الحمراء", "Zawya al-Hamra" },
                    { 9, 1, "الزيتون", "El-Zaytoun" },
                    { 10, 1, "الساحل", "Sahel" },
                    { 11, 1, "السلام", "El Salam" },
                    { 12, 1, "السيدة زينب", "Sayeda Zeinab" },
                    { 13, 1, "الشرابية", "El Sharabeya" },
                    { 14, 1, "مدينة الشروق", "Shorouk" },
                    { 15, 1, "الظاهر", "El Daher" },
                    { 16, 1, "العتبة", "Ataba" },
                    { 17, 1, "القاهرة الجديدة", "New Cairo" },
                    { 18, 1, "المرج", "El Marg" },
                    { 19, 1, "عزبة النخل", "Ezbet el Nakhl" },
                    { 20, 1, "المطرية", "Matareya" },
                    { 21, 1, "المعادى", "Maadi" },
                    { 22, 1, "المعصرة", "Maasara" },
                    { 23, 1, "المقطم", "Mokattam" },
                    { 24, 1, "المنيل", "Manyal" },
                    { 25, 1, "الموسكى", "Mosky" },
                    { 26, 1, "النزهة", "Nozha" },
                    { 27, 1, "الوايلى", "Waily" },
                    { 28, 1, "باب الشعرية", "Bab al-Shereia" },
                    { 29, 1, "بولاق", "Bolaq" },
                    { 30, 1, "جاردن سيتى", "Garden City" },
                    { 31, 1, "حدائق القبة", "Hadayek El-Kobba" },
                    { 32, 1, "حلوان", "Helwan" },
                    { 33, 1, "دار السلام", "Dar Al Salam" },
                    { 34, 1, "شبرا", "Shubra" },
                    { 35, 1, "طره", "Tura" },
                    { 36, 1, "عابدين", "Abdeen" },
                    { 37, 1, "عباسية", "Abaseya" },
                    { 38, 1, "عين شمس", "Ain Shams" },
                    { 39, 1, "مدينة نصر", "Nasr City" },
                    { 40, 1, "مصر الجديدة", "New Heliopolis" },
                    { 41, 1, "مصر القديمة", "Masr Al Qadima" },
                    { 42, 1, "منشية ناصر", "Mansheya Nasir" },
                    { 43, 1, "مدينة بدر", "Badr City" },
                    { 44, 1, "مدينة العبور", "Obour City" },
                    { 45, 1, "وسط البلد", "Cairo Downtown" },
                    { 46, 1, "الزمالك", "Zamalek" },
                    { 47, 1, "قصر النيل", "Kasr El Nile" },
                    { 48, 1, "الرحاب", "Rehab" },
                    { 49, 1, "القطامية", "Katameya" },
                    { 50, 1, "مدينتي", "Madinty" },
                    { 51, 1, "روض الفرج", "Rod Alfarag" },
                    { 52, 1, "شيراتون", "Sheraton" },
                    { 53, 1, "الجمالية", "El-Gamaleya" },
                    { 54, 1, "العاشر من رمضان", "10th of Ramadan City" },
                    { 55, 1, "الحلمية", "Helmeyat Alzaytoun" },
                    { 56, 1, "النزهة الجديدة", "New Nozha" },
                    { 57, 1, "العاصمة الإدارية", "Capital New" },
                    { 58, 2, "الجيزة", "Giza" },
                    { 59, 2, "السادس من أكتوبر", "Sixth of October" },
                    { 60, 2, "الشيخ زايد", "Cheikh Zayed" },
                    { 61, 2, "الحوامدية", "Hawamdiyah" },
                    { 62, 2, "البدرشين", "Al Badrasheen" },
                    { 63, 2, "الصف", "Saf" },
                    { 64, 2, "أطفيح", "Atfih" },
                    { 65, 2, "العياط", "Al Ayat" },
                    { 66, 2, "الباويطي", "Al-Bawaiti" },
                    { 67, 2, "منشأة القناطر", "ManshiyetAl Qanater" },
                    { 68, 2, "أوسيم", "Oaseem" },
                    { 69, 2, "كرداسة", "Kerdasa" },
                    { 70, 2, "أبو النمرس", "Abu Nomros" },
                    { 71, 2, "كفر غطاطي", "Kafr Ghati" },
                    { 72, 2, "منشأة البكاري", "Manshiyet Al Bakari" },
                    { 73, 2, "الدقى", "Dokki" },
                    { 74, 2, "العجوزة", "Agouza" },
                    { 75, 2, "الهرم", "Haram" },
                    { 76, 2, "الوراق", "Warraq" },
                    { 77, 2, "امبابة", "Imbaba" },
                    { 78, 2, "بولاق الدكرور", "Boulaq Dakrour" },
                    { 79, 2, "الواحات البحرية", "Al Wahat Al Baharia" },
                    { 80, 2, "العمرانية", "Omraneya" },
                    { 81, 2, "المنيب", "Moneeb" },
                    { 82, 2, "بين السرايات", "Bin Alsarayat" },
                    { 83, 2, "الكيت كات", "Kit Kat" },
                    { 84, 2, "المهندسين", "Mohandessin" },
                    { 85, 2, "فيصل", "Faisal" },
                    { 86, 2, "أبو رواش", "Abu Rawash" },
                    { 87, 2, "حدائق الأهرام", "Hadayek Alahram" },
                    { 88, 2, "الحرانية", "Haraneya" },
                    { 89, 2, "حدائق اكتوبر", "Hadayek October" },
                    { 90, 2, "صفط اللبن", "Saft Allaban" },
                    { 91, 2, "القرية الذكية", "Smart Village" },
                    { 92, 2, "ارض اللواء", "Ard Ellwaa" },
                    { 93, 3, "ابو قير", "Abu Qir" },
                    { 94, 3, "الابراهيمية", "Al Ibrahimeyah" },
                    { 95, 3, "الأزاريطة", "Azarita" },
                    { 96, 3, "الانفوشى", "Anfoushi" },
                    { 97, 3, "الدخيلة", "Dekheila" },
                    { 98, 3, "السيوف", "El Soyof" },
                    { 99, 3, "العامرية", "Ameria" },
                    { 100, 3, "اللبان", "El Labban" },
                    { 101, 3, "المفروزة", "Al Mafrouza" },
                    { 102, 3, "المنتزه", "El Montaza" },
                    { 103, 3, "المنشية", "Mansheya" },
                    { 104, 3, "الناصرية", "Naseria" },
                    { 105, 3, "امبروزو", "Ambrozo" },
                    { 106, 3, "باب شرق", "Bab Sharq" },
                    { 107, 3, "برج العرب", "Bourj Alarab" },
                    { 108, 3, "ستانلى", "Stanley" },
                    { 109, 3, "سموحة", "Smouha" },
                    { 110, 3, "سيدى بشر", "Sidi Bishr" },
                    { 111, 3, "شدس", "Shads" },
                    { 112, 3, "غيط العنب", "Gheet Alenab" },
                    { 113, 3, "فلمينج", "Fleming" },
                    { 114, 3, "فيكتوريا", "Victoria" },
                    { 115, 3, "كامب شيزار", "Camp Shizar" },
                    { 116, 3, "كرموز", "Karmooz" },
                    { 117, 3, "محطة الرمل", "Mahta Alraml" },
                    { 118, 3, "مينا البصل", "Mina El-Basal" },
                    { 119, 3, "العصافرة", "Asafra" },
                    { 120, 3, "العجمي", "Agamy" },
                    { 121, 3, "بكوس", "Bakos" },
                    { 122, 3, "بولكلي", "Boulkly" },
                    { 123, 3, "كليوباترا", "Cleopatra" },
                    { 124, 3, "جليم", "Glim" },
                    { 125, 3, "المعمورة", "Al Mamurah" },
                    { 126, 3, "المندرة", "Al Mandara" },
                    { 127, 3, "محرم بك", "Moharam Bek" },
                    { 128, 3, "الشاطبي", "Elshatby" },
                    { 129, 3, "سيدي جابر", "Sidi Gaber" },
                    { 130, 3, "الساحل الشمالي", "North Coast Sahel" },
                    { 131, 3, "الحضرة", "Alhadra" },
                    { 132, 3, "العطارين", "Alattarin" },
                    { 133, 3, "سيدي كرير", "Sidi Kerir" },
                    { 134, 3, "الجمرك", "Elgomrok" },
                    { 135, 3, "المكس", "Al Max" },
                    { 136, 3, "مارينا", "Marina" },
                    { 137, 4, "المنصورة", "Mansoura" },
                    { 138, 4, "طلخا", "Talkha" },
                    { 139, 4, "ميت غمر", "Mitt Ghamr" },
                    { 140, 4, "دكرنس", "Dekernes" },
                    { 141, 4, "أجا", "Aga" },
                    { 142, 4, "منية النصر", "Menia El Nasr" },
                    { 143, 4, "السنبلاوين", "Sinbillawin" },
                    { 144, 4, "الكردي", "El Kurdi" },
                    { 145, 4, "بني عبيد", "Bani Ubaid" },
                    { 146, 4, "المنزلة", "Al Manzala" },
                    { 147, 4, "تمي الأمديد", "tami al'amdid" },
                    { 148, 4, "الجمالية", "aljamalia" },
                    { 149, 4, "شربين", "Sherbin" },
                    { 150, 4, "المطرية", "Mataria" },
                    { 151, 4, "بلقاس", "Belqas" },
                    { 152, 4, "ميت سلسيل", "Meet Salsil" },
                    { 153, 4, "جمصة", "Gamasa" },
                    { 154, 4, "محلة دمنة", "Mahalat Damana" },
                    { 155, 4, "نبروه", "Nabroh" },
                    { 156, 5, "الغردقة", "Hurghada" },
                    { 157, 5, "رأس غارب", "Ras Ghareb" },
                    { 158, 5, "سفاجا", "Safaga" },
                    { 159, 5, "القصير", "El Qusiar" },
                    { 160, 5, "مرسى علم", "Marsa Alam" },
                    { 161, 5, "الشلاتين", "Shalatin" },
                    { 162, 5, "حلايب", "Halaib" },
                    { 163, 5, "الدهار", "Aldahar" },
                    { 164, 6, "دمنهور", "Damanhour" },
                    { 165, 6, "كفر الدوار", "Kafr El Dawar" },
                    { 166, 6, "رشيد", "Rashid" },
                    { 167, 6, "إدكو", "Edco" },
                    { 168, 6, "أبو المطامير", "Abu al-Matamir" },
                    { 169, 6, "أبو حمص", "Abu Homs" },
                    { 170, 6, "الدلنجات", "Delengat" },
                    { 171, 6, "المحمودية", "Mahmoudiyah" },
                    { 172, 6, "الرحمانية", "Rahmaniyah" },
                    { 173, 6, "إيتاي البارود", "Itai Baroud" },
                    { 174, 6, "حوش عيسى", "Housh Eissa" },
                    { 175, 6, "شبراخيت", "Shubrakhit" },
                    { 176, 6, "كوم حمادة", "Kom Hamada" },
                    { 177, 6, "بدر", "Badr" },
                    { 178, 6, "وادي النطرون", "Wadi Natrun" },
                    { 179, 6, "النوبارية الجديدة", "New Nubaria" },
                    { 180, 6, "النوبارية", "Alnoubareya" },
                    { 181, 7, "الفيوم", "Fayoum" },
                    { 182, 7, "الفيوم الجديدة", "Fayoum El Gedida" },
                    { 183, 7, "طامية", "Tamiya" },
                    { 184, 7, "سنورس", "Snores" },
                    { 185, 7, "إطسا", "Etsa" },
                    { 186, 7, "إبشواي", "Epschway" },
                    { 187, 7, "يوسف الصديق", "Yusuf El Sediaq" },
                    { 188, 7, "الحادقة", "Hadqa" },
                    { 189, 7, "اطسا", "Atsa" },
                    { 190, 7, "الجامعة", "Algamaa" },
                    { 191, 7, "السيالة", "Sayala" },
                    { 192, 8, "طنطا", "Tanta" },
                    { 193, 8, "المحلة الكبرى", "Al Mahalla Al Kobra" },
                    { 194, 8, "كفر الزيات", "Kafr El Zayat" },
                    { 195, 8, "زفتى", "Zefta" },
                    { 196, 8, "السنطة", "El Santa" },
                    { 197, 8, "قطور", "Qutour" },
                    { 198, 8, "بسيون", "Basion" },
                    { 199, 8, "سمنود", "Samannoud" },
                    { 200, 9, "الإسماعيلية", "Ismailia" },
                    { 201, 9, "فايد", "Fayed" },
                    { 202, 9, "القنطرة شرق", "Qantara Sharq" },
                    { 203, 9, "القنطرة غرب", "Qantara Gharb" },
                    { 204, 9, "التل الكبير", "El Tal El Kabier" },
                    { 205, 9, "أبو صوير", "Abu Sawir" },
                    { 206, 9, "القصاصين الجديدة", "Kasasien El Gedida" },
                    { 207, 9, "نفيشة", "Nefesha" },
                    { 208, 9, "الشيخ زايد", "Sheikh Zayed" },
                    { 209, 10, "شبين الكوم", "Shbeen El Koom" },
                    { 210, 10, "مدينة السادات", "Sadat City" },
                    { 211, 10, "منوف", "Menouf" },
                    { 212, 10, "سرس الليان", "Sars El-Layan" },
                    { 213, 10, "أشمون", "Ashmon" },
                    { 214, 10, "الباجور", "Al Bagor" },
                    { 215, 10, "قويسنا", "Quesna" },
                    { 216, 10, "بركة السبع", "Berkat El Saba" },
                    { 217, 10, "تلا", "Tala" },
                    { 218, 10, "الشهداء", "Al Shohada" },
                    { 219, 11, "المنيا", "Minya" },
                    { 220, 11, "المنيا الجديدة", "Minya El Gedida" },
                    { 221, 11, "العدوة", "El Adwa" },
                    { 222, 11, "مغاغة", "Magagha" },
                    { 223, 11, "بني مزار", "Bani Mazar" },
                    { 224, 11, "مطاي", "Mattay" },
                    { 225, 11, "سمالوط", "Samalut" },
                    { 226, 11, "المدينة الفكرية", "Madinat El Fekria" },
                    { 227, 11, "ملوي", "Meloy" },
                    { 228, 11, "دير مواس", "Deir Mawas" },
                    { 229, 11, "ابو قرقاص", "Abu Qurqas" },
                    { 230, 11, "ارض سلطان", "Ard Sultan" },
                    { 231, 12, "بنها", "Banha" },
                    { 232, 12, "قليوب", "Qalyub" },
                    { 233, 12, "شبرا الخيمة", "Shubra Al Khaimah" },
                    { 234, 12, "القناطر الخيرية", "Al Qanater Charity" },
                    { 235, 12, "الخانكة", "Khanka" },
                    { 236, 12, "كفر شكر", "Kafr Shukr" },
                    { 237, 12, "طوخ", "Tukh" },
                    { 238, 12, "قها", "Qaha" },
                    { 239, 12, "العبور", "Obour" },
                    { 240, 12, "الخصوص", "Khosous" },
                    { 241, 12, "شبين القناطر", "Shibin Al Qanater" },
                    { 242, 12, "مسطرد", "Mostorod" },
                    { 243, 13, "الخارجة", "El Kharga" },
                    { 244, 13, "باريس", "Paris" },
                    { 245, 13, "موط", "Mout" },
                    { 246, 13, "الفرافرة", "Farafra" },
                    { 247, 13, "بلاط", "Balat" },
                    { 248, 13, "الداخلة", "Dakhla" },
                    { 249, 14, "السويس", "Suez" },
                    { 250, 14, "الجناين", "Alganayen" },
                    { 251, 14, "عتاقة", "Ataqah" },
                    { 252, 14, "العين السخنة", "Ain Sokhna" },
                    { 253, 14, "فيصل", "Faysal" },
                    { 254, 15, "أسوان", "Aswan" },
                    { 255, 15, "أسوان الجديدة", "Aswan El Gedida" },
                    { 256, 15, "دراو", "Drau" },
                    { 257, 15, "كوم أمبو", "Kom Ombo" },
                    { 258, 15, "نصر النوبة", "Nasr Al Nuba" },
                    { 259, 15, "كلابشة", "Kalabsha" },
                    { 260, 15, "إدفو", "Edfu" },
                    { 261, 15, "الرديسية", "Al-Radisiyah" },
                    { 262, 15, "البصيلية", "Al Basilia" },
                    { 263, 15, "السباعية", "Al Sibaeia" },
                    { 264, 15, "ابوسمبل السياحية", "Abo Simbl Al Siyahia" },
                    { 265, 15, "مرسى علم", "Marsa Alam" },
                    { 266, 16, "أسيوط", "Assiut" },
                    { 267, 16, "أسيوط الجديدة", "Assiut El Gedida" },
                    { 268, 16, "ديروط", "Dayrout" },
                    { 269, 16, "منفلوط", "Manfalut" },
                    { 270, 16, "القوصية", "Qusiya" },
                    { 271, 16, "أبنوب", "Abnoub" },
                    { 272, 16, "أبو تيج", "Abu Tig" },
                    { 273, 16, "الغنايم", "El Ghanaim" },
                    { 274, 16, "ساحل سليم", "Sahel Selim" },
                    { 275, 16, "البداري", "El Badari" },
                    { 276, 16, "صدفا", "Sidfa" },
                    { 277, 17, "بني سويف", "Bani Sweif" },
                    { 278, 17, "بني سويف الجديدة", "Beni Suef El Gedida" },
                    { 279, 17, "الواسطى", "Al Wasta" },
                    { 280, 17, "ناصر", "Naser" },
                    { 281, 17, "إهناسيا", "Ehnasia" },
                    { 282, 17, "ببا", "beba" },
                    { 283, 17, "الفشن", "Fashn" },
                    { 284, 17, "سمسطا", "Somasta" },
                    { 285, 17, "الاباصيرى", "Alabbaseri" },
                    { 286, 17, "مقبل", "Mokbel" },
                    { 287, 18, "بورسعيد", "PorSaid" },
                    { 288, 18, "بورفؤاد", "Port Fouad" },
                    { 289, 18, "العرب", "Alarab" },
                    { 290, 18, "حى الزهور", "Zohour" },
                    { 291, 18, "حى الشرق", "Alsharq" },
                    { 292, 18, "حى الضواحى", "Aldawahi" },
                    { 293, 18, "حى المناخ", "Almanakh" },
                    { 294, 18, "حى مبارك", "Mubarak" },
                    { 295, 19, "دمياط", "Damietta" },
                    { 296, 19, "دمياط الجديدة", "New Damietta" },
                    { 297, 19, "رأس البر", "Ras El Bar" },
                    { 298, 19, "فارسكور", "Faraskour" },
                    { 299, 19, "الزرقا", "Zarqa" },
                    { 300, 19, "السرو", "alsaru" },
                    { 301, 19, "الروضة", "alruwda" },
                    { 302, 19, "كفر البطيخ", "Kafr El-Batikh" },
                    { 303, 19, "عزبة البرج", "Azbet Al Burg" },
                    { 304, 19, "ميت أبو غالب", "Meet Abou Ghalib" },
                    { 305, 19, "كفر سعد", "Kafr Saad" },
                    { 306, 20, "الزقازيق", "Zagazig" },
                    { 307, 20, "العاشر من رمضان", "Al Ashr Men Ramadan" },
                    { 308, 20, "منيا القمح", "Minya Al Qamh" },
                    { 309, 20, "بلبيس", "Belbeis" },
                    { 310, 20, "مشتول السوق", "Mashtoul El Souq" },
                    { 311, 20, "القنايات", "Qenaiat" },
                    { 312, 20, "أبو حماد", "Abu Hammad" },
                    { 313, 20, "القرين", "El Qurain" },
                    { 314, 20, "ههيا", "Hehia" },
                    { 315, 20, "أبو كبير", "Abu Kabir" },
                    { 316, 20, "فاقوس", "Faccus" },
                    { 317, 20, "الصالحية الجديدة", "El Salihia El Gedida" },
                    { 318, 20, "الإبراهيمية", "Al Ibrahimiyah" },
                    { 319, 20, "ديرب نجم", "Deirb Negm" },
                    { 320, 20, "كفر صقر", "Kafr Saqr" },
                    { 321, 20, "أولاد صقر", "Awlad Saqr" },
                    { 322, 20, "الحسينية", "Husseiniya" },
                    { 323, 20, "صان الحجر القبلية", "san alhajar alqablia" },
                    { 324, 20, "منشأة أبو عمر", "Manshayat Abu Omar" },
                    { 325, 21, "الطور", "Al Toor" },
                    { 326, 21, "شرم الشيخ", "Sharm El-Shaikh" },
                    { 327, 21, "دهب", "Dahab" },
                    { 328, 21, "نويبع", "Nuweiba" },
                    { 329, 21, "طابا", "Taba" },
                    { 330, 21, "سانت كاترين", "Saint Catherine" },
                    { 331, 21, "أبو رديس", "Abu Redis" },
                    { 332, 21, "أبو زنيمة", "Abu Zenaima" },
                    { 333, 21, "رأس سدر", "Ras Sidr" },
                    { 334, 22, "كفر الشيخ", "Kafr El Sheikh" },
                    { 335, 22, "وسط البلد كفر الشيخ", "Kafr El Sheikh Downtown" },
                    { 336, 22, "دسوق", "Desouq" },
                    { 337, 22, "فوه", "Fooh" },
                    { 338, 22, "مطوبس", "Metobas" },
                    { 339, 22, "برج البرلس", "Burg Al Burullus" },
                    { 340, 22, "بلطيم", "Baltim" },
                    { 341, 22, "مصيف بلطيم", "Masief Baltim" },
                    { 342, 22, "الحامول", "Hamol" },
                    { 343, 22, "بيلا", "Bella" },
                    { 344, 22, "الرياض", "Riyadh" },
                    { 345, 22, "سيدي سالم", "Sidi Salm" },
                    { 346, 22, "قلين", "Qellen" },
                    { 347, 22, "سيدي غازي", "Sidi Ghazi" },
                    { 348, 23, "مرسى مطروح", "Marsa Matrouh" },
                    { 349, 23, "الحمام", "El Hamam" },
                    { 350, 23, "العلمين", "Alamein" },
                    { 351, 23, "الضبعة", "Dabaa" },
                    { 352, 23, "النجيلة", "Al-Nagila" },
                    { 353, 23, "سيدي براني", "Sidi Brani" },
                    { 354, 23, "السلوم", "Salloum" },
                    { 355, 23, "سيوة", "Siwa" },
                    { 356, 23, "مارينا", "Marina" },
                    { 357, 23, "الساحل الشمالى", "North Coast" },
                    { 358, 24, "الأقصر", "Luxor" },
                    { 359, 24, "الأقصر الجديدة", "New Luxor" },
                    { 360, 24, "إسنا", "Esna" },
                    { 361, 24, "طيبة الجديدة", "New Tiba" },
                    { 362, 24, "الزينية", "Al ziynia" },
                    { 363, 24, "البياضية", "Al Bayadieh" },
                    { 364, 24, "القرنة", "Al Qarna" },
                    { 365, 24, "أرمنت", "Armant" },
                    { 366, 24, "الطود", "Al Tud" },
                    { 367, 25, "قنا", "Qena" },
                    { 368, 25, "قنا الجديدة", "New Qena" },
                    { 369, 25, "ابو طشت", "Abu Tesht" },
                    { 370, 25, "نجع حمادي", "Nag Hammadi" },
                    { 371, 25, "دشنا", "Deshna" },
                    { 372, 25, "الوقف", "Alwaqf" },
                    { 373, 25, "قفط", "Qaft" },
                    { 374, 25, "نقادة", "Naqada" },
                    { 375, 25, "فرشوط", "Farshout" },
                    { 376, 25, "قوص", "Quos" },
                    { 377, 26, "العريش", "Arish" },
                    { 378, 26, "الشيخ زويد", "Sheikh Zowaid" },
                    { 379, 26, "نخل", "Nakhl" },
                    { 380, 26, "رفح", "Rafah" },
                    { 381, 26, "بئر العبد", "Bir al-Abed" },
                    { 382, 26, "الحسنة", "Al Hasana" },
                    { 383, 27, "سوهاج", "Sohag" },
                    { 384, 27, "سوهاج الجديدة", "Sohag El Gedida" },
                    { 385, 27, "أخميم", "Akhmeem" },
                    { 386, 27, "أخميم الجديدة", "Akhmim El Gedida" },
                    { 387, 27, "البلينا", "Albalina" },
                    { 388, 27, "المراغة", "El Maragha" },
                    { 389, 27, "المنشأة", "almunsha'a" },
                    { 390, 27, "دار السلام", "Dar AISalaam" },
                    { 391, 27, "جرجا", "Gerga" },
                    { 392, 27, "جهينة الغربية", "Jahina Al Gharbia" },
                    { 393, 27, "ساقلته", "Saqilatuh" },
                    { 394, 27, "طما", "Tama" },
                    { 395, 27, "طهطا", "Tahta" },
                    { 396, 27, "الكوثر", "Alkawthar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GovernorateId",
                table: "AspNetUsers",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartID",
                table: "CartItem",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductID",
                table: "CartItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_RequestID",
                schema: "Chat",
                table: "Chat",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SecondUserId",
                schema: "Chat",
                table: "Chat",
                column: "SecondUserId");

            migrationBuilder.CreateIndex(
                name: "IX_City_GovernorateId",
                schema: "Address",
                table: "City",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ChatId",
                schema: "Chat",
                table: "Message",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                schema: "Chat",
                table: "Message",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageMedia_MessageID",
                schema: "Chat",
                table: "MessageMedia",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CityId",
                table: "Order",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_GovernorateId",
                table: "Order",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                schema: "Product",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProviderId",
                schema: "Product",
                table: "Product",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_ProductID",
                schema: "Product",
                table: "ProductMedia",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRate_ProductId",
                schema: "Product",
                table: "ProductRate",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRate_UserId",
                schema: "Product",
                table: "ProductRate",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_CityId",
                schema: "Request",
                table: "Request",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_GovernorateId",
                schema: "Request",
                table: "Request",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ProviderId",
                schema: "Request",
                table: "Request",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserID",
                schema: "Request",
                table: "Request",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Request",
                table: "RequestMedia",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOffer_ProviderID",
                schema: "Request",
                table: "RequestOffer",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOffer_RequestID",
                schema: "Request",
                table: "RequestOffer",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CategoryID",
                schema: "Service",
                table: "Service",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ProviderID",
                schema: "Service",
                table: "Service",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRate_ServiceID",
                schema: "Service",
                table: "ServiceRate",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRate_UserId",
                schema: "Service",
                table: "ServiceRate",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "MessageMedia",
                schema: "Chat");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "ProductMedia",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "ProductRate",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "RequestMedia",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "RequestOffer",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "ServiceMedia",
                schema: "Service");

            migrationBuilder.DropTable(
                name: "ServiceRate",
                schema: "Service");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Message",
                schema: "Chat");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Service",
                schema: "Service");

            migrationBuilder.DropTable(
                name: "Chat",
                schema: "Chat");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "ServiceCategory",
                schema: "Service");

            migrationBuilder.DropTable(
                name: "Request",
                schema: "Request");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Address");

            migrationBuilder.DropTable(
                name: "Governorate",
                schema: "Address");
        }
    }
}
