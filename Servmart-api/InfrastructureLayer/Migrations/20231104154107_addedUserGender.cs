using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class addedUserGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d729f8f-55ad-4050-86d5-f51cce3a0f41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53e704da-6e3f-4fac-b279-8e310d0e14d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795906b0-e7de-4154-9dd2-fc9f7e5c7175");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0823e66-64a4-472b-a00c-f2e2994a8936");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0ee5f6c4-3a22-4fa7-a36e-2c47147fcbcb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1155b216-cd32-493e-b52e-2062091f0f0c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1c65c8c6-449c-4185-8c99-8663c0d47d6e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("219c91e0-6359-4a25-b7fe-ac6fd7bbacbd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2c608694-624f-4809-ac05-5b40ee662fc6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("31c579d8-ce8e-40da-894d-222575d62529"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("32a09656-50bd-4915-becb-76df0d0c447f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("40f05943-6d64-4506-bd47-83ba90541fde"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4bfa0e87-3c02-45d9-9608-6c3552dadf7c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("502b20a0-a9e2-49c8-8d9e-d1430557f674"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("52c79875-3a31-491e-b639-a8d82b15d61e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("547cadc3-524a-435e-97da-509d9d0d465b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5629744c-bb57-4bc0-885b-eb7cd65ee298"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5bd42ef2-f3f5-424e-bf02-748304a7061f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("620ccbc4-195d-4b52-9779-195fe6c03563"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67c231d6-e587-4f7b-8159-cf42c3c7ae80"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6f0728ed-a2b5-4da1-83c3-233ffecf784b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("72821d14-5f63-447c-94e1-ce596e3598cb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("741168ef-1aa6-4256-ab05-7c98938bb49d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7b1a6ebc-d508-43bb-b4df-2f445c2c6f67"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7db33c18-d9e2-401d-8302-60fbe601dd32"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("83d5dd5a-fcbb-4590-a505-fc8df309db81"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87d3839a-d091-4fb7-bec2-fa508d4f670d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8815a136-2779-4e20-b900-9cc4b26d6e30"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8be6fd1f-7c1e-4563-9437-349a6cce4060"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9eb8d640-1976-4bcb-ad8b-be5a28c0440b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9ef1cad2-752d-4a34-9fae-f88cd5cb5251"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a2384a60-849d-4ea6-b879-495475aa1b2c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ae99dd94-0747-48ae-ad42-f12024a8c440"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b42175da-4640-4fe9-acb1-910fd05263b2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b5ce1273-e4a4-4b33-bb6d-8c933bc9007c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("be467449-4a95-4f92-8017-0329a56040dd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c059a327-f8f1-4892-8b57-3b98c32879f1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c3d60210-99f4-4452-bfbb-0ce5d566ce82"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c5e28958-26e9-4638-a13c-b3c917d70cac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c88e2c1f-69cf-4553-8174-b33985f1521f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cb2e8137-464b-4f29-99c5-bf45a502fd8c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf35db87-a1ec-4a33-8fe1-49a2798c9072"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf364c56-de94-4362-8dc7-7a81aeb730c8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dee437ec-e5f3-47ea-90d3-6027ae1a4696"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df7fb407-d78e-4e27-ae93-0863e953a83b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e7dad44d-ac8b-4655-8b42-b39475a6fb0f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e935f40e-9a15-496a-bd8c-d7929bdb88b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e9611e2d-0822-4e9d-b93b-1e715d0d6e94"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f427fc43-d2d5-4cbd-ae2a-3213cf9cd30d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f495c6c9-0499-4563-91d3-ac5df636a92e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f6a5848c-d74c-486d-8983-c09db38a1ea3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fbb345ed-ec89-4d50-a70a-d5bc29e46105"));

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b107ad3-ea4b-4d71-8b88-6987dc2c0fb4", null, "Admin", "ADMIN" },
                    { "8172c8dc-926b-4f99-a131-8b5c66ea2756", null, "Vendor", "VENDOR" },
                    { "d9c1b88d-1fe2-47d0-8346-fc390bbc1dd0", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "e05e3822-4983-4f57-90eb-1ac9a728e98e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0079915b-0aa4-46a1-873e-72ac2278aeb3"), "تأمين", "Insurance" },
                    { new Guid("0141ee9c-d827-4692-bfb6-eb5f7851a479"), "خدمات الترجمة", "Translation services" },
                    { new Guid("05bfd53e-12c9-4be3-9fe1-bce1c0b10965"), "رعاية الأطفال", "Childcare" },
                    { new Guid("0629f444-14e2-4748-b0b4-d9b89b4743b2"), "نجارة", "Carpenter " },
                    { new Guid("0b2e5db6-b86d-48c1-964d-9c1063748ca9"), "خدمات حكومية", "Government services" },
                    { new Guid("13223a8c-e11b-4ca4-acda-82db56675c20"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("14727823-b1a1-45ee-9cec-e70a1e2ca921"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("193d7015-13f5-4405-ab16-3870f4792cfd"), "إستشارات", "Consulting " },
                    { new Guid("1a9f8e67-7d74-4df1-8c25-242370208a86"), "ضيافة", "Hospitality" },
                    { new Guid("1f1e7190-0ad2-4aab-8211-e037bcaf08cb"), "المحاسبة", "Accounting" },
                    { new Guid("206570e8-a7e8-4517-8c69-b41b2000b5d0"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("25d191fb-9855-48af-84b9-af7980e91a07"), "نقاشة", "Painter" },
                    { new Guid("2ff10b11-16ab-41f0-91cb-b60bacd6de37"), "التكييف", "Air conditioning" },
                    { new Guid("30f0ecf2-6c97-4767-8223-5322680d70d3"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("33695fbd-c1ba-4dd7-a3a0-a8abb9b875a1"), "البناء", "Construction" },
                    { new Guid("3be20b69-651f-4428-a06e-30eda63627ea"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("4e25d630-1161-4940-8fec-3a197e42ee54"), "خدمات أخرى", "Other services" },
                    { new Guid("5038af38-4ba2-4d43-88df-bcbad9a739c0"), "سباكة", "Plumbing" },
                    { new Guid("513b831f-6a96-4921-86cf-2df20f19b47d"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("52529986-8bbe-4c42-82f4-6bb312899d69"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("52977ae8-5158-4ce9-b942-73ce1024c787"), "العناية بالحديقة", "Garden care" },
                    { new Guid("575d2ddf-5436-4703-a8a4-5c7c9e590fe8"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("5ad5c4df-7d3e-45fe-bcd2-a8aa98813320"), "المكتبات", "Libraries" },
                    { new Guid("6245d1f6-c027-465c-ae65-28e545c729bc"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("7307f772-f2ca-4909-8d2a-75d9f402fea7"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("783ac255-05e8-40a9-977b-233a76b497be"), "ترفيه", "Entertainment" },
                    { new Guid("7840e8b0-0c04-4be6-9a80-cc77f694dff6"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("7a21a52c-d4af-4c84-968c-d1fbe3719acb"), "الخدمات المالية", "Financial services" },
                    { new Guid("84af5b58-d5c8-4331-8583-2a4e3c015e70"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("a2d77185-5605-4413-a248-dd84779ec1f1"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("a9d86f9a-78ec-4051-9997-b63b31e471dc"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("aa3f54e0-4d84-4cc4-bcad-aa5b16924690"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("abeb4e7d-3f23-4488-9a94-eb6fffb2418a"), "تسقيف", "Roofing" },
                    { new Guid("b0f74519-c24b-43f6-b28f-88992f0bbb8f"), "خدمات قانونية", "Legal services" },
                    { new Guid("b59616cf-372e-4d86-a85e-c9b11df44125"), "إدارة المكاتب", "Office management" },
                    { new Guid("b67cb8ab-a378-484b-8b38-7efe76f7b6f2"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("b8f82fc1-48cd-4368-859f-b7682b750616"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("b93c7535-2d7f-4f72-9db0-a76b12ca3e84"), "تقديم الطعام", "Catering " },
                    { new Guid("bb1c6f87-b5a9-478d-b84b-5bc21b1d941c"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("c9aa4263-5c52-46de-b6fe-1b75446dc441"), "خدمات التجميل", "Beauty services" },
                    { new Guid("d4bebb41-3fdb-4a33-a4f4-ec89e0283e44"), "كهرباء", "Electricity" },
                    { new Guid("d702c4d0-1305-465e-8863-df90b723668a"), "الخدمات الطبية", "Medical services" },
                    { new Guid("e00d26cf-3c6f-48c5-99f6-8d640d92b164"), "الرياضة", "Sports" },
                    { new Guid("e2f7bd63-04ba-4d13-a17e-6d289a67b491"), "العقارات", "Real estate" },
                    { new Guid("efd3bbac-6611-4cfb-95b1-583a2f68d77e"), "خدمات النقل", "Transportation services" },
                    { new Guid("f189b911-bde3-49ab-ada6-b72f4b2771e9"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("f8567083-709e-40d9-a161-3ebaaf60c8b7"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("fd8fef98-6708-4e1f-9e1f-38c34c1a9972"), "مكافحة الحشرات والطيور", "Pest and bird control" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b107ad3-ea4b-4d71-8b88-6987dc2c0fb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8172c8dc-926b-4f99-a131-8b5c66ea2756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9c1b88d-1fe2-47d0-8346-fc390bbc1dd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e05e3822-4983-4f57-90eb-1ac9a728e98e");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0079915b-0aa4-46a1-873e-72ac2278aeb3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0141ee9c-d827-4692-bfb6-eb5f7851a479"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("05bfd53e-12c9-4be3-9fe1-bce1c0b10965"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0629f444-14e2-4748-b0b4-d9b89b4743b2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0b2e5db6-b86d-48c1-964d-9c1063748ca9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("13223a8c-e11b-4ca4-acda-82db56675c20"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("14727823-b1a1-45ee-9cec-e70a1e2ca921"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("193d7015-13f5-4405-ab16-3870f4792cfd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a9f8e67-7d74-4df1-8c25-242370208a86"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1f1e7190-0ad2-4aab-8211-e037bcaf08cb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("206570e8-a7e8-4517-8c69-b41b2000b5d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("25d191fb-9855-48af-84b9-af7980e91a07"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ff10b11-16ab-41f0-91cb-b60bacd6de37"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("30f0ecf2-6c97-4767-8223-5322680d70d3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("33695fbd-c1ba-4dd7-a3a0-a8abb9b875a1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3be20b69-651f-4428-a06e-30eda63627ea"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e25d630-1161-4940-8fec-3a197e42ee54"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5038af38-4ba2-4d43-88df-bcbad9a739c0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("513b831f-6a96-4921-86cf-2df20f19b47d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("52529986-8bbe-4c42-82f4-6bb312899d69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("52977ae8-5158-4ce9-b942-73ce1024c787"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("575d2ddf-5436-4703-a8a4-5c7c9e590fe8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5ad5c4df-7d3e-45fe-bcd2-a8aa98813320"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6245d1f6-c027-465c-ae65-28e545c729bc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7307f772-f2ca-4909-8d2a-75d9f402fea7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("783ac255-05e8-40a9-977b-233a76b497be"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7840e8b0-0c04-4be6-9a80-cc77f694dff6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7a21a52c-d4af-4c84-968c-d1fbe3719acb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("84af5b58-d5c8-4331-8583-2a4e3c015e70"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a2d77185-5605-4413-a248-dd84779ec1f1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a9d86f9a-78ec-4051-9997-b63b31e471dc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aa3f54e0-4d84-4cc4-bcad-aa5b16924690"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("abeb4e7d-3f23-4488-9a94-eb6fffb2418a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b0f74519-c24b-43f6-b28f-88992f0bbb8f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b59616cf-372e-4d86-a85e-c9b11df44125"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b67cb8ab-a378-484b-8b38-7efe76f7b6f2"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b8f82fc1-48cd-4368-859f-b7682b750616"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b93c7535-2d7f-4f72-9db0-a76b12ca3e84"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bb1c6f87-b5a9-478d-b84b-5bc21b1d941c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c9aa4263-5c52-46de-b6fe-1b75446dc441"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d4bebb41-3fdb-4a33-a4f4-ec89e0283e44"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d702c4d0-1305-465e-8863-df90b723668a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e00d26cf-3c6f-48c5-99f6-8d640d92b164"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e2f7bd63-04ba-4d13-a17e-6d289a67b491"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("efd3bbac-6611-4cfb-95b1-583a2f68d77e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f189b911-bde3-49ab-ada6-b72f4b2771e9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f8567083-709e-40d9-a161-3ebaaf60c8b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fd8fef98-6708-4e1f-9e1f-38c34c1a9972"));

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d729f8f-55ad-4050-86d5-f51cce3a0f41", null, "Customer", "CUSTOMER" },
                    { "53e704da-6e3f-4fac-b279-8e310d0e14d0", null, "Admin", "ADMIN" },
                    { "795906b0-e7de-4154-9dd2-fc9f7e5c7175", null, "Vendor", "VENDOR" },
                    { "e0823e66-64a4-472b-a00c-f2e2994a8936", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0ee5f6c4-3a22-4fa7-a36e-2c47147fcbcb"), "خدمات قانونية", "Legal services" },
                    { new Guid("1155b216-cd32-493e-b52e-2062091f0f0c"), "نجارة", "Carpenter " },
                    { new Guid("1c65c8c6-449c-4185-8c99-8663c0d47d6e"), "تقديم الطعام", "Catering " },
                    { new Guid("219c91e0-6359-4a25-b7fe-ac6fd7bbacbd"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("2c608694-624f-4809-ac05-5b40ee662fc6"), "خدمات حكومية", "Government services" },
                    { new Guid("31c579d8-ce8e-40da-894d-222575d62529"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("32a09656-50bd-4915-becb-76df0d0c447f"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("40f05943-6d64-4506-bd47-83ba90541fde"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("4bfa0e87-3c02-45d9-9608-6c3552dadf7c"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("502b20a0-a9e2-49c8-8d9e-d1430557f674"), "الخدمات الطبية", "Medical services" },
                    { new Guid("52c79875-3a31-491e-b639-a8d82b15d61e"), "البناء", "Construction" },
                    { new Guid("547cadc3-524a-435e-97da-509d9d0d465b"), "إدارة المكاتب", "Office management" },
                    { new Guid("5629744c-bb57-4bc0-885b-eb7cd65ee298"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("5bd42ef2-f3f5-424e-bf02-748304a7061f"), "خدمات الترجمة", "Translation services" },
                    { new Guid("620ccbc4-195d-4b52-9779-195fe6c03563"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("67c231d6-e587-4f7b-8159-cf42c3c7ae80"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("6f0728ed-a2b5-4da1-83c3-233ffecf784b"), "رعاية الأطفال", "Childcare" },
                    { new Guid("72821d14-5f63-447c-94e1-ce596e3598cb"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("741168ef-1aa6-4256-ab05-7c98938bb49d"), "خدمات أخرى", "Other services" },
                    { new Guid("7b1a6ebc-d508-43bb-b4df-2f445c2c6f67"), "الخدمات المالية", "Financial services" },
                    { new Guid("7db33c18-d9e2-401d-8302-60fbe601dd32"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("83d5dd5a-fcbb-4590-a505-fc8df309db81"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("87d3839a-d091-4fb7-bec2-fa508d4f670d"), "سباكة", "Plumbing" },
                    { new Guid("8815a136-2779-4e20-b900-9cc4b26d6e30"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("8be6fd1f-7c1e-4563-9437-349a6cce4060"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("9eb8d640-1976-4bcb-ad8b-be5a28c0440b"), "خدمات التجميل", "Beauty services" },
                    { new Guid("9ef1cad2-752d-4a34-9fae-f88cd5cb5251"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("a2384a60-849d-4ea6-b879-495475aa1b2c"), "ترفيه", "Entertainment" },
                    { new Guid("ae99dd94-0747-48ae-ad42-f12024a8c440"), "تأمين", "Insurance" },
                    { new Guid("b42175da-4640-4fe9-acb1-910fd05263b2"), "تسقيف", "Roofing" },
                    { new Guid("b5ce1273-e4a4-4b33-bb6d-8c933bc9007c"), "الرياضة", "Sports" },
                    { new Guid("be467449-4a95-4f92-8017-0329a56040dd"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c059a327-f8f1-4892-8b57-3b98c32879f1"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("c3d60210-99f4-4452-bfbb-0ce5d566ce82"), "المحاسبة", "Accounting" },
                    { new Guid("c5e28958-26e9-4638-a13c-b3c917d70cac"), "خدمات النقل", "Transportation services" },
                    { new Guid("c88e2c1f-69cf-4553-8174-b33985f1521f"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("cb2e8137-464b-4f29-99c5-bf45a502fd8c"), "كهرباء", "Electricity" },
                    { new Guid("cf35db87-a1ec-4a33-8fe1-49a2798c9072"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("cf364c56-de94-4362-8dc7-7a81aeb730c8"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("dee437ec-e5f3-47ea-90d3-6027ae1a4696"), "نقاشة", "Painter" },
                    { new Guid("df7fb407-d78e-4e27-ae93-0863e953a83b"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("e7dad44d-ac8b-4655-8b42-b39475a6fb0f"), "التكييف", "Air conditioning" },
                    { new Guid("e935f40e-9a15-496a-bd8c-d7929bdb88b8"), "العقارات", "Real estate" },
                    { new Guid("e9611e2d-0822-4e9d-b93b-1e715d0d6e94"), "إستشارات", "Consulting " },
                    { new Guid("f427fc43-d2d5-4cbd-ae2a-3213cf9cd30d"), "ضيافة", "Hospitality" },
                    { new Guid("f495c6c9-0499-4563-91d3-ac5df636a92e"), "العناية بالحديقة", "Garden care" },
                    { new Guid("f6a5848c-d74c-486d-8983-c09db38a1ea3"), "المكتبات", "Libraries" },
                    { new Guid("fbb345ed-ec89-4d50-a70a-d5bc29e46105"), "إصلاح الكمبيوتر", "Computer repair" }
                });
        }
    }
}
