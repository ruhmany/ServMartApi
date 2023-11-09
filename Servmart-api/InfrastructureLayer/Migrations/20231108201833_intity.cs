using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class intity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "064e917f-27a7-4087-8b11-dbe4bcf9a42b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10f33124-7f79-448e-8627-42c07ebcdc73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82b817e4-3ecd-4a92-aff9-a9e6c4825b79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d46e440c-2747-4afd-87d5-12d048bafa14");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("02f48749-8856-4963-8573-2b67c4e67c5a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("08491cfd-2404-44a1-9e18-c8551d4ac431"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("126cac67-937f-4456-b573-794438c7bc75"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("12db5367-bc2e-4913-9450-906c9a9deed4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1c3bff4e-b9a8-4917-9d72-20f0901ce36c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e6b71ac-8b4e-463c-b876-a3967f946105"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("20e49b46-286a-4f09-9917-161e68e4afe0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2487ed2c-e932-4d8c-bd28-4bdb4b5785f5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2cd13953-659c-4cb4-a76d-509143c7a006"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3347148b-18ac-43aa-b481-d9f824c8f8ab"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3ed45f3a-a20d-489e-8860-2e1584f743be"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("439da446-24d4-4249-abf3-27e8f41bb595"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e0eb368-686f-4146-9216-a99ec478d832"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5576fa5c-e2bf-468c-9f09-f8adc942e88a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("613f46fa-ef81-4a86-b1d5-448107d50540"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6ca2016b-b9ba-47da-a22e-3cdf8b85acf6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6d309b8d-7086-4d94-b4c3-7d3da985d77e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6f160814-d4f6-4e03-a280-ed87b217cf58"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7167a588-50d1-41f9-9bc4-b99a71763380"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("72495378-c230-4608-8e41-09bdd96b5216"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("737253dd-a454-4db9-bd89-16e1407b2f94"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("73f9ee4d-db52-437d-92d9-ab0bffdbc276"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("793625c8-a565-4ace-a3a4-bbcf7e27c2ca"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7d305e60-509c-4401-b8be-53d5c50a7a6b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("874d31a5-c72c-4c1c-b315-a490d9501c91"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("89dcbb9e-bc1d-405c-b224-98674a30f464"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("90c9d76a-2910-4313-b33d-8a9bbe34cf1e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("93e030d9-c5fb-445d-b9b3-e7dc94abf3f5"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95278a91-0eef-4add-b72b-e13cc82e291c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95929785-95fb-4540-a89f-a8fd1aac6bc8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9963f0a8-201c-45be-9324-01fa2d5670c6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9c907c21-0682-44ce-884f-9d4ad3975b2f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a11dd883-3198-40de-8645-113b76182119"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b859413c-a70a-4113-ba23-3554ceb7e1ad"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("beb432f8-3f6e-45c2-9ab6-5fc07059651d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c1ed8870-4c67-4558-a513-80e8ec4aae26"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ccc581d5-79e7-44b9-96ff-bc01c850c24e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d6330ebd-5576-4614-b75a-6980f5f0bc75"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d8fe1dd0-27a0-4557-b1d2-ea03aaf5669b"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("da8e032c-7844-44c3-b144-b00d435cf3c7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df1ab498-8c10-4576-bc7d-a0528e5254f4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ea663a5f-352f-4e3f-8c3a-64eb18bac414"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ede0025e-81e5-4f26-a6cd-74c691e810eb"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f55326b3-2636-4949-ba88-5948162e8d9c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f5e98520-10fc-4776-a4b9-314ace5e79d6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f878d782-470d-4b82-ae56-5fae03c2468c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fa5a0e67-e9a2-4407-9dca-64954c67ee8a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fcaff786-ebe2-4364-a6eb-8b3bd1804980"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40f860d2-97c3-4292-aa6c-f18351a1617d", null, "Customer", "CUSTOMER" },
                    { "43cd27dd-23dc-4d50-bf95-cd3912fd48e5", null, "Admin", "ADMIN" },
                    { "469bf326-601b-43c4-a56b-d2072c8df978", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "543814fc-1815-43e1-8e47-c03400dae9de", null, "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0375b579-8c3c-46fe-a688-8cec771e1390"), "رعاية الأطفال", "Childcare" },
                    { new Guid("06d71b51-1db3-4c5c-8426-75f1d5b3057d"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("078559c5-9ea5-4e7a-b144-904eab54c76a"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("124fcd15-4eb1-477c-adb7-646ca0e4ac39"), "البناء", "Construction" },
                    { new Guid("15263ad1-4909-4e62-ad5f-e826c0baefaa"), "إدارة المكاتب", "Office management" },
                    { new Guid("158cee74-3a77-4b16-aff7-63608a34f2b0"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("1807267a-e421-49e0-9513-bba3aa1a91e3"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("237dd9d0-7272-42de-8906-fa7ef0c8f3be"), "إستشارات", "Consulting " },
                    { new Guid("3ca5e4c3-ea56-4ba6-83ad-e0f6dcdd07e3"), "كهرباء", "Electricity" },
                    { new Guid("3e6167a4-ebe1-440d-9b7a-80100e3fdbda"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("41363fe6-60fc-446a-8e84-02c622a000fd"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("44972479-d2a9-434f-a783-40b8ca3cfb21"), "سباكة", "Plumbing" },
                    { new Guid("4f4e9752-346e-49d1-9e00-e51a65d13028"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("54fafdbe-b6c4-4965-af22-5c6c42d96208"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("55ff3b21-d533-4dff-8a96-5e8f5c4c5ff1"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("5847e6ad-d6b9-4076-b9bd-077a046b28e3"), "خدمات قانونية", "Legal services" },
                    { new Guid("5f4353bb-180a-4104-b0f6-1a1a9a668e53"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("645a439e-05aa-4fc4-b4b1-f35c7393e2c4"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("6981cb78-2c48-448f-9253-e55a1ced2d74"), "التكييف", "Air conditioning" },
                    { new Guid("6d43aee6-6c52-469f-a059-f00faa9869cf"), "الخدمات الطبية", "Medical services" },
                    { new Guid("7866ef4d-3518-449e-a4bc-3a2927522646"), "خدمات الترجمة", "Translation services" },
                    { new Guid("7abe39ae-7138-4541-a9c5-70c9582d7528"), "ترفيه", "Entertainment" },
                    { new Guid("7f8788a6-eb19-44b5-a15f-42d57bce8dd4"), "خدمات التجميل", "Beauty services" },
                    { new Guid("87bb2bb5-0d3f-44a7-8823-91927333f0fa"), "تسقيف", "Roofing" },
                    { new Guid("89ffa741-39b5-472d-a3e4-f0dcddb32edf"), "العناية بالحديقة", "Garden care" },
                    { new Guid("8c63ac3c-eab6-4885-8f1d-9492ba665182"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("9eeb483f-5f63-4e6f-bd33-26e64f9172d8"), "الخدمات المالية", "Financial services" },
                    { new Guid("aa096c4c-d15f-4332-a69f-df4b078868dc"), "تقديم الطعام", "Catering " },
                    { new Guid("ac7352c7-a070-46f6-87a1-8f69f839beff"), "المكتبات", "Libraries" },
                    { new Guid("b0b9c904-33e4-4484-a789-a8c3e8c30ce3"), "خدمات أخرى", "Other services" },
                    { new Guid("b2670c2c-c0a0-42cd-843d-d6580411d460"), "خدمات حكومية", "Government services" },
                    { new Guid("b4f68536-ff8d-4944-8538-238cda937d22"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("b817d9f9-8842-4a27-94a1-9fb7264b5b7f"), "خدمات النقل", "Transportation services" },
                    { new Guid("b9de7b73-9f78-49e1-8a62-bfd53094a13e"), "تأمين", "Insurance" },
                    { new Guid("bcbe4fd7-60d6-4dcb-a955-ea73216378b1"), "ضيافة", "Hospitality" },
                    { new Guid("c2c9e0d5-fe3b-4029-b6e7-5abdfa771e03"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("d21a77ec-8965-412e-a813-585dd95da802"), "نجارة", "Carpenter " },
                    { new Guid("d2bbaafd-f286-4c5e-920f-0ebc7baf9aa7"), "نقاشة", "Painter" },
                    { new Guid("dda53ad8-e389-4158-aa29-3d5b66798f95"), "الرياضة", "Sports" },
                    { new Guid("df658c50-410a-4c0b-a5a3-65f214b3d75a"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("e568f495-d873-4ef7-b85e-0c9a54a8f699"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("e6b2c120-a081-4b18-bb26-1edec8a0e9ee"), "المحاسبة", "Accounting" },
                    { new Guid("ef3cf33d-0473-4ff1-a7fe-a01de4343401"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("ef3e92f9-9814-436e-ae8b-c112bbb48d37"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("f1bd7218-dc92-487f-9b09-262a3129e323"), "العقارات", "Real estate" },
                    { new Guid("f7d57ab1-71f7-463f-850d-d48bf27589aa"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("facdaec9-6714-4f96-a906-dfe46cc16c1f"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("ff81201b-fc2c-48f1-9e69-b7a7b392d3a7"), "تدريب اللياقة البدنية", "Fitness training" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f860d2-97c3-4292-aa6c-f18351a1617d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43cd27dd-23dc-4d50-bf95-cd3912fd48e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "469bf326-601b-43c4-a56b-d2072c8df978");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "543814fc-1815-43e1-8e47-c03400dae9de");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("0375b579-8c3c-46fe-a688-8cec771e1390"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("06d71b51-1db3-4c5c-8426-75f1d5b3057d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("078559c5-9ea5-4e7a-b144-904eab54c76a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("124fcd15-4eb1-477c-adb7-646ca0e4ac39"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("15263ad1-4909-4e62-ad5f-e826c0baefaa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("158cee74-3a77-4b16-aff7-63608a34f2b0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1807267a-e421-49e0-9513-bba3aa1a91e3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("237dd9d0-7272-42de-8906-fa7ef0c8f3be"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3ca5e4c3-ea56-4ba6-83ad-e0f6dcdd07e3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3e6167a4-ebe1-440d-9b7a-80100e3fdbda"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("41363fe6-60fc-446a-8e84-02c622a000fd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("44972479-d2a9-434f-a783-40b8ca3cfb21"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4f4e9752-346e-49d1-9e00-e51a65d13028"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("54fafdbe-b6c4-4965-af22-5c6c42d96208"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("55ff3b21-d533-4dff-8a96-5e8f5c4c5ff1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5847e6ad-d6b9-4076-b9bd-077a046b28e3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5f4353bb-180a-4104-b0f6-1a1a9a668e53"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("645a439e-05aa-4fc4-b4b1-f35c7393e2c4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6981cb78-2c48-448f-9253-e55a1ced2d74"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("6d43aee6-6c52-469f-a059-f00faa9869cf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7866ef4d-3518-449e-a4bc-3a2927522646"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7abe39ae-7138-4541-a9c5-70c9582d7528"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7f8788a6-eb19-44b5-a15f-42d57bce8dd4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("87bb2bb5-0d3f-44a7-8823-91927333f0fa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("89ffa741-39b5-472d-a3e4-f0dcddb32edf"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("8c63ac3c-eab6-4885-8f1d-9492ba665182"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9eeb483f-5f63-4e6f-bd33-26e64f9172d8"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aa096c4c-d15f-4332-a69f-df4b078868dc"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ac7352c7-a070-46f6-87a1-8f69f839beff"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b0b9c904-33e4-4484-a789-a8c3e8c30ce3"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b2670c2c-c0a0-42cd-843d-d6580411d460"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b4f68536-ff8d-4944-8538-238cda937d22"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b817d9f9-8842-4a27-94a1-9fb7264b5b7f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b9de7b73-9f78-49e1-8a62-bfd53094a13e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("bcbe4fd7-60d6-4dcb-a955-ea73216378b1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c2c9e0d5-fe3b-4029-b6e7-5abdfa771e03"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d21a77ec-8965-412e-a813-585dd95da802"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("d2bbaafd-f286-4c5e-920f-0ebc7baf9aa7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("dda53ad8-e389-4158-aa29-3d5b66798f95"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("df658c50-410a-4c0b-a5a3-65f214b3d75a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e568f495-d873-4ef7-b85e-0c9a54a8f699"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e6b2c120-a081-4b18-bb26-1edec8a0e9ee"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ef3cf33d-0473-4ff1-a7fe-a01de4343401"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ef3e92f9-9814-436e-ae8b-c112bbb48d37"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f1bd7218-dc92-487f-9b09-262a3129e323"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f7d57ab1-71f7-463f-850d-d48bf27589aa"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("facdaec9-6714-4f96-a906-dfe46cc16c1f"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ff81201b-fc2c-48f1-9e69-b7a7b392d3a7"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "064e917f-27a7-4087-8b11-dbe4bcf9a42b", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "10f33124-7f79-448e-8627-42c07ebcdc73", null, "Vendor", "VENDOR" },
                    { "82b817e4-3ecd-4a92-aff9-a9e6c4825b79", null, "Customer", "CUSTOMER" },
                    { "d46e440c-2747-4afd-87d5-12d048bafa14", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("02f48749-8856-4963-8573-2b67c4e67c5a"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("08491cfd-2404-44a1-9e18-c8551d4ac431"), "الخدمات الطبية", "Medical services" },
                    { new Guid("126cac67-937f-4456-b573-794438c7bc75"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("12db5367-bc2e-4913-9450-906c9a9deed4"), "المكتبات", "Libraries" },
                    { new Guid("1c3bff4e-b9a8-4917-9d72-20f0901ce36c"), "تقديم الطعام", "Catering " },
                    { new Guid("1e6b71ac-8b4e-463c-b876-a3967f946105"), "سباكة", "Plumbing" },
                    { new Guid("20e49b46-286a-4f09-9917-161e68e4afe0"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("2487ed2c-e932-4d8c-bd28-4bdb4b5785f5"), "إستشارات", "Consulting " },
                    { new Guid("2cd13953-659c-4cb4-a76d-509143c7a006"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("3347148b-18ac-43aa-b481-d9f824c8f8ab"), "العقارات", "Real estate" },
                    { new Guid("3ed45f3a-a20d-489e-8860-2e1584f743be"), "تسقيف", "Roofing" },
                    { new Guid("439da446-24d4-4249-abf3-27e8f41bb595"), "خدمات حكومية", "Government services" },
                    { new Guid("4e0eb368-686f-4146-9216-a99ec478d832"), "نجارة", "Carpenter " },
                    { new Guid("5576fa5c-e2bf-468c-9f09-f8adc942e88a"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("613f46fa-ef81-4a86-b1d5-448107d50540"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("6ca2016b-b9ba-47da-a22e-3cdf8b85acf6"), "المحاسبة", "Accounting" },
                    { new Guid("6d309b8d-7086-4d94-b4c3-7d3da985d77e"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("6f160814-d4f6-4e03-a280-ed87b217cf58"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("7167a588-50d1-41f9-9bc4-b99a71763380"), "خدمات النقل", "Transportation services" },
                    { new Guid("72495378-c230-4608-8e41-09bdd96b5216"), "إدارة المكاتب", "Office management" },
                    { new Guid("737253dd-a454-4db9-bd89-16e1407b2f94"), "البناء", "Construction" },
                    { new Guid("73f9ee4d-db52-437d-92d9-ab0bffdbc276"), "توصيل طلبات الطعام", "Food delivery" },
                    { new Guid("793625c8-a565-4ace-a3a4-bbcf7e27c2ca"), "العناية بالحديقة", "Garden care" },
                    { new Guid("7d305e60-509c-4401-b8be-53d5c50a7a6b"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("874d31a5-c72c-4c1c-b315-a490d9501c91"), "خدمات الترجمة", "Translation services" },
                    { new Guid("89dcbb9e-bc1d-405c-b224-98674a30f464"), "رعاية الأطفال", "Childcare" },
                    { new Guid("90c9d76a-2910-4313-b33d-8a9bbe34cf1e"), "الخدمات المالية", "Financial services" },
                    { new Guid("93e030d9-c5fb-445d-b9b3-e7dc94abf3f5"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("95278a91-0eef-4add-b72b-e13cc82e291c"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("95929785-95fb-4540-a89f-a8fd1aac6bc8"), "ضيافة", "Hospitality" },
                    { new Guid("9963f0a8-201c-45be-9324-01fa2d5670c6"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("9c907c21-0682-44ce-884f-9d4ad3975b2f"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("a11dd883-3198-40de-8645-113b76182119"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("b859413c-a70a-4113-ba23-3554ceb7e1ad"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("beb432f8-3f6e-45c2-9ab6-5fc07059651d"), "خدمات التجميل", "Beauty services" },
                    { new Guid("c1ed8870-4c67-4558-a513-80e8ec4aae26"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("ccc581d5-79e7-44b9-96ff-bc01c850c24e"), "خدمات أخرى", "Other services" },
                    { new Guid("d6330ebd-5576-4614-b75a-6980f5f0bc75"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("d8fe1dd0-27a0-4557-b1d2-ea03aaf5669b"), "تأمين", "Insurance" },
                    { new Guid("da8e032c-7844-44c3-b144-b00d435cf3c7"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("df1ab498-8c10-4576-bc7d-a0528e5254f4"), "التكييف", "Air conditioning" },
                    { new Guid("ea663a5f-352f-4e3f-8c3a-64eb18bac414"), "ترفيه", "Entertainment" },
                    { new Guid("ede0025e-81e5-4f26-a6cd-74c691e810eb"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("f55326b3-2636-4949-ba88-5948162e8d9c"), "خدمات قانونية", "Legal services" },
                    { new Guid("f5e98520-10fc-4776-a4b9-314ace5e79d6"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("f878d782-470d-4b82-ae56-5fae03c2468c"), "الرياضة", "Sports" },
                    { new Guid("fa5a0e67-e9a2-4407-9dca-64954c67ee8a"), "كهرباء", "Electricity" },
                    { new Guid("fcaff786-ebe2-4364-a6eb-8b3bd1804980"), "نقاشة", "Painter" }
                });
        }
    }
}
