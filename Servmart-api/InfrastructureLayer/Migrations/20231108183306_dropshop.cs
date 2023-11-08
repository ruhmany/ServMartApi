using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class dropshop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Shope");
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Shop",
                schema: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Product_ShopID",
                schema: "Product",
                table: "Product");

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

            migrationBuilder.DropColumn(
                name: "ShopID",
                schema: "Product",
                table: "Product");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36046522-9000-45dd-bae7-acd0efa7d2b5", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "c38df88b-f941-42e4-838c-02d127b2ae30", null, "Admin", "ADMIN" },
                    { "cc14ea8f-9628-4e5d-b093-cdb74e2191c2", null, "Vendor", "VENDOR" },
                    { "d00ba307-b631-41cd-8c0f-bff336855e7d", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("16fb0a80-0e70-4e25-9b3e-a324509b6e05"), "التكييف", "Air conditioning" },
                    { new Guid("1741bc6d-ec68-446d-94e1-d4aecd561e36"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("18079133-8785-41e5-b5f5-fabf4fb10b18"), "العقارات", "Real estate" },
                    { new Guid("181864d5-a076-4352-9bb3-b53147ca332f"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("1a3953c0-f684-4950-b419-5e7700bd70c2"), "خدمات الترجمة", "Translation services" },
                    { new Guid("1f9c4832-27f1-4b8f-b290-3744d4b95682"), "المحاسبة", "Accounting" },
                    { new Guid("205e8820-a582-4a23-b3d5-53468f3e7836"), "إدارة المكاتب", "Office management" },
                    { new Guid("225836c6-a8ac-4bc8-b43c-6e08e5c9e238"), "الخدمات المالية", "Financial services" },
                    { new Guid("22cc6e5b-7490-450c-b9e7-8f1ee4f2a9d0"), "نجارة", "Carpenter " },
                    { new Guid("23b506f9-e771-4401-83ed-69efb7866a7f"), "العناية بالحديقة", "Garden care" },
                    { new Guid("245db055-5be5-471f-8d02-60e21263e435"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("2a052784-8c38-41a3-bcb4-75349c149545"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("33bcccc9-3ec9-47b6-9bb4-9a6a4263123c"), "ضيافة", "Hospitality" },
                    { new Guid("39ef6738-4434-477c-b944-451d8c4c646e"), "تسقيف", "Roofing" },
                    { new Guid("3adc77ed-dc79-4d97-b32b-e23082354df2"), "كهرباء", "Electricity" },
                    { new Guid("3b21dcb4-ac5c-4ece-bb90-871fc05f0e5b"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("43ea848e-d0bb-40bc-9655-d9ea6dd4994e"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("4e17c671-ec8c-483c-aea7-abe8df54c604"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("4f2785fd-7a73-4d60-8d6e-d63f4c7f522f"), "سباكة", "Plumbing" },
                    { new Guid("6dff5dcc-dfba-4372-ac7f-21167707ad35"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("7733e7c1-cc27-4065-a234-aa54ce88179d"), "تقديم الطعام", "Catering " },
                    { new Guid("776c4a42-83ee-4ddb-abcf-684271763ba3"), "خدمات قانونية", "Legal services" },
                    { new Guid("7bbd1612-c1a9-41f7-b41e-90ac0cf9f169"), "البناء", "Construction" },
                    { new Guid("81c444db-3941-4bf5-8db0-482228fb60df"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("8353814b-7bda-4982-bc7f-514dcea7bb8b"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("8a6f1033-280d-4995-bb20-b30a45444c7b"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("8b4b181e-98cd-4c7b-9303-26a59403a14d"), "المكتبات", "Libraries" },
                    { new Guid("8d00d56c-cb50-4897-80eb-137277f1a512"), "خدمات النقل", "Transportation services" },
                    { new Guid("8fd23606-a77d-44f9-ab13-527cc7a49fa1"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("954cab86-ef91-4710-83d4-b8248c1029a4"), "ترفيه", "Entertainment" },
                    { new Guid("9954a9c9-dd9e-456f-ba56-e0c7a02a0383"), "الخدمات الطبية", "Medical services" },
                    { new Guid("9df8297b-4454-4ff5-abfa-d53a2584ed79"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("9e46c362-20dd-449a-8f16-45040b096535"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("a9b0b31f-65e0-41e0-9a55-53ae5849a27a"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("bde50830-6d99-49bf-9728-0696df1ba159"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("cdb99924-6d10-4f29-950b-1781e70210ef"), "خدمات التجميل", "Beauty services" },
                    { new Guid("ceae47fb-bd6a-45ea-b76a-450fa01bb400"), "خدمات أخرى", "Other services" },
                    { new Guid("cf21d047-a5ff-45c1-a3aa-42ff0ee75e8c"), "الرياضة", "Sports" },
                    { new Guid("d183fe58-8036-43d6-946b-c09deac859e0"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("d5092d39-bf2e-4029-a6fc-a111b0b47d4b"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("d9076eec-bcc1-4f9c-b549-45c74bb8c67c"), "نقاشة", "Painter" },
                    { new Guid("d974166a-c722-41d6-a433-e8a6c02002e2"), "إستشارات", "Consulting " },
                    { new Guid("df9e7ba5-08a7-49e8-839b-934f5ac0968e"), "رعاية الأطفال", "Childcare" },
                    { new Guid("e176bcf6-4ee9-41e0-9d22-affb23243f2a"), "تأمين", "Insurance" },
                    { new Guid("e2c4a2ec-ad90-41ef-a607-75a7f9da058c"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("e4004905-5e5c-4641-97dc-6a92c5d5a1dd"), "خدمات حكومية", "Government services" },
                    { new Guid("ea297806-e526-415f-8fe5-757c0febec72"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("f935bebb-0b44-4384-9ea1-6a07f5216356"), "التخطيط للأحداث", "Event planning" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36046522-9000-45dd-bae7-acd0efa7d2b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c38df88b-f941-42e4-838c-02d127b2ae30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc14ea8f-9628-4e5d-b093-cdb74e2191c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d00ba307-b631-41cd-8c0f-bff336855e7d");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("16fb0a80-0e70-4e25-9b3e-a324509b6e05"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1741bc6d-ec68-446d-94e1-d4aecd561e36"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("18079133-8785-41e5-b5f5-fabf4fb10b18"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("181864d5-a076-4352-9bb3-b53147ca332f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a3953c0-f684-4950-b419-5e7700bd70c2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1f9c4832-27f1-4b8f-b290-3744d4b95682"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("205e8820-a582-4a23-b3d5-53468f3e7836"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("225836c6-a8ac-4bc8-b43c-6e08e5c9e238"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("22cc6e5b-7490-450c-b9e7-8f1ee4f2a9d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("23b506f9-e771-4401-83ed-69efb7866a7f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("245db055-5be5-471f-8d02-60e21263e435"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2a052784-8c38-41a3-bcb4-75349c149545"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("33bcccc9-3ec9-47b6-9bb4-9a6a4263123c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("39ef6738-4434-477c-b944-451d8c4c646e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3adc77ed-dc79-4d97-b32b-e23082354df2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3b21dcb4-ac5c-4ece-bb90-871fc05f0e5b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("43ea848e-d0bb-40bc-9655-d9ea6dd4994e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e17c671-ec8c-483c-aea7-abe8df54c604"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4f2785fd-7a73-4d60-8d6e-d63f4c7f522f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6dff5dcc-dfba-4372-ac7f-21167707ad35"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7733e7c1-cc27-4065-a234-aa54ce88179d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("776c4a42-83ee-4ddb-abcf-684271763ba3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7bbd1612-c1a9-41f7-b41e-90ac0cf9f169"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("81c444db-3941-4bf5-8db0-482228fb60df"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8353814b-7bda-4982-bc7f-514dcea7bb8b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a6f1033-280d-4995-bb20-b30a45444c7b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8b4b181e-98cd-4c7b-9303-26a59403a14d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8d00d56c-cb50-4897-80eb-137277f1a512"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8fd23606-a77d-44f9-ab13-527cc7a49fa1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("954cab86-ef91-4710-83d4-b8248c1029a4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9954a9c9-dd9e-456f-ba56-e0c7a02a0383"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9df8297b-4454-4ff5-abfa-d53a2584ed79"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e46c362-20dd-449a-8f16-45040b096535"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a9b0b31f-65e0-41e0-9a55-53ae5849a27a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bde50830-6d99-49bf-9728-0696df1ba159"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cdb99924-6d10-4f29-950b-1781e70210ef"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ceae47fb-bd6a-45ea-b76a-450fa01bb400"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf21d047-a5ff-45c1-a3aa-42ff0ee75e8c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d183fe58-8036-43d6-946b-c09deac859e0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d5092d39-bf2e-4029-a6fc-a111b0b47d4b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d9076eec-bcc1-4f9c-b549-45c74bb8c67c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d974166a-c722-41d6-a433-e8a6c02002e2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df9e7ba5-08a7-49e8-839b-934f5ac0968e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e176bcf6-4ee9-41e0-9d22-affb23243f2a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e2c4a2ec-ad90-41ef-a607-75a7f9da058c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e4004905-5e5c-4641-97dc-6a92c5d5a1dd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ea297806-e526-415f-8fe5-757c0febec72"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f935bebb-0b44-4384-9ea1-6a07f5216356"));

            migrationBuilder.EnsureSchema(
                name: "Shop");

            migrationBuilder.AddColumn<Guid>(
                name: "ShopID",
                schema: "Product",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shop",
                schema: "Shop",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shop_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Product_ShopID",
                schema: "Product",
                table: "Product",
                column: "ShopID");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_UserID",
                schema: "Shop",
                table: "Shop",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product",
                column: "ShopID",
                principalSchema: "Shop",
                principalTable: "Shop",
                principalColumn: "ID");
        }
    }
}
