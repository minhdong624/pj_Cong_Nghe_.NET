USE [QLCuaHangDienThoai]
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[User] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NULL,
 CONSTRAINT [PK_tblDangNhap] PRIMARY KEY CLUSTERED 
(
	[User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDienThoai]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDienThoai](
	[MaSP] [nvarchar](15) NOT NULL,
	[Hang] [nvarchar](255) NULL,
	[TenSP] [nvarchar](255) NULL,
	[Ram] [float] NULL,
	[Rom] [float] NULL,
	[Weight] [float] NULL,
	[Screen] [float] NULL,
	[Pin] [float] NULL,
	[Width] [float] NULL,
	[Height] [float] NULL,
	[Price] [float] NULL,
 CONSTRAINT [DienThoai_PK] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[MaHD] [nvarchar](15) NOT NULL,
	[MaKH] [nvarchar](15) NULL,
	[MaNV] [nvarchar](15) NULL,
	[MaSP] [nvarchar](15) NULL,
	[SoSP] [float] NULL,
	[MaPK] [nvarchar](15) NULL,
	[SoPK] [float] NULL,
	[NgayLap] [datetime] NULL,
	[Tong] [float] NULL,
 CONSTRAINT [HoaDon_PK] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [nvarchar](15) NOT NULL,
	[TenKH] [nvarchar](255) NULL,
	[SDT] [float] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
 CONSTRAINT [KhachHang_PK] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [nvarchar](15) NOT NULL,
	[TenNV] [nvarchar](255) NULL,
	[SDT] [float] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[ChuyenMon] [nvarchar](50) NULL,
	[Luong] [float] NULL,
 CONSTRAINT [NhanVien_PK] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhuKien]    Script Date: 17/07/2021 06:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhuKien](
	[MaPK] [nvarchar](15) NOT NULL,
	[TenPK] [nvarchar](255) NULL,
	[Hang] [nvarchar](255) NULL,
	[Loai] [nvarchar](255) NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PhuKien_PK] PRIMARY KEY CLUSTERED 
