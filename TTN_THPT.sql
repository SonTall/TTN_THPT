create database ThucTapNhom_QuanLyTruongTHPT
go
USE [ThucTapNhom_QuanLyTruongTHPT]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 4/6/2018 9:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangDiem](
	[mahocsinh] [varchar](10) NOT NULL,
	[magiaovien] [varchar](10) NULL,
	[mamonhoc] [varchar](10) NOT NULL,
	[namhoc] [varchar](9) NOT NULL,
	[hocki] [int] NOT NULL,
	[diemtrungbinh] [float] NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC,
	[mamonhoc] ASC,
	[namhoc] ASC,
	[hocki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[machucvu] [varchar](10) NOT NULL,
	[tenchucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuyenLop]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChuyenLop](
	[mahocsinh] [varchar](10) NOT NULL,
	[ngaychuyen] [date] NOT NULL,
	[malopcu] [varchar](10) NOT NULL,
	[malopmoi] [varchar](10) NOT NULL,
	[lydochuyen] [varchar](100) NULL,
 CONSTRAINT [PK_ChuyenLop] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC,
	[ngaychuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiangDay]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiangDay](
	[magiaovien] [varchar](10) NOT NULL,
	[malop] [varchar](10) NOT NULL,
	[mamonhoc] [varchar](10) NULL,
	[thu] [nvarchar](50) NOT NULL,
	[tiet] [int] NOT NULL,
	[sotiet] [int] NULL,
 CONSTRAINT [PK_GiangDay] PRIMARY KEY CLUSTERED 
(
	[thu] ASC,
	[tiet] ASC,
	[malop] ASC,
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[magiaovien] [varchar](10) NOT NULL,
	[tengiaovien] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[quequan] [nvarchar](50) NOT NULL,
	[sdt] [varchar](12) NULL,
	[trinhdo] [nvarchar](50) NULL,
	[luongcoban] [money] NULL,
	[machucvu] [varchar](10) NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[mahocsinh] [varchar](10) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [date] NULL,
	[dantoc] [nvarchar](50) NULL,
	[tongiao] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[quequan] [nvarchar](50) NULL,
	[thongtinphuhuynh] [nvarchar](50) NOT NULL,
	[sdtlienhe] [varchar](12) NULL,
	[malop] [varchar](10) NOT NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[malop] [varchar](10) NOT NULL,
	[tenlop] [nvarchar](50) NOT NULL,
	[ngaybatdau] [date] NOT NULL,
	[ngayketthuc] [date] NOT NULL,
	[magvchunhiem] [varchar](10) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 4/6/2018 9:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[mamonhoc] [varchar](10) NOT NULL,
	[tenmonhoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[mamonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ChuyenLop] ADD  DEFAULT (getdate()) FOR [ngaychuyen]
GO
ALTER TABLE [dbo].[GiaoVien] ADD  CONSTRAINT [DF__GiaoVien__ngaysi__29572725]  DEFAULT (getdate()) FOR [ngaysinh]
GO
ALTER TABLE [dbo].[HocSinh] ADD  DEFAULT (getdate()) FOR [ngaysinh]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_GiaoVien_magiaovien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[GiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_GiaoVien_magiaovien]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocSinh_mahocsinh] FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[HocSinh] ([mahocsinh])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocSinh_mahocsinh]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc_mamonhoc] FOREIGN KEY([mamonhoc])
REFERENCES [dbo].[MonHoc] ([mamonhoc])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc_mamonhoc]
GO
ALTER TABLE [dbo].[ChuyenLop]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenLop_HocSinh_mahocsinh] FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[HocSinh] ([mahocsinh])
GO
ALTER TABLE [dbo].[ChuyenLop] CHECK CONSTRAINT [FK_ChuyenLop_HocSinh_mahocsinh]
GO
ALTER TABLE [dbo].[ChuyenLop]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenLop_Lopcu_malop] FOREIGN KEY([malopcu])
REFERENCES [dbo].[Lop] ([malop])
GO
ALTER TABLE [dbo].[ChuyenLop] CHECK CONSTRAINT [FK_ChuyenLop_Lopcu_malop]
GO
ALTER TABLE [dbo].[ChuyenLop]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenLop_Lopmoi_malop] FOREIGN KEY([malopcu])
REFERENCES [dbo].[Lop] ([malop])
GO
ALTER TABLE [dbo].[ChuyenLop] CHECK CONSTRAINT [FK_ChuyenLop_Lopmoi_malop]
GO
ALTER TABLE [dbo].[GiangDay]  WITH CHECK ADD  CONSTRAINT [FK_GiangDay_GiaoVien_magiaovien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[GiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[GiangDay] CHECK CONSTRAINT [FK_GiangDay_GiaoVien_magiaovien]
GO
ALTER TABLE [dbo].[GiangDay]  WITH CHECK ADD  CONSTRAINT [FK_GiangDay_Lop_malop] FOREIGN KEY([malop])
REFERENCES [dbo].[Lop] ([malop])
GO
ALTER TABLE [dbo].[GiangDay] CHECK CONSTRAINT [FK_GiangDay_Lop_malop]
GO
ALTER TABLE [dbo].[GiangDay]  WITH CHECK ADD  CONSTRAINT [FK_GiangDay_MonHoc] FOREIGN KEY([mamonhoc])
REFERENCES [dbo].[MonHoc] ([mamonhoc])
GO
ALTER TABLE [dbo].[GiangDay] CHECK CONSTRAINT [FK_GiangDay_MonHoc]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_ChucVu_machucvu] FOREIGN KEY([machucvu])
REFERENCES [dbo].[ChucVu] ([machucvu])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_ChucVu_machucvu]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop_malop] FOREIGN KEY([malop])
REFERENCES [dbo].[Lop] ([malop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop_malop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiaoVien_magiaovien] FOREIGN KEY([magvchunhiem])
REFERENCES [dbo].[GiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiaoVien_magiaovien]
GO
--sua mon hoc
CREATE PROC EDITMONHOC(@MAMONHOCU VARCHAR(10),@MAMONHOC VARCHAR(10),@TENMONHOC NVARCHAR(50))
AS
BEGIN 
    UPDATE MONHOC
	SET mamonhoc=@MAMONHOC,tenmonhoc=@TENMONHOC
	
	WHERE mamonhoc=@MAMONHOCU
END


--UPDATE GIANG DAY
CREATE PROC EDITGIANGDAY(@MAGVCU VARCHAR(10),@MAGIAOVIEN VARCHAR(10),@MAMONHOC VARCHAR(10),@MALOP VARCHAR(10),@THU NVARCHAR(20),@TIET INT, @SOTIET INT)
AS
BEGIN
	UPDATE GiangDay
	SET magiaovien=@MAGIAOVIEN, mamonhoc=@MAMONHOC,malop=@MALOP, thu=@THU, tiet=@TIET, sotiet=@SOTIET
	WHERE magiaovien=@MAGVCU
END


--UPDATE LOP
CREATE PROC EDITLOP(@MALOPCU VARCHAR(10),@MALOP VARCHAR(10),@TENLOP NVARCHAR(50),@NAMBATDAU INT,@NAMKETTHUC INT, @MAGVCHUNHIEM VARCHAR(10))
AS
BEGIN
	UPDATE Lop
	SET MALOP=@MALOP, tenlop=@TENLOP,nambatdau=@NAMBATDAU,namketthuc=@NAMKETTHUC, magvchunhiem=@MAGVCHUNHIEM
	
	WHERE MALOP=@MALOPCU
END

--UPDATE CHUYENLOP
CREATE PROC EDITCHUYENLOP(@MAHSCU VARCHAR(10),@MAHOCSINH VARCHAR(10),@NGAYCHUYEN DATE,@MALOPCU VARCHAR(10),@MALOPMOI VARCHAR(10),@LYDOCHUYEN NVARCHAR(100))
AS
BEGIN
	UPDATE ChuyenLop
	SET mahocsinh=@MAHOCSINH, ngaychuyen=@NGAYCHUYEN, malopcu=@MALOPCU, malopmoi=@MALOPMOI, lydochuyen=@LYDOCHUYEN
	
	WHERE mahocsinh=@MAHSCU
END

--UPDATE HOCSINH
ALTER PROC EDITHOCSINH(@MAHOCSINHCU VARCHAR(10),@MAHOCSINH VARCHAR(10),@HOTEN NVARCHAR(50),@GIOITINH NVARCHAR(20),@NGAYSINH DATETIME,@DANTOC NVARCHAR(50), @TONGIAO NVARCHAR(50),@DIACHI NVARCHAR(50),@QUEQUAN NVARCHAR(100),@THONGTINPHUHUYNH NVARCHAR(100),@SODTLIENHE VARCHAR(12),@MALOP VARCHAR(10))
AS
BEGIN
	UPDATE HOCSINH
	SET mahocsinh=@MAHOCSINH, hoten=@HOTEN,ngaysinh=@NGAYSINH,gioitinh=@GIOITINH,dantoc=@DANTOC,tongiao=@TONGIAO, diachi=@DIACHI,quequan=@QUEQUAN,thongtinphuhuynh=@THONGTINPHUHUYNH, sdtlienhe=@SODTLIENHE, malop=@MALOP
	
	WHERE mahocsinh=@MAHOCSINHCU
END

--UPDATE GIAOVIEN
CREATE PROC EDITGIAOVIEN(@MAGVCU VARCHAR(10),@MAGV VARCHAR(10),@TENGV NVARCHAR(50),@NGAYSINH DATE,@GIOITINH NVARCHAR(10),@DIACHI NVARCHAR(50),@QUEQUAN NVARCHAR(50),@SDT VARCHAR(12),@EMAIL NVARCHAR(50),@TRINHDO NVARCHAR(50),@LUONGCOBAN NVARCHAR(50),@MACHUCVU VARCHAR(10))
AS
BEGIN
	UPDATE GiaoVien
	SET magiaovien=@MAGV, tengiaovien=@TENGV, ngaysinh=@NGAYSINH, gioitinh=@GIOITINH,diachi=@DIACHI,quequan=@QUEQUAN,sdt=@SDT,EMAIL=@EMAIL,trinhdo=@TRINHDO,luongcoban=@LUONGCOBAN,machucvu=@MACHUCVU
	
	WHERE magiaovien=@MAGVCU
END
--UPDATE CHUC VU
CREATE PROC EDITCHUCVU(@MACHUCVUCU VARCHAR(10),@MACHUCVU VARCHAR(10),@TENCHUCVU NVARCHAR(50))
AS
BEGIN
	UPDATE ChucVu
	SET machucvu=@MACHUCVU,tenchucvu=@TENCHUCVU
	WHERE machucvu=@MACHUCVUCU
END
--UPDATE BANGDIEM
CREATE PROC EDITBANGDIEM(@MAHOCSINHCU VARCHAR(10),@MAHOCSINH VARCHAR(10),@MAGIAOVIEN VARCHAR(10),@MAMONHOC VARCHAR(10),@NAMHOC VARCHAR(10),@HOCKY INT,@DIEMTRUNGBINH VARCHAR(10))
AS
BEGIN
	UPDATE BangDiem
	SET mahocsinh=@MAHOCSINH,magiaovien=@MAGIAOVIEN,mamonhoc=@MAMONHOC,namhoc=@NAMHOC,hocki=@HOCKY,diemtrungbinh=@DIEMTRUNGBINH
	
	WHERE mahocsinh=@MAHOCSINHCU
END