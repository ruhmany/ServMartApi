using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "316aecff-8125-42ba-a688-4407bc9b1ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba121f5-930d-4aca-ad15-fcdcffd997cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c0cb018-d170-46d8-b845-b814c6b6e39a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c31f9de8-4187-4eb6-aae9-dee791c31ef9");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("05335794-ffa9-45dd-af2a-e9d0a7689edc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("063dd24b-cd27-4b28-bb70-9fba172adc84"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0818bf43-1fcd-4520-b283-cee706a31707"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("10ba11c5-5a2f-4fd0-8eae-2bda71b82b80"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1211439d-6595-445f-9769-da6bb9c6190f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a43a534-aaa0-4e80-b873-0b87efbc35b4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1a4c266f-e63f-49c6-8ea4-09f49ae78517"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1d3a7885-03ce-4ec2-87c1-160f5f4f61f4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e1e7a96-819b-4c94-9037-d8678eb4e8c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("27987ddb-1abc-4013-9889-412463da1b81"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("29768473-0e7f-42a1-b5a1-f7aabcc9f683"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("415ea623-6fbe-408b-bb77-4f05c4e5081e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("43eeac62-b5eb-419e-9db8-13daca7c3339"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("47666ef0-4697-4a18-a21c-5832460c571a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4c7df3eb-aae0-4a08-a14e-46c1f8e85fc8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("55dcf1e2-29df-4454-94ef-ad8d160a170b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5e91d996-6161-4c64-8293-21e237253a54"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6703c50b-e02b-4099-942e-2d441c45766b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6b8bd2c1-b794-44e0-bfb0-7851e2d62512"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6db72198-b53c-432b-ad08-831c232e487b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("73726bd3-32cf-445f-bd41-b19c160ce971"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("751ca285-ce37-4b63-b642-1d12327f685b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7826fad4-9c6b-46a1-8e0a-a6736e80a4e5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7e4c054b-61dd-4f34-9b81-778a8195b3f0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("816a5a2d-bc5b-4153-87c0-a33f8ad5d4eb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8259fa1c-7830-4240-bcf9-f226f23e4e89"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("847733ff-6200-4cb4-ae1e-23e3a6285b58"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8eea7039-8499-40be-ab96-38da857aea69"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("99c5572a-2f10-443b-b97e-2bed8a4d4ffa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9c9df342-8974-42fa-9149-eb17101f522a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aa0c7ccf-d92b-49d2-a0be-6b0e69109401"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b43fbea8-b3b6-4e8b-bf24-838067ebf7c8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b7b65876-ab6c-4914-be73-a8427d802101"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bb509e58-fbb0-4342-ab44-0e6bdf74c82e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bbcc5141-6297-414b-8547-b8eff163b3e3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c1436b13-d1c8-4227-b49a-f2135c2e56b4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c6bc50a0-e989-42c5-b04b-71650e092177"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c9d21ace-1dc5-4494-9897-141f53edb873"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d1506e47-c32b-48e9-8e56-2ee19749606a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d354fae9-ab23-4b4a-94ab-73de66054a2a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d6000dbd-6b4b-4971-b97f-59e7dafba699"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d6293e2b-7667-4427-ac7f-b402a8917536"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dcdbc193-bc1c-41f1-b130-979fd577a448"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dfe93772-70e7-4d04-8d24-90a45f413172"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e7c60c33-1abd-43f3-b009-3a8d7f0efa5f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ef23916b-0a2a-4c72-8260-7d93a99b8dc4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f55836be-843b-49fa-ae2e-e0a0327142fe"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fbf91da4-f8d6-4052-bbae-622184107190"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "351e55e7-0526-48e8-ae14-5660bf248ca4", null, "Admin", "ADMIN" },
                    { "4578be63-9097-4066-9e38-2f5ace098a06", null, "Vendor", "VENDOR" },
                    { "471f823f-f19d-4c7d-bc8d-4746fe078121", null, "Customer", "CUSTOMER" },
                    { "b627e5ac-882a-4984-9242-e5e52e201cc0", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Product",
                table: "ProductCategory",
                columns: new[] { "ID", "Catagory" },
                values: new object[,]
                {
                    { new Guid("416a1e59-fb65-47ec-a955-2c0c9ee8e33c"), "مياه  " },
                    { new Guid("a0e36702-5873-4d15-b10d-ae8cb81b463f"), "ملابس " },
                    { new Guid("bfe5434f-f8bb-4783-b2fb-d5b11504c595"), "لحوم" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("06f95bb3-31c7-4d60-9428-7e3c2a59dfb7"), "نقاشة", "Painter" },
                    { new Guid("0a956bcf-89ad-4bbe-a545-6ca0d8baa9b3"), "نجارة", "Carpenter " },
                    { new Guid("0f00c014-5788-408b-9e30-a21f2c99d4f7"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("11d19870-6146-4af1-a8fe-48a43c8c0927"), "إستشارات", "Consulting " },
                    { new Guid("170e6f93-6b2e-4477-8ad5-d9ff457e7c74"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("18ac4108-5d34-4218-b37b-a86b798e6b7a"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("1c9facc8-a4f2-48d5-90f9-6153691b3ccf"), "الخدمات المالية", "Financial services" },
                    { new Guid("1e0d364d-f6ac-44ec-9aa4-e9eafbf20aa1"), "ضيافة", "Hospitality" },
                    { new Guid("2ae1e529-d81b-4314-9b7f-2233b2f15daf"), "خدمات أخرى", "Other services" },
                    { new Guid("2e8a860f-3ae3-4345-b0a7-be5d1bc18c62"), "التكييف", "Air conditioning" },
                    { new Guid("371e8375-2745-4a24-8960-8b005637b09f"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("3b6b2649-8b5d-4707-a89b-285e3da1f82a"), "ترفيه", "Entertainment" },
                    { new Guid("3d5f12b4-4e4c-4e29-b85a-c47b1b6df508"), "إدارة المكاتب", "Office management" },
                    { new Guid("41b96260-880a-46b0-b28d-aa3b80a8a019"), "الخدمات الطبية", "Medical services" },
                    { new Guid("4246951b-9b8a-4b0e-87d5-fd5baa06ec0e"), "البناء", "Construction" },
                    { new Guid("486b2469-3e2b-45e8-880a-e178642d3a88"), "سباكة", "Plumbing" },
                    { new Guid("48803309-a9da-4064-bad1-8c33f406a793"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("58557d79-d90b-4360-baef-77585e997e56"), "المكتبات", "Libraries" },
                    { new Guid("5cd4b119-12d0-4c43-ba0c-c0114732acad"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("5f197995-b187-461a-a031-e0e1d02a21ba"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("63a59ece-15b2-419c-913e-7b65b5ee63a6"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("643f3358-e691-4a6b-908d-9be55b6098b5"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("66698567-cc04-47eb-b1b3-cb613fb198e7"), "العناية بالحديقة", "Garden care" },
                    { new Guid("67c2c4ea-b67e-49c7-9aca-a11a3be6cc39"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("6e57cd69-b752-431a-89bc-3c15deaf82ac"), "تقديم الطعام", "Catering " },
                    { new Guid("70bbf2ee-e5ec-4ba2-ac97-4dcbd22d055a"), "العقارات", "Real estate" },
                    { new Guid("78c31345-9bdd-46df-bf3a-adc7815eabf0"), "الرياضة", "Sports" },
                    { new Guid("7b98b25f-3956-4fd8-bdbb-5da9ef357e5b"), "تأمين", "Insurance" },
                    { new Guid("7ece3e3d-a96d-454c-8e86-0c38e904377c"), "كهرباء", "Electricity" },
                    { new Guid("879ceba0-8fd0-410b-b7db-4439494f433b"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("8bb3a925-f753-4177-aab7-a64d494eb390"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("8bfd4787-46c7-478f-8d50-1364b335a239"), "خدمات قانونية", "Legal services" },
                    { new Guid("8f0c1896-6ae2-418e-ab96-c72c4decc3c5"), "تسقيف", "Roofing" },
                    { new Guid("94c6a34d-8bdb-496c-9dce-751685064a34"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("95e0b6c4-9750-46dd-a836-99ca85844b4d"), "خدمات حكومية", "Government services" },
                    { new Guid("9db783cc-2d05-4baa-966d-3078e61a2966"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("bd3e74ef-12c5-458c-a4d4-54a87afbbbaa"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("c72bdf13-7e27-40f6-8bfb-4f5dfac10edd"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("c83a4a3c-7217-45db-80b0-96133ea34192"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("ca3974bb-db89-479b-80ef-561acee98eb0"), "رعاية الأطفال", "Childcare" },
                    { new Guid("cf97b3e3-1622-4bde-bae8-7371fd195258"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("d778c036-7fd1-49ca-822f-94a07fb177fb"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("d859f8cc-8b6f-48db-889c-45bdf7eb528c"), "خدمات النقل", "Transportation services" },
                    { new Guid("de9b8694-eb6c-415c-8eb6-363bb4089b3b"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("e038aee1-6683-497d-b299-7b9a446ac8bb"), "المحاسبة", "Accounting" },
                    { new Guid("eb534de8-4c7a-422c-aeec-02bbdfef1802"), "خدمات الترجمة", "Translation services" },
                    { new Guid("ecffbdf5-8c6e-4faf-8887-6f316cec519b"), "خدمات التجميل", "Beauty services" },
                    { new Guid("effefb0a-1e59-4b62-85a4-8534343c905b"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "351e55e7-0526-48e8-ae14-5660bf248ca4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4578be63-9097-4066-9e38-2f5ace098a06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "471f823f-f19d-4c7d-bc8d-4746fe078121");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b627e5ac-882a-4984-9242-e5e52e201cc0");

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("416a1e59-fb65-47ec-a955-2c0c9ee8e33c"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("a0e36702-5873-4d15-b10d-ae8cb81b463f"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("bfe5434f-f8bb-4783-b2fb-d5b11504c595"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("06f95bb3-31c7-4d60-9428-7e3c2a59dfb7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0a956bcf-89ad-4bbe-a545-6ca0d8baa9b3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0f00c014-5788-408b-9e30-a21f2c99d4f7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("11d19870-6146-4af1-a8fe-48a43c8c0927"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("170e6f93-6b2e-4477-8ad5-d9ff457e7c74"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("18ac4108-5d34-4218-b37b-a86b798e6b7a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1c9facc8-a4f2-48d5-90f9-6153691b3ccf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e0d364d-f6ac-44ec-9aa4-e9eafbf20aa1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ae1e529-d81b-4314-9b7f-2233b2f15daf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2e8a860f-3ae3-4345-b0a7-be5d1bc18c62"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("371e8375-2745-4a24-8960-8b005637b09f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3b6b2649-8b5d-4707-a89b-285e3da1f82a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3d5f12b4-4e4c-4e29-b85a-c47b1b6df508"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("41b96260-880a-46b0-b28d-aa3b80a8a019"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4246951b-9b8a-4b0e-87d5-fd5baa06ec0e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("486b2469-3e2b-45e8-880a-e178642d3a88"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("48803309-a9da-4064-bad1-8c33f406a793"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("58557d79-d90b-4360-baef-77585e997e56"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5cd4b119-12d0-4c43-ba0c-c0114732acad"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5f197995-b187-461a-a031-e0e1d02a21ba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("63a59ece-15b2-419c-913e-7b65b5ee63a6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("643f3358-e691-4a6b-908d-9be55b6098b5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("66698567-cc04-47eb-b1b3-cb613fb198e7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67c2c4ea-b67e-49c7-9aca-a11a3be6cc39"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6e57cd69-b752-431a-89bc-3c15deaf82ac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("70bbf2ee-e5ec-4ba2-ac97-4dcbd22d055a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("78c31345-9bdd-46df-bf3a-adc7815eabf0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7b98b25f-3956-4fd8-bdbb-5da9ef357e5b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7ece3e3d-a96d-454c-8e86-0c38e904377c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("879ceba0-8fd0-410b-b7db-4439494f433b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8bb3a925-f753-4177-aab7-a64d494eb390"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8bfd4787-46c7-478f-8d50-1364b335a239"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8f0c1896-6ae2-418e-ab96-c72c4decc3c5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("94c6a34d-8bdb-496c-9dce-751685064a34"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95e0b6c4-9750-46dd-a836-99ca85844b4d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9db783cc-2d05-4baa-966d-3078e61a2966"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bd3e74ef-12c5-458c-a4d4-54a87afbbbaa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c72bdf13-7e27-40f6-8bfb-4f5dfac10edd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c83a4a3c-7217-45db-80b0-96133ea34192"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ca3974bb-db89-479b-80ef-561acee98eb0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cf97b3e3-1622-4bde-bae8-7371fd195258"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d778c036-7fd1-49ca-822f-94a07fb177fb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d859f8cc-8b6f-48db-889c-45bdf7eb528c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("de9b8694-eb6c-415c-8eb6-363bb4089b3b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e038aee1-6683-497d-b299-7b9a446ac8bb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("eb534de8-4c7a-422c-aeec-02bbdfef1802"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ecffbdf5-8c6e-4faf-8887-6f316cec519b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("effefb0a-1e59-4b62-85a4-8534343c905b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "316aecff-8125-42ba-a688-4407bc9b1ca0", null, "Customer", "CUSTOMER" },
                    { "6ba121f5-930d-4aca-ad15-fcdcffd997cc", null, "Admin", "ADMIN" },
                    { "9c0cb018-d170-46d8-b845-b814c6b6e39a", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "c31f9de8-4187-4eb6-aae9-dee791c31ef9", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("05335794-ffa9-45dd-af2a-e9d0a7689edc"), "كهرباء", "Electricity" },
                    { new Guid("063dd24b-cd27-4b28-bb70-9fba172adc84"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("0818bf43-1fcd-4520-b283-cee706a31707"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("10ba11c5-5a2f-4fd0-8eae-2bda71b82b80"), "تسقيف", "Roofing" },
                    { new Guid("1211439d-6595-445f-9769-da6bb9c6190f"), "تقديم الطعام", "Catering " },
                    { new Guid("1a43a534-aaa0-4e80-b873-0b87efbc35b4"), "نجارة", "Carpenter " },
                    { new Guid("1a4c266f-e63f-49c6-8ea4-09f49ae78517"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("1d3a7885-03ce-4ec2-87c1-160f5f4f61f4"), "العناية بالحديقة", "Garden care" },
                    { new Guid("1e1e7a96-819b-4c94-9037-d8678eb4e8c4"), "خدمات حكومية", "Government services" },
                    { new Guid("27987ddb-1abc-4013-9889-412463da1b81"), "سباكة", "Plumbing" },
                    { new Guid("29768473-0e7f-42a1-b5a1-f7aabcc9f683"), "البناء", "Construction" },
                    { new Guid("415ea623-6fbe-408b-bb77-4f05c4e5081e"), "خدمات الترجمة", "Translation services" },
                    { new Guid("43eeac62-b5eb-419e-9db8-13daca7c3339"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("47666ef0-4697-4a18-a21c-5832460c571a"), "خدمات أخرى", "Other services" },
                    { new Guid("4c7df3eb-aae0-4a08-a14e-46c1f8e85fc8"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("55dcf1e2-29df-4454-94ef-ad8d160a170b"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("5e91d996-6161-4c64-8293-21e237253a54"), "خدمات التجميل", "Beauty services" },
                    { new Guid("6703c50b-e02b-4099-942e-2d441c45766b"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("6b8bd2c1-b794-44e0-bfb0-7851e2d62512"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("6db72198-b53c-432b-ad08-831c232e487b"), "العقارات", "Real estate" },
                    { new Guid("73726bd3-32cf-445f-bd41-b19c160ce971"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("751ca285-ce37-4b63-b642-1d12327f685b"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("7826fad4-9c6b-46a1-8e0a-a6736e80a4e5"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("7e4c054b-61dd-4f34-9b81-778a8195b3f0"), "خدمات قانونية", "Legal services" },
                    { new Guid("816a5a2d-bc5b-4153-87c0-a33f8ad5d4eb"), "المحاسبة", "Accounting" },
                    { new Guid("8259fa1c-7830-4240-bcf9-f226f23e4e89"), "نقاشة", "Painter" },
                    { new Guid("847733ff-6200-4cb4-ae1e-23e3a6285b58"), "المكتبات", "Libraries" },
                    { new Guid("8eea7039-8499-40be-ab96-38da857aea69"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("99c5572a-2f10-443b-b97e-2bed8a4d4ffa"), "إستشارات", "Consulting " },
                    { new Guid("9c9df342-8974-42fa-9149-eb17101f522a"), "الخدمات المالية", "Financial services" },
                    { new Guid("aa0c7ccf-d92b-49d2-a0be-6b0e69109401"), "ترفيه", "Entertainment" },
                    { new Guid("b43fbea8-b3b6-4e8b-bf24-838067ebf7c8"), "رعاية الأطفال", "Childcare" },
                    { new Guid("b7b65876-ab6c-4914-be73-a8427d802101"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("bb509e58-fbb0-4342-ab44-0e6bdf74c82e"), "التكييف", "Air conditioning" },
                    { new Guid("bbcc5141-6297-414b-8547-b8eff163b3e3"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("c1436b13-d1c8-4227-b49a-f2135c2e56b4"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("c6bc50a0-e989-42c5-b04b-71650e092177"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("c9d21ace-1dc5-4494-9897-141f53edb873"), "الرياضة", "Sports" },
                    { new Guid("d1506e47-c32b-48e9-8e56-2ee19749606a"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("d354fae9-ab23-4b4a-94ab-73de66054a2a"), "ضيافة", "Hospitality" },
                    { new Guid("d6000dbd-6b4b-4971-b97f-59e7dafba699"), "خدمات النقل", "Transportation services" },
                    { new Guid("d6293e2b-7667-4427-ac7f-b402a8917536"), "الخدمات الطبية", "Medical services" },
                    { new Guid("dcdbc193-bc1c-41f1-b130-979fd577a448"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("dfe93772-70e7-4d04-8d24-90a45f413172"), "تأمين", "Insurance" },
                    { new Guid("e7c60c33-1abd-43f3-b009-3a8d7f0efa5f"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("ef23916b-0a2a-4c72-8260-7d93a99b8dc4"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("f55836be-843b-49fa-ae2e-e0a0327142fe"), "إدارة المكاتب", "Office management" },
                    { new Guid("fbf91da4-f8d6-4052-bbae-622184107190"), "إصلاح الكمبيوتر", "Computer repair" }
                });
        }
    }
}
