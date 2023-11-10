using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class updateorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GovernorateId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "302f8e4a-23ad-428b-b3fc-4403aac8bc9d", null, "Admin", "ADMIN" },
                    { "37794f25-7995-45fa-ba2d-2980e2252030", null, "Vendor", "VENDOR" },
                    { "c5e282a7-5c2b-4fdc-90a5-0af72f5ac12a", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "e0444851-3ab1-4951-b43e-62ff847eabe5", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("063eacfe-28fe-4083-a448-937d07793912"), "خدمات حكومية", "Government services" },
                    { new Guid("0b6dff23-0055-40e9-9fa2-cbd0bb345970"), "نقاشة", "Painter" },
                    { new Guid("0d0ea98e-fc66-47b3-bb0e-db65b24aae72"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("0dc381ab-9997-4bff-9311-03a538ed7a3c"), "خدمات التجميل", "Beauty services" },
                    { new Guid("1484c7a0-d98e-4404-9f56-59df38f22549"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("1a039491-fb72-408d-b982-5f72491a0663"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("1efbf403-a783-4bd9-b93b-a8774599c68d"), "سباكة", "Plumbing" },
                    { new Guid("2c5fb4d1-ce48-4e3b-aa29-16a236b3cbdb"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("306475b5-d6c2-4a2d-9b06-895d4102522a"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("34b80ee0-8be1-406e-b515-19d9c14e425f"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("4600aa77-09a7-4d35-b48c-f3a06127c975"), "خدمات أخرى", "Other services" },
                    { new Guid("51b77e92-12fb-4cbd-87fe-dcbc2825cf25"), "المحاسبة", "Accounting" },
                    { new Guid("59057a59-5e14-411c-a58a-89d7097a8478"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("5c294219-e7c4-4c25-91bd-e676896d67b5"), "الخدمات الطبية", "Medical services" },
                    { new Guid("5d1001ec-c796-40aa-9d29-9f97aadf20ab"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("5da4ae05-cdde-477d-a4c4-39f2aa9efddf"), "إدارة المكاتب", "Office management" },
                    { new Guid("67af5381-7d6d-41e8-9c63-07bbe96ea33c"), "كهرباء", "Electricity" },
                    { new Guid("7c5802ed-29e3-4c59-a7c2-384fdc1b021b"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("836ef156-c1b4-48b3-b786-48cfb6882ca0"), "العناية بالحديقة", "Garden care" },
                    { new Guid("8a217504-9b32-4999-9d71-4ac6345b7e46"), "رعاية الأطفال", "Childcare" },
                    { new Guid("8a6abc9f-630d-4113-8d8e-c91f7dd722bf"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("8ce92106-5588-46ec-aaff-ab10762f603e"), "المكتبات", "Libraries" },
                    { new Guid("8fbffc31-febb-4d43-b588-ad843bb7c32b"), "تأمين", "Insurance" },
                    { new Guid("a2b20e18-74f7-4b42-8192-012eaf75fb20"), "ترفيه", "Entertainment" },
                    { new Guid("a8dfbfbb-1aca-490f-8db2-8d92fe67ae2a"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("a9782e11-214d-4f3b-b56a-cacf6d3e5bc3"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("b41c0fb3-920b-43ae-a9b5-be28fc4983b2"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("bcaba142-03fc-428f-977e-bcee4a52d972"), "تسقيف", "Roofing" },
                    { new Guid("bd640995-fefc-45c9-a77f-80fbc5468b16"), "البناء", "Construction" },
                    { new Guid("be5941b1-fea5-4746-a065-77322ed92f2b"), "خدمات الترجمة", "Translation services" },
                    { new Guid("c6285349-062e-419d-b1c8-f519505c5b70"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("c8fb67b7-7350-4077-9dde-0211328a7913"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("ca6d85d0-6c59-47c4-ad5c-204ec96187b7"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("ce8af60e-104a-400a-99e0-c86a0e6a1435"), "نجارة", "Carpenter " },
                    { new Guid("cec88847-92e5-4f2b-a6c0-6b9227ef497f"), "التكييف", "Air conditioning" },
                    { new Guid("ceff71d1-6a03-414c-914f-b4c09e9a3bcd"), "الخدمات المالية", "Financial services" },
                    { new Guid("d9867367-7815-45f3-98d3-27b9aac3db91"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("da4c24e9-8bd4-422e-8e80-f1d754fafee5"), "إستشارات", "Consulting " },
                    { new Guid("de2d5fa9-fdbc-4c63-8748-7115f513ca50"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("e42ed627-ddb4-4ecf-8f14-3a0b8dad30cd"), "تقديم الطعام", "Catering " },
                    { new Guid("e50fe498-3a8a-4b27-99a0-5171d7b4a841"), "خدمات قانونية", "Legal services" },
                    { new Guid("e553cb2d-9d78-4b09-9699-a7e924dc68b8"), "ضيافة", "Hospitality" },
                    { new Guid("f12f4d8b-390f-4347-87e0-b7bc29fb51ab"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("f4c3a9ff-1369-42da-9d09-d0331e19a306"), "العقارات", "Real estate" },
                    { new Guid("f97b45f3-8d5c-4bda-8d35-3fc68bb26dc0"), "الرياضة", "Sports" },
                    { new Guid("fbc45a7c-fcc0-4c07-8b75-6c0d94f6a8ef"), "خدمات النقل", "Transportation services" },
                    { new Guid("ff0df501-b88b-464d-a2c1-e1c2d2a24922"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("ff5a4604-4c8e-490e-8db4-e15edf3c643f"), "تدريب اللياقة البدنية", "Fitness training" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CityId",
                table: "Order",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_GovernorateId",
                table: "Order",
                column: "GovernorateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_City_CityId",
                table: "Order",
                column: "CityId",
                principalSchema: "Address",
                principalTable: "City",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Governorate_GovernorateId",
                table: "Order",
                column: "GovernorateId",
                principalSchema: "Address",
                principalTable: "Governorate",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_City_CityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Governorate_GovernorateId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CityId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_GovernorateId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "302f8e4a-23ad-428b-b3fc-4403aac8bc9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37794f25-7995-45fa-ba2d-2980e2252030");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5e282a7-5c2b-4fdc-90a5-0af72f5ac12a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0444851-3ab1-4951-b43e-62ff847eabe5");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("063eacfe-28fe-4083-a448-937d07793912"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0b6dff23-0055-40e9-9fa2-cbd0bb345970"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0d0ea98e-fc66-47b3-bb0e-db65b24aae72"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0dc381ab-9997-4bff-9311-03a538ed7a3c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1484c7a0-d98e-4404-9f56-59df38f22549"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a039491-fb72-408d-b982-5f72491a0663"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1efbf403-a783-4bd9-b93b-a8774599c68d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2c5fb4d1-ce48-4e3b-aa29-16a236b3cbdb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("306475b5-d6c2-4a2d-9b06-895d4102522a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("34b80ee0-8be1-406e-b515-19d9c14e425f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4600aa77-09a7-4d35-b48c-f3a06127c975"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("51b77e92-12fb-4cbd-87fe-dcbc2825cf25"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("59057a59-5e14-411c-a58a-89d7097a8478"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5c294219-e7c4-4c25-91bd-e676896d67b5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5d1001ec-c796-40aa-9d29-9f97aadf20ab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5da4ae05-cdde-477d-a4c4-39f2aa9efddf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67af5381-7d6d-41e8-9c63-07bbe96ea33c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7c5802ed-29e3-4c59-a7c2-384fdc1b021b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("836ef156-c1b4-48b3-b786-48cfb6882ca0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a217504-9b32-4999-9d71-4ac6345b7e46"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8a6abc9f-630d-4113-8d8e-c91f7dd722bf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8ce92106-5588-46ec-aaff-ab10762f603e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8fbffc31-febb-4d43-b588-ad843bb7c32b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a2b20e18-74f7-4b42-8192-012eaf75fb20"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a8dfbfbb-1aca-490f-8db2-8d92fe67ae2a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a9782e11-214d-4f3b-b56a-cacf6d3e5bc3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b41c0fb3-920b-43ae-a9b5-be28fc4983b2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bcaba142-03fc-428f-977e-bcee4a52d972"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bd640995-fefc-45c9-a77f-80fbc5468b16"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("be5941b1-fea5-4746-a065-77322ed92f2b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c6285349-062e-419d-b1c8-f519505c5b70"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c8fb67b7-7350-4077-9dde-0211328a7913"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ca6d85d0-6c59-47c4-ad5c-204ec96187b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ce8af60e-104a-400a-99e0-c86a0e6a1435"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cec88847-92e5-4f2b-a6c0-6b9227ef497f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ceff71d1-6a03-414c-914f-b4c09e9a3bcd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d9867367-7815-45f3-98d3-27b9aac3db91"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("da4c24e9-8bd4-422e-8e80-f1d754fafee5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de2d5fa9-fdbc-4c63-8748-7115f513ca50"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e42ed627-ddb4-4ecf-8f14-3a0b8dad30cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e50fe498-3a8a-4b27-99a0-5171d7b4a841"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e553cb2d-9d78-4b09-9699-a7e924dc68b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f12f4d8b-390f-4347-87e0-b7bc29fb51ab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f4c3a9ff-1369-42da-9d09-d0331e19a306"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f97b45f3-8d5c-4bda-8d35-3fc68bb26dc0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fbc45a7c-fcc0-4c07-8b75-6c0d94f6a8ef"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ff0df501-b88b-464d-a2c1-e1c2d2a24922"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ff5a4604-4c8e-490e-8db4-e15edf3c643f"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "GovernorateId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Order");

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
        }
    }
}
