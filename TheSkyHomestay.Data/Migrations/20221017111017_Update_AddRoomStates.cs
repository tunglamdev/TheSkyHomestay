using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Update_AddRoomStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Rooms_RoomId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_RoomId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Feedbacks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(6756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(2964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2865));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(6380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(7053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 456, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(1852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(2865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 10, 17, 146, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "RoomId", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(494), 1, new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "RoomId", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(502), 3, new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4424), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 10, 18, 17, 46, 462, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4438), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 10, 10, 18, 17, 46, 457, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "a66b67e1-a674-444e-9807-fae6a7fc6caa", "AQAAAAEAACcQAAAAEDIHUr9WQUiDTPxIRmESVCpXqeMwfQLxEXZJsPvUKzZAz6sKc2cw5aI9PEbozWAzSQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "f8619df2-ef2a-42a0-8a89-5a024137d9a2", "AQAAAAEAACcQAAAAEA77MOwgzcvT5vdqEJeB81MiHlMl7MD5O2wj+pys14Jjhj4co4GuergCMfNRIU2FRg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "6377e711-df82-4d05-9e2a-7dec0e0c650a", "AQAAAAEAACcQAAAAEAVPxc2tgeM10YzxOrtZgFd1TpqgsdrQG/hzpwTr2nO6/5N+AAuqQ9bNEioDBDbTSg==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "f6e32b72-f878-4895-8917-a77722b2ac21");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "150f44a2-4ada-49dd-a69a-68858e565520");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_RoomId",
                table: "Feedbacks",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Rooms_RoomId",
                table: "Feedbacks",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
