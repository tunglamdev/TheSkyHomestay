using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheSkyHomestay.Data.Migrations
{
    public partial class AddDescriptionForTableRoom_RemoveTableRoomState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomStates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(1656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(9067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(3827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(5227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(5212));

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
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7869), "Phòng 1 giường cho 2 người ở", new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7872), "Phòng 1 giường cho 2 người ở", new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7874), "Phòng 1 giường cho 2 người ở", new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7876), "Phòng 2 giường cho 2 người ở", new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Description", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7878), "Phòng 2 giường cho 2 người ở", new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(7878) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Rooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(74),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(9119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "ServiceBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "RoomCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 478, DateTimeKind.Local).AddTicks(6676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookingTime",
                table: "RoomBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(1146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 990, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 17, 18, 19, 43, 479, DateTimeKind.Local).AddTicks(5212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 26, 14, 29, 22, 991, DateTimeKind.Local).AddTicks(5227));

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
    }
}
