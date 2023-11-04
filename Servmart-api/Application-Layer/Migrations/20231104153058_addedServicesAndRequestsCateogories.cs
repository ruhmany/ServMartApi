using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class addedServicesAndRequestsCateogories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7b8ccf-892c-4031-8c97-edd429f5d145");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ce6f929-090a-43ba-b14d-f00b91a5ac9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ff1f83-b099-4934-a518-322d91799cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7ef1b77-6dbc-440a-aaba-ff742f99ec8c");

            migrationBuilder.EnsureSchema(
                name: "Shop");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "Shop",
                newSchema: "Shop");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Service",
                table: "ServiceCategory",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                schema: "Service",
                table: "ServiceCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Shop",
                table: "Shop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "Shop",
                table: "Shop",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NameAr",
                schema: "Service",
                table: "ServiceCategory");

            migrationBuilder.RenameTable(
                name: "Shop",
                schema: "Shop",
                newName: "Shop");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                schema: "Service",
                table: "ServiceCategory",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e7b8ccf-892c-4031-8c97-edd429f5d145", null, "Vendor", "VENDOR" },
                    { "5ce6f929-090a-43ba-b14d-f00b91a5ac9d", null, "Customer", "CUSTOMER" },
                    { "c8ff1f83-b099-4934-a518-322d91799cb0", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "f7ef1b77-6dbc-440a-aaba-ff742f99ec8c", null, "Admin", "ADMIN" }
                });
        }
    }
}
