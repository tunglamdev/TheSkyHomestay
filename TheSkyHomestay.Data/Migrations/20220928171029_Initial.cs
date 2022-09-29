using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8090)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8178)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8551)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(8661)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CINo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "default.png"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9210)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9339)),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7650)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(7773)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Stars = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "RoomCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouristId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3268))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_User_TouristId",
                        column: x => x.TouristId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouristId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Vote = table.Column<int>(type: "int", nullable: false, defaultValue: 5),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2456)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2552)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_User_TouristId",
                        column: x => x.TouristId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(2916)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(3012)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomImages_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBookings",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9855)),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 171, DateTimeKind.Local).AddTicks(9943)),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    BookingTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(66)),
                    CancelingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookings", x => new { x.BillId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_RoomBookings_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceBookings",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookingTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(1338)),
                    CancelingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceBookings", x => new { x.BillId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServiceBookings_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceBookings_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15") },
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4") }
                });

            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "CreatedTime", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4651), "Phòng 1 giường", new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4652) },
                    { 2, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4653), "Phòng 2 giường", new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4653) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "Price", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4666), "200.000/lượt/24h, xe được bao xăng chạy thoải mái", "Thuê xe máy", 200000m, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4667) },
                    { 2, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4668), "50.000/lượt/người, được hỗ trợ kính lặn biển, vợt bắt nhum", "Lặn nhum", 50000m, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4668) },
                    { 3, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4669), "50.000/lượt/người, hướng dẫn leo núi, hỗ trợ nước uống", "Chinh phục Ma Thiên Lãnh", 50000m, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4669) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "CINo", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("372ea575-2536-4076-9bab-3e3138de495f"), 0, "admin.jpg", "777888999", "e6935f51-835f-4f57-9d97-5d1c9e89589f", "admin@gmail.com", false, false, null, "John", null, null, "AQAAAAEAACcQAAAAEJD7DTzxsIXn7Be2lA1oQ71kt6/I/6NjyFQKLgyp1v4udK5nrQ2sJu51fQADaTRd4Q==", null, "0123456789", false, null, false, null },
                    { new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 0, "an.jpg", "444555666", "f4fa4814-79e4-4687-a51e-cd8793fb4143", "an@gmail.com", false, false, null, "Nguyễn Văn An", null, null, "AQAAAAEAACcQAAAAEFhwflc7VhluZxmYQtGzQ/R6Wpl+KmSbnzlH8SelxGeMpsTAiUuLMlSm44+EQC3E0Q==", null, "0338307994", false, null, false, null },
                    { new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 0, "lam.jpg", "333444555", "bb87e47d-be66-46ca-8cd4-e6c43578d68e", "lam@gmail.com", false, false, null, "Nguyễn Tùng Lâm", null, null, "AQAAAAEAACcQAAAAELTwqetns19JKaQTtfvxH1TtzhulQijlOWYB4JmxF5I0Vp3b49nSTyg7tqUyJ6sp1A==", null, "0338307449", false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), "c58b3bbe-5794-4ff4-9f7f-fbd86bc305a5", "Tourist role", "tourist", "tourist" },
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), "ba37df17-85ca-4bc1-aa39-56f8b42edcb1", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "CreatedTime", "TouristId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3892), new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4") },
                    { 2, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3894), new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "Name", "Price", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4533), "Hollywood", 500000m, 5.0, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4535) },
                    { 2, 1, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4536), "Tokyo", 500000m, 5.0, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4537) },
                    { 3, 1, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4538), "Berlin", 500000m, 4.5, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4538) },
                    { 4, 2, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4539), "Paris", 800000m, 5.0, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4539) },
                    { 5, 2, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4540), "California", 800000m, 5.0, new DateTime(2022, 9, 29, 0, 10, 29, 172, DateTimeKind.Local).AddTicks(4540) }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comment", "CreatedTime", "RoomId", "TouristId", "UpdatedTime", "Vote" },
                values: new object[,]
                {
                    { 1, "Phòng rất đẹp! Anh chủ rất dễ thương luôn!", new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3871), 1, new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3872), 5 },
                    { 2, "Phòng rất đẹp! Anh chủ rất dễ thương luôn!", new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3874), 3, new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3875), 5 }
                });

            migrationBuilder.InsertData(
                table: "RoomBookings",
                columns: new[] { "BillId", "RoomId", "BookingTime", "CancelingTime", "CheckInDate", "CheckOutDate", "Deposit", "Price", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3915), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m, 500000m, 500000m },
                    { 1, 3, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3917), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m, 500000m, 500000m },
                    { 2, 4, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 500000m, 800000m, 800000m }
                });

            migrationBuilder.InsertData(
                table: "RoomImages",
                columns: new[] { "Id", "CreatedTime", "Description", "Name", "RoomId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3958), "Ảnh phòng 1", "phong1-1.jpg", 1 },
                    { 2, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3959), "Ảnh phòng 1", "phong1-2.jpg", 1 },
                    { 3, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3960), "Ảnh phòng 1", "phong1-3.jpg", 1 },
                    { 4, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3961), "Ảnh phòng 1", "phong2-1.jpg", 2 },
                    { 5, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3962), "Ảnh phòng 1", "phong2-1.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "ServiceBookings",
                columns: new[] { "BillId", "ServiceId", "Amount", "BookingTime", "CancelingTime", "Price", "Total" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m, 200000m },
                    { 1, 2, 2, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3941), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50000m, 100000m },
                    { 2, 1, 2, new DateTime(2022, 9, 29, 0, 10, 29, 176, DateTimeKind.Local).AddTicks(3942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m, 400000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TouristId",
                table: "Bills",
                column: "TouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_RoomId",
                table: "Feedbacks",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_TouristId",
                table: "Feedbacks",
                column: "TouristId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookings_RoomId",
                table: "RoomBookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_RoomId",
                table: "RoomImages",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CategoryId",
                table: "Rooms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceBookings_ServiceId",
                table: "ServiceBookings",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "RoomBookings");

            migrationBuilder.DropTable(
                name: "RoomImages");

            migrationBuilder.DropTable(
                name: "ServiceBookings");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "RoomCategories");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
