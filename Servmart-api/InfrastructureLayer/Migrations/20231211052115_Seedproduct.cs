using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class Seedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0e9f6806-5417-4496-b96a-bc4f25157e02", null, "Customer", "CUSTOMER" },
                    { "2f4dc293-fbc7-46e9-98a3-52aa429c2278", null, "Vendor", "VENDOR" },
                    { "bf68199a-554d-4219-adba-70011bc4e93c", null, "Admin", "ADMIN" },
                    { "d670b6e8-d816-461f-9b82-e96e4b3228b0", null, "ServiceProvider", "SERVICEPROVIDER" }
                });

            migrationBuilder.InsertData(
                schema: "Product",
                table: "ProductCategory",
                columns: new[] { "ID", "Catagory" },
                values: new object[,]
                {
                    { new Guid("0d6a415a-ea2e-474b-aa6a-10aa1fd8f871"), "العاب فيديو  " },
                    { new Guid("14dc9d55-0ef8-41ee-9e28-7fe9d6b3aac2"), "الآلكترونيات" },
                    { new Guid("46e46759-0060-47ee-bdb2-ecb518e00a88"), "مستلزمات السيارات  " },
                    { new Guid("48f25c1c-c53e-4557-9f22-7112f2959fb1"), "الاجهزة المنزلية  " },
                    { new Guid("60e85931-a8ac-4956-a707-39b432a4e4d3"), " منتجات الاطفال" },
                    { new Guid("8630e49a-afb0-466f-97b7-5bbe284e10f8"), "كتب   " },
                    { new Guid("a4eb2d10-4afc-47e7-97e4-06f8587a339e"), "المشروبات  " },
                    { new Guid("a74c5106-042a-4993-bfe4-b44dceeb3718"), "العناية المنزلية  " },
                    { new Guid("ba563a74-1edd-4817-b724-a826e1c2dbff"), "الاغذية" },
                    { new Guid("e8848de8-714a-4e80-a982-6baf45c4dd7b"), "ملابس " },
                    { new Guid("f7bd66a0-e364-4847-9e6a-2c8426ba32b7"), "مستلزمات المنزل   " }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("13add710-ac37-4f33-b4e8-2e7fcaa17c6d"), "رعاية الأطفال", "Childcare" },
                    { new Guid("16cfb998-a18a-4568-af51-49156111120d"), "خدمات التجميل", "Beauty services" },
                    { new Guid("23a4dcc0-c2f5-43ae-9c51-6493bd6576ee"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("25fffb1a-e7d2-40c6-862a-e1a497732901"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("270dc038-a3ad-4824-ae3e-1a92cf47b9c4"), "سباكة", "Plumbing" },
                    { new Guid("2752b06b-a012-4266-a771-02a968bd7396"), "الرياضة", "Sports" },
                    { new Guid("28f99b0c-7f08-4de4-9e92-4bea16f9aaab"), "نقاشة", "Painter" },
                    { new Guid("2ebbb417-fbd6-4433-a35e-a720cbb43b7a"), "الخدمات المالية", "Financial services" },
                    { new Guid("323463a4-26f0-43f5-b90f-e9e9cc9c1da1"), "خدمات الترجمة", "Translation services" },
                    { new Guid("36c4fe59-20ed-45be-968e-f76720a07f14"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("3f1c75b2-df64-4f53-a03d-78f165777c11"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("4880d7a4-0b22-467b-8d2d-75738b2e5cd8"), "خدمات قانونية", "Legal services" },
                    { new Guid("4da7dc08-5ce4-4204-9a2a-f6c9f729b2fa"), "إستشارات", "Consulting " },
                    { new Guid("50493ecd-93bc-4b82-a3bb-f91253c1a021"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("50ff647f-22c0-4367-b688-db911820688d"), "خدمات أخرى", "Other services" },
                    { new Guid("55dae3ea-a1df-4874-83a0-44adb25c0e0d"), "البناء", "Construction" },
                    { new Guid("5893bf87-6500-418a-80bb-753214bb37b8"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("59a5bb14-adc2-471e-9995-efe551a51170"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("6dc00977-2f4f-4a23-bcb7-3939b9d00d5f"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("6ebf643f-4c64-4269-869e-39493b701613"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("787f5c20-736d-40a0-8c1d-98b5921a8350"), "خدمات النقل", "Transportation services" },
                    { new Guid("7a5cb5d5-6e71-41b3-b29f-3887db7c6672"), "الخدمات الطبية", "Medical services" },
                    { new Guid("7cec067e-17f2-425f-a6b4-4398bdbc1fac"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("87cab33a-be45-4590-b10a-5b55d10741a5"), "التكييف", "Air conditioning" },
                    { new Guid("87dff1d9-aa27-4bb5-b2ee-990a637b6273"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("8b6e8c13-857f-4b6e-a3c7-88275b48f5ea"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("8e1f0cc3-ce3f-4500-a567-c2f0e3fdf7e3"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("8e997bca-4666-482c-89f6-f0140107569a"), "تأمين", "Insurance" },
                    { new Guid("8fc6e93d-50cf-474b-a412-52df6f3b6e93"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("963f8360-caa3-4641-9727-b4dd62b96bb5"), "العقارات", "Real estate" },
                    { new Guid("96521463-267b-40dd-a15e-9a1fa9d074b0"), "العناية بالحديقة", "Garden care" },
                    { new Guid("9b2e53d9-8959-46e1-a38e-aad38150787b"), "ترفيه", "Entertainment" },
                    { new Guid("9bf93beb-d23f-456a-bc39-a7cd03add2fb"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("9c22e75c-4e94-461c-b76f-53053c8d1499"), "تسقيف", "Roofing" },
                    { new Guid("9d8285d5-7d16-4c72-ba3a-d0b5ca393149"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("9e92cb31-df62-42b8-802a-33ff669ab4b7"), "نجارة", "Carpenter " },
                    { new Guid("d0de0255-9042-4455-8a25-8ff070fe7aba"), "خدمات حكومية", "Government services" },
                    { new Guid("d30ad13a-f6ef-4b51-8172-515d1dc3ad38"), "ضيافة", "Hospitality" },
                    { new Guid("d5527b2f-553d-4bef-9e48-ed50d1cd4a56"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("d7c567f3-a8cd-432a-a88a-1f46da93ceff"), "كهرباء", "Electricity" },
                    { new Guid("d8723a1d-98da-4f73-b3c2-734193534461"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("e2789d22-c668-4407-8953-fa37c1469086"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("e50c1f9f-f4e9-4b9b-bb7e-395522196d6f"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("e70c9dda-fcf6-4d43-8439-c58196f78074"), "المحاسبة", "Accounting" },
                    { new Guid("e87ef9ec-e4b0-4c47-952c-6413d19851ed"), "إدارة المكاتب", "Office management" },
                    { new Guid("f05a33d9-5e75-42c1-9d9f-4a48db41e1a5"), "تقديم الطعام", "Catering " },
                    { new Guid("f4b56f01-cbd5-4d6a-9014-36cd94c70e71"), "المكتبات", "Libraries" },
                    { new Guid("f6acf4d2-cd8a-4b64-8837-5d179cf623ab"), "الخدمات البيطرية", "Veterinary services" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e9f6806-5417-4496-b96a-bc4f25157e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f4dc293-fbc7-46e9-98a3-52aa429c2278");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf68199a-554d-4219-adba-70011bc4e93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d670b6e8-d816-461f-9b82-e96e4b3228b0");

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("0d6a415a-ea2e-474b-aa6a-10aa1fd8f871"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("14dc9d55-0ef8-41ee-9e28-7fe9d6b3aac2"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("46e46759-0060-47ee-bdb2-ecb518e00a88"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("48f25c1c-c53e-4557-9f22-7112f2959fb1"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("60e85931-a8ac-4956-a707-39b432a4e4d3"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("8630e49a-afb0-466f-97b7-5bbe284e10f8"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("a4eb2d10-4afc-47e7-97e4-06f8587a339e"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("a74c5106-042a-4993-bfe4-b44dceeb3718"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("ba563a74-1edd-4817-b724-a826e1c2dbff"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("e8848de8-714a-4e80-a982-6baf45c4dd7b"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: new Guid("f7bd66a0-e364-4847-9e6a-2c8426ba32b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("13add710-ac37-4f33-b4e8-2e7fcaa17c6d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("16cfb998-a18a-4568-af51-49156111120d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("23a4dcc0-c2f5-43ae-9c51-6493bd6576ee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("25fffb1a-e7d2-40c6-862a-e1a497732901"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("270dc038-a3ad-4824-ae3e-1a92cf47b9c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2752b06b-a012-4266-a771-02a968bd7396"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("28f99b0c-7f08-4de4-9e92-4bea16f9aaab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ebbb417-fbd6-4433-a35e-a720cbb43b7a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("323463a4-26f0-43f5-b90f-e9e9cc9c1da1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("36c4fe59-20ed-45be-968e-f76720a07f14"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3f1c75b2-df64-4f53-a03d-78f165777c11"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4880d7a4-0b22-467b-8d2d-75738b2e5cd8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4da7dc08-5ce4-4204-9a2a-f6c9f729b2fa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("50493ecd-93bc-4b82-a3bb-f91253c1a021"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("50ff647f-22c0-4367-b688-db911820688d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("55dae3ea-a1df-4874-83a0-44adb25c0e0d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5893bf87-6500-418a-80bb-753214bb37b8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("59a5bb14-adc2-471e-9995-efe551a51170"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6dc00977-2f4f-4a23-bcb7-3939b9d00d5f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6ebf643f-4c64-4269-869e-39493b701613"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("787f5c20-736d-40a0-8c1d-98b5921a8350"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7a5cb5d5-6e71-41b3-b29f-3887db7c6672"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7cec067e-17f2-425f-a6b4-4398bdbc1fac"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87cab33a-be45-4590-b10a-5b55d10741a5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87dff1d9-aa27-4bb5-b2ee-990a637b6273"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8b6e8c13-857f-4b6e-a3c7-88275b48f5ea"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8e1f0cc3-ce3f-4500-a567-c2f0e3fdf7e3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8e997bca-4666-482c-89f6-f0140107569a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8fc6e93d-50cf-474b-a412-52df6f3b6e93"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("963f8360-caa3-4641-9727-b4dd62b96bb5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("96521463-267b-40dd-a15e-9a1fa9d074b0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9b2e53d9-8959-46e1-a38e-aad38150787b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9bf93beb-d23f-456a-bc39-a7cd03add2fb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9c22e75c-4e94-461c-b76f-53053c8d1499"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9d8285d5-7d16-4c72-ba3a-d0b5ca393149"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9e92cb31-df62-42b8-802a-33ff669ab4b7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d0de0255-9042-4455-8a25-8ff070fe7aba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d30ad13a-f6ef-4b51-8172-515d1dc3ad38"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d5527b2f-553d-4bef-9e48-ed50d1cd4a56"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d7c567f3-a8cd-432a-a88a-1f46da93ceff"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d8723a1d-98da-4f73-b3c2-734193534461"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e2789d22-c668-4407-8953-fa37c1469086"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e50c1f9f-f4e9-4b9b-bb7e-395522196d6f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e70c9dda-fcf6-4d43-8439-c58196f78074"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e87ef9ec-e4b0-4c47-952c-6413d19851ed"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f05a33d9-5e75-42c1-9d9f-4a48db41e1a5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f4b56f01-cbd5-4d6a-9014-36cd94c70e71"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f6acf4d2-cd8a-4b64-8837-5d179cf623ab"));

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
    }
}
