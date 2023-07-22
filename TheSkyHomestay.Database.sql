/*
 Navicat Premium Data Transfer

 Source Server         : SQLSERVER
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : LAMNGUYEN\SQLEXPRESS:1433
 Source Catalog        : TheSkyHomestay
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 26/12/2022 17:17:29
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220928171029_Initial', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221004174301_AddBookingListToBill', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221009175356_AddColumnImageToTableRoomCategories', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221010111747_AddColumnImageToTableServices', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221017111017_Update_AddRoomStates', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221017111944_Update_AddRoomStatesAgain', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221026072923_AddDescriptionForTableRoom_RemoveTableRoomState', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221026074105_RemoveColumnStartAtTableRooms', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221104041151_UpdatePassWordCanBeNull', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221115080623_Remove_Column_Deposit_In_RoomBookingTable', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221128121039_Add_Number_Of_Adult_and_Child', N'6.0.9')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221204120949_Add_Total_To_Bill', N'6.0.9')
GO


-- ----------------------------
-- Table structure for AppRoleClaims
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AppRoleClaims]') AND type IN ('U'))
	DROP TABLE [dbo].[AppRoleClaims]
GO

CREATE TABLE [dbo].[AppRoleClaims] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [RoleId] uniqueidentifier  NOT NULL,
  [ClaimType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ClaimValue] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AppRoleClaims] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AppRoleClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AppRoleClaims] ON
GO

SET IDENTITY_INSERT [dbo].[AppRoleClaims] OFF
GO


-- ----------------------------
-- Table structure for AppUserClaims
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AppUserClaims]') AND type IN ('U'))
	DROP TABLE [dbo].[AppUserClaims]
GO

CREATE TABLE [dbo].[AppUserClaims] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [UserId] uniqueidentifier  NOT NULL,
  [ClaimType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ClaimValue] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AppUserClaims] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AppUserClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AppUserClaims] ON
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'1', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'id', N'5278ec8b-9cc8-414a-a02a-08dacc9ef513')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'2', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'userName', N'sieu@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'3', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'name', N'Mã Siêu')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'4', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'email', N'sieu@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'5', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'sieu@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'6', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Mã Siêu')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'7', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'sieu@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'8', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'id', N'd6fd19a7-1f4d-4585-2182-08dace00c09c')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'9', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'userName', N'quyen@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'10', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'name', N'Ngô Tôn Quyền')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'11', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'email', N'quyen@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'12', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'quyen@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'13', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Ngô Tôn Quyền')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'14', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'quyen@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'15', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'cino', N'123123123')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'16', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'phoneNumber', N'0987654321')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'17', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'cino', N'456456456')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'18', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'phoneNumber', N'0123456789')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'19', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'id', N'0335fb8c-c878-4421-dcd3-08dad762820b')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'20', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'userName', N'theskyhomestay.honson@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'21', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'name', N'Sky Admin')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'22', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'email', N'theskyhomestay.honson@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'23', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'phoneNumber', N'0123456789')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'24', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'cino', N'331909754')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'25', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'theskyhomestay.honson@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'26', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'John')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'27', N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'theskyhomestay.honson@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'28', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'id', N'eefbfc72-4b22-43ad-1ede-08dad763c8ca')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'29', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'userName', N'lan@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'30', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'name', N'Trần Thị Ngọc Lan')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'31', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'email', N'lan@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'32', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'phoneNumber', N'0245674123')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'33', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'cino', N'331564230')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'34', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'lan@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'35', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Trần Thị Ngọc Lan')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'36', N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'lan@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'37', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'id', N'0cbcb794-3418-49b2-e76c-08dad7642878')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'38', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'userName', N'hoa@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'39', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'name', N'Lê Thị Hoa')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'40', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'email', N'hoa@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'41', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'phoneNumber', N'0376198527')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'42', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'cino', N'331987264')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'43', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'hoa@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'44', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Lê Thị Hoa')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'45', N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'hoa@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'46', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'id', N'8ed22925-29ba-44d5-5ed9-08dad765184f')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'47', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'userName', N'cuong@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'48', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'name', N'Nguyễn Văn Cường')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'49', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'email', N'cuong@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'50', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'phoneNumber', N'0239761619')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'51', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'cino', N'331846295')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'52', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'cuong@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'53', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Nguyễn Văn Cường')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'54', N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'cuong@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'55', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'id', N'2d928dfb-421e-4380-5eda-08dad765184f')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'56', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'userName', N'thanh@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'57', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'name', N'Mai Văn Thành')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'58', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'email', N'thanh@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'59', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'phoneNumber', N'0916285273')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'60', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'cino', N'331978284')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'61', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'thanh@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'62', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Mai Văn Thành')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'63', N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'thanh@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'64', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'id', N'188a18dc-4490-4332-bb9f-08dad7759bc9')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'65', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'userName', N'nhuthuy@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'66', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'name', N'Nguyễn Nhựt Huy')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'67', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'email', N'nhuthuy@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'68', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'phoneNumber', N'0536762915')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'69', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'cino', N'331918362')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'70', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'nhuthuy@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'71', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Nguyễn Nhựt Huy')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'72', N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'nhuthuy@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'73', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'id', N'30dd4d48-3491-468a-7ec1-08dad77651ac')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'74', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'userName', N'lamtran@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'75', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'name', N'Trần Tùng Lâm')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'76', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'email', N'lamtran@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'77', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'phoneNumber', N'0725419852')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'78', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'cino', N'331298763')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'79', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'lamtran@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'80', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Trần Tùng Lâm')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'81', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'lamtran@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'82', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'id', N'9fb9d798-a999-45cc-5c6c-08dadcae2f4c')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'83', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'userName', N'tunglam.contact@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'84', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'name', N'Nguyễn Tùng Lâm')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'85', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'email', N'tunglam.contact@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'86', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'phoneNumber', N'0338307449')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'87', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'cino', N'331909754')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'88', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier', N'tunglam.contact@gmail.com')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'89', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name', N'Nguyễn Tùng Lâm')
GO

INSERT INTO [dbo].[AppUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'90', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress', N'tunglam.contact@gmail.com')
GO

SET IDENTITY_INSERT [dbo].[AppUserClaims] OFF
GO


-- ----------------------------
-- Table structure for AppUserLogins
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AppUserLogins]') AND type IN ('U'))
	DROP TABLE [dbo].[AppUserLogins]
GO

CREATE TABLE [dbo].[AppUserLogins] (
  [UserId] uniqueidentifier  NOT NULL,
  [LoginProvider] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ProviderKey] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ProviderDisplayName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AppUserLogins] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AppUserLogins
-- ----------------------------

-- ----------------------------
-- Table structure for AppUserRoles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AppUserRoles]') AND type IN ('U'))
	DROP TABLE [dbo].[AppUserRoles]
GO

CREATE TABLE [dbo].[AppUserRoles] (
  [UserId] uniqueidentifier  NOT NULL,
  [RoleId] uniqueidentifier  NOT NULL
)
GO

ALTER TABLE [dbo].[AppUserRoles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AppUserRoles
-- ----------------------------
INSERT INTO [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'372EA575-2536-4076-9BAB-3E3138DE495F', N'9E87B492-5343-4272-9A34-FA5DE7CFFB22')
GO

INSERT INTO [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'8A820ADB-93D7-4C6F-9404-BDBFC14419F4', N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31')
GO

INSERT INTO [dbo].[AppUserRoles] ([UserId], [RoleId]) VALUES (N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31')
GO


-- ----------------------------
-- Table structure for AppUserTokens
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AppUserTokens]') AND type IN ('U'))
	DROP TABLE [dbo].[AppUserTokens]
GO

CREATE TABLE [dbo].[AppUserTokens] (
  [UserId] uniqueidentifier  NOT NULL,
  [LoginProvider] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Value] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AppUserTokens] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AppUserTokens
-- ----------------------------

-- ----------------------------
-- Table structure for Bills
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bills]') AND type IN ('U'))
	DROP TABLE [dbo].[Bills]
GO

CREATE TABLE [dbo].[Bills] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [TouristId] uniqueidentifier  NOT NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4211354+07:00' NOT NULL,
  [Total] decimal(18,2) DEFAULT 0.0 NOT NULL
)
GO

ALTER TABLE [dbo].[Bills] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Bills
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Bills] ON
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'2', N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'2022-12-04 19:09:48.4253178', N'1200000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'5', N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'2022-10-05 00:43:00.7561778', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'12', N'CD650487-904D-4316-2FF6-08DABE52B629', N'2022-11-04 11:11:50.7184782', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'13', N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'2022-11-04 11:11:50.7184782', N'850000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'14', N'CD650487-904D-4316-2FF6-08DABE52B629', N'2022-11-04 11:11:50.7184782', N'550000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'16', N'CD650487-904D-4316-2FF6-08DABE52B629', N'2022-11-04 11:11:50.7184782', N'500000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'17', N'BE5B33AC-F16F-4DCC-9E40-08DABE5AD1CB', N'2022-11-04 11:11:50.7184782', N'1000000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'18', N'3B98FF1F-E48B-4B9C-2DF7-08DABE5C356B', N'2022-11-04 11:11:50.7184782', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'19', N'40242251-918A-4AC6-9BC5-08DAC09557EB', N'2022-11-04 11:11:50.7184782', N'1000000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'23', N'CCD0D8FC-2E9D-478F-93FA-08DAC0B21DF1', N'2022-11-04 11:11:50.7184782', N'800000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'24', N'6A89536C-E8F3-4146-4A51-08DAC3DD5494', N'2022-11-04 11:11:50.7184782', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'25', N'E5368C67-18CC-4645-DE76-08DAC40751C9', N'2022-11-04 11:11:50.7184782', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'26', N'1EA5020D-E17D-4453-3545-08DAC40D66DA', N'2022-11-04 11:11:50.7184782', N'800000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'27', N'1BECEAAF-9838-4126-B0E4-08DAC5331956', N'2022-11-04 11:11:50.7184782', N'800000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'36', N'E6B9FE4D-DCF1-4967-32EF-08DAC9FEC5A0', N'2022-11-15 15:06:22.6693452', N'1000000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'37', N'CDEE6DAE-2CE0-4EB5-F6E3-08DACA00BF84', N'2022-11-15 15:06:22.6693452', N'300000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'38', N'4419BA86-FED9-4D1A-68C9-08DACAC3F4B0', N'2022-11-15 15:06:22.6693452', N'600000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'39', N'3DB332DA-85E0-4B00-608E-08DACADDAEC7', N'2022-11-15 15:06:22.6693452', N'500000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'40', N'58E92F0F-0679-4CC5-6CA9-08DAD11A3BB5', N'2022-11-15 15:06:22.6693452', N'800000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'41', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'2022-11-28 19:10:38.9418540', N'300000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'42', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'2022-11-28 19:10:38.9418540', N'1750000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'43', N'290361D7-CEAC-44AF-EBBA-08DAD44D89A7', N'2022-11-28 19:10:38.9418540', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'44', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'2022-12-04 19:09:48.4211354', N'2000000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'45', N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'2022-12-04 19:09:48.4211354', N'500000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'46', N'77865433-450D-460E-E83C-08DAD93E1273', N'2022-12-04 19:09:48.4211354', N'1900000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'47', N'CBB11604-A154-4EE2-4C0D-08DADC2D8FF2', N'2022-12-04 19:09:48.4211354', N'3800000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'48', N'BCAB563E-3889-4DA5-5C6B-08DADCAE2F4C', N'2022-12-04 19:09:48.4211354', N'700000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'49', N'4F8C4BF2-852F-4D1E-4D8C-08DADCD29B35', N'2022-12-04 19:09:48.4211354', N'600000.00')
GO

INSERT INTO [dbo].[Bills] ([Id], [TouristId], [CreatedTime], [Total]) VALUES (N'50', N'F0D9D70F-F68C-480A-4D8D-08DADCD29B35', N'2022-12-04 19:09:48.4211354', N'1000000.00')
GO

SET IDENTITY_INSERT [dbo].[Bills] OFF
GO


-- ----------------------------
-- Table structure for Feedbacks
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Feedbacks]') AND type IN ('U'))
	DROP TABLE [dbo].[Feedbacks]
GO

CREATE TABLE [dbo].[Feedbacks] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [TouristId] uniqueidentifier  NOT NULL,
  [Vote] int DEFAULT 5 NOT NULL,
  [Comment] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4210486+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4210584+07:00' NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL
)
GO

ALTER TABLE [dbo].[Feedbacks] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Feedbacks
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Feedbacks] ON
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'2', N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'5', N'Phòng rất đẹp! Anh chủ rất dễ thương luôn! Phòng rất đẹp! Anh chủ rất dễ thương luôn! Phòng rất đẹp!', N'2022-12-04 19:09:48.4253165', N'2022-12-04 19:09:48.4253165', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'4', N'6A89536C-E8F3-4146-4A51-08DAC3DD5494', N'4', N'Phòng đẹp nhưng hơi xa cầu cảng và khu ăn uống, anh chủ tận tình hướng dẫn, rất thân thiện hòa đồng.', N'2022-10-17 18:19:43.4794122', N'2022-10-17 18:19:43.4794223', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'5', N'E5368C67-18CC-4645-DE76-08DAC40751C9', N'5', N'Phòng đẹp lắm, dịch vụ tốt, tiện lợi, xứng đáng với giá tiền, sẽ quay lại nếu có đi Hòn Sơn.', N'2022-11-15 15:06:22.6691886', N'2022-11-15 15:06:22.6691993', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'6', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'5', N'Phòng đẹp lắm, anh chủ thân thiện nhiệt tình, ấn tượng rất tốt với homestay này luôn.', N'2022-11-15 15:06:22.6691886', N'2022-11-15 15:06:22.6691993', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'7', N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'5', N'Phòng rất đẹp, anh chủ cực kỳ dễ thương luôn nha, hải sản chế biến rất ngon, rất hợp khẩu vị mình.', N'2022-11-15 15:06:22.6691886', N'2022-11-15 15:06:22.6691993', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'8', N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'5', N'Homestay rất đẹp, anh chủ rất vui tính và hiếu khách, mình rất thích...', N'2022-12-04 19:09:48.4210486', N'2022-12-04 19:09:48.4210584', N'0')
GO

INSERT INTO [dbo].[Feedbacks] ([Id], [TouristId], [Vote], [Comment], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'9', N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'5', N'Phòng rất đẹp, anh chị chủ nhà rất dễ thương, mình rất thích, sẽ quay lại Hòn Sơn dịp gần nhất!', N'2022-12-04 19:09:48.4210486', N'2022-12-04 19:09:48.4210584', N'0')
GO

SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
GO


-- ----------------------------
-- Table structure for RoomBookings
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomBookings]') AND type IN ('U'))
	DROP TABLE [dbo].[RoomBookings]
GO

CREATE TABLE [dbo].[RoomBookings] (
  [BillId] int  NOT NULL,
  [RoomId] int  NOT NULL,
  [CheckInDate] datetime2(7) DEFAULT '2022-12-04T19:09:48.4207781+07:00' NOT NULL,
  [CheckOutDate] datetime2(7) DEFAULT '2022-12-04T19:09:48.4207872+07:00' NOT NULL,
  [Price] decimal(18,2)  NOT NULL,
  [Total] decimal(18,2)  NOT NULL,
  [BookingTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4207963+07:00' NOT NULL,
  [CancelingTime] datetime2(7)  NOT NULL,
  [IsCanceled] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [NumberOfAdult] int DEFAULT 2 NOT NULL,
  [NumberOfChild] int DEFAULT 1 NOT NULL
)
GO

ALTER TABLE [dbo].[RoomBookings] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoomBookings
-- ----------------------------
INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'2', N'4', N'2022-09-29 12:00:00.0000000', N'2022-09-30 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-12-04 19:09:48.4253197', N'0001-01-01 00:00:00.0000000', N'0', N'4', N'2')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'5', N'2', N'2022-10-05 12:00:00.8490000', N'2022-10-06 12:00:00.8490000', N'500000.00', N'500000.00', N'2022-10-05 00:43:00.7556852', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'12', N'1', N'2022-11-04 12:00:00.0000000', N'2022-11-05 12:00:00.0000000', N'700000.00', N'700000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'13', N'9', N'2022-11-04 12:00:00.0000000', N'2022-11-05 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'14', N'2', N'2022-11-04 12:00:00.0000000', N'2022-11-05 12:00:00.0000000', N'500000.00', N'500000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'16', N'3', N'2022-11-04 12:00:00.0000000', N'2022-11-05 12:00:00.0000000', N'500000.00', N'500000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'17', N'7', N'2022-11-04 12:00:00.0000000', N'2022-11-05 12:00:00.0000000', N'1000000.00', N'1000000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'18', N'1', N'2022-11-15 12:00:00.0000000', N'2022-11-16 12:00:00.0000000', N'700000.00', N'700000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'19', N'7', N'2022-11-15 12:00:00.0000000', N'2022-11-16 12:00:00.0000000', N'1000000.00', N'1000000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'23', N'5', N'2022-11-15 12:00:00.0000000', N'2022-11-16 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'24', N'1', N'2022-11-11 12:00:00.0000000', N'2022-11-12 12:00:00.0000000', N'700000.00', N'700000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'25', N'1', N'2022-11-30 12:00:00.0000000', N'2022-12-01 12:00:00.0000000', N'700000.00', N'700000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'26', N'9', N'2022-12-01 12:00:00.0000000', N'2022-12-02 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'27', N'1', N'2022-12-02 12:00:00.0000000', N'2022-12-03 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-04 11:11:50.7179620', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'36', N'8', N'2022-12-01 12:00:00.0000000', N'2022-12-02 12:00:00.0000000', N'1000000.00', N'1000000.00', N'2022-11-15 15:06:22.6689178', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'37', N'5', N'2022-12-01 12:00:00.0000000', N'2022-12-02 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-11-15 15:06:22.6689178', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'38', N'2', N'2022-11-30 12:00:00.0000000', N'2022-12-02 12:00:00.0000000', N'300000.00', N'600000.00', N'2022-11-15 15:06:22.6689178', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'39', N'7', N'2022-11-30 12:00:00.0000000', N'2022-12-01 00:00:00.0000000', N'500000.00', N'500000.00', N'2022-11-15 15:06:22.6689178', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'40', N'3', N'2022-12-01 12:00:00.0000000', N'2022-12-02 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-15 15:06:22.6689178', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'41', N'5', N'2022-12-02 12:00:00.0000000', N'2022-12-03 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-11-28 19:10:38.9414863', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'42', N'3', N'2022-12-02 12:00:00.0000000', N'2022-12-03 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-11-28 19:10:38.9414863', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'43', N'2', N'2022-12-02 12:00:00.0000000', N'2022-12-03 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-11-28 19:10:38.9414863', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'44', N'1', N'2022-12-24 12:00:00.0000000', N'2022-12-26 12:00:00.0000000', N'500000.00', N'1000000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'3', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'45', N'4', N'2022-12-24 12:00:00.0000000', N'2022-12-25 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'46', N'3', N'2022-12-24 12:00:00.0000000', N'2022-12-25 12:00:00.0000000', N'800000.00', N'800000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'5', N'3')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'47', N'8', N'2022-12-24 12:00:00.0000000', N'2022-12-26 12:00:00.0000000', N'1000000.00', N'2000000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'6', N'2')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'48', N'5', N'2022-12-24 12:00:00.0000000', N'2022-12-25 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'49', N'2', N'2022-12-30 12:00:00.0000000', N'2022-12-31 12:00:00.0000000', N'300000.00', N'300000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO

INSERT INTO [dbo].[RoomBookings] ([BillId], [RoomId], [CheckInDate], [CheckOutDate], [Price], [Total], [BookingTime], [CancelingTime], [IsCanceled], [NumberOfAdult], [NumberOfChild]) VALUES (N'50', N'2', N'2022-12-24 12:00:00.0000000', N'2022-12-26 12:00:00.0000000', N'300000.00', N'600000.00', N'2022-12-04 19:09:48.4207963', N'0001-01-01 00:00:00.0000000', N'0', N'2', N'1')
GO


-- ----------------------------
-- Table structure for RoomCategories
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomCategories]') AND type IN ('U'))
	DROP TABLE [dbo].[RoomCategories]
GO

CREATE TABLE [dbo].[RoomCategories] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4205729+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4205813+07:00' NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [Image] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'default.jpg' NOT NULL
)
GO

ALTER TABLE [dbo].[RoomCategories] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoomCategories
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RoomCategories] ON
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'1', N'Phòng 1 giường (2 người)', N'2022-12-04 19:09:48.4213017', N'2022-12-04 19:09:48.4213018', N'0', N'a68cd80c-9601-46f7-8c54-91893d13447f.jpg')
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'2', N'Phòng 2 giường (4 người)', N'2022-12-04 19:09:48.4213019', N'2022-12-04 19:09:48.4213019', N'0', N'a9bdf03d-a023-4d85-9847-9e791464a6ac.jpg')
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'3', N'Phòng tập thể (6 người)', N'2022-09-29 00:10:29.1718090', N'2022-10-10 00:58:09.7881596', N'0', N'320c0bcb-1f83-4b31-9b7d-7ad9ff584dc3.jpg')
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'4', N'Phòng kiểu dorm (6 người)', N'2022-10-05 00:43:00.7553889', N'2022-10-10 00:58:31.8794733', N'0', N'09ffa056-c0c3-4e1d-8e64-2b4c24fcf17d.jpg')
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'5', N'Phòng aaa', N'2022-10-17 18:19:43.4786676', N'2022-10-17 18:19:43.4786758', N'1', N'3e2178d2-b641-4341-8daf-a729508dc303.jpg')
GO

INSERT INTO [dbo].[RoomCategories] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'6', N'Phòng bbb', N'2022-10-17 18:19:43.4786676', N'2022-10-25 16:12:51.1599100', N'1', N'af8143d9-cfc9-4d7a-96a7-70094326e955.jpg')
GO

SET IDENTITY_INSERT [dbo].[RoomCategories] OFF
GO


-- ----------------------------
-- Table structure for RoomImages
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomImages]') AND type IN ('U'))
	DROP TABLE [dbo].[RoomImages]
GO

CREATE TABLE [dbo].[RoomImages] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(300) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [RoomId] int  NOT NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4210954+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4211059+07:00' NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL
)
GO

ALTER TABLE [dbo].[RoomImages] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoomImages
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RoomImages] ON
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'1', N'P1-1.jpg', N'Ảnh phòng 1', N'1', N'2022-12-04 19:09:48.4253222', N'2022-09-29 00:10:29.1723012', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'2', N'P1-2.jpg', N'Ảnh phòng 1', N'1', N'2022-12-04 19:09:48.4253224', N'2022-09-29 00:10:29.1723012', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'3', N'P1-3.jpg', N'Ảnh phòng 1', N'1', N'2022-12-04 19:09:48.4253224', N'2022-09-29 00:10:29.1723012', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'4', N'P2-1.jpg', N'Ảnh phòng 2', N'2', N'2022-12-04 19:09:48.4253225', N'2022-09-29 00:10:29.1723012', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'5', N'P2-2.jpg', N'Ảnh phòng 2', N'2', N'2022-12-04 19:09:48.4253258', N'2022-09-29 00:10:29.1723012', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'6', N'P2-3.jpg', N'Ảnh phòng 2', N'2', N'2022-09-29 00:10:29.1722916', N'2022-09-29 00:10:29.1723012', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'7', N'P2-4.jpg', N'Ảnh phòng 2', N'2', N'2022-10-10 00:53:56.2275263', N'2022-10-10 00:53:56.2275400', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'8', N'P2-5.jpg', N'Ảnh phòng 2', N'2', N'2022-10-10 00:53:56.2275263', N'2022-10-10 00:53:56.2275400', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'10', N'P3-1.jpg', N'Ảnh phòng 3', N'3', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'11', N'P3-2.jpg', N'Ảnh phòng 3', N'3', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'12', N'P3-3.jpg', N'Ảnh phòng 3', N'3', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'13', N'P4-1.jpg', N'Ảnh phòng 4', N'4', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'14', N'P4-2.jpg', N'Ảnh phòng 4', N'4', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'15', N'P4-3.jpg', N'Ảnh phòng 4', N'4', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'16', N'P4-4.jpg', N'Ảnh phòng 4', N'4', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'17', N'P5-1.jpg', N'Ảnh phòng 5', N'5', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'18', N'P5-2.jpg', N'Ảnh phòng 5', N'5', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'19', N'P6-1.jpg', N'Ảnh phòng 6', N'7', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'20', N'P6-2.jpg', N'Ảnh phòng 6', N'7', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'21', N'P7-1.jpg', N'Ảnh phòng 7', N'8', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'22', N'P7-2.jpg', N'Ảnh phòng 7', N'8', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'23', N'P7-3.jpg', N'Ảnh phòng 7', N'8', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'24', N'P8-1.jpg', N'Ảnh phòng 8', N'9', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'25', N'P8-2.jpg', N'Ảnh phòng 8', N'9', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'26', N'P8-3.jpg', N'Ảnh phòng 8', N'9', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'27', N'e2b62912-c67b-42ad-8b68-d5fea1fbd582.png', N'Ảnh phòng Phòng XXX', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'28', N'ba02c70b-eebd-490d-986a-64b324581543.jpg', N'Ảnh phòng Phòng XXX', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'29', N'6ce59152-0790-4ee3-8665-2fcb8faeba7c.png', N'Ảnh Phòng NewYork', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'30', N'9f10468c-191e-4276-b913-a41e669481ae.jpg', N'Ảnh Phòng NewYork AAA', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'31', N'12a73d09-a352-4b18-958e-1c5649972038.jpg', N'Ảnh Phòng NewYork AAA', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'1')
GO

INSERT INTO [dbo].[RoomImages] ([Id], [Name], [Description], [RoomId], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'32', N'bbf999f9-05d1-4b53-aa8f-0bfcbb942ea4.png', N'Ảnh Phòng NewYork', N'10', N'2022-10-26 14:41:05.0502275', N'2022-10-26 14:41:05.0502395', N'0')
GO

SET IDENTITY_INSERT [dbo].[RoomImages] OFF
GO


-- ----------------------------
-- Table structure for Rooms
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Rooms]') AND type IN ('U'))
	DROP TABLE [dbo].[Rooms]
GO

CREATE TABLE [dbo].[Rooms] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Price] decimal(18,2)  NOT NULL,
  [CategoryId] int  NOT NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4205180+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4205289+07:00' NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [Description] nvarchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL,
  [AdultCapacity] int DEFAULT 2 NOT NULL,
  [ChildCapacity] int DEFAULT 1 NOT NULL
)
GO

ALTER TABLE [dbo].[Rooms] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Rooms
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Rooms] ON
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'1', N'Phòng London', N'300000.00', N'1', N'2022-12-04 19:09:48.4212901', N'2022-12-04 19:09:48.4212903', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'2', N'1')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'2', N'Phòng Tokyo', N'300000.00', N'1', N'2022-12-04 19:09:48.4212904', N'2022-12-04 19:09:48.4212905', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'2', N'1')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'3', N'Phòng Berlin', N'800000.00', N'4', N'2022-12-04 19:09:48.4212906', N'2022-12-04 19:09:48.4212906', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'8', N'4')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'4', N'Phòng Paris', N'800000.00', N'4', N'2022-12-04 19:09:48.4212907', N'2022-12-04 19:09:48.4212907', N'0', N'Phòng 2 giường cho 4 người ở', N'8', N'4')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'5', N'Phòng Ottawa', N'300000.00', N'1', N'2022-12-04 19:09:48.4212908', N'2022-12-04 19:09:48.4212909', N'0', N'Phòng 2 giường cho 4 người ở', N'2', N'1')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'7', N'Phòng Rome', N'500000.00', N'2', N'2022-09-29 00:10:29.1717650', N'2022-11-18 13:28:18.3301517', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'4', N'2')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'8', N'Phòng Washington', N'1000000.00', N'3', N'2022-10-10 00:53:56.2269453', N'2022-12-12 13:33:57.2421459', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'6', N'3')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'9', N'Phòng Moscow', N'1000000.00', N'3', N'2022-10-10 00:53:56.2269453', N'2022-11-18 13:29:02.0926590', N'0', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ).', N'6', N'3')
GO

INSERT INTO [dbo].[Rooms] ([Id], [Name], [Price], [CategoryId], [CreatedTime], [UpdatedTime], [IsDeleted], [Description], [AdultCapacity], [ChildCapacity]) VALUES (N'10', N'Phòng NewYork', N'500000.00', N'2', N'2022-10-26 14:41:05.0496420', N'2022-11-01 18:05:17.1200219', N'1', N'Phòng có 01 giường ngủ thích hợp cho 2 người ở. Với diện tích 12m vuông đủ để du khách cảm thấy thoải mái với không gian rộng rãi. Phòng được thiết kế theo phong cách vintage với pallet gỗ và các vật dụng handmade từ thiên nhiên tạo cảm giác thoải mái dễ chịu khi sinh hoạt tại phòng. Cửa sổ kính lớn với view hướng núi giúp tạo ánh sáng và sự thông thoáng cho căn phòng, rèm cửa hiện đại trang nhã giúp che chắn khi ánh nắng chiếu vào trực tiếp. Phòng có toilet riêng, được trang bị máy lạnh, máy nước nóng, máy sấy tóc, gương, bàn nhỏ, đồ ăn vặt và nước suối miễn phí. Check-in nhận phòng lúc 12 giờ trưa, giá phòng áp dụng cho 01 ngày thuê (24 giờ). XXX', N'4', N'2')
GO

SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO


-- ----------------------------
-- Table structure for ServiceBookings
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ServiceBookings]') AND type IN ('U'))
	DROP TABLE [dbo].[ServiceBookings]
GO

CREATE TABLE [dbo].[ServiceBookings] (
  [BillId] int  NOT NULL,
  [ServiceId] int  NOT NULL,
  [Price] decimal(18,2)  NOT NULL,
  [Amount] int DEFAULT 1 NOT NULL,
  [Total] decimal(18,2)  NOT NULL,
  [BookingTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4209298+07:00' NOT NULL,
  [CancelingTime] datetime2(7)  NOT NULL,
  [IsCanceled] bit DEFAULT CONVERT([bit],(0)) NOT NULL
)
GO

ALTER TABLE [dbo].[ServiceBookings] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ServiceBookings
-- ----------------------------
INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'2', N'1', N'200000.00', N'2', N'400000.00', N'2022-12-04 19:09:48.4253211', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'5', N'1', N'200000.00', N'1', N'200000.00', N'2022-10-05 00:43:00.7558797', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'13', N'1', N'50000.00', N'1', N'50000.00', N'2022-11-04 11:11:50.7181721', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'14', N'1', N'50000.00', N'1', N'50000.00', N'2022-11-04 11:11:50.7181721', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'42', N'1', N'200000.00', N'3', N'600000.00', N'2022-11-28 19:10:38.9416267', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'42', N'2', N'50000.00', N'7', N'350000.00', N'2022-11-28 19:10:38.9416267', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'43', N'1', N'200000.00', N'1', N'200000.00', N'2022-11-28 19:10:38.9416267', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'43', N'4', N'100000.00', N'2', N'200000.00', N'2022-11-28 19:10:38.9416267', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'44', N'1', N'200000.00', N'3', N'600000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'44', N'2', N'50000.00', N'2', N'100000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'44', N'4', N'100000.00', N'3', N'300000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'45', N'1', N'200000.00', N'1', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'46', N'1', N'200000.00', N'3', N'600000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'46', N'4', N'100000.00', N'5', N'500000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'47', N'1', N'200000.00', N'3', N'600000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'47', N'2', N'50000.00', N'6', N'300000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'47', N'3', N'50000.00', N'6', N'300000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'47', N'4', N'100000.00', N'6', N'600000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'48', N'1', N'200000.00', N'1', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'48', N'4', N'100000.00', N'2', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'49', N'1', N'200000.00', N'1', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'49', N'3', N'50000.00', N'2', N'100000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'50', N'1', N'200000.00', N'1', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[ServiceBookings] ([BillId], [ServiceId], [Price], [Amount], [Total], [BookingTime], [CancelingTime], [IsCanceled]) VALUES (N'50', N'4', N'100000.00', N'2', N'200000.00', N'2022-12-04 19:09:48.4209298', N'0001-01-01 00:00:00.0000000', N'0')
GO


-- ----------------------------
-- Table structure for Services
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Services]') AND type IN ('U'))
	DROP TABLE [dbo].[Services]
GO

CREATE TABLE [dbo].[Services] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Price] decimal(18,2)  NOT NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CreatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4206374+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4206460+07:00' NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [Image] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'default.jpg' NOT NULL
)
GO

ALTER TABLE [dbo].[Services] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Services
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Services] ON
GO

INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [Description], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'1', N'Thuê xe máy', N'200000.00', N'200.000/ngày/chiếc, bao xăng', N'2022-12-04 19:09:48.4213035', N'2022-12-04 19:09:48.4213036', N'0', N'47e83a66-b4db-4dad-a806-b4bfa0e02e6c.jpg')
GO

INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [Description], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'2', N'Lặn nhum', N'50000.00', N'50.000/lượt/người, được hỗ trợ kính lặn biển, vợt bắt nhum', N'2022-12-04 19:09:48.4213037', N'2022-12-04 19:09:48.4213037', N'0', N'ebc8a8e3-f683-4507-b697-818c56ba91bb.jpg')
GO

INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [Description], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'3', N'Chinh phục Ma Thiên Lãnh', N'50000.00', N'50.000/lượt/người, hướng dẫn leo núi, hỗ trợ nước uống', N'2022-12-04 19:09:48.4213038', N'2022-12-04 19:09:48.4213038', N'0', N'4d200c28-3466-4e5a-9943-d7b5023e8910.jpeg')
GO

INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [Description], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'4', N'Câu hải sản tại bè', N'100000.00', N'Xuồng máy đưa rước khách ra bè hải sản', N'2022-09-29 00:10:29.1718551', N'2022-10-03 16:42:27.8483575', N'0', N'ff2f3e52-8f08-4ce4-8122-1d9ae6835b21.jpg')
GO

INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [Description], [CreatedTime], [UpdatedTime], [IsDeleted], [Image]) VALUES (N'5', N'Dịch vụ aaa', N'100000.00', N'aaaa', N'2022-10-17 18:19:43.4789119', N'2022-10-25 16:32:01.9264275', N'1', N'default.jpg')
GO

SET IDENTITY_INSERT [dbo].[Services] OFF
GO


-- ----------------------------
-- Table structure for User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type IN ('U'))
	DROP TABLE [dbo].[User]
GO

CREATE TABLE [dbo].[User] (
  [Id] uniqueidentifier  NOT NULL,
  [Name] nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Email] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [PhoneNumber] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CINo] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Avatar] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'default.png' NOT NULL,
  [Password] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [RegisteredTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4207062+07:00' NOT NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2022-12-04T19:09:48.4207181+07:00' NOT NULL,
  [IsBlocked] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [UserName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedUserName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedEmail] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [EmailConfirmed] bit  NOT NULL,
  [PasswordHash] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [SecurityStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ConcurrencyStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PhoneNumberConfirmed] bit  NOT NULL,
  [TwoFactorEnabled] bit  NOT NULL,
  [LockoutEnd] datetimeoffset(7)  NULL,
  [LockoutEnabled] bit  NOT NULL,
  [AccessFailedCount] int  NOT NULL
)
GO

ALTER TABLE [dbo].[User] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of User
-- ----------------------------
INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'CD650487-904D-4316-2FF6-08DABE52B629', N'Lê Minh Khang', N'khangkhongkhung123@gmail.com', N'0135792468', N'123123123', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'khangkhongkhungkkk@gmail.com', N'KHANGKHONGKHUNGKKK@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEFX1I8lNLQ7SM+l7V1PvVYLbEqzg9ZPuWoS2khODrUbTNAU9BiUse2FTXninWeOTwQ==', N'YL4ETXHNMR2T3VDSPTMYXPH7E6CQBKV5', N'b2f2219d-1db5-4cdc-98ee-a4c90b5cb3af', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'BE5B33AC-F16F-4DCC-9E40-08DABE5AD1CB', N'Đào Bá Lộc', N'loc@gmail.com', N'0101010101', N'111222333', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'tunglamhb2kkkk@gmail.com', N'TUNGLAMHB2Kkkk@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAELahfO2Tc/FNjmlODGhvxmOEO4HQBOYukka9VKVRXCufaMVzsehLsA2HcGKOjaBmdw==', N'SXJA6DMXC7ZPVPGMOJVLBIPOIIKNSRP4', N'4d9ad3e6-4f18-4b24-8fb3-d1d0655c9792', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3B98FF1F-E48B-4B9C-2DF7-08DABE5C356B', N'Tăng Tăng Tăng', N'tang@gmail.com', N'0202020202', N'222333444', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'khakhongkhung12345@gmail.com', N'KHAKHONGKHUNG12345@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEKiuxTIv+teS5gInW2Q6jWO8DDZuPaDm0BnX7ccrWLaL5wSYN3cjuqBw5VH/h66yRg==', N'XFG7VBEK2HQLUPBKMTVQ6CF73U2O367S', N'be29abeb-9732-4139-a10e-8991791d4ac8', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'40242251-918A-4AC6-9BC5-08DAC09557EB', N'Triệu Tử Long', N'ntlamctu123@gmail.com', N'0999888777', N'789789789', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'ntlamctu123@gmail.com', N'NTLAMCTU123@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAECgqw+oKFjZrQCZ+XfXDb1xc9N8hNZMGAMP87inunj/Eip5p/SqwqkSma05BzmoJAg==', N'ABSGRPPSWUPYXRV223RY5BZTZT6CI2QH', N'd7a43ff8-779d-4c0e-940e-d5dce3a4114a', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'CCD0D8FC-2E9D-478F-93FA-08DAC0B21DF1', N'Mai Nhựt Long', N'mainhutlong.2018tgdd@gmail.com', N'0707070707', N'123456789', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'mainhutlong.2018tgdd@gmail.com', N'MAINHUTLONG.2018TGDD@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEDoGd/jOdeRO0tXYxTztVAEy0k0cEj4L3rpufYM0b4WA3TuHw9RiSPd3q67UPjHg4Q==', N'FMHNM7Q7HZ67QBP6CBUI5LGUERRS7SIS', N'0fcf5f37-f459-4b0a-a21a-a34a81abf925', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6A89536C-E8F3-4146-4A51-08DAC3DD5494', N'Lưu Bị', N'bi@gmail.com', N'0505050505', N'916582362', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'bi@gmail.com', N'BI@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEGe7+ahysRClGSfIK9+07Ea05KREG33VbZhgHgCVSx+NBvd6uSGhuG2iniRGKRC1DQ==', N'22ZKY6STSG35PIWY5N7FHGUDWDJRCME2', N'8b493ee8-a778-4797-985c-d909489153af', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'E5368C67-18CC-4645-DE76-08DAC40751C9', N'Tào Tháo', N'thao@gmail.com', N'0102030405', N'688913653', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'thao@gmail.com', N'THAO@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEBYiKLbvx878CS2h7zdpRsnI/ZkKi3YPnCky8/yKOxSP63HaLMBjjhx9lVe7tIBFgw==', N'VQ2UPW4EJXLQ64XEWUFZDBVOOIFJAZYG', N'2dc6692f-2f73-4c84-aa09-434ac13eafd0', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1EA5020D-E17D-4453-3545-08DAC40D66DA', N'Quan Vũ', N'vu@gmail.com', N'0102030405', N'286761220', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'vu@gmail.com', N'VU@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEL72pR++y9lye2JUlHBvifqRZgWE7k32egrr4LaQ76wAz5c6BvhvrBalVMsacv43kw==', N'7VZ3YVRU6KVRCDQRJFW7XZ3QSD6HVHZR', N'cf6e7842-9d68-444b-bfb5-e86ac7467bfe', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1BECEAAF-9838-4126-B0E4-08DAC5331956', N'Lê Minh Kha', N'minhkhalectu123@gmail.com', N'0785023121', N'331879201', N'default.png', NULL, N'2022-11-04 11:11:50.7178213', N'2022-11-04 11:11:50.7178416', N'0', N'minhkhalectu123@gmail.com', N'MINHKHALECTU123@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAENDgC98pBewCCAuT+GXeTM+6GRYtHXX5oRvyDJzfBhdY8ez3D+qOjPN6lLsswy/vnQ==', N'WEU7QHU37MQ4HBVSTX356B4M3UTTCBI7', N'bf278b5d-55f1-43cd-884d-3ad78ccd4ef4', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'E6B9FE4D-DCF1-4967-32EF-08DAC9FEC5A0', N'Nguyễn Tùng', N'tunglamhb2k@gmail.com', N'0987654321', N'331909754', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'tunglamhb2kkkkkk@gmail.com', N'TUNGLAMHB2KKKKKK@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEIulbejjzvs5lu57RldrdinnEQGPHhXhOefQyXUfzjtiz85paHnziAaNd7QO/rClWQ==', N'4MSV72GW74MLFOKJWD2V2WTXYRN6A2VB', N'05108e25-f086-4606-84c0-4164c530c42f', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'CDEE6DAE-2CE0-4EB5-F6E3-08DACA00BF84', N'Nguyễn Văn C', N'tunglamhb2k@gmail.com', N'0123456789', N'126347681', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'tunglamhb2kkk@gmail.com', N'TUNGLAMHB2KKKK@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEM1SOWScAcAtavoa5EWoVwL2AIzTSLsk/3A2bzTo4eMdZmKmpqApXCftABRCU3W1Tw==', N'UK336FA7SPDNAHEZL6ZMI6WSU7LM5OHK', N'a3d84784-a186-4844-84f7-304762906f2b', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4419BA86-FED9-4D1A-68C9-08DACAC3F4B0', N'Nguyễn Văn E', N'ntlamctu123@gmail.com', N'0987654321', N'987654321', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'ntlamctu123@gmail.com', N'NTLAMCTU123@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEKpjhSS1kvme6tfNwM2pYrhzaG+B22GQ7LVXQO3zrfXjMSG+7zONlDxsKcQbw6rT0g==', N'FOCXTRXDF3K3NSMS62KSADED6QETDX7F', N'ad84fc39-9f44-4075-8fa7-9f7b02fe5336', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'3DB332DA-85E0-4B00-608E-08DACADDAEC7', N'Nguyễn Văn B', N'tunglam.contact123@gmail.com', N'0987654321', N'987654312', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'tunglam.contact123@gmail.com', N'TUNGLAM.CONTACT123@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEJLQQvMUx0diC3jlJq7eEo9fscTtc7v0LFko0B/ebd/Zlu3ce/CEtyQhsE5CWNwa1Q==', N'AXUK7HOBNGRHVB2UEU4S7U4EKTUBDAXD', N'cc392a1b-dbc7-4039-bdab-3e910e597320', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5278EC8B-9CC8-414A-A02A-08DACC9EF513', N'Mã Siêu', N'sieu@gmail.com', N'0987654321', N'123987456', N'default.png', N'sieu123', N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'sieu@gmail.com', N'SIEU@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAELb82jbDWtYAoXUzWdYfc+QTwevsO4/8exHUjSDqfJtmCoSOAOYntZtqPR3zQ8VLhg==', N'IZ4UU52JM5F5CX3GGN5VIEL7SYEUUHCC', N'e6829407-b840-4733-bcf0-7030456016f7', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'599363FF-78E9-407E-779D-08DACCB5A94E', N'Lục Vân Tiên', N'lvtien@gmail.com', N'0987654321', N'123456788', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'lvtien@gmail.com', N'LVTIEN@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAENd1qHkAjJhceiwfwLqs59CY/XoQz1iMXSe5Bp1fWvwSZyJdFaeW6NaZ8hY/1zWZSw==', N'ZX4WD7TLERJVQLDYNJNUN2HW3XTERD2G', N'4e4a301e-2730-4a28-a8d4-79724d3fde50', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'D6FD19A7-1F4D-4585-2182-08DACE00C09C', N'Ngô Tôn Quyền', N'quyen@gmail.com', N'0123456789', N'456456456', N'default.png', N'quyen123', N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'quyen@gmail.com', N'QUYEN@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEK6cmbHZX06olQXJ6VlmKLpQwLP8VxnOflR1ccW6VB60mFUsq+3Pce+C4CqkomPV4Q==', N'HJOTRQIELH4FJPBLMAH3OJCI2R34NIWD', N'a039bd2c-fa6e-4fa9-92ab-6d14ff9de1c0', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'58E92F0F-0679-4CC5-6CA9-08DAD11A3BB5', N'Lâm Nhựt Huy', N'lnhuy7649@gmail.com', N'0907867451', N'097867851', N'default.png', NULL, N'2022-11-15 15:06:22.6688481', N'2022-11-15 15:06:22.6688600', N'0', N'lnhuy7649@gmail.com', N'LNHUY7649@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEHV0X3c36eXwFzDISx70GC5ayxqyWwrmv3nbfdSVM2KeTahGR20/ddLM7gpfJcFUkQ==', N'32SKML3JVBOF6AARSWRWU7FXYI6AUCZB', N'fec04070-3038-4529-9d02-79fc789aa0b8', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'290361D7-CEAC-44AF-EBBA-08DAD44D89A7', N'Le Minh Kha', N'tunglamhb2kxxxx@gmail.com', N'1235246357', N'351345115', N'default.png', NULL, N'2022-11-28 19:10:38.9413913', N'2022-11-28 19:10:38.9414040', N'0', N'tunglamhb2kxxxx@gmail.com', N'TUNGLAMHB2KXXXX@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEIR1zNV4J5VRZlWuAk2N++AYmB9taPS7WYQbOzmznQ6L2tNR/CiCWSw7Op445kHYug==', N'GB3QIHXSB2UXS4F4MXEPTH6O4VCLD3YZ', N'67636c90-46ea-4e5a-9623-5ad93cc470b1', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0335FB8C-C878-4421-DCD3-08DAD762820B', N'Sky Admin', N'theskyhomestay.honson@gmail.com', N'0123456789', N'331909754', N'default.png', N'admin123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'theskyhomestay.honson@gmail.com', N'THESKYHOMESTAY.HONSON@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEGeFGcTR0sbViFdRUoMag6O/SlU/hq3OAIkYxTW79ZoHqD0jfp+n7SYsb7W0s9a97Q==', N'U3DD5KCERUQNAP2LVPT64IK3CJI7AHPN', N'85706e0f-dce5-4a6f-9d1a-cf6205690e95', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'EEFBFC72-4B22-43AD-1EDE-08DAD763C8CA', N'Trần Thị Ngọc Lan', N'lan@gmail.com', N'0245674123', N'331564230', N'default.png', N'lan123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'lan@gmail.com', N'LAN@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEKVBcgSmG87q6DSDqcJyrxmV1k9jUDAXybM0YkKQekRgeghZjOaVAETjssYIy7y8zw==', N'2HMYTGEHAKOSYZCQIDNICGEB2AMOY7GR', N'70dd1984-5290-42cc-9cf4-871f08437616', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0CBCB794-3418-49B2-E76C-08DAD7642878', N'Lê Thị Hoa', N'hoa@gmail.com', N'0376198527', N'331987264', N'default.png', N'hoa123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'hoa@gmail.com', N'HOA@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAECdkNGmwbaNxT5gYsMO9E6qLDn6HjYQnB+I/Ha+n6G3rXWa2nfR4YBzBSf5FsccfpA==', N'X4LAEU7LCZ2PHFZBNC2T3VITD635VUKX', N'3117c2ed-fc69-4157-a529-9b2b1fa14ac3', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8ED22925-29BA-44D5-5ED9-08DAD765184F', N'Nguyễn Văn Cường', N'cuong@gmail.com', N'0239761619', N'331846295', N'default.png', N'cuong123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'cuong@gmail.com', N'CUONG@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAENxDq+4AsfT22YidwYzFeFG3IBwZ/BmqkeiRQXVACA8r/Fxx6ssJ0DVbvtFqcXjbvA==', N'IZF6J46C6L7DCGGJEHO4WHZRIRURDKDK', N'adfbb863-6bf8-4c8e-9ae0-6a82933b4c03', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2D928DFB-421E-4380-5EDA-08DAD765184F', N'Mai Văn Thành', N'thanh@gmail.com', N'0916285273', N'331978284', N'default.png', N'thanh123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'thanh@gmail.com', N'THANH@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEHrQNqUNHZY7XF0nQbmKzP9oW9SaUCpKuYMpupu/2n+Ai8ww5QDlOYFCZLyillaY8Q==', N'ROCLFEJHLN77VXAEYESQPXPFORCJFC3B', N'61083bbb-6763-436b-a0b6-92b9b7db9845', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'188A18DC-4490-4332-BB9F-08DAD7759BC9', N'Nguyễn Nhựt Huy', N'nhuthuy@gmail.com', N'0536762915', N'331918362', N'default.png', N'huy123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'nhuthuy@gmail.com', N'NHUTHUY@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEJcOaXcujwR7LJDL85ImgRa2m0IzcSz+62SFkJuvp24auS63Qsp/MmdutbQSpcF7EQ==', N'URHB4KLMXR45QLXBVTN54AARWXUA6HNZ', N'9c851971-93b4-471b-8549-a8ffa7166c39', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'30DD4D48-3491-468A-7EC1-08DAD77651AC', N'Trần Tùng Lâm', N'lamtran@gmail.com', N'0725419852', N'331298763', N'default.png', N'lam123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'lamtran@gmail.com', N'LAMTRAN@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEK1aqbI1H+AkQ8FSRhKU13WBOahTdfEWNeBW/TfXGaO2yqMY1Z/H2N57KVkAqmkUGw==', N'N3KMOYM3QKN5RUHJLVL2NTXGC3KI24VU', N'8e7888aa-6c1e-436c-bb51-f9ae2bbadd05', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'77865433-450D-460E-E83C-08DAD93E1273', N'Nguyễn Văn Ân', N'tunglamhb2k3k4k@gmail.com', N'0338307449', N'331909754', N'default.png', NULL, N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'tunglamhb2k3k4k@gmail.com', N'TUNGLAMHB2K3K4K@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEF41igVZkDX4KsB/mNqTF3DqttOJupmgIZv6yRDxq6Fz3VQdJNJgL8gHepZPc+Suzg==', N'FZNBNLVPLMOZFCTURM3BBQ56G2ZVXIC7', N'9562940b-d69f-4b31-afda-133cb0b115dc', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'CBB11604-A154-4EE2-4C0D-08DADC2D8FF2', N'Trần Văn Dũng', N'tvdung@gmail.com', N'0189328918', N'331909754', N'default.png', NULL, N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'tvdung@gmail.com', N'TVDUNG@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEPpHLze5D8n+PV50OZApJA5nlkxD3FHQyLPpD5UqwZ/6QkI6zn7ybqgHFPd50iiF4w==', N'ULFPSMIU2BFHKO2YQXFGZ442NG4SUC5O', N'0a580097-ae7e-4a8e-8e7e-14a279eadfc4', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'BCAB563E-3889-4DA5-5C6B-08DADCAE2F4C', N'Nguyễn Thi Diễm', N'ntdiem@gmail.com', N'0338307449', N'331909654', N'default.png', NULL, N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'ntdiem@gmail.com', N'NTDIEM@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEBgvExO7+9qrWONJWnuLjLYnKll9wV5jySBFFwaUzjKNUE/7dbIUEtTUKvmpSKr4PQ==', N'6E3HK73O2B3AY67OM6KO5AFGFJBFBV2Y', N'b1f39083-961c-4ee2-ad41-6860d8bd3544', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9FB9D798-A999-45CC-5C6C-08DADCAE2F4C', N'Nguyễn Tùng Lâm', N'tunglam.contact@gmail.com', N'0338307449', N'331909754', N'default.png', N'lam123', N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'tunglam.contact@gmail.com', N'TUNGLAM.CONTACT@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEHjfnSKXuAUZdx3QmaJqjQpyQasz17PhcQKXB8leMEHEzl9mpeX7xNU3BpTMv9P2vQ==', N'33LMCM53Q26MHKLWYE3K6IRF3ERCAJCT', N'2a5cadd6-fc28-4728-ab04-cc7b766535a7', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4F8C4BF2-852F-4D1E-4D8C-08DADCD29B35', N'Lê Minh Kha', N'minhkhalectu@gmail.com', N'0362739174', N'652810382', N'default.png', NULL, N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'minhkhalectu@gmail.com', N'MINHKHALECTU@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEF8JNaYBXfgnhXf13WxAVlnDP1GL7ygohEIn7IDzJfgFxb7yY1OF7pbPFZ/ZNMGPxA==', N'OO2FYODP4BC5RP443UU7KZXGDGFFMLTD', N'7a921958-d470-4ed2-88e6-516da4b51e12', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'F0D9D70F-F68C-480A-4D8D-08DADCD29B35', N'Nguyễn Văn A', N'theskyhomestay.guest@gmail.com', N'0338307449', N'752381293', N'default.png', NULL, N'2022-12-04 19:09:48.4207062', N'2022-12-04 19:09:48.4207181', N'0', N'theskyhomestay.guest@gmail.com', N'THESKYHOMESTAY.GUEST@GMAIL.COM', NULL, N'0', N'AQAAAAEAACcQAAAAEMTwMBZzEIMEiLSuHSEnJoZ4+GetwXXSTO57eWlSE7CV11tX0aq5JoeM0lKnWhcQ/Q==', N'EJAHW2JLDZ4ZTWU7FMFUW7MDTSP3WTMP', N'0241a8b3-6f20-4e74-be63-c77eab95fc43', N'0', N'0', NULL, N'1', N'0')
GO

INSERT INTO [dbo].[User] ([Id], [Name], [Email], [PhoneNumber], [CINo], [Avatar], [Password], [RegisteredTime], [UpdatedTime], [IsBlocked], [UserName], [NormalizedUserName], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51B4B238-4AE0-4E46-A3F4-E0ACF7666B15', N'Trương Phi', N'phi@gmail.com', N'0338307994', N'444555666', N'an.jpg', N'phi123', N'2022-09-29 00:10:29.1719210', N'2022-09-29 00:10:29.1719339', N'0', NULL, NULL, NULL, N'0', NULL, NULL, N'b94eb68a-c967-41c3-a13e-2d2feea94a27', N'0', N'0', NULL, N'0', N'0')
GO


-- ----------------------------
-- Table structure for UserRole
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRole]') AND type IN ('U'))
	DROP TABLE [dbo].[UserRole]
GO

CREATE TABLE [dbo].[UserRole] (
  [Id] uniqueidentifier  NOT NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ConcurrencyStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[UserRole] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UserRole
-- ----------------------------
INSERT INTO [dbo].[UserRole] ([Id], [Description], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31', N'Tourist role', N'tourist', N'tourist', N'ea5c44c1-c245-4df6-a126-d0eacabd330c')
GO

INSERT INTO [dbo].[UserRole] ([Id], [Description], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9E87B492-5343-4272-9A34-FA5DE7CFFB22', N'Administrator role', N'admin', N'admin', N'ff2dddaa-b470-4a3c-868e-abec09fe36fa')
GO


-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for AppRoleClaims
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AppRoleClaims]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table AppRoleClaims
-- ----------------------------
ALTER TABLE [dbo].[AppRoleClaims] ADD CONSTRAINT [PK_AppRoleClaims] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for AppUserClaims
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AppUserClaims]', RESEED, 90)
GO


-- ----------------------------
-- Primary Key structure for table AppUserClaims
-- ----------------------------
ALTER TABLE [dbo].[AppUserClaims] ADD CONSTRAINT [PK_AppUserClaims] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AppUserLogins
-- ----------------------------
ALTER TABLE [dbo].[AppUserLogins] ADD CONSTRAINT [PK_AppUserLogins] PRIMARY KEY CLUSTERED ([UserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AppUserRoles
-- ----------------------------
ALTER TABLE [dbo].[AppUserRoles] ADD CONSTRAINT [PK_AppUserRoles] PRIMARY KEY CLUSTERED ([UserId], [RoleId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AppUserTokens
-- ----------------------------
ALTER TABLE [dbo].[AppUserTokens] ADD CONSTRAINT [PK_AppUserTokens] PRIMARY KEY CLUSTERED ([UserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Bills
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Bills]', RESEED, 50)
GO


-- ----------------------------
-- Indexes structure for table Bills
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Bills_TouristId]
ON [dbo].[Bills] (
  [TouristId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Bills
-- ----------------------------
ALTER TABLE [dbo].[Bills] ADD CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Feedbacks
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Feedbacks]', RESEED, 9)
GO


-- ----------------------------
-- Indexes structure for table Feedbacks
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Feedbacks_TouristId]
ON [dbo].[Feedbacks] (
  [TouristId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Feedbacks
-- ----------------------------
ALTER TABLE [dbo].[Feedbacks] ADD CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table RoomBookings
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_RoomBookings_RoomId]
ON [dbo].[RoomBookings] (
  [RoomId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table RoomBookings
-- ----------------------------
ALTER TABLE [dbo].[RoomBookings] ADD CONSTRAINT [PK_RoomBookings] PRIMARY KEY CLUSTERED ([BillId], [RoomId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for RoomCategories
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[RoomCategories]', RESEED, 6)
GO


-- ----------------------------
-- Primary Key structure for table RoomCategories
-- ----------------------------
ALTER TABLE [dbo].[RoomCategories] ADD CONSTRAINT [PK_RoomCategories] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for RoomImages
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[RoomImages]', RESEED, 32)
GO


-- ----------------------------
-- Indexes structure for table RoomImages
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_RoomImages_RoomId]
ON [dbo].[RoomImages] (
  [RoomId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table RoomImages
-- ----------------------------
ALTER TABLE [dbo].[RoomImages] ADD CONSTRAINT [PK_RoomImages] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Rooms
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Rooms]', RESEED, 10)
GO


-- ----------------------------
-- Indexes structure for table Rooms
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Rooms_CategoryId]
ON [dbo].[Rooms] (
  [CategoryId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Rooms
-- ----------------------------
ALTER TABLE [dbo].[Rooms] ADD CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table ServiceBookings
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_ServiceBookings_ServiceId]
ON [dbo].[ServiceBookings] (
  [ServiceId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table ServiceBookings
-- ----------------------------
ALTER TABLE [dbo].[ServiceBookings] ADD CONSTRAINT [PK_ServiceBookings] PRIMARY KEY CLUSTERED ([BillId], [ServiceId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Services
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Services]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table Services
-- ----------------------------
ALTER TABLE [dbo].[Services] ADD CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table UserRole
-- ----------------------------
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Bills
-- ----------------------------
ALTER TABLE [dbo].[Bills] ADD CONSTRAINT [FK_Bills_User_TouristId] FOREIGN KEY ([TouristId]) REFERENCES [dbo].[User] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Feedbacks
-- ----------------------------
ALTER TABLE [dbo].[Feedbacks] ADD CONSTRAINT [FK_Feedbacks_User_TouristId] FOREIGN KEY ([TouristId]) REFERENCES [dbo].[User] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table RoomBookings
-- ----------------------------
ALTER TABLE [dbo].[RoomBookings] ADD CONSTRAINT [FK_RoomBookings_Bills_BillId] FOREIGN KEY ([BillId]) REFERENCES [dbo].[Bills] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[RoomBookings] ADD CONSTRAINT [FK_RoomBookings_Rooms_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table RoomImages
-- ----------------------------
ALTER TABLE [dbo].[RoomImages] ADD CONSTRAINT [FK_RoomImages_Rooms_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Rooms
-- ----------------------------
ALTER TABLE [dbo].[Rooms] ADD CONSTRAINT [FK_Rooms_RoomCategories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[RoomCategories] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ServiceBookings
-- ----------------------------
ALTER TABLE [dbo].[ServiceBookings] ADD CONSTRAINT [FK_ServiceBookings_Bills_BillId] FOREIGN KEY ([BillId]) REFERENCES [dbo].[Bills] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ServiceBookings] ADD CONSTRAINT [FK_ServiceBookings_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Services] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

