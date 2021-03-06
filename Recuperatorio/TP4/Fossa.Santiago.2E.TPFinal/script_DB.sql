USE [master]
GO
/****** Object:  Database [TP4_FOSSA]    Script Date: 22/11/2021 3:58:15 ******/
CREATE DATABASE [TP4_FOSSA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_FOSSA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_FOSSA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_FOSSA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_FOSSA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_FOSSA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_FOSSA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_FOSSA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_FOSSA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_FOSSA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_FOSSA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_FOSSA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_FOSSA] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_FOSSA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_FOSSA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_FOSSA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_FOSSA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_FOSSA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_FOSSA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_FOSSA', N'ON'
GO
ALTER DATABASE [TP4_FOSSA] SET QUERY_STORE = OFF
GO
USE [TP4_FOSSA]
GO
/****** Object:  Table [dbo].[paises]    Script Date: 22/11/2021 3:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paises](
	[nombre] [varchar](50) NOT NULL,
	[continente] [varchar](50) NOT NULL,
	[poblaciontotal] [varchar](50) NOT NULL,
	[infectados] [varchar](50) NOT NULL,
	[fallecidos] [varchar](50) NOT NULL,
	[vacunados] [varchar](50) NOT NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ALBANIA', N'Europa', N'2873485', N'193269', N'2997', N'924194')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ALEMANIA', N'Europa', N'84149279', N'5009388', N'98159', N'56141195')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ARABIA SAUDITA', N'Asia', N'35552251', N'549192', N'8811', N'21976248')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ARGELIA', N'Africa', N'44935581', N'208104', N'5991', N'4897288')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ARGENTINA', N'Sudamerica', N'45761013', N'5304059', N'116222', N'27201986')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ARMENIA', N'Asia', N'2970842', N'329341', N'7055', N'252496')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'AUSTRALIA', N'Oceania', N'25905441', N'191623', N'1898', N'17872077')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'AUSTRIA', N'Europa', N'9076461', N'948100', N'11689', N'5733743')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'BANGLADESH', N'Asia', N'166925412', N'1572127', N'27912', N'32538709')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'BAREIN', N'Asia', N'1782405', N'277246', N'1393', N'1148496')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'BELGICA', N'Europa', N'11658399', N'1484712', N'26321', N'8613555')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'BOLIVIA', N'Sudamerica', N'11889925', N'522530', N'19004', N'3913343')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'BRASIL', N'Sudamerica', N'214619177', N'21940950', N'610935', N'126202217')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CANADA', N'Norteamerica', N'38193186', N'1746863', N'29322', N'28653150')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CATAR', N'Asia', N'2807805', N'241232', N'611', N'2218292')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CHILE', N'Sudamerica', N'19339859', N'1723728', N'37951', N'15712884')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CHINA', N'Asia', N'1439323776', N'98337', N'4636', N'1072454000')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'COLOMBIA', N'Sudamerica', N'51621938', N'5026822', N'127721', N'22626221')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'COREA DEL SUR', N'Asia', N'51329727', N'399591', N'3137', N'39997410')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'COSTA RICA', N'Centroamerica', N'5157517', N'564159', N'7197', N'2922621')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CROACIA', N'Europa', N'4070721', N'534601', N'9840', N'1851543')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'CUBA', N'Norteamerica', N'11317185', N'958390', N'8279', N'8138612')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'DINAMARCA', N'Europa', N'5820184', N'426992', N'2772', N'4425979')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ECUADOR', N'Sudamerica', N'18007931', N'519560', N'32989', N'10344290')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'EGIPTO', N'Africa', N'104977713', N'344907', N'19567', N'11811236')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'EL SALVADOR', N'Centroamerica', N'6531096', N'118041', N'3731', N'3978938')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'EMIRATOS ARABES UNIDOS', N'Asia', N'10053214', N'740879', N'2143', N'8812470')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ESLOVENIA', N'Europa', N'2079330', N'379964', N'4953', N'1131251')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ESPAÑA', N'Europa', N'46779479', N'5047156', N'87673', N'37448743')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ESTADOS UNIDOS', N'Norteamerica', N'333659530', N'46949943', N'761354', N'193487135')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ESTONIA', N'Europa', N'1327759', N'212607', N'1690', N'774979')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ETIOPIA', N'Africa', N'118860393', N'368979', N'6630', N'1393504')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'FILIPINAS', N'Asia', N'111567946', N'2815080', N'45272', N'36907827')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'FRACIA', N'Europa', N'65470493', N'7275149', N'118137', N'46312482')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'GHANA', N'Africa', N'31960982', N'130710', N'1207', N'835989')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'GRECIA', N'Europa', N'10353586', N'828032', N'16686', N'6464346')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'GUATEMALA', N'Centroamerica', N'18366732', N'609136', N'15675', N'3577564')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'HONDURAS', N'Centroamerica', N'10120427', N'376967', N'10353', N'3622891')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'HUNGRIA', N'Europa', N'9626886', N'939784', N'31867', N'5768941')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'INDIA', N'Asia', N'1398494658', N'34426036', N'463245', N'367698745')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'INDONESIA', N'Asia', N'277465027', N'4250516', N'143644', N'83418086')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'IRAK', N'Asia', N'41450591', N'2068388', N'23483', N'3570258')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'IRAN', N'Asia', N'85457576', N'6031575', N'128042', N'42183468')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'IRLANDA', N'Europa', N'5013395', N'503018', N'5566', N'3763443')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ISRAEL', N'Asia', N'9326000', N'1336860', N'8140', N'5752941')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'ITALIA', N'Europa', N'60340543', N'4852496', N'132739', N'43772698')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'JAPON', N'Asia', N'125948224', N'1725121', N'18323', N'94589255')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'JORDANIA', N'Asia', N'10341147', N'889671', N'11215', N'3607396')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'KAZAJISTAN', N'Asia', N'19082716', N'955366', N'12402', N'7800190')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'KENIA', N'Africa', N'55392697', N'254309', N'5319', N'2110357')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'KUWAIT', N'Asia', N'4357111', N'413034', N'2462', N'923307')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'LIBIA', N'Africa', N'6999340', N'365237', N'5307', N'508805')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'LITUANIA', N'Europa', N'2670127', N'44181', N'6344', N'1749009')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'MALASIA', N'Asia', N'32930947', N'2541147', N'29631', N'24778711')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'MARRUECOS', N'Africa', N'37506650', N'948157', N'14740', N'22253789')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'MEXICO', N'Norteamerica', N'130778720', N'3841661', N'290872', N'62881897')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'MOLDAVIA', N'Europa', N'4021096', N'353778', N'8549', N'901961')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'MONGOLIA', N'Asia', N'3350616', N'373344', N'1888', N'2144617')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'NEPAL', N'Asia', N'29850284', N'816675', N'11471', N'7436714')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'NIGERIA', N'Africa', N'213131110', N'213177', N'2968', N'3152648')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'NORUEGA', N'Europa', N'5479371', N'229309', N'951', N'3772054')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'NUEVA ZELANDA', N'Oceania', N'5002100', N'9088', N'35', N'3413839')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'OMAN', N'Asia', N'5284334', N'304437', N'4113', N'2733021')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PAISES BAJOS', N'Europa', N'17186578', N'2283083', N'18728', N'12571545')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PAKISTAN', N'Asia', N'226730682', N'1279373', N'28595', N'47804912')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PALESTINA', N'Asia', N'5263727', N'427034', N'4493', N'1292573')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PANAMA', N'Centroamerica', N'4407824', N'474621', N'7343', N'2396181')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PARAGUAY', N'Sudamerica', N'7252624', N'462003', N'16340', N'2508250')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PERU', N'Sudamerica', N'33597500', N'2212514', N'200573', N'16312821')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'POLONIA', N'Europa', N'37790066', N'3190067', N'78821', N'20134376')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'PORTUGAL', N'Europa', N'10156147', N'1106005', N'18242', N'8902861')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'REINO UNIDO', N'Europa', N'68372226', N'9524971', N'142835', N'45985795')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'REPUBLICA CHECA', N'Europa', N'10736077', N'1881206', N'31431', N'6184098')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'REPUBLICA DOMINICANA', N'Centroamerica', N'10997050', N'397016', N'4170', N'5465964')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'RUMANIA', N'Europa', N'19062567', N'1739283', N'52836', N'5919840')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'RUSIA', N'Europa', N'146019815', N'9031851', N'254167', N'50991092')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SENEGAL', N'Africa', N'17347601', N'73958', N'1881', N'879073')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SERBIA', N'Europa', N'8689352', N'1208386', N'10781', N'3033202')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SINGAPUR', N'Asia', N'5913436', N'239272', N'594', N'4703751')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SUDAFRICA', N'Africa', N'60327438', N'2925677', N'89476', N'13324316')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SUECIA', N'Europa', N'10185118', N'1182471', N'15051', N'6964838')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'SUIZA', N'Europa', N'8740900', N'909034', N'11339', N'5609979')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'TAILANDIA', N'Asia', N'70038839', N'2011331', N'19987', N'35800674')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'TURQUIA', N'Asia', N'85575739', N'8386542', N'73342', N'49594716')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'UCRANIA', N'Europa', N'43375232', N'3203149', N'76302', N'8686625')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'UGANDA', N'Africa', N'47715961', N'126965', N'3239', N'415486')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'URUGUAY', N'Sudamerica', N'3490245', N'396677', N'6102', N'2634383')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'VENEZUELA', N'Sudamerica', N'28325361', N'419745', N'5026', N'9271857')
INSERT [dbo].[paises] ([nombre], [continente], [poblaciontotal], [infectados], [fallecidos], [vacunados]) VALUES (N'VIETNAM', N'Asia', N'98532263', N'1018346', N'23018', N'33758048')
GO
USE [master]
GO
ALTER DATABASE [TP4_FOSSA] SET  READ_WRITE 
GO
