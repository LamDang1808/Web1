CREATE TABLE [dbo].[ThongTinBenhNhan] (
    [MaBN]          NVARCHAR (50)  NOT NULL,
    [HoTenBN]       NVARCHAR (MAX) NULL,
    [GioiTinhBN]    NVARCHAR (50)  NULL,
    [NgaySinh]      DATE           NULL,
    [TinhTrangBenh] NVARCHAR (MAX) NULL,
    [Thuoc]         NVARCHAR (MAX) NULL,
    [GhiChu]        NVARCHAR (MAX) NULL,
    [DiaChi] NVARCHAR(MAX) NULL, 
    [DoiTuong] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_ThongTinBenhNhan] PRIMARY KEY CLUSTERED ([MaBN] ASC)
);

