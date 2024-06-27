create database QLBenhNhan
go
use QLBenhNhan
CREATE TABLE [dbo].[ThongTinBenhNhan] (
    [MaBN]          NVARCHAR (50)  NOT NULL,
    [HoTenBN]       NVARCHAR (MAX) NULL,
    [GioiTinhBN]    NVARCHAR (50)  NULL,
    [NgaySinh]      DATE           NULL,
    [TinhTrangBenh] NVARCHAR (MAX) NULL,
    [Thuoc]         NVARCHAR (MAX) NULL,
    [GhiChu]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ThongTinBenhNhan] PRIMARY KEY CLUSTERED ([MaBN] ASC)
);
go
INSERT INTO [dbo].[ThongTinBenhNhan] ([MaBN], [HoTenBN], [GioiTinhBN], [NgaySinh], [TinhTrangBenh], [Thuoc], [GhiChu]) VALUES (N'Bn01', N'Nguyễn Thị An', N'Nữ', N'2001-02-06', N'Ho, đau họng', N'Thuốc Ho, Viên Ngậm', N'2 lần/ngày, sau khi ăn')
INSERT INTO [dbo].[ThongTinBenhNhan] ([MaBN], [HoTenBN], [GioiTinhBN], [NgaySinh], [TinhTrangBenh], [Thuoc], [GhiChu]) VALUES (N'Bn02', N'Trần Hùng Anh', N'Nam', N'2000-06-03', N'Đau bụng', N'Thuốc Dạ dày', N'2 lần/ngày, sau ăn')
