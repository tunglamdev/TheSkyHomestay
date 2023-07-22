using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class Add_Total_To_Bill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(6374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(9298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(1059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(1354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Bills",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2901), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 12, 4, 19, 9, 48, 425, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3035), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3037), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3038), new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "f2190dd9-b2a2-4b0f-bfbd-86956a43238e", "AQAAAAEAACcQAAAAEIXLznxFYVw+2uXe0tK+ayVY8rEvcAVXRCXbxLfCIh1NuskCDrWB7pvnTnwOYq8XVw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "b94eb68a-c967-41c3-a13e-2d2feea94a27", "AQAAAAEAACcQAAAAEI8/eXSL7Njg+rSo1Nomyik819ASSMf3ld29jtPCGQqdE/B7MEi0wr0LvveB3hwPEA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "2b040956-e210-49df-9e45-7fcbcb0cbd6f", "AQAAAAEAACcQAAAAEJnmWgd4RtYVf3nQy2kK/gj4zItt3gurvTXaztSpwt/QPvOZOxhXzn/01UTMGQqKqw==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "ea5c44c1-c245-4df6-a126-d0eacabd330c");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ff2dddaa-b470-4a3c-868e-abec09fe36fa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Bills");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(6267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(1708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(4863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 420, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 4, 19, 9, 48, 421, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(71), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9925), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9935), new DateTime(2022, 11, 28, 19, 10, 38, 941, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 11, 28, 19, 10, 38, 946, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(97), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(102), new DateTime(2022, 11, 28, 19, 10, 38, 942, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "52bfbfea-8890-4570-a291-985d572350cc", "AQAAAAEAACcQAAAAEH25uwW6Lwu0EmXw7AbPsbW1+2n+tj7j0B/cQ6wlEqGcgk/hqDyqNCH050C8eNr74w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "11ca572b-38c1-457f-93ac-b8616ee042ab", "AQAAAAEAACcQAAAAEFtwYETtZD06Ab5ToMKgl892CqMWJ6b/FNXVSqRjWTE8/QHxv9vPscX46HDgcYpB7w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "c3df0aaf-d187-477b-a38b-787a3a7ba468", "AQAAAAEAACcQAAAAEF2nBsFTy2ZMwn/C2LSOdXAqey20PYBbiGyahQK0Qe2vD3hcQWO2u4ykIy8ryCKezA==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "91c691d4-bc3f-4260-932b-e177b54c85da");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ad7fda82-9b8d-42dc-b065-4c03406602ab");
        }
    }
}
