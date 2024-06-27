CREATE TABLE [dbo].[ThongTinBenhNhan] (
    [MaBN]          VARBINARY(MAX)  NOT NULL,
    [HoTenBN]       NVARCHAR (MAX) NULL,
    [GioiTinhBN]    NVARCHAR (MAX)  NULL,
    [NgaySinh]      NVARCHAR(MAX)           NULL,
    [TinhTrangBenh] NVARCHAR (MAX) NULL,
    [Thuoc]         NVARCHAR (MAX) NULL,
    [GhiChu]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ThongTinBenhNhan] PRIMARY KEY CLUSTERED ([MaBN] ASC)
);

