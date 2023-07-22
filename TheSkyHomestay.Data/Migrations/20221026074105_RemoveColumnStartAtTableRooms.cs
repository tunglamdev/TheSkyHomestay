using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class RemoveColumnStartAtTableRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Rooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(8354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomImages",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(1913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3662), new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4130), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4131), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4032), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4033), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 41, 5, 54, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4146), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4147), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "3041285d-7d8b-4f55-8c17-c27f0ac018d4", "AQAAAAEAACcQAAAAEMnRjSO4/Q7q+9cKUek6a+VP0FOPv6OYN1iJCDG5/636rjmhWwgAusqu/ZE8hh9OrA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "3d1ac1de-11fc-43de-9962-ab7814d5740e", "AQAAAAEAACcQAAAAEHk39Gw6in2giw7tdbV2sVXRIoxKgE1nBoRhCgOqdP3x9x8IpZOe6ROuq7QXwoTnrA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "3a003cd9-458b-4514-8e8e-ee6a37b1cddc", "AQAAAAEAACcQAAAAEO4zHrsgWzbJVyNpkHQHm9kCEhpLGG9FHL9uACluB64CsnWl2DkedSZVbw9LqpxsNg==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "7c13d780-56f1-4d82-9d75-e0aa5e978a1b");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "4f7e0590-f0a9-4b06-b9ff-511a04a291b1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(1656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.AddColumn<double>(
                name: "Stars",
                table: "Rooms",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomImages",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(9067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 49, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(3827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(5227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 41, 5, 50, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7930), new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 1, 3 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "RoomBookings",
                keyColumns: new[] { "BillId", "RoomId" },
                keyValues: new object[] { 2, 4 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8018), new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "RoomImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Stars", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7869), 5.0, new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Stars", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7872), 5.0, new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Stars", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7874), 4.5, new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Stars", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7876), 5.0, new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Stars", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7878), 5.0, new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "ServiceBookings",
                keyColumns: new[] { "BillId", "ServiceId" },
                keyValues: new object[] { 2, 1 },
                column: "BookingTime",
                value: new DateTime(2022, 10, 26, 14, 29, 22, 997, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8044), new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8046), new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8048), new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "b5952318-12e8-4506-8e95-d68a4cae3937", "AQAAAAEAACcQAAAAEJ6gOqbLnun7srJx6UlOtFYS6nPhdL/fGQR+B4b3AyalFCv01a9EPEISlykeN+alhw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "fa7b1967-92e4-44a3-b18c-cc69a264d5f1", "AQAAAAEAACcQAAAAEK2vglDP+Wdlgs2w5O90ZUMOxPkUQV4PMDhjoYTKIuot+HqOtUdJasTjSEJ9EbyAjQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "6369c70f-a645-4549-b73c-4936fc25ea94", "AQAAAAEAACcQAAAAEC8gZ8JRNbCAgw51XGEfB9bbGInOatkCu252AQJoIwfAFXU8QmsaKTxE4UfPnAk1lQ==" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "e4033980-9ae4-4442-8148-c50e7da964c3");

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "5d15f46a-2ff0-49b9-948c-392e0b7c5831");
        }
    }
}
