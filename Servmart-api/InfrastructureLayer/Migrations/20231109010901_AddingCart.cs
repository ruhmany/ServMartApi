using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ca193d-1987-444a-8236-f49ee1a0c5fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3827e480-4024-4157-ba18-a6bf64effdde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ea73a3f-c411-4e3e-8265-a52e769d4ced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb3a9817-8a94-4f06-b70d-cc9df0c8eb99");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0ab123cc-9f25-45eb-95b9-63bc7f736816"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0d8e1d9c-6183-41c3-809f-7dfb683331ec"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("10b7e800-e6ca-4d1e-aafa-f84136940eed"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("113fbf41-df3c-4bb9-8aca-d7280aa60da3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("16cabc64-761e-4214-ae1e-c1fd04d751b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1b24644a-14f7-4cce-88b2-01ce3ba6d0b0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1c621b4f-3ddd-4b00-a729-319b9b7ef17f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21447d13-db89-4b4a-ba63-de1984c40e2c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("26605b8d-ec81-463d-82d8-5c226456dd8f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3019ca8e-8f8a-4823-b060-14a5ac4da57a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("380da619-5290-4fa5-ab85-3134172aef75"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("45dd40a5-3b1a-4b69-bd1a-999932cada98"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("47d82bd8-53e3-47a7-bfe5-5e7104822564"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("586af569-2717-4c02-a049-2cd4b796b66d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("667ae0f8-3655-4a16-896b-cc333e423684"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("71602e03-551d-4fa2-9d28-9646a0c6e843"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("75ac46fd-9d3f-4378-9b02-6a84715cbe98"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7c2f7d90-9fb4-4a81-b28f-0a6ba720f84b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("83ab18b1-8cad-4d00-ac4b-01779faed78b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8437ad38-79ce-435c-b334-b3021d55598d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("854063d6-fb66-4a0c-8eaf-2d81acce7afa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("94dff266-d688-4577-9ad6-50fff3640115"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9c697de8-ede2-45a4-b731-6cb10b91d225"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9d4c3943-62be-4d19-a1f1-e5ed5100e6a1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e072b4d-2d86-480d-9b92-2d889f40ccbe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a16b064c-de96-4d3b-86f9-40c0ba5e5cf5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a2f3069b-5575-4d41-bb74-4ca4d867b53c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a43fcf21-504f-41b7-b58d-349678bce832"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a52a6fb9-3c1b-4b3a-be18-024b474289ba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a5885445-4ed4-41b0-9588-c25fb5210b4c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b90c2710-8cf7-466d-b967-d74637353114"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bb63bd01-35f6-4123-9df7-5b9e87acceaa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bd5a8a6e-0683-4cce-9bb3-c8d335ebef61"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c58cb72d-28e9-4ef4-b720-e306e614ffdf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c7a575d7-4767-4642-becd-e96ed3663e24"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d18ea9f1-04bd-43ab-8217-0d6c803aa75f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d20acc39-b8e0-4e72-a3d2-cd2c3289de97"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d227113d-7907-4147-9946-811e6f2ec988"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dd4f51d2-337c-4a15-9f23-7a726366670f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df2390f4-a2ce-487f-b8a7-c62881164e7d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e902f193-4b25-4475-98a3-fad95d2e4007"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ea2141ff-74fb-481f-9594-c05d473b18bf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f10bd98c-8732-4f50-8ebb-042cec6cb9c9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f27c0087-c96c-4d51-88c6-ace08cfc8e2f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f2c4d1e4-ae6d-4684-a67b-f7c365f94ae3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f9704502-122b-4695-825a-4b9fbb7c0883"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc6857fc-ce74-4c16-af21-d857c256762d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("feda9619-4cc1-4b20-ac57-b7e68e9195e4"));

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_ProductID",
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
                    { "271400fb-ad84-4100-a724-d2544fe8e92e", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "4a166432-aed7-4990-80bc-c0f7a02d3d8d", null, "Customer", "CUSTOMER" },
                    { "bd15cc29-a19a-4d1e-bb6b-1d0859e2c7b9", null, "Admin", "ADMIN" },
                    { "e4424f45-c0e7-4f02-bbcd-ab6ab72e6c87", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("05b4ae4e-508a-41b5-b394-7b899f3a7c06"), "تأمين", "Insurance" },
                    { new Guid("07245a59-6dc0-49eb-9215-bb246ea8526c"), "ترفيه", "Entertainment" },
                    { new Guid("111b823c-845f-4654-92fa-3c28f4765aab"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("14da5815-afd9-4663-ae6f-a51464cc5b85"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("15c016da-76db-4b50-9a3c-8016d8df2916"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("1a3b9e49-6dad-4aed-a983-42794ce29d0a"), "تقديم الطعام", "Catering " },
                    { new Guid("1e592e2d-6f58-40d0-837f-ddcf568fa344"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("22b79538-3ae3-4570-b09a-89027068a167"), "التكييف", "Air conditioning" },
                    { new Guid("236a5342-b513-4c5e-949c-2d2b68454252"), "ضيافة", "Hospitality" },
                    { new Guid("2e6c0c86-4c61-4065-95e4-56cf08099c5a"), "العقارات", "Real estate" },
                    { new Guid("2ed628a8-92df-4320-97de-7129b7ceb0a3"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("355dc03e-3661-47d1-84ed-56bdef666103"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("40d2711d-be7b-49be-b021-e3c3c954ece4"), "المحاسبة", "Accounting" },
                    { new Guid("447190ff-2e5c-4642-86b5-d76bdfe348ed"), "رعاية الأطفال", "Childcare" },
                    { new Guid("4c61bd5f-17a9-4658-96d6-a12046e9c9ae"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("4ce526e8-cf59-4610-bc0a-908279bb1440"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("536b7fe2-a3d7-4fab-b964-269fc58fef56"), "خدمات الترجمة", "Translation services" },
                    { new Guid("53b7c11c-1f0a-4a85-b932-5b644e36a4a4"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("55059ef9-ce68-4a88-aff5-effb53aa5fb5"), "سباكة", "Plumbing" },
                    { new Guid("57971369-98eb-415c-898e-35f75b76e8a2"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("5f4dcdce-284a-4f4c-8275-a12d54fc4796"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("67588fb4-9cc3-4f2f-bb4c-b01a54e38fdf"), "الرياضة", "Sports" },
                    { new Guid("73807eab-fc09-4ee7-9a60-d8201f8892b8"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("7673b1e8-4cdd-4ec2-bd6b-223352850cff"), "خدمات قانونية", "Legal services" },
                    { new Guid("78693896-b764-435a-b5da-89292b00fd9e"), "خدمات التجميل", "Beauty services" },
                    { new Guid("7b73eb1e-6d0b-48cc-99a2-02584f502c41"), "خدمات أخرى", "Other services" },
                    { new Guid("7f76bb5d-2747-448e-bc31-b42415acf3b6"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("80b0f27a-02fe-4e93-b273-49163ad9483b"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("8505768e-8376-4af0-b1ad-b96f3ee7fd05"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("87445bc2-9647-4576-8ab9-b1f53f2d3c91"), "نقاشة", "Painter" },
                    { new Guid("890b8efe-5d80-4fd6-9c6c-407e2d56dc5d"), "خدمات حكومية", "Government services" },
                    { new Guid("90f15bfd-ac13-45a6-99e7-949625673949"), "تسقيف", "Roofing" },
                    { new Guid("a3a56108-8fae-44bc-8961-fd2b489c9cf4"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("a8b00fee-d3fe-412a-ae2c-327c374bbdb3"), "إدارة المكاتب", "Office management" },
                    { new Guid("ab21e15c-ea9a-4fcf-ade4-a16bc071e7ca"), "المكتبات", "Libraries" },
                    { new Guid("ac5a23fa-cb82-4e96-8804-b395a1f5948b"), "خدمات النقل", "Transportation services" },
                    { new Guid("ac8dd77c-8eed-4ac5-9137-9b97c5c0e70b"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("b52ac6f8-e80e-4b21-b767-de59d6266a8e"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("b895aa15-4717-40dc-aa3c-dec19118f929"), "الخدمات الطبية", "Medical services" },
                    { new Guid("bc1ba78b-d555-4fd0-b24e-ffbcbb520768"), "نجارة", "Carpenter " },
                    { new Guid("cd2fef9e-26c8-4498-b362-b79fefc2cf8e"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("dbd878a0-34bd-45ee-8c4f-28b613a59fa7"), "العناية بالحديقة", "Garden care" },
                    { new Guid("e99627b4-7ab8-4e66-b6e0-4325e235da9f"), "البناء", "Construction" },
                    { new Guid("f50f80f3-5fe5-448d-bdb6-a8e05b64c2af"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("f807cd92-fe1c-4082-8fcf-5b935441af38"), "الخدمات المالية", "Financial services" },
                    { new Guid("f87bf5f1-8681-4bf0-89c0-30003459129e"), "إستشارات", "Consulting " },
                    { new Guid("fc4b894c-e095-49ce-9100-16913b35cf1b"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("fd90afac-6391-408d-b5b4-450175cbb1a7"), "كهرباء", "Electricity" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "271400fb-ad84-4100-a724-d2544fe8e92e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a166432-aed7-4990-80bc-c0f7a02d3d8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd15cc29-a19a-4d1e-bb6b-1d0859e2c7b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4424f45-c0e7-4f02-bbcd-ab6ab72e6c87");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("05b4ae4e-508a-41b5-b394-7b899f3a7c06"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("07245a59-6dc0-49eb-9215-bb246ea8526c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("111b823c-845f-4654-92fa-3c28f4765aab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("14da5815-afd9-4663-ae6f-a51464cc5b85"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("15c016da-76db-4b50-9a3c-8016d8df2916"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a3b9e49-6dad-4aed-a983-42794ce29d0a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e592e2d-6f58-40d0-837f-ddcf568fa344"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("22b79538-3ae3-4570-b09a-89027068a167"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("236a5342-b513-4c5e-949c-2d2b68454252"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2e6c0c86-4c61-4065-95e4-56cf08099c5a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ed628a8-92df-4320-97de-7129b7ceb0a3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("355dc03e-3661-47d1-84ed-56bdef666103"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("40d2711d-be7b-49be-b021-e3c3c954ece4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("447190ff-2e5c-4642-86b5-d76bdfe348ed"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4c61bd5f-17a9-4658-96d6-a12046e9c9ae"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4ce526e8-cf59-4610-bc0a-908279bb1440"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("536b7fe2-a3d7-4fab-b964-269fc58fef56"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("53b7c11c-1f0a-4a85-b932-5b644e36a4a4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("55059ef9-ce68-4a88-aff5-effb53aa5fb5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57971369-98eb-415c-898e-35f75b76e8a2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5f4dcdce-284a-4f4c-8275-a12d54fc4796"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67588fb4-9cc3-4f2f-bb4c-b01a54e38fdf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("73807eab-fc09-4ee7-9a60-d8201f8892b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7673b1e8-4cdd-4ec2-bd6b-223352850cff"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("78693896-b764-435a-b5da-89292b00fd9e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7b73eb1e-6d0b-48cc-99a2-02584f502c41"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7f76bb5d-2747-448e-bc31-b42415acf3b6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("80b0f27a-02fe-4e93-b273-49163ad9483b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8505768e-8376-4af0-b1ad-b96f3ee7fd05"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87445bc2-9647-4576-8ab9-b1f53f2d3c91"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("890b8efe-5d80-4fd6-9c6c-407e2d56dc5d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("90f15bfd-ac13-45a6-99e7-949625673949"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a3a56108-8fae-44bc-8961-fd2b489c9cf4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a8b00fee-d3fe-412a-ae2c-327c374bbdb3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ab21e15c-ea9a-4fcf-ade4-a16bc071e7ca"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ac5a23fa-cb82-4e96-8804-b395a1f5948b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ac8dd77c-8eed-4ac5-9137-9b97c5c0e70b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b52ac6f8-e80e-4b21-b767-de59d6266a8e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b895aa15-4717-40dc-aa3c-dec19118f929"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bc1ba78b-d555-4fd0-b24e-ffbcbb520768"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cd2fef9e-26c8-4498-b362-b79fefc2cf8e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dbd878a0-34bd-45ee-8c4f-28b613a59fa7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e99627b4-7ab8-4e66-b6e0-4325e235da9f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f50f80f3-5fe5-448d-bdb6-a8e05b64c2af"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f807cd92-fe1c-4082-8fcf-5b935441af38"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f87bf5f1-8681-4bf0-89c0-30003459129e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc4b894c-e095-49ce-9100-16913b35cf1b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fd90afac-6391-408d-b5b4-450175cbb1a7"));

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14ca193d-1987-444a-8236-f49ee1a0c5fe", null, "Admin", "ADMIN" },
                    { "3827e480-4024-4157-ba18-a6bf64effdde", null, "Customer", "CUSTOMER" },
                    { "8ea73a3f-c411-4e3e-8265-a52e769d4ced", null, "Vendor", "VENDOR" },
                    { "eb3a9817-8a94-4f06-b70d-cc9df0c8eb99", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0ab123cc-9f25-45eb-95b9-63bc7f736816"), "كهرباء", "Electricity" },
                    { new Guid("0d8e1d9c-6183-41c3-809f-7dfb683331ec"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("10b7e800-e6ca-4d1e-aafa-f84136940eed"), "المحاسبة", "Accounting" },
                    { new Guid("113fbf41-df3c-4bb9-8aca-d7280aa60da3"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("16cabc64-761e-4214-ae1e-c1fd04d751b8"), "خدمات التجميل", "Beauty services" },
                    { new Guid("1b24644a-14f7-4cce-88b2-01ce3ba6d0b0"), "خدمات أخرى", "Other services" },
                    { new Guid("1c621b4f-3ddd-4b00-a729-319b9b7ef17f"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("21447d13-db89-4b4a-ba63-de1984c40e2c"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("26605b8d-ec81-463d-82d8-5c226456dd8f"), "العناية بالحديقة", "Garden care" },
                    { new Guid("3019ca8e-8f8a-4823-b060-14a5ac4da57a"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("380da619-5290-4fa5-ab85-3134172aef75"), "المكتبات", "Libraries" },
                    { new Guid("45dd40a5-3b1a-4b69-bd1a-999932cada98"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("47d82bd8-53e3-47a7-bfe5-5e7104822564"), "ترفيه", "Entertainment" },
                    { new Guid("586af569-2717-4c02-a049-2cd4b796b66d"), "الخدمات المالية", "Financial services" },
                    { new Guid("667ae0f8-3655-4a16-896b-cc333e423684"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("71602e03-551d-4fa2-9d28-9646a0c6e843"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("75ac46fd-9d3f-4378-9b02-6a84715cbe98"), "الرياضة", "Sports" },
                    { new Guid("7c2f7d90-9fb4-4a81-b28f-0a6ba720f84b"), "البناء", "Construction" },
                    { new Guid("83ab18b1-8cad-4d00-ac4b-01779faed78b"), "الخدمات الطبية", "Medical services" },
                    { new Guid("8437ad38-79ce-435c-b334-b3021d55598d"), "خدمات حكومية", "Government services" },
                    { new Guid("854063d6-fb66-4a0c-8eaf-2d81acce7afa"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("94dff266-d688-4577-9ad6-50fff3640115"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("9c697de8-ede2-45a4-b731-6cb10b91d225"), "التكييف", "Air conditioning" },
                    { new Guid("9d4c3943-62be-4d19-a1f1-e5ed5100e6a1"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("9e072b4d-2d86-480d-9b92-2d889f40ccbe"), "تقديم الطعام", "Catering " },
                    { new Guid("a16b064c-de96-4d3b-86f9-40c0ba5e5cf5"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("a2f3069b-5575-4d41-bb74-4ca4d867b53c"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("a43fcf21-504f-41b7-b58d-349678bce832"), "خدمات قانونية", "Legal services" },
                    { new Guid("a52a6fb9-3c1b-4b3a-be18-024b474289ba"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("a5885445-4ed4-41b0-9588-c25fb5210b4c"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("b90c2710-8cf7-466d-b967-d74637353114"), "خدمات النقل", "Transportation services" },
                    { new Guid("bb63bd01-35f6-4123-9df7-5b9e87acceaa"), "سباكة", "Plumbing" },
                    { new Guid("bd5a8a6e-0683-4cce-9bb3-c8d335ebef61"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("c58cb72d-28e9-4ef4-b720-e306e614ffdf"), "نقاشة", "Painter" },
                    { new Guid("c7a575d7-4767-4642-becd-e96ed3663e24"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("d18ea9f1-04bd-43ab-8217-0d6c803aa75f"), "رعاية الأطفال", "Childcare" },
                    { new Guid("d20acc39-b8e0-4e72-a3d2-cd2c3289de97"), "تسقيف", "Roofing" },
                    { new Guid("d227113d-7907-4147-9946-811e6f2ec988"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("dd4f51d2-337c-4a15-9f23-7a726366670f"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("df2390f4-a2ce-487f-b8a7-c62881164e7d"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("e902f193-4b25-4475-98a3-fad95d2e4007"), "خدمات الترجمة", "Translation services" },
                    { new Guid("ea2141ff-74fb-481f-9594-c05d473b18bf"), "تأمين", "Insurance" },
                    { new Guid("f10bd98c-8732-4f50-8ebb-042cec6cb9c9"), "إستشارات", "Consulting " },
                    { new Guid("f27c0087-c96c-4d51-88c6-ace08cfc8e2f"), "العقارات", "Real estate" },
                    { new Guid("f2c4d1e4-ae6d-4684-a67b-f7c365f94ae3"), "نجارة", "Carpenter " },
                    { new Guid("f9704502-122b-4695-825a-4b9fbb7c0883"), "إدارة المكاتب", "Office management" },
                    { new Guid("fc6857fc-ce74-4c16-af21-d857c256762d"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("feda9619-4cc1-4b20-ac57-b7e68e9195e4"), "ضيافة", "Hospitality" }
                });
        }
    }
}
