using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfrastructureLayer.Migrations
{
    /// <inheritdoc />
    public partial class databaseUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
