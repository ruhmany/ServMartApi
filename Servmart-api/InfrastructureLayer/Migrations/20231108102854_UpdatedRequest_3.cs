using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequest_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedia_Request_RequestImagesID",
                schema: "Service",
                table: "RequestMedia");

            migrationBuilder.DropIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia");

            migrationBuilder.DropIndex(
                name: "IX_RequestMedia_RequestImagesID",
                schema: "Service",
                table: "RequestMedia");

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
                name: "RequestImagesID",
                schema: "Service",
                table: "RequestMedia");

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

            migrationBuilder.CreateIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia");

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

            migrationBuilder.AddColumn<Guid>(
                name: "RequestImagesID",
                schema: "Service",
                table: "RequestMedia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestMedia_RequestImagesID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestImagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedia_Request_RequestImagesID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestImagesID",
                principalSchema: "Service",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
