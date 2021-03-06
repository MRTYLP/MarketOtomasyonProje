USE [master]
GO
/****** Object:  Database [deneme]    Script Date: 26.12.2021 12:40:56 ******/
CREATE DATABASE [deneme]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'deneme', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\deneme.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'deneme_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\deneme_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [deneme] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [deneme].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [deneme] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [deneme] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [deneme] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [deneme] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [deneme] SET ARITHABORT OFF 
GO
ALTER DATABASE [deneme] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [deneme] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [deneme] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [deneme] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [deneme] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [deneme] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [deneme] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [deneme] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [deneme] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [deneme] SET  DISABLE_BROKER 
GO
ALTER DATABASE [deneme] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [deneme] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [deneme] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [deneme] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [deneme] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [deneme] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [deneme] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [deneme] SET RECOVERY FULL 
GO
ALTER DATABASE [deneme] SET  MULTI_USER 
GO
ALTER DATABASE [deneme] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [deneme] SET DB_CHAINING OFF 
GO
ALTER DATABASE [deneme] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [deneme] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [deneme] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [deneme] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'deneme', N'ON'
GO
ALTER DATABASE [deneme] SET QUERY_STORE = OFF
GO
USE [deneme]
GO
/****** Object:  Table [dbo].[Tbl_Giderler]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Giderler](
	[AdSoyad] [varchar](30) NULL,
	[OdemeUcreti] [float] NULL,
	[IslemTarihi] [date] NULL,
	[OdemeTuru] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kullanicilar]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kullanicilar](
	[KullaniciAd] [varchar](15) NULL,
	[KullaniciSoyad] [varchar](15) NULL,
	[KullaniciTel] [varchar](15) NULL,
	[KullaniciTC] [varchar](11) NULL,
	[KullaniciSifre] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Personeller]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personeller](
	[PersonelAdSoyad] [varchar](30) NULL,
	[PersonelTel] [varchar](15) NULL,
	[PersonelAdres] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Satıslar]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Satıslar](
	[Tarih] [date] NULL,
	[AdSoyad] [varchar](40) NULL,
	[Adres] [varchar](100) NULL,
	[ÖdemeTürü] [varchar](20) NULL,
	[ÖdenenTutar] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sepetim]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sepetim](
	[ÜrünID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ÜrünAdı] [varchar](30) NULL,
	[ÜrünAdedi] [smallint] NULL,
	[KDV] [float] NULL,
	[Litre_KG] [float] NULL,
	[KDVsiz] [float] NULL,
	[KDVli] [float] NULL,
	[ToplamTutar] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Stok]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Stok](
	[UrunAdi] [varchar](20) NULL,
	[UrunKDV] [float] NULL,
	[UrunAlisFiyat] [float] NULL,
	[UrunMiktari] [smallint] NULL,
	[UrunBirimi] [varchar](15) NULL,
	[UrunGirisTarihi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Yoneticiler]    Script Date: 26.12.2021 12:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Yoneticiler](
	[YoneticiTC] [varchar](11) NULL,
	[YoneticiSifre] [varchar](11) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Tbl_Giderler] ([AdSoyad], [OdemeUcreti], [IslemTarihi], [OdemeTuru]) VALUES (N'MUSTAFA CANIK', 4500, CAST(N'2021-12-25' AS Date), N'MAAS')
GO
INSERT [dbo].[Tbl_Kullanicilar] ([KullaniciAd], [KullaniciSoyad], [KullaniciTel], [KullaniciTC], [KullaniciSifre]) VALUES (N'Halil', N'Yilmaz', N'5351234563', N'12345678910', N'1234')
INSERT [dbo].[Tbl_Kullanicilar] ([KullaniciAd], [KullaniciSoyad], [KullaniciTel], [KullaniciTC], [KullaniciSifre]) VALUES (N'YASIN', N'CANIVAR', N'(507) 005-28-50', N'21974751590', N'amsterdam')
INSERT [dbo].[Tbl_Kullanicilar] ([KullaniciAd], [KullaniciSoyad], [KullaniciTel], [KullaniciTC], [KullaniciSifre]) VALUES (N'AHMET', N'YILDIRI', N'(512) 234-45-55', N'44444444444', N'ahmet')
INSERT [dbo].[Tbl_Kullanicilar] ([KullaniciAd], [KullaniciSoyad], [KullaniciTel], [KullaniciTC], [KullaniciSifre]) VALUES (N'MERT UMUT ', N'YALPI', N'(531) 928-97-52', N'12345678910', N'mertumut01')
INSERT [dbo].[Tbl_Kullanicilar] ([KullaniciAd], [KullaniciSoyad], [KullaniciTel], [KullaniciTC], [KullaniciSifre]) VALUES (N'MAHMUT', N'GÜRSOY', N'(531) 252-45-45', N'74185296336', N'10101974')
GO
INSERT [dbo].[Tbl_Personeller] ([PersonelAdSoyad], [PersonelTel], [PersonelAdres]) VALUES (N'MERT UMUT YALPI', N'(531) 928-7451', N'Acarlar Mahallesi')
GO
INSERT [dbo].[Tbl_Stok] ([UrunAdi], [UrunKDV], [UrunAlisFiyat], [UrunMiktari], [UrunBirimi], [UrunGirisTarihi]) VALUES (N'JBL BT HOPARLÖR', 8, 1100, 1, N'ADET', CAST(N'2021-12-25' AS Date))
GO
INSERT [dbo].[Tbl_Yoneticiler] ([YoneticiTC], [YoneticiSifre]) VALUES (N'12345678910', N'1234')
GO
USE [master]
GO
ALTER DATABASE [deneme] SET  READ_WRITE 
GO
