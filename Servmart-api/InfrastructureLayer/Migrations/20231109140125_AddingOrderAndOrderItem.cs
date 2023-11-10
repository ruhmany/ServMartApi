using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class AddingOrderAndOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20e6e0e3-1ab3-4dc4-848c-385da4479e4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a6bc53b-36b8-46f6-bf8c-fc78c5c99927");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af7b2705-e605-4f54-bc9f-8576de22fd1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4366997-79f1-4c28-9dc2-e13b407d5908");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("05577694-5e88-4580-adb7-b507d041a768"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("072f8b38-df15-4f0d-9bb0-3c322597659e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("09a5b00d-98bc-44e4-b763-10365f424b65"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0e3d87c6-7b08-491d-b955-aace20a79b47"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1687e5ce-74ba-4e18-b983-9d46a50b22ba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1f8e083c-171c-4209-8e50-0e1ed1505a7b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2128baaa-2310-4cc3-b3a8-818fe094922f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("22fed7dc-06ed-490a-b283-26d0cbc47856"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("24c5d132-a645-4f93-beb3-e09c7e376599"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("25175465-c915-4ae3-bbfb-ff4b9b9d890b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2bc01b8a-44bb-40f3-af78-1cf5745d84be"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2c98c046-773a-4160-889b-2f5307458bbc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("34279a13-65cc-4bd7-a206-8ad203331132"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("37d42ead-6640-4faf-a85d-ad31079f58f8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3dbf1f2a-2aa9-43a5-98ba-9c1dd965cf76"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("473c38b7-d512-4099-99c4-00ab0ded5f69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4b84ea6f-b13f-40fe-b30b-9054aa4e1b46"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57213f39-9b0c-4448-b4b4-07f967d3ade3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("578ec31a-e8cc-469d-aaa5-16a6ee3b8a80"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5dc3f9b7-c953-46b1-ad55-f4c6dce828dd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5eee76e1-aa12-48c5-84f7-27951986ccef"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("65e863c7-3cd8-4684-9ec8-5a302b87a4d4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6d7e1fb7-83bd-4af2-abae-9c6e49b9ae12"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("711c9745-5c78-43b1-b0c0-3db2f24e6b45"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("71e8d611-8d88-4f3d-add2-331dcc699de6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("780df81d-c803-4393-9597-63f42654771f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7978c709-9d84-4624-bbc2-9a35d396cfa7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7afbaefb-9460-4d64-b453-37a13c9c370c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9201c348-b1bd-4c87-a713-96dffd783969"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9af536a2-6da8-427c-86f5-425e32959eca"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a237f048-7705-4be1-b9b1-a28f44251b28"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad94427c-8a24-428d-aaac-3b8a082c556d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b254524c-4929-4595-994f-c087070f9957"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bdd09a87-b380-4ad2-8b14-c040662e7942"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c354fad8-66eb-4d67-9078-a64f826266ec"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c3db72b6-56d7-4970-97ed-f496fb7bd142"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c5cbd767-6af6-464e-8130-dfc19219833e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cd6b1db3-fc8c-4203-b655-222585778b22"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d073f4ce-3e15-4ca8-825c-7499d47ca7db"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d30aa20d-cd46-433e-a58b-d6d868361862"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d3fc95f1-f2a2-4ff4-b7d5-7e26f07af832"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d578d549-af29-4118-b110-ef47f340de91"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d857c947-6c8e-43cf-9810-ad1fc5dcc09b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("db1daeac-0cb6-4fb7-98b8-e8add9732fd8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e7d2b0ea-7b28-486e-b714-c145ddce90fa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("eb592ead-ea9a-4f1f-9dc1-55ff27b562d6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ed639b6e-ba4c-4d17-8a6c-c2ce2ccc1980"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f42319f4-cab2-4bf2-a033-ed12a0d165ca"));

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0feeb55b-a0e2-431c-8f02-d49fe6d3b0fc", null, "Admin", "ADMIN" },
                    { "45e7697e-fa9a-43b3-a060-1cb66c15af42", null, "Customer", "CUSTOMER" },
                    { "c19f5b29-f109-4997-b7d2-ea2ab319778a", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "fad39e6e-f6eb-45ae-834a-e3e0b257ca21", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0665c723-766e-4d25-8da3-c0b0fe259f96"), "تأمين", "Insurance" },
                    { new Guid("0bf11e8c-b5da-4fa7-8c3f-cd183a4262c3"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("10484932-f8ce-4636-8ecb-5c595bcc6470"), "العقارات", "Real estate" },
                    { new Guid("18a42f26-3500-47c5-9975-b5ec7b857fc9"), "نقاشة", "Painter" },
                    { new Guid("1a2d6ab8-1699-491e-826f-246def14181e"), "خدمات قانونية", "Legal services" },
                    { new Guid("1bb89067-7d9c-41c4-aebc-5fe8aa87f965"), "نجارة", "Carpenter " },
                    { new Guid("1f6fe9a7-fa7c-4280-9960-cd223631563a"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("2098900d-3019-4130-9686-b3b464026617"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("2099be88-5679-4c78-b818-540d72cadc49"), "كهرباء", "Electricity" },
                    { new Guid("2a4b1c1a-11d9-4d11-95f4-1cc67774a57e"), "المحاسبة", "Accounting" },
                    { new Guid("2e2aa3b0-626e-4046-8910-249f36e46ea2"), "خدمات الترجمة", "Translation services" },
                    { new Guid("2ecfc6fb-2c18-4feb-a4de-4a7cd9cf60c5"), "إدارة المكاتب", "Office management" },
                    { new Guid("309207c9-6e0a-4a42-850f-1b6770b3315d"), "خدمات التجميل", "Beauty services" },
                    { new Guid("3b05f54f-68b9-4b13-ad3c-031716493fae"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("3d6b49d2-1acd-46d2-be77-288a6e83a13e"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("4e36176d-c136-4c65-8b76-eca7ab4aa0b7"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("638c76a9-b0bb-4c3a-976d-49d948214213"), "خدمات أخرى", "Other services" },
                    { new Guid("669409a4-524d-43e4-b47a-90e8bae6384e"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("675ba7f8-ff18-4772-9279-ecf4b9751c93"), "ترفيه", "Entertainment" },
                    { new Guid("68780f16-c3e4-4147-a442-228b1cf29d1f"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("7593cbd7-3e68-42b3-9d2d-2fe81820395a"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("7687fd48-643e-4b42-90ce-298e35c2bf51"), "الرياضة", "Sports" },
                    { new Guid("78f0b1d4-736c-419b-997c-a6ef4575978f"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("81a4c225-aa6c-44f0-bbfd-a893d86bafbd"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("85bb4d5d-c2f0-4c20-b891-a42b8be5647c"), "إستشارات", "Consulting " },
                    { new Guid("8fb787b5-8296-4e6d-8a61-582735f05001"), "سباكة", "Plumbing" },
                    { new Guid("925b642f-2089-4415-88f9-31cab861d12b"), "تسقيف", "Roofing" },
                    { new Guid("97cc1543-1c2e-485e-937c-1d92edcd1a50"), "خدمات حكومية", "Government services" },
                    { new Guid("988c4af8-9236-47f4-b791-cc4ca4a7871f"), "تقديم الطعام", "Catering " },
                    { new Guid("9ac0103f-c2e8-4589-883f-878546bb8c5c"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("9e7ee80b-706f-4dbc-adcf-5070c82a0cad"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("9f8b990b-0086-4c94-9a96-2944d48e517e"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("a86876e9-1efa-4160-82ca-c5c3590af483"), "خدمات النقل", "Transportation services" },
                    { new Guid("b1f32c2b-1d6b-4b4a-889f-009714d29aa3"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("b6ddaec7-d474-408c-bb62-4101589a113b"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("c346a2b0-3d55-487d-adaf-008bb8f27fd9"), "البناء", "Construction" },
                    { new Guid("ce6d39dc-e1c5-4047-a0db-b7563121fac8"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("d1073084-17b4-4594-8cf9-6f9f6fa25fcd"), "المكتبات", "Libraries" },
                    { new Guid("d32b0634-cce0-47e4-add8-878c45bd511d"), "الخدمات المالية", "Financial services" },
                    { new Guid("d64b84e4-559c-48eb-84a8-db75dc5ff07e"), "الخدمات الطبية", "Medical services" },
                    { new Guid("dd5ed062-3a55-4481-90c9-a81547236410"), "رعاية الأطفال", "Childcare" },
                    { new Guid("de28af84-91c8-474d-96cb-a7918460d780"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("deac164d-443f-40a4-8977-0c31ffbc47e1"), "ضيافة", "Hospitality" },
                    { new Guid("e77d3558-401c-4abc-86ba-b67dce0752f0"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("e8350e60-4622-4e3b-836e-8f769aab8861"), "التكييف", "Air conditioning" },
                    { new Guid("ea7bde52-42f1-4b8c-a107-32123b7d21d6"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("f190e44f-9fef-4c5b-bc38-2cc2659ac0b5"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("f2858a43-ca10-4cad-9069-495ea0e3821c"), "العناية بالحديقة", "Garden care" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0feeb55b-a0e2-431c-8f02-d49fe6d3b0fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45e7697e-fa9a-43b3-a060-1cb66c15af42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c19f5b29-f109-4997-b7d2-ea2ab319778a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fad39e6e-f6eb-45ae-834a-e3e0b257ca21");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0665c723-766e-4d25-8da3-c0b0fe259f96"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0bf11e8c-b5da-4fa7-8c3f-cd183a4262c3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("10484932-f8ce-4636-8ecb-5c595bcc6470"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("18a42f26-3500-47c5-9975-b5ec7b857fc9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a2d6ab8-1699-491e-826f-246def14181e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1bb89067-7d9c-41c4-aebc-5fe8aa87f965"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1f6fe9a7-fa7c-4280-9960-cd223631563a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2098900d-3019-4130-9686-b3b464026617"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2099be88-5679-4c78-b818-540d72cadc49"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2a4b1c1a-11d9-4d11-95f4-1cc67774a57e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2e2aa3b0-626e-4046-8910-249f36e46ea2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ecfc6fb-2c18-4feb-a4de-4a7cd9cf60c5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("309207c9-6e0a-4a42-850f-1b6770b3315d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3b05f54f-68b9-4b13-ad3c-031716493fae"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3d6b49d2-1acd-46d2-be77-288a6e83a13e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e36176d-c136-4c65-8b76-eca7ab4aa0b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("638c76a9-b0bb-4c3a-976d-49d948214213"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("669409a4-524d-43e4-b47a-90e8bae6384e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("675ba7f8-ff18-4772-9279-ecf4b9751c93"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("68780f16-c3e4-4147-a442-228b1cf29d1f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7593cbd7-3e68-42b3-9d2d-2fe81820395a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7687fd48-643e-4b42-90ce-298e35c2bf51"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("78f0b1d4-736c-419b-997c-a6ef4575978f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("81a4c225-aa6c-44f0-bbfd-a893d86bafbd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("85bb4d5d-c2f0-4c20-b891-a42b8be5647c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8fb787b5-8296-4e6d-8a61-582735f05001"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("925b642f-2089-4415-88f9-31cab861d12b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("97cc1543-1c2e-485e-937c-1d92edcd1a50"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("988c4af8-9236-47f4-b791-cc4ca4a7871f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9ac0103f-c2e8-4589-883f-878546bb8c5c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e7ee80b-706f-4dbc-adcf-5070c82a0cad"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9f8b990b-0086-4c94-9a96-2944d48e517e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a86876e9-1efa-4160-82ca-c5c3590af483"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b1f32c2b-1d6b-4b4a-889f-009714d29aa3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b6ddaec7-d474-408c-bb62-4101589a113b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c346a2b0-3d55-487d-adaf-008bb8f27fd9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ce6d39dc-e1c5-4047-a0db-b7563121fac8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d1073084-17b4-4594-8cf9-6f9f6fa25fcd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d32b0634-cce0-47e4-add8-878c45bd511d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d64b84e4-559c-48eb-84a8-db75dc5ff07e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dd5ed062-3a55-4481-90c9-a81547236410"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de28af84-91c8-474d-96cb-a7918460d780"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("deac164d-443f-40a4-8977-0c31ffbc47e1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e77d3558-401c-4abc-86ba-b67dce0752f0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e8350e60-4622-4e3b-836e-8f769aab8861"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ea7bde52-42f1-4b8c-a107-32123b7d21d6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f190e44f-9fef-4c5b-bc38-2cc2659ac0b5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f2858a43-ca10-4cad-9069-495ea0e3821c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20e6e0e3-1ab3-4dc4-848c-385da4479e4e", null, "Admin", "ADMIN" },
                    { "7a6bc53b-36b8-46f6-bf8c-fc78c5c99927", null, "Vendor", "VENDOR" },
                    { "af7b2705-e605-4f54-bc9f-8576de22fd1d", null, "Customer", "CUSTOMER" },
                    { "f4366997-79f1-4c28-9dc2-e13b407d5908", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("05577694-5e88-4580-adb7-b507d041a768"), "التكييف", "Air conditioning" },
                    { new Guid("072f8b38-df15-4f0d-9bb0-3c322597659e"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("09a5b00d-98bc-44e4-b763-10365f424b65"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("0e3d87c6-7b08-491d-b955-aace20a79b47"), "المكتبات", "Libraries" },
                    { new Guid("1687e5ce-74ba-4e18-b983-9d46a50b22ba"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("1f8e083c-171c-4209-8e50-0e1ed1505a7b"), "العقارات", "Real estate" },
                    { new Guid("2128baaa-2310-4cc3-b3a8-818fe094922f"), "خدمات النقل", "Transportation services" },
                    { new Guid("22fed7dc-06ed-490a-b283-26d0cbc47856"), "تأمين", "Insurance" },
                    { new Guid("24c5d132-a645-4f93-beb3-e09c7e376599"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("25175465-c915-4ae3-bbfb-ff4b9b9d890b"), "كهرباء", "Electricity" },
                    { new Guid("2bc01b8a-44bb-40f3-af78-1cf5745d84be"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("2c98c046-773a-4160-889b-2f5307458bbc"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("34279a13-65cc-4bd7-a206-8ad203331132"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("37d42ead-6640-4faf-a85d-ad31079f58f8"), "البناء", "Construction" },
                    { new Guid("3dbf1f2a-2aa9-43a5-98ba-9c1dd965cf76"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("473c38b7-d512-4099-99c4-00ab0ded5f69"), "سباكة", "Plumbing" },
                    { new Guid("4b84ea6f-b13f-40fe-b30b-9054aa4e1b46"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("57213f39-9b0c-4448-b4b4-07f967d3ade3"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("578ec31a-e8cc-469d-aaa5-16a6ee3b8a80"), "نقاشة", "Painter" },
                    { new Guid("5dc3f9b7-c953-46b1-ad55-f4c6dce828dd"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("5eee76e1-aa12-48c5-84f7-27951986ccef"), "نجارة", "Carpenter " },
                    { new Guid("65e863c7-3cd8-4684-9ec8-5a302b87a4d4"), "خدمات التجميل", "Beauty services" },
                    { new Guid("6d7e1fb7-83bd-4af2-abae-9c6e49b9ae12"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("711c9745-5c78-43b1-b0c0-3db2f24e6b45"), "إدارة المكاتب", "Office management" },
                    { new Guid("71e8d611-8d88-4f3d-add2-331dcc699de6"), "الرياضة", "Sports" },
                    { new Guid("780df81d-c803-4393-9597-63f42654771f"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("7978c709-9d84-4624-bbc2-9a35d396cfa7"), "خدمات حكومية", "Government services" },
                    { new Guid("7afbaefb-9460-4d64-b453-37a13c9c370c"), "خدمات أخرى", "Other services" },
                    { new Guid("9201c348-b1bd-4c87-a713-96dffd783969"), "خدمات قانونية", "Legal services" },
                    { new Guid("9af536a2-6da8-427c-86f5-425e32959eca"), "رعاية الأطفال", "Childcare" },
                    { new Guid("a237f048-7705-4be1-b9b1-a28f44251b28"), "العناية بالحديقة", "Garden care" },
                    { new Guid("ad94427c-8a24-428d-aaac-3b8a082c556d"), "الخدمات المالية", "Financial services" },
                    { new Guid("b254524c-4929-4595-994f-c087070f9957"), "الخدمات الطبية", "Medical services" },
                    { new Guid("bdd09a87-b380-4ad2-8b14-c040662e7942"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("c354fad8-66eb-4d67-9078-a64f826266ec"), "تقديم الطعام", "Catering " },
                    { new Guid("c3db72b6-56d7-4970-97ed-f496fb7bd142"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("c5cbd767-6af6-464e-8130-dfc19219833e"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("cd6b1db3-fc8c-4203-b655-222585778b22"), "ترفيه", "Entertainment" },
                    { new Guid("d073f4ce-3e15-4ca8-825c-7499d47ca7db"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("d30aa20d-cd46-433e-a58b-d6d868361862"), "خدمات الترجمة", "Translation services" },
                    { new Guid("d3fc95f1-f2a2-4ff4-b7d5-7e26f07af832"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("d578d549-af29-4118-b110-ef47f340de91"), "تسقيف", "Roofing" },
                    { new Guid("d857c947-6c8e-43cf-9810-ad1fc5dcc09b"), "إستشارات", "Consulting " },
                    { new Guid("db1daeac-0cb6-4fb7-98b8-e8add9732fd8"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("e7d2b0ea-7b28-486e-b714-c145ddce90fa"), "ضيافة", "Hospitality" },
                    { new Guid("eb592ead-ea9a-4f1f-9dc1-55ff27b562d6"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("ed639b6e-ba4c-4d17-8a6c-c2ce2ccc1980"), "المحاسبة", "Accounting" },
                    { new Guid("f42319f4-cab2-4bf2-a033-ed12a0d165ca"), "خدمات غسيل الملابس", "Laundry services" }
                });
        }
    }
}
