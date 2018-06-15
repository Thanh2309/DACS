/*
Created		5/29/2018
Modified		6/8/2018
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
DROP DATABASE DOANCOSO
DROP TABLE KHOA
DROP TABLE LOP	
DROP TABLE CAP_SV5T
DROP TABLE ACCOUNT
DROP TABLE CHITIET_TC
DROP TABLE KQDANHGIA_ACCOUNT
DROP TABLE LHTT
DROP TABLE LOAIACCOUNT
CREATE DATABASE DOANCOSO
USE DOANCOSO
Create table [KHOA]
(
	[MAKHOA] VARChar(10) NOT NULL,
	[TENKHOA] Nvarchar(100) NULL,
	[SOLUONGSV] Integer NULL,
Primary Key ([MAKHOA])
) 
go

Create table [LOP]
(
	[MALOP] VARCHAR(10) NOT NULL,
	[MAKHOA] VARChar(10) NOT NULL,
	[SOLUONG_SV] Integer NULL,
Primary Key ([MALOP])
) 
go

Create table [CAP_SV5T]
(
	[MACAP] Char(5) NOT NULL,
	[TENCAP] Nvarchar(50) NULL,
	[SOLUONGDK] Integer NULL,
Primary Key ([MACAP])
) 
go

Create table [PHIEUDK_SV5T]
(
	[SOPHIEUDK] Integer NOT NULL,
	[NGAYLAP] Datetime NULL,
	[DRL_HK1] Integer NULL,
	[DRL_HK2] Integer NULL,
	[DRL_TB] Integer NULL,
	[KQ_CHATLUONGDOANVIEN] Nvarchar(30) NULL,
	[DD_THANHNIENTTLAMTHEOLOIBAC] Bit NULL,
	[DD_HOITHI_TTHCM] Bit NULL,
	[DIEMHK1] Float NULL,
	[DIEMHK2] Float NULL,
	[DIEMTB] Float NULL,
	[HT_BAIVIETKH] Bit NULL,
	[HT_NCKH] Char(1) NULL,
	[HT_GIAITHIHOCTHUAT] Bit NULL,
	[TEN_THIHOCTHUAT] Nvarchar(200) NULL,
	[TL_SVKHOE] Bit NULL,
	[TL_TV_DOITUYENTDTT] Bit NULL,
	[DATGIAIHOITHAOCACCAP] Bit NULL,
	[TEN_CAPHOITHAO] Nvarchar(100) NULL,
	[TN_THAMGIACHIENDICHLON] Binary(1) NULL,
	[TN_5HDTN_NAM] Bit NULL,
	[HN_AV_B1] Bit NULL,
	[TEN_AV_KHAC] Varchar(50) NULL,
	[HN_GIAOLUUQT] Bit NULL,
	[HN_GIAICUOCTHI_NNgu] Bit NULL,
	[HN_1KHOAHOCKYNANG] Bit NULL,
	[HN_3BUOI_HOITHAOKYNANG] Bit NULL,
	[HN_THAMGIA_HDHOINHAP] Bit NULL,
	[UT_KETNAPDANG] Bit NULL,
	[UT_HIENMAU] Bit NULL,
	[UT_BIEUDUONG_KHENTHUONG] Bit NULL,
	[KHOKHAN-KIENNGHI] Nvarchar(500) NULL,
	[MACAP] Char(5) NOT NULL,
	[USERNAME] Varchar(15) NOT NULL,
Primary Key ([SOPHIEUDK])
) 
go

Create table [LHTT]
(
	[STT] Tinyint NOT NULL,
	[MALOP] VARCHAR(10) NOT NULL,
Primary Key ([STT])
) 
go

Create table [ACCOUNT]
(
	[USERNAME] Varchar(15) NOT NULL,
	[MAKHOA] VARChar(10) NULL,
	[PASSWORD] Char(20) NULL,
	[MALOAI] Char(5) NOT NULL,
	[QUYEN] Bit Default 0 NOT NULL,
Primary Key ([USERNAME])
) 
go

Create table [KQDANHGIA_ACCOUNT]
(	
	[DIEMRL] Bit NULL,
	[DIEMHOCTAP] Bit NULL,
	[TEST_THELUC] Bit NULL,
	[TN_5NGAYTN] Bit NULL,
	[TN_3CHIENDICHLON] Bit NULL,
	[HN_NGOAINGU] Bit NULL,
	[HN_KYNANG] Bit NULL,
	[UT_KETNAPDANG] Bit NULL,
	[UT_HIENMAU] Bit NULL,
	[UT_BIEUDUONG] Bit NULL,
	[USERNAME] Varchar(15) NOT NULL,
	[MaNguoiDanhGia] char(5) not null,
	Primary Key ([USERNAME], [MaNguoiDanhGia])
) 
go


Create table [NGUOIDANHGIA]
(
	[MaNguoiDanhGia] Char(5) NOT NULL,
	[TenLoai] Nvarchar(100) NULL,
Primary Key ([MaNguoiDanhGia])
) 
go

Create table [TIEUCHI_SV5T]
(
	[MATC] Char(5) NOT NULL,
	[TENTC] Nvarchar(200) NULL,
	[SOLUONG] Integer NULL,
Primary Key ([MATC])
) 
go

Create table [CHITIET_TC]
(
	[MATC] Char(5) NOT NULL,
	[MACAP] Char(5) NOT NULL,
	[NOIDUNG_TC1] Nvarchar(250) NULL,
	[NGAYCHINHSUA] Datetime NULL,
	[NOIDUNG_TC2] Nvarchar(500) NULL,
	[NOIDUNG_TC3] Nvarchar(500) NULL,
	[NOIDUNGTC_4] Nvarchar(500) NULL,
Primary Key ([MATC],[MACAP])
) 
go


Alter table [LOP] add  foreign key([MAKHOA]) references [KHOA] ([MAKHOA])  on update no action on delete no action 
go
Alter table [ACCOUNT] add  foreign key([MAKHOA]) references [KHOA] ([MAKHOA])  on update no action on delete no action 
go
Alter table [LHTT] add  foreign key([MALOP]) references [LOP] ([MALOP])  on update no action on delete no action 
go
Alter table [PHIEUDK_SV5T] add  foreign key([MACAP]) references [CAP_SV5T] ([MACAP])  on update no action on delete no action 
go
Alter table [CHITIET_TC] add  foreign key([MACAP]) references [CAP_SV5T] ([MACAP])  on update no action on delete no action 
go
Alter table [KQDANHGIA_ACCOUNT] add  foreign key([USERNAME]) references [ACCOUNT] ([USERNAME])  on update no action on delete no action 
go
Alter table [KQDANHGIA_ACCOUNT] add  foreign key([MaNguoiDanhGia]) references [NGUOIDANHGIA] ([MaNguoiDanhGia])  on update no action on delete no action 
go
Alter table [PHIEUDK_SV5T] add  foreign key([USERNAME]) references [ACCOUNT] ([USERNAME])  on update no action on delete no action 
go
Alter table [ACCOUNT] add  foreign key([MALOAI]) references [LOAIACCOUNT] ([MALOAI])  on update no action on delete no action 
go
Alter table [CHITIET_TC] add  foreign key([MATC]) references [TIEUCHI_SV5T] ([MATC])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


