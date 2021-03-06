USE [master]
GO
/****** Object:  Database [HMS]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE DATABASE [HMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HMS.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HMS_log.ldf' , SIZE = 1792KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HMS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [HMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HMS] SET RECOVERY FULL 
GO
ALTER DATABASE [HMS] SET  MULTI_USER 
GO
ALTER DATABASE [HMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HMS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HMS', N'ON'
GO
USE [HMS]
GO
/****** Object:  User [AuthoritySystem]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE USER [AuthoritySystem] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_datareader] ADD MEMBER [AuthoritySystem]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [AuthoritySystem]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[Detail] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[IsLocked] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoctorInfo]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorInfo](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[IsAvailable] [bit] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[SpecializationId] [int] NULL,
 CONSTRAINT [PK_dbo.Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gynae_PhysicalExamination]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gynae_PhysicalExamination](
	[GynaePhysicalExamId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[Weight] [decimal](4, 0) NULL,
	[Height] [decimal](4, 0) NULL,
	[Temperature] [decimal](4, 0) NULL,
	[Pulse] [decimal](4, 0) NULL,
	[BP] [decimal](4, 0) NULL,
	[Thyroid] [nvarchar](50) NULL,
	[Size] [nvarchar](50) NULL,
	[HeartMurmur] [bit] NULL,
	[HeartRate] [nvarchar](50) NULL,
	[HeartRythm] [nvarchar](50) NULL,
	[Abdomen] [nvarchar](50) NULL,
	[AbdomenBowelSound] [bit] NULL,
	[VaginalExamination] [nvarchar](100) NULL,
	[BreastLeftNormal] [bit] NULL,
	[BreastLeftAbnormal] [bit] NULL,
	[BreastLeftMass] [bit] NULL,
	[BreastLeftErythema] [bit] NULL,
	[BreastLeftTender] [bit] NULL,
	[BreastLeftDischargeMilk] [bit] NULL,
	[BreastLeftPus] [bit] NULL,
	[BreastLeftOther] [bit] NULL,
	[BreastRightNormal] [bit] NULL,
	[BreastRightAbnormal] [bit] NULL,
	[BreastRightMass] [bit] NULL,
	[BreastRightErythema] [bit] NULL,
	[BreastRightTender] [bit] NULL,
	[BreastRightDischargeMilk] [bit] NULL,
	[BreastRightPus] [bit] NULL,
	[BreastRightOther] [bit] NULL,
	[SpeculumExam] [nvarchar](50) NULL,
	[CarvixAppearance] [nvarchar](50) NULL,
	[MotionTenderness] [nvarchar](50) NULL,
	[Uterus] [nvarchar](50) NULL,
	[UterusNl] [nvarchar](50) NULL,
	[AdnexaLeft] [nvarchar](50) NULL,
	[AdnexaRight] [nvarchar](50) NULL,
	[AdnexaDescription] [nvarchar](max) NULL,
	[lungscondition] [nvarchar](50) NULL,
	[LungLeftWheezes] [bit] NULL,
	[LungLeftRhonchi] [bit] NULL,
	[LungLeftRales] [bit] NULL,
	[LungLeftPoorAirEntry] [bit] NULL,
	[LungLeftOther] [bit] NULL,
	[LungRightWheezes] [bit] NULL,
	[LungRightRhonchi] [bit] NULL,
	[LungRightRales] [bit] NULL,
	[LungRightPoorAirEntry] [bit] NULL,
	[LungRightOther] [bit] NULL,
 CONSTRAINT [PK_GynaePhysicalExamination] PRIMARY KEY CLUSTERED 
(
	[GynaePhysicalExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GynaeForm]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GynaeForm](
	[GynaeFormId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[LastMenstrualDate] [date] NULL,
	[History] [nvarchar](max) NULL,
	[LastMenstrualBegin] [date] NULL,
	[LastMenstrualEnd] [date] NULL,
	[NumberOfDaysBleeding] [bit] NULL,
	[Dayss] [int] NULL,
	[BleedingCondition] [bit] NULL,
	[Pain] [bit] NULL,
	[PainNotes] [nvarchar](max) NULL,
	[CycleHistory] [nvarchar](max) NULL,
	[Para] [nvarchar](50) NULL,
	[Gravida] [nvarchar](50) NULL,
	[Abortions] [int] NULL,
	[LastBabyBorn] [nvarchar](50) NULL,
	[Infertility] [bit] NULL,
	[MarriedYears] [decimal](4, 0) NULL,
	[Husband] [nvarchar](max) NULL,
	[HistoryAndTestsWife] [nvarchar](max) NULL,
	[OtherMedicalHistory] [nvarchar](max) NULL,
	[CurrentMedication] [nvarchar](max) NULL,
	[ComplaintPain] [bit] NULL,
	[ComplaintBleeding] [bit] NULL,
	[ComplaintDischarge] [bit] NULL,
	[ComplaintUrineBurning] [bit] NULL,
	[ComplaintSeizures] [bit] NULL,
	[ComplaintFits] [bit] NULL,
 CONSTRAINT [PK_GynaeGeneral] PRIMARY KEY CLUSTERED 
(
	[GynaeFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paeds_PhysicalExamination]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paeds_PhysicalExamination](
	[PaedsExamId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[DOB] [date] NULL,
	[Temperature] [decimal](4, 0) NULL,
	[BP] [decimal](4, 0) NULL,
	[Pulse] [decimal](4, 0) NULL,
	[Weight] [decimal](4, 0) NULL,
	[WeightPercentile] [nvarchar](50) NULL,
	[Height] [decimal](4, 0) NULL,
	[HeightPercentile] [nvarchar](50) NULL,
	[HC] [nvarchar](50) NULL,
	[HCPercentile] [nvarchar](50) NULL,
	[Oxygen] [nvarchar](50) NULL,
	[RR] [nvarchar](50) NULL,
	[Alert] [bit] NULL,
	[ListLess] [bit] NULL,
	[Jaundice] [bit] NULL,
	[Active] [bit] NULL,
	[Agitated] [bit] NULL,
	[Pale] [bit] NULL,
	[Smiling] [bit] NULL,
	[Convulsions] [bit] NULL,
	[Crying] [bit] NULL,
	[NonResponse] [bit] NULL,
	[Lethargic] [bit] NULL,
	[ColorPink] [bit] NULL,
	[Other] [bit] NULL,
	[Head] [nvarchar](50) NULL,
	[AntFontAnelle] [nvarchar](50) NULL,
	[PostFontAnelle] [nvarchar](50) NULL,
	[Sutures] [nvarchar](50) NULL,
	[Cephalohematoma] [bit] NULL,
	[HeadOther] [nvarchar](150) NULL,
	[EyePupils] [nvarchar](50) NULL,
	[EyeSclera] [nvarchar](50) NULL,
	[EyeConjuctiva] [nvarchar](50) NULL,
	[EyeDischargeLeft] [nvarchar](50) NULL,
	[EyeDischargeRight] [nvarchar](50) NULL,
	[EyeRedReflex] [bit] NULL,
	[EyeOther] [nvarchar](150) NULL,
	[EarPennaeLeft] [nvarchar](50) NULL,
	[EarPennaeRight] [nvarchar](50) NULL,
	[EarPennaeNotes] [nvarchar](50) NULL,
	[EarCanalLeft] [nvarchar](50) NULL,
	[EarCanalRight] [nvarchar](50) NULL,
	[EarDischarge] [nvarchar](50) NULL,
	[EarOther] [nvarchar](150) NULL,
	[Mouth] [nvarchar](50) NULL,
	[MouthGums] [nvarchar](50) NULL,
	[MouthTeeth] [nvarchar](50) NULL,
	[MouthOther] [nvarchar](50) NULL,
	[Throat] [nvarchar](50) NULL,
	[Tonsils] [nvarchar](50) NULL,
	[ThroatOther] [nvarchar](50) NULL,
	[Nose] [nvarchar](50) NULL,
	[NoseDischarge] [nvarchar](50) NULL,
	[Neck] [nvarchar](50) NULL,
	[SwollenLymphNode] [nvarchar](50) NULL,
	[NeckLeft] [nvarchar](50) NULL,
	[NeckRight] [nvarchar](50) NULL,
	[NeckOther] [nvarchar](150) NULL,
	[TMLeftNormal] [bit] NULL,
	[TMLeftWhite] [bit] NULL,
	[TMLeftRed] [bit] NOT NULL,
	[TMLeftYellow] [bit] NULL,
	[TMLeftBulging] [bit] NULL,
	[TMLeftMobile] [bit] NULL,
	[TMLeftNonMobile] [bit] NULL,
	[TMLeftRaptured] [bit] NULL,
	[TMLeftOther] [nvarchar](50) NULL,
	[TMRightNormal] [bit] NULL,
	[TMRightWhite] [bit] NULL,
	[TMRightRed] [bit] NULL,
	[TMRightYellow] [bit] NULL,
	[TMRightBulging] [bit] NULL,
	[TMRightMobile] [bit] NULL,
	[TMRightNonMobile] [bit] NULL,
	[TMRightRaptured] [bit] NULL,
	[TMDischarge] [nvarchar](50) NULL,
	[TMRightOther] [nvarchar](150) NULL,
	[LungsRespiration] [nvarchar](50) NULL,
	[LungLeftWheezes] [bit] NULL,
	[LungLeftRhonchi] [bit] NULL,
	[LungLeftRales] [bit] NULL,
	[LungLeftPoorAirEntry] [bit] NULL,
	[LungLeftDiminshed] [bit] NULL,
	[LungRightWheezes] [bit] NULL,
	[LungRightRhonchi] [bit] NULL,
	[LungRightRales] [bit] NULL,
	[LungRightPoorAirEntry] [bit] NULL,
	[LungRightDiminished] [bit] NULL,
	[LungOther] [nvarchar](max) NULL,
	[HeartMurmur] [bit] NULL,
	[MurmurRate] [nvarchar](50) NULL,
	[HeartRate] [nvarchar](50) NULL,
	[HeartRythm] [nvarchar](50) NULL,
	[HeartOther] [nvarchar](250) NULL,
	[AbdAbdomen] [nvarchar](50) NULL,
	[AbdTender] [nvarchar](50) NULL,
	[AbdMassQuality] [nvarchar](50) NULL,
	[AbdRebound] [bit] NULL,
	[AbdUmbilicalHernia] [nvarchar](50) NULL,
	[AbdInguinalHernialLeft] [nvarchar](50) NULL,
	[AbdInguinalHernialRight] [nvarchar](50) NULL,
	[UmbClean] [nvarchar](50) NULL,
	[UmdDishcharge] [nvarchar](50) NULL,
	[UmbOther] [nvarchar](150) NULL,
	[GentMale] [nvarchar](50) NULL,
	[GentHydrocele] [bit] NULL,
	[GentUndescendedLeft] [bit] NULL,
	[GentUndescendedRight] [bit] NULL,
	[GentHerniaLeft] [nvarchar](50) NULL,
	[GentHerniaRight] [nvarchar](50) NULL,
	[GentPenis] [nvarchar](50) NULL,
	[GentMicro] [bit] NULL,
	[GentMeatus] [nvarchar](50) NULL,
	[GentDishcharge] [nvarchar](50) NULL,
	[GentMaleOther] [nvarchar](150) NULL,
	[GentFemale] [nvarchar](50) NULL,
	[GentLabia] [nvarchar](50) NULL,
	[GentUrethra] [nvarchar](50) NULL,
	[GentDischarge] [nvarchar](50) NULL,
	[GentMassLeft] [nvarchar](50) NULL,
	[GentMassRight] [nvarchar](50) NULL,
	[GentSize] [decimal](18, 0) NULL,
	[GentOtherFemale] [nvarchar](150) NULL,
	[MuscArmsLegs] [nvarchar](50) NULL,
	[MuscLeftWeekness] [bit] NULL,
	[MuscLeftSwelling] [bit] NULL,
	[MuscLeftToneIncDec] [bit] NULL,
	[MuscLeftTender] [bit] NULL,
	[MuscLeftImmobile] [bit] NULL,
	[MuscLeftDecStrength] [bit] NULL,
	[MuscRightWeekness] [bit] NULL,
	[MuscRightSwelling] [bit] NULL,
	[MuscRightToneIncDec] [bit] NULL,
	[MuscRightTender] [bit] NULL,
	[MuscRightImmobile] [bit] NULL,
	[MuscRightDecStrength] [bit] NULL,
	[MuscLaceration] [bit] NULL,
	[MuscBruise] [bit] NULL,
	[MuscOther] [nvarchar](150) NULL,
	[FeetHandSymmetry] [nvarchar](50) NULL,
	[FeetHandLeftWeekness] [bit] NULL,
	[FeetHandLeftSwelling] [bit] NULL,
	[FeetHandLeftTender] [bit] NULL,
	[FeetHandLeftImmobile] [bit] NULL,
	[FeetHandLeftDecStrength] [bit] NULL,
	[FeetHandLeftLaceration] [bit] NULL,
	[FeetHandLeftBruise] [bit] NULL,
	[FeetHandRightWeekness] [bit] NULL,
	[FeetHandRightSwelling] [bit] NULL,
	[FeetHandRightTender] [bit] NULL,
	[FeetHandRightImmobile] [bit] NULL,
	[FeetHandRightDecStrength] [bit] NULL,
	[FeetHandRightLaceration] [bit] NULL,
	[FeetHandRightBruise] [bit] NULL,
	[FeetHandAbleToWalk] [bit] NULL,
	[FeetToes] [nvarchar](50) NULL,
	[FeetOther] [nvarchar](150) NULL,
	[NeuroAwake] [bit] NULL,
	[NeuroAlert] [bit] NULL,
	[NeuroActive] [bit] NULL,
	[NeuroDecConsciousness] [bit] NULL,
	[NeuroAgitated] [bit] NULL,
	[NeuroConvelsions] [bit] NULL,
	[NeuroListLess] [bit] NULL,
	[NeuroLethargic] [bit] NULL,
	[NeuroAQAppropriately] [bit] NULL,
	[NeuroReflexLeft] [nvarchar](50) NULL,
	[NeuroReflexRight] [nvarchar](50) NULL,
	[NeuroDevelopment] [nvarchar](50) NULL,
	[NeuroMotor] [bit] NULL,
	[NeuroLanguage] [bit] NULL,
	[NeuroSocial] [bit] NULL,
	[NeuroOther] [nvarchar](max) NULL,
	[Skin] [nvarchar](50) NULL,
	[RashFlate] [bit] NULL,
	[RashRaised] [bit] NULL,
	[RashErythema] [bit] NULL,
	[RashMacules] [bit] NULL,
	[RashPapules] [bit] NULL,
	[RashPetechiae] [bit] NULL,
	[RashSize] [decimal](18, 0) NULL,
	[RashOther] [nvarchar](150) NULL,
 CONSTRAINT [PK_PaedsPhysicalExamination] PRIMARY KEY CLUSTERED 
(
	[PaedsExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaedsForm]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaedsForm](
	[PaedsFormId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[ChiefComplaint] [nvarchar](max) NULL,
	[IllnessHistory] [nvarchar](max) NULL,
	[CurrentMedication] [nvarchar](max) NULL,
	[BCG] [bit] NULL,
	[PolioDate1] [date] NULL,
	[PolioDate2] [date] NULL,
	[PolioDate3] [date] NULL,
	[PolioDate4] [date] NULL,
	[DPTDate1] [date] NULL,
	[DPTDate2] [date] NULL,
	[DPTDate3] [date] NULL,
	[DPTDate4] [date] NULL,
	[HepBDate1] [date] NULL,
	[HepBDate2] [date] NULL,
	[HepBDate3] [date] NULL,
	[HepADate1] [date] NULL,
	[HepADate2] [date] NULL,
	[HepADate3] [date] NULL,
	[Other] [nvarchar](max) NULL,
	[OtherDate] [date] NULL,
 CONSTRAINT [PK_PaedsGeneral] PRIMARY KEY CLUSTERED 
(
	[PaedsFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PatientInfo]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientInfo](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[MrNumber] [bigint] NOT NULL,
	[PatientName] [nvarchar](200) NOT NULL,
	[DOB] [date] NULL,
	[PatientAge] [nvarchar](50) NULL,
	[GuardianRelation] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](15) NULL,
	[CNIC] [nvarchar](15) NULL,
	[Address] [nvarchar](200) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_MrNumber] UNIQUE NONCLUSTERED 
(
	[MrNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostNatal_Infant]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostNatal_Infant](
	[PostNatalInfantId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[InfantDOB] [date] NULL,
	[InfantAge] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[DeliveryCondition] [nvarchar](50) NULL,
	[DeliveryTerm] [nvarchar](50) NULL,
	[DeliveryHospital] [bit] NULL,
	[DeliveryMaternityHome] [bit] NULL,
	[DeliveryHome] [bit] NULL,
	[Alert] [bit] NULL,
	[Listless] [bit] NULL,
	[Jaundice] [bit] NULL,
	[Active] [bit] NULL,
	[Agitated] [bit] NULL,
	[Pale] [bit] NULL,
	[Smiling] [bit] NULL,
	[Convulsions] [bit] NULL,
	[Crying] [bit] NULL,
	[NonResponse] [bit] NULL,
	[Lethargic] [bit] NULL,
	[ColorPink] [bit] NULL,
	[Other] [bit] NULL,
	[InfantCondition] [nvarchar](50) NULL,
	[BreastFeeding] [bit] NULL,
	[FeedingCondition] [nvarchar](50) NULL,
	[Temperature] [decimal](4, 0) NULL,
	[Weight] [decimal](4, 0) NULL,
	[WeightPercentile] [nvarchar](50) NULL,
	[BirthWieght] [decimal](4, 0) NULL,
	[BirthWieghtPercentile] [nvarchar](50) NULL,
	[Length] [nvarchar](50) NULL,
	[LengthPercentile] [nvarchar](50) NULL,
	[HC] [nvarchar](50) NULL,
	[HCPercentile] [nvarchar](50) NULL,
	[Head] [nvarchar](50) NULL,
	[AntFontAnelle] [nvarchar](50) NULL,
	[PostFontAnelle] [nvarchar](50) NULL,
	[Sutures] [nvarchar](50) NULL,
	[CephalohematomaLeft] [bit] NULL,
	[CephalohematomaRight] [bit] NULL,
	[HeadOther] [nvarchar](150) NULL,
	[EyePupils] [nvarchar](50) NULL,
	[EyeSclera] [nvarchar](50) NULL,
	[EyeConjuctiva] [nvarchar](50) NULL,
	[EyeDischargeLeft] [nvarchar](50) NULL,
	[EyeDischargeRight] [nvarchar](50) NULL,
	[EyeRedReflexLeft] [bit] NULL,
	[EyeRedReflexRight] [bit] NULL,
	[EarPennaeLeft] [nvarchar](50) NULL,
	[EarPennaeRight] [nvarchar](50) NULL,
	[EarCanalLeft] [nvarchar](50) NULL,
	[EarCanalRight] [nvarchar](50) NULL,
	[EarDischarge] [nvarchar](50) NULL,
	[EarPennaeNotes] [nvarchar](50) NULL,
	[EarOther] [nvarchar](150) NULL,
	[TMLeftNormal] [bit] NULL,
	[TMLeftWhite] [bit] NULL,
	[TMLeftRed] [bit] NULL,
	[TMLeftRellow] [bit] NULL,
	[TMLeftBulging] [bit] NULL,
	[TMLeftMobile] [bit] NULL,
	[TMLeftNonMobile] [bit] NULL,
	[TMLeftRaptured] [bit] NULL,
	[TMRightNormal] [bit] NULL,
	[TMRightWhite] [bit] NULL,
	[TMRightRed] [bit] NULL,
	[TMRightYellow] [bit] NULL,
	[TMRightBulging] [bit] NULL,
	[TMRightMobile] [bit] NULL,
	[TMRightNonMobile] [bit] NULL,
	[TMRightRuptured] [bit] NULL,
	[TMDischarge] [nvarchar](50) NULL,
	[TMOther] [nvarchar](50) NULL,
	[Nose] [nvarchar](50) NULL,
	[NoseDischarge] [nvarchar](50) NULL,
	[NoseOther] [nvarchar](150) NULL,
	[Mouth] [nvarchar](50) NULL,
	[MouthGums] [nvarchar](50) NULL,
	[MouthOther] [nvarchar](150) NULL,
	[Suck] [nvarchar](50) NULL,
	[Throat] [nvarchar](50) NULL,
	[ThroatOther] [nvarchar](150) NULL,
	[Neck] [nvarchar](50) NULL,
	[SwollenLymphNode] [nvarchar](50) NULL,
	[NeckLeft] [nvarchar](50) NULL,
	[NeckRight] [nvarchar](50) NULL,
	[NeckOther] [nvarchar](50) NULL,
	[LungRespiration] [nvarchar](50) NULL,
	[LungRetratcions] [bit] NULL,
	[LungWheezes] [bit] NULL,
	[LungBreathSound] [bit] NULL,
	[LungDimishedLeft] [bit] NULL,
	[LungDimishedRight] [bit] NULL,
	[LungRhonchi] [bit] NULL,
	[LungRales] [bit] NULL,
	[LungIncRespRate] [bit] NULL,
	[LungOhter] [nvarchar](150) NULL,
	[HeartRate] [nvarchar](50) NULL,
	[HeartMurmur] [nvarchar](50) NULL,
	[HeartIncreasedRate] [bit] NULL,
	[HeartDecreasedRate] [bit] NULL,
	[HeartIrregularRhythm] [bit] NULL,
	[HeartRub] [bit] NULL,
	[HeartPedal] [nvarchar](50) NULL,
	[HeartOther] [nvarchar](150) NULL,
	[AbdAbdomen] [nvarchar](50) NULL,
	[AbdTender] [nvarchar](50) NULL,
	[AbdMass] [nvarchar](50) NULL,
	[AbdSize] [decimal](18, 0) NULL,
	[AbdMassQuality] [nvarchar](50) NULL,
	[AbdHernia] [nvarchar](50) NULL,
	[UmbClean] [nvarchar](50) NULL,
	[UmbDischarge] [nvarchar](50) NULL,
	[UmbErythema] [bit] NULL,
	[UmbInduration] [bit] NULL,
	[UmbWarmtoTouch] [bit] NULL,
	[UmbHernia] [nvarchar](50) NULL,
	[UmbOther] [nvarchar](150) NULL,
	[GentTesties] [nvarchar](50) NULL,
	[GentHydrocele] [bit] NULL,
	[GentUndescededLeft] [bit] NULL,
	[GentUndescededRight] [bit] NULL,
	[GentHernia] [nvarchar](50) NULL,
	[GentPenis] [nvarchar](50) NULL,
	[GentMeatus] [nvarchar](50) NULL,
	[GentDischargeMale] [nvarchar](50) NULL,
	[GentOtherMale] [nvarchar](150) NULL,
	[GentNormal] [nvarchar](50) NULL,
	[GentLabia] [nvarchar](50) NULL,
	[GentUrethra] [nvarchar](50) NULL,
	[GentDishargeFemale] [nvarchar](50) NULL,
	[GentMass] [nvarchar](50) NULL,
	[GentSize] [decimal](18, 0) NULL,
	[GentOtherFemale] [nvarchar](150) NULL,
	[MuscArms] [nvarchar](50) NULL,
	[MuscWeekness] [nvarchar](50) NULL,
	[MuscSwelling] [nvarchar](50) NULL,
	[MuscTender] [nvarchar](50) NULL,
	[MuscImmobile] [nvarchar](50) NULL,
	[MuscDecStrength] [nvarchar](50) NULL,
	[MuscOther] [nvarchar](150) NULL,
	[HandSymmetry] [nvarchar](50) NULL,
	[HandWeekness] [nvarchar](50) NULL,
	[HandSwelling] [nvarchar](50) NULL,
	[HandTender] [nvarchar](50) NULL,
	[HandImmobile] [nvarchar](50) NULL,
	[HandDecStrength] [nvarchar](50) NULL,
	[HandFingers] [nvarchar](50) NULL,
	[HandBruise] [nvarchar](50) NULL,
	[HandExtraDigits] [bit] NULL,
	[HandSyndactyly] [bit] NULL,
	[HandOther] [nvarchar](150) NULL,
	[LegSymmetry] [nvarchar](50) NULL,
	[LegWeekness] [nvarchar](50) NULL,
	[LegFlacid] [nvarchar](50) NULL,
	[LegNomalTone] [nvarchar](50) NULL,
	[LegSwelling] [nvarchar](50) NULL,
	[LegTender] [nvarchar](50) NULL,
	[LegImmobile] [nvarchar](50) NULL,
	[LegDecStrength] [nvarchar](50) NULL,
	[LegOther] [nvarchar](50) NULL,
	[FeetSymmetry] [nvarchar](50) NULL,
	[FeetWeekness] [nvarchar](50) NULL,
	[FeetSwelling] [nvarchar](50) NULL,
	[FeetTender] [nvarchar](50) NULL,
	[FeetImmobile] [nvarchar](50) NULL,
	[FeetDecStrength] [nvarchar](50) NULL,
	[FeetClubFoot] [nvarchar](50) NULL,
	[FeetToes] [nvarchar](50) NULL,
	[FeetExtraDigits] [bit] NULL,
	[FeetSyndactyly] [bit] NULL,
	[FeetOther] [nvarchar](150) NULL,
	[HipSymmetry] [nvarchar](50) NULL,
	[HipLeft] [nvarchar](50) NULL,
	[HipRight] [nvarchar](50) NULL,
	[NeuroAwake] [bit] NULL,
	[NeuroAlert] [bit] NULL,
	[NeuroActive] [bit] NULL,
	[NeuroDecConsciousness] [bit] NULL,
	[NeuroAgitated] [bit] NULL,
	[NeuroConvelsions] [bit] NULL,
	[NeuroListLess] [bit] NULL,
	[NeuroLethargic] [bit] NULL,
	[NeuroFlaccid] [bit] NULL,
	[ReflexMoro] [bit] NULL,
	[ReflexGrasp] [bit] NULL,
	[ReflexRooting] [bit] NULL,
	[ReflexGalant] [bit] NULL,
	[ReflexStepping] [bit] NULL,
	[ReflexOther] [nvarchar](150) NULL,
	[SkinNormal] [nvarchar](50) NULL,
	[Rashflat] [bit] NULL,
	[RashRaised] [bit] NULL,
	[RashErythema] [bit] NULL,
	[RashMacules] [bit] NULL,
	[RashPapules] [bit] NULL,
	[RashPetechie] [bit] NULL,
	[RashSize] [decimal](18, 0) NULL,
	[RashOther] [nvarchar](150) NULL,
	[BfSuck] [bit] NULL,
	[BfLatchingOn] [bit] NULL,
	[BfSpitting] [bit] NULL,
	[BfVomiting] [bit] NULL,
	[BfNasalObstruction] [bit] NULL,
	[BfOther] [nvarchar](150) NULL,
	[DsFever] [bit] NULL,
	[DsPoorFeeding] [bit] NULL,
	[DsCrying] [bit] NULL,
	[DsLethargy] [bit] NULL,
	[DsHardToWakeup] [bit] NULL,
	[DsNoUrination] [bit] NULL,
	[DsNoBowelMovement] [bit] NULL,
	[DsVomiting] [bit] NULL,
	[DsDiarrhea] [bit] NULL,
	[DsReturn] [bit] NULL,
	[Hgb] [nvarchar](50) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[HepB] [bit] NULL,
	[Protein] [nvarchar](50) NULL,
	[Glucose] [nvarchar](50) NULL,
	[BloodSugar] [nvarchar](50) NULL,
	[WBC] [nvarchar](50) NULL,
	[GramStain] [nvarchar](50) NULL,
	[Keytone] [nvarchar](50) NULL,
	[Blood] [nvarchar](50) NULL,
	[Polio] [bit] NULL,
	[BCG] [bit] NULL,
	[Bilirubin] [nvarchar](150) NULL,
	[Notes] [nvarchar](max) NULL,
	[Plan] [nvarchar](max) NULL,
 CONSTRAINT [PK_PreNatalInfant] PRIMARY KEY CLUSTERED 
(
	[PostNatalInfantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostNatal_MotherPhysicalExamination]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostNatal_MotherPhysicalExamination](
	[PostNatalMotherPhysicalExamId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[InfantDOB] [date] NULL,
	[DeliveryHospital] [bit] NULL,
	[DeliveryMaternityHome] [bit] NULL,
	[DeliveryHome] [bit] NULL,
	[DeliveryCondition] [nvarchar](50) NULL,
	[DeliveryTerm] [nvarchar](50) NULL,
	[SkilledBirthAttendant] [bit] NULL,
	[Episiotomy] [bit] NULL,
	[InfantCondition] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL,
	[Bleeding] [bit] NULL,
	[Discharge] [bit] NULL,
	[DischargeType] [nvarchar](50) NULL,
	[UrinationPain] [bit] NULL,
	[UrinationDifficulty] [bit] NULL,
	[UrinationDifficultyType] [nvarchar](50) NULL,
	[Fever] [bit] NULL,
	[Pain] [bit] NULL,
	[PainAbdomen] [nvarchar](50) NULL,
	[Appetite] [bit] NULL,
	[OtherConcerns] [nvarchar](max) NULL,
	[TakePrenatalVitamins] [bit] NULL,
	[OtherMedication] [nvarchar](max) NULL,
	[Weight] [decimal](4, 0) NULL,
	[Height] [decimal](4, 0) NULL,
	[Temperature] [decimal](4, 0) NULL,
	[Pulse] [decimal](4, 0) NULL,
	[BP] [decimal](4, 0) NULL,
	[Heent] [nvarchar](50) NULL,
	[HeartMurmur] [bit] NULL,
	[HeartRate] [nvarchar](50) NULL,
	[HeartRythm] [nvarchar](50) NULL,
	[Abdomen] [nvarchar](50) NULL,
	[AbdomenBowelSound] [bit] NULL,
	[FundalHeight] [nvarchar](50) NULL,
	[Tender] [nvarchar](50) NULL,
	[Mass] [nvarchar](50) NULL,
	[MassQuality] [nvarchar](50) NULL,
	[BreastLeftNormal] [bit] NULL,
	[BreastLeftAbnormal] [bit] NULL,
	[BreastLeftMass] [bit] NULL,
	[BreastLeftErythema] [bit] NULL,
	[BreastLeftTender] [bit] NULL,
	[BreastLeftDischargeMilk] [bit] NULL,
	[BreastLeftPus] [bit] NULL,
	[BreastLeftOther] [bit] NULL,
	[BreastRightNormal] [bit] NULL,
	[BreastRightAbnormal] [bit] NULL,
	[BreastRightMass] [bit] NULL,
	[BreastRightErythema] [bit] NULL,
	[BreastRightTender] [bit] NULL,
	[BreastRightDischargeMilk] [bit] NULL,
	[BreastRightPus] [bit] NULL,
	[BreastRightOther] [bit] NULL,
	[CsectionIncisionWellHealed] [bit] NULL,
	[CsectionIncisionNotwellhealed] [bit] NULL,
	[CsectionIncisionOpening] [bit] NULL,
	[WoundDischarge] [nvarchar](50) NULL,
	[VagExamNormal] [bit] NULL,
	[VagExamBloodyDischarge] [bit] NULL,
	[VagExamNoDischarge] [bit] NULL,
	[VagExamTearHealing] [bit] NULL,
	[VagExamNoHealing] [bit] NULL,
	[VagExamSwollen] [bit] NULL,
	[VagExamTender] [bit] NULL,
	[VagExamNoTender] [bit] NULL,
	[LungsCondition] [nvarchar](50) NULL,
	[LungLeftWheezes] [bit] NULL,
	[LungLeftRhonchi] [bit] NULL,
	[LungLeftRales] [bit] NULL,
	[LungLeftPoorAirEntry] [bit] NULL,
	[LungLeftOther] [bit] NULL,
	[LungRightWheezes] [bit] NULL,
	[LungRightRhonchi] [bit] NULL,
	[LungRightRales] [bit] NULL,
	[LungRightPoorAirEntry] [bit] NULL,
	[LungRightOther] [bit] NULL,
 CONSTRAINT [PK_PreNatalMotherPhysicalExamination] PRIMARY KEY CLUSTERED 
(
	[PostNatalMotherPhysicalExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Assessment]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Assessment](
	[AssessmentId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[Notes] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_PreNatalAssessment] PRIMARY KEY CLUSTERED 
(
	[AssessmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Counsel]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Counsel](
	[PreNatalcounselId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[PreNatalVisitId] [int] NULL,
	[VisitNo] [nvarchar](100) NULL,
	[CheckupOf] [nvarchar](100) NULL,
	[DangerSigns] [bit] NULL,
	[Hgb] [bit] NULL,
	[Protein] [bit] NULL,
	[NextVisitDate] [date] NULL,
	[NextVisitNotes] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_PreNatalCounsel] PRIMARY KEY CLUSTERED 
(
	[PreNatalcounselId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_LabTest]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_LabTest](
	[TestId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[CurrentEgaWeek] [nvarchar](50) NULL,
	[VisitNo] [nvarchar](100) NULL,
	[CheckupOf] [nvarchar](100) NULL,
	[Hgb] [nvarchar](50) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[HepB] [bit] NULL,
	[Protein] [nvarchar](50) NULL,
	[Glucose] [nvarchar](50) NULL,
	[BloodSugar] [nvarchar](50) NULL,
	[WBC] [nvarchar](50) NULL,
	[GramStain] [nvarchar](50) NULL,
	[Keytone] [nvarchar](50) NULL,
	[Blood] [nvarchar](50) NULL,
	[Nitrite] [bit] NULL,
	[SpecificGravity] [nvarchar](50) NULL,
	[PrenatalUltrasound] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_PreNatalLabTest] PRIMARY KEY CLUSTERED 
(
	[TestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Medication]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Medication](
	[PreNatalMedicationId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[VisitNo] [nvarchar](100) NULL,
	[CheckupOf] [nvarchar](100) NULL,
	[PreNatalVitamins] [bit] NULL,
	[TT] [bit] NULL,
	[Calcium] [bit] NULL,
	[HepBVaccine] [bit] NULL,
	[ReviewDangerSigns] [bit] NULL,
	[Advice] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_PreNatalMedication] PRIMARY KEY CLUSTERED 
(
	[PreNatalMedicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_PhysicalExamination]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_PhysicalExamination](
	[PreNatalPhysicalExamId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[PreNatalVisitId] [int] NULL,
	[VisitNo] [nvarchar](50) NULL,
	[CurrentEGAWeek] [nvarchar](50) NULL,
	[Weight] [decimal](4, 0) NULL,
	[Height] [decimal](4, 0) NULL,
	[Temperature] [decimal](4, 0) NULL,
	[Pulse] [decimal](4, 0) NULL,
	[BP] [decimal](4, 0) NULL,
	[GeneralAppearance] [nvarchar](50) NULL,
	[HeartMurmur] [bit] NULL,
	[HeartRate] [bit] NULL,
	[Lungs] [nvarchar](50) NULL,
	[Abdomen] [nvarchar](50) NULL,
	[AbdomenBowelSounds] [bit] NULL,
	[FundalHeight] [decimal](18, 0) NULL,
	[AppropriateForGestationalAge] [bit] NULL,
	[SmallForGestationalAge] [bit] NULL,
	[LargeForGestationalAge] [bit] NULL,
	[VagExamNone] [bit] NULL,
	[VagExamMass] [bit] NULL,
	[VagExamTender] [bit] NULL,
	[VagDischargeYellow] [bit] NULL,
	[VagDischargeWhite] [bit] NULL,
	[VagDischargeGreen] [bit] NULL,
	[VagDischargeBleeding] [bit] NULL,
	[VagDischargeNone] [bit] NULL,
	[ComplaintPain] [bit] NULL,
	[ComplaintBleeding] [bit] NULL,
	[ComplaintDischarge] [bit] NULL,
	[ComplaintUrineBurning] [bit] NULL,
	[ComplaintSeizures] [bit] NULL,
	[ComplaintFits] [bit] NULL,
	[ComplaintFever] [bit] NULL,
	[PreNataVisit1Notes] [nvarchar](max) NULL,
	[BirthingKit] [bit] NULL,
	[FetalPosition] [nvarchar](50) NULL,
	[FetalMovement] [bit] NULL,
	[Edema] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_PreNatalPhysicalExamination] PRIMARY KEY CLUSTERED 
(
	[PreNatalPhysicalExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Plan]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Plan](
	[PreNatalPlanId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_PreNatalPlan] PRIMARY KEY CLUSTERED 
(
	[PreNatalPlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Step1]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Step1](
	[PreNatalStep1Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[LastMestrualDate] [date] NULL,
	[EDD] [date] NULL,
	[Para] [nvarchar](250) NULL,
	[Gravida] [nvarchar](250) NULL,
	[Abortions] [int] NULL,
	[LastBabyBorn] [nvarchar](50) NULL,
	[EGA] [nvarchar](100) NULL,
 CONSTRAINT [PK_PreNatalStep1] PRIMARY KEY CLUSTERED 
(
	[PreNatalStep1Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Step2]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Step2](
	[PreNatalStep2Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[DateOfDelivery] [date] NULL,
	[CompBleeding] [bit] NULL,
	[CompBP] [bit] NULL,
	[CompStillBirth] [bit] NULL,
	[CompHeavyBleeding] [bit] NULL,
	[CompKidneyProblem] [bit] NULL,
	[CompAnemia] [bit] NULL,
	[CompCSection] [bit] NULL,
	[CompEclampsia] [bit] NULL,
	[CompFever] [bit] NULL,
	[CompForcepsVaccum] [bit] NULL,
	[CompPreEcplampsia] [bit] NULL,
	[CompTwins] [bit] NULL,
	[CompTear] [bit] NULL,
	[CompSugar] [bit] NULL,
	[CompTetanusImmunization] [bit] NULL,
	[homeDelivery] [bit] NULL,
	[MaternityHomeDelivery] [bit] NULL,
	[HospitalDelivery] [bit] NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_PreNatalStep2] PRIMARY KEY CLUSTERED 
(
	[PreNatalStep2Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreNatal_Visit]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreNatal_Visit](
	[PreNatalVisitId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[VisitTitle] [nvarchar](50) NULL,
	[VisitDate] [date] NULL,
	[VisitReasons] [nvarchar](200) NULL,
	[VisitDiagnosis] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
	[VisitNotes] [nvarchar](200) NULL,
 CONSTRAINT [PK_PreNatalVisit] PRIMARY KEY CLUSTERED 
(
	[PreNatalVisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[SpecializationId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_dbo.Specializations] PRIMARY KEY CLUSTERED 
(
	[SpecializationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[TreatmentId] [int] IDENTITY(1,1) NOT NULL,
	[PreNatalPhsicalExamId] [int] NULL,
	[PostNatalInfantId] [int] NULL,
	[PostNatalMotherPhysicalExamId] [int] NULL,
	[GynaePhysicalExamId] [int] NULL,
	[PaedsExamId] [int] NULL,
	[LabTestId] [int] NULL,
	[MedicationId] [int] NULL,
	[CouselId] [int] NULL,
	[AssessmentId] [int] NULL,
	[PlanId] [int] NULL,
	[VisitId] [int] NULL,
 CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED 
(
	[TreatmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ultrasound]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ultrasound](
	[UltrasoundId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NULL,
	[Date] [date] NULL,
	[LastMenstrualPeriod] [nvarchar](50) NULL,
	[EDD] [date] NULL,
	[EGA] [nvarchar](100) NULL,
	[Placenta] [nvarchar](50) NULL,
	[Grade] [nvarchar](50) NULL,
	[Cord] [nvarchar](50) NULL,
	[AmnioticFluidVolume] [nvarchar](50) NULL,
	[AFI] [decimal](18, 0) NULL,
	[Gender] [nvarchar](50) NULL,
	[NoOfFetuses] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Breathing] [bit] NULL,
	[Movement] [bit] NULL,
	[Face] [nvarchar](50) NULL,
	[Brain] [nvarchar](50) NULL,
	[Spine] [nvarchar](50) NULL,
	[Lungs] [nvarchar](50) NULL,
	[HeartChamber] [bit] NULL,
	[HeartCondition] [nvarchar](50) NULL,
	[HeartRate] [nvarchar](50) NULL,
	[Stomach] [nvarchar](50) NULL,
	[CordInsertion] [nvarchar](50) NULL,
	[ExtLeftArms] [nvarchar](50) NULL,
	[ExtRightArms] [nvarchar](50) NULL,
	[ExtLeftLegs] [nvarchar](50) NULL,
	[ExtRightLegs] [nvarchar](50) NULL,
	[CRL] [nvarchar](100) NULL,
	[CRLEGA] [nvarchar](100) NULL,
	[FemurLength] [nvarchar](100) NULL,
	[FemurLengthEGA] [nvarchar](100) NULL,
	[BPD] [nvarchar](100) NULL,
	[BPDEGA] [nvarchar](50) NULL,
	[HeadCircumference] [nvarchar](100) NULL,
	[HeadCircumferenceEGA] [nvarchar](50) NULL,
	[AbdCircumference] [nvarchar](100) NULL,
	[AbdEGA] [nvarchar](50) NULL,
	[EFetalWeight] [nvarchar](50) NULL,
	[ThirdFermurLength] [nvarchar](50) NULL,
	[ThirdBPD] [nvarchar](50) NULL,
	[ThirdEGA] [nvarchar](50) NULL,
	[ThirdEstimatedFetalWeight] [nvarchar](50) NULL,
	[Comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ultrasound] PRIMARY KEY CLUSTERED 
(
	[UltrasoundId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](15) NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 2020-12-10 10:08:53 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_DoctorInfo] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[DoctorInfo] ([DoctorId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_DoctorInfo]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_PatientInfo]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[DoctorInfo]  WITH CHECK ADD  CONSTRAINT [FK_DoctorInfo_Specializations] FOREIGN KEY([SpecializationId])
REFERENCES [dbo].[Specializations] ([SpecializationId])
GO
ALTER TABLE [dbo].[DoctorInfo] CHECK CONSTRAINT [FK_DoctorInfo_Specializations]
GO
ALTER TABLE [dbo].[Gynae_PhysicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_Gynae_PhysicalExamination_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[Gynae_PhysicalExamination] CHECK CONSTRAINT [FK_Gynae_PhysicalExamination_PatientInfo]
GO
ALTER TABLE [dbo].[GynaeForm]  WITH CHECK ADD  CONSTRAINT [FK_GynaeForm_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[GynaeForm] CHECK CONSTRAINT [FK_GynaeForm_PatientInfo]
GO
ALTER TABLE [dbo].[Paeds_PhysicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_Paeds_PhysicalExamination_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[Paeds_PhysicalExamination] CHECK CONSTRAINT [FK_Paeds_PhysicalExamination_PatientInfo]
GO
ALTER TABLE [dbo].[PaedsForm]  WITH CHECK ADD  CONSTRAINT [FK_PaedsForm_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PaedsForm] CHECK CONSTRAINT [FK_PaedsForm_PatientInfo]
GO
ALTER TABLE [dbo].[PostNatal_Infant]  WITH CHECK ADD  CONSTRAINT [FK_PostNatal_Infant_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PostNatal_Infant] CHECK CONSTRAINT [FK_PostNatal_Infant_PatientInfo]
GO
ALTER TABLE [dbo].[PostNatal_MotherPhysicalExamination]  WITH CHECK ADD  CONSTRAINT [FK_PostNatal_MotherPhysicalExamination_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PostNatal_MotherPhysicalExamination] CHECK CONSTRAINT [FK_PostNatal_MotherPhysicalExamination_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Assessment]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Assessment_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Assessment] CHECK CONSTRAINT [FK_PreNatal_Assessment_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Counsel]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Counsel_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Counsel] CHECK CONSTRAINT [FK_PreNatal_Counsel_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_LabTest]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_LabTest_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_LabTest] CHECK CONSTRAINT [FK_PreNatal_LabTest_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Medication]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Medication_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Medication] CHECK CONSTRAINT [FK_PreNatal_Medication_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Plan]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Plan_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Plan] CHECK CONSTRAINT [FK_PreNatal_Plan_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Step1]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Step1_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Step1] CHECK CONSTRAINT [FK_PreNatal_Step1_PatientInfo]
GO
ALTER TABLE [dbo].[PreNatal_Step2]  WITH CHECK ADD  CONSTRAINT [FK_PreNatal_Step2_PatientInfo] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientInfo] ([PatientId])
GO
ALTER TABLE [dbo].[PreNatal_Step2] CHECK CONSTRAINT [FK_PreNatal_Step2_PatientInfo]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[UserRoles] ([RoleId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserRoles]
GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PreNatal_PhysicalExamination_Delete]
   @PreNatalPhysicalExamId int
as
begin
Delete from PreNatal_PhysicalExamination where PreNatalPhysicalExamId=@PreNatalPhysicalExamId
end

GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PreNatal_PhysicalExamination_Insert]
   @PatientId int						=NULL
  ,@PreNatalVisitId int					=NULL
  ,@VisitNo nvarchar(50)                =NULL
  ,@CurrentEGAWeek nvarchar(50)			=NULL
  ,@Weight decimal(4,0)					=NULL
  ,@Height decimal(4,0)					=NULL
  ,@Temperature decimal(4,0)			=NULL
  ,@Pulse decimal(4,0)					=NULL
  ,@BP decimal(4,0)						=NULL
  ,@GeneralAppearance nvarchar(50)		=NULL
  ,@HeartMurmur bit						=NULL
  ,@HeartRate bit						=NULL
  ,@Lungs nvarchar(50)					=NULL
  ,@Abdomen nvarchar(50)				=NULL
  ,@AbdomenBowelSounds bit				=NULL
  ,@FundalHeight decimal(18,0)			=NULL
  ,@AppropriateForGestationalAge bit	=NULL
  ,@SmallForGestationalAge bit			=NULL
  ,@LargeForGestationalAge bit			=NULL
  ,@VagExamNone bit						=NULL
  ,@VagExamMass bit						=NULL
  ,@VagExamTender bit					=NULL
  ,@VagDischargeYellow bit				=NULL
  ,@VagDischargeWhite bit				=NULL
  ,@VagDischargeGreen bit				=NULL
  ,@VagDischargeBleeding bit			=NULL
  ,@VagDischargeNone bit				=NULL
  ,@ComplaintPain bit					=NULL
  ,@ComplaintBleeding bit				=NULL
  ,@ComplaintDischarge bit				=NULL
  ,@ComplaintUrineBurning bit			=NULL
  ,@ComplaintSeizures bit				=NULL
  ,@ComplaintFits bit					=NULL
  ,@ComplaintFever bit					=NULL
  ,@PreNataVisit1Notes nvarchar(max)	=NULL
  ,@BirthingKit bit						=NULL
  ,@FetalPosition nvarchar(50)			=NULL
  ,@FetalMovement bit					=NULL
  ,@Edema nvarchar(50)					=NULL
  ,@Error bit =null output
  ,@Message nvarchar(200)=null output 
  ,@ID int output
as
begin
INSERT INTO PreNatal_PhysicalExamination
           ([PatientId]
           ,[PreNatalVisitId]
		   ,[VisitNo]
           ,[CurrentEGAWeek]
           ,[Weight]
           ,[Height]
           ,[Temperature]
           ,[Pulse]
           ,[BP]
           ,[GeneralAppearance]
           ,[HeartMurmur]
           ,[HeartRate]
           ,[Lungs]
           ,[Abdomen]
           ,[AbdomenBowelSounds]
           ,[FundalHeight]
           ,[AppropriateForGestationalAge]
           ,[SmallForGestationalAge]
           ,[LargeForGestationalAge]
           ,[VagExamNone]
           ,[VagExamMass]
           ,[VagExamTender]
           ,[VagDischargeYellow]
           ,[VagDischargeWhite]
           ,[VagDischargeGreen]
           ,[VagDischargeBleeding]
           ,[VagDischargeNone]
           ,[ComplaintPain]
           ,[ComplaintBleeding]
           ,[ComplaintDischarge]
           ,[ComplaintUrineBurning]
           ,[ComplaintSeizures]
           ,[ComplaintFits]
           ,[ComplaintFever]
           ,[PreNataVisit1Notes]
		   ,[BirthingKit]
           ,[FetalPosition]
           ,[FetalMovement]
           ,[Edema])
     VALUES
           (
		    @PatientId
           ,@PreNatalVisitId
		   ,@VisitNo 
           ,@CurrentEGAWeek 
           ,@Weight 
           ,@Height 
           ,@Temperature 
           ,@Pulse 
           ,@BP 
           ,@GeneralAppearance 
           ,@HeartMurmur
           ,@HeartRate 
           ,@Lungs 
           ,@Abdomen 
           ,@AbdomenBowelSounds 
           ,@FundalHeight 
           ,@AppropriateForGestationalAge 
           ,@SmallForGestationalAge 
           ,@LargeForGestationalAge 
           ,@VagExamNone 
           ,@VagExamMass
           ,@VagExamTender 
           ,@VagDischargeYellow 
           ,@VagDischargeWhite 
           ,@VagDischargeGreen 
           ,@VagDischargeBleeding
           ,@VagDischargeNone 
           ,@ComplaintPain 
           ,@ComplaintBleeding 
           ,@ComplaintDischarge 
           ,@ComplaintUrineBurning 
           ,@ComplaintSeizures
           ,@ComplaintFits
           ,@ComplaintFever
           ,@PreNataVisit1Notes
		   ,@BirthingKit
           ,@FetalPosition
           ,@FetalMovement
           ,@Edema
		   )

		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec PreNatal_PhysicalExamination_Populate 2
CREATE proc [dbo].[PreNatal_PhysicalExamination_Populate]
@MrNumber bigint
as
SELECT        PPE.PreNatalPhysicalExamId,P.PatientName,PPE.PatientId, PPE.PreNatalVisitId, PPE.VisitNo, PPE.CurrentEGAWeek, PPE.Weight, PPE.Height, PPE.Temperature, PPE.Pulse, PPE.BP, PPE.GeneralAppearance, PPE.HeartMurmur, 
                         PPE.HeartRate, PPE.Lungs, PPE.Abdomen, PPE.AbdomenBowelSounds, PPE.FundalHeight, PPE.AppropriateForGestationalAge, PPE.SmallForGestationalAge, PPE.LargeForGestationalAge, PPE.VagExamNone, 
                         PPE.VagExamMass, PPE.VagExamTender, PPE.VagDischargeYellow, PPE.VagDischargeWhite, PPE.VagDischargeGreen, PPE.VagDischargeBleeding, PPE.VagDischargeNone, PPE.ComplaintPain, PPE.ComplaintBleeding, 
                         PPE.ComplaintDischarge, PPE.ComplaintUrineBurning, PPE.ComplaintSeizures, PPE.ComplaintFits, PPE.ComplaintFever, PPE.PreNataVisit1Notes, PPE.BirthingKit, PPE.FetalPosition, PPE.FetalMovement, PPE.Edema 
                        
FROM            PreNatal_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId where  P.MrNumber=@MrNumber

					
GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PreNatal_PhysicalExamination_SelectAll]
as
begin
SELECT        PPE.PreNatalPhysicalExamId,  P.PatientName,PPE.PatientId, PPE.PreNatalVisitId, PPE.VisitNo, PPE.CurrentEGAWeek, PPE.Weight, PPE.Height, PPE.Temperature, PPE.Pulse, PPE.BP, PPE.GeneralAppearance, PPE.HeartMurmur, 
                         PPE.HeartRate, PPE.Lungs, PPE.Abdomen, PPE.AbdomenBowelSounds, PPE.FundalHeight, PPE.AppropriateForGestationalAge, PPE.SmallForGestationalAge, PPE.LargeForGestationalAge, PPE.VagExamNone, 
                         PPE.VagExamMass, PPE.VagExamTender, PPE.VagDischargeYellow, PPE.VagDischargeWhite, PPE.VagDischargeGreen, PPE.VagDischargeBleeding, PPE.VagDischargeNone, PPE.ComplaintPain, PPE.ComplaintBleeding, 
                         PPE.ComplaintDischarge, PPE.ComplaintUrineBurning, PPE.ComplaintSeizures, PPE.ComplaintFits, PPE.ComplaintFever, PPE.PreNataVisit1Notes, PPE.BirthingKit, PPE.FetalPosition, PPE.FetalMovement, PPE.Edema 
                        
FROM            PreNatal_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId order by PPE.PreNatalPhysicalExamId desc
						
						 
end

GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PreNatal_PhysicalExamination_SelectByID]
   @PreNatalPhysicalExamId int
as
begin
SELECT        PPE.PreNatalPhysicalExamId,P.PatientName,PPE.PatientId, PPE.PreNatalVisitId, PPE.VisitNo, PPE.CurrentEGAWeek, PPE.Weight, PPE.Height, PPE.Temperature, PPE.Pulse, PPE.BP, PPE.GeneralAppearance, PPE.HeartMurmur, 
                         PPE.HeartRate, PPE.Lungs, PPE.Abdomen, PPE.AbdomenBowelSounds, PPE.FundalHeight, PPE.AppropriateForGestationalAge, PPE.SmallForGestationalAge, PPE.LargeForGestationalAge, PPE.VagExamNone, 
                         PPE.VagExamMass, PPE.VagExamTender, PPE.VagDischargeYellow, PPE.VagDischargeWhite, PPE.VagDischargeGreen, PPE.VagDischargeBleeding, PPE.VagDischargeNone, PPE.ComplaintPain, PPE.ComplaintBleeding, 
                         PPE.ComplaintDischarge, PPE.ComplaintUrineBurning, PPE.ComplaintSeizures, PPE.ComplaintFits, PPE.ComplaintFever, PPE.PreNataVisit1Notes, PPE.BirthingKit, PPE.FetalPosition, PPE.FetalMovement, PPE.Edema 
                        
FROM            PreNatal_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId where PPE.PreNatalPhysicalExamId=@PreNatalPhysicalExamId
end

GO
/****** Object:  StoredProcedure [dbo].[PreNatal_PhysicalExamination_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PreNatal_PhysicalExamination_Update]
   @PreNatalPhysicalExamId int
  ,@PatientId int						=NULL
  ,@PreNatalVisitId int					=NULL
  ,@VisitNo nvarchar(50)                =NULL
  ,@CurrentEGAWeek nvarchar(50)			=NULL
  ,@Weight decimal(4,0)					=NULL
  ,@Hieght decimal(4,0)					=NULL
  ,@Temperature decimal(4,0)			=NULL
  ,@Pulse decimal(4,0)					=NULL
  ,@BP decimal(4,0)						=NULL
  ,@GeneralAppearance nvarchar(50)		=NULL
  ,@HeartMurmur bit						=NULL
  ,@HeartRate bit						=NULL
  ,@Lungs nvarchar(50)					=NULL
  ,@Abdomen nvarchar(50)				=NULL
  ,@AbdomenBowelSounds bit				=NULL
  ,@FundalHeight decimal(18,0)			=NULL
  ,@AppropriateForGestationalAge bit	=NULL
  ,@SmallForGestationalAge bit			=NULL
  ,@LargeForGestationalAge bit			=NULL
  ,@VagExamNone bit						=NULL
  ,@VagExamMass bit						=NULL
  ,@VagExamTender bit					=NULL
  ,@VagDischargeYellow bit				=NULL
  ,@VagDischargeWhite bit				=NULL
  ,@VagDischargeGreen bit				=NULL
  ,@VagDischargeBleeding bit			=NULL
  ,@VagDischargeNone bit				=NULL
  ,@ComplaintPain bit					=NULL
  ,@ComplaintBleeding bit				=NULL
  ,@ComplaintDischarge bit				=NULL
  ,@ComplaintUrineBurning bit			=NULL
  ,@ComplaintSeizures bit				=NULL
  ,@ComplaintFits bit					=NULL
  ,@ComplaintFever bit					=NULL
  ,@PreNataVisit1Notes nvarchar(max)	=NULL
  ,@BirthingKit bit						=NULL
  ,@FetalPosition nvarchar(50)			=NULL
  ,@FetalMovement bit					=NULL
  ,@Edema nvarchar(50)					=NULL
as
begin
UPDATE PreNatal_PhysicalExamination
   SET [PatientId] = @PatientId 
      ,[PreNatalVisitId] = @PreNatalVisitId 
	  ,[VisitNo]=@VisitNo
      ,[CurrentEGAWeek] = @CurrentEGAWeek 
      ,[Weight] = @Weight
      ,[Height] = @Hieght 
      ,[Temperature] = @Temperature 
      ,[Pulse] = @Pulse 
      ,[BP] = @BP
      ,[GeneralAppearance] = @GeneralAppearance 
      ,[HeartMurmur] = @HeartMurmur 
      ,[HeartRate] = @HeartRate 
      ,[Lungs] = @Lungs 
      ,[Abdomen] = @Abdomen 
      ,[AbdomenBowelSounds] = @AbdomenBowelSounds 
      ,[FundalHeight] = @FundalHeight 
      ,[AppropriateForGestationalAge] = @AppropriateForGestationalAge 
      ,[SmallForGestationalAge] = @SmallForGestationalAge 
      ,[LargeForGestationalAge] = @LargeForGestationalAge 
      ,[VagExamNone] = @VagExamNone 
      ,[VagExamMass] = @VagExamMass 
      ,[VagExamTender] = @VagExamTender 
      ,[VagDischargeYellow] = @VagDischargeYellow 
      ,[VagDischargeWhite] = @VagDischargeWhite 
      ,[VagDischargeGreen] = @VagDischargeGreen 
      ,[VagDischargeBleeding] = @VagDischargeBleeding 
      ,[VagDischargeNone] = @VagDischargeNone 
      ,[ComplaintPain] = @ComplaintPain 
      ,[ComplaintBleeding] = @ComplaintBleeding 
      ,[ComplaintDischarge] = @ComplaintDischarge 
      ,[ComplaintUrineBurning] = @ComplaintUrineBurning 
      ,[ComplaintSeizures] = @ComplaintSeizures 
      ,[ComplaintFits] = @ComplaintFits 
      ,[ComplaintFever] = @ComplaintFever 
      ,[PreNataVisit1Notes] = @PreNataVisit1Notes
	  ,[BirthingKit] =   @BirthingKit
      ,[FetalPosition] = @FetalPosition
      ,[FetalMovement] = @FetalMovement
      ,[Edema] =         @Edema
 WHERE PreNatalPhysicalExamId=@PreNatalPhysicalExamId
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Councel_Delete]
@PreNatalcounselId int
as
begin
DELETE FROM PreNatal_Counsel WHERE PreNatalcounselId=@PreNatalcounselId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Councel_Insert]
 @PatientId int
,@VisitNo nvarchar(100)				=NULL
,@CheckupOf nvarchar(100) =NULL
,@DangerSigns bit					=NULL
,@Hgb bit							=NULL
,@Protein bit						=NULL
,@NextVisitDate date				=NULL
,@NextVisitNotes nvarchar(500)		=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO [dbo].[PreNatal_Counsel]
           ([PatientId]
           ,[VisitNo]
		   ,[CheckupOf]
           ,[DangerSigns]
           ,[Hgb]
           ,[Protein]
           ,[NextVisitDate]
           ,[NextVisitNotes])
     VALUES
           (@PatientId 
           ,@VisitNo
		   ,@CheckupOf
           ,@DangerSigns
           ,@Hgb
           ,@Protein
           ,@NextVisitDate 
           ,@NextVisitNotes
		   )

		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()

end


GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_Councel_Populate 1
create proc [dbo].[sp_Councel_Populate]
@MrNumber bigint
as
begin
SELECT        C.PreNatalcounselId, C.PatientId, C.PreNatalVisitId, C.VisitNo, C.CheckupOf, C.DangerSigns, C.Hgb, C.Protein, C.NextVisitDate, C.NextVisitNotes, P.MrNumber
FROM            PreNatal_Counsel AS C INNER JOIN
                         PatientInfo AS P ON C.PatientId = P.PatientId where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Councel_SelectAll]
as
begin
SELECT        PreNatal_Counsel.PreNatalcounselId, PatientInfo.PatientName, PreNatal_Counsel.VisitNo, PreNatal_Counsel.CheckupOf, PreNatal_Counsel.DangerSigns, PreNatal_Counsel.Hgb, PreNatal_Counsel.Protein, PreNatal_Counsel.NextVisitDate, 
              PreNatal_Counsel.NextVisitNotes
FROM          PatientInfo INNER JOIN
              PreNatal_Counsel ON PatientInfo.PatientId = PreNatal_Counsel.PatientId order by PreNatal_Counsel.PreNatalcounselId desc

end



GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Councel_SelectByID]
@PreNatalcounselId int
as
begin
SELECT        PreNatal_Counsel.PreNatalcounselId, PreNatal_Counsel.PatientId, PatientInfo.PatientName, PreNatal_Counsel.VisitNo,PreNatal_Counsel.CheckupOf, PreNatal_Counsel.DangerSigns, PreNatal_Counsel.Hgb, PreNatal_Counsel.Protein, PreNatal_Counsel.NextVisitDate, 
              PreNatal_Counsel.NextVisitNotes
FROM          PatientInfo INNER JOIN
              PreNatal_Counsel ON PatientInfo.PatientId = PreNatal_Counsel.PatientId
WHERE		  PreNatal_Counsel.PreNatalcounselId=@PreNatalcounselId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Councel_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Councel_Update]
 @PreNatalcounselId int
,@PatientId int					=NULL
,@VisitNo nvarchar(100)			=NULL
,@CheckupOf nvarchar(100) =NULL
,@DangerSigns bit				=NULL
,@Hgb bit						=NULL
,@Protein bit					=NULL
,@NextVisitDate date			=NULL
,@NextVisitNotes nvarchar(500)	=NULL
as
begin
UPDATE PreNatal_Counsel
   SET [PatientId] = @PatientId
      ,[VisitNo] = @VisitNo
	  ,[CheckupOf]=@CheckupOf
      ,[DangerSigns] = @DangerSigns
      ,[Hgb] = @Hgb
      ,[Protein] = @Protein
      ,[NextVisitDate] = @NextVisitDate
      ,[NextVisitNotes] = @NextVisitNotes
 WHERE PreNatalcounselId=@PreNatalcounselId
end


GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorInfo_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoctorInfo_Delete]
 @DoctorId int
as
begin
Delete from DoctorInfo WHERE DoctorId=@DoctorId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorInfo_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DoctorInfo_Insert]
 @DoctorName nvarchar(255)	=NULL	
,@Phone nvarchar(max)	=NULL
,@IsAvailable bit		=NULL
,@Address nvarchar(max)	=NULL
,@SpecializationId int	=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO DoctorInfo
           ([DoctorName]
           ,[Phone]
           ,[IsAvailable]
           ,[Address]
           ,[SpecializationId])
     VALUES
           (@DoctorName
           ,@Phone
           ,@IsAvailable 
           ,@Address 
           ,@SpecializationId 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorInfo_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoctorInfo_SelectAll]
as
begin
SELECT        D.DoctorId, D.DoctorName, D.Phone, D.IsAvailable, D.Address, S.Name
FROM            DoctorInfo AS D INNER JOIN
                         Specializations AS S ON D.SpecializationId = S.SpecializationId
						order by D.DoctorId desc 
end



GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorInfo_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DoctorInfo_SelectByID]
 @DoctorId int
as
begin
SELECT        D.DoctorId,D.SpecializationId, D.DoctorName, D.Phone, D.IsAvailable, D.Address, S.Name
FROM            DoctorInfo AS D INNER JOIN
                         Specializations AS S ON D.SpecializationId = S.SpecializationId
						 where DoctorId=@DoctorId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_DoctorInfo_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DoctorInfo_Update]
 @DoctorId int
,@DoctorName nvarchar(255)	=NULL	
,@Phone nvarchar(max)	=NULL
,@IsAvailable bit		=NULL
,@Address nvarchar(max)	=NULL
,@SpecializationId int	=NULL

as
begin
UPDATE DoctorInfo
   SET [DoctorName] = @DoctorName
      ,[Phone] = @Phone 
      ,[IsAvailable] = @IsAvailable 
      ,[Address] = @Address 
      ,[SpecializationId] = @SpecializationId 
 WHERE DoctorId=@DoctorId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_FindStringInTable]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_FindStringInTable] 
@stringToFind VARCHAR(100), 
@schema sysname, 
@table sysname   
AS  
  
BEGIN TRY  
   DECLARE @sqlCommand varchar(max) = 'SELECT * FROM [' + @schema + '].[' + @table + '] WHERE '   
      
   SELECT @sqlCommand = @sqlCommand + '[' + COLUMN_NAME + '] LIKE ''' +'%'+ @stringToFind +'%' + ''' OR '  
   FROM INFORMATION_SCHEMA.COLUMNS   
   WHERE TABLE_SCHEMA = @schema  
   AND TABLE_NAME = @table   
   AND DATA_TYPE IN ('char','nchar','ntext','nvarchar','text','varchar')  
  
   SET @sqlCommand = left(@sqlCommand,len(@sqlCommand)-3)  
   EXEC (@sqlCommand)  
   PRINT @sqlCommand  
END TRY  
  
BEGIN CATCH   
   PRINT 'There was an error. Check to make sure object exists.'  
   PRINT error_message()  
END CATCH   

--sp_FindStringInTable 1,'dbo','PatientInfo'


GO
/****** Object:  StoredProcedure [dbo].[sp_GrowthChart]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_GrowthChart 'MaleHeight'
-- exec sp_GrowthChart 'MaleWeight'
-- exec sp_GrowthChart 'FemaleHeight'
-- exec sp_GrowthChart 'FemaleWeight'
-- exec sp_GrowthChart 'MaleLength'
-- exec sp_GrowthChart 'FemaleLength'
CREATE proc [dbo].[sp_GrowthChart]
@Condition nvarchar(50)
as
begin
		if @Condition='MaleHeight'
		begin
		SELECT HC, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Male'
		end
		if @Condition='MaleWeight'
		begin
		SELECT Weight, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Male'
		end
		if @Condition='FemaleHeight'
		begin
		SELECT HC, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Female'
		end
		if @Condition='FemaleWeight'
		begin
		SELECT Weight, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Female'
		end

		if @Condition='MaleLength'
		begin
		SELECT Length, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Male'
		end
		if @Condition='FemaleLength'
		begin
		SELECT Length, CONVERT(int,ROUND(DATEDIFF(hour,InfantDOB,GETDATE())/8766.0,0)) AS Age from PostNatal_Infant where Gender='Female'
		end
end



	
GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Gynae_PhysicalExamination_Delete]
 @GynaePhysicalExamId int
as
begin
Delete from Gynae_PhysicalExamination where GynaePhysicalExamId=@GynaePhysicalExamId
					
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Gynae_PhysicalExamination_Insert]
 @PatientId int							=NULL		
,@Weight decimal(4,0)					=NULL
,@Height decimal(4,0)					=NULL
,@Temperature decimal(4,0)				=NULL
,@Pulse decimal(4,0)					=NULL
,@BP decimal(4,0)						=NULL
,@Thyroid nvarchar(50)					=NULL
,@Size nvarchar(50)						=NULL
,@HeartMurmur bit						=NULL
,@HeartRate nvarchar(50)				=NULL
,@HeartRythm nvarchar(50)				=NULL
,@Abdomen nvarchar(50)					=NULL
,@AbdomenBowelSound bit					=NULL
,@VaginalExamination nvarchar(100)		=NULL
,@BreastLeftNormal bit					=NULL
,@BreastLeftAbnormal bit				=NULL
,@BreastLeftMass bit					=NULL
,@BreastLeftErythema bit				=NULL
,@BreastLeftTender bit					=NULL
,@BreastLeftDischargeMilk bit			=NULL
,@BreastLeftPus bit						=NULL
,@BreastLeftOther bit					=NULL
,@BreastRightNormal bit					=NULL
,@BreastRightAbnormal bit				=NULL
,@BreastRightMass bit					=NULL
,@BreastRightErythema bit				=NULL
,@BreastRightTender bit					=NULL
,@BreastRightDischargeMilk bit			=NULL
,@BreastRightPus bit					=NULL
,@BreastRightOther bit					=NULL
,@SpeculumExam nvarchar(50)				=NULL
,@CarvixAppearance nvarchar(50)			=NULL
,@MotionTenderness nvarchar(50)			=NULL
,@Uterus nvarchar(50)					=NULL
,@UterusNl nvarchar(50)					=NULL
,@AdnexaLeft nvarchar(50)				=NULL
,@AdnexaRight nvarchar(50)				=NULL
,@AdnexaDescription nvarchar(max)		=NULL
,@lungscondition nvarchar(50)			=NULL
,@LungLeftWheezes bit					=NULL
,@LungLeftRhonchi bit					=NULL
,@LungLeftRales bit						=NULL
,@LungLeftPoorAirEntry bit				=NULL
,@LungLeftOther bit						=NULL
,@LungRightWheezes bit					=NULL
,@LungRightRhonchi bit					=NULL
,@LungRightRales bit					=NULL
,@LungRightPoorAirEntry bit			=NULL
,@LungRightOther bit					=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO Gynae_PhysicalExamination
           ([PatientId]
           ,[Weight]
           ,[Height]
           ,[Temperature]
           ,[Pulse]
           ,[BP]
           ,[Thyroid]
           ,[Size]
           ,[HeartMurmur]
           ,[HeartRate]
           ,[HeartRythm]
           ,[Abdomen]
           ,[AbdomenBowelSound]
           ,[VaginalExamination]
           ,[BreastLeftNormal]
           ,[BreastLeftAbnormal]
           ,[BreastLeftMass]
           ,[BreastLeftErythema]
           ,[BreastLeftTender]
           ,[BreastLeftDischargeMilk]
           ,[BreastLeftPus]
           ,[BreastLeftOther]
           ,[BreastRightNormal]
           ,[BreastRightAbnormal]
           ,[BreastRightMass]
           ,[BreastRightErythema]
           ,[BreastRightTender]
           ,[BreastRightDischargeMilk]
           ,[BreastRightPus]
           ,[BreastRightOther]
           ,[SpeculumExam]
           ,[CarvixAppearance]
           ,[MotionTenderness]
           ,[Uterus]
           ,[UterusNl]
           ,[AdnexaLeft]
           ,[AdnexaRight]
           ,[AdnexaDescription]
           ,[lungscondition]
           ,[LungLeftWheezes]
           ,[LungLeftRhonchi]
           ,[LungLeftRales]
           ,[LungLeftPoorAirEntry]
           ,[LungLeftOther]
           ,[LungRightWheezes]
           ,[LungRightRhonchi]
           ,[LungRightRales]
           ,[LungRightPoorAirEntry]
           ,[LungRightOther])
     VALUES(
            @PatientId 
           ,@Weight
           ,@Height
           ,@Temperature
           ,@Pulse
           ,@BP
           ,@Thyroid 
           ,@Size 
           ,@HeartMurmur 
           ,@HeartRate 
           ,@HeartRythm 
           ,@Abdomen 
           ,@AbdomenBowelSound 
           ,@VaginalExamination
           ,@BreastLeftNormal 
           ,@BreastLeftAbnormal 
           ,@BreastLeftMass 
           ,@BreastLeftErythema 
           ,@BreastLeftTender 
           ,@BreastLeftDischargeMilk 
           ,@BreastLeftPus 
           ,@BreastLeftOther 
           ,@BreastRightNormal 
           ,@BreastRightAbnormal 
           ,@BreastRightMass 
           ,@BreastRightErythema 
           ,@BreastRightTender 
           ,@BreastRightDischargeMilk 
           ,@BreastRightPus 
           ,@BreastRightOther 
           ,@SpeculumExam 
           ,@CarvixAppearance 
           ,@MotionTenderness 
           ,@Uterus 
           ,@UterusNl 
           ,@AdnexaLeft 
           ,@AdnexaRight 
           ,@AdnexaDescription 
           ,@lungscondition 
           ,@LungLeftWheezes 
           ,@LungLeftRhonchi 
           ,@LungLeftRales 
           ,@LungLeftPoorAirEntry 
           ,@LungLeftOther 
           ,@LungRightWheezes 
           ,@LungRightRhonchi 
           ,@LungRightRales 
           ,@LungRightPoorAirEntry 
           ,@LungRightOther 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Gynae_PhysicalExamination_Populate]
  @MrNumber bigint
as
begin
SELECT        GPE.GynaePhysicalExamId, GPE.PatientId,P.PatientName, GPE.Weight, GPE.Height, GPE.Temperature, GPE.Pulse, GPE.BP, GPE.Thyroid, GPE.Size, GPE.HeartMurmur, GPE.HeartRate, GPE.HeartRythm, GPE.Abdomen, 
                         GPE.AbdomenBowelSound, GPE.VaginalExamination, GPE.BreastLeftNormal, GPE.BreastLeftAbnormal, GPE.BreastLeftMass, GPE.BreastLeftErythema, GPE.BreastLeftTender, GPE.BreastLeftDischargeMilk, GPE.BreastLeftPus, 
                         GPE.BreastLeftOther, GPE.BreastRightNormal, GPE.BreastRightAbnormal, GPE.BreastRightMass, GPE.BreastRightErythema, GPE.BreastRightTender, GPE.BreastRightDischargeMilk, GPE.BreastRightPus, 
                         GPE.BreastRightOther, GPE.SpeculumExam, GPE.CarvixAppearance, GPE.MotionTenderness, GPE.Uterus, GPE.UterusNl, GPE.AdnexaLeft, GPE.AdnexaRight, GPE.AdnexaDescription, GPE.lungscondition, 
                         GPE.LungLeftWheezes, GPE.LungLeftRhonchi, GPE.LungLeftRales, GPE.LungLeftPoorAirEntry, GPE.LungLeftOther, GPE.LungRightWheezes, GPE.LungRightRhonchi, GPE.LungRightRales, GPE.LungRightPoorAirEntry, 
                         GPE.LungRightOther
FROM            Gynae_PhysicalExamination AS GPE INNER JOIN
                         PatientInfo AS P ON GPE.PatientId = P.PatientId
						 where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Gynae_PhysicalExamination_SelectAll]
as
begin
SELECT        GPE.GynaePhysicalExamId, GPE.PatientId,P.PatientName, GPE.Weight, GPE.Height, GPE.Temperature, GPE.Pulse, GPE.BP, GPE.Thyroid, GPE.Size, GPE.HeartMurmur, GPE.HeartRate, GPE.HeartRythm, GPE.Abdomen, 
                         GPE.AbdomenBowelSound, GPE.VaginalExamination, GPE.BreastLeftNormal, GPE.BreastLeftAbnormal, GPE.BreastLeftMass, GPE.BreastLeftErythema, GPE.BreastLeftTender, GPE.BreastLeftDischargeMilk, GPE.BreastLeftPus, 
                         GPE.BreastLeftOther, GPE.BreastRightNormal, GPE.BreastRightAbnormal, GPE.BreastRightMass, GPE.BreastRightErythema, GPE.BreastRightTender, GPE.BreastRightDischargeMilk, GPE.BreastRightPus, 
                         GPE.BreastRightOther, GPE.SpeculumExam, GPE.CarvixAppearance, GPE.MotionTenderness, GPE.Uterus, GPE.UterusNl, GPE.AdnexaLeft, GPE.AdnexaRight, GPE.AdnexaDescription, GPE.lungscondition, 
                         GPE.LungLeftWheezes, GPE.LungLeftRhonchi, GPE.LungLeftRales, GPE.LungLeftPoorAirEntry, GPE.LungLeftOther, GPE.LungRightWheezes, GPE.LungRightRhonchi, GPE.LungRightRales, GPE.LungRightPoorAirEntry, 
                         GPE.LungRightOther
FROM            Gynae_PhysicalExamination AS GPE INNER JOIN
                         PatientInfo AS P ON GPE.PatientId = P.PatientId order by GPE.GynaePhysicalExamId desc
					
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Gynae_PhysicalExamination_SelectByID]
 @GynaePhysicalExamId int
as
begin
SELECT        GPE.GynaePhysicalExamId, GPE.PatientId,P.PatientName, GPE.Weight, GPE.Height, GPE.Temperature, GPE.Pulse, GPE.BP, GPE.Thyroid, GPE.Size, GPE.HeartMurmur, GPE.HeartRate, GPE.HeartRythm, GPE.Abdomen, 
                         GPE.AbdomenBowelSound, GPE.VaginalExamination, GPE.BreastLeftNormal, GPE.BreastLeftAbnormal, GPE.BreastLeftMass, GPE.BreastLeftErythema, GPE.BreastLeftTender, GPE.BreastLeftDischargeMilk, GPE.BreastLeftPus, 
                         GPE.BreastLeftOther, GPE.BreastRightNormal, GPE.BreastRightAbnormal, GPE.BreastRightMass, GPE.BreastRightErythema, GPE.BreastRightTender, GPE.BreastRightDischargeMilk, GPE.BreastRightPus, 
                         GPE.BreastRightOther, GPE.SpeculumExam, GPE.CarvixAppearance, GPE.MotionTenderness, GPE.Uterus, GPE.UterusNl, GPE.AdnexaLeft, GPE.AdnexaRight, GPE.AdnexaDescription, GPE.lungscondition, 
                         GPE.LungLeftWheezes, GPE.LungLeftRhonchi, GPE.LungLeftRales, GPE.LungLeftPoorAirEntry, GPE.LungLeftOther, GPE.LungRightWheezes, GPE.LungRightRhonchi, GPE.LungRightRales, GPE.LungRightPoorAirEntry, 
                         GPE.LungRightOther
FROM            Gynae_PhysicalExamination AS GPE INNER JOIN
                         PatientInfo AS P ON GPE.PatientId = P.PatientId
						 where GPE.GynaePhysicalExamId=@GynaePhysicalExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Gynae_PhysicalExamination_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Gynae_PhysicalExamination_Update]
 @GynaePhysicalExamId int
,@PatientId int							=NULL		
,@Weight decimal(4,0)					=NULL
,@Height decimal(4,0)					=NULL
,@Temperature decimal(4,0)				=NULL
,@Pulse decimal(4,0)					=NULL
,@BP decimal(4,0)						=NULL
,@Thyroid nvarchar(50)					=NULL
,@Size nvarchar(50)						=NULL
,@HeartMurmur bit						=NULL
,@HeartRate nvarchar(50)				=NULL
,@HeartRythm nvarchar(50)				=NULL
,@Abdomen nvarchar(50)					=NULL
,@AbdomenBowelSound bit					=NULL
,@VaginalExamination nvarchar(100)		=NULL
,@BreastLeftNormal bit					=NULL
,@BreastLeftAbnormal bit				=NULL
,@BreastLeftMass bit					=NULL
,@BreastLeftErythema bit				=NULL
,@BreastLeftTender bit					=NULL
,@BreastLeftDischargeMilk bit			=NULL
,@BreastLeftPus bit						=NULL
,@BreastLeftOther bit					=NULL
,@BreastRightNormal bit					=NULL
,@BreastRightAbnormal bit				=NULL
,@BreastRightMass bit					=NULL
,@BreastRightErythema bit				=NULL
,@BreastRightTender bit					=NULL
,@BreastRightDischargeMilk bit			=NULL
,@BreastRightPus bit					=NULL
,@BreastRightOther bit					=NULL
,@SpeculumExam nvarchar(50)				=NULL
,@CarvixAppearance nvarchar(50)			=NULL
,@MotionTenderness nvarchar(50)			=NULL
,@Uterus nvarchar(50)					=NULL
,@UterusNl nvarchar(50)					=NULL
,@AdnexaLeft nvarchar(50)				=NULL
,@AdnexaRight nvarchar(50)				=NULL
,@AdnexaDescription nvarchar(max)		=NULL
,@lungscondition nvarchar(50)			=NULL
,@LungLeftWheezes bit					=NULL
,@LungLeftRhonchi bit					=NULL
,@LungLeftRales bit						=NULL
,@LungLeftPoorAirEntry bit				=NULL
,@LungLeftOther bit						=NULL
,@LungRightWheezes bit					=NULL
,@LungRightRhonchi bit					=NULL
,@LungRightRales bit					=NULL
,@LungRightPoorAirEntry bit			=NULL
,@LungRightOther bit					=NULL
as
begin
UPDATE Gynae_PhysicalExamination
   SET [PatientId] = @PatientId
      ,[Weight] = @Weight 
      ,[Height] = @Height 
      ,[Temperature] = @Temperature 
      ,[Pulse] = @Pulse 
      ,[BP] = @BP 
      ,[Thyroid] = @Thyroid 
      ,[Size] = @Size 
      ,[HeartMurmur] = @HeartMurmur 
      ,[HeartRate] = @HeartRate 
      ,[HeartRythm] = @HeartRythm 
      ,[Abdomen] = @Abdomen 
      ,[AbdomenBowelSound] = @AbdomenBowelSound 
      ,[VaginalExamination] = @VaginalExamination
      ,[BreastLeftNormal] = @BreastLeftNormal 
      ,[BreastLeftAbnormal] = @BreastLeftAbnormal 
      ,[BreastLeftMass] = @BreastLeftMass 
      ,[BreastLeftErythema] = @BreastLeftErythema 
      ,[BreastLeftTender] = @BreastLeftTender 
      ,[BreastLeftDischargeMilk] = @BreastLeftDischargeMilk 
      ,[BreastLeftPus] = @BreastLeftPus 
      ,[BreastLeftOther] = @BreastLeftOther 
      ,[BreastRightNormal] = @BreastRightNormal 
      ,[BreastRightAbnormal] = @BreastRightAbnormal 
      ,[BreastRightMass] = @BreastRightMass 
      ,[BreastRightErythema] = @BreastRightErythema 
      ,[BreastRightTender] = @BreastRightTender 
      ,[BreastRightDischargeMilk] = @BreastRightDischargeMilk 
      ,[BreastRightPus] = @BreastRightPus 
      ,[BreastRightOther] = @BreastRightOther 
      ,[SpeculumExam] = @SpeculumExam 
      ,[CarvixAppearance] = @CarvixAppearance 
      ,[MotionTenderness] = @MotionTenderness 
      ,[Uterus] = @Uterus 
      ,[UterusNl] = @UterusNl 
      ,[AdnexaLeft] = @AdnexaLeft 
      ,[AdnexaRight] = @AdnexaRight 
      ,[AdnexaDescription] = @AdnexaDescription
      ,[lungscondition] = @lungscondition 
      ,[LungLeftWheezes] = @LungLeftWheezes 
      ,[LungLeftRhonchi] = @LungLeftRhonchi 
      ,[LungLeftRales] = @LungLeftRales 
      ,[LungLeftPoorAirEntry] = @LungLeftPoorAirEntry 
      ,[LungLeftOther] = @LungLeftOther 
      ,[LungRightWheezes] = @LungRightWheezes 
      ,[LungRightRhonchi] = @LungRightRhonchi 
      ,[LungRightRales] = @LungRightRales 
      ,[LungRightPoorAirEntry] = @LungRightPoorAirEntry 
      ,[LungRightOther] = @LungRightOther 
 WHERE GynaePhysicalExamId=@GynaePhysicalExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_GynaeForm_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_GynaeForm_Delete]
@GynaeFormId int
as
Delete from GynaeForm where GynaeFormId=@GynaeFormId



GO
/****** Object:  StoredProcedure [dbo].[sp_GynaeForm_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GynaeForm_Insert]
 @PatientId int						=NULL
,@LastMenstrualDate date			=NULL
,@History nvarchar(max)				=NULL
,@LastMenstrualBegin date			=NULL
,@LastMenstrualEnd date				=NULL
,@NumberOfDaysBleeding bit			=NULL
,@Dayss int							=NULL
,@BleedingCondition bit	=NULL
,@Pain bit							=NULL
,@PainNotes nvarchar(max)			=NULL
,@CycleHistory nvarchar(max)		=NULL
,@Para nvarchar(50)					=NULL
,@Gravida nvarchar(50)				=NULL
,@Abortions int						=NULL
,@LastBabyBorn nvarchar(50)			=NULL
,@Infertility bit					=NULL
,@MarriedYears decimal(4,0)			=NULL
,@Husband nvarchar(max)				=NULL
,@HistoryAndTestsWife nvarchar(max) =NULL
,@OtherMedicalHistory nvarchar(max)	=NULL
,@CurrentMedication nvarchar(max)	=NULL
,@ComplaintPain bit					=NULL
,@ComplaintBleeding bit				=NULL
,@ComplaintDischarge bit			=NULL
,@ComplaintUrineBurning bit			=NULL
,@ComplaintSeizures bit				=NULL
,@ComplaintFits bit					=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO  GynaeForm
           ([PatientId]
           ,[LastMenstrualDate]
           ,[History]
           ,[LastMenstrualBegin]
           ,[LastMenstrualEnd]
           ,[NumberOfDaysBleeding]
           ,[Dayss]
           ,[BleedingCondition]
           ,[Pain]
           ,[PainNotes]
           ,[CycleHistory]
           ,[Para]
           ,[Gravida]
           ,[Abortions]
           ,[LastBabyBorn]
           ,[Infertility]
           ,[MarriedYears]
           ,[Husband]
		   ,[HistoryAndTestsWife]
           ,[OtherMedicalHistory]
           ,[CurrentMedication]
           ,[ComplaintPain]
           ,[ComplaintBleeding]
           ,[ComplaintDischarge]
           ,[ComplaintUrineBurning]
           ,[ComplaintSeizures]
           ,[ComplaintFits])
     VALUES
           (@PatientId						
           ,@LastMenstrualDate 				
           ,@History 				
           ,@LastMenstrualBegin 			
           ,@LastMenstrualEnd 				
           ,@NumberOfDaysBleeding 
           ,@Dayss 
           ,@BleedingCondition 	
           ,@Pain 
           ,@PainNotes 
           ,@CycleHistory 
           ,@Para 
           ,@Gravida 
           ,@Abortions 
           ,@LastBabyBorn
           ,@Infertility 
           ,@MarriedYears 		
           ,@Husband 
		   ,@HistoryAndTestsWife				
           ,@OtherMedicalHistory 	
           ,@CurrentMedication 	
           ,@ComplaintPain 				
           ,@ComplaintBleeding 			
           ,@ComplaintDischarge 			
           ,@ComplaintUrineBurning 			
           ,@ComplaintSeizures 				
           ,@ComplaintFits 					
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_GynaeForm_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GynaeForm_SelectAll]
as
SELECT        GynaeForm.GynaeFormId,PatientInfo.PatientName,  GynaeForm.LastMenstrualDate, GynaeForm.History, GynaeForm.LastMenstrualBegin, GynaeForm.LastMenstrualEnd, GynaeForm.NumberOfDaysBleeding, 
                         GynaeForm.Dayss, GynaeForm.BleedingCondition, GynaeForm.Pain, GynaeForm.PainNotes, GynaeForm.CycleHistory, GynaeForm.Para, GynaeForm.Gravida, GynaeForm.Abortions, GynaeForm.LastBabyBorn, 
                         GynaeForm.Infertility, GynaeForm.MarriedYears, GynaeForm.Husband,GynaeForm.HistoryAndTestsWife, GynaeForm.OtherMedicalHistory, GynaeForm.CurrentMedication, GynaeForm.ComplaintPain, GynaeForm.ComplaintBleeding, 
                         GynaeForm.ComplaintUrineBurning, GynaeForm.ComplaintDischarge, GynaeForm.ComplaintSeizures, GynaeForm.ComplaintFits
FROM            GynaeForm INNER JOIN
                         PatientInfo ON GynaeForm.PatientId = PatientInfo.PatientId order by GynaeForm.GynaeFormId desc




GO
/****** Object:  StoredProcedure [dbo].[sp_GynaeForm_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GynaeForm_SelectByID]
@GynaeFormId int
as
SELECT        G.GynaeFormId,G.PatientId,PatientInfo.PatientName,  G.LastMenstrualDate, G.History, G.LastMenstrualBegin, G.LastMenstrualEnd, G.NumberOfDaysBleeding, 
                         G.Dayss, G.BleedingCondition, G.Pain, G.PainNotes, G.CycleHistory, G.Para, G.Gravida, G.Abortions, G.LastBabyBorn, 
                         G.Infertility, G.MarriedYears, G.Husband,G.HistoryAndTestsWife, G.OtherMedicalHistory, G.CurrentMedication, G.ComplaintPain, G.ComplaintBleeding, 
                         G.ComplaintUrineBurning, G.ComplaintDischarge, G.ComplaintSeizures, G.ComplaintFits
FROM            GynaeForm G INNER JOIN
                         PatientInfo ON G.PatientId = PatientInfo.PatientId
						 where G.GynaeFormId=@GynaeFormId



GO
/****** Object:  StoredProcedure [dbo].[sp_GynaeForm_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GynaeForm_Update]
 @GynaeFormId int
,@PatientId int						=NULL
,@LastMenstrualDate date			=NULL
,@History nvarchar(max)				=NULL
,@LastMenstrualBegin date			=NULL
,@LastMenstrualEnd date				=NULL
,@NumberOfDaysBleeding bit			=NULL
,@Dayss int							=NULL
,@BleedingCondition bit	=NULL
,@Pain bit							=NULL
,@PainNotes nvarchar(max)			=NULL
,@CycleHistory nvarchar(max)		=NULL
,@Para nvarchar(50)					=NULL
,@Gravida nvarchar(50)				=NULL
,@Abortions int						=NULL
,@LastBabyBorn nvarchar(50)			=NULL
,@Infertility bit					=NULL
,@MarriedYears decimal(4,0)			=NULL
,@Husband nvarchar(max)				=NULL
,@HistoryAndTestsWife nvarchar(max) =NULL
,@OtherMedicalHistory nvarchar(max)	=NULL
,@CurrentMedication nvarchar(max)	=NULL
,@ComplaintPain bit					=NULL
,@ComplaintBleeding bit				=NULL
,@ComplaintDischarge bit			=NULL
,@ComplaintUrineBurning bit			=NULL
,@ComplaintSeizures bit				=NULL
,@ComplaintFits bit					=NULL
as
begin
UPDATE GynaeForm
   SET [PatientId] = @PatientId 
      ,[LastMenstrualDate] = @LastMenstrualDate 
      ,[History] = @History 
      ,[LastMenstrualBegin] = @LastMenstrualBegin
      ,[LastMenstrualEnd] = @LastMenstrualEnd 
      ,[NumberOfDaysBleeding] = @NumberOfDaysBleeding 
      ,[Dayss] = @Dayss 
      ,[BleedingCondition] = @BleedingCondition 
      ,[Pain] = @Pain 
      ,[PainNotes] = @PainNotes 
      ,[CycleHistory] = @CycleHistory 
      ,[Para] = @Para 
      ,[Gravida] = @Gravida 
      ,[Abortions] = @Abortions 
      ,[LastBabyBorn] = @LastBabyBorn 
      ,[Infertility] = @Infertility 
      ,[MarriedYears] = @MarriedYears 
      ,[Husband] = @Husband 
	  ,[HistoryAndTestsWife]=@HistoryAndTestsWife
      ,[OtherMedicalHistory] = @OtherMedicalHistory 
      ,[CurrentMedication] = @CurrentMedication 
      ,[ComplaintPain] = @ComplaintPain 
      ,[ComplaintBleeding] = @ComplaintBleeding 
      ,[ComplaintDischarge] = @ComplaintDischarge 
      ,[ComplaintUrineBurning] = @ComplaintUrineBurning 
      ,[ComplaintSeizures] = @ComplaintSeizures
      ,[ComplaintFits] = @ComplaintFits 
 WHERE GynaeFormId=@GynaeFormId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[sp_Labtest_Delete]
@TestId int
as
Delete from PreNatal_LabTest where TestId=@TestId




GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Labtest_Insert]
 @PatientId int						
,@CurrentEgaWeek nvarchar(50)		=NULL
,@VisitNo nvarchar(100)				=NULL
,@CheckupOf nvarchar(100) =NULL
,@Hgb nvarchar(50)					=NULL
,@BloodGroup nvarchar(50)			=NULL
,@HepB bit							=NULL
,@Protein nvarchar(50)				=NULL
,@Glucose nvarchar(50)				=NULL
,@BloodSugar nvarchar(50)			=NULL
,@WBC nvarchar(50)					=NULL
,@GramStain nvarchar(50)			=NULL
,@Keytone nvarchar(50)				=NULL
,@Blood nvarchar(50)				=NULL
,@Nitrite bit						=NULL
,@SpecificGravity nvarchar(50)		=NULL
,@PrenatalUltrasound nvarchar(max)	=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO [dbo].[PreNatal_LabTest]
           ([PatientId]
           ,[CurrentEgaWeek]
           ,[VisitNo]
		   ,[CheckupOf]
           ,[Hgb]
           ,[BloodGroup]
           ,[HepB]
           ,[Protein]
           ,[Glucose]
           ,[BloodSugar]
           ,[WBC]
           ,[GramStain]
           ,[Keytone]
           ,[Blood]
           ,[Nitrite]
           ,[SpecificGravity]
           ,[PrenatalUltrasound]
		   )
		   VALUES
          (@PatientId			
           ,@CurrentEgaWeek 
           ,@VisitNo
		   ,@CheckupOf 
           ,@Hgb 
           ,@BloodGroup 
           ,@HepB
           ,@Protein 
           ,@Glucose 
           ,@BloodSugar 
           ,@WBC 
           ,@GramStain 
           ,@Keytone 
           ,@Blood 
           ,@Nitrite 
           ,@SpecificGravity 
           ,@PrenatalUltrasound 
		   )
        set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec sp_Labtest_Populate 2
CREATE proc [dbo].[sp_Labtest_Populate]
@MrNumber bigint
as
SELECT        LT.TestId, LT.PatientId, LT.CurrentEgaWeek, LT.VisitNo, LT.CheckupOf, LT.Hgb, LT.BloodGroup, LT.HepB, LT.Protein, LT.Glucose, LT.BloodSugar, LT.WBC, LT.GramStain, LT.Keytone, LT.Blood, LT.Nitrite, LT.SpecificGravity, 
                         LT.PrenatalUltrasound, P.MrNumber
FROM            PreNatal_LabTest AS LT INNER JOIN
                         PatientInfo AS P ON LT.PatientId = P.PatientId where P.MrNumber=@MrNumber




GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Labtest_SelectAll]
as
SELECT        PreNatal_LabTest.TestId, PreNatal_LabTest.PatientId,PreNatal_LabTest.CheckupOf, PatientInfo.PatientName, PreNatal_LabTest.CurrentEgaWeek, PreNatal_LabTest.VisitNo, PreNatal_LabTest.Hgb, PreNatal_LabTest.BloodGroup, PreNatal_LabTest.HepB, PreNatal_LabTest.Protein, 
                         PreNatal_LabTest.Glucose, PreNatal_LabTest.BloodSugar, PreNatal_LabTest.WBC, PreNatal_LabTest.GramStain, PreNatal_LabTest.Keytone, PreNatal_LabTest.Blood, PreNatal_LabTest.Nitrite, 
                         PreNatal_LabTest.SpecificGravity, PreNatal_LabTest.PrenatalUltrasound
FROM            PatientInfo INNER JOIN
                         PreNatal_LabTest ON PatientInfo.PatientId = PreNatal_LabTest.PatientId order by PreNatal_LabTest.TestId desc





GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Labtest_SelectByID]
@TestId int
as
SELECT        PreNatal_LabTest.TestId,PreNatal_LabTest.PatientId, PatientInfo.PatientName, PreNatal_LabTest.CurrentEgaWeek, PreNatal_LabTest.VisitNo,PreNatal_LabTest.CheckupOf, PreNatal_LabTest.Hgb, PreNatal_LabTest.BloodGroup, PreNatal_LabTest.HepB, PreNatal_LabTest.Protein, 
                         PreNatal_LabTest.Glucose, PreNatal_LabTest.BloodSugar, PreNatal_LabTest.WBC, PreNatal_LabTest.GramStain, PreNatal_LabTest.Keytone, PreNatal_LabTest.Blood, PreNatal_LabTest.Nitrite, 
                         PreNatal_LabTest.SpecificGravity, PreNatal_LabTest.PrenatalUltrasound
FROM            PatientInfo INNER JOIN
                         PreNatal_LabTest ON PatientInfo.PatientId = PreNatal_LabTest.PatientId where PreNatal_LabTest.TestId=@TestId




GO
/****** Object:  StoredProcedure [dbo].[sp_Labtest_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Labtest_Update]
 @TestId int
,@PatientId int						=NULL
,@CurrentEgaWeek nvarchar(50)		=NULL
,@VisitNo nvarchar(100)				=NULL
,@CheckupOf nvarchar(100) = NULL
,@Hgb nvarchar(50)					=NULL
,@BloodGroup nvarchar(50)			=NULL
,@HepB bit							=NULL
,@Protein nvarchar(50)				=NULL
,@Glucose nvarchar(50)				=NULL
,@BloodSugar nvarchar(50)			=NULL
,@WBC nvarchar(50)					=NULL
,@GramStain nvarchar(50)			=NULL
,@Keytone nvarchar(50)				=NULL
,@Blood nvarchar(50)				=NULL
,@Nitrite bit						=NULL
,@SpecificGravity nvarchar(50)		=NULL
,@PrenatalUltrasound nvarchar(max)	=NULL
as
begin
UPDATE PreNatal_LabTest
   SET [PatientId] = @PatientId 
      ,[CurrentEgaWeek] = @CurrentEgaWeek 
      ,[VisitNo] = @VisitNo 
	  ,[CheckupOf]=@CheckupOf
      ,[Hgb] = @Hgb 
      ,[BloodGroup] = @BloodGroup 
      ,[HepB] = @HepB 
      ,[Protein] = @Protein 
      ,[Glucose] = @Glucose 
      ,[BloodSugar] = @BloodSugar 
      ,[WBC] = @WBC 
      ,[GramStain] = @GramStain 
      ,[Keytone] = @Keytone 
      ,[Blood] = @Blood 
      ,[Nitrite] = @Nitrite
      ,[SpecificGravity] = @SpecificGravity 
      ,[PrenatalUltrasound] = @PrenatalUltrasound
 WHERE TestId=@TestId 
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Medication_Delete]
@PreNatalMedicationId int
as
begin
Delete from PreNatal_Medication WHERE PreNatalMedicationId=@PreNatalMedicationId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Medication_Insert]
 @PatientId int
,@VisitNo nvarchar(100)  =NULL
,@CheckupOf nvarchar(100)=NULL
,@PreNatalVitamins bit	 =NULL
,@TT bit				 =NULL
,@Calcium bit			 =NULL
,@HepBVaccine bit		 =NULL
,@ReviewDangerSigns bit	 =NULL
,@Advice nvarchar(500)	 =NULL
,@Error bit=null output
,@Message nvarchar(200)=null output
,@ID int output
as
begin
INSERT INTO [dbo].[PreNatal_Medication]
           ([PatientId]
           ,[VisitNo]
		   ,[CheckupOf]
           ,[PreNatalVitamins]
           ,[TT]
           ,[Calcium]
           ,[HepBVaccine]
           ,[ReviewDangerSigns]
           ,[Advice])
     VALUES
           (@PatientId
           ,@VisitNo
		   ,@CheckupOf
           ,@PreNatalVitamins
           ,@TT
           ,@Calcium 
           ,@HepBVaccine 
           ,@ReviewDangerSigns
           ,@Advice
		   )

		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_Medication_Populate 1
create proc [dbo].[sp_Medication_Populate]
@MrNumber bigint
as
begin
SELECT        M.PreNatalMedicationId, M.PatientId, M.VisitNo, M.CheckupOf, M.PreNatalVitamins, M.TT, M.Calcium, M.HepBVaccine, M.ReviewDangerSigns, M.Advice, P.MrNumber
FROM            PreNatal_Medication AS M INNER JOIN
                         PatientInfo AS P ON M.PatientId = P.PatientId where p.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Medication_SelectAll]
as
begin
SELECT        PreNatal_Medication.PreNatalMedicationId, PatientInfo.PatientName, PreNatal_Medication.VisitNo,PreNatal_Medication.CheckupOf, PreNatal_Medication.PreNatalVitamins, PreNatal_Medication.TT, PreNatal_Medication.Calcium, 
              PreNatal_Medication.HepBVaccine, PreNatal_Medication.ReviewDangerSigns, PreNatal_Medication.Advice
FROM          PatientInfo INNER JOIN
              PreNatal_Medication ON PatientInfo.PatientId = PreNatal_Medication.PatientId order by  PreNatal_Medication.PreNatalMedicationId desc

end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Medication_SelectByID]
@PreNatalMedicationId int
as
begin
SELECT        PreNatal_Medication.PreNatalMedicationId,PreNatal_Medication.PatientId, PatientInfo.PatientName, PreNatal_Medication.VisitNo,PreNatal_Medication.CheckupOf, PreNatal_Medication.PreNatalVitamins, PreNatal_Medication.TT, PreNatal_Medication.Calcium, 
              PreNatal_Medication.HepBVaccine, PreNatal_Medication.ReviewDangerSigns, PreNatal_Medication.Advice
FROM          PatientInfo INNER JOIN
              PreNatal_Medication ON PatientInfo.PatientId = PreNatal_Medication.PatientId
 where  PreNatal_Medication.PreNatalMedicationId=@PreNatalMedicationId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Medication_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Medication_Update]
 @PreNatalMedicationId int
,@PatientId int				=NULL
,@VisitNo nvarchar(100)		=NULL
,@CheckupOf nvarchar(100) =NULL
,@PreNatalVitamins bit		=NULL
,@TT bit					=NULL
,@Calcium bit				=NULL
,@HepBVaccine bit			=NULL
,@ReviewDangerSigns bit		=NULL
,@Advice nvarchar(500)		=NULL
as
begin
UPDATE  PreNatal_Medication
   SET [PatientId] = @PatientId 
      ,[VisitNo] = @VisitNo
	  ,[CheckupOf]=@CheckupOf
      ,[PreNatalVitamins] = @PreNatalVitamins
      ,[TT] = @TT
      ,[Calcium] = @Calcium 
      ,[HepBVaccine] = @HepBVaccine
      ,[ReviewDangerSigns] = @ReviewDangerSigns
      ,[Advice] = @Advice 
 WHERE PreNatalMedicationId=@PreNatalMedicationId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Paeds_PhysicalExamination_Delete]
 @PaedsExamId int
as
begin
Delete from Paeds_PhysicalExamination where PaedsExamId=@PaedsExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Paeds_PhysicalExamination_Insert]
 @PatientId int								=NULL
,@DOB date									=NULL
,@Temperature decimal(4,0)					=NULL
,@BP decimal(4,0)							=NULL
,@Pulse decimal(4,0)						=NULL
,@Weight decimal(4,0)						=NULL
,@WeightPercentile nvarchar(50)				=NULL
,@Height decimal(4,0)						=NULL
,@HeightPercentile nvarchar(50)				=NULL
,@HC nvarchar(50)							=NULL
,@HCPercentile nvarchar(50)					=NULL
,@Oxygen nvarchar(50)						=NULL
,@RR nvarchar(50)							=NULL
,@Alert bit									=NULL
,@ListLess bit								=NULL
,@Jaundice bit								=NULL
,@Active bit								=NULL
,@Agitated bit								=NULL
,@Pale bit									=NULL
,@Smiling bit								=NULL
,@Convulsions bit							=NULL
,@Crying bit								=NULL
,@NonResponse bit							=NULL
,@Lethargic bit								=NULL
,@ColorPink bit								=NULL
,@Other bit									=NULL
,@Head nvarchar(50)							=NULL
,@AntFontAnelle nvarchar(50)				=NULL
,@PostFontAnelle nvarchar(50)				=NULL
,@Sutures nvarchar(50)						=NULL
,@Cephalohematoma bit						=NULL
,@HeadOther nvarchar(150)					=NULL
,@EyePupils nvarchar(50)					=NULL
,@EyeSclera nvarchar(50)					=NULL
,@EyeConjuctiva nvarchar(50)				=NULL
,@EyeDischargeLeft nvarchar(50)				=NULL
,@EyeDischargeRight nvarchar(50)			=NULL
,@EyeRedReflex bit							=NULL
,@EyeOther nvarchar(150)					=NULL
,@EarPennaeLeft nvarchar(50)				=NULL
,@EarPennaeRight nvarchar(50)				=NULL
,@EarPennaeNotes nvarchar(50)				=NULL
,@EarCanalLeft nvarchar(50)					=NULL
,@EarCanalRight nvarchar(50)				=NULL
,@EarDischarge nvarchar(50)					=NULL
,@EarOther nvarchar(150)					=NULL
,@Mouth nvarchar(50)						=NULL
,@MouthGums nvarchar(50)					=NULL
,@MouthTeeth nvarchar(50)					=NULL
,@MouthOther nvarchar(50)					=NULL
,@Throat nvarchar(50)						=NULL
,@Tonsils nvarchar(50)						=NULL
,@ThroatOther nvarchar(50)					=NULL
,@Nose nvarchar(50)							=NULL
,@NoseDischarge nvarchar(50)				=NULL
,@Neck nvarchar(50)							=NULL
,@SwollenLymphNode nvarchar(50)				=NULL
,@NeckLeft nvarchar(50)						=NULL
,@NeckRight nvarchar(50)					=NULL
,@NeckOther nvarchar(150)					=NULL
,@TMLeftNormal bit							=NULL
,@TMLeftWhite bit							=NULL
,@TMLeftRed bit								=NULL
,@TMLeftYellow bit							=NULL
,@TMLeftBulging bit							=NULL
,@TMLeftMobile bit							=NULL
,@TMLeftNonMobile bit						=NULL
,@TMLeftRaptured bit						=NULL
,@TMLeftOther nvarchar(50)					=NULL
,@TMRightNormal bit							=NULL
,@TMRightWhite bit							=NULL
,@TMRightRed bit							=NULL
,@TMRightYellow bit							=NULL
,@TMRightBulging bit						=NULL
,@TMRightMobile bit							=NULL
,@TMRightNonMobile bit						=NULL
,@TMRightRaptured bit						=NULL
,@TMDischarge nvarchar(50)					=NULL
,@TMRightOther nvarchar(150)				=NULL
,@LungsRespiration nvarchar(50)				=NULL
,@LungLeftWheezes bit						=NULL
,@LungLeftRhonchi bit						=NULL
,@LungLeftRales bit							=NULL
,@LungLeftPoorAirEntry bit					=NULL
,@LungLeftDiminshed bit						=NULL
,@LungRightWheezes bit						=NULL
,@LungRightRhonchi bit						=NULL
,@LungRightRales bit						=NULL
,@LungRightPoorAirEntry bit					=NULL
,@LungRightDiminished bit					=NULL
,@LungOther nvarchar(max)					=NULL
,@HeartMurmur bit							=NULL
,@MurmurRate nvarchar(50)					=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartRythm nvarchar(50)					=NULL
,@HeartOther nvarchar(250)					=NULL
,@AbdAbdomen nvarchar(50)					=NULL
,@AbdTender nvarchar(50)					=NULL
,@AbdMassQuality nvarchar(50)				=NULL
,@AbdRebound bit							=NULL
,@AbdUmbilicalHernia nvarchar(50)			=NULL
,@AbdInguinalHernialLeft nvarchar(50)		=NULL
,@AbdInguinalHernialRight nvarchar(50)		=NULL
,@UmbClean nvarchar(50)						=NULL
,@UmdDishcharge nvarchar(50)				=NULL
,@UmbOther nvarchar(150)					=NULL
,@GentMale nvarchar(50)						=NULL
,@GentHydrocele bit							=NULL
,@GentUndescendedLeft bit					=NULL
,@GentUndescendedRight bit					=NULL
,@GentHerniaLeft nvarchar(50)				=NULL
,@GentHerniaRight nvarchar(50)				=NULL
,@GentPenis nvarchar(50)					=NULL
,@GentMicro bit								=NULL
,@GentMeatus nvarchar(50)					=NULL
,@GentDishcharge nvarchar(50)				=NULL
,@GentMaleOther nvarchar(150)				=NULL
,@GentFemale nvarchar(50)					=NULL
,@GentLabia nvarchar(50)					=NULL
,@GentUrethra nvarchar(50)					=NULL
,@GentDischarge nvarchar(50)				=NULL
,@GentMassLeft nvarchar(50)					=NULL
,@GentMassRight nvarchar(50)				=NULL
,@GentSize decimal(18,0)					=NULL
,@GentOtherFemale nvarchar(150)				=NULL
,@MuscArmsLegs nvarchar(50)					=NULL
,@MuscLeftWeekness bit						=NULL
,@MuscLeftSwelling bit						=NULL
,@MuscLeftToneIncDec bit					=NULL
,@MuscLeftTender bit						=NULL
,@MuscLeftImmobile bit						=NULL
,@MuscLeftDecStrength bit					=NULL
,@MuscRightWeekness bit						=NULL
,@MuscRightSwelling bit						=NULL
,@MuscRightToneIncDec bit					=NULL
,@MuscRightTender bit						=NULL
,@MuscRightImmobile bit						=NULL
,@MuscRightDecStrength bit					=NULL
,@MuscLaceration bit						=NULL
,@MuscBruise bit							=NULL
,@MuscOther nvarchar(150)					=NULL
,@FeetHandSymmetry nvarchar(50)				=NULL
,@FeetHandLeftWeekness bit					=NULL
,@FeetHandLeftSwelling bit					=NULL
,@FeetHandLeftTender bit					=NULL
,@FeetHandLeftImmobile bit					=NULL
,@FeetHandLeftDecStrength bit				=NULL
,@FeetHandLeftLaceration bit				=NULL
,@FeetHandLeftBruise bit					=NULL
,@FeetHandRightWeekness bit					=NULL
,@FeetHandRightSwelling bit					=NULL
,@FeetHandRightTender bit					=NULL
,@FeetHandRightImmobile bit					=NULL
,@FeetHandRightDecStrength bit				=NULL
,@FeetHandRightLaceration bit				=NULL
,@FeetHandRightBruise bit					=NULL
,@FeetHandAbleToWalk bit					=NULL
,@FeetToes nvarchar(50)						=NULL
,@FeetOther nvarchar(150)					=NULL
,@NeuroAwake bit							=NULL
,@NeuroAlert bit							=NULL
,@NeuroActive bit							=NULL
,@NeuroDecConsciousness bit					=NULL
,@NeuroAgitated bit							=NULL
,@NeuroConvelsions bit						=NULL
,@NeuroListLess bit							=NULL
,@NeuroLethargic bit						=NULL
,@NeuroAQAppropriately bit					=NULL
,@NeuroReflexLeft nvarchar(50)				=NULL
,@NeuroReflexRight nvarchar(50)				=NULL
,@NeuroDevelopment nvarchar(50)				=NULL
,@NeuroMotor bit							=NULL
,@NeuroLanguage bit							=NULL
,@NeuroSocial bit							=NULL
,@NeuroOther nvarchar(max)					=NULL
,@Skin nvarchar(50)							=NULL
,@RashFlate bit								=NULL
,@RashRaised bit							=NULL
,@RashErythema bit							=NULL
,@RashMacules bit							=NULL
,@RashPapules bit							=NULL
,@RashPetechiae bit							=NULL
,@RashSize decimal(18,0)					=NULL
,@RashOther nvarchar(150)					=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO Paeds_PhysicalExamination
            ([PatientId]
		   ,[DOB]
           ,[Temperature]
           ,[BP]
           ,[Pulse]
           ,[Weight]
           ,[WeightPercentile]
           ,[Height]
           ,[HeightPercentile]
           ,[HC]
           ,[HCPercentile]
           ,[Oxygen]
           ,[RR]
           ,[Alert]
           ,[ListLess]
           ,[Jaundice]
           ,[Active]
           ,[Agitated]
           ,[Pale]
           ,[Smiling]
           ,[Convulsions]
           ,[Crying]
           ,[NonResponse]
           ,[Lethargic]
           ,[ColorPink]
           ,[Other]
           ,[Head]
           ,[AntFontAnelle]
           ,[PostFontAnelle]
           ,[Sutures]
           ,[Cephalohematoma]
           ,[HeadOther]
           ,[EyePupils]
           ,[EyeSclera]
           ,[EyeConjuctiva]
           ,[EyeDischargeLeft]
           ,[EyeDischargeRight]
           ,[EyeRedReflex]
           ,[EyeOther]
           ,[EarPennaeLeft]
           ,[EarPennaeRight]
           ,[EarPennaeNotes]
           ,[EarCanalLeft]
           ,[EarCanalRight]
           ,[EarDischarge]
           ,[EarOther]
           ,[Mouth]
           ,[MouthGums]
           ,[MouthTeeth]
           ,[MouthOther]
           ,[Throat]
           ,[Tonsils]
           ,[ThroatOther]
           ,[Nose]
           ,[NoseDischarge]
           ,[Neck]
           ,[SwollenLymphNode]
           ,[NeckLeft]
           ,[NeckRight]
           ,[NeckOther]
           ,[TMLeftNormal]
           ,[TMLeftWhite]
           ,[TMLeftRed]
           ,[TMLeftYellow]
           ,[TMLeftBulging]
           ,[TMLeftMobile]
           ,[TMLeftNonMobile]
           ,[TMLeftRaptured]
           ,[TMLeftOther]
           ,[TMRightNormal]
           ,[TMRightWhite]
           ,[TMRightRed]
           ,[TMRightYellow]
           ,[TMRightBulging]
           ,[TMRightMobile]
           ,[TMRightNonMobile]
           ,[TMRightRaptured]
           ,[TMDischarge]
           ,[TMRightOther]
           ,[LungsRespiration]
           ,[LungLeftWheezes]
           ,[LungLeftRhonchi]
           ,[LungLeftRales]
           ,[LungLeftPoorAirEntry]
           ,[LungLeftDiminshed]
           ,[LungRightWheezes]
           ,[LungRightRhonchi]
           ,[LungRightRales]
           ,[LungRightPoorAirEntry]
           ,[LungRightDiminished]
           ,[LungOther]
           ,[HeartMurmur]
           ,[MurmurRate]
           ,[HeartRate]
           ,[HeartRythm]
           ,[HeartOther]
           ,[AbdAbdomen]
           ,[AbdTender]
           ,[AbdMassQuality]
           ,[AbdRebound]
           ,[AbdUmbilicalHernia]
           ,[AbdInguinalHernialLeft]
           ,[AbdInguinalHernialRight]
           ,[UmbClean]
           ,[UmdDishcharge]
           ,[UmbOther]
           ,[GentMale]
           ,[GentHydrocele]
           ,[GentUndescendedLeft]
           ,[GentUndescendedRight]
           ,[GentHerniaLeft]
           ,[GentHerniaRight]
           ,[GentPenis]
           ,[GentMicro]
           ,[GentMeatus]
           ,[GentDishcharge]
           ,[GentMaleOther]
           ,[GentFemale]
           ,[GentLabia]
           ,[GentUrethra]
           ,[GentDischarge]
           ,[GentMassLeft]
           ,[GentMassRight]
           ,[GentSize]
           ,[GentOtherFemale]
           ,[MuscArmsLegs]
           ,[MuscLeftWeekness]
           ,[MuscLeftSwelling]
           ,[MuscLeftToneIncDec]
           ,[MuscLeftTender]
           ,[MuscLeftImmobile]
           ,[MuscLeftDecStrength]
           ,[MuscRightWeekness]
           ,[MuscRightSwelling]
           ,[MuscRightToneIncDec]
           ,[MuscRightTender]
           ,[MuscRightImmobile]
           ,[MuscRightDecStrength]
           ,[MuscLaceration]
           ,[MuscBruise]
           ,[MuscOther]
           ,[FeetHandSymmetry]
           ,[FeetHandLeftWeekness]
           ,[FeetHandLeftSwelling]
           ,[FeetHandLeftTender]
           ,[FeetHandLeftImmobile]
           ,[FeetHandLeftDecStrength]
           ,[FeetHandLeftLaceration]
           ,[FeetHandLeftBruise]
           ,[FeetHandRightWeekness]
           ,[FeetHandRightSwelling]
           ,[FeetHandRightTender]
           ,[FeetHandRightImmobile]
           ,[FeetHandRightDecStrength]
           ,[FeetHandRightLaceration]
           ,[FeetHandRightBruise]
           ,[FeetHandAbleToWalk]
           ,[FeetToes]
           ,[FeetOther]
           ,[NeuroAwake]
           ,[NeuroAlert]
           ,[NeuroActive]
           ,[NeuroDecConsciousness]
           ,[NeuroAgitated]
           ,[NeuroConvelsions]
           ,[NeuroListLess]
           ,[NeuroLethargic]
           ,[NeuroAQAppropriately]
           ,[NeuroReflexLeft]
           ,[NeuroReflexRight]
           ,[NeuroDevelopment]
           ,[NeuroMotor]
           ,[NeuroLanguage]
           ,[NeuroSocial]
           ,[NeuroOther]
           ,[Skin]
           ,[RashFlate]
           ,[RashRaised]
           ,[RashErythema]
           ,[RashMacules]
           ,[RashPapules]
           ,[RashPetechiae]
           ,[RashSize]
           ,[RashOther])
   VALUES
           (
		    @PatientId
		   ,@DOB 
           ,@Temperature 
           ,@BP 
           ,@Pulse
           ,@Weight 
           ,@WeightPercentile 
           ,@Height 
           ,@HeightPercentile 
           ,@HC 
           ,@HCPercentile 
           ,@Oxygen 
           ,@RR 
           ,@Alert 
           ,@ListLess 
           ,@Jaundice 
           ,@Active 
           ,@Agitated 
           ,@Pale 
           ,@Smiling 
           ,@Convulsions 
           ,@Crying 
           ,@NonResponse 
           ,@Lethargic 
           ,@ColorPink 
           ,@Other 
           ,@Head 
           ,@AntFontAnelle 
           ,@PostFontAnelle 
           ,@Sutures 
           ,@Cephalohematoma 
           ,@HeadOther 
           ,@EyePupils 
           ,@EyeSclera 
           ,@EyeConjuctiva 
           ,@EyeDischargeLeft 
           ,@EyeDischargeRight 
           ,@EyeRedReflex 
           ,@EyeOther
           ,@EarPennaeLeft 
           ,@EarPennaeRight 
           ,@EarPennaeNotes 
           ,@EarCanalLeft 
           ,@EarCanalRight 
           ,@EarDischarge 
           ,@EarOther 
           ,@Mouth 
           ,@MouthGums 
           ,@MouthTeeth 
           ,@MouthOther 
           ,@Throat 
           ,@Tonsils 
           ,@ThroatOther 
           ,@Nose 
           ,@NoseDischarge 
           ,@Neck 
           ,@SwollenLymphNode 
           ,@NeckLeft 
           ,@NeckRight 
           ,@NeckOther 
           ,@TMLeftNormal 
           ,@TMLeftWhite 
           ,@TMLeftRed 
           ,@TMLeftYellow 
           ,@TMLeftBulging 
           ,@TMLeftMobile 
           ,@TMLeftNonMobile 
           ,@TMLeftRaptured 
           ,@TMLeftOther 
           ,@TMRightNormal 
           ,@TMRightWhite 
           ,@TMRightRed 
           ,@TMRightYellow 
           ,@TMRightBulging 
           ,@TMRightMobile 
           ,@TMRightNonMobile 
           ,@TMRightRaptured 
           ,@TMDischarge 
           ,@TMRightOther
           ,@LungsRespiration 
           ,@LungLeftWheezes 
           ,@LungLeftRhonchi 
           ,@LungLeftRales 
           ,@LungLeftPoorAirEntry 
           ,@LungLeftDiminshed 
           ,@LungRightWheezes 
           ,@LungRightRhonchi 
           ,@LungRightRales 
           ,@LungRightPoorAirEntry 
           ,@LungRightDiminished 
           ,@LungOther
           ,@HeartMurmur 
           ,@MurmurRate 
           ,@HeartRate 
           ,@HeartRythm 
           ,@HeartOther
           ,@AbdAbdomen 
           ,@AbdTender 
           ,@AbdMassQuality 
           ,@AbdRebound 
           ,@AbdUmbilicalHernia 
           ,@AbdInguinalHernialLeft 
           ,@AbdInguinalHernialRight 
           ,@UmbClean 
           ,@UmdDishcharge 
           ,@UmbOther 
           ,@GentMale 
           ,@GentHydrocele 
           ,@GentUndescendedLeft 
           ,@GentUndescendedRight 
           ,@GentHerniaLeft 
           ,@GentHerniaRight 
           ,@GentPenis 
           ,@GentMicro 
           ,@GentMeatus 
           ,@GentDishcharge 
           ,@GentMaleOther 
           ,@GentFemale 
           ,@GentLabia 
           ,@GentUrethra 
           ,@GentDischarge 
           ,@GentMassLeft 
           ,@GentMassRight 
           ,@GentSize 
           ,@GentOtherFemale 
           ,@MuscArmsLegs 
           ,@MuscLeftWeekness 
           ,@MuscLeftSwelling 
           ,@MuscLeftToneIncDec 
           ,@MuscLeftTender 
           ,@MuscLeftImmobile 
           ,@MuscLeftDecStrength 
           ,@MuscRightWeekness 
           ,@MuscRightSwelling 
           ,@MuscRightToneIncDec 
           ,@MuscRightTender 
           ,@MuscRightImmobile 
           ,@MuscRightDecStrength 
           ,@MuscLaceration 
           ,@MuscBruise 
           ,@MuscOther 
           ,@FeetHandSymmetry 
           ,@FeetHandLeftWeekness 
           ,@FeetHandLeftSwelling 
           ,@FeetHandLeftTender 
           ,@FeetHandLeftImmobile 
           ,@FeetHandLeftDecStrength 
           ,@FeetHandLeftLaceration 
           ,@FeetHandLeftBruise 
           ,@FeetHandRightWeekness 
           ,@FeetHandRightSwelling 
           ,@FeetHandRightTender 
           ,@FeetHandRightImmobile 
           ,@FeetHandRightDecStrength 
           ,@FeetHandRightLaceration 
           ,@FeetHandRightBruise 
           ,@FeetHandAbleToWalk 
           ,@FeetToes 
           ,@FeetOther
           ,@NeuroAwake 
           ,@NeuroAlert 
           ,@NeuroActive 
           ,@NeuroDecConsciousness 
           ,@NeuroAgitated 
           ,@NeuroConvelsions 
           ,@NeuroListLess 
           ,@NeuroLethargic 
           ,@NeuroAQAppropriately 
           ,@NeuroReflexLeft 
           ,@NeuroReflexRight 
           ,@NeuroDevelopment 
           ,@NeuroMotor 
           ,@NeuroLanguage 
           ,@NeuroSocial 
           ,@NeuroOther 
           ,@Skin 
           ,@RashFlate 
           ,@RashRaised 
           ,@RashErythema 
           ,@RashMacules 
           ,@RashPapules 
           ,@RashPetechiae 
           ,@RashSize 
           ,@RashOther 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully ,@br/Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Paeds_PhysicalExamination_Populate]
 @MrNumber bigint
as
begin
SELECT        PPE.PaedsExamId, PPE.PatientId,P.PatientName,PPE.DOB, PPE.Temperature, PPE.BP, PPE.Pulse, PPE.Weight, PPE.WeightPercentile, PPE.Height, PPE.HeightPercentile, PPE.HC, PPE.HCPercentile, PPE.Oxygen, PPE.RR, PPE.Alert, PPE.ListLess, 
                         PPE.Jaundice, PPE.Active, PPE.Agitated, PPE.Pale, PPE.Smiling, PPE.Convulsions, PPE.Crying, PPE.NonResponse, PPE.Lethargic, PPE.ColorPink, PPE.Other, PPE.Head, PPE.AntFontAnelle, PPE.PostFontAnelle, PPE.Sutures, 
                         PPE.Cephalohematoma, PPE.HeadOther, PPE.EyePupils, PPE.EyeSclera, PPE.EyeConjuctiva, PPE.EyeDischargeLeft, PPE.EyeDischargeRight, PPE.EyeRedReflex, PPE.EyeOther, PPE.EarPennaeLeft, PPE.EarPennaeRight, 
                         PPE.EarPennaeNotes, PPE.EarCanalLeft, PPE.EarCanalRight, PPE.EarDischarge, PPE.EarOther, PPE.Mouth, PPE.MouthGums, PPE.MouthTeeth, PPE.MouthOther, PPE.Throat, PPE.Tonsils, PPE.ThroatOther, PPE.Nose, 
                         PPE.NoseDischarge, PPE.Neck, PPE.SwollenLymphNode, PPE.NeckLeft, PPE.NeckRight, PPE.NeckOther, PPE.TMLeftNormal, PPE.TMLeftWhite, PPE.TMLeftRed, PPE.TMLeftYellow, PPE.TMLeftBulging, PPE.TMLeftMobile, 
                         PPE.TMLeftNonMobile, PPE.TMLeftRaptured, PPE.TMLeftOther, PPE.TMRightNormal, PPE.TMRightWhite, PPE.TMRightRed, PPE.TMRightYellow, PPE.TMRightBulging, PPE.TMRightMobile, PPE.TMRightNonMobile, 
                         PPE.TMRightRaptured, PPE.TMDischarge, PPE.TMRightOther, PPE.LungsRespiration, PPE.LungLeftWheezes, PPE.LungLeftRhonchi, PPE.LungLeftRales, PPE.LungLeftPoorAirEntry, PPE.LungLeftDiminshed, 
                         PPE.LungRightWheezes, PPE.LungRightRhonchi, PPE.LungRightRales, PPE.LungRightPoorAirEntry, PPE.LungRightDiminished, PPE.LungOther, PPE.HeartMurmur, PPE.MurmurRate, PPE.HeartRate, PPE.HeartRythm, 
                         PPE.HeartOther, PPE.AbdAbdomen, PPE.AbdTender, PPE.AbdMassQuality, PPE.AbdRebound, PPE.AbdUmbilicalHernia, PPE.AbdInguinalHernialLeft, PPE.AbdInguinalHernialRight, PPE.UmbClean, PPE.UmdDishcharge, 
                         PPE.UmbOther, PPE.GentMale, PPE.GentHydrocele, PPE.GentUndescendedLeft, PPE.GentUndescendedRight, PPE.GentHerniaLeft, PPE.GentHerniaRight, PPE.GentPenis, PPE.GentMicro, PPE.GentMeatus, PPE.GentDishcharge, 
                         PPE.GentMaleOther, PPE.GentFemale, PPE.GentLabia, PPE.GentUrethra, PPE.GentDischarge, PPE.GentMassLeft, PPE.GentMassRight, PPE.GentSize, PPE.GentOtherFemale, PPE.MuscArmsLegs, PPE.MuscLeftWeekness, 
                         PPE.MuscLeftSwelling, PPE.MuscLeftToneIncDec, PPE.MuscLeftTender, PPE.MuscLeftImmobile, PPE.MuscLeftDecStrength, PPE.MuscRightWeekness, PPE.MuscRightSwelling, PPE.MuscRightToneIncDec, 
                         PPE.MuscRightTender, PPE.MuscRightImmobile, PPE.MuscRightDecStrength, PPE.MuscLaceration, PPE.MuscBruise, PPE.MuscOther, PPE.FeetHandSymmetry, PPE.FeetHandLeftWeekness, PPE.FeetHandLeftSwelling, 
                         PPE.FeetHandLeftTender, PPE.FeetHandLeftImmobile, PPE.FeetHandLeftDecStrength, PPE.FeetHandLeftLaceration, PPE.FeetHandLeftBruise, PPE.FeetHandRightWeekness, PPE.FeetHandRightSwelling, 
                         PPE.FeetHandRightTender, PPE.FeetHandRightImmobile, PPE.FeetHandRightDecStrength, PPE.FeetHandRightLaceration, PPE.FeetHandRightBruise, PPE.FeetHandAbleToWalk, PPE.FeetToes, PPE.FeetOther, PPE.NeuroAwake, 
                         PPE.NeuroAlert, PPE.NeuroActive, PPE.NeuroDecConsciousness, PPE.NeuroAgitated, PPE.NeuroConvelsions, PPE.NeuroListLess, PPE.NeuroLethargic, PPE.NeuroAQAppropriately, PPE.NeuroReflexLeft, PPE.NeuroReflexRight, 
                         PPE.NeuroDevelopment, PPE.NeuroMotor, PPE.NeuroLanguage, PPE.NeuroSocial, PPE.NeuroOther, PPE.Skin, PPE.RashFlate, PPE.RashRaised, PPE.RashErythema, PPE.RashMacules, PPE.RashPapules, PPE.RashPetechiae, 
                         PPE.RashSize, PPE.RashOther
FROM            Paeds_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId
						 where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Paeds_PhysicalExamination_SelectAll]
as
begin
SELECT        PPE.PaedsExamId, PPE.PatientId,P.PatientName,PPE.DOB, PPE.Temperature, PPE.BP, PPE.Pulse, PPE.Weight, PPE.WeightPercentile, PPE.Height, PPE.HeightPercentile, PPE.HC, PPE.HCPercentile, PPE.Oxygen, PPE.RR, PPE.Alert, PPE.ListLess, 
                         PPE.Jaundice, PPE.Active, PPE.Agitated, PPE.Pale, PPE.Smiling, PPE.Convulsions, PPE.Crying, PPE.NonResponse, PPE.Lethargic, PPE.ColorPink, PPE.Other, PPE.Head, PPE.AntFontAnelle, PPE.PostFontAnelle, PPE.Sutures, 
                         PPE.Cephalohematoma, PPE.HeadOther, PPE.EyePupils, PPE.EyeSclera, PPE.EyeConjuctiva, PPE.EyeDischargeLeft, PPE.EyeDischargeRight, PPE.EyeRedReflex, PPE.EyeOther, PPE.EarPennaeLeft, PPE.EarPennaeRight, 
                         PPE.EarPennaeNotes, PPE.EarCanalLeft, PPE.EarCanalRight, PPE.EarDischarge, PPE.EarOther, PPE.Mouth, PPE.MouthGums, PPE.MouthTeeth, PPE.MouthOther, PPE.Throat, PPE.Tonsils, PPE.ThroatOther, PPE.Nose, 
                         PPE.NoseDischarge, PPE.Neck, PPE.SwollenLymphNode, PPE.NeckLeft, PPE.NeckRight, PPE.NeckOther, PPE.TMLeftNormal, PPE.TMLeftWhite, PPE.TMLeftRed, PPE.TMLeftYellow, PPE.TMLeftBulging, PPE.TMLeftMobile, 
                         PPE.TMLeftNonMobile, PPE.TMLeftRaptured, PPE.TMLeftOther, PPE.TMRightNormal, PPE.TMRightWhite, PPE.TMRightRed, PPE.TMRightYellow, PPE.TMRightBulging, PPE.TMRightMobile, PPE.TMRightNonMobile, 
                         PPE.TMRightRaptured, PPE.TMDischarge, PPE.TMRightOther, PPE.LungsRespiration, PPE.LungLeftWheezes, PPE.LungLeftRhonchi, PPE.LungLeftRales, PPE.LungLeftPoorAirEntry, PPE.LungLeftDiminshed, 
                         PPE.LungRightWheezes, PPE.LungRightRhonchi, PPE.LungRightRales, PPE.LungRightPoorAirEntry, PPE.LungRightDiminished, PPE.LungOther, PPE.HeartMurmur, PPE.MurmurRate, PPE.HeartRate, PPE.HeartRythm, 
                         PPE.HeartOther, PPE.AbdAbdomen, PPE.AbdTender, PPE.AbdMassQuality, PPE.AbdRebound, PPE.AbdUmbilicalHernia, PPE.AbdInguinalHernialLeft, PPE.AbdInguinalHernialRight, PPE.UmbClean, PPE.UmdDishcharge, 
                         PPE.UmbOther, PPE.GentMale, PPE.GentHydrocele, PPE.GentUndescendedLeft, PPE.GentUndescendedRight, PPE.GentHerniaLeft, PPE.GentHerniaRight, PPE.GentPenis, PPE.GentMicro, PPE.GentMeatus, PPE.GentDishcharge, 
                         PPE.GentMaleOther, PPE.GentFemale, PPE.GentLabia, PPE.GentUrethra, PPE.GentDischarge, PPE.GentMassLeft, PPE.GentMassRight, PPE.GentSize, PPE.GentOtherFemale, PPE.MuscArmsLegs, PPE.MuscLeftWeekness, 
                         PPE.MuscLeftSwelling, PPE.MuscLeftToneIncDec, PPE.MuscLeftTender, PPE.MuscLeftImmobile, PPE.MuscLeftDecStrength, PPE.MuscRightWeekness, PPE.MuscRightSwelling, PPE.MuscRightToneIncDec, 
                         PPE.MuscRightTender, PPE.MuscRightImmobile, PPE.MuscRightDecStrength, PPE.MuscLaceration, PPE.MuscBruise, PPE.MuscOther, PPE.FeetHandSymmetry, PPE.FeetHandLeftWeekness, PPE.FeetHandLeftSwelling, 
                         PPE.FeetHandLeftTender, PPE.FeetHandLeftImmobile, PPE.FeetHandLeftDecStrength, PPE.FeetHandLeftLaceration, PPE.FeetHandLeftBruise, PPE.FeetHandRightWeekness, PPE.FeetHandRightSwelling, 
                         PPE.FeetHandRightTender, PPE.FeetHandRightImmobile, PPE.FeetHandRightDecStrength, PPE.FeetHandRightLaceration, PPE.FeetHandRightBruise, PPE.FeetHandAbleToWalk, PPE.FeetToes, PPE.FeetOther, PPE.NeuroAwake, 
                         PPE.NeuroAlert, PPE.NeuroActive, PPE.NeuroDecConsciousness, PPE.NeuroAgitated, PPE.NeuroConvelsions, PPE.NeuroListLess, PPE.NeuroLethargic, PPE.NeuroAQAppropriately, PPE.NeuroReflexLeft, PPE.NeuroReflexRight, 
                         PPE.NeuroDevelopment, PPE.NeuroMotor, PPE.NeuroLanguage, PPE.NeuroSocial, PPE.NeuroOther, PPE.Skin, PPE.RashFlate, PPE.RashRaised, PPE.RashErythema, PPE.RashMacules, PPE.RashPapules, PPE.RashPetechiae, 
                         PPE.RashSize, PPE.RashOther
FROM            Paeds_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId
						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Paeds_PhysicalExamination_SelectByID]
 @PaedsExamId int
as
begin
SELECT        PPE.PaedsExamId, PPE.PatientId,P.PatientName,PPE.DOB, PPE.Temperature, PPE.BP, PPE.Pulse, PPE.Weight, PPE.WeightPercentile, PPE.Height, PPE.HeightPercentile, PPE.HC, PPE.HCPercentile, PPE.Oxygen, PPE.RR, PPE.Alert, PPE.ListLess, 
                         PPE.Jaundice, PPE.Active, PPE.Agitated, PPE.Pale, PPE.Smiling, PPE.Convulsions, PPE.Crying, PPE.NonResponse, PPE.Lethargic, PPE.ColorPink, PPE.Other, PPE.Head, PPE.AntFontAnelle, PPE.PostFontAnelle, PPE.Sutures, 
                         PPE.Cephalohematoma, PPE.HeadOther, PPE.EyePupils, PPE.EyeSclera, PPE.EyeConjuctiva, PPE.EyeDischargeLeft, PPE.EyeDischargeRight, PPE.EyeRedReflex, PPE.EyeOther, PPE.EarPennaeLeft, PPE.EarPennaeRight, 
                         PPE.EarPennaeNotes, PPE.EarCanalLeft, PPE.EarCanalRight, PPE.EarDischarge, PPE.EarOther, PPE.Mouth, PPE.MouthGums, PPE.MouthTeeth, PPE.MouthOther, PPE.Throat, PPE.Tonsils, PPE.ThroatOther, PPE.Nose, 
                         PPE.NoseDischarge, PPE.Neck, PPE.SwollenLymphNode, PPE.NeckLeft, PPE.NeckRight, PPE.NeckOther, PPE.TMLeftNormal, PPE.TMLeftWhite, PPE.TMLeftRed, PPE.TMLeftYellow, PPE.TMLeftBulging, PPE.TMLeftMobile, 
                         PPE.TMLeftNonMobile, PPE.TMLeftRaptured, PPE.TMLeftOther, PPE.TMRightNormal, PPE.TMRightWhite, PPE.TMRightRed, PPE.TMRightYellow, PPE.TMRightBulging, PPE.TMRightMobile, PPE.TMRightNonMobile, 
                         PPE.TMRightRaptured, PPE.TMDischarge, PPE.TMRightOther, PPE.LungsRespiration, PPE.LungLeftWheezes, PPE.LungLeftRhonchi, PPE.LungLeftRales, PPE.LungLeftPoorAirEntry, PPE.LungLeftDiminshed, 
                         PPE.LungRightWheezes, PPE.LungRightRhonchi, PPE.LungRightRales, PPE.LungRightPoorAirEntry, PPE.LungRightDiminished, PPE.LungOther, PPE.HeartMurmur, PPE.MurmurRate, PPE.HeartRate, PPE.HeartRythm, 
                         PPE.HeartOther, PPE.AbdAbdomen, PPE.AbdTender, PPE.AbdMassQuality, PPE.AbdRebound, PPE.AbdUmbilicalHernia, PPE.AbdInguinalHernialLeft, PPE.AbdInguinalHernialRight, PPE.UmbClean, PPE.UmdDishcharge, 
                         PPE.UmbOther, PPE.GentMale, PPE.GentHydrocele, PPE.GentUndescendedLeft, PPE.GentUndescendedRight, PPE.GentHerniaLeft, PPE.GentHerniaRight, PPE.GentPenis, PPE.GentMicro, PPE.GentMeatus, PPE.GentDishcharge, 
                         PPE.GentMaleOther, PPE.GentFemale, PPE.GentLabia, PPE.GentUrethra, PPE.GentDischarge, PPE.GentMassLeft, PPE.GentMassRight, PPE.GentSize, PPE.GentOtherFemale, PPE.MuscArmsLegs, PPE.MuscLeftWeekness, 
                         PPE.MuscLeftSwelling, PPE.MuscLeftToneIncDec, PPE.MuscLeftTender, PPE.MuscLeftImmobile, PPE.MuscLeftDecStrength, PPE.MuscRightWeekness, PPE.MuscRightSwelling, PPE.MuscRightToneIncDec, 
                         PPE.MuscRightTender, PPE.MuscRightImmobile, PPE.MuscRightDecStrength, PPE.MuscLaceration, PPE.MuscBruise, PPE.MuscOther, PPE.FeetHandSymmetry, PPE.FeetHandLeftWeekness, PPE.FeetHandLeftSwelling, 
                         PPE.FeetHandLeftTender, PPE.FeetHandLeftImmobile, PPE.FeetHandLeftDecStrength, PPE.FeetHandLeftLaceration, PPE.FeetHandLeftBruise, PPE.FeetHandRightWeekness, PPE.FeetHandRightSwelling, 
                         PPE.FeetHandRightTender, PPE.FeetHandRightImmobile, PPE.FeetHandRightDecStrength, PPE.FeetHandRightLaceration, PPE.FeetHandRightBruise, PPE.FeetHandAbleToWalk, PPE.FeetToes, PPE.FeetOther, PPE.NeuroAwake, 
                         PPE.NeuroAlert, PPE.NeuroActive, PPE.NeuroDecConsciousness, PPE.NeuroAgitated, PPE.NeuroConvelsions, PPE.NeuroListLess, PPE.NeuroLethargic, PPE.NeuroAQAppropriately, PPE.NeuroReflexLeft, PPE.NeuroReflexRight, 
                         PPE.NeuroDevelopment, PPE.NeuroMotor, PPE.NeuroLanguage, PPE.NeuroSocial, PPE.NeuroOther, PPE.Skin, PPE.RashFlate, PPE.RashRaised, PPE.RashErythema, PPE.RashMacules, PPE.RashPapules, PPE.RashPetechiae, 
                         PPE.RashSize, PPE.RashOther
FROM            Paeds_PhysicalExamination AS PPE INNER JOIN
                         PatientInfo AS P ON PPE.PatientId = P.PatientId
						 where PPE.PaedsExamId=@PaedsExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Paeds_PhysicalExamination_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Paeds_PhysicalExamination_Update]
 @PaedsExamId int
,@PatientId int								=NULL
,@DOB date									=NULL
,@Temperature decimal(4,0)					=NULL
,@BP decimal(4,0)							=NULL
,@Pulse decimal(4,0)						=NULL
,@Weight decimal(4,0)						=NULL
,@WeightPercentile nvarchar(50)				=NULL
,@Height decimal(4,0)						=NULL
,@HeightPercentile nvarchar(50)				=NULL
,@HC nvarchar(50)							=NULL
,@HCPercentile nvarchar(50)					=NULL
,@Oxygen nvarchar(50)						=NULL
,@RR nvarchar(50)							=NULL
,@Alert bit									=NULL
,@ListLess bit								=NULL
,@Jaundice bit								=NULL
,@Active bit								=NULL
,@Agitated bit								=NULL
,@Pale bit									=NULL
,@Smiling bit								=NULL
,@Convulsions bit							=NULL
,@Crying bit								=NULL
,@NonResponse bit							=NULL
,@Lethargic bit								=NULL
,@ColorPink bit								=NULL
,@Other bit									=NULL
,@Head nvarchar(50)							=NULL
,@AntFontAnelle nvarchar(50)				=NULL
,@PostFontAnelle nvarchar(50)				=NULL
,@Sutures nvarchar(50)						=NULL
,@Cephalohematoma bit						=NULL
,@HeadOther nvarchar(150)					=NULL
,@EyePupils nvarchar(50)					=NULL
,@EyeSclera nvarchar(50)					=NULL
,@EyeConjuctiva nvarchar(50)				=NULL
,@EyeDischargeLeft nvarchar(50)				=NULL
,@EyeDischargeRight nvarchar(50)			=NULL
,@EyeRedReflex bit							=NULL
,@EyeOther nvarchar(150)					=NULL
,@EarPennaeLeft nvarchar(50)				=NULL
,@EarPennaeRight nvarchar(50)				=NULL
,@EarPennaeNotes nvarchar(50)				=NULL
,@EarCanalLeft nvarchar(50)					=NULL
,@EarCanalRight nvarchar(50)				=NULL
,@EarDischarge nvarchar(50)					=NULL
,@EarOther nvarchar(150)					=NULL
,@Mouth nvarchar(50)						=NULL
,@MouthGums nvarchar(50)					=NULL
,@MouthTeeth nvarchar(50)					=NULL
,@MouthOther nvarchar(50)					=NULL
,@Throat nvarchar(50)						=NULL
,@Tonsils nvarchar(50)						=NULL
,@ThroatOther nvarchar(50)					=NULL
,@Nose nvarchar(50)							=NULL
,@NoseDischarge nvarchar(50)				=NULL
,@Neck nvarchar(50)							=NULL
,@SwollenLymphNode nvarchar(50)				=NULL
,@NeckLeft nvarchar(50)						=NULL
,@NeckRight nvarchar(50)					=NULL
,@NeckOther nvarchar(150)					=NULL
,@TMLeftNormal bit							=NULL
,@TMLeftWhite bit							=NULL
,@TMLeftRed bit								=NULL
,@TMLeftYellow bit							=NULL
,@TMLeftBulging bit							=NULL
,@TMLeftMobile bit							=NULL
,@TMLeftNonMobile bit						=NULL
,@TMLeftRaptured bit						=NULL
,@TMLeftOther nvarchar(50)					=NULL
,@TMRightNormal bit							=NULL
,@TMRightWhite bit							=NULL
,@TMRightRed bit							=NULL
,@TMRightYellow bit							=NULL
,@TMRightBulging bit						=NULL
,@TMRightMobile bit							=NULL
,@TMRightNonMobile bit						=NULL
,@TMRightRaptured bit						=NULL
,@TMDischarge nvarchar(50)					=NULL
,@TMRightOther nvarchar(150)				=NULL
,@LungsRespiration nvarchar(50)				=NULL
,@LungLeftWheezes bit						=NULL
,@LungLeftRhonchi bit						=NULL
,@LungLeftRales bit							=NULL
,@LungLeftPoorAirEntry bit					=NULL
,@LungLeftDiminshed bit						=NULL
,@LungRightWheezes bit						=NULL
,@LungRightRhonchi bit						=NULL
,@LungRightRales bit						=NULL
,@LungRightPoorAirEntry bit					=NULL
,@LungRightDiminished bit					=NULL
,@LungOther nvarchar(max)					=NULL
,@HeartMurmur bit							=NULL
,@MurmurRate nvarchar(50)					=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartRythm nvarchar(50)					=NULL
,@HeartOther nvarchar(250)					=NULL
,@AbdAbdomen nvarchar(50)					=NULL
,@AbdTender nvarchar(50)					=NULL
,@AbdMassQuality nvarchar(50)				=NULL
,@AbdRebound bit							=NULL
,@AbdUmbilicalHernia nvarchar(50)			=NULL
,@AbdInguinalHernialLeft nvarchar(50)		=NULL
,@AbdInguinalHernialRight nvarchar(50)		=NULL
,@UmbClean nvarchar(50)						=NULL
,@UmdDishcharge nvarchar(50)				=NULL
,@UmbOther nvarchar(150)					=NULL
,@GentMale nvarchar(50)						=NULL
,@GentHydrocele bit							=NULL
,@GentUndescendedLeft bit					=NULL
,@GentUndescendedRight bit					=NULL
,@GentHerniaLeft nvarchar(50)				=NULL
,@GentHerniaRight nvarchar(50)				=NULL
,@GentPenis nvarchar(50)					=NULL
,@GentMicro bit								=NULL
,@GentMeatus nvarchar(50)					=NULL
,@GentDishcharge nvarchar(50)				=NULL
,@GentMaleOther nvarchar(150)				=NULL
,@GentFemale nvarchar(50)					=NULL
,@GentLabia nvarchar(50)					=NULL
,@GentUrethra nvarchar(50)					=NULL
,@GentDischarge nvarchar(50)				=NULL
,@GentMassLeft nvarchar(50)					=NULL
,@GentMassRight nvarchar(50)				=NULL
,@GentSize decimal(18,0)					=NULL
,@GentOtherFemale nvarchar(150)				=NULL
,@MuscArmsLegs nvarchar(50)					=NULL
,@MuscLeftWeekness bit						=NULL
,@MuscLeftSwelling bit						=NULL
,@MuscLeftToneIncDec bit					=NULL
,@MuscLeftTender bit						=NULL
,@MuscLeftImmobile bit						=NULL
,@MuscLeftDecStrength bit					=NULL
,@MuscRightWeekness bit						=NULL
,@MuscRightSwelling bit						=NULL
,@MuscRightToneIncDec bit					=NULL
,@MuscRightTender bit						=NULL
,@MuscRightImmobile bit						=NULL
,@MuscRightDecStrength bit					=NULL
,@MuscLaceration bit						=NULL
,@MuscBruise bit							=NULL
,@MuscOther nvarchar(150)					=NULL
,@FeetHandSymmetry nvarchar(50)				=NULL
,@FeetHandLeftWeekness bit					=NULL
,@FeetHandLeftSwelling bit					=NULL
,@FeetHandLeftTender bit					=NULL
,@FeetHandLeftImmobile bit					=NULL
,@FeetHandLeftDecStrength bit				=NULL
,@FeetHandLeftLaceration bit				=NULL
,@FeetHandLeftBruise bit					=NULL
,@FeetHandRightWeekness bit					=NULL
,@FeetHandRightSwelling bit					=NULL
,@FeetHandRightTender bit					=NULL
,@FeetHandRightImmobile bit					=NULL
,@FeetHandRightDecStrength bit				=NULL
,@FeetHandRightLaceration bit				=NULL
,@FeetHandRightBruise bit					=NULL
,@FeetHandAbleToWalk bit					=NULL
,@FeetToes nvarchar(50)						=NULL
,@FeetOther nvarchar(150)					=NULL
,@NeuroAwake bit							=NULL
,@NeuroAlert bit							=NULL
,@NeuroActive bit							=NULL
,@NeuroDecConsciousness bit					=NULL
,@NeuroAgitated bit							=NULL
,@NeuroConvelsions bit						=NULL
,@NeuroListLess bit							=NULL
,@NeuroLethargic bit						=NULL
,@NeuroAQAppropriately bit					=NULL
,@NeuroReflexLeft nvarchar(50)				=NULL
,@NeuroReflexRight nvarchar(50)				=NULL
,@NeuroDevelopment nvarchar(50)				=NULL
,@NeuroMotor bit							=NULL
,@NeuroLanguage bit							=NULL
,@NeuroSocial bit							=NULL
,@NeuroOther nvarchar(max)					=NULL
,@Skin nvarchar(50)							=NULL
,@RashFlate bit								=NULL
,@RashRaised bit							=NULL
,@RashErythema bit							=NULL
,@RashMacules bit							=NULL
,@RashPapules bit							=NULL
,@RashPetechiae bit							=NULL
,@RashSize decimal(18,0)					=NULL
,@RashOther nvarchar(150)					=NULL
as
begin
UPDATE Paeds_PhysicalExamination
   SET [PatientId] = @PatientId
      ,[DOB]=@DOB 
      ,[Temperature] = @Temperature 
      ,[BP] = @BP 
      ,[Pulse] = @Pulse 
      ,[Weight] = @Weight 
      ,[WeightPercentile] = @WeightPercentile 
      ,[Height] = @Height 
      ,[HeightPercentile] = @HeightPercentile 
      ,[HC] = @HC 
      ,[HCPercentile] = @HCPercentile 
      ,[Oxygen] = @Oxygen 
      ,[RR] = @RR 
      ,[Alert] = @Alert 
      ,[ListLess] = @ListLess 
      ,[Jaundice] = @Jaundice 
      ,[Active] = @Active 
      ,[Agitated] = @Agitated 
      ,[Pale] = @Pale 
      ,[Smiling] = @Smiling 
      ,[Convulsions] = @Convulsions 
      ,[Crying] = @Crying 
      ,[NonResponse] = @NonResponse 
      ,[Lethargic] = @Lethargic 
      ,[ColorPink] = @ColorPink 
      ,[Other] = @Other 
      ,[Head] = @Head 
      ,[AntFontAnelle] = @AntFontAnelle 
      ,[PostFontAnelle] = @PostFontAnelle 
      ,[Sutures] = @Sutures 
      ,[Cephalohematoma] = @Cephalohematoma 
      ,[HeadOther] = @HeadOther 
      ,[EyePupils] = @EyePupils 
      ,[EyeSclera] = @EyeSclera 
      ,[EyeConjuctiva] = @EyeConjuctiva 
      ,[EyeDischargeLeft] = @EyeDischargeLeft 
      ,[EyeDischargeRight] = @EyeDischargeRight 
      ,[EyeRedReflex] = @EyeRedReflex 
      ,[EyeOther] = @EyeOther 
      ,[EarPennaeLeft] = @EarPennaeLeft 
      ,[EarPennaeRight] = @EarPennaeRight 
      ,[EarPennaeNotes] = @EarPennaeNotes 
      ,[EarCanalLeft] = @EarCanalLeft 
      ,[EarCanalRight] = @EarCanalRight 
      ,[EarDischarge] = @EarDischarge 
      ,[EarOther] = @EarOther 
      ,[Mouth] = @Mouth 
      ,[MouthGums] = @MouthGums 
      ,[MouthTeeth] = @MouthTeeth 
      ,[MouthOther] = @MouthOther 
      ,[Throat] = @Throat 
      ,[Tonsils] = @Tonsils 
      ,[ThroatOther] = @ThroatOther 
      ,[Nose] = @Nose 
      ,[NoseDischarge] = @NoseDischarge 
      ,[Neck] = @Neck 
      ,[SwollenLymphNode] = @SwollenLymphNode 
      ,[NeckLeft] = @NeckLeft 
      ,[NeckRight] = @NeckRight 
      ,[NeckOther] = @NeckOther 
      ,[TMLeftNormal] = @TMLeftNormal 
      ,[TMLeftWhite] = @TMLeftWhite 
      ,[TMLeftRed] = @TMLeftRed 
      ,[TMLeftYellow] = @TMLeftYellow 
      ,[TMLeftBulging] = @TMLeftBulging 
      ,[TMLeftMobile] = @TMLeftMobile 
      ,[TMLeftNonMobile] = @TMLeftNonMobile 
      ,[TMLeftRaptured] = @TMLeftRaptured 
      ,[TMLeftOther] = @TMLeftOther 
      ,[TMRightNormal] = @TMRightNormal 
      ,[TMRightWhite] = @TMRightWhite 
      ,[TMRightRed] = @TMRightRed 
      ,[TMRightYellow] = @TMRightYellow 
      ,[TMRightBulging] = @TMRightBulging 
      ,[TMRightMobile] = @TMRightMobile 
      ,[TMRightNonMobile] = @TMRightNonMobile 
      ,[TMRightRaptured] = @TMRightRaptured 
      ,[TMDischarge] = @TMDischarge 
      ,[TMRightOther] = @TMRightOther
      ,[LungsRespiration] = @LungsRespiration 
      ,[LungLeftWheezes] = @LungLeftWheezes 
      ,[LungLeftRhonchi] = @LungLeftRhonchi 
      ,[LungLeftRales] = @LungLeftRales 
      ,[LungLeftPoorAirEntry] = @LungLeftPoorAirEntry 
      ,[LungLeftDiminshed] = @LungLeftDiminshed 
      ,[LungRightWheezes] = @LungRightWheezes 
      ,[LungRightRhonchi] = @LungRightRhonchi 
      ,[LungRightRales] = @LungRightRales 
      ,[LungRightPoorAirEntry] = @LungRightPoorAirEntry 
      ,[LungRightDiminished] = @LungRightDiminished 
      ,[LungOther] = @LungOther 
      ,[HeartMurmur] = @HeartMurmur 
      ,[MurmurRate] = @MurmurRate 
      ,[HeartRate] = @HeartRate 
      ,[HeartRythm] = @HeartRythm 
      ,[HeartOther] = @HeartOther 
      ,[AbdAbdomen] = @AbdAbdomen 
      ,[AbdTender] = @AbdTender 
      ,[AbdMassQuality] = @AbdMassQuality 
      ,[AbdRebound] = @AbdRebound 
      ,[AbdUmbilicalHernia] = @AbdUmbilicalHernia 
      ,[AbdInguinalHernialLeft] = @AbdInguinalHernialLeft 
      ,[AbdInguinalHernialRight] = @AbdInguinalHernialRight 
      ,[UmbClean] = @UmbClean 
      ,[UmdDishcharge] = @UmdDishcharge 
      ,[UmbOther] = @UmbOther 
      ,[GentMale] = @GentMale 
      ,[GentHydrocele] = @GentHydrocele 
      ,[GentUndescendedLeft] = @GentUndescendedLeft 
      ,[GentUndescendedRight] = @GentUndescendedRight 
      ,[GentHerniaLeft] = @GentHerniaLeft 
      ,[GentHerniaRight] = @GentHerniaRight 
      ,[GentPenis] = @GentPenis 
      ,[GentMicro] = @GentMicro 
      ,[GentMeatus] = @GentMeatus 
      ,[GentDishcharge] = @GentDishcharge 
      ,[GentMaleOther] = @GentMaleOther 
      ,[GentFemale] = @GentFemale 
      ,[GentLabia] = @GentLabia 
      ,[GentUrethra] = @GentUrethra 
      ,[GentDischarge] = @GentDischarge 
      ,[GentMassLeft] = @GentMassLeft 
      ,[GentMassRight] = @GentMassRight 
      ,[GentSize] = @GentSize 
      ,[GentOtherFemale] = @GentOtherFemale
      ,[MuscArmsLegs] = @MuscArmsLegs 
      ,[MuscLeftWeekness] = @MuscLeftWeekness 
      ,[MuscLeftSwelling] = @MuscLeftSwelling 
      ,[MuscLeftToneIncDec] = @MuscLeftToneIncDec 
      ,[MuscLeftTender] = @MuscLeftTender 
      ,[MuscLeftImmobile] = @MuscLeftImmobile 
      ,[MuscLeftDecStrength] = @MuscLeftDecStrength 
      ,[MuscRightWeekness] = @MuscRightWeekness 
      ,[MuscRightSwelling] = @MuscRightSwelling 
      ,[MuscRightToneIncDec] = @MuscRightToneIncDec 
      ,[MuscRightTender] = @MuscRightTender 
      ,[MuscRightImmobile] = @MuscRightImmobile 
      ,[MuscRightDecStrength] = @MuscRightDecStrength 
      ,[MuscLaceration] = @MuscLaceration 
      ,[MuscBruise] = @MuscBruise 
      ,[MuscOther] = @MuscOther
      ,[FeetHandSymmetry] = @FeetHandSymmetry 
      ,[FeetHandLeftWeekness] = @FeetHandLeftWeekness 
      ,[FeetHandLeftSwelling] = @FeetHandLeftSwelling 
      ,[FeetHandLeftTender] = @FeetHandLeftTender 
      ,[FeetHandLeftImmobile] = @FeetHandLeftImmobile 
      ,[FeetHandLeftDecStrength] = @FeetHandLeftDecStrength 
      ,[FeetHandLeftLaceration] = @FeetHandLeftLaceration 
      ,[FeetHandLeftBruise] = @FeetHandLeftBruise 
      ,[FeetHandRightWeekness] = @FeetHandRightWeekness 
      ,[FeetHandRightSwelling] = @FeetHandRightSwelling 
      ,[FeetHandRightTender] = @FeetHandRightTender 
      ,[FeetHandRightImmobile] = @FeetHandRightImmobile 
      ,[FeetHandRightDecStrength] = @FeetHandRightDecStrength 
      ,[FeetHandRightLaceration] = @FeetHandRightLaceration 
      ,[FeetHandRightBruise] = @FeetHandRightBruise 
      ,[FeetHandAbleToWalk] = @FeetHandAbleToWalk 
      ,[FeetToes] = @FeetToes 
      ,[FeetOther] = @FeetOther
      ,[NeuroAwake] = @NeuroAwake 
      ,[NeuroAlert] = @NeuroAlert 
      ,[NeuroActive] = @NeuroActive 
      ,[NeuroDecConsciousness] = @NeuroDecConsciousness 
      ,[NeuroAgitated] = @NeuroAgitated 
      ,[NeuroConvelsions] = @NeuroConvelsions 
      ,[NeuroListLess] = @NeuroListLess 
      ,[NeuroLethargic] = @NeuroLethargic 
      ,[NeuroAQAppropriately] = @NeuroAQAppropriately 
      ,[NeuroReflexLeft] = @NeuroReflexLeft 
      ,[NeuroReflexRight] = @NeuroReflexRight 
      ,[NeuroDevelopment] = @NeuroDevelopment 
      ,[NeuroMotor] = @NeuroMotor 
      ,[NeuroLanguage] = @NeuroLanguage 
      ,[NeuroSocial] = @NeuroSocial 
      ,[NeuroOther] = @NeuroOther 
      ,[Skin] = @Skin 
      ,[RashFlate] = @RashFlate 
      ,[RashRaised] = @RashRaised 
      ,[RashErythema] = @RashErythema 
      ,[RashMacules] = @RashMacules 
      ,[RashPapules] = @RashPapules 
      ,[RashPetechiae] = @RashPetechiae 
      ,[RashSize] = @RashSize 
      ,[RashOther] = @RashOther 
 WHERE PaedsExamId=@PaedsExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PaedsForm_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PaedsForm_Delete]
  @PaedsFormId int


as
begin
delete from PaedsForm where PaedsFormId=@PaedsFormId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PaedsForm_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PaedsForm_Insert]
  @PatientId int					=NULL
 ,@ChiefComplaint nvarchar(max)		=NULL
 ,@IllnessHistory nvarchar(max)		=NULL
 ,@CurrentMedication nvarchar(max)	=NULL
 ,@BCG bit							=NULL
 ,@PolioDate1 date					=NULL
 ,@PolioDate2 date					=NULL
 ,@PolioDate3 date					=NULL
 ,@PolioDate4 date					=NULL
 ,@DPTDate1 date					=NULL
 ,@DPTDate2 date					=NULL
 ,@DPTDate3 date					=NULL
 ,@DPTDate4 date					=NULL
 ,@HepBDate1 date					=NULL
 ,@HepBDate2 date					=NULL
 ,@HepBDate3 date					=NULL
 ,@HepADate1 date					=NULL
 ,@HepADate2 date					=NULL
 ,@HepADate3 date					=NULL
 ,@Other nvarchar(max)				=NULL
 ,@OtherDate date					=NULL
 ,@Error bit =null output
 ,@Message nvarchar(200)=null output 
 ,@ID int output
as
begin
INSERT INTO PaedsForm
           ([PatientId]
           ,[ChiefComplaint]
           ,[IllnessHistory]
           ,[CurrentMedication]
           ,[BCG]
           ,[PolioDate1]
           ,[PolioDate2]
           ,[PolioDate3]
           ,[PolioDate4]
           ,[DPTDate1]
           ,[DPTDate2]
           ,[DPTDate3]
           ,[DPTDate4]
           ,[HepBDate1]
           ,[HepBDate2]
           ,[HepBDate3]
           ,[HepADate1]
           ,[HepADate2]
           ,[HepADate3]
           ,[Other]
           ,[OtherDate])
     VALUES
           (@PatientId 
           ,@ChiefComplaint
           ,@IllnessHistory 
           ,@CurrentMedication 
           ,@BCG 
           ,@PolioDate1 
           ,@PolioDate2 
           ,@PolioDate3 
           ,@PolioDate4 
           ,@DPTDate1 
           ,@DPTDate2 
           ,@DPTDate3 
           ,@DPTDate4 
           ,@HepBDate1
           ,@HepBDate2
           ,@HepBDate3
           ,@HepADate1
           ,@HepADate2
           ,@HepADate3
           ,@Other 
           ,@OtherDate 
		   )

		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PaedsForm_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PaedsForm_SelectAll]
as
SELECT        PF.PaedsFormId, PF.PatientId,P.PatientName, PF.ChiefComplaint, PF.IllnessHistory, PF.CurrentMedication, PF.BCG, PF.PolioDate1, PF.PolioDate2, PF.PolioDate3, PF.PolioDate4, PF.DPTDate1, PF.DPTDate2, PF.DPTDate3, PF.DPTDate4, 
              PF.HepBDate1, PF.HepBDate2, PF.HepBDate3, PF.HepADate1, PF.HepADate2, PF.HepADate3, PF.Other, PF.OtherDate
FROM            PaedsForm AS PF INNER JOIN
                         PatientInfo AS P ON PF.PatientId = P.PatientId order by PF.PaedsFormId desc
						

GO
/****** Object:  StoredProcedure [dbo].[sp_PaedsForm_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PaedsForm_SelectByID]
@PaedsFormId int
as
SELECT        PF.PaedsFormId, PF.PatientId,P.PatientName, PF.ChiefComplaint, PF.IllnessHistory, PF.CurrentMedication, PF.BCG, PF.PolioDate1, PF.PolioDate2, PF.PolioDate3, PF.PolioDate4, PF.DPTDate1, PF.DPTDate2, PF.DPTDate3, PF.DPTDate4, 
              PF.HepBDate1, PF.HepBDate2, PF.HepBDate3, PF.HepADate1, PF.HepADate2, PF.HepADate3, PF.Other, PF.OtherDate
FROM            PaedsForm AS PF INNER JOIN
                         PatientInfo AS P ON PF.PatientId = P.PatientId
						 where PF.PaedsFormId=@PaedsFormId

GO
/****** Object:  StoredProcedure [dbo].[sp_PaedsForm_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PaedsForm_Update]
  @PaedsFormId int
 ,@PatientId int					=NULL
 ,@ChiefComplaint nvarchar(max)		=NULL
 ,@IllnessHistory nvarchar(max)		=NULL
 ,@CurrentMedication nvarchar(max)	=NULL
 ,@BCG bit							=NULL
 ,@PolioDate1 date					=NULL
 ,@PolioDate2 date					=NULL
 ,@PolioDate3 date					=NULL
 ,@PolioDate4 date					=NULL
 ,@DPTDate1 date					=NULL
 ,@DPTDate2 date					=NULL
 ,@DPTDate3 date					=NULL
 ,@DPTDate4 date					=NULL
 ,@HepBDate1 date					=NULL
 ,@HepBDate2 date					=NULL
 ,@HepBDate3 date					=NULL
 ,@HepADate1 date					=NULL
 ,@HepADate2 date					=NULL
 ,@HepADate3 date					=NULL
 ,@Other nvarchar(max)				=NULL
 ,@OtherDate date					=NULL
as
begin
UPDATE PaedsForm
   SET [PatientId] = @PatientId 
      ,[ChiefComplaint] = @ChiefComplaint 
      ,[IllnessHistory] = @IllnessHistory 
      ,[CurrentMedication] = @CurrentMedication 
      ,[BCG] = @BCG
      ,[PolioDate1] = @PolioDate1 
      ,[PolioDate2] = @PolioDate2 
      ,[PolioDate3] = @PolioDate3 
      ,[PolioDate4] = @PolioDate4 
      ,[DPTDate1] = @DPTDate1 
      ,[DPTDate2] = @DPTDate2 
      ,[DPTDate3] = @DPTDate3 
      ,[DPTDate4] = @DPTDate4 
      ,[HepBDate1] = @HepBDate1 
      ,[HepBDate2] = @HepBDate2 
      ,[HepBDate3] = @HepBDate3 
      ,[HepADate1] = @HepADate1 
      ,[HepADate2] = @HepADate2 
      ,[HepADate3] = @HepADate3 
      ,[Other] = @Other 
      ,[OtherDate] = @OtherDate 
 WHERE PaedsFormId=@PaedsFormId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Patient_Delete]
@Id int
as
update  PatientInfo set [Status]=0 where PatientId=@Id
--delete from  PatientInfo where PatientId=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_Dropdown]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Patient_Dropdown]
as
select PatientId,PatientName from PatientInfo where [Status]=1





GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Patient_Insert]
 @PatientName nvarchar(200)=null,
 @DOB date=null,
 @PatientAge nvarchar(50)=null,
 @GuardianRelation nvarchar(50)=null,
 @Gender nvarchar(50)=null,
 @ContactNumber nvarchar(15)=null,
 @CNIC nvarchar(15)=null,
 @Address nvarchar(200)=null,
 @Message nvarchar(200)=null output,  
 @Error bit =null output,
 @ID int output 
as  
begin
declare @mrno bigint;
set @mrno=(select isnull(max(mrNumber),0)+1 from PatientInfo);
INSERT INTO [PatientInfo]
            ([MrNumber]
           ,[PatientName]
           ,[DOB]
           ,[PatientAge]
           ,[GuardianRelation]
           ,[Gender]
           ,[ContactNumber]
           ,[CNIC]
           ,[Address]
		   ,[Status])
     VALUES
          (
		    @mrno
           ,@PatientName
           ,@DOB
           ,@PatientAge
           ,@GuardianRelation
           ,@Gender
           ,@ContactNumber
           ,@CNIC
           ,@Address
		   ,1)
		   
		set @Error=convert(bit,0)
		set @Message='Patient Record saved <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY();
		
		
end

GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_Search]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_Patient_Search 1
CREATE proc [dbo].[sp_Patient_Search]
@MrNumber int=NULL
as
SELECT PatientId,
       [MrNumber]
      ,[PatientName]
      ,[DOB]
      ,[PatientAge]
      ,[GuardianRelation]
      ,[Gender]
      ,[ContactNumber]
      ,[CNIC]
      ,[Address]
  FROM PatientInfo with(nolock)  WHERE [MrNumber] LIKE cast(@MrNumber as nvarchar) -- + '%' 





GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Patient_SelectAll]
@PageNumber int=1,
@PageSize int=10,
@TotalRecords int=null output
as
SELECT PatientId,
       [MrNumber]
      ,[PatientName]
      ,[DOB]
      ,[PatientAge]
      ,[GuardianRelation]
      ,[Gender]
      ,[ContactNumber]
      ,[CNIC]
      ,[Address]
  FROM PatientInfo with(nolock) where [Status]=1 order by PatientId desc
  OFFSET @PageSize * (@PageNumber - 1) ROWS
  FETCH NEXT @PageSize ROWS ONLY OPTION (RECOMPILE);

  set @TotalRecords =(select count(PatientId) from PatientInfo where Status=1);



GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Patient_SelectByID]
@Id int
as
SELECT [PatientId]
      ,[MrNumber]
      ,[PatientName]
      ,[DOB]
      ,[PatientAge]
      ,[GuardianRelation]
      ,[Gender]
      ,[ContactNumber]
      ,[CNIC]
      ,[Address]
  FROM PatientInfo where PatientId=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_Patient_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Patient_Update]
 @PatientId int,
 @PatientName nvarchar(200)=null,
 @DOB date=null,
 @PatientAge nvarchar(50)=null,
 @GuardianRelation nvarchar(50)=null,
 @Gender nvarchar(50)=null,
 @ContactNumber nvarchar(15)=null,
 @CNIC nvarchar(15)=null,
 @Address nvarchar(200)=null
as
begin
UPDATE PatientInfo
   SET [PatientName] = @PatientName
      ,[DOB] = @DOB
      ,[PatientAge] = @PatientAge
      ,[GuardianRelation] = @GuardianRelation
      ,[Gender] = @Gender
      ,[ContactNumber] = @ContactNumber
      ,[CNIC] = @CNIC
      ,[Address] = @Address
 WHERE PatientId=@PatientId

 end


GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PostNatal_Infant_Delete]
 @PostNatalInfantId int
 as
Delete from PostNatal_Infant where  PostNatalInfantId=@PostNatalInfantId






GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_Infant_Insert]
 @PatientId int
,@InfantDOB date							=NULL
,@InfantAge nvarchar(50)					=NULL
,@Gender nvarchar(50)						=NULL
,@DeliveryCondition nvarchar(50)			=NULL
,@DeliveryTerm nvarchar(50)					=NULL
,@DeliveryHospital bit						=NULL
,@DeliveryMaternityHome bit					=NULL
,@DeliveryHome bit							=NULL
,@Alert bit									=NULL
,@Listless bit								=NULL
,@Jaundice bit								=NULL
,@Active bit								=NULL
,@Agitated bit								=NULL
,@Pale bit									=NULL
,@Smiling bit								=NULL
,@Convulsions bit							=NULL
,@Crying bit								=NULL
,@NonResponse bit							=NULL
,@Lethargic bit								=NULL
,@ColorPink bit								=NULL
,@Other bit									=NULL
,@InfantCondition nvarchar(50)				=NULL
,@BreastFeeding bit							=NULL
,@FeedingCondition nvarchar(50)				=NULL
,@Temperature decimal(4,0)					=NULL
,@Weight decimal(4,0)						=NULL
,@WeightPercentile nvarchar(50)				=NULL
,@BirthWieght decimal(4,0)					=NULL
,@BirthWieghtPercentile nvarchar(50)		=NULL
,@Length nvarchar(50)						=NULL
,@LengthPercentile nvarchar(50)				=NULL
,@HC nvarchar(50)							=NULL
,@HCPercentile nvarchar(50)					=NULL
,@Head nvarchar(50)							=NULL
,@AntFontAnelle nvarchar(50)				=NULL
,@PostFontAnelle nvarchar(50)				=NULL
,@Sutures nvarchar(50)						=NULL
,@CephalohematomaLeft bit					=NULL
,@CephalohematomaRight bit					=NULL
,@HeadOther nvarchar(150)					=NULL
,@EyePupils nvarchar(50)					=NULL
,@EyeSclera nvarchar(50)					=NULL
,@EyeConjuctiva nvarchar(50)				=NULL
,@EyeDischargeLeft nvarchar(50)				=NULL
,@EyeDischargeRight nvarchar(50)			=NULL
,@EyeRedReflexLeft bit			=NULL
,@EyeRedReflexRight bit			=NULL
,@EarPennaeLeft nvarchar(50)				=NULL
,@EarPennaeRight nvarchar(50)				=NULL
,@EarCanalLeft nvarchar(50)					=NULL
,@EarCanalRight nvarchar(50)				=NULL
,@EarDischarge nvarchar(50)					=NULL
,@EarPennaeNotes nvarchar(50)				=NULL
,@EarOther nvarchar(150)					=NULL
,@TMLeftNormal bit							=NULL
,@TMLeftWhite bit							=NULL
,@TMLeftRed bit								=NULL
,@TMLeftRellow bit							=NULL
,@TMLeftBulging bit							=NULL
,@TMLeftMobile bit							=NULL
,@TMLeftNonMobile bit						=NULL
,@TMLeftRaptured bit						=NULL
,@TMRightNormal bit							=NULL
,@TMRightWhite bit							=NULL
,@TMRightRed bit							=NULL
,@TMRightYellow bit							=NULL
,@TMRightBulging bit						=NULL
,@TMRightMobile bit							=NULL
,@TMRightNonMobile bit						=NULL
,@TMRightRuptured bit						=NULL
,@TMDischarge nvarchar(50)					=NULL
,@TMOther nvarchar(50)						=NULL
,@Nose nvarchar(50)							=NULL
,@NoseDischarge nvarchar(50)				=NULL
,@NoseOther nvarchar(150)					=NULL
,@Mouth nvarchar(50)						=NULL
,@MouthGums nvarchar(50)					=NULL
,@MouthOther nvarchar(150)					=NULL
,@Suck nvarchar(50)							=NULL
,@Throat nvarchar(50)						=NULL
,@ThroatOther nvarchar(150)					=NULL
,@Neck nvarchar(50)							=NULL
,@SwollenLymphNode nvarchar(50)				=NULL
,@NeckLeft nvarchar(50)						=NULL
,@NeckRight nvarchar(50)					=NULL
,@NeckOther nvarchar(50)					=NULL
,@LungRespiration nvarchar(50)				=NULL
,@LungRetratcions bit						=NULL
,@LungWheezes bit							=NULL
,@LungBreathSound bit						=NULL
,@LungDimishedLeft bit						=NULL
,@LungDimishedRight bit						=NULL
,@LungRhonchi bit							=NULL
,@LungRales bit								=NULL
,@LungIncRespRate bit						=NULL
,@LungOhter nvarchar(150)					=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartMurmur nvarchar(50)					=NULL
,@HeartIncreasedRate bit					=NULL
,@HeartDecreasedRate bit					=NULL
,@HeartIrregularRhythm bit					=NULL
,@HeartRub bit								=NULL
,@HeartPedal nvarchar(50)					=NULL
,@HeartOther nvarchar(150)					=NULL
,@AbdAbdomen nvarchar(50)					=NULL
,@AbdTender nvarchar(50)					=NULL
,@AbdMass nvarchar(50)						=NULL
,@AbdSize decimal(18,0)						=NULL
,@AbdMassQuality nvarchar(50)				=NULL
,@AbdHernia nvarchar(50)					=NULL
,@UmbClean nvarchar(50)						=NULL
,@UmbDischarge nvarchar(50)					=NULL
,@UmbErythema bit							=NULL
,@UmbInduration bit							=NULL
,@UmbWarmtoTouch bit						=NULL
,@UmbHernia nvarchar(50)								=NULL
,@UmbOther nvarchar(150)					=NULL
,@GentTesties nvarchar(50)					=NULL
,@GentHydrocele bit							=NULL
,@GentUndescededLeft bit					=NULL
,@GentUndescededRight bit					=NULL
,@GentHernia nvarchar(50)					=NULL
,@GentPenis nvarchar(50)					=NULL
,@GentMeatus nvarchar(50)					=NULL
,@GentDischargeMale nvarchar(50)			=NULL
,@GentOtherMale nvarchar(150)				=NULL
,@GentNormal nvarchar(50)					=NULL
,@GentLabia nvarchar(50)					=NULL
,@GentUrethra nvarchar(50)					=NULL
,@GentDishargeFemale nvarchar(50)			=NULL
,@GentMass nvarchar(50)						=NULL
,@GentSize decimal(18,0)						=NULL
,@GentOtherFemale nvarchar(150)				=NULL
,@MuscArms nvarchar(50)						=NULL
,@MuscWeekness nvarchar(50)					=NULL
,@MuscSwelling nvarchar(50)					=NULL
,@MuscTender nvarchar(50)					=NULL
,@MuscImmobile nvarchar(50)					=NULL
,@MuscDecStrength nvarchar(50)				=NULL
,@MuscOther nvarchar(150)					=NULL
,@HandSymmetry nvarchar(50)					=NULL
,@HandWeekness nvarchar(50)					=NULL
,@HandSwelling nvarchar(50)					=NULL
,@HandTender nvarchar(50)					=NULL
,@HandImmobile nvarchar(50)					=NULL
,@HandDecStrength nvarchar(50)				=NULL
,@HandFingers nvarchar(50)					=NULL
,@HandBruise nvarchar(50)					=NULL
,@HandExtraDigits bit						=NULL
,@HandSyndactyly bit						=NULL
,@HandOther nvarchar(150)					=NULL
,@LegSymmetry nvarchar(50)					=NULL
,@LegWeekness nvarchar(50)					=NULL
,@LegFlacid nvarchar(50)					=NULL
,@LegNomalTone nvarchar(50)					=NULL
,@LegSwelling nvarchar(50)					=NULL
,@LegTender nvarchar(50)					=NULL
,@LegImmobile nvarchar(50)					=NULL
,@LegDecStrength nvarchar(50)				=NULL
,@LegOther nvarchar(50)						=NULL
,@FeetSymmetry nvarchar(50)					=NULL
,@FeetWeekness nvarchar(50)					=NULL
,@FeetSwelling nvarchar(50)					=NULL
,@FeetTender nvarchar(50)					=NULL
,@FeetImmobile nvarchar(50)					=NULL
,@FeetDecStrength nvarchar(50)				=NULL
,@FeetClubFoot nvarchar(50)					=NULL
,@FeetToes nvarchar(50)						=NULL
,@FeetExtraDigits bit						=NULL
,@FeetSyndactyly bit						=NULL
,@FeetOther nvarchar(150)					=NULL
,@HipSymmetry nvarchar(50)					=NULL
,@HipLeft nvarchar(50)						=NULL
,@HipRight nvarchar(50)						=NULL
,@NeuroAwake bit							=NULL
,@NeuroAlert bit							=NULL
,@NeuroActive bit							=NULL
,@NeuroDecConsciousness bit					=NULL
,@NeuroAgitated bit							=NULL
,@NeuroConvelsions bit						=NULL
,@NeuroListLess bit							=NULL
,@NeuroLethargic bit						=NULL
,@NeuroFlaccid bit							=NULL
,@ReflexMoro bit							=NULL
,@ReflexGrasp bit							=NULL
,@ReflexRooting bit							=NULL
,@ReflexGalant bit							=NULL
,@ReflexStepping bit						=NULL
,@ReflexOther nvarchar(150)					=NULL
,@SkinNormal nvarchar(50)					=NULL
,@Rashflat bit								=NULL
,@RashRaised bit							=NULL
,@RashErythema bit							=NULL
,@RashMacules bit							=NULL
,@RashPapules bit							=NULL
,@RashPetechie bit							=NULL
,@RashSize decimal(18,0)					=NULL
,@RashOther nvarchar(150)					=NULL
,@BfSuck bit								=NULL
,@BfLatchingOn bit							=NULL
,@BfSpitting bit							=NULL
,@BfVomiting bit							=NULL
,@BfNasalObstruction bit					=NULL
,@BfOther nvarchar(150)						=NULL
,@DsFever bit								=NULL
,@DsPoorFeeding bit							=NULL
,@DsCrying bit								=NULL
,@DsLethargy bit							=NULL
,@DsHardToWakeup bit						=NULL
,@DsNoUrination bit							=NULL
,@DsNoBowelMovement bit						=NULL
,@DsVomiting bit							=NULL
,@DsDiarrhea bit							=NULL
,@DsReturn bit								=NULL
,@Hgb nvarchar(50)							=NULL
,@BloodGroup nvarchar(50)					=NULL
,@HepB bit									=NULL
,@Protein nvarchar(50)						=NULL
,@Glucose nvarchar(50)						=NULL
,@BloodSugar nvarchar(50)					=NULL
,@WBC nvarchar(50)							=NULL
,@GramStain nvarchar(50)					=NULL
,@Keytone nvarchar(50)						=NULL
,@Blood nvarchar(50)						=NULL
,@Polio bit									=NULL
,@BCG bit									=NULL
,@Bilirubin nvarchar(150)					=NULL
,@Notes nvarchar(max)						=NULL
,@Plan nvarchar(max)						=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO [dbo].[PostNatal_Infant]
           ([PatientId]
           ,[InfantDOB]
           ,[InfantAge]
           ,[Gender]
           ,[DeliveryCondition]
           ,[DeliveryTerm]
           ,[DeliveryHospital]
           ,[DeliveryMaternityHome]
           ,[DeliveryHome]
           ,[Alert]
           ,[Listless]
           ,[Jaundice]
           ,[Active]
           ,[Agitated]
           ,[Pale]
           ,[Smiling]
           ,[Convulsions]
           ,[Crying]
           ,[NonResponse]
           ,[Lethargic]
           ,[ColorPink]
           ,[Other]
           ,[InfantCondition]
           ,[BreastFeeding]
           ,[FeedingCondition]
           ,[Temperature]
           ,[Weight]
           ,[WeightPercentile]
           ,[BirthWieght]
           ,[BirthWieghtPercentile]
           ,[Length]
           ,[LengthPercentile]
           ,[HC]
           ,[HCPercentile]
           ,[Head]
           ,[AntFontAnelle]
           ,[PostFontAnelle]
           ,[Sutures]
           ,[CephalohematomaLeft]
           ,[CephalohematomaRight]
           ,[HeadOther]
           ,[EyePupils]
           ,[EyeSclera]
           ,[EyeConjuctiva]
           ,[EyeDischargeLeft]
           ,[EyeDischargeRight]
           ,[EyeRedReflexLeft]
           ,[EyeRedReflexRight]
           ,[EarPennaeLeft]
           ,[EarPennaeRight]
           ,[EarCanalLeft]
           ,[EarCanalRight]
           ,[EarDischarge]
           ,[EarPennaeNotes]
           ,[EarOther]
           ,[TMLeftNormal]
           ,[TMLeftWhite]
           ,[TMLeftRed]
           ,[TMLeftRellow]
           ,[TMLeftBulging]
           ,[TMLeftMobile]
           ,[TMLeftNonMobile]
           ,[TMLeftRaptured]
           ,[TMRightNormal]
           ,[TMRightWhite]
           ,[TMRightRed]
           ,[TMRightYellow]
           ,[TMRightBulging]
           ,[TMRightMobile]
           ,[TMRightNonMobile]
           ,[TMRightRuptured]
           ,[TMDischarge]
           ,[TMOther]
           ,[Nose]
           ,[NoseDischarge]
           ,[NoseOther]
           ,[Mouth]
           ,[MouthGums]
           ,[MouthOther]
           ,[Suck]
           ,[Throat]
           ,[ThroatOther]
           ,[Neck]
           ,[SwollenLymphNode]
           ,[NeckLeft]
           ,[NeckRight]
           ,[NeckOther]
           ,[LungRespiration]
           ,[LungRetratcions]
           ,[LungWheezes]
           ,[LungBreathSound]
           ,[LungDimishedLeft]
           ,[LungDimishedRight]
           ,[LungRhonchi]
           ,[LungRales]
           ,[LungIncRespRate]
           ,[LungOhter]
           ,[HeartRate]
           ,[HeartMurmur]
           ,[HeartIncreasedRate]
           ,[HeartDecreasedRate]
           ,[HeartIrregularRhythm]
           ,[HeartRub]
           ,[HeartPedal]
           ,[HeartOther]
           ,[AbdAbdomen]
           ,[AbdTender]
           ,[AbdMass]
           ,[AbdSize]
           ,[AbdMassQuality]
           ,[AbdHernia]
           ,[UmbClean]
           ,[UmbDischarge]
           ,[UmbErythema]
           ,[UmbInduration]
           ,[UmbWarmtoTouch]
           ,[UmbHernia]
           ,[UmbOther]
           ,[GentTesties]
           ,[GentHydrocele]
           ,[GentUndescededLeft]
           ,[GentUndescededRight]
           ,[GentHernia]
           ,[GentPenis]
           ,[GentMeatus]
           ,[GentDischargeMale]
           ,[GentOtherMale]
           ,[GentNormal]
           ,[GentLabia]
           ,[GentUrethra]
           ,[GentDishargeFemale]
           ,[GentMass]
           ,[GentSize]
           ,[GentOtherFemale]
           ,[MuscArms]
           ,[MuscWeekness]
           ,[MuscSwelling]
           ,[MuscTender]
           ,[MuscImmobile]
           ,[MuscDecStrength]
           ,[MuscOther]
           ,[HandSymmetry]
           ,[HandWeekness]
           ,[HandSwelling]
           ,[HandTender]
           ,[HandImmobile]
           ,[HandDecStrength]
           ,[HandFingers]
           ,[HandBruise]
           ,[HandExtraDigits]
           ,[HandSyndactyly]
           ,[HandOther]
           ,[LegSymmetry]
           ,[LegWeekness]
           ,[LegFlacid]
           ,[LegNomalTone]
           ,[LegSwelling]
           ,[LegTender]
           ,[LegImmobile]
           ,[LegDecStrength]
           ,[LegOther]
           ,[FeetSymmetry]
           ,[FeetWeekness]
           ,[FeetSwelling]
           ,[FeetTender]
           ,[FeetImmobile]
           ,[FeetDecStrength]
           ,[FeetClubFoot]
           ,[FeetToes]
           ,[FeetExtraDigits]
           ,[FeetSyndactyly]
           ,[FeetOther]
           ,[HipSymmetry]
           ,[HipLeft]
           ,[HipRight]
           ,[NeuroAwake]
           ,[NeuroAlert]
           ,[NeuroActive]
           ,[NeuroDecConsciousness]
           ,[NeuroAgitated]
           ,[NeuroConvelsions]
           ,[NeuroListLess]
           ,[NeuroLethargic]
           ,[NeuroFlaccid]
           ,[ReflexMoro]
           ,[ReflexGrasp]
           ,[ReflexRooting]
           ,[ReflexGalant]
           ,[ReflexStepping]
           ,[ReflexOther]
           ,[SkinNormal]
           ,[Rashflat]
           ,[RashRaised]
           ,[RashErythema]
           ,[RashMacules]
           ,[RashPapules]
           ,[RashPetechie]
           ,[RashSize]
           ,[RashOther]
           ,[BfSuck]
           ,[BfLatchingOn]
           ,[BfSpitting]
           ,[BfVomiting]
           ,[BfNasalObstruction]
           ,[BfOther]
           ,[DsFever]
           ,[DsPoorFeeding]
           ,[DsCrying]
           ,[DsLethargy]
           ,[DsHardToWakeup]
           ,[DsNoUrination]
           ,[DsNoBowelMovement]
           ,[DsVomiting]
           ,[DsDiarrhea]
           ,[DsReturn]
           ,[Hgb]
           ,[BloodGroup]
           ,[HepB]
           ,[Protein]
           ,[Glucose]
           ,[BloodSugar]
           ,[WBC]
           ,[GramStain]
           ,[Keytone]
           ,[Blood]
           ,[Polio]
           ,[BCG]
           ,[Bilirubin]
           ,[Notes]
           ,[Plan])
    VALUES(
		    @PatientId 
           ,@InfantDOB 
           ,@InfantAge 
           ,@Gender 
           ,@DeliveryCondition 
           ,@DeliveryTerm 
           ,@DeliveryHospital 
           ,@DeliveryMaternityHome 
           ,@DeliveryHome 
           ,@Alert 
           ,@Listless 
           ,@Jaundice 
           ,@Active 
           ,@Agitated 
           ,@Pale 
           ,@Smiling 
           ,@Convulsions 
           ,@Crying 
           ,@NonResponse 
           ,@Lethargic 
           ,@ColorPink 
           ,@Other 
           ,@InfantCondition 
           ,@BreastFeeding 
           ,@FeedingCondition 
           ,@Temperature
           ,@Weight 
           ,@WeightPercentile 
           ,@BirthWieght 
           ,@BirthWieghtPercentile 
           ,@Length 
           ,@LengthPercentile 
           ,@HC 
           ,@HCPercentile 
           ,@Head 
           ,@AntFontAnelle 
           ,@PostFontAnelle 
           ,@Sutures 
           ,@CephalohematomaLeft 
           ,@CephalohematomaRight 
           ,@HeadOther 
           ,@EyePupils 
           ,@EyeSclera 
           ,@EyeConjuctiva 
           ,@EyeDischargeLeft 
           ,@EyeDischargeRight 
           ,@EyeRedReflexLeft 
           ,@EyeRedReflexRight 
           ,@EarPennaeLeft 
           ,@EarPennaeRight 
           ,@EarCanalLeft 
           ,@EarCanalRight 
           ,@EarDischarge 
           ,@EarPennaeNotes 
           ,@EarOther 
           ,@TMLeftNormal 
           ,@TMLeftWhite 
           ,@TMLeftRed 
           ,@TMLeftRellow 
           ,@TMLeftBulging 
           ,@TMLeftMobile 
           ,@TMLeftNonMobile 
           ,@TMLeftRaptured 
           ,@TMRightNormal 
           ,@TMRightWhite 
           ,@TMRightRed 
           ,@TMRightYellow 
           ,@TMRightBulging 
           ,@TMRightMobile 
           ,@TMRightNonMobile 
           ,@TMRightRuptured 
           ,@TMDischarge 
           ,@TMOther 
           ,@Nose 
           ,@NoseDischarge 
           ,@NoseOther 
           ,@Mouth 
           ,@MouthGums 
           ,@MouthOther 
           ,@Suck 
           ,@Throat 
           ,@ThroatOther 
           ,@Neck 
           ,@SwollenLymphNode 
           ,@NeckLeft 
           ,@NeckRight 
           ,@NeckOther 
           ,@LungRespiration 
           ,@LungRetratcions 
           ,@LungWheezes 
           ,@LungBreathSound 
           ,@LungDimishedLeft 
           ,@LungDimishedRight 
           ,@LungRhonchi 
           ,@LungRales 
           ,@LungIncRespRate 
           ,@LungOhter 
           ,@HeartRate 
           ,@HeartMurmur 
           ,@HeartIncreasedRate 
           ,@HeartDecreasedRate 
           ,@HeartIrregularRhythm 
           ,@HeartRub 
           ,@HeartPedal 
           ,@HeartOther 
           ,@AbdAbdomen 
           ,@AbdTender 
           ,@AbdMass 
           ,@AbdSize
           ,@AbdMassQuality 
           ,@AbdHernia 
           ,@UmbClean 
           ,@UmbDischarge 
           ,@UmbErythema 
           ,@UmbInduration 
           ,@UmbWarmtoTouch 
           ,@UmbHernia 
           ,@UmbOther 
           ,@GentTesties 
           ,@GentHydrocele 
           ,@GentUndescededLeft 
           ,@GentUndescededRight 
           ,@GentHernia 
           ,@GentPenis 
           ,@GentMeatus 
           ,@GentDischargeMale 
           ,@GentOtherMale 
           ,@GentNormal
           ,@GentLabia 
           ,@GentUrethra 
           ,@GentDishargeFemale 
           ,@GentMass 
           ,@GentSize 
           ,@GentOtherFemale 
           ,@MuscArms 
           ,@MuscWeekness 
           ,@MuscSwelling 
           ,@MuscTender 
           ,@MuscImmobile 
           ,@MuscDecStrength 
           ,@MuscOther 
           ,@HandSymmetry 
           ,@HandWeekness 
           ,@HandSwelling 
           ,@HandTender 
           ,@HandImmobile 
           ,@HandDecStrength 
           ,@HandFingers 
           ,@HandBruise 
           ,@HandExtraDigits 
           ,@HandSyndactyly 
           ,@HandOther 
           ,@LegSymmetry 
           ,@LegWeekness 
           ,@LegFlacid 
           ,@LegNomalTone 
           ,@LegSwelling 
           ,@LegTender 
           ,@LegImmobile 
           ,@LegDecStrength 
           ,@LegOther 
           ,@FeetSymmetry 
           ,@FeetWeekness 
           ,@FeetSwelling 
           ,@FeetTender 
           ,@FeetImmobile 
           ,@FeetDecStrength 
           ,@FeetClubFoot 
           ,@FeetToes 
           ,@FeetExtraDigits 
           ,@FeetSyndactyly 
           ,@FeetOther 
           ,@HipSymmetry 
           ,@HipLeft 
           ,@HipRight 
           ,@NeuroAwake 
           ,@NeuroAlert 
           ,@NeuroActive 
           ,@NeuroDecConsciousness 
           ,@NeuroAgitated 
           ,@NeuroConvelsions 
           ,@NeuroListLess 
           ,@NeuroLethargic 
           ,@NeuroFlaccid 
           ,@ReflexMoro 
           ,@ReflexGrasp 
           ,@ReflexRooting 
           ,@ReflexGalant 
           ,@ReflexStepping 
           ,@ReflexOther
           ,@SkinNormal 
           ,@Rashflat 
           ,@RashRaised 
           ,@RashErythema 
           ,@RashMacules 
           ,@RashPapules 
           ,@RashPetechie 
           ,@RashSize
           ,@RashOther 
           ,@BfSuck 
           ,@BfLatchingOn 
           ,@BfSpitting 
           ,@BfVomiting 
           ,@BfNasalObstruction 
           ,@BfOther 
           ,@DsFever 
           ,@DsPoorFeeding 
           ,@DsCrying 
           ,@DsLethargy 
           ,@DsHardToWakeup 
           ,@DsNoUrination 
           ,@DsNoBowelMovement 
           ,@DsVomiting 
           ,@DsDiarrhea 
           ,@DsReturn 
           ,@Hgb 
           ,@BloodGroup 
           ,@HepB 
           ,@Protein 
           ,@Glucose 
           ,@BloodSugar 
           ,@WBC 
           ,@GramStain 
           ,@Keytone 
           ,@Blood 
           ,@Polio 
           ,@BCG 
           ,@Bilirubin 
           ,@Notes
           ,@Plan 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_Infant_Populate]
 @MrNumber bigint
 as
SELECT        Pni.PostNatalInfantId,P.PatientName, Pni.PatientId, Pni.InfantDOB, Pni.InfantAge, Pni.DeliveryCondition, Pni.DeliveryTerm, Pni.DeliveryHospital, Pni.DeliveryMaternityHome, Pni.DeliveryHome, Pni.Alert, Pni.Listless, Pni.Jaundice, Pni.Active, 
                         Pni.Agitated, Pni.Pale, Pni.Smiling, Pni.Convulsions, Pni.Crying, Pni.NonResponse, Pni.Lethargic, Pni.ColorPink, Pni.Other, Pni.InfantCondition, Pni.Gender, Pni.BreastFeeding, Pni.FeedingCondition, Pni.Temperature, 
                         Pni.Weight, Pni.WeightPercentile, Pni.BirthWieght, Pni.BirthWieghtPercentile, Pni.Length, Pni.LengthPercentile, Pni.HC, Pni.HCPercentile, Pni.Head, Pni.AntFontAnelle, Pni.PostFontAnelle, Pni.Sutures, Pni.Cephalohematoma, 
                         Pni.EyePupils, Pni.EyeSclera, Pni.EyeConjuctiva, Pni.EyeDischargeLeft, Pni.EyedischargeRight, Pni.EyeRedReflex, Pni.TMLeftNormal, Pni.TMLeftWhite, Pni.TMLeftRed, Pni.TMLeftRellow, Pni.TMLeftBulging, Pni.TMLeftMobile, 
                         Pni.TMLeftNonMobile, Pni.TMLeftRaptured, Pni.TMRightNormal, Pni.TMRightWhite, Pni.TMRightRed, Pni.TMRightYellow, Pni.TMRightBulging, Pni.TMRightMobile, Pni.TMRightNonMobile, Pni.TMRightRaptured, Pni.TMDischarge,
                          Pni.Neck, Pni.SwollenLymphNode, Pni.NeckLeft, Pni.NeckRight, Pni.Suck, Pni.Mouth, Pni.Throat, Pni.Nose, Pni.NoseDischarge, Pni.EarPennaeLeft, Pni.EarPennaeRight, Pni.EarCanalLeft, Pni.EarCanalRight, Pni.EarDischarge, 
                         Pni.EarPennaeNotes 
FROM            PostNatal_Infant AS Pni INNER JOIN
                         PatientInfo AS P ON Pni.PatientId = P.PatientId  
						 where  P.MrNumber=@MrNumber






GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_Infant_SelectAll]
 as

SELECT        Pni.PostNatalInfantId, Pni.PatientId, P.PatientName, Pni.InfantDOB, Pni.InfantAge, Pni.Gender, Pni.DeliveryCondition, Pni.DeliveryTerm, Pni.DeliveryHospital, Pni.DeliveryMaternityHome, Pni.DeliveryHome, Pni.Alert, Pni.Listless, Pni.Jaundice, 
                         Pni.Active, Pni.Agitated, Pni.Pale, Pni.Smiling, Pni.Convulsions, Pni.Crying, Pni.NonResponse, Pni.Lethargic, Pni.ColorPink, Pni.Other, Pni.InfantCondition, Pni.BreastFeeding, Pni.FeedingCondition, Pni.Temperature, Pni.Weight, 
                         Pni.WeightPercentile, Pni.BirthWieght, Pni.BirthWieghtPercentile, Pni.Length, Pni.LengthPercentile, Pni.HC, Pni.HCPercentile, Pni.Head, Pni.AntFontAnelle, Pni.PostFontAnelle, Pni.Sutures, Pni.CephalohematomaLeft, 
                         Pni.CephalohematomaRight, Pni.HeadOther, Pni.EyePupils, Pni.EyeSclera, Pni.EyeConjuctiva, Pni.EyeDischargeLeft, Pni.EyeDischargeRight, Pni.EyeRedReflexLeft, Pni.EyeRedReflexRight, Pni.EarPennaeLeft, 
                         Pni.EarPennaeRight, Pni.EarCanalLeft, Pni.EarCanalRight, Pni.EarDischarge, Pni.EarPennaeNotes, Pni.EarOther, Pni.TMLeftNormal, Pni.TMLeftWhite, Pni.TMLeftRed, Pni.TMLeftRellow, Pni.TMLeftBulging, Pni.TMLeftMobile, 
                         Pni.TMLeftNonMobile, Pni.TMLeftRaptured, Pni.TMRightNormal, Pni.TMRightWhite, Pni.TMRightRed, Pni.TMRightYellow, Pni.TMRightBulging, Pni.TMRightMobile, Pni.TMRightNonMobile, Pni.TMRightRuptured, Pni.TMDischarge,
                          Pni.TMOther, Pni.Nose, Pni.NoseDischarge, Pni.NoseOther, Pni.Mouth, Pni.MouthGums, Pni.MouthOther, Pni.Suck, Pni.Throat, Pni.ThroatOther, Pni.Neck, Pni.SwollenLymphNode, Pni.NeckLeft, Pni.NeckRight, Pni.NeckOther, 
                         Pni.LungRespiration, Pni.LungRetratcions, Pni.LungWheezes, Pni.LungBreathSound, Pni.LungDimishedLeft, Pni.LungDimishedRight, Pni.LungRhonchi, Pni.LungRales, Pni.LungIncRespRate, Pni.LungOhter, Pni.HeartRate, 
                         Pni.HeartMurmur, Pni.HeartIncreasedRate, Pni.HeartDecreasedRate, Pni.HeartIrregularRhythm, Pni.HeartRub, Pni.HeartPedal, Pni.HeartOther, Pni.AbdAbdomen, Pni.AbdTender, Pni.AbdMass, Pni.AbdSize, Pni.AbdMassQuality, 
                         Pni.AbdHernia, Pni.UmbClean, Pni.UmbDischarge, Pni.UmbErythema, Pni.UmbInduration, Pni.UmbWarmtoTouch, Pni.UmbHernia, Pni.UmbOther, Pni.GentTesties, Pni.GentHydrocele, Pni.GentUndescededLeft, 
                         Pni.GentUndescededRight, Pni.GentHernia, Pni.GentPenis, Pni.GentMeatus, Pni.GentDischargeMale, Pni.GentOtherMale, Pni.GentNormal, Pni.GentLabia, Pni.GentUrethra, Pni.GentDishargeFemale, Pni.GentMass, Pni.GentSize, 
                         Pni.GentOtherFemale, Pni.MuscArms, Pni.MuscWeekness, Pni.MuscSwelling, Pni.MuscTender, Pni.MuscImmobile, Pni.MuscDecStrength, Pni.MuscOther, Pni.HandSymmetry, Pni.HandWeekness, Pni.HandSwelling, 
                         Pni.HandTender, Pni.HandImmobile, Pni.HandDecStrength, Pni.HandFingers, Pni.HandBruise, Pni.HandExtraDigits, Pni.HandSyndactyly, Pni.HandOther, Pni.LegSymmetry, Pni.LegWeekness, Pni.LegFlacid, Pni.LegNomalTone, 
                         Pni.LegSwelling, Pni.LegTender, Pni.LegImmobile, Pni.LegDecStrength, Pni.LegOther, Pni.FeetSymmetry, Pni.FeetWeekness, Pni.FeetSwelling, Pni.FeetTender, Pni.FeetImmobile, Pni.FeetDecStrength, Pni.FeetClubFoot, 
                         Pni.FeetToes, Pni.FeetExtraDigits, Pni.FeetSyndactyly, Pni.FeetOther, Pni.HipSymmetry, Pni.HipLeft, Pni.HipRight, Pni.NeuroAwake, Pni.NeuroAlert, Pni.NeuroActive, Pni.NeuroDecConsciousness, Pni.NeuroAgitated, 
                         Pni.NeuroConvelsions, Pni.NeuroListLess, Pni.NeuroLethargic, Pni.NeuroFlaccid, Pni.ReflexMoro, Pni.ReflexGrasp, Pni.ReflexRooting, Pni.ReflexGalant, Pni.ReflexStepping, Pni.ReflexOther, Pni.SkinNormal, Pni.Rashflat, 
                         Pni.RashRaised, Pni.RashErythema, Pni.RashMacules, Pni.RashPapules, Pni.RashPetechie, Pni.RashSize, Pni.RashOther, Pni.BfSuck, Pni.BfLatchingOn, Pni.BfSpitting, Pni.BfVomiting, Pni.BfNasalObstruction, Pni.BfOther, 
                         Pni.DsFever, Pni.DsPoorFeeding, Pni.DsCrying, Pni.DsLethargy, Pni.DsHardToWakeup, Pni.DsNoUrination, Pni.DsNoBowelMovement, Pni.DsVomiting, Pni.DsDiarrhea, Pni.DsReturn, Pni.Hgb, Pni.BloodGroup, Pni.HepB, 
                         Pni.Protein, Pni.Glucose, Pni.BloodSugar, Pni.WBC, Pni.GramStain, Pni.Keytone, Pni.Blood, Pni.Polio, Pni.BCG, Pni.Bilirubin, Pni.Notes, Pni.[Plan]
FROM            PostNatal_Infant AS Pni INNER JOIN
                         PatientInfo AS P ON Pni.PatientId = P.PatientId
						order by Pni.PostNatalInfantId desc
					






GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_Infant_SelectByID]
 @PostNatalInfantId int
 as
SELECT        Pni.PostNatalInfantId, Pni.PatientId, P.PatientName, Pni.InfantDOB, Pni.InfantAge, Pni.Gender, Pni.DeliveryCondition, Pni.DeliveryTerm, Pni.DeliveryHospital, Pni.DeliveryMaternityHome, Pni.DeliveryHome, Pni.Alert, Pni.Listless, Pni.Jaundice, 
                         Pni.Active, Pni.Agitated, Pni.Pale, Pni.Smiling, Pni.Convulsions, Pni.Crying, Pni.NonResponse, Pni.Lethargic, Pni.ColorPink, Pni.Other, Pni.InfantCondition, Pni.BreastFeeding, Pni.FeedingCondition, Pni.Temperature, Pni.Weight, 
                         Pni.WeightPercentile, Pni.BirthWieght, Pni.BirthWieghtPercentile, Pni.Length, Pni.LengthPercentile, Pni.HC, Pni.HCPercentile, Pni.Head, Pni.AntFontAnelle, Pni.PostFontAnelle, Pni.Sutures, Pni.CephalohematomaLeft, 
                         Pni.CephalohematomaRight, Pni.HeadOther, Pni.EyePupils, Pni.EyeSclera, Pni.EyeConjuctiva, Pni.EyeDischargeLeft, Pni.EyeDischargeRight, Pni.EyeRedReflexLeft, Pni.EyeRedReflexRight, Pni.EarPennaeLeft, 
                         Pni.EarPennaeRight, Pni.EarCanalLeft, Pni.EarCanalRight, Pni.EarDischarge, Pni.EarPennaeNotes, Pni.EarOther, Pni.TMLeftNormal, Pni.TMLeftWhite, Pni.TMLeftRed, Pni.TMLeftRellow, Pni.TMLeftBulging, Pni.TMLeftMobile, 
                         Pni.TMLeftNonMobile, Pni.TMLeftRaptured, Pni.TMRightNormal, Pni.TMRightWhite, Pni.TMRightRed, Pni.TMRightYellow, Pni.TMRightBulging, Pni.TMRightMobile, Pni.TMRightNonMobile, Pni.TMRightRuptured, Pni.TMDischarge,
                          Pni.TMOther, Pni.Nose, Pni.NoseDischarge, Pni.NoseOther, Pni.Mouth, Pni.MouthGums, Pni.MouthOther, Pni.Suck, Pni.Throat, Pni.ThroatOther, Pni.Neck, Pni.SwollenLymphNode, Pni.NeckLeft, Pni.NeckRight, Pni.NeckOther, 
                         Pni.LungRespiration, Pni.LungRetratcions, Pni.LungWheezes, Pni.LungBreathSound, Pni.LungDimishedLeft, Pni.LungDimishedRight, Pni.LungRhonchi, Pni.LungRales, Pni.LungIncRespRate, Pni.LungOhter, Pni.HeartRate, 
                         Pni.HeartMurmur, Pni.HeartIncreasedRate, Pni.HeartDecreasedRate, Pni.HeartIrregularRhythm, Pni.HeartRub, Pni.HeartPedal, Pni.HeartOther, Pni.AbdAbdomen, Pni.AbdTender, Pni.AbdMass, Pni.AbdSize, Pni.AbdMassQuality, 
                         Pni.AbdHernia, Pni.UmbClean, Pni.UmbDischarge, Pni.UmbErythema, Pni.UmbInduration, Pni.UmbWarmtoTouch, Pni.UmbHernia, Pni.UmbOther, Pni.GentTesties, Pni.GentHydrocele, Pni.GentUndescededLeft, 
                         Pni.GentUndescededRight, Pni.GentHernia, Pni.GentPenis, Pni.GentMeatus, Pni.GentDischargeMale, Pni.GentOtherMale, Pni.GentNormal, Pni.GentLabia, Pni.GentUrethra, Pni.GentDishargeFemale, Pni.GentMass, Pni.GentSize, 
                         Pni.GentOtherFemale, Pni.MuscArms, Pni.MuscWeekness, Pni.MuscSwelling, Pni.MuscTender, Pni.MuscImmobile, Pni.MuscDecStrength, Pni.MuscOther, Pni.HandSymmetry, Pni.HandWeekness, Pni.HandSwelling, 
                         Pni.HandTender, Pni.HandImmobile, Pni.HandDecStrength, Pni.HandFingers, Pni.HandBruise, Pni.HandExtraDigits, Pni.HandSyndactyly, Pni.HandOther, Pni.LegSymmetry, Pni.LegWeekness, Pni.LegFlacid, Pni.LegNomalTone, 
                         Pni.LegSwelling, Pni.LegTender, Pni.LegImmobile, Pni.LegDecStrength, Pni.LegOther, Pni.FeetSymmetry, Pni.FeetWeekness, Pni.FeetSwelling, Pni.FeetTender, Pni.FeetImmobile, Pni.FeetDecStrength, Pni.FeetClubFoot, 
                         Pni.FeetToes, Pni.FeetExtraDigits, Pni.FeetSyndactyly, Pni.FeetOther, Pni.HipSymmetry, Pni.HipLeft, Pni.HipRight, Pni.NeuroAwake, Pni.NeuroAlert, Pni.NeuroActive, Pni.NeuroDecConsciousness, Pni.NeuroAgitated, 
                         Pni.NeuroConvelsions, Pni.NeuroListLess, Pni.NeuroLethargic, Pni.NeuroFlaccid, Pni.ReflexMoro, Pni.ReflexGrasp, Pni.ReflexRooting, Pni.ReflexGalant, Pni.ReflexStepping, Pni.ReflexOther, Pni.SkinNormal, Pni.Rashflat, 
                         Pni.RashRaised, Pni.RashErythema, Pni.RashMacules, Pni.RashPapules, Pni.RashPetechie, Pni.RashSize, Pni.RashOther, Pni.BfSuck, Pni.BfLatchingOn, Pni.BfSpitting, Pni.BfVomiting, Pni.BfNasalObstruction, Pni.BfOther, 
                         Pni.DsFever, Pni.DsPoorFeeding, Pni.DsCrying, Pni.DsLethargy, Pni.DsHardToWakeup, Pni.DsNoUrination, Pni.DsNoBowelMovement, Pni.DsVomiting, Pni.DsDiarrhea, Pni.DsReturn, Pni.Hgb, Pni.BloodGroup, Pni.HepB, 
                         Pni.Protein, Pni.Glucose, Pni.BloodSugar, Pni.WBC, Pni.GramStain, Pni.Keytone, Pni.Blood, Pni.Polio, Pni.BCG, Pni.Bilirubin, Pni.Notes, Pni.[Plan]
FROM            PostNatal_Infant AS Pni INNER JOIN
                         PatientInfo AS P ON Pni.PatientId = P.PatientId
						 where  Pni.PostNatalInfantId=@PostNatalInfantId






GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_Infant_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_Infant_Update]
 @PostNatalInfantId int
,@PatientId int								=NULL
,@InfantDOB date							=NULL
,@InfantAge nvarchar(50)					=NULL
,@Gender nvarchar(50)						=NULL
,@DeliveryCondition nvarchar(50)			=NULL
,@DeliveryTerm nvarchar(50)					=NULL
,@DeliveryHospital bit						=NULL
,@DeliveryMaternityHome bit					=NULL
,@DeliveryHome bit							=NULL
,@Alert bit									=NULL
,@Listless bit								=NULL
,@Jaundice bit								=NULL
,@Active bit								=NULL
,@Agitated bit								=NULL
,@Pale bit									=NULL
,@Smiling bit								=NULL
,@Convulsions bit							=NULL
,@Crying bit								=NULL
,@NonResponse bit							=NULL
,@Lethargic bit								=NULL
,@ColorPink bit								=NULL
,@Other bit									=NULL
,@InfantCondition nvarchar(50)				=NULL
,@BreastFeeding bit							=NULL
,@FeedingCondition nvarchar(50)				=NULL
,@Temperature decimal(4,0)					=NULL
,@Weight decimal(4,0)						=NULL
,@WeightPercentile nvarchar(50)				=NULL
,@BirthWieght decimal(4,0)					=NULL
,@BirthWieghtPercentile nvarchar(50)		=NULL
,@Length nvarchar(50)						=NULL
,@LengthPercentile nvarchar(50)				=NULL
,@HC nvarchar(50)							=NULL
,@HCPercentile nvarchar(50)					=NULL
,@Head nvarchar(50)							=NULL
,@AntFontAnelle nvarchar(50)				=NULL
,@PostFontAnelle nvarchar(50)				=NULL
,@Sutures nvarchar(50)						=NULL
,@CephalohematomaLeft bit					=NULL
,@CephalohematomaRight bit					=NULL
,@HeadOther nvarchar(150)					=NULL
,@EyePupils nvarchar(50)					=NULL
,@EyeSclera nvarchar(50)					=NULL
,@EyeConjuctiva nvarchar(50)				=NULL
,@EyeDischargeLeft nvarchar(50)				=NULL
,@EyeDischargeRight nvarchar(50)			=NULL
,@EyeRedReflexLeft nvarchar(50)				=NULL
,@EyeRedReflexRight nvarchar(50)			=NULL
,@EarPennaeLeft nvarchar(50)				=NULL
,@EarPennaeRight nvarchar(50)				=NULL
,@EarCanalLeft nvarchar(50)					=NULL
,@EarCanalRight nvarchar(50)				=NULL
,@EarDischarge nvarchar(50)					=NULL
,@EarPennaeNotes nvarchar(50)				=NULL
,@EarOther nvarchar(150)					=NULL
,@TMLeftNormal bit							=NULL
,@TMLeftWhite bit							=NULL
,@TMLeftRed bit								=NULL
,@TMLeftRellow bit							=NULL
,@TMLeftBulging bit							=NULL
,@TMLeftMobile bit							=NULL
,@TMLeftNonMobile bit						=NULL
,@TMLeftRaptured bit						=NULL
,@TMRightNormal bit							=NULL
,@TMRightWhite bit							=NULL
,@TMRightRed bit							=NULL
,@TMRightYellow bit							=NULL
,@TMRightBulging bit						=NULL
,@TMRightMobile bit							=NULL
,@TMRightNonMobile bit						=NULL
,@TMRightRuptured bit						=NULL
,@TMDischarge nvarchar(50)					=NULL
,@TMOther nvarchar(50)						=NULL
,@Nose nvarchar(50)							=NULL
,@NoseDischarge nvarchar(50)				=NULL
,@NoseOther nvarchar(150)					=NULL
,@Mouth nvarchar(50)						=NULL
,@MouthGums nvarchar(50)					=NULL
,@MouthOther nvarchar(150)					=NULL
,@Suck nvarchar(50)							=NULL
,@Throat nvarchar(50)						=NULL
,@ThroatOther nvarchar(150)					=NULL
,@Neck nvarchar(50)							=NULL
,@SwollenLymphNode nvarchar(50)				=NULL
,@NeckLeft nvarchar(50)						=NULL
,@NeckRight nvarchar(50)					=NULL
,@NeckOther nvarchar(50)					=NULL
,@LungRespiration nvarchar(50)				=NULL
,@LungRetratcions bit						=NULL
,@LungWheezes bit							=NULL
,@LungBreathSound bit						=NULL
,@LungDimishedLeft bit						=NULL
,@LungDimishedRight bit						=NULL
,@LungRhonchi bit							=NULL
,@LungRales bit								=NULL
,@LungIncRespRate bit						=NULL
,@LungOhter nvarchar(150)					=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartMurmur nvarchar(50)					=NULL
,@HeartIncreasedRate bit					=NULL
,@HeartDecreasedRate bit					=NULL
,@HeartIrregularRhythm bit					=NULL
,@HeartRub bit								=NULL
,@HeartPedal nvarchar(50)					=NULL
,@HeartOther nvarchar(150)					=NULL
,@AbdAbdomen nvarchar(50)					=NULL
,@AbdTender nvarchar(50)					=NULL
,@AbdMass nvarchar(50)						=NULL
,@AbdSize decimal(18,0)						=NULL
,@AbdMassQuality nvarchar(50)				=NULL
,@AbdHernia nvarchar(50)					=NULL
,@UmbClean nvarchar(50)						=NULL
,@UmbDischarge nvarchar(50)					=NULL
,@UmbErythema bit							=NULL
,@UmbInduration bit							=NULL
,@UmbWarmtoTouch bit						=NULL
,@UmbHernia nvarchar(50)					=NULL
,@UmbOther nvarchar(150)					=NULL
,@GentTesties nvarchar(50)					=NULL
,@GentHydrocele bit							=NULL
,@GentUndescededLeft bit					=NULL
,@GentUndescededRight bit					=NULL
,@GentHernia nvarchar(50)					=NULL
,@GentPenis nvarchar(50)					=NULL
,@GentMeatus nvarchar(50)					=NULL
,@GentDischargeMale nvarchar(50)			=NULL
,@GentOtherMale nvarchar(150)				=NULL
,@GentNormal nvarchar(50)					=NULL
,@GentLabia nvarchar(50)					=NULL
,@GentUrethra nvarchar(50)					=NULL
,@GentDishargeFemale nvarchar(50)			=NULL
,@GentMass nvarchar(50)						=NULL
,@GentSize decimal(18,0)						=NULL
,@GentOtherFemale nvarchar(150)				=NULL
,@MuscArms nvarchar(50)						=NULL
,@MuscWeekness nvarchar(50)					=NULL
,@MuscSwelling nvarchar(50)					=NULL
,@MuscTender nvarchar(50)					=NULL
,@MuscImmobile nvarchar(50)					=NULL
,@MuscDecStrength nvarchar(50)				=NULL
,@MuscOther nvarchar(150)					=NULL
,@HandSymmetry nvarchar(50)					=NULL
,@HandWeekness nvarchar(50)					=NULL
,@HandSwelling nvarchar(50)					=NULL
,@HandTender nvarchar(50)					=NULL
,@HandImmobile nvarchar(50)					=NULL
,@HandDecStrength nvarchar(50)				=NULL
,@HandFingers nvarchar(50)					=NULL
,@HandBruise nvarchar(50)					=NULL
,@HandExtraDigits bit						=NULL
,@HandSyndactyly bit						=NULL
,@HandOther nvarchar(150)					=NULL
,@LegSymmetry nvarchar(50)					=NULL
,@LegWeekness nvarchar(50)					=NULL
,@LegFlacid nvarchar(50)					=NULL
,@LegNomalTone nvarchar(50)					=NULL
,@LegSwelling nvarchar(50)					=NULL
,@LegTender nvarchar(50)					=NULL
,@LegImmobile nvarchar(50)					=NULL
,@LegDecStrength nvarchar(50)				=NULL
,@LegOther nvarchar(50)						=NULL
,@FeetSymmetry nvarchar(50)					=NULL
,@FeetWeekness nvarchar(50)					=NULL
,@FeetSwelling nvarchar(50)					=NULL
,@FeetTender nvarchar(50)					=NULL
,@FeetImmobile nvarchar(50)					=NULL
,@FeetDecStrength nvarchar(50)				=NULL
,@FeetClubFoot nvarchar(50)					=NULL
,@FeetToes nvarchar(50)						=NULL
,@FeetExtraDigits bit						=NULL
,@FeetSyndactyly bit						=NULL
,@FeetOther nvarchar(150)					=NULL
,@HipSymmetry nvarchar(50)					=NULL
,@HipLeft nvarchar(50)						=NULL
,@HipRight nvarchar(50)						=NULL
,@NeuroAwake bit							=NULL
,@NeuroAlert bit							=NULL
,@NeuroActive bit							=NULL
,@NeuroDecConsciousness bit					=NULL
,@NeuroAgitated bit							=NULL
,@NeuroConvelsions bit						=NULL
,@NeuroListLess bit							=NULL
,@NeuroLethargic bit						=NULL
,@NeuroFlaccid bit							=NULL
,@ReflexMoro bit							=NULL
,@ReflexGrasp bit							=NULL
,@ReflexRooting bit							=NULL
,@ReflexGalant bit							=NULL
,@ReflexStepping bit						=NULL
,@ReflexOther nvarchar(150)					=NULL
,@SkinNormal nvarchar(50)					=NULL
,@Rashflat bit								=NULL
,@RashRaised bit							=NULL
,@RashErythema bit							=NULL
,@RashMacules bit							=NULL
,@RashPapules bit							=NULL
,@RashPetechie bit							=NULL
,@RashSize decimal(18,0)					=NULL
,@RashOther nvarchar(150)					=NULL
,@BfSuck bit								=NULL
,@BfLatchingOn bit							=NULL
,@BfSpitting bit							=NULL
,@BfVomiting bit							=NULL
,@BfNasalObstruction bit					=NULL
,@BfOther nvarchar(150)						=NULL
,@DsFever bit								=NULL
,@DsPoorFeeding bit							=NULL
,@DsCrying bit								=NULL
,@DsLethargy bit							=NULL
,@DsHardToWakeup bit						=NULL
,@DsNoUrination bit							=NULL
,@DsNoBowelMovement bit						=NULL
,@DsVomiting bit							=NULL
,@DsDiarrhea bit							=NULL
,@DsReturn bit								=NULL
,@Hgb nvarchar(50)							=NULL
,@BloodGroup nvarchar(50)					=NULL
,@HepB bit									=NULL
,@Protein nvarchar(50)						=NULL
,@Glucose nvarchar(50)						=NULL
,@BloodSugar nvarchar(50)					=NULL
,@WBC nvarchar(50)							=NULL
,@GramStain nvarchar(50)					=NULL
,@Keytone nvarchar(50)						=NULL
,@Blood nvarchar(50)						=NULL
,@Polio bit									=NULL
,@BCG bit									=NULL
,@Bilirubin nvarchar(150)					=NULL
,@Notes nvarchar(max)						=NULL
,@Plan nvarchar(max)						=NULL
as
begin
UPDATE PostNatal_Infant
   SET [PatientId] = @PatientId 
      ,[InfantDOB] = @InfantDOB 
      ,[InfantAge] = @InfantAge 
      ,[Gender] = @Gender 
      ,[DeliveryCondition] = @DeliveryCondition 
      ,[DeliveryTerm] = @DeliveryTerm 
      ,[DeliveryHospital] = @DeliveryHospital 
      ,[DeliveryMaternityHome] = @DeliveryMaternityHome 
      ,[DeliveryHome] = @DeliveryHome 
      ,[Alert] = @Alert 
      ,[Listless] = @Listless 
      ,[Jaundice] = @Jaundice 
      ,[Active] = @Active 
      ,[Agitated] = @Agitated 
      ,[Pale] = @Pale 
      ,[Smiling] = @Smiling 
      ,[Convulsions] = @Convulsions 
      ,[Crying] = @Crying 
      ,[NonResponse] = @NonResponse 
      ,[Lethargic] = @Lethargic 
      ,[ColorPink] = @ColorPink 
      ,[Other] = @Other 
      ,[InfantCondition] = @InfantCondition 
      ,[BreastFeeding] = @BreastFeeding 
      ,[FeedingCondition] = @FeedingCondition 
      ,[Temperature] = @Temperature 
      ,[Weight] = @Weight 
      ,[WeightPercentile] = @WeightPercentile 
      ,[BirthWieght] = @BirthWieght 
      ,[BirthWieghtPercentile] = @BirthWieghtPercentile 
      ,[Length] = @Length 
      ,[LengthPercentile] = @LengthPercentile 
      ,[HC] = @HC 
      ,[HCPercentile] = @HCPercentile 
      ,[Head] = @Head 
      ,[AntFontAnelle] = @AntFontAnelle 
      ,[PostFontAnelle] = @PostFontAnelle 
      ,[Sutures] = @Sutures 
      ,[CephalohematomaLeft] = @CephalohematomaLeft 
      ,[CephalohematomaRight] = @CephalohematomaRight 
      ,[HeadOther] = @HeadOther 
      ,[EyePupils] = @EyePupils 
      ,[EyeSclera] = @EyeSclera 
      ,[EyeConjuctiva] = @EyeConjuctiva 
      ,[EyeDischargeLeft] = @EyeDischargeLeft 
      ,[EyeDischargeRight] = @EyeDischargeRight 
      ,[EyeRedReflexLeft] = @EyeRedReflexLeft 
      ,[EyeRedReflexRight] = @EyeRedReflexRight 
      ,[EarPennaeLeft] = @EarPennaeLeft 
      ,[EarPennaeRight] = @EarPennaeRight 
      ,[EarCanalLeft] = @EarCanalLeft 
      ,[EarCanalRight] = @EarCanalRight 
      ,[EarDischarge] = @EarDischarge 
      ,[EarPennaeNotes] = @EarPennaeNotes 
      ,[EarOther] = @EarOther
      ,[TMLeftNormal] = @TMLeftNormal 
      ,[TMLeftWhite] = @TMLeftWhite 
      ,[TMLeftRed] = @TMLeftRed 
      ,[TMLeftRellow] = @TMLeftRellow 
      ,[TMLeftBulging] = @TMLeftBulging 
      ,[TMLeftMobile] = @TMLeftMobile 
      ,[TMLeftNonMobile] = @TMLeftNonMobile 
      ,[TMLeftRaptured] = @TMLeftRaptured 
      ,[TMRightNormal] = @TMRightNormal 
      ,[TMRightWhite] = @TMRightWhite 
      ,[TMRightRed] = @TMRightRed 
      ,[TMRightYellow] = @TMRightYellow 
      ,[TMRightBulging] = @TMRightBulging 
      ,[TMRightMobile] = @TMRightMobile 
      ,[TMRightNonMobile] = @TMRightNonMobile 
      ,[TMRightRuptured] = @TMRightRuptured 
      ,[TMDischarge] = @TMDischarge 
      ,[TMOther] = @TMOther 
      ,[Nose] = @Nose 
      ,[NoseDischarge] = @NoseDischarge 
      ,[NoseOther] = @NoseOther 
      ,[Mouth] = @Mouth 
      ,[MouthGums] = @MouthGums 
      ,[MouthOther] = @MouthOther 
      ,[Suck] = @Suck 
      ,[Throat] = @Throat 
      ,[ThroatOther] = @ThroatOther 
      ,[Neck] = @Neck 
      ,[SwollenLymphNode] = @SwollenLymphNode 
      ,[NeckLeft] = @NeckLeft 
      ,[NeckRight] = @NeckRight 
      ,[NeckOther] = @NeckOther 
      ,[LungRespiration] = @LungRespiration 
      ,[LungRetratcions] = @LungRetratcions 
      ,[LungWheezes] = @LungWheezes 
      ,[LungBreathSound] = @LungBreathSound 
      ,[LungDimishedLeft] = @LungDimishedLeft 
      ,[LungDimishedRight] = @LungDimishedRight 
      ,[LungRhonchi] = @LungRhonchi 
      ,[LungRales] = @LungRales 
      ,[LungIncRespRate] = @LungIncRespRate 
      ,[LungOhter] = @LungOhter 
      ,[HeartRate] = @HeartRate 
      ,[HeartMurmur] = @HeartMurmur 
      ,[HeartIncreasedRate] = @HeartIncreasedRate 
      ,[HeartDecreasedRate] = @HeartDecreasedRate 
      ,[HeartIrregularRhythm] = @HeartIrregularRhythm 
      ,[HeartRub] = @HeartRub 
      ,[HeartPedal] = @HeartPedal 
      ,[HeartOther] = @HeartOther 
      ,[AbdAbdomen] = @AbdAbdomen 
      ,[AbdTender] = @AbdTender 
      ,[AbdMass] = @AbdMass 
      ,[AbdSize] = @AbdSize 
      ,[AbdMassQuality] = @AbdMassQuality 
      ,[AbdHernia] = @AbdHernia 
      ,[UmbClean] = @UmbClean 
      ,[UmbDischarge] = @UmbDischarge 
      ,[UmbErythema] = @UmbErythema 
      ,[UmbInduration] = @UmbInduration 
      ,[UmbWarmtoTouch] = @UmbWarmtoTouch 
      ,[UmbHernia] = @UmbHernia 
      ,[UmbOther] = @UmbOther 
      ,[GentTesties] = @GentTesties 
      ,[GentHydrocele] = @GentHydrocele 
      ,[GentUndescededLeft] = @GentUndescededLeft 
      ,[GentUndescededRight] = @GentUndescededRight 
      ,[GentHernia] = @GentHernia 
      ,[GentPenis] = @GentPenis 
      ,[GentMeatus] = @GentMeatus 
      ,[GentDischargeMale] = @GentDischargeMale 
      ,[GentOtherMale] = @GentOtherMale 
      ,[GentNormal] = @GentNormal 
      ,[GentLabia] = @GentLabia 
      ,[GentUrethra] = @GentUrethra 
      ,[GentDishargeFemale] = @GentDishargeFemale 
      ,[GentMass] = @GentMass 
      ,[GentSize] = @GentSize 
      ,[GentOtherFemale] = @GentOtherFemale 
      ,[MuscArms] = @MuscArms 
      ,[MuscWeekness] = @MuscWeekness 
      ,[MuscSwelling] = @MuscSwelling 
      ,[MuscTender] = @MuscTender 
      ,[MuscImmobile] = @MuscImmobile 
      ,[MuscDecStrength] = @MuscDecStrength 
      ,[MuscOther] = @MuscOther 
      ,[HandSymmetry] = @HandSymmetry 
      ,[HandWeekness] = @HandWeekness 
      ,[HandSwelling] = @HandSwelling 
      ,[HandTender] = @HandTender 
      ,[HandImmobile] = @HandImmobile 
      ,[HandDecStrength] = @HandDecStrength 
      ,[HandFingers] = @HandFingers 
      ,[HandBruise] = @HandBruise 
      ,[HandExtraDigits] = @HandExtraDigits 
      ,[HandSyndactyly] = @HandSyndactyly 
      ,[HandOther] = @HandOther 
      ,[LegSymmetry] = @LegSymmetry 
      ,[LegWeekness] = @LegWeekness 
      ,[LegFlacid] = @LegFlacid 
      ,[LegNomalTone] = @LegNomalTone 
      ,[LegSwelling] = @LegSwelling 
      ,[LegTender] = @LegTender 
      ,[LegImmobile] = @LegImmobile 
      ,[LegDecStrength] = @LegDecStrength 
      ,[LegOther] = @LegOther 
      ,[FeetSymmetry] = @FeetSymmetry 
      ,[FeetWeekness] = @FeetWeekness 
      ,[FeetSwelling] = @FeetSwelling 
      ,[FeetTender] = @FeetTender 
      ,[FeetImmobile] = @FeetImmobile 
      ,[FeetDecStrength] = @FeetDecStrength 
      ,[FeetClubFoot] = @FeetClubFoot 
      ,[FeetToes] = @FeetToes 
      ,[FeetExtraDigits] = @FeetExtraDigits 
      ,[FeetSyndactyly] = @FeetSyndactyly 
      ,[FeetOther] = @FeetOther 
      ,[HipSymmetry] = @HipSymmetry 
      ,[HipLeft] = @HipLeft 
      ,[HipRight] = @HipRight 
      ,[NeuroAwake] = @NeuroAwake 
      ,[NeuroAlert] = @NeuroAlert 
      ,[NeuroActive] = @NeuroActive 
      ,[NeuroDecConsciousness] = @NeuroDecConsciousness 
      ,[NeuroAgitated] = @NeuroAgitated 
      ,[NeuroConvelsions] = @NeuroConvelsions 
      ,[NeuroListLess] = @NeuroListLess 
      ,[NeuroLethargic] = @NeuroLethargic 
      ,[NeuroFlaccid] = @NeuroFlaccid 
      ,[ReflexMoro] = @ReflexMoro 
      ,[ReflexGrasp] = @ReflexGrasp 
      ,[ReflexRooting] = @ReflexRooting 
      ,[ReflexGalant] = @ReflexGalant 
      ,[ReflexStepping] = @ReflexStepping 
      ,[ReflexOther] = @ReflexOther 
      ,[SkinNormal] = @SkinNormal 
      ,[Rashflat] = @Rashflat 
      ,[RashRaised] = @RashRaised 
      ,[RashErythema] = @RashErythema 
      ,[RashMacules] = @RashMacules 
      ,[RashPapules] = @RashPapules 
      ,[RashPetechie] = @RashPetechie 
      ,[RashSize] = @RashSize 
      ,[RashOther] = @RashOther 
      ,[BfSuck] = @BfSuck 
      ,[BfLatchingOn] = @BfLatchingOn 
      ,[BfSpitting] = @BfSpitting 
      ,[BfVomiting] = @BfVomiting 
      ,[BfNasalObstruction] = @BfNasalObstruction 
      ,[BfOther] = @BfOther 
      ,[DsFever] = @DsFever 
      ,[DsPoorFeeding] = @DsPoorFeeding 
      ,[DsCrying] = @DsCrying 
      ,[DsLethargy] = @DsLethargy 
      ,[DsHardToWakeup] = @DsHardToWakeup 
      ,[DsNoUrination] = @DsNoUrination 
      ,[DsNoBowelMovement] = @DsNoBowelMovement 
      ,[DsVomiting] = @DsVomiting 
      ,[DsDiarrhea] = @DsDiarrhea 
      ,[DsReturn] = @DsReturn 
      ,[Hgb] = @Hgb 
      ,[BloodGroup] = @BloodGroup 
      ,[HepB] = @HepB 
      ,[Protein] = @Protein 
      ,[Glucose] = @Glucose 
      ,[BloodSugar] = @BloodSugar 
      ,[WBC] = @WBC 
      ,[GramStain] = @GramStain 
      ,[Keytone] = @Keytone 
      ,[Blood] = @Blood 
      ,[Polio] = @Polio 
      ,[BCG] = @BCG 
      ,[Bilirubin] = @Bilirubin 
      ,[Notes] = @Notes 
      ,[Plan] = @Plan 
 WHERE PostNatalInfantId=@PostNatalInfantId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PostNatal_MotherPE_Delete]
 @PostNatalMotherPhysicalExamId int
as
begin
Delete from PostNatal_MotherPhysicalExamination  where PostNatalMotherPhysicalExamId=@PostNatalMotherPhysicalExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_MotherPE_Insert]
 @PatientId int								=NULL
,@InfantDOB date							=NULL
,@DeliveryHospital bit						=NULL
,@DeliveryMaternityHome bit					=NULL
,@DeliveryHome bit							=NULL
,@DeliveryCondition nvarchar(50)			=NULL
,@DeliveryTerm nvarchar(50)					=NULL
,@SkilledBirthAttendant bit					=NULL
,@Episiotomy bit							=NULL
,@InfantCondition nvarchar(50)				=NULL
,@Notes nvarchar(max)						=NULL
,@Bleeding bit								=NULL
,@Discharge bit								=NULL
,@DischargeType nvarchar(50)				=NULL
,@UrinationPain bit							=NULL
,@UrinationDifficulty bit					=NULL
,@UrinationDifficultyType nvarchar(50)		=NULL
,@Fever bit									=NULL
,@Pain bit									=NULL
,@PainAbdomen nvarchar(50)					=NULL
,@Appetite bit								=NULL
,@OtherConcerns nvarchar(max)				=NULL
,@TakePrenatalVitamins bit					=NULL
,@OtherMedication nvarchar(max)				=NULL
,@Weight decimal(4,0)						=NULL
,@Height decimal(4,0)						=NULL
,@Temperature decimal(4,0)					=NULL
,@Pulse decimal(4,0)						=NULL
,@BP decimal(4,0)							=NULL
,@Heent nvarchar(50)						=NULL
,@HeartMurmur bit							=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartRythm nvarchar(50)					=NULL
,@Abdomen nvarchar(50)						=NULL
,@AbdomenBowelSound bit						=NULL
,@FundalHeight nvarchar(50)					=NULL
,@Tender nvarchar(50)						=NULL
,@Mass nvarchar(50)							=NULL
,@MassQuality nvarchar(50)					=NULL
,@BreastLeftNormal bit						=NULL
,@BreastLeftAbnormal bit					=NULL
,@BreastLeftMass bit						=NULL
,@BreastLeftErythema bit					=NULL
,@BreastLeftTender bit						=NULL
,@BreastLeftDischargeMilk bit				=NULL
,@BreastLeftPus bit							=NULL
,@BreastLeftOther bit						=NULL
,@BreastRightNormal bit						=NULL
,@BreastRightAbnormal bit					=NULL
,@BreastRightMass bit						=NULL
,@BreastRightErythema bit					=NULL
,@BreastRightTender bit						=NULL
,@BreastRightDischargeMilk bit				=NULL
,@BreastRightPus bit						=NULL
,@BreastRightOther bit						=NULL
,@CsectionIncisionWellHealed bit			=NULL
,@CsectionIncisionNotwellhealed bit			=NULL
,@CsectionIncisionOpening bit				=NULL
,@WoundDischarge nvarchar(50)				=NULL
,@VagExamNormal bit							=NULL
,@VagExamBloodyDischarge bit				=NULL
,@VagExamNoDischarge bit					=NULL
,@VagExamTearHealing bit					=NULL
,@VagExamNoHealing bit						=NULL
,@VagExamSwollen bit						=NULL
,@VagExamTender bit							=NULL
,@VagExamNoTender bit						=NULL
,@LungsCondition nvarchar(50)				=NULL
,@LungLeftWheezes bit						=NULL
,@LungLeftRhonchi bit						=NULL
,@LungLeftRales bit							=NULL
,@LungLeftPoorAirEntry bit					=NULL
,@LungLeftOther bit							=NULL
,@LungRightWheezes bit						=NULL
,@LungRightRhonchi bit						=NULL
,@LungRightRales bit						=NULL
,@LungRightPoorAirEntry bit					=NULL
,@LungRightOther bit						=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO PostNatal_MotherPhysicalExamination
           ([PatientId]
           ,[InfantDOB]
           ,[DeliveryHospital]
           ,[DeliveryMaternityHome]
           ,[DeliveryHome]
           ,[DeliveryCondition]
           ,[DeliveryTerm]
           ,[SkilledBirthAttendant]
           ,[Episiotomy]
           ,[InfantCondition]
           ,[Notes]
           ,[Bleeding]
           ,[Discharge]
           ,[DischargeType]
           ,[UrinationPain]
           ,[UrinationDifficulty]
           ,[UrinationDifficultyType]
           ,[Fever]
           ,[Pain]
           ,[PainAbdomen]
           ,[Appetite]
           ,[OtherConcerns]
           ,[TakePrenatalVitamins]
           ,[OtherMedication]
           ,[Weight]
           ,[Height]
           ,[Temperature]
           ,[Pulse]
           ,[BP]
           ,[Heent]
           ,[HeartMurmur]
           ,[HeartRate]
           ,[HeartRythm]
           ,[Abdomen]
           ,[AbdomenBowelSound]
           ,[FundalHeight]
           ,[Tender]
           ,[Mass]
           ,[MassQuality]
           ,[BreastLeftNormal]
           ,[BreastLeftAbnormal]
           ,[BreastLeftMass]
           ,[BreastLeftErythema]
           ,[BreastLeftTender]
           ,[BreastLeftDischargeMilk]
           ,[BreastLeftPus]
           ,[BreastLeftOther]
           ,[BreastRightNormal]
           ,[BreastRightAbnormal]
           ,[BreastRightMass]
           ,[BreastRightErythema]
           ,[BreastRightTender]
           ,[BreastRightDischargeMilk]
           ,[BreastRightPus]
           ,[BreastRightOther]
           ,[CsectionIncisionWellHealed]
           ,[CsectionIncisionNotwellhealed]
           ,[CsectionIncisionOpening]
           ,[WoundDischarge]
           ,[VagExamNormal]
           ,[VagExamBloodyDischarge]
           ,[VagExamNoDischarge]
           ,[VagExamTearHealing]
           ,[VagExamNoHealing]
           ,[VagExamSwollen]
           ,[VagExamTender]
           ,[VagExamNoTender]
           ,[LungsCondition]
           ,[LungLeftWheezes]
           ,[LungLeftRhonchi]
           ,[LungLeftRales]
           ,[LungLeftPoorAirEntry]
           ,[LungLeftOther]
           ,[LungRightWheezes]
           ,[LungRightRhonchi]
           ,[LungRightRales]
           ,[LungRightPoorAirEntry]
           ,[LungRightOther])
    VALUES(
		    @PatientId						
           ,@InfantDOB 
           ,@DeliveryHospital 
           ,@DeliveryMaternityHome 
           ,@DeliveryHome 
           ,@DeliveryCondition 
           ,@DeliveryTerm 
           ,@SkilledBirthAttendant 
           ,@Episiotomy 
           ,@InfantCondition 
           ,@Notes
           ,@Bleeding 
           ,@Discharge 
           ,@DischargeType 
           ,@UrinationPain 
           ,@UrinationDifficulty 
           ,@UrinationDifficultyType 
           ,@Fever 
           ,@Pain 
           ,@PainAbdomen 
           ,@Appetite 
           ,@OtherConcerns 
           ,@TakePrenatalVitamins 
           ,@OtherMedication 
           ,@Weight 
           ,@Height
           ,@Temperature 
           ,@Pulse 
           ,@BP
           ,@Heent 
           ,@HeartMurmur 
           ,@HeartRate 
           ,@HeartRythm 
           ,@Abdomen 
           ,@AbdomenBowelSound 
           ,@FundalHeight 
           ,@Tender 
           ,@Mass 
           ,@MassQuality 
           ,@BreastLeftNormal 
           ,@BreastLeftAbnormal 
           ,@BreastLeftMass 
           ,@BreastLeftErythema 
           ,@BreastLeftTender 
           ,@BreastLeftDischargeMilk 
           ,@BreastLeftPus 
           ,@BreastLeftOther 
           ,@BreastRightNormal 
           ,@BreastRightAbnormal 
           ,@BreastRightMass 
           ,@BreastRightErythema 
           ,@BreastRightTender 
           ,@BreastRightDischargeMilk 
           ,@BreastRightPus 
           ,@BreastRightOther 
           ,@CsectionIncisionWellHealed 
           ,@CsectionIncisionNotwellhealed 
           ,@CsectionIncisionOpening 
           ,@WoundDischarge 
           ,@VagExamNormal 
           ,@VagExamBloodyDischarge 
           ,@VagExamNoDischarge 
           ,@VagExamTearHealing 
           ,@VagExamNoHealing 
           ,@VagExamSwollen 
           ,@VagExamTender 
           ,@VagExamNoTender 
           ,@LungsCondition 
           ,@LungLeftWheezes 
           ,@LungLeftRhonchi 
           ,@LungLeftRales 
           ,@LungLeftPoorAirEntry 
           ,@LungLeftOther 
           ,@LungRightWheezes 
           ,@LungRightRhonchi 
           ,@LungRightRales 
           ,@LungRightPoorAirEntry 
           ,@LungRightOther 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PostNatal_MotherPE_Populate]
 @MrNumber bigint
as
begin
SELECT        MPE.PostNatalMotherPhysicalExamId, MPE.PatientId, P.PatientName,MPE.InfantDOB, MPE.DeliveryHospital, MPE.DeliveryMaternityHome, MPE.DeliveryHome, MPE.DeliveryCondition, MPE.DeliveryTerm, MPE.SkilledBirthAttendant, 
                         MPE.Episiotomy, MPE.InfantCondition, MPE.Notes, MPE.Bleeding, MPE.Discharge, MPE.DischargeType, MPE.UrinationPain, MPE.UrinationDifficulty, MPE.UrinationDifficultyType, MPE.Fever, MPE.Pain, MPE.PainAbdomen, 
                         MPE.Appetite, MPE.OtherConcerns, MPE.TakePrenatalVitamins, MPE.OtherMedication, MPE.Weight, MPE.Height, MPE.Temperature, MPE.Pulse, MPE.BP, MPE.Heent, MPE.HeartMurmur, MPE.HeartRate, MPE.HeartRythm, 
                         MPE.Abdomen, MPE.AbdomenBowelSound, MPE.FundalHeight, MPE.Tender, MPE.Mass, MPE.MassQuality, MPE.BreastLeftNormal, MPE.BreastLeftAbnormal, MPE.BreastLeftMass, MPE.BreastLeftErythema, 
                         MPE.BreastLeftTender, MPE.BreastLeftDischargeMilk, MPE.BreastLeftPus, MPE.BreastLeftOther, MPE.BreastRightNormal, MPE.BreastRightAbnormal, MPE.BreastRightMass, MPE.BreastRightErythema, 
                         MPE.BreastRightTender, MPE.BreastRightDischargeMilk, MPE.BreastRightPus, MPE.BreastRightOther, MPE.CsectionIncisionWellHealed, MPE.CsectionIncisionNotwellhealed, MPE.CsectionIncisionOpening, 
                         MPE.WoundDischarge, MPE.VagExamNormal, MPE.VagExamBloodyDischarge, MPE.VagExamNoDischarge, MPE.VagExamTearHealing, MPE.VagExamNoHealing, MPE.VagExamSwollen, MPE.VagExamTender, 
                         MPE.VagExamNoTender, MPE.LungsCondition, MPE.LungLeftWheezes, MPE.LungLeftRhonchi, MPE.LungLeftRales, MPE.LungLeftPoorAirEntry, MPE.LungLeftOther, MPE.LungRightWheezes, MPE.LungRightRhonchi, 
                         MPE.LungRightRales, MPE.LungRightPoorAirEntry, MPE.LungRightOther
FROM            PostNatal_MotherPhysicalExamination AS MPE INNER JOIN
                         PatientInfo AS P ON MPE.PatientId = P.PatientId
						 where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PostNatal_MotherPE_SelectAll]
as
begin
SELECT        MPE.PostNatalMotherPhysicalExamId, MPE.PatientId, P.PatientName,MPE.InfantDOB, MPE.DeliveryHospital, MPE.DeliveryMaternityHome, MPE.DeliveryHome, MPE.DeliveryCondition, MPE.DeliveryTerm, MPE.SkilledBirthAttendant, 
                         MPE.Episiotomy, MPE.InfantCondition, MPE.Notes, MPE.Bleeding, MPE.Discharge, MPE.DischargeType, MPE.UrinationPain, MPE.UrinationDifficulty, MPE.UrinationDifficultyType, MPE.Fever, MPE.Pain, MPE.PainAbdomen, 
                         MPE.Appetite, MPE.OtherConcerns, MPE.TakePrenatalVitamins, MPE.OtherMedication, MPE.Weight, MPE.Height, MPE.Temperature, MPE.Pulse, MPE.BP, MPE.Heent, MPE.HeartMurmur, MPE.HeartRate, MPE.HeartRythm, 
                         MPE.Abdomen, MPE.AbdomenBowelSound, MPE.FundalHeight, MPE.Tender, MPE.Mass, MPE.MassQuality, MPE.BreastLeftNormal, MPE.BreastLeftAbnormal, MPE.BreastLeftMass, MPE.BreastLeftErythema, 
                         MPE.BreastLeftTender, MPE.BreastLeftDischargeMilk, MPE.BreastLeftPus, MPE.BreastLeftOther, MPE.BreastRightNormal, MPE.BreastRightAbnormal, MPE.BreastRightMass, MPE.BreastRightErythema, 
                         MPE.BreastRightTender, MPE.BreastRightDischargeMilk, MPE.BreastRightPus, MPE.BreastRightOther, MPE.CsectionIncisionWellHealed, MPE.CsectionIncisionNotwellhealed, MPE.CsectionIncisionOpening, 
                         MPE.WoundDischarge, MPE.VagExamNormal, MPE.VagExamBloodyDischarge, MPE.VagExamNoDischarge, MPE.VagExamTearHealing, MPE.VagExamNoHealing, MPE.VagExamSwollen, MPE.VagExamTender, 
                         MPE.VagExamNoTender, MPE.LungsCondition, MPE.LungLeftWheezes, MPE.LungLeftRhonchi, MPE.LungLeftRales, MPE.LungLeftPoorAirEntry, MPE.LungLeftOther, MPE.LungRightWheezes, MPE.LungRightRhonchi, 
                         MPE.LungRightRales, MPE.LungRightPoorAirEntry, MPE.LungRightOther
FROM            PostNatal_MotherPhysicalExamination AS MPE INNER JOIN
                         PatientInfo AS P ON MPE.PatientId = P.PatientId
						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PostNatal_MotherPE_SelectByID]
 @PostNatalMotherPhysicalExamId int
as
begin
SELECT        MPE.PostNatalMotherPhysicalExamId, MPE.PatientId, P.PatientName,MPE.InfantDOB, MPE.DeliveryHospital, MPE.DeliveryMaternityHome, MPE.DeliveryHome, MPE.DeliveryCondition, MPE.DeliveryTerm, MPE.SkilledBirthAttendant, 
                         MPE.Episiotomy, MPE.InfantCondition, MPE.Notes, MPE.Bleeding, MPE.Discharge, MPE.DischargeType, MPE.UrinationPain, MPE.UrinationDifficulty, MPE.UrinationDifficultyType, MPE.Fever, MPE.Pain, MPE.PainAbdomen, 
                         MPE.Appetite, MPE.OtherConcerns, MPE.TakePrenatalVitamins, MPE.OtherMedication, MPE.Weight, MPE.Height, MPE.Temperature, MPE.Pulse, MPE.BP, MPE.Heent, MPE.HeartMurmur, MPE.HeartRate, MPE.HeartRythm, 
                         MPE.Abdomen, MPE.AbdomenBowelSound, MPE.FundalHeight, MPE.Tender, MPE.Mass, MPE.MassQuality, MPE.BreastLeftNormal, MPE.BreastLeftAbnormal, MPE.BreastLeftMass, MPE.BreastLeftErythema, 
                         MPE.BreastLeftTender, MPE.BreastLeftDischargeMilk, MPE.BreastLeftPus, MPE.BreastLeftOther, MPE.BreastRightNormal, MPE.BreastRightAbnormal, MPE.BreastRightMass, MPE.BreastRightErythema, 
                         MPE.BreastRightTender, MPE.BreastRightDischargeMilk, MPE.BreastRightPus, MPE.BreastRightOther, MPE.CsectionIncisionWellHealed, MPE.CsectionIncisionNotwellhealed, MPE.CsectionIncisionOpening, 
                         MPE.WoundDischarge, MPE.VagExamNormal, MPE.VagExamBloodyDischarge, MPE.VagExamNoDischarge, MPE.VagExamTearHealing, MPE.VagExamNoHealing, MPE.VagExamSwollen, MPE.VagExamTender, 
                         MPE.VagExamNoTender, MPE.LungsCondition, MPE.LungLeftWheezes, MPE.LungLeftRhonchi, MPE.LungLeftRales, MPE.LungLeftPoorAirEntry, MPE.LungLeftOther, MPE.LungRightWheezes, MPE.LungRightRhonchi, 
                         MPE.LungRightRales, MPE.LungRightPoorAirEntry, MPE.LungRightOther
FROM            PostNatal_MotherPhysicalExamination AS MPE INNER JOIN
                         PatientInfo AS P ON MPE.PatientId = P.PatientId
						 where MPE.PostNatalMotherPhysicalExamId=@PostNatalMotherPhysicalExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PostNatal_MotherPE_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PostNatal_MotherPE_Update]
 @PostNatalMotherPhysicalExamId int
,@PatientId int								=NULL
,@InfantDOB date							=NULL
,@DeliveryHospital bit						=NULL
,@DeliveryMaternityHome bit					=NULL
,@DeliveryHome bit							=NULL
,@DeliveryCondition nvarchar(50)			=NULL
,@DeliveryTerm nvarchar(50)					=NULL
,@SkilledBirthAttendant bit					=NULL
,@Episiotomy bit							=NULL
,@InfantCondition nvarchar(50)				=NULL
,@Notes nvarchar(max)						=NULL
,@Bleeding bit								=NULL
,@Discharge bit								=NULL
,@DischargeType nvarchar(50)				=NULL
,@UrinationPain bit							=NULL
,@UrinationDifficulty bit					=NULL
,@UrinationDifficultyType nvarchar(50)		=NULL
,@Fever bit									=NULL
,@Pain bit									=NULL
,@PainAbdomen nvarchar(50)					=NULL
,@Appetite bit								=NULL
,@OtherConcerns nvarchar(max)				=NULL
,@TakePrenatalVitamins bit					=NULL
,@OtherMedication nvarchar(max)				=NULL
,@Weight decimal(4,0)						=NULL
,@Height decimal(4,0)						=NULL
,@Temperature decimal(4,0)					=NULL
,@Pulse decimal(4,0)						=NULL
,@BP decimal(4,0)							=NULL
,@Heent nvarchar(50)						=NULL
,@HeartMurmur bit							=NULL
,@HeartRate nvarchar(50)					=NULL
,@HeartRythm nvarchar(50)					=NULL
,@Abdomen nvarchar(50)						=NULL
,@AbdomenBowelSound bit						=NULL
,@FundalHeight nvarchar(50)					=NULL
,@Tender nvarchar(50)						=NULL
,@Mass nvarchar(50)							=NULL
,@MassQuality nvarchar(50)					=NULL
,@BreastLeftNormal bit						=NULL
,@BreastLeftAbnormal bit					=NULL
,@BreastLeftMass bit						=NULL
,@BreastLeftErythema bit					=NULL
,@BreastLeftTender bit						=NULL
,@BreastLeftDischargeMilk bit				=NULL
,@BreastLeftPus bit							=NULL
,@BreastLeftOther bit						=NULL
,@BreastRightNormal bit						=NULL
,@BreastRightAbnormal bit					=NULL
,@BreastRightMass bit						=NULL
,@BreastRightErythema bit					=NULL
,@BreastRightTender bit						=NULL
,@BreastRightDischargeMilk bit				=NULL
,@BreastRightPus bit						=NULL
,@BreastRightOther bit						=NULL
,@CsectionIncisionWellHealed bit			=NULL
,@CsectionIncisionNotwellhealed bit			=NULL
,@CsectionIncisionOpening bit				=NULL
,@WoundDischarge nvarchar(50)				=NULL
,@VagExamNormal bit							=NULL
,@VagExamBloodyDischarge bit				=NULL
,@VagExamNoDischarge bit					=NULL
,@VagExamTearHealing bit					=NULL
,@VagExamNoHealing bit						=NULL
,@VagExamSwollen bit						=NULL
,@VagExamTender bit							=NULL
,@VagExamNoTender bit						=NULL
,@LungsCondition nvarchar(50)				=NULL
,@LungLeftWheezes bit						=NULL
,@LungLeftRhonchi bit						=NULL
,@LungLeftRales bit							=NULL
,@LungLeftPoorAirEntry bit					=NULL
,@LungLeftOther bit							=NULL
,@LungRightWheezes bit						=NULL
,@LungRightRhonchi bit						=NULL
,@LungRightRales bit						=NULL
,@LungRightPoorAirEntry bit					=NULL
,@LungRightOther bit						=NULL

as
begin
UPDATE PostNatal_MotherPhysicalExamination
   SET [PatientId] = @PatientId 
      ,[InfantDOB] = @InfantDOB 
      ,[DeliveryHospital] = @DeliveryHospital 
      ,[DeliveryMaternityHome] = @DeliveryMaternityHome 
      ,[DeliveryHome] = @DeliveryHome 
      ,[DeliveryCondition] = @DeliveryCondition 
      ,[DeliveryTerm] = @DeliveryTerm 
      ,[SkilledBirthAttendant] = @SkilledBirthAttendant 
      ,[Episiotomy] = @Episiotomy 
      ,[InfantCondition] = @InfantCondition 
      ,[Notes] = @Notes 
      ,[Bleeding] = @Bleeding 
      ,[Discharge] = @Discharge 
      ,[DischargeType] = @DischargeType 
      ,[UrinationPain] = @UrinationPain 
      ,[UrinationDifficulty] = @UrinationDifficulty 
      ,[UrinationDifficultyType] = @UrinationDifficultyType 
      ,[Fever] = @Fever 
      ,[Pain] = @Pain 
      ,[PainAbdomen] = @PainAbdomen 
      ,[Appetite] = @Appetite 
      ,[OtherConcerns] = @OtherConcerns 
      ,[TakePrenatalVitamins] = @TakePrenatalVitamins 
      ,[OtherMedication] = @OtherMedication 
      ,[Weight] = @Weight 
      ,[Height] = @Height 
      ,[Temperature] = @Temperature 
      ,[Pulse] = @Pulse 
      ,[BP] = @BP 
      ,[Heent] = @Heent 
      ,[HeartMurmur] = @HeartMurmur 
      ,[HeartRate] = @HeartRate 
      ,[HeartRythm] = @HeartRythm 
      ,[Abdomen] = @Abdomen 
      ,[AbdomenBowelSound] = @AbdomenBowelSound 
      ,[FundalHeight] = @FundalHeight 
      ,[Tender] = @Tender 
      ,[Mass] = @Mass 
      ,[MassQuality] = @MassQuality 
      ,[BreastLeftNormal] = @BreastLeftNormal 
      ,[BreastLeftAbnormal] = @BreastLeftAbnormal 
      ,[BreastLeftMass] = @BreastLeftMass 
      ,[BreastLeftErythema] = @BreastLeftErythema 
      ,[BreastLeftTender] = @BreastLeftTender 
      ,[BreastLeftDischargeMilk] = @BreastLeftDischargeMilk 
      ,[BreastLeftPus] = @BreastLeftPus 
      ,[BreastLeftOther] = @BreastLeftOther 
      ,[BreastRightNormal] = @BreastRightNormal 
      ,[BreastRightAbnormal] = @BreastRightAbnormal 
      ,[BreastRightMass] = @BreastRightMass 
      ,[BreastRightErythema] = @BreastRightErythema 
      ,[BreastRightTender] = @BreastRightTender 
      ,[BreastRightDischargeMilk] = @BreastRightDischargeMilk 
      ,[BreastRightPus] = @BreastRightPus 
      ,[BreastRightOther] = @BreastRightOther 
      ,[CsectionIncisionWellHealed] = @CsectionIncisionWellHealed 
      ,[CsectionIncisionNotwellhealed] = @CsectionIncisionNotwellhealed 
      ,[CsectionIncisionOpening] = @CsectionIncisionOpening 
      ,[WoundDischarge] = @WoundDischarge 
      ,[VagExamNormal] = @VagExamNormal 
      ,[VagExamBloodyDischarge] = @VagExamBloodyDischarge 
      ,[VagExamNoDischarge] = @VagExamNoDischarge 
      ,[VagExamTearHealing] = @VagExamTearHealing 
      ,[VagExamNoHealing] = @VagExamNoHealing 
      ,[VagExamSwollen] = @VagExamSwollen 
      ,[VagExamTender] = @VagExamTender 
      ,[VagExamNoTender] = @VagExamNoTender 
      ,[LungsCondition] = @LungsCondition 
      ,[LungLeftWheezes] = @LungLeftWheezes 
      ,[LungLeftRhonchi] = @LungLeftRhonchi 
      ,[LungLeftRales] = @LungLeftRales 
      ,[LungLeftPoorAirEntry] = @LungLeftPoorAirEntry 
      ,[LungLeftOther] = @LungLeftOther 
      ,[LungRightWheezes] = @LungRightWheezes 
      ,[LungRightRhonchi] = @LungRightRhonchi 
      ,[LungRightRales] = @LungRightRales 
      ,[LungRightPoorAirEntry] = @LungRightPoorAirEntry 
      ,[LungRightOther] = @LungRightOther 
 WHERE PostNatalMotherPhysicalExamId=@PostNatalMotherPhysicalExamId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNatal_Assessment_Delete]
 @AssessmentId int
as
begin
Delete FROM PreNatal_Assessment where AssessmentId=@AssessmentId						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Assessment_Insert]
 @PatientId int=null
,@Notes nvarchar(max)=null
,@Error bit=null output
,@Message nvarchar(200)=null output
,@ID int output
as
begin
INSERT INTO [dbo].[PreNatal_Assessment]
           ([PatientId]
           ,[Notes])
     VALUES
           (@PatientId
           ,@Notes
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_PreNatal_Assessment_Populate]
 @MrNumber bigint

as
begin
SELECT        A.AssessmentId, A.PatientId, P.PatientName, A.Notes
FROM            PreNatal_Assessment A INNER JOIN
                         PatientInfo P ON A.PatientId = P.PatientId
						 where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Assessment_SelectAll]
as
begin
SELECT        A.AssessmentId, A.PatientId, P.PatientName, A.Notes
FROM            PreNatal_Assessment A INNER JOIN
                         PatientInfo P ON A.PatientId = P.PatientId order by  A.AssessmentId desc
						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Assessment_SelectByID]
 @AssessmentId int

as
begin
SELECT        A.AssessmentId, A.PatientId, P.PatientName, A.Notes
FROM            PreNatal_Assessment A INNER JOIN
                         PatientInfo P ON A.PatientId = P.PatientId
						 where A.AssessmentId=@AssessmentId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Assessment_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Assessment_Update]
 @AssessmentId int
,@PatientId int=null
,@Notes nvarchar(max)=null
as
begin
UPDATE  PreNatal_Assessment
   SET [PatientId] = @PatientId
      ,[Notes] =@Notes 
 WHERE AssessmentId=@AssessmentId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_Delete]
 @PreNatalPlanId int

as
begin
Delete from PreNatal_Plan where PreNatalPlanId=@PreNatalPlanId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_Insert]
@PatientId int
,@Notes nvarchar(max)
,@Error bit =null output
,@Message nvarchar(200)=null output  
,@ID int output
as
INSERT INTO [dbo].[PreNatal_Plan]
           ([PatientId]
           ,[Notes])
     VALUES
           (@PatientId
           ,@Notes)

		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY();

GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_Populate]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_Populate]
 @MrNumber bigint

as
begin
SELECT        PL.PreNatalPlanId, PL.PatientId, P.PatientName, PL.Notes,P.MrNumber
FROM            PreNatal_Plan PL INNER JOIN
                         PatientInfo P ON PL.PatientId = P.PatientId
						 where P.MrNumber=@MrNumber
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_SelectAll]

as
begin
SELECT        PreNatal_Plan.PreNatalPlanId, PreNatal_Plan.PatientId, PatientInfo.PatientName, PreNatal_Plan.Notes
FROM            PreNatal_Plan INNER JOIN
                         PatientInfo ON PreNatal_Plan.PatientId = PatientInfo.PatientId
						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_SelectByID]
 @PreNatalPlanId int

as
begin
SELECT        PreNatal_Plan.PreNatalPlanId, PreNatal_Plan.PatientId, PatientInfo.PatientName, PreNatal_Plan.Notes
FROM            PreNatal_Plan INNER JOIN
                         PatientInfo ON PreNatal_Plan.PatientId = PatientInfo.PatientId
						 where PreNatalPlanId=@PreNatalPlanId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatal_Plan_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatal_Plan_Update]
 @PreNatalPlanId int
,@PatientId int			=NULL
,@Notes nvarchar(max)	=NULL
as
begin
UPDATE PreNatal_Plan
   SET [PatientId] =  @PatientId
      ,[Notes] =      @Notes
 WHERE PreNatalPlanId=@PreNatalPlanId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep1_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PreNatalStep1_Delete]
@Id int
as
delete from  PreNatal_Step1 where PreNatalStep1Id=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep1_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNatalStep1_Insert]
  @PatientId int			=NULL
 ,@LastMestrualDate date	=NULL
 ,@EDD date					=NULL
 ,@Para nvarchar(250)		=NULL
 ,@Gravida nvarchar(250)	=NULL
 ,@Abortions int			=NULL
 ,@LastBabyBorn nvarchar(50)=NULL
 ,@EGA nvarchar(100)		=NULL
 ,@Error bit =null output
 ,@Message nvarchar(200)=null output  
 ,@ID int output 
as 
begin
INSERT INTO PreNatal_Step1
           ([PatientId]
		   ,[LastMestrualDate]
           ,[EDD]
           ,[Para]
           ,[Gravida]
           ,[Abortions]
           ,[LastBabyBorn]
           ,[EGA])
     VALUES
          ( @PatientId
		   ,@LastMestrualDate
           ,@EDD
           ,@Para
           ,@Gravida 
           ,@Abortions
           ,@LastBabyBorn
           ,@EGA
		   )

		set @Error=convert(bit,0)
		set @Message='Record saved Successfully <br/> Do you want to add another?'
		set @ID=SCOPE_IDENTITY();
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PrenatalStep1_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PrenatalStep1_SelectAll]
as
SELECT  PreNatal_Step1.PreNatalStep1Id, PatientInfo.PatientName, PreNatal_Step1.LastMestrualDate, PreNatal_Step1.EDD, PreNatal_Step1.Para, PreNatal_Step1.Gravida, PreNatal_Step1.Abortions, PreNatal_Step1.LastBabyBorn, PreNatal_Step1.EGA
FROM   PatientInfo INNER JOIN
PreNatal_Step1 ON PatientInfo.PatientId = PreNatal_Step1.PatientId order by PreNatal_Step1.PreNatalStep1Id desc

GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep1_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec [sp_PreNatalStep1_SelectByID] 1
CREATE proc [dbo].[sp_PreNatalStep1_SelectByID] 
@Id int
as
SELECT        Pso.PreNatalStep1Id, P.PatientName, Pso.LastMestrualDate, Pso.EDD, Pso.Para, Pso.Gravida, Pso.Abortions, Pso.LastBabyBorn, Pso.EGA
FROM            PreNatal_Step1 AS Pso INNER JOIN
                         PatientInfo AS P ON Pso.PatientId = P.PatientId
						 where Pso.PreNatalStep1Id=@Id



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep1_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNatalStep1_Update]
  @PreNatalStep1Id int
 ,@PatientId int			=NULL
 ,@LastMestrualDate date	=NULL
 ,@EDD date					=NULL
 ,@Para nvarchar(250)		=NULL
 ,@Gravida nvarchar(250)	=NULL
 ,@Abortions int			=NULL
 ,@LastBabyBorn nvarchar(50)=NULL
 ,@EGA nvarchar(100)		=NULL
as
begin
UPDATE PreNatal_Step1
   SET [PatientId] =@PatientId
   ,[LastMestrualDate]=@LastMestrualDate
      ,[EDD] =@EDD
      ,[Para] =@Para
      ,[Gravida] = @Gravida
      ,[Abortions] = @Abortions
      ,[LastBabyBorn] = @LastBabyBorn
      ,[EGA] = @EGA
 WHERE PreNatalStep1Id=@PreNatalStep1Id
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PrenatalStep2_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_PrenatalStep2_Delete]
@PreNatalStep2Id int
as
Delete from PreNatal_Step2 where PreNatalStep2Id=@PreNatalStep2Id 

GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep2_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNatalStep2_Insert]
 @PatientId int
,@DateOfDelivery date=null
,@CompBleeding bit=null
,@CompBP bit=null
,@CompStillBirth bit=null
,@CompHeavyBleeding bit=null
,@CompKidneyProblem bit=null
,@CompAnemia bit=null
,@CompCSection bit=null
,@CompEclampsia bit=null
,@CompFever bit=null
,@CompForcepsVaccum bit=null
,@CompPreEcplampsia bit=null
,@CompTwins bit=null
,@CompTear bit=null
,@CompSugar bit=null
,@CompTetanusImmunization bit=null
,@homeDelivery bit=null
,@MaternityHomeDelivery bit=null
,@HospitalDelivery bit=null
,@Notes nvarchar(max)=null
,@Error bit =null output
,@Message nvarchar(200)=null output  
,@ID int output 
as
begin
INSERT INTO PreNatal_Step2
           ([PatientId]
           ,[DateOfDelivery]
           ,[CompBleeding]
           ,[CompBP]
           ,[CompStillBirth]
           ,[CompHeavyBleeding]
           ,[CompKidneyProblem]
           ,[CompAnemia]
           ,[CompCSection]
           ,[CompEclampsia]
           ,[CompFever]
           ,[CompForcepsVaccum]
           ,[CompPreEcplampsia]
           ,[CompTwins]
           ,[CompTear]
           ,[CompSugar]
		   ,[CompTetanusImmunization]
           ,[homeDelivery]
           ,[MaternityHomeDelivery]
           ,[HospitalDelivery]
		   ,[Notes])
     VALUES
          ( @PatientId
           ,@DateOfDelivery
           ,@CompBleeding
           ,@CompBP
           ,@CompStillBirth
           ,@CompHeavyBleeding
           ,@CompKidneyProblem
           ,@CompAnemia
           ,@CompCSection
           ,@CompEclampsia
           ,@CompFever
           ,@CompForcepsVaccum
           ,@CompPreEcplampsia
           ,@CompTwins
           ,@CompTear
           ,@CompSugar
		   ,@CompTetanusImmunization
           ,@homeDelivery
           ,@MaternityHomeDelivery
           ,@HospitalDelivery
		   ,@Notes
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved Successfully <br/> Do you want to add another?'
		set @ID=SCOPE_IDENTITY();
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PrenatalStep2_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PrenatalStep2_SelectAll]
as
SELECT        PreNatal_Step2.PreNatalStep2Id, PreNatal_Step2.PatientId,PatientInfo.PatientName, PreNatal_Step2.DateOfDelivery, PreNatal_Step2.CompBleeding, PreNatal_Step2.CompBP, PreNatal_Step2.CompStillBirth, PreNatal_Step2.CompHeavyBleeding, 
                         PreNatal_Step2.CompKidneyProblem, PreNatal_Step2.CompCSection, PreNatal_Step2.CompAnemia, PreNatal_Step2.CompEclampsia, PreNatal_Step2.CompFever, PreNatal_Step2.CompForcepsVaccum, 
                         PreNatal_Step2.CompPreEcplampsia, PreNatal_Step2.CompTwins, PreNatal_Step2.CompTear, PreNatal_Step2.CompSugar,PreNatal_Step2.CompTetanusImmunization, PreNatal_Step2.MaternityHomeDelivery, PreNatal_Step2.homeDelivery, 
                         PreNatal_Step2.HospitalDelivery,PreNatal_Step2.Notes
FROM            PatientInfo INNER JOIN
                         PreNatal_Step2 ON PatientInfo.PatientId = PreNatal_Step2.PatientId order by PreNatal_Step2.PreNatalStep2Id desc

GO
/****** Object:  StoredProcedure [dbo].[sp_PrenatalStep2_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PrenatalStep2_SelectByID]
@PreNatalStep2Id int
as
SELECT        PreNatal_Step2.PreNatalStep2Id,PreNatal_Step2.PatientId, PatientInfo.PatientName, PreNatal_Step2.DateOfDelivery, PreNatal_Step2.CompBleeding, PreNatal_Step2.CompBP, PreNatal_Step2.CompStillBirth, PreNatal_Step2.CompHeavyBleeding, 
              PreNatal_Step2.CompKidneyProblem, PreNatal_Step2.CompCSection, PreNatal_Step2.CompAnemia, PreNatal_Step2.CompEclampsia, PreNatal_Step2.CompFever, PreNatal_Step2.CompForcepsVaccum, 
              PreNatal_Step2.CompPreEcplampsia, PreNatal_Step2.CompTwins, PreNatal_Step2.CompTear, PreNatal_Step2.CompSugar, PreNatal_Step2.CompTetanusImmunization, PreNatal_Step2.MaternityHomeDelivery, PreNatal_Step2.homeDelivery, 
              PreNatal_Step2.HospitalDelivery,PreNatal_Step2.Notes
FROM  PatientInfo INNER JOIN PreNatal_Step2 ON PatientInfo.PatientId = PreNatal_Step2.PatientId where PreNatalStep2Id=@PreNatalStep2Id

GO
/****** Object:  StoredProcedure [dbo].[sp_PreNatalStep2_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNatalStep2_Update]
 @PreNatalStep2Id int
,@PatientId int=null
,@DateOfDelivery date=null
,@CompBleeding bit=null
,@CompBP bit=null
,@CompStillBirth bit=null
,@CompHeavyBleeding bit=null
,@CompKidneyProblem bit=null
,@CompAnemia bit=null
,@CompCSection bit=null
,@CompEclampsia bit=null
,@CompFever bit=null
,@CompForcepsVaccum bit=null
,@CompPreEcplampsia bit=null
,@CompTwins bit=null
,@CompTear bit=null
,@CompSugar bit=null
,@CompTetanusImmunization bit=null
,@homeDelivery bit=null
,@MaternityHomeDelivery bit=null
,@HospitalDelivery bit=null
,@Notes nvarchar(max)=null
as
begin	   
UPDATE PreNatal_Step2
   SET [PatientId] = @PatientId
      ,[DateOfDelivery] = @DateOfDelivery
      ,[CompBleeding] = @CompBleeding
      ,[CompBP] = @CompBP
      ,[CompStillBirth] = @CompStillBirth
      ,[CompHeavyBleeding] = @CompHeavyBleeding
      ,[CompKidneyProblem] = @CompKidneyProblem
      ,[CompAnemia] =    @CompAnemia
      ,[CompCSection] =  @CompCSection
      ,[CompEclampsia] = @CompEclampsia
      ,[CompFever] =     @CompFever
      ,[CompForcepsVaccum] = @CompForcepsVaccum
      ,[CompPreEcplampsia] = @CompPreEcplampsia
      ,[CompTwins] = @CompTwins
      ,[CompTear] =  @CompTear
      ,[CompSugar] = @CompSugar
	  ,[CompTetanusImmunization]=@CompTetanusImmunization
      ,[homeDelivery] = @homeDelivery
      ,[MaternityHomeDelivery] = @MaternityHomeDelivery
      ,[HospitalDelivery] = @HospitalDelivery
	  ,[Notes]=@Notes
	  
	  where PreNatalStep2Id=@PreNatalStep2Id	   
   
end



GO
/****** Object:  StoredProcedure [dbo].[sp_PreNataStep2_PoplateByMRNo]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_PreNataStep2_PoplateByMRNo]
@MrNumber bigint
as
SELECT        PreNatal_Step2.PatientId, PreNatal_Step2.DateOfDelivery, PreNatal_Step2.CompBleeding, PreNatal_Step2.CompBP, PreNatal_Step2.CompStillBirth, PreNatal_Step2.CompHeavyBleeding, PreNatal_Step2.CompKidneyProblem, 
                         PreNatal_Step2.CompAnemia, PreNatal_Step2.CompCSection, PreNatal_Step2.CompEclampsia, PreNatal_Step2.CompFever, PreNatal_Step2.CompForcepsVaccum, PreNatal_Step2.CompPreEcplampsia, 
                         PreNatal_Step2.CompTwins, PreNatal_Step2.CompTear, PreNatal_Step2.CompSugar,PreNatal_Step2.CompTetanusImmunization, PreNatal_Step2.homeDelivery, PreNatal_Step2.MaternityHomeDelivery, PreNatal_Step2.HospitalDelivery, PreNatal_Step2.Notes                     
FROM            PatientInfo INNER JOIN
                         PreNatal_Step2 ON PatientInfo.PatientId = PreNatal_Step2.PatientId
						 where     PatientInfo.MrNumber=@MrNumber
GO
/****** Object:  StoredProcedure [dbo].[sp_PrenatlVisitSummary]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_PrenatlVisitSummary 1
CREATE proc [dbo].[sp_PrenatlVisitSummary] 
@MrNumber int
as
SELECT distinct p.PatientName,  pe.VisitNo as Visit, isnull(pe.Weight,0) as Weight, isnull(pe.BP,0) as BP, isnull(pe.FundalHeight,0) as FH, 
convert(nvarchar,case when pe.FetalMovement=1 then '+' else '-'end) as [Fetal Movement], 
lt.Hgb,
lt.BloodGroup+','+ 
lt.Protein+',' +
lt.Glucose+',' +
--lt.BloodSugar+','+ 
lt.WBC+',' +
--lt.GramStain+','+ 
lt.Blood+',' +
lt.Keytone as Tests, 
convert(nvarchar, case when m.TT=1 then 'TT' end)+','+ 
convert(nvarchar, case when m.PreNatalVitamins=1 then 'PNV'end) +','+ 
convert(nvarchar, case when m.Calcium=1 then 'Calcium' end) +','+ 
convert(nvarchar, case when m.HepBVaccine=1 then 'Hep B' end) +','+ 
convert(nvarchar, case when m.ReviewDangerSigns=1 then 'Danger Signs' end) as Medications

FROM   PatientInfo AS p INNER JOIN
       PreNatal_PhysicalExamination AS pe ON p.PatientId = pe.PatientId INNER JOIN
       PreNatal_LabTest AS lt ON p.PatientId = lt.PatientId INNER JOIN
       PreNatal_Medication AS m ON p.PatientId = m.PatientId where MrNumber=@MrNumber and lt.CheckupOf='Mother' and m.CheckupOf='Mother'

	   --select * from PreNatal_PhysicalExamination
	   --select * from PreNatal_LabTest
	   --select * from PreNatal_Medication
	   
GO
/****** Object:  StoredProcedure [dbo].[sp_Roles_IsLoked]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec sp_Roles_IsLoked 'admin'
CREATE proc [dbo].[sp_Roles_IsLoked]
@UserName nvarchar(256)
as
select * from AspNetUsers where IsLocked=1 and UserName=@UserName
GO
/****** Object:  StoredProcedure [dbo].[sp_Roles_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Roles_SelectAll]
as
SELECT        AspNetUsers.Id, AspNetRoles.Name as [Role], AspNetUsers.UserName,AspNetUsers.Email,AspNetUsers.IsLocked
FROM            AspNetUsers INNER JOIN
                         AspNetUserRoles ON AspNetUsers.Id = AspNetUserRoles.UserId INNER JOIN
                         AspNetRoles ON AspNetUserRoles.RoleId = AspNetRoles.Id 



						
GO
/****** Object:  StoredProcedure [dbo].[sp_Roles_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Roles_SelectByID]
@ID nvarchar(128)
as
SELECT        AspNetUsers.Id, AspNetRoles.Name as [Role], AspNetUsers.UserName,AspNetUsers.Email,AspNetUsers.IsLocked
FROM            AspNetUsers INNER JOIN
                         AspNetUserRoles ON AspNetUsers.Id = AspNetUserRoles.UserId INNER JOIN
                         AspNetRoles ON AspNetUserRoles.RoleId = AspNetRoles.Id 
						 where AspNetUsers.Id=@ID


						
GO
/****** Object:  StoredProcedure [dbo].[sp_Roles_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Roles_Update]
 @Id nvarchar(128)
,@RoleId nvarchar(128)
,@UserName nvarchar(256)
,@Email nvarchar(256)
,@IsLocked bit
as
begin
			
			update U set  U.UserName=@UserName,U.Email=@Email,U.IsLocked=@IsLocked
			   from         AspNetUsers  U INNER JOIN
									 AspNetUserRoles UR ON U.Id = UR.UserId INNER JOIN
									 AspNetRoles R ON UR.RoleId = R.Id 
									 where U.Id=@ID



			update UR set UR.RoleId=@RoleId
				from         AspNetUsers  U INNER JOIN
									 AspNetUserRoles UR ON U.Id = UR.UserId INNER JOIN
									 AspNetRoles R ON UR.RoleId = R.Id 
									 where U.Id=@ID
			
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Specialization_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Specialization_Delete]
@Id int
as
delete from  [Specializations] where SpecializationId=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_specialization_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_specialization_Insert]
@Name nvarchar(255),
@Error bit =null output,
@Message nvarchar(200)=null output,  
@ID int output 
as
begin
INSERT INTO Specializations ([Name]) VALUES(@Name)
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY();
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Specialization_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Specialization_SelectAll]
as
SELECT [SpecializationId]
      ,[Name]
 FROM [Specializations] with(nolock) order by SpecializationId desc




GO
/****** Object:  StoredProcedure [dbo].[sp_Specialization_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Specialization_SelectByID]
@Id int
as
SELECT [SpecializationId]
      ,[Name]
  FROM [dbo].[Specializations] where SpecializationId=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_Specialization_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Specialization_Update]
@Id int,
@Name nvarchar(50)
as
update [dbo].[Specializations] set [Name]=@Name 
      
   where SpecializationId=@Id




GO
/****** Object:  StoredProcedure [dbo].[sp_Specializations_Dropdown]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[sp_Specializations_Dropdown]
as
SELECT [SpecializationId]
      ,[Name]
  FROM Specializations

GO
/****** Object:  StoredProcedure [dbo].[sp_Ultrasound_Delete]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Ultrasound_Delete]
 @UltrasoundId int 
as
begin
Delete from Ultrasound where  UltrasoundId=@UltrasoundId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Ultrasound_Insert]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Ultrasound_Insert]
 @PatientId int							=NULL
,@Date date								=NULL
,@LastMenstrualPeriod nvarchar(50)		=NULL
,@EDD date								=NULL
,@EGA nvarchar(100)						=NULL
,@Placenta nvarchar(50)					=NULL
,@Grade nvarchar(50)					=NULL
,@Cord nvarchar(50)						=NULL
,@AmnioticFluidVolume nvarchar(50)		=NULL
,@AFI decimal(18,0)						=NULL
,@Gender nvarchar(50)					=NULL
,@NoOfFetuses nvarchar(50)				=NULL
,@Position nvarchar(50)					=NULL
,@Breathing bit							=NULL
,@Movement bit							=NULL
,@Face nvarchar(50)						=NULL
,@Brain nvarchar(50)					=NULL
,@Spine nvarchar(50)					=NULL
,@Lungs nvarchar(50)					=NULL
,@HeartChamber bit						=NULL
,@HeartCondition nvarchar(50)			=NULL
,@HeartRate nvarchar(50)				=NULL
,@Stomach nvarchar(50)					=NULL
,@CordInsertion nvarchar(50)			=NULL
,@ExtLeftArms nvarchar(50)				=NULL
,@ExtRightArms nvarchar(50)				=NULL
,@ExtLeftLegs nvarchar(50)				=NULL
,@ExtRightLegs nvarchar(50)				=NULL
,@CRL nvarchar(100)						=NULL
,@CRLEGA nvarchar(100)					=NULL
,@FemurLength nvarchar(100)				=NULL
,@FemurLengthEGA nvarchar(100)			=NULL
,@BPD nvarchar(100)						=NULL
,@BPDEGA nvarchar(50)					=NULL
,@HeadCircumference nvarchar(100)		=NULL
,@HeadCircumferenceEGA nvarchar(50)		=NULL
,@AbdCircumference nvarchar(100)		=NULL
,@AbdEGA nvarchar(50)					=NULL
,@EFetalWeight nvarchar(50)				=NULL
,@ThirdFermurLength nvarchar(50)		=NULL
,@ThirdBPD nvarchar(50)					=NULL
,@ThirdEGA nvarchar(50)					=NULL
,@ThirdEstimatedFetalWeight nvarchar(50)=NULL
,@Comments nvarchar(max)				=NULL
,@Error bit =null output
,@Message nvarchar(200)=null output 
,@ID int output
as
begin
INSERT INTO [dbo].[Ultrasound]
           ([PatientId]
           ,[Date]
           ,[LastMenstrualPeriod]
           ,[EDD]
           ,[EGA]
           ,[Placenta]
           ,[Grade]
           ,[Cord]
           ,[AmnioticFluidVolume]
		   ,[AFI]
           ,[Gender]
           ,[NoOfFetuses]
           ,[Position]
           ,[Breathing]
           ,[Movement]
           ,[Face]
           ,[Brain]
           ,[Spine]
           ,[Lungs]
           ,[HeartChamber]
           ,[HeartCondition]
           ,[HeartRate]
           ,[Stomach]
		   ,[CordInsertion]
           ,[ExtLeftArms]
           ,[ExtRightArms]
           ,[ExtLeftLegs]
           ,[ExtRightLegs]
           ,[CRL]
           ,[CRLEGA]
           ,[FemurLength]
           ,[FemurLengthEGA]
           ,[BPD]
           ,[BPDEGA]
           ,[HeadCircumference]
           ,[HeadCircumferenceEGA]
           ,[AbdCircumference]
           ,[AbdEGA]
           ,[EFetalWeight]
           ,[ThirdFermurLength]
           ,[ThirdBPD]
           ,[ThirdEGA]
           ,[ThirdEstimatedFetalWeight]
           ,[Comments])
     VALUES
           (
		    @PatientId 						
           ,@Date 
           ,@LastMenstrualPeriod 
           ,@EDD 
           ,@EGA 
           ,@Placenta 
           ,@Grade 
           ,@Cord 
           ,@AmnioticFluidVolume
		   ,@AFI 
           ,@Gender 
           ,@NoOfFetuses 
           ,@Position 
           ,@Breathing 
           ,@Movement 
           ,@Face 
           ,@Brain 
           ,@Spine 
           ,@Lungs 
           ,@HeartChamber 
           ,@HeartCondition 
           ,@HeartRate 
           ,@Stomach
		   ,@CordInsertion 
           ,@ExtLeftArms 
           ,@ExtRightArms 
           ,@ExtLeftLegs 
           ,@ExtRightLegs 
           ,@CRL 
           ,@CRLEGA 
           ,@FemurLength 
           ,@FemurLengthEGA 
           ,@BPD 
           ,@BPDEGA 
           ,@HeadCircumference 
           ,@HeadCircumferenceEGA 
           ,@AbdCircumference 
           ,@AbdEGA 
           ,@EFetalWeight 
           ,@ThirdFermurLength 
           ,@ThirdBPD 
           ,@ThirdEGA 
           ,@ThirdEstimatedFetalWeight 
           ,@Comments 
		   )
		set @Error=convert(bit,0)
		set @Message='Record saved sucessfully <br/>Do you want to add another?'
		set @ID=SCOPE_IDENTITY()
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Ultrasound_SelectAll]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Ultrasound_SelectAll]
as
begin
SELECT        U.UltrasoundId, U.PatientId,P.PatientName, U.Date, U.LastMenstrualPeriod, U.EDD, U.EGA, U.Placenta, U.Grade, U.Cord, U.AmnioticFluidVolume, U.Gender, U.NoOfFetuses, U.Position, U.Breathing, U.Movement, U.Face, U.Brain, U.Spine, 
                         U.Lungs, U.HeartChamber, U.HeartCondition, U.HeartRate, U.Stomach, U.ExtLeftArms, U.ExtRightArms, U.ExtLeftLegs, U.ExtRightLegs, U.CRL, U.CRLEGA, U.FemurLength, U.FemurLengthEGA, U.BPD, U.BPDEGA, 
                         U.HeadCircumference, U.HeadCircumferenceEGA, U.AbdCircumference, U.AbdEGA, U.EFetalWeight, U.ThirdFermurLength, U.ThirdBPD, U.ThirdEGA, U.ThirdEstimatedFetalWeight, U.Comments
FROM            Ultrasound AS U INNER JOIN
                         PatientInfo AS P ON U.PatientId = P.PatientId
						
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Ultrasound_SelectByID]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Ultrasound_SelectByID]
 @UltrasoundId int 
as
begin
SELECT        U.UltrasoundId, U.PatientId, U.Date, U.LastMenstrualPeriod, U.EDD, U.EGA, U.Placenta, U.Grade, U.Cord, U.AmnioticFluidVolume, U.Gender, U.NoOfFetuses, U.Position, U.Breathing, U.Movement, U.Face, U.Brain, U.Spine, 
                         U.Lungs, U.HeartChamber, U.HeartCondition, U.HeartRate, U.Stomach, U.ExtLeftArms, U.ExtRightArms, U.ExtLeftLegs, U.ExtRightLegs, U.CRL, U.CRLEGA, U.FemurLength, U.FemurLengthEGA, U.BPD, U.BPDEGA, 
                         U.HeadCircumference, U.HeadCircumferenceEGA, U.AbdCircumference, U.AbdEGA, U.EFetalWeight, U.ThirdFermurLength, U.ThirdBPD, U.ThirdEGA, U.ThirdEstimatedFetalWeight, U.Comments, P.PatientName
FROM            Ultrasound AS U INNER JOIN
                         PatientInfo AS P ON U.PatientId = P.PatientId
						 where  U.UltrasoundId=@UltrasoundId
end



GO
/****** Object:  StoredProcedure [dbo].[sp_Ultrasound_Update]    Script Date: 2020-12-10 10:08:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Ultrasound_Update]
 @UltrasoundId int 
,@PatientId int							=NULL
,@Date date								=NULL
,@LastMenstrualPeriod nvarchar(50)		=NULL
,@EDD date								=NULL
,@EGA nvarchar(100)						=NULL
,@Placenta nvarchar(50)					=NULL
,@Grade nvarchar(50)					=NULL
,@Cord nvarchar(50)						=NULL
,@AmnioticFluidVolume nvarchar(50)		=NULL
,@AFI decimal(18,0)						=NULL
,@Gender nvarchar(50)					=NULL
,@NoOfFetuses nvarchar(50)				=NULL
,@Position nvarchar(50)					=NULL
,@Breathing bit							=NULL
,@Movement bit							=NULL
,@Face nvarchar(50)						=NULL
,@Brain nvarchar(50)					=NULL
,@Spine nvarchar(50)					=NULL
,@Lungs nvarchar(50)					=NULL
,@HeartChamber bit						=NULL
,@HeartCondition nvarchar(50)			=NULL
,@HeartRate nvarchar(50)				=NULL
,@Stomach nvarchar(50)					=NULL
,@CordInsertion nvarchar(50)			=NULL
,@ExtLeftArms nvarchar(50)				=NULL
,@ExtRightArms nvarchar(50)				=NULL
,@ExtLeftLegs nvarchar(50)				=NULL
,@ExtRightLegs nvarchar(50)				=NULL
,@CRL nvarchar(100)						=NULL
,@CRLEGA nvarchar(100)					=NULL
,@FemurLength nvarchar(100)				=NULL
,@FemurLengthEGA nvarchar(100)			=NULL
,@BPD nvarchar(100)						=NULL
,@BPDEGA nvarchar(50)					=NULL
,@HeadCircumference nvarchar(100)		=NULL
,@HeadCircumferenceEGA nvarchar(50)		=NULL
,@AbdCircumference nvarchar(100)		=NULL
,@AbdEGA nvarchar(50)					=NULL
,@EFetalWeight nvarchar(50)				=NULL
,@ThirdFermurLength nvarchar(50)		=NULL
,@ThirdBPD nvarchar(50)					=NULL
,@ThirdEGA nvarchar(50)					=NULL
,@ThirdEstimatedFetalWeight nvarchar(50)=NULL
,@Comments nvarchar(max)				=NULL

as
begin
UPDATE Ultrasound
   SET [PatientId] = @PatientId 
      ,[Date] = @Date 
      ,[LastMenstrualPeriod] = @LastMenstrualPeriod 
      ,[EDD] = @EDD 
      ,[EGA] = @EGA 
      ,[Placenta] = @Placenta 
      ,[Grade] = @Grade 
      ,[Cord] = @Cord 
      ,[AmnioticFluidVolume] = @AmnioticFluidVolume 
	  ,[AFI]=@AFI
      ,[Gender] = @Gender 
      ,[NoOfFetuses] = @NoOfFetuses 
      ,[Position] = @Position 
      ,[Breathing] = @Breathing 
      ,[Movement] = @Movement
      ,[Face] = @Face 
      ,[Brain] = @Brain 
      ,[Spine] = @Spine 
      ,[Lungs] = @Lungs 
      ,[HeartChamber] = @HeartChamber 
      ,[HeartCondition] = @HeartCondition 
      ,[HeartRate] = @HeartRate 
      ,[Stomach] = @Stomach
	  ,[CordInsertion]=@CordInsertion 
      ,[ExtLeftArms] = @ExtLeftArms 
      ,[ExtRightArms] = @ExtRightArms 
      ,[ExtLeftLegs] = @ExtLeftLegs 
      ,[ExtRightLegs] = @ExtRightLegs 
      ,[CRL] = @CRL 
      ,[CRLEGA] = @CRLEGA 
      ,[FemurLength] = @FemurLength 
      ,[FemurLengthEGA] = @FemurLengthEGA 
      ,[BPD] = @BPD 
      ,[BPDEGA] = @BPDEGA 
      ,[HeadCircumference] = @HeadCircumference 
      ,[HeadCircumferenceEGA] = @HeadCircumferenceEGA 
      ,[AbdCircumference] = @AbdCircumference 
      ,[AbdEGA] = @AbdEGA 
      ,[EFetalWeight] = @EFetalWeight 
      ,[ThirdFermurLength] = @ThirdFermurLength 
      ,[ThirdBPD] = @ThirdBPD 
      ,[ThirdEGA] = @ThirdEGA 
      ,[ThirdEstimatedFetalWeight] = @ThirdEstimatedFetalWeight 
      ,[Comments] = @Comments 
 WHERE UltrasoundId=@UltrasoundId
end



GO
USE [master]
GO
ALTER DATABASE [HMS] SET  READ_WRITE 
GO
