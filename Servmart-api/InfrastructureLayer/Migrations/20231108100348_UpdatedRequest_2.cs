using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequest_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_AspNetUsers_UserId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e3a7a88-6b7f-462f-b36a-788537e75cd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65cbbe40-89ac-4174-9c2f-5944cf5bdabe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c55cb2cf-621a-475e-a803-81a8360195c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c706ff24-c574-4dfd-9089-a11a4babd219");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("06620dc1-4f7b-480d-8975-396b0d9f39f4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("09e37b91-61ed-4361-8ac6-47adfaf09769"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0a5c10eb-2326-4e4f-9404-ff5b77a0e110"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0adb3e59-8089-4b9e-9d75-6742f22bca4c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0bafff88-b191-44df-a1bd-0ced7efaa464"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0cc654d5-fc03-44f3-bea8-17a48682a26d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0cfa0d39-d73d-45d3-a246-1eb79a26b84f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0f1af7b4-87f2-43d0-9a93-521f4046154e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e61d5e6-7c5f-4738-93ff-fb7cece71c8d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21293c58-8978-4acd-8b55-77d129670e3b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("293b6620-10e0-433a-a2b4-6994f85d4a3b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3119e8c4-8a65-458f-a3f4-c31dd82569e4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("34e32c40-7739-457b-b347-113a916ded61"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3bbbcd2c-9280-4ad9-a950-8e4da5795a0b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("42935cf9-8039-4977-80f5-e5c12461833d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4f1a6361-a73b-4869-b30b-1c340fe9eabe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4f8e2433-f937-4c19-b01d-001bfc72561e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5cbc79b6-a63a-40b6-87be-f0de7a24d6ea"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6989d5e7-4e70-466d-b107-f0bb667001e5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6a7ff909-c548-46bf-a276-c180114525ff"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("73790c1c-84dd-4baa-be5d-e2196b738914"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7445c5dd-fc84-4968-b771-0d2093b9bd6c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("80ae1157-9edd-40c3-a458-1d6de21aad22"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82147460-45dd-4e85-b505-3247ceb28dc2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("89b866bb-59f3-4169-8881-3f1c5eca5476"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("93e1c242-cdfb-44f3-b87d-bb2580464b49"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("996954c1-e0d7-4bb8-8a61-19fb724688cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e79e1d2-3e54-4bc0-b6cd-a225af6545d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a038c51d-46b4-4672-a67a-413ba0b636ee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad57f44a-00ed-4b66-acb5-4d8ce0e5fa06"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ae7c336f-050a-43af-9d8b-6c95df3b7e49"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b07d0e5a-e15e-499c-ad3c-904a5f1a5f23"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b34a83a4-81a5-49d2-af57-5b18d30b8b73"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b3ab6782-6c72-4861-a37c-153f7a7ae72f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b3fc05a6-8549-4d8c-a040-e9560339bdb0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b8c79184-2e40-4c3c-a542-efa76f4db010"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b908aef5-c7d0-493c-99c4-0e089a9d745b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bc0aaae3-443b-4e45-a407-3d76a779c85d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("be21c433-2b2a-47cd-8f1f-0df0e5f7d68c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ce6d82c4-e7f8-44ee-86d6-bb2280e44b6a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d41ad544-f57e-4e48-ba22-e8a430f54b76"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dc2353de-8b7f-4fd1-ad76-9837a5a069e2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dcf11a46-26a1-489e-a02c-920ae33fb949"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de129eff-2aff-4173-8523-bd653adecd2b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("eaa3bc9c-d980-4787-aa3b-71cc1a3dbebf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("eb47d258-1b98-47fc-b9b5-a60d2f82d34d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f140e04b-12ee-4ec5-93fa-f8149f4db939"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f9eead7d-8785-4242-9b23-20fb348736d4"));

            migrationBuilder.DropColumn(
                name: "CleintID",
                schema: "Service",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Service",
                table: "Request",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Request_UserId",
                schema: "Service",
                table: "Request",
                newName: "IX_Request_UserID");

            migrationBuilder.AddColumn<string>(
                name: "PicUrl",
                schema: "Service",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                schema: "Service",
                table: "Request",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProviderId",
                schema: "Service",
                table: "Request",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15920f26-b71f-4308-bd43-635bfdf57bc2", null, "Admin", "ADMIN" },
                    { "2fd7d6e7-36b4-4286-add8-870a71f5c810", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "6b239fa8-a30b-4203-9446-9f1a5127e87d", null, "Vendor", "VENDOR" },
                    { "a82095ee-66ea-4ac7-94b0-f18debb9e96d", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0c1fb553-d88f-4227-afc9-f27a2f7160b8"), "كهرباء", "Electricity" },
                    { new Guid("0ea6876e-1d41-4131-a920-18e58f5bff6e"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("128e742e-dfd4-45a8-a03e-70344317d10a"), "الرياضة", "Sports" },
                    { new Guid("1a943679-78a2-4419-b794-7967b9673521"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("1bdcc770-4a58-408d-8827-848979b7c138"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("2734f5fd-f2c6-41fa-a661-229de6bd5ceb"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("292635d5-d5ff-4453-8b67-5e8f826ee335"), "تأمين", "Insurance" },
                    { new Guid("29fb0450-9aec-4765-ba6d-8d3a309634b7"), "الخدمات الطبية", "Medical services" },
                    { new Guid("2cc2db43-6429-4cd3-a834-767cfde27432"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("2d50f566-43f0-4995-8466-3c36a6d7d8e1"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("3ba26192-a442-4b8e-9266-17f7e06f3fee"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("4392e978-1bdd-4b27-a9ba-739dc45f29aa"), "خدمات قانونية", "Legal services" },
                    { new Guid("48143f30-9ee4-42b3-9edd-c78bf1e5aaa4"), "الخدمات المالية", "Financial services" },
                    { new Guid("57083922-e551-403a-ab6a-afc2164a5b4a"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("640f8789-0cee-4746-b33d-a6a846bd5a4e"), "ترفيه", "Entertainment" },
                    { new Guid("64b2a98d-e5e6-43db-bbd8-9012d84152c4"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("64e82cd3-0504-468b-89fe-f072d9c1c190"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("68f32415-6488-4b9e-8518-c76d99fb6b8b"), "خدمات التجميل", "Beauty services" },
                    { new Guid("6e5bb700-c5e3-4aa9-8106-548c262a1939"), "التكييف", "Air conditioning" },
                    { new Guid("6fefcb91-0272-4550-b058-cfa06ca18e9c"), "رعاية الأطفال", "Childcare" },
                    { new Guid("70e8d4de-3fc5-4be2-8936-7ce556493bd4"), "المحاسبة", "Accounting" },
                    { new Guid("77377072-1dd9-4d6d-a9d0-14fc516a1aba"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("7b7c826b-2882-4738-95a9-0d0a3654845c"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("8823c602-b7d3-4ea6-abf8-62b50fa3078a"), "إدارة المكاتب", "Office management" },
                    { new Guid("8a14c71a-bd4d-4b6a-8a97-49f1637c17df"), "العقارات", "Real estate" },
                    { new Guid("8a36d739-fd10-4b50-ba70-e65ce48d5220"), "خدمات النقل", "Transportation services" },
                    { new Guid("8c395b79-5051-477f-b107-99d3e1104d6b"), "نقاشة", "Painter" },
                    { new Guid("92f92c0d-31b3-4ede-a4d6-92c30a407a85"), "ضيافة", "Hospitality" },
                    { new Guid("95e8809f-2a1f-4593-883d-370ceef2a69c"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("99955374-6dc9-4abb-8275-012e543cce23"), "العناية بالحديقة", "Garden care" },
                    { new Guid("a4313278-fc89-4191-92da-bb181b5dda3a"), "نجارة", "Carpenter " },
                    { new Guid("a833f8dc-c1b2-46e0-b016-1423fb6d8e89"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("ab691ba0-bb79-480f-85b9-22d1f1666b5b"), "سباكة", "Plumbing" },
                    { new Guid("ab6e469f-9c7b-418e-88d1-46d9d0d9a9d2"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("ae703202-615d-4bea-bdcd-53a453d510c1"), "تسقيف", "Roofing" },
                    { new Guid("b4e62b9d-bbcc-4255-9632-193c60d25b9a"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("b7bc9556-13bf-4b63-98ab-ef2ad546b15c"), "خدمات الترجمة", "Translation services" },
                    { new Guid("ccbaa1f9-2240-4b23-b792-f42f9f8b22d1"), "تقديم الطعام", "Catering " },
                    { new Guid("cddb1f04-ed93-420c-8347-3546454c2c63"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("d25c8935-928a-4b95-bf39-27bdc95b132a"), "إستشارات", "Consulting " },
                    { new Guid("d4699694-790e-4246-b393-1f4b1138a169"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("d55fabfe-c9cf-4b30-9ded-63a7d5b6717f"), "خدمات أخرى", "Other services" },
                    { new Guid("dee92355-1fdc-44fb-9fea-1bb226b6e141"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("edb08d6e-4baa-45fa-9b05-74240ca5deee"), "خدمات حكومية", "Government services" },
                    { new Guid("ee5d1ebf-02c0-4975-9a6e-725a0304369c"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("f6e43a55-38a2-4627-a731-e7ccb517b0e6"), "البناء", "Construction" },
                    { new Guid("f91e7720-ee4a-4d98-9c0c-97188b8d0745"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("f9eeb938-a7e1-45f7-87af-ba440fc234e6"), "المكتبات", "Libraries" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Request_ProviderId",
                schema: "Service",
                table: "Request",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_AspNetUsers_ProviderId",
                schema: "Service",
                table: "Request",
                column: "ProviderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_AspNetUsers_UserID",
                schema: "Service",
                table: "Request",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_AspNetUsers_ProviderId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_AspNetUsers_UserID",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_ProviderId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15920f26-b71f-4308-bd43-635bfdf57bc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd7d6e7-36b4-4286-add8-870a71f5c810");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b239fa8-a30b-4203-9446-9f1a5127e87d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a82095ee-66ea-4ac7-94b0-f18debb9e96d");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0c1fb553-d88f-4227-afc9-f27a2f7160b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0ea6876e-1d41-4131-a920-18e58f5bff6e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("128e742e-dfd4-45a8-a03e-70344317d10a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a943679-78a2-4419-b794-7967b9673521"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1bdcc770-4a58-408d-8827-848979b7c138"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2734f5fd-f2c6-41fa-a661-229de6bd5ceb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("292635d5-d5ff-4453-8b67-5e8f826ee335"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("29fb0450-9aec-4765-ba6d-8d3a309634b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2cc2db43-6429-4cd3-a834-767cfde27432"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2d50f566-43f0-4995-8466-3c36a6d7d8e1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3ba26192-a442-4b8e-9266-17f7e06f3fee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4392e978-1bdd-4b27-a9ba-739dc45f29aa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("48143f30-9ee4-42b3-9edd-c78bf1e5aaa4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57083922-e551-403a-ab6a-afc2164a5b4a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("640f8789-0cee-4746-b33d-a6a846bd5a4e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("64b2a98d-e5e6-43db-bbd8-9012d84152c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("64e82cd3-0504-468b-89fe-f072d9c1c190"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("68f32415-6488-4b9e-8518-c76d99fb6b8b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6e5bb700-c5e3-4aa9-8106-548c262a1939"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6fefcb91-0272-4550-b058-cfa06ca18e9c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("70e8d4de-3fc5-4be2-8936-7ce556493bd4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("77377072-1dd9-4d6d-a9d0-14fc516a1aba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7b7c826b-2882-4738-95a9-0d0a3654845c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8823c602-b7d3-4ea6-abf8-62b50fa3078a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a14c71a-bd4d-4b6a-8a97-49f1637c17df"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a36d739-fd10-4b50-ba70-e65ce48d5220"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8c395b79-5051-477f-b107-99d3e1104d6b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("92f92c0d-31b3-4ede-a4d6-92c30a407a85"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95e8809f-2a1f-4593-883d-370ceef2a69c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("99955374-6dc9-4abb-8275-012e543cce23"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a4313278-fc89-4191-92da-bb181b5dda3a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a833f8dc-c1b2-46e0-b016-1423fb6d8e89"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ab691ba0-bb79-480f-85b9-22d1f1666b5b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ab6e469f-9c7b-418e-88d1-46d9d0d9a9d2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ae703202-615d-4bea-bdcd-53a453d510c1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b4e62b9d-bbcc-4255-9632-193c60d25b9a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b7bc9556-13bf-4b63-98ab-ef2ad546b15c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ccbaa1f9-2240-4b23-b792-f42f9f8b22d1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cddb1f04-ed93-420c-8347-3546454c2c63"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d25c8935-928a-4b95-bf39-27bdc95b132a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d4699694-790e-4246-b393-1f4b1138a169"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d55fabfe-c9cf-4b30-9ded-63a7d5b6717f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dee92355-1fdc-44fb-9fea-1bb226b6e141"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("edb08d6e-4baa-45fa-9b05-74240ca5deee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ee5d1ebf-02c0-4975-9a6e-725a0304369c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f6e43a55-38a2-4627-a731-e7ccb517b0e6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f91e7720-ee4a-4d98-9c0c-97188b8d0745"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f9eeb938-a7e1-45f7-87af-ba440fc234e6"));

            migrationBuilder.DropColumn(
                name: "PicUrl",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                schema: "Service",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "UserID",
                schema: "Service",
                table: "Request",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_UserID",
                schema: "Service",
                table: "Request",
                newName: "IX_Request_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "Service",
                table: "Request",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CleintID",
                schema: "Service",
                table: "Request",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e3a7a88-6b7f-462f-b36a-788537e75cd6", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "65cbbe40-89ac-4174-9c2f-5944cf5bdabe", null, "Admin", "ADMIN" },
                    { "c55cb2cf-621a-475e-a803-81a8360195c2", null, "Customer", "CUSTOMER" },
                    { "c706ff24-c574-4dfd-9089-a11a4babd219", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("06620dc1-4f7b-480d-8975-396b0d9f39f4"), "العقارات", "Real estate" },
                    { new Guid("09e37b91-61ed-4361-8ac6-47adfaf09769"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("0a5c10eb-2326-4e4f-9404-ff5b77a0e110"), "خدمات الترجمة", "Translation services" },
                    { new Guid("0adb3e59-8089-4b9e-9d75-6742f22bca4c"), "سباكة", "Plumbing" },
                    { new Guid("0bafff88-b191-44df-a1bd-0ced7efaa464"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("0cc654d5-fc03-44f3-bea8-17a48682a26d"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("0cfa0d39-d73d-45d3-a246-1eb79a26b84f"), "خدمات النقل", "Transportation services" },
                    { new Guid("0f1af7b4-87f2-43d0-9a93-521f4046154e"), "الخدمات الطبية", "Medical services" },
                    { new Guid("1e61d5e6-7c5f-4738-93ff-fb7cece71c8d"), "خدمات قانونية", "Legal services" },
                    { new Guid("21293c58-8978-4acd-8b55-77d129670e3b"), "العناية بالحديقة", "Garden care" },
                    { new Guid("293b6620-10e0-433a-a2b4-6994f85d4a3b"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("3119e8c4-8a65-458f-a3f4-c31dd82569e4"), "نقاشة", "Painter" },
                    { new Guid("34e32c40-7739-457b-b347-113a916ded61"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("3bbbcd2c-9280-4ad9-a950-8e4da5795a0b"), "خدمات التجميل", "Beauty services" },
                    { new Guid("42935cf9-8039-4977-80f5-e5c12461833d"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("4f1a6361-a73b-4869-b30b-1c340fe9eabe"), "رعاية الأطفال", "Childcare" },
                    { new Guid("4f8e2433-f937-4c19-b01d-001bfc72561e"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("5cbc79b6-a63a-40b6-87be-f0de7a24d6ea"), "إستشارات", "Consulting " },
                    { new Guid("6989d5e7-4e70-466d-b107-f0bb667001e5"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("6a7ff909-c548-46bf-a276-c180114525ff"), "المحاسبة", "Accounting" },
                    { new Guid("73790c1c-84dd-4baa-be5d-e2196b738914"), "كهرباء", "Electricity" },
                    { new Guid("7445c5dd-fc84-4968-b771-0d2093b9bd6c"), "البناء", "Construction" },
                    { new Guid("80ae1157-9edd-40c3-a458-1d6de21aad22"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("82147460-45dd-4e85-b505-3247ceb28dc2"), "الرياضة", "Sports" },
                    { new Guid("89b866bb-59f3-4169-8881-3f1c5eca5476"), "تأمين", "Insurance" },
                    { new Guid("93e1c242-cdfb-44f3-b87d-bb2580464b49"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("996954c1-e0d7-4bb8-8a61-19fb724688cd"), "ترفيه", "Entertainment" },
                    { new Guid("9e79e1d2-3e54-4bc0-b6cd-a225af6545d0"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("a038c51d-46b4-4672-a67a-413ba0b636ee"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("ad57f44a-00ed-4b66-acb5-4d8ce0e5fa06"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("ae7c336f-050a-43af-9d8b-6c95df3b7e49"), "المكتبات", "Libraries" },
                    { new Guid("b07d0e5a-e15e-499c-ad3c-904a5f1a5f23"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("b34a83a4-81a5-49d2-af57-5b18d30b8b73"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("b3ab6782-6c72-4861-a37c-153f7a7ae72f"), "ضيافة", "Hospitality" },
                    { new Guid("b3fc05a6-8549-4d8c-a040-e9560339bdb0"), "خدمات حكومية", "Government services" },
                    { new Guid("b8c79184-2e40-4c3c-a542-efa76f4db010"), "الخدمات المالية", "Financial services" },
                    { new Guid("b908aef5-c7d0-493c-99c4-0e089a9d745b"), "خدمات أخرى", "Other services" },
                    { new Guid("bc0aaae3-443b-4e45-a407-3d76a779c85d"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("be21c433-2b2a-47cd-8f1f-0df0e5f7d68c"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("ce6d82c4-e7f8-44ee-86d6-bb2280e44b6a"), "تقديم الطعام", "Catering " },
                    { new Guid("d41ad544-f57e-4e48-ba22-e8a430f54b76"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("dc2353de-8b7f-4fd1-ad76-9837a5a069e2"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("dcf11a46-26a1-489e-a02c-920ae33fb949"), "التكييف", "Air conditioning" },
                    { new Guid("de129eff-2aff-4173-8523-bd653adecd2b"), "إدارة المكاتب", "Office management" },
                    { new Guid("eaa3bc9c-d980-4787-aa3b-71cc1a3dbebf"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("eb47d258-1b98-47fc-b9b5-a60d2f82d34d"), "نجارة", "Carpenter " },
                    { new Guid("f140e04b-12ee-4ec5-93fa-f8149f4db939"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("f9eead7d-8785-4242-9b23-20fb348736d4"), "تسقيف", "Roofing" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Request_AspNetUsers_UserId",
                schema: "Service",
                table: "Request",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
