using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedia_Request_RequestID",
                schema: "Service",
                table: "RequestMedia");

            migrationBuilder.DropIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e853ff8-c169-483b-91fa-3cba01b7bb9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55a6be81-c84a-498c-a6f3-b8f388e6bcb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90d25fca-7e9e-4f3e-a34b-420f315e9789");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af5fdce-d9e7-4be8-acfc-41f813a15c83");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0231bbb2-8def-40d2-96b5-035782c2b5db"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0c6a366d-9c83-4381-a568-dd333a5fff63"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1ea83717-1526-4704-95bd-9140b9ef0657"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2033872b-6a9f-4da1-a49e-19a427c61d33"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("23aa2f8c-fc4c-4877-990e-00192e238d9d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("27f77296-bb68-4af8-950d-bc2291885cbe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("33b55a0e-6f10-4d6e-8409-f0c8ab3d3785"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3651c688-c530-4be8-ad5c-8201320705b2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3745cf28-69c2-46ca-803f-02f95b54f221"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3a994ccf-43ea-4b9a-8e58-b570e8f1b513"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3b090bfd-574f-4586-bf6b-f399078498bc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("412b4049-85e0-43fa-aaaa-98417a0420da"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("445fb8bc-19ba-403f-8034-96751436c43c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("48b1ce01-d241-4a59-b020-0ae0358f125d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4a4dcb4b-3b29-4fd3-bb53-c85641fb5ced"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4f964552-8dca-4e95-8065-6d3b24bef3cc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("52d69260-9a46-4bfe-a08e-5980c0b0cd2c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("59fbeaad-6795-4b10-ae8a-ee17dd25730d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5eb8a358-90c9-4b11-a231-b11e56fdb222"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6198d8f4-68b7-4f46-9405-d83068e35b83"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67766823-f154-48f2-ba0a-d493cce46599"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6f6b6cea-8172-409b-aa9f-36058c4b9be9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6fc970a4-c56c-4f81-896c-3ac366c11143"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("78d7800b-01c2-430a-9d9c-8f5dc7a6ebc3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7f544146-783b-4f9a-be2d-383a494c44df"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82f31be4-a290-4ee9-b907-661d9a0eeee0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("98bd8721-1e0a-4e5a-9bee-9fbff99ce470"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a63cb409-76fe-4dd6-9310-df6a217817cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a80c935a-f822-46d0-96df-50678fcd169c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad3f0b0a-64f4-4492-8f9d-7dff160725ca"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("af5cae8f-5330-42eb-910b-8d068f31d7d4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b9b23711-2964-493c-80ad-7c2643fb452f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ba611586-33de-467f-981c-9fdf1b1cc4c8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bd3f28d0-d7a3-4e74-8c5d-59ca711d5550"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c43cc37e-dd8a-4921-94a1-5aa760596fb5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c996795b-abec-4574-a730-9570c6c75444"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cdac42d5-58a4-4481-8dd6-beb2f3d99b0f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d042fa46-b196-4b5a-8487-fdc7ee3e7105"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d3db77b7-b1f8-4e73-910f-21bc6c954929"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d7b33676-382d-47af-9957-0cf0bb802210"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dee0e314-6922-44eb-8e20-c57ba13136ea"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e1bb30c1-9714-49a9-be95-2a7e821da2e5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e21da957-7508-4873-96ff-03e39c7a9e70"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e448b55f-c5e5-4b7a-8715-3170a0fe5b16"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("edd46d1a-1104-466b-8a5d-4b65886db3eb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f4a676d9-bfe7-4dfb-ae51-74261786ed30"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f9b6758c-8a6e-4787-86f9-470f8312ec32"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc6daf6a-3dae-480e-8290-a205485499b1"));

            migrationBuilder.RenameColumn(
                name: "State",
                schema: "Service",
                table: "Request",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ExpectSalary",
                schema: "Service",
                table: "Request",
                newName: "ExpectedSalary");

            migrationBuilder.AddColumn<Guid>(
                name: "RequestImagesID",
                schema: "Service",
                table: "RequestMedia",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "Service",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                schema: "Service",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                schema: "Service",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GovernorateId",
                schema: "Service",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Request_CityId",
                schema: "Service",
                table: "Request",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_GovernorateId",
                schema: "Service",
                table: "Request",
                column: "GovernorateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_City_CityId",
                schema: "Service",
                table: "Request",
                column: "CityId",
                principalSchema: "Address",
                principalTable: "City",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Governorate_GovernorateId",
                schema: "Service",
                table: "Request",
                column: "GovernorateId",
                principalSchema: "Address",
                principalTable: "Governorate",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedia_Request_RequestID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestID",
                principalSchema: "Service",
                principalTable: "Request",
                principalColumn: "ID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_City_CityId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Governorate_GovernorateId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedia_Request_RequestID",
                schema: "Service",
                table: "RequestMedia");

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

            migrationBuilder.DropIndex(
                name: "IX_Request_CityId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_GovernorateId",
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
                name: "RequestImagesID",
                schema: "Service",
                table: "RequestMedia");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Category",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "CityId",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "GovernorateId",
                schema: "Service",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "Service",
                table: "Request",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ExpectedSalary",
                schema: "Service",
                table: "Request",
                newName: "ExpectSalary");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e853ff8-c169-483b-91fa-3cba01b7bb9f", null, "Admin", "ADMIN" },
                    { "55a6be81-c84a-498c-a6f3-b8f388e6bcb5", null, "Customer", "CUSTOMER" },
                    { "90d25fca-7e9e-4f3e-a34b-420f315e9789", null, "Vendor", "VENDOR" },
                    { "9af5fdce-d9e7-4be8-acfc-41f813a15c83", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0231bbb2-8def-40d2-96b5-035782c2b5db"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("0c6a366d-9c83-4381-a568-dd333a5fff63"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("1ea83717-1526-4704-95bd-9140b9ef0657"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("2033872b-6a9f-4da1-a49e-19a427c61d33"), "خدمات قانونية", "Legal services" },
                    { new Guid("23aa2f8c-fc4c-4877-990e-00192e238d9d"), "ترفيه", "Entertainment" },
                    { new Guid("27f77296-bb68-4af8-950d-bc2291885cbe"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("33b55a0e-6f10-4d6e-8409-f0c8ab3d3785"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("3651c688-c530-4be8-ad5c-8201320705b2"), "ضيافة", "Hospitality" },
                    { new Guid("3745cf28-69c2-46ca-803f-02f95b54f221"), "خدمات النقل", "Transportation services" },
                    { new Guid("3a994ccf-43ea-4b9a-8e58-b570e8f1b513"), "نقاشة", "Painter" },
                    { new Guid("3b090bfd-574f-4586-bf6b-f399078498bc"), "سباكة", "Plumbing" },
                    { new Guid("412b4049-85e0-43fa-aaaa-98417a0420da"), "خدمات التجميل", "Beauty services" },
                    { new Guid("445fb8bc-19ba-403f-8034-96751436c43c"), "خدمات أخرى", "Other services" },
                    { new Guid("48b1ce01-d241-4a59-b020-0ae0358f125d"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("4a4dcb4b-3b29-4fd3-bb53-c85641fb5ced"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("4f964552-8dca-4e95-8065-6d3b24bef3cc"), "البناء", "Construction" },
                    { new Guid("52d69260-9a46-4bfe-a08e-5980c0b0cd2c"), "الخدمات الطبية", "Medical services" },
                    { new Guid("59fbeaad-6795-4b10-ae8a-ee17dd25730d"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("5eb8a358-90c9-4b11-a231-b11e56fdb222"), "تسقيف", "Roofing" },
                    { new Guid("6198d8f4-68b7-4f46-9405-d83068e35b83"), "المكتبات", "Libraries" },
                    { new Guid("67766823-f154-48f2-ba0a-d493cce46599"), "تقديم الطعام", "Catering " },
                    { new Guid("6f6b6cea-8172-409b-aa9f-36058c4b9be9"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("6fc970a4-c56c-4f81-896c-3ac366c11143"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("78d7800b-01c2-430a-9d9c-8f5dc7a6ebc3"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("7f544146-783b-4f9a-be2d-383a494c44df"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("82f31be4-a290-4ee9-b907-661d9a0eeee0"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("98bd8721-1e0a-4e5a-9bee-9fbff99ce470"), "نجارة", "Carpenter " },
                    { new Guid("a63cb409-76fe-4dd6-9310-df6a217817cd"), "المحاسبة", "Accounting" },
                    { new Guid("a80c935a-f822-46d0-96df-50678fcd169c"), "الخدمات المالية", "Financial services" },
                    { new Guid("ad3f0b0a-64f4-4492-8f9d-7dff160725ca"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("af5cae8f-5330-42eb-910b-8d068f31d7d4"), "الرياضة", "Sports" },
                    { new Guid("b9b23711-2964-493c-80ad-7c2643fb452f"), "خدمات الترجمة", "Translation services" },
                    { new Guid("ba611586-33de-467f-981c-9fdf1b1cc4c8"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("bd3f28d0-d7a3-4e74-8c5d-59ca711d5550"), "خدمات حكومية", "Government services" },
                    { new Guid("c43cc37e-dd8a-4921-94a1-5aa760596fb5"), "كهرباء", "Electricity" },
                    { new Guid("c996795b-abec-4574-a730-9570c6c75444"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("cdac42d5-58a4-4481-8dd6-beb2f3d99b0f"), "إستشارات", "Consulting " },
                    { new Guid("d042fa46-b196-4b5a-8487-fdc7ee3e7105"), "العناية بالحديقة", "Garden care" },
                    { new Guid("d3db77b7-b1f8-4e73-910f-21bc6c954929"), "العقارات", "Real estate" },
                    { new Guid("d7b33676-382d-47af-9957-0cf0bb802210"), "التكييف", "Air conditioning" },
                    { new Guid("dee0e314-6922-44eb-8e20-c57ba13136ea"), "إدارة المكاتب", "Office management" },
                    { new Guid("e1bb30c1-9714-49a9-be95-2a7e821da2e5"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("e21da957-7508-4873-96ff-03e39c7a9e70"), "رعاية الأطفال", "Childcare" },
                    { new Guid("e448b55f-c5e5-4b7a-8715-3170a0fe5b16"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("edd46d1a-1104-466b-8a5d-4b65886db3eb"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("f4a676d9-bfe7-4dfb-ae51-74261786ed30"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("f9b6758c-8a6e-4787-86f9-470f8312ec32"), "تأمين", "Insurance" },
                    { new Guid("fc6daf6a-3dae-480e-8290-a205485499b1"), "خدمات التوصيل", "Delivery services" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestMedia_RequestID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedia_Request_RequestID",
                schema: "Service",
                table: "RequestMedia",
                column: "RequestID",
                principalSchema: "Service",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
