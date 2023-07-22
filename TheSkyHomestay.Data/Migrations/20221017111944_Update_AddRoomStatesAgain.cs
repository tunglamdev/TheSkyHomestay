using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Update_AddRoomStatesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(74),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(5212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.CreateTable(
                name: "RoomStates",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStates", x => new { x.RoomId, x.FromDate, x.ToDate });
                    table.ForeignKey(
                        name: "FK_RoomStates_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9581), new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7105), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.InsertData(
                table: "RoomStates",
                columns: new[] { "FromDate", "RoomId", "ToDate", "State" },
                values: new object[,]
                {
                    { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6873), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6876), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6879), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6881), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 19, 43, 483, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7133), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7135), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7136), new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "1920b768-adf8-4d31-9d42-c3b01baf50ab", "AQAAAAEAACcQAAAAEKBxoWZJMnQq8kIu8g1VbmRbi9wqugRp4hTcc7xA/0OXDwYU4CaLvG+3BqPFV1cvlQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "2ad8fb4f-322a-4116-9fbb-f1bf18dda3dd", "AQAAAAEAACcQAAAAEFjP4eYg5MSCBLrG4K3TaTvO22UNN2DRXoX4ToBn7BvUWG53qHb6pRDDoyYSEhgnyw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "10eaadc4-cc76-413f-aabe-cafca7fbde46", "AQAAAAEAACcQAAAAEOBo7aMoGaBGelO1RhNrZgW1xeWseuXvNGWE9+syAImlsV7xWftgpUCavXETtAE5bg==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "553dd35d-9d6f-4a23-93fb-7e20f3a248e0");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "7f46d7ff-fe27-4fd9-b3fc-663308aade2a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomStates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(6756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(2964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(173), new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(177), new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 17, 18, 10, 17, 151, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(57), new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(59), new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 10, 17, 18, 10, 17, 147, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "50f42877-244d-4cef-ba13-8bf7f5b36cd7", "AQAAAAEAACcQAAAAEJKvzOIz9ksM0yGLAdLQkRXbb4kLr5f1vKvd1v1EDh5Ae2LpeCwghYy0Yz6Fwhq8Gg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "882356a0-7ac5-4d99-a079-0dd991275291", "AQAAAAEAACcQAAAAEEEGdASUx1Ke7EMGXm//u9CRJ41Sx6w2obWOlUSaTTFOycsslWCf1zO6d7h5j3hOow==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "9c508229-4b69-48c4-bbaa-3aefe42cd13b", "AQAAAAEAACcQAAAAEBw46LDh6BaCkJqqj3K96wzO2bSi+ilyyboUpOATbBBSvzzFnILhRvAB7QL2HJ8LEw==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "92ec3412-84ba-4243-800a-ab5f7a5f6b7c");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "7937defb-7816-4b6a-8bc6-5ad921ad676f");
        }
    }
}