(
	[MaPK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblDangNhap] ([User], [Password]) VALUES (N'admin', N'admin     ')
INSERT [dbo].[tblDangNhap] ([User], [Password]) VALUES (N'dinh', N'haha1     ')
INSERT [dbo].[tblDangNhap] ([User], [Password]) VALUES (N'dong', N'haha      ')
INSERT [dbo].[tblDangNhap] ([User], [Password]) VALUES (N'dong1', N'haha      ')
GO
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP001', N'Iphone', N'Iphone SE 2020', 3, 128, 148, 4.7, 1750, 67.3, 138.4, 12500000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP002', N'Iphone', N'Iphone X', 3, 64, 174, 5.8, 2716, 70.9, 143.6, 19000000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP003', N'Iphone', N'Iphone 11', 4, 64, 194, 6.1, 3110, 75.7, 150.9, 17900000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP004', N'Iphone', N'Iphone 8 plus', 3, 64, 202, 5.5, 2691, 78.1, 158.4, 13200000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP005', N'Iphone', N'Iphone 11 Pro', 4, 64, 188, 5.8, 3046, 71.1, 144, 23700000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP006', N'Iphone', N'Iphone 11 Pro Max', 4, 64, 226, 6.5, 3969, 77.8, 158, 26200000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP007', N'Iphone', N'Iphone XR', 3, 64, 194, 6.1, 2942, 75.7, 150.9, 12990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP008', N'Iphone', N'Iphone 7', 2, 32, 138, 4.7, 1960, 67.1, 138.3, 7000000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'IP009', N'Iphone', N'Iphone 6s plus', 2, 32, 192, 5.5, 2750, 77.9, 158.2, 7000000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG001', N'LG', N'LG V50s ThinQ 5G 256gb', 8, 256, 192, 6.4, 4000, 159.3, 75.8, 14790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG002', N'LG', N'LG V50s ThinQ 5G 512gb', 8, 512, 192, 6.4, 4000, 159.3, 75.8, 16790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG003', N'LG', N'LG V60 ThinQ 5G 256gb', 8, 256, 218, 6.8, 5000, 169.3, 77.6, 10390000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG004', N'LG', N'LG V60 ThinQ 5G 512gb', 8, 512, 218, 6.8, 5000, 169.3, 77.6, 11390000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG005', N'LG', N'LG V50 ThinQ 5G 64gb', 6, 64, 183, 6.4, 4000, 159.2, 76.1, 8190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG006', N'LG', N'LG V50 ThinQ 5G 128gb', 6, 128, 183, 6.4, 4000, 159.2, 76.1, 9190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG007', N'LG', N'LG V50 ThinQ 5G 256gb', 6, 256, 183, 6.4, 4000, 159.2, 76.1, 10190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG008', N'LG', N'LG G8 ThinQ  128gb', 6, 128, 167, 6.1, 3500, 151.9, 71.8, 6290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG009', N'LG', N'LG G8 ThinQ  256gb', 6, 256, 167, 6.1, 3500, 151.9, 71.8, 7290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG010', N'LG', N'LG G8 ThinQ  512gb', 6, 512, 167, 6.1, 3500, 151.9, 71.8, 8290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG011', N'LG', N'LG V40 ThinQ  64gb', 6, 64, 169, 6.4, 3300, 158.8, 75.7, 5890000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG012', N'LG', N'LG V40 ThinQ  128gb', 6, 128, 169, 6.4, 3300, 158.8, 75.7, 6890000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG013', N'LG', N'LG V40 ThinQ  256gb', 6, 256, 169, 6.4, 3300, 158.8, 75.7, 7890000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG014', N'LG', N'LG G7 ThinQ  64gb', 4, 64, 170, 6.1, 3000, 153.2, 71.9, 3490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG015', N'LG', N'LG G7 ThinQ  128gb', 4, 128, 170, 6.1, 3000, 153.2, 71.9, 4490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG016', N'LG', N'LG G7 ThinQ  256gb', 4, 256, 170, 6.1, 3000, 153.2, 71.9, 5490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG017', N'LG', N'LG V30 Plus  64gb', 4, 64, 172, 6, 3300, 151.2, 70.5, 2990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG018', N'LG', N'LG V30 Plus  128gb', 4, 128, 172, 6, 3300, 151.2, 70.5, 3990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG019', N'LG', N'LG V30 Plus  256gb', 4, 256, 172, 6, 3300, 151.2, 70.5, 4990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG020', N'LG', N'LG G6 32gb', 4, 32, 171, 6, 3300, 150.1, 69.6, 2490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG021', N'LG', N'LG G6 64gb', 4, 64, 171, 6, 3300, 150.1, 69.6, 3490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG022', N'LG', N'LG G6 1238gb', 4, 128, 171, 6, 3300, 150.1, 69.6, 4490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG023', N'LG', N'LG G8X ThinQ  128gb', 6, 128, 192, 6.5, 4000, 159.3, 75.8, 5990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG024', N'LG', N'LG G8X ThinQ  256gb', 6, 256, 192, 6.5, 4000, 159.3, 75.8, 6990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'LG025', N'LG', N'LG G8X ThinQ  512gb', 6, 512, 192, 6.5, 4000, 159.3, 75.8, 7990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO001', N'Sony', N'Sony Xperia XZ2', 4, 64, 205, 5.7, 3180, 163.6, 75, 5490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO002', N'Sony', N'Sony Xperia Z5', 3, 32, 154, 5.2, 2900, 146, 72, 2500000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO003', N'Sony', N'Sony Xperia 10 ii', 4, 128, 151, 6, 3600, 157, 69, 6190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO004', N'Sony', N'Sony Xperia 10 ', 3, 64, 162, 6, 2870, 155.7, 68, 5990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO005', N'Sony', N'Sony Xperia 5', 6, 128, 164, 6.1, 3140, 158, 68, 11500000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO006', N'Sony', N'Sony Xperia 5 ii', 8, 128, 163, 6.1, 4000, 158, 68, 24890000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO007', N'Sony', N'Sony Xperia 1 II', 8, 256, 181.4, 6.5, 4000, 165.1, 71.1, 22900000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO008', N'Sony', N'Sony Xperia 1', 6, 128, 180, 6.5, 3330, 167, 72, 14190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SO009', N'Sony', N'Sony Xperia 10 Plus', 4, 64, 180, 6.5, 3000, 167, 73, 4990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS001', N'Samsung', N'Samsung Galaxy A01', 2, 16, 149, 5.7, 3000, 146.2, 70.9, 2790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS002', N'Samsung', N'Samsung Galaxy A11', 3, 32, 177, 6.4, 4000, 161.4, 76.3, 3490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS003', N'Samsung', N'Samsung Galaxy A10s', 2, 32, 168, 6.2, 4000, 156.89, 75.8, 3690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS004', N'Samsung', N'Samsung Galaxy A20s 32GB', 3, 32, 183, 6.5, 4000, 163.3, 77.5, 4390000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS005', N'Samsung', N'Samsung Galaxy A21s 3G/32GB)', 3, 32, 192, 6.5, 5000, 163.3, 77.5, 4690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS006', N'Samsung', N' Samsung Galaxy A20s 64GB', 4, 64, 183, 6.5, 4000, 163.3, 77.5, 5300000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS007', N'Samsung', N'Samsung Galaxy A21s 6GB 64GB', 6, 64, 192, 6.5, 5000, 163.3, 77.5, 5690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS008', N'Samsung', N'Samsung Galaxy A30s', 4, 64, 166, 6.4, 4000, 158.5, 74.7, 6290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS009', N'Samsung', N'Samsung Galaxy A31', 6, 128, 185, 6.4, 5000, 159.3, 73.1, 6490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS010', N'Samsung', N'Samsung Galaxy A50s', 4, 64, 169, 6.4, 4000, 158.5, 74.5, 6990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS011', N'Samsung', N'Samsung Galaxy A51 6GB 128GB', 6, 128, 172, 6.5, 4000, 158.4, 73.7, 7990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS012', N'Samsung', N'Samsung Galaxy A51  8GB 128GB', 8, 128, 173, 6.5, 4500, 158.4, 73.7, 8390000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS013', N'Samsung', N'Samsung Galaxy A70', 6, 128, 170, 6.7, 4500, 164.3, 76.7, 9290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS014', N'Samsung', N'Samsung Galaxy A71', 8, 128, 172, 6.7, 4500, 164.3, 76.7, 10490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS015', N'Samsung', N'Samsung Galaxy Note 10 Lite', 8, 128, 167, 6.7, 4500, 163.7, 76.1, 11490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS016', N'Samsung', N'Samsung Galaxy S10 Lite', 8, 128, 180, 6.7, 4500, 162.5, 75.6, 14990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS017', N'Samsung', N'Samsung Galaxy Note 10+', 12, 256, 196, 6.7, 4300, 162.3, 77.2, 17900000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS018', N'Samsung', N'Samsung Galaxy S20', 8, 128, 163, 6.2, 4000, 151.7, 69.1, 21490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS019', N'Samsung', N'Samsung Galaxy S20+', 8, 128, 188, 6.7, 4500, 161.9, 73.7, 23990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS020', N'Samsung', N'Samsung Galaxy M51', 8, 128, 213, 6.7, 7000, 163.9, 76.3, 9490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS021', N'Samsung', N'Samsung Galaxy S20 FE', 8, 128, 190, 6.5, 4500, 159.8, 74, 15990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS022', N'Samsung', N'Samsung Galaxy Note 20', 8, 256, 192, 6.7, 4300, 161.6, 72.5, 23990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS023', N'Samsung', N'Samsung Galaxy Note 20 Ultra', 8, 256, 208, 6.7, 4500, 164.8, 77.2, 29990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'SS024', N'Samsung', N' Samsung Galaxy Note 20 Ultra 5G', 12, 256, 208, 6.7, 4500, 164.8, 77.2, 32900000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI001', N'Vivo', N'Vivo Y30i 64gb', 4, 64, 197, 6.47, 5000, 162.04, 76.46, 3090000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI002', N'Vivo', N'Vivo Y30i 128gb', 4, 128, 197, 6.47, 5000, 162.04, 76.46, 4090000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI003', N'Vivo', N'Vivo Y20s 128gb', 6, 128, 192.3, 6.5, 5000, 164.41, 76.32, 4990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI004', N'Vivo', N'Vivo Y20s 256gb', 6, 256, 192.3, 6.5, 5000, 164.41, 76.32, 5990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI005', N'Vivo', N'Vivo Y20 64gb', 4, 64, 192.3, 6.5, 5000, 164.41, 76.32, 3590000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI006', N'Vivo', N'Vivo Y20 128gb', 4, 128, 192.3, 6.5, 5000, 164.41, 76.32, 4590000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI007', N'Vivo', N'Vivo Y20 256gb', 4, 128, 192.3, 6.5, 5000, 164.41, 76.32, 5590000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI008', N'Vivo', N'Vivo V20 128gb', 8, 128, 171, 6.44, 4000, 161.3, 74.2, 7490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI009', N'Vivo', N'Vivo V20 256gb', 8, 256, 171, 6.44, 4000, 161.3, 74.2, 8490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI011', N'Vivo', N'Vivo Y15 64gb', 4, 64, 180, 6.5, 5000, 150.2, 72.4, 2240000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI012', N'Vivo', N'Vivo Y15 128gb', 4, 128, 180, 6.5, 5000, 150.2, 72.4, 3240000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI013', N'Vivo', N'Vivo Y11 32gb', 3, 32, 190.5, 6.35, 5000, 159.3, 76.77, 2690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI014', N'Vivo', N'Vivo Y11 64gb', 3, 64, 190.5, 6.35, 5000, 159.3, 76.77, 3690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI015', N'Vivo', N'Vivo Y11 128gb', 3, 128, 190.5, 6.35, 5000, 159.3, 76.77, 4690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI016', N'Vivo', N'Vivo U10 64gb', 3, 64, 190, 6.35, 5000, 159.43, 76.77, 3790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI017', N'Vivo', N'Vivo U10 128gb', 3, 128, 190, 6.35, 5000, 159.43, 76.77, 4790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI018', N'Vivo', N'Vivo Y19 128gb', 6, 128, 190, 6.53, 5000, 164.41, 76.32, 4990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI019', N'Vivo', N'Vivo Y19 256gb', 6, 256, 190, 6.53, 5000, 164.41, 76.32, 5990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI020', N'Vivo', N'Vivo Y50 128gb', 8, 128, 197, 6.53, 5000, 162.4, 76.45, 6290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI021', N'Vivo', N'Vivo Y50 256gb', 8, 256, 197, 6.53, 5000, 162.4, 76.45, 7290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI022', N'Vivo', N'Vivo Y50 512gb', 8, 512, 197, 6.53, 5000, 162.4, 76.45, 8290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI023', N'Vivo', N'Vivo V20 SE 128gb', 8, 128, 171, 6.44, 4100, 162.4, 76.45, 7190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI024', N'Vivo', N'Vivo V20 SE 256gb', 8, 256, 171, 6.44, 4100, 162.4, 76.45, 8190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI025', N'Vivo', N'Vivo V20 SE 512gb', 8, 512, 171, 6.44, 4100, 162.4, 76.45, 9190000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI026', N'Vivo', N'Vivo Y1s 32gb', 2, 32, 161, 6.22, 4030, 150.2, 75.09, 2490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VI027', N'Vivo', N'Vivo Y1s 64gb', 2, 64, 161, 6.22, 4030, 150.2, 75.09, 3490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS001', N'Vsmart', N'Vsmart Star 3', 2, 16, 149, 6, 3500, 157.8, 76, 1990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS002', N'Vsmart', N'Vsmart Aris', 8, 128, 178, 6.4, 4000, 156.2, 75, 7490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS003', N'Vsmart', N'Vsmart Joy 4', 3, 64, 216, 6.53, 5000, 163.65, 77.65, 3290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS004', N'Vsmart', N'Vsmart Joy 4', 4, 64, 216, 6.53, 5000, 163.65, 77.65, 3590000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS005', N'Vsmart', N'Vsmart Aris', 6, 64, 178, 6.39, 4000, 156.2, 75.04, 7490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS006', N'Vsmart', N'Vsmart Aris Pro', 8, 128, 178, 6.39, 4000, 156.2, 75.04, 9999000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS007', N'Vsmart', N'Vsmart Live 4 4GB', 4, 64, 217, 6.5, 5000, 162.4, 76.5, 4390000)
GO
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS008', N'Vsmart', N'Vsmart Live 4 6GB', 6, 64, 166, 6.5, 5000, 162.4, 76.5, 4790000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS009', N'Vsmart', N'Vsmart Star 4', 2, 16, 165, 6.09, 3500, 156.24, 74, 2050000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS010', N'Vsmart', N'Vsmart Star 4', 3, 32, 165, 6.09, 3500, 156.24, 74, 2490000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS011', N'Vsmart', N'Vsmart Star 4', 2, 32, 165, 6.09, 3500, 156.24, 74, 2290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS012', N'Vsmart', N'Vsmart Joy 3', 3, 32, 192, 6.5, 5000, 165.13, 76.4, 2690000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS013', N'Vsmart', N'Vsmart Joy 3', 4, 64, 192, 6.5, 5000, 165.13, 76.4, 3290000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS014', N'Vsmart', N'Vsmart Active 3', 6, 64, 183, 6.39, 4020, 166.25, 75.62, 3990000)
INSERT [dbo].[tblDienThoai] ([MaSP], [Hang], [TenSP], [Ram], [Rom], [Weight], [Screen], [Pin], [Width], [Height], [Price]) VALUES (N'VS015', N'Vsmart', N'Vsmart Bee 3', 2, 16, 170, 6, 3000, 163.6, 77.2, 1590000)
GO
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD001', N'KH001', N'NV003', N'IP001', 2, N'P001', 0, CAST(N'2020-08-07T00:00:00.000' AS DateTime), 25000000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD002', N'KH002', N'NV003', N'IP002', 2, N'P002', 1, CAST(N'2020-05-13T00:00:00.000' AS DateTime), 19550000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD003', N'KH003', N'NV003', N'IP003', 3, N'P003', 3, CAST(N'2020-05-18T00:00:00.000' AS DateTime), 36700000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD004', N'KH004', N'NV003', N'IP004', 2, N'P004', 0, CAST(N'2020-10-21T00:00:00.000' AS DateTime), 13200000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD005', N'KH005', N'NV003', N'IP005', 3, N'P005', 1, CAST(N'2020-11-09T00:00:00.000' AS DateTime), 71550000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD006', N'KH006', N'NV003', N'IP006', 1, N'P006', 0, CAST(N'2020-11-24T00:00:00.000' AS DateTime), 78600000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD007', N'KH007', N'NV003', N'IP007', 2, N'P007', 0, CAST(N'2020-03-11T00:00:00.000' AS DateTime), 12990000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD008', N'KH008', N'NV005', N'IP008', 3, N'P008', 0, CAST(N'2020-03-26T00:00:00.000' AS DateTime), 7000000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD009', N'KH009', N'NV005', N'IP009', 2, N'P009', 3, CAST(N'2020-04-21T00:00:00.000' AS DateTime), 23700000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD010', N'KH010', N'NV005', N'VI001', 2, N'P010', 3, CAST(N'2020-05-24T00:00:00.000' AS DateTime), 5190000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD011', N'KH011', N'NV005', N'VI002', 2, N'P011', 3, CAST(N'2020-07-26T00:00:00.000' AS DateTime), 12380000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD012', N'KH012', N'NV005', N'VI003', 1, N'P012', 1, CAST(N'2020-04-18T00:00:00.000' AS DateTime), 10580000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD013', N'KH013', N'NV005', N'VI004', 2, N'SC001', 3, CAST(N'2020-01-27T00:00:00.000' AS DateTime), 18870000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD014', N'KH014', N'NV008', N'VI005', 1, N'SC002', 2, CAST(N'2020-02-27T00:00:00.000' AS DateTime), 11270000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD015', N'KH015', N'NV008', N'VI006', 2, N'SC003', 0, CAST(N'2020-01-12T00:00:00.000' AS DateTime), 4590000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD016', N'KH016', N'NV008', N'VI007', 3, N'SC004', 2, CAST(N'2020-06-10T00:00:00.000' AS DateTime), 6360000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD017', N'KH017', N'NV008', N'VI008', 2, N'SC005', 2, CAST(N'2020-04-20T00:00:00.000' AS DateTime), 15320000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD018', N'KH018', N'NV008', N'VI009', 2, N'SC006', 3, CAST(N'2020-06-15T00:00:00.000' AS DateTime), 9540000)
INSERT [dbo].[tblHoaDon] ([MaHD], [MaKH], [MaNV], [MaSP], [SoSP], [MaPK], [SoPK], [NgayLap], [Tong]) VALUES (N'HD025', N'KH005', N'NV003', N'IP001', 1, N'P004', 0, CAST(N'2020-02-12T00:00:00.000' AS DateTime), 12500000)
GO
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH001', N'Nguyễn Văn An', 7876534, N'Hồ Chí Minh', N'123@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH002', N'Nguyễn Văn Bình', 342435467, N'Hà Nội', N'dagvc@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH003', N'Lê Văn Long', 214356456, N'Đà Nẵng', N'qtorero@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH004', N'Lê Thị Hiền', 7656542, N'Huế', N'fdxcz@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH005', N'Nguyễn Thị Vân', 23456, N'Hồ Chí Minh', N'sdfdfgj@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH006', N'Trần Văn An', 324567, N'Hà Nội', N'fdsfsk@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH007', N'Trần Thị Loan', 124567, N'Quảng Ngãi', N'qwerewro@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH008', N'Nguyễn Văn Dũng', 764535, N'Đồng Nai', N'xzcmxzc@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH009', N'Võ Thị Như Quỳnh', 74532, N'Cà Mau', N'wesadk@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH010', N'Trương Đình Mạnh', 32678567, N'Hồ Chí Minh', N'xzmcask@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH011', N'Trần Thị Hoài Nhi', 3245923, N'Hà Nội', N'qwoeqwo@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH012', N'Nguyễn Đại Hải', 32784433, N'Quảng Bình', N'dfsl@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH013', N'Nguyễn Mạnh Hùng', 5644234, N'Huế', N'243024@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH014', N'Lê Quang Đình', 313545, N'Đà Nẵng', N'swasid@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH015', N'Bế Bình Minh Đông', 13563, N'Quảng Bình', N'oiqweoq@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH016', N'Nguyễn Xuân Hiếu', 2312456, N'Quảng Ngãi', N'xcmvmcx@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH017', N'Nguyễn Hữu Phúc', 21316456, N'Hồ Chí Minh', N'eworeo@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH018', N'Nguyễn Trung Nguyên', 214567, N'Hà Nội', N'dsjfdsf@gmail.com')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Email]) VALUES (N'KH019', N'Lê Thị Huyền', 321456, N'Hà Tĩnh', N'qeqw2@gmail.com')
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV001', N'Le Van A', 123456789, N'HCM', N'haha@gmail.com', N'Quan Ly', 10000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV002', N'Nguyen Van B', 123456, N'Ha Noi', N'haha1@gmail.com', N'Nhân Viên Kho', 6000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV003', N'Tran Van C', 123, N'Da Nang', N'haha2@gmail.com', N'Nhân Viên Bán Hàng', 8000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV004', N'Le Van D', 12, N'Can Tho', N'haha3@gmail.com', N'Bao Ve', 5000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV005', N'Nguyen Thi E', 155152, N'Can Tho', N'haha4@gmail.com', N'Nhân Viên Bán Hàng', 8000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV006', N'Ly Quang F', 646115, N'Can Tho', N'haha5@gmail.com', N'Nhân Viên Tu Van', 6500000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV008', N'Dinh Thi G', 6151515, N'Can Tho', N'haha7@gmail.com', N'Nhân Viên Bán Hàng', 8000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV009', N'Trieu H', 621151, N'Can Tho', N'haha8@gmail.com', N'Bao Ve', 5000000)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [SDT], [DiaChi], [Email], [ChuyenMon], [Luong]) VALUES (N'NV010', N'Nguyen I', 285456324, N'Hue', N'Ihue958@gmail.com', N'Nhân Viên Kho', 6000000)
GO
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'Op001', N'Ốp lưng Galaxy A02s Nhựa dẻo Soft Clear Samsung Trong suốt', N'Soft Clear', N'Op lung', 160000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'Op002', N'Ốp lưng iPhone 12 Pro Max Nhựa cứng viền dẻo TPU PC Double Phone Case COSANO Đen', N'COSANO', N'Op lung', 150000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'Op003', N'Ốp lưng Galaxy M51 Nhựa dẻo TPU PVC bracelet metal ring MEEKER Hồng nhạt', N'MEEKER', N'Op lung', 100000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P001', N'Pin sạc dự phòng Polymer 10.000mAh Type C Xiaomi Power Bank 3 Ultra Compact Đen', N'Xiaomi', N'Pin sac du phong', 790000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P002', N'Pin sạc dự phòng Polymer 10.000mAh Type C Energizer UE10054BK Đen', N'Energizer', N'Pin sac du phong', 550000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P003', N'Pin sạc dự phòng 7500mAh AVA DS004', N'AVA', N'Pin sac du phong', 300000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P004', N'Pin sạc dự phòng 7500mAh AVA DS630', N'AVA', N'Pin sac du phong', 300000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P005', N'Pin sạc dự phòng Polymer 10.000mAh AVA PJ JP191S', N'AVA', N'Pin sac du phong', 450000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P006', N'Pin sạc dự phòng Polymer 10.000mAh AVA PJ JP207 Xám', N'AVA', N'Pin sac du phong', 450000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P007', N'Pin sạc dự phòng Polymer 10.000mAh không dây Type C PD QC3.0 Xmobile PowerLite P106WD Đen', N'Xmobile', N'Pin sac du phong', 750000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P008', N'Pin sạc dự phòng Polymer 20.000mAh Type C PD QC3.0 Xmobile PowerBox P69D Đen', N'Xmobile', N'Pin sac du phong', 1050000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P009', N'Pin sạc dự phòng Polymer 15.000mAh Type C PD QC3.0 Xmobile PowerBox P72D Xanh', N'Xmobile', N'Pin sac du phong', 900000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P010', N'Pin sạc dự phòng Polymer 10.000mAh Type C PD QC3.0 Xmobile PowerSlim PJ JP213', N'Xmobile', N'Pin sac du phong', 700000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P011', N'Pin sạc dự phòng Polymer 20.000mAh Type C PowerCore Essential PD Anker A1281 Fabric Đen', N'Anker', N'Pin sac du phong', 1400000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'P012', N'Pin sạc dự phòng 10.000mAh Anker PowerCore Select A1223 Đen', N'Anker', N'Pin sac du phong', 600000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC001', N'Adapter Sạc Type C PD 20W Xmobile TCE20W Trắng', N'Xmobile', N'Adapter', 300000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC002', N'Cáp HDMI 2.0 Tròn 2m Belkin F3Y02 Đen', N'Belkin', N'Cap sac', 250000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC003', N'Adapter sạc 12W Belkin WCA002 Trắng', N'Belkin', N'Adapter', 395000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC004', N'Cáp Type C 1m Belkin CAB002', N'Belkin', N'Cap sac', 385000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC005', N'Cáp Type C 1m Mbest DS462X', N'Mbest', N'Cap sac', 170000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC006', N'Cáp Type C - Lightning MFI 1m Mbest DS954', N'Lightning', N'Cap sac', 350000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC007', N'Adapter Sạc 2 cổng USB 2.4A Type C 3A Xmobile DS165X Trắng', N'Xmobile', N'Adapter', 290000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC008', N'Adapter Sạc 2 cổng Type C PD 18W QC 3.0 Xmobile DS714 Xanh Navy', N'Xmobile', N'Adapter', 450000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC009', N'Cáp Type C 1m AVA DS449-TB Xanh lá', N'AVA', N'Cap sac', 90000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC010', N'Cáp Lightning MFI 1m Mbest DS950-WB Đen', N'Lightning', N'Cap sac', 290000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC011', N'Cáp Micro 1m AVA DR-M01 Trắng', N'AVA', N'Cap sac', 70000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SC012', N'Adapter Sạc 5W cho iPhone/iPad/iPod Apple MGN13 Trắng', N'MGN', N'Adapter', 490000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SD001', N'Thẻ nhớ MicroSD 200 GB SanDisk Class 10', N'SanDisk', N'The nho', 2100000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SD002', N'Thẻ nhớ MicroSD 128 GB Class 10', N'SanDisk', N'The nho', 1000000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SD003', N'Thẻ nhớ MicroSD 64 GB Class 10', N'SanDisk', N'The nho', 550000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SD004', N'Thẻ nhớ MicroSD 16 GB Class 10', N'SanDisk', N'The nho', 220000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'SD005', N'Thẻ nhớ MicroSD 8 GB Class 4', N'SanDisk', N'The nho', 80000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN001', N'Tai nghe Bluetooth True Wireless Soundpeats Q Trắng', N'Soundpeats', N'Tai nghe', 1190000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN002', N'Tai nghe Bluetooth True Wireless Soundpeats Sonic Xám', N'Soundpeats', N'Tai nghe', 1390000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN003', N'Tai nghe Bluetooth True Wireless Belkin Soundform AUC001', N'Belkin', N'Tai nghe', 1790000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN004', N'Tai nghe Bluetooth True Wireless Mozard TS11 mini', N'Mozard', N'Tai nghe', 950000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN005', N'Tai nghe EP Gaming Asus Rog Cetra Core Đen', N'ASUS', N'Tai nghe', 1190000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN006', N'Tai nghe EP Gaming JBL Quantum 50', N'JBL', N'Tai nghe', 890000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN007', N'Tai nghe nhét tai EP JBL T110', N'JBL', N'Tai nghe', 390000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN008', N'Tai nghe EP JBL C150 Đen', N'JBL', N'Tai nghe', 250000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN009', N'Tai nghe chụp tai Mozard IP-878 Đen Rêu', N'Mozard', N'Tai nghe', 350000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN010', N'Tai nghe chụp tai JBL T500', N'JBL', N'Tai nghe', 890000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN011', N'Tai nghe chụp tai Sony Extra Bass MDR-XB550AP', N'Sony', N'Tai nghe', 1190000)
INSERT [dbo].[tblPhuKien] ([MaPK], [TenPK], [Hang], [Loai], [Gia]) VALUES (N'TN012', N'Tai nghe chụp tai Kanen IP-892', N'Kanen', N'Tai nghe', 350000)
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblDienThoai] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblDienThoai] ([MaSP])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblDienThoai]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblPhuKien] FOREIGN KEY([MaPK])
REFERENCES [dbo].[tblPhuKien] ([MaPK])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblPhuKien]
GO
