using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRatingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRate_AspNetUsers_UserId",
                schema: "Product",
                table: "ProductRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRate_AspNetUsers_UserId",
                schema: "Service",
                table: "ServiceRate");

            migrationBuilder.DropIndex(
                name: "IX_ProductRate_UserId",
                schema: "Product",
                table: "ProductRate");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f41b92a-902b-4245-89bf-708f5e3224c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96600e49-9882-4e8d-b026-249114e2825c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc82628a-84ec-4ba4-a2f5-21fa8d86c9c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3144f1a-f3f8-4179-af86-a424667769b2");

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("07101d31-61b8-49d6-b4cb-ad978fd8bb8d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("08a2a1d5-2328-4e3b-9df2-4607d9eef627"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("090ac529-fe5d-4e32-a556-d000ed8c47ba"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("09f19426-31f2-4eba-b06a-bc693172a0e1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("10cd6e40-7fcb-4828-87c7-2158b42c012a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("16c12d0d-e628-4537-8dd9-8c04777c1b04"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("1e109557-a1de-450b-b2da-ddf6583274cd"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("21ee11e5-1dd7-4e34-9ba4-d57838404863"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("234af348-feaf-434b-821e-9fa3fe332b50"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("2ea91942-75b9-4866-9ab6-94f70e042bf0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3506c448-ff02-4168-9ed5-4f0805e89770"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3bd82edd-ad85-4824-998d-95d1a1298ca9"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3cb143e8-ee7a-4be5-8d87-57788e88b147"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("3e71d3ba-39e4-49d1-95f3-c52b628e5133"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("426aff11-7dc8-4f32-98e7-f37dbea920d1"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("43f3a438-e558-4d6f-b6d8-6642ae03e910"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("45c34d8c-d4b7-402e-ba0b-09ac4ed35ef7"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4d9d0c66-6c7b-42cd-b19c-a0798ee08d8d"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("4e025ea1-bda6-4c62-a411-95b7732ba669"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("57a85d43-31be-4610-b28a-da2a03d044d0"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5e79f60e-26e7-4e5c-9bcd-7ffcf165791a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("5f3257f8-5d24-4e9f-a4b5-20a397665f33"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67b8389b-8888-44a0-9875-3697a4fe37ae"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("67e8563a-9643-46bc-9c5a-d380eb9d9003"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7de9a5f6-ef39-4f9a-9df7-3b33e56c6c27"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("7fe14dfd-841a-42b5-9a28-8f336f685020"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("82630ebd-3bcc-4b37-aaf4-797662897f3e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("95b7d412-cb83-4b53-95c8-52a5c0cf6b79"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("9654b5ea-e975-435c-a452-46a14e19de4e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("97e5dc3d-5c47-42d3-9c3b-e0086427ebef"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a45f2529-1098-4889-af66-50e0fab08541"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a8c9fd62-e468-4597-9ddb-55e9adc56e34"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("a9b04243-f86b-4346-8538-03efc8cb534c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ad612b1e-91ea-4373-bb6f-18f5afc17e3c"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("aea22b8e-35fe-4c30-9a2e-4f3278965e2e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b2563916-4047-4024-aa25-500e25898906"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("b5079ae7-c376-4ea9-a400-f7a0abd7720e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c5b6e93e-9cba-4299-a777-4241f8713c37"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("c9e94ff0-4651-4f02-962a-1d870c61fca4"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cbfc51e1-f53f-48a7-ab87-5835c58f5067"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("cd39b9f6-43b2-48a2-b85b-c9418a598fa6"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e4a1621c-15e4-4d8c-9b5c-eb05be65501e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("e8a17c37-4dd4-427d-b681-4002019b347a"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("ebfed259-0c6f-4486-b2fe-dbf9edf1be7e"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("f7a0beb7-82c1-4d57-a784-d83235e63849"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fa8d5f83-b455-40c5-9fdc-33314b6ad664"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fc4631f5-c6d3-462a-966e-cceafa83b687"));

            migrationBuilder.DeleteData(
                schema: "Service",
                table: "ServiceCategory",
                keyColumn: "ID",
                keyValue: new Guid("fd4bb0dd-7cba-4c12-8bbb-18f47320bc05"));

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Product",
                table: "ProductRate");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Service",
                table: "ServiceRate",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRate_UserId",
                schema: "Service",
                table: "ServiceRate",
                newName: "IX_ServiceRate_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                schema: "Service",
                table: "ServiceRate",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl",
                schema: "Service",
                table: "ServiceMedia",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Discription",
                schema: "Service",
                table: "Service",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl",
                schema: "Request",
                table: "RequestMedia",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                schema: "Product",
                table: "ProductRate",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductRate_CustomerID",
                schema: "Product",
                table: "ProductRate",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRate_AspNetUsers_CustomerID",
                schema: "Product",
                table: "ProductRate",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRate_AspNetUsers_UserID",
                schema: "Service",
                table: "ServiceRate",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRate_AspNetUsers_CustomerID",
                schema: "Product",
                table: "ProductRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRate_AspNetUsers_UserID",
                schema: "Service",
                table: "ServiceRate");

            migrationBuilder.DropIndex(
                name: "IX_ProductRate_CustomerID",
                schema: "Product",
                table: "ProductRate");

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

            migrationBuilder.RenameColumn(
                name: "UserID",
                schema: "Service",
                table: "ServiceRate",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRate_UserID",
                schema: "Service",
                table: "ServiceRate",
                newName: "IX_ServiceRate_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "Service",
                table: "ServiceRate",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl",
                schema: "Service",
                table: "ServiceMedia",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Discription",
                schema: "Service",
                table: "Service",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl",
                schema: "Request",
                table: "RequestMedia",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerID",
                schema: "Product",
                table: "ProductRate",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "Product",
                table: "ProductRate",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f41b92a-902b-4245-89bf-708f5e3224c3", null, "Customer", "CUSTOMER" },
                    { "96600e49-9882-4e8d-b026-249114e2825c", null, "Vendor", "VENDOR" },
                    { "bc82628a-84ec-4ba4-a2f5-21fa8d86c9c8", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "e3144f1a-f3f8-4179-af86-a424667769b2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "Service",
                table: "ServiceCategory",
                columns: new[] { "ID", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("07101d31-61b8-49d6-b4cb-ad978fd8bb8d"), "خدمات حكومية", "Government services" },
                    { new Guid("08a2a1d5-2328-4e3b-9df2-4607d9eef627"), "خدمات الترجمة", "Translation services" },
                    { new Guid("090ac529-fe5d-4e32-a556-d000ed8c47ba"), "الخدمات الطبية", "Medical services" },
                    { new Guid("09f19426-31f2-4eba-b06a-bc693172a0e1"), "سباكة", "Plumbing" },
                    { new Guid("10cd6e40-7fcb-4828-87c7-2158b42c012a"), "الخدمات البيطرية", "Veterinary services" },
                    { new Guid("16c12d0d-e628-4537-8dd9-8c04777c1b04"), "خدمات التجميل", "Beauty services" },
                    { new Guid("1e109557-a1de-450b-b2da-ddf6583274cd"), "تقديم الطعام", "Catering " },
                    { new Guid("21ee11e5-1dd7-4e34-9ba4-d57838404863"), "إستشارات", "Consulting " },
                    { new Guid("234af348-feaf-434b-821e-9fa3fe332b50"), "مكافحة الحشرات والطيور", "Pest and bird control" },
                    { new Guid("2ea91942-75b9-4866-9ab6-94f70e042bf0"), "تنظيف حمام السباحة", "Swimming pool cleaning" },
                    { new Guid("3506c448-ff02-4168-9ed5-4f0805e89770"), "المحاسبة", "Accounting" },
                    { new Guid("3bd82edd-ad85-4824-998d-95d1a1298ca9"), "تأمين", "Insurance" },
                    { new Guid("3cb143e8-ee7a-4be5-8d87-57788e88b147"), "صيانة سيارات", "Car maintenance" },
                    { new Guid("3e71d3ba-39e4-49d1-95f3-c52b628e5133"), "كهرباء", "Electricity" },
                    { new Guid("426aff11-7dc8-4f32-98e7-f37dbea920d1"), "خدمات صناعة الأقفال", "Locksmith services" },
                    { new Guid("43f3a438-e558-4d6f-b6d8-6642ae03e910"), "خدمات التنظيف", "Cleaning services" },
                    { new Guid("45c34d8c-d4b7-402e-ba0b-09ac4ed35ef7"), "التنظيف الجاف", "Dry cleaning" },
                    { new Guid("4d9d0c66-6c7b-42cd-b19c-a0798ee08d8d"), "العناية بالحديقة", "Garden care" },
                    { new Guid("4e025ea1-bda6-4c62-a411-95b7732ba669"), "ترفيه", "Entertainment" },
                    { new Guid("57a85d43-31be-4610-b28a-da2a03d044d0"), "تدريب اللياقة البدنية", "Fitness training" },
                    { new Guid("5e79f60e-26e7-4e5c-9bcd-7ffcf165791a"), "خدمات النقل", "Transportation services" },
                    { new Guid("5f3257f8-5d24-4e9f-a4b5-20a397665f33"), "خدمات قانونية", "Legal services" },
                    { new Guid("67b8389b-8888-44a0-9875-3697a4fe37ae"), "نقاشة", "Painter" },
                    { new Guid("67e8563a-9643-46bc-9c5a-d380eb9d9003"), "خدمات التوصيل", "Delivery services" },
                    { new Guid("7de9a5f6-ef39-4f9a-9df7-3b33e56c6c27"), "التكييف", "Air conditioning" },
                    { new Guid("7fe14dfd-841a-42b5-9a28-8f336f685020"), "الإعلان والتسويق", "Advertising and marketing" },
                    { new Guid("82630ebd-3bcc-4b37-aaf4-797662897f3e"), "خدمات أخرى", "Other services" },
                    { new Guid("95b7d412-cb83-4b53-95c8-52a5c0cf6b79"), "خدمات سيارات الأجرة", "Taxi services" },
                    { new Guid("9654b5ea-e975-435c-a452-46a14e19de4e"), "إصلاح الكمبيوتر", "Computer repair" },
                    { new Guid("97e5dc3d-5c47-42d3-9c3b-e0086427ebef"), "البناء", "Construction" },
                    { new Guid("a45f2529-1098-4889-af66-50e0fab08541"), "الخدمات المالية", "Financial services" },
                    { new Guid("a8c9fd62-e468-4597-9ddb-55e9adc56e34"), "إدارة المكاتب", "Office management" },
                    { new Guid("a9b04243-f86b-4346-8538-03efc8cb534c"), "نجارة", "Carpenter " },
                    { new Guid("ad612b1e-91ea-4373-bb6f-18f5afc17e3c"), "ضيافة", "Hospitality" },
                    { new Guid("aea22b8e-35fe-4c30-9a2e-4f3278965e2e"), "تركيب و صيانة الاجهزة المنزلية", "Installation and maintenance of home appliances" },
                    { new Guid("b2563916-4047-4024-aa25-500e25898906"), "التخطيط للأحداث", "Event planning" },
                    { new Guid("b5079ae7-c376-4ea9-a400-f7a0abd7720e"), "حدائق و منتجعات ترفيهيه", "Parks and recreation" },
                    { new Guid("c5b6e93e-9cba-4299-a777-4241f8713c37"), "تصميم وتطوير مواقع الويب", "Web design and development" },
                    { new Guid("c9e94ff0-4651-4f02-962a-1d870c61fca4"), "خدمات غسيل الملابس", "Laundry services" },
                    { new Guid("cbfc51e1-f53f-48a7-ab87-5835c58f5067"), "خدمات تكنولوجيا المعلومات", "Information technology services" },
                    { new Guid("cd39b9f6-43b2-48a2-b85b-c9418a598fa6"), "العقارات", "Real estate" },
                    { new Guid("e4a1621c-15e4-4d8c-9b5c-eb05be65501e"), "ساتلايت ورسيفر", "Satellite and receiver" },
                    { new Guid("e8a17c37-4dd4-427d-b681-4002019b347a"), "الرياضة", "Sports" },
                    { new Guid("ebfed259-0c6f-4486-b2fe-dbf9edf1be7e"), "رعاية الحيوانات الاليفة", "Pet care" },
                    { new Guid("f7a0beb7-82c1-4d57-a784-d83235e63849"), "تسقيف", "Roofing" },
                    { new Guid("fa8d5f83-b455-40c5-9fdc-33314b6ad664"), "رعاية الأطفال", "Childcare" },
                    { new Guid("fc4631f5-c6d3-462a-966e-cceafa83b687"), "المكتبات", "Libraries" },
                    { new Guid("fd4bb0dd-7cba-4c12-8bbb-18f47320bc05"), "توصيل طلبات الطعام", "Food delivery" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductRate_UserId",
                schema: "Product",
                table: "ProductRate",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRate_AspNetUsers_UserId",
                schema: "Product",
                table: "ProductRate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRate_AspNetUsers_UserId",
                schema: "Service",
                table: "ServiceRate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
