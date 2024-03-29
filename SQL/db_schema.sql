USE [master]
GO
/****** Object:  Database [RegistreTraitementContext]    Script Date: 20-04-22 15:12:45 ******/
CREATE DATABASE [RegistreTraitementContext]
GO
USE [RegistreTraitementContext]
GO

CREATE TABLE [dbo].[AccesIllegitime](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdGravite] [bigint] NOT NULL,
	[IdVraisemblance] [bigint] NOT NULL,
 CONSTRAINT [PK_AccesIllegitime] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccesIllegitimeMesureTraitement]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccesIllegitimeMesureTraitement](
	[IdAccesIllegitime] [bigint] NOT NULL,
	[IdMesureTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_AccesIllegitimeMesureTraitement] PRIMARY KEY CLUSTERED 
(
	[IdAccesIllegitime] ASC,
	[IdMesureTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccesIllegitimeSourceRisque]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccesIllegitimeSourceRisque](
	[IdAccesIllegitime] [bigint] NOT NULL,
	[IdSourceRisque] [bigint] NOT NULL,
 CONSTRAINT [PK_AccesIllegitimeSourceRisque] PRIMARY KEY CLUSTERED 
(
	[IdAccesIllegitime] ASC,
	[IdSourceRisque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessIllegitimeSourceMenace]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessIllegitimeSourceMenace](
	[IdAccessIllegitime] [bigint] NOT NULL,
	[IdSourceMenace] [bigint] NOT NULL,
 CONSTRAINT [PK_AccessIllegitimeSourceMenace] PRIMARY KEY CLUSTERED 
(
	[IdAccessIllegitime] ASC,
	[IdSourceMenace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauseIncident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauseIncident](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
 CONSTRAINT [PK_CauseIncident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisparitionDonnee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisparitionDonnee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdGravite] [bigint] NOT NULL,
	[IdVraisemblance] [bigint] NOT NULL,
 CONSTRAINT [PK_DisparitionDonnee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisparitionDonneeMesureTraitement]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisparitionDonneeMesureTraitement](
	[IdDisparitionDonnee] [bigint] NOT NULL,
	[IdMesureTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_DisparitionDonneeMesureTraitement] PRIMARY KEY CLUSTERED 
(
	[IdDisparitionDonnee] ASC,
	[IdMesureTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisparitionDonneeSourceMenace]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisparitionDonneeSourceMenace](
	[IdDisparitionDonnee] [bigint] NOT NULL,
	[IdSourceMenace] [bigint] NOT NULL,
 CONSTRAINT [PK_DisparitionDonneeSourceMenace] PRIMARY KEY CLUSTERED 
(
	[IdDisparitionDonnee] ASC,
	[IdSourceMenace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisparitionDonneeSourceRisque]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisparitionDonneeSourceRisque](
	[IdDisparitionDonnee] [bigint] NOT NULL,
	[IdSourceRisque] [bigint] NOT NULL,
 CONSTRAINT [PK_DisparitionDonneeSourceRisque] PRIMARY KEY CLUSTERED 
(
	[IdDisparitionDonnee] ASC,
	[IdSourceRisque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonneeCaracterePersonnel]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonneeCaracterePersonnel](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_DonneeCaracterePersonnel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonneeCaractereSensible]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonneeCaractereSensible](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_DonneeCaractereSensible] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DureeConservationDonnee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DureeConservationDonnee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](50) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_DureeConservationDonnee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fichier]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fichier](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[IdTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_Fichier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FichierIncident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FichierIncident](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Path] [varchar](max) NOT NULL,
	[Nom] [varchar](max) NOT NULL,
 CONSTRAINT [PK_FichierIncident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinaliteDonnee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinaliteDonnee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_FinaliteDonnee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gravite]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gravite](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_Gravite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incident](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](250) NOT NULL,
	[DateCreation] [date] NOT NULL,
	[DateConstat] [date] NOT NULL,
	[DateIncident] [date] NULL,
	[Description] [varchar](max) NULL,
	[IsInfoPersConcerne] [bit] NOT NULL,
	[DateInfoPersConcerne] [date] NULL,
	[TxtInfoPersConcerne] [varchar](max) NULL,
	[IsInfoAutorite] [bit] NOT NULL,
	[DateInfoAutorite] [date] NULL,
	[IdFichierIncident] [bigint] NULL,
	[CommentaireDPO] [varchar](max) NULL,
	[IdLieuIncident] [bigint] NOT NULL,
	[TxtDescrLieuIncident] [varchar](max) NULL,
	[IdCauseIncident] [bigint] NOT NULL,
	[IdAgent] [bigint] NOT NULL,
	[IdService] [bigint] NOT NULL,
 CONSTRAINT [PK_Incident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegitimationCaracterePersonnel]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegitimationCaracterePersonnel](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](50) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_LegitimationCaracterePersonnel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegitimationCaractereSensible]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegitimationCaractereSensible](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](50) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_LegitimationCaractereSensible] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LieuIncident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LieuIncident](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
 CONSTRAINT [PK_LieuIncident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesure]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesure](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](40) NULL,
	[Titre] [varchar](75) NOT NULL,
	[Description] [varchar](max) NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK__Mesure__3214EC070F39191E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MesureTraitement]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MesureTraitement](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Titre] [varchar](max) NULL,
	[Explication] [varchar](max) NULL,
	[Commentaire] [varchar](max) NULL,
	[IdTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_MesureTraitement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModificationNonDesiree]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModificationNonDesiree](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdGravite] [bigint] NOT NULL,
	[IdVraisemblance] [bigint] NOT NULL,
 CONSTRAINT [PK_ModificationNonDesiree] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModificationNonDesireeMesureTraitement]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModificationNonDesireeMesureTraitement](
	[IdModificationNonDesire] [bigint] NOT NULL,
	[IdMesureTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_ModificationNonDesireeMesureTraitement] PRIMARY KEY CLUSTERED 
(
	[IdModificationNonDesire] ASC,
	[IdMesureTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModificationNonDesireeSourceMenace]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModificationNonDesireeSourceMenace](
	[IdModificationNonDesiree] [bigint] NOT NULL,
	[IdSourceMenace] [bigint] NOT NULL,
 CONSTRAINT [PK_ModificationNonDesireeSourceMenace] PRIMARY KEY CLUSTERED 
(
	[IdModificationNonDesiree] ASC,
	[IdSourceMenace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModificationNonDesireeSourceRisque]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModificationNonDesireeSourceRisque](
	[IdModificationNonDesiree] [bigint] NOT NULL,
	[IdSourceRisque] [bigint] NOT NULL,
 CONSTRAINT [PK_ModificationNonDesireeSourceRisque] PRIMARY KEY CLUSTERED 
(
	[IdModificationNonDesiree] ASC,
	[IdSourceRisque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonneConcernee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonneConcernee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](50) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_PersonneConcernee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SourceMenace]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceMenace](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_SourceMenace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SourceRisque]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceRisque](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_SourceRisque] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupportDonnee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupportDonnee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NOT NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_SupportDonnee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traitement]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traitement](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](150) NOT NULL,
	[AgentEncodeur] [nvarchar](50) NOT NULL,
	[AgentContact] [nvarchar](50) NOT NULL,
	[PrincipeProportionnalite] [varchar](max) NULL,
	[GestionSousTraitance] [varchar](max) NULL,
	[RemContact] [varchar](max) NULL,
	[RemDPD] [varchar](max) NULL,
	[DateCrea] [datetime] NOT NULL,
	[DateModif] [datetime] NOT NULL,
	[DonneeAJour] [bit] NOT NULL,
	[ToModify] [bit] NOT NULL,
	[ToControlContact] [bit] NOT NULL,
	[ToControlDPD] [bit] NOT NULL,
	[IsValid] [bit] NOT NULL,
	[IsActif] [bit] NOT NULL,
	[IsOpen] [bit] NOT NULL,
	[IdService] [bigint] NOT NULL,
	[IdPersonneConcerne] [bigint] NOT NULL,
	[IdDureeConservationDonnee] [bigint] NOT NULL,
	[IdLegitimationPersonnel] [bigint] NOT NULL,
	[IdLegitimationSensible] [bigint] NOT NULL,
	[IdFinaliteDonnee] [bigint] NOT NULL,
	[IdAccesIll] [bigint] NULL,
	[IdDispDonnee] [bigint] NULL,
	[IdModNonDesiree] [bigint] NULL,
 CONSTRAINT [PK_Traitement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraitementDonneeCaracterePersonnel]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraitementDonneeCaracterePersonnel](
	[IdDonneeCaracterePersonnel] [bigint] NOT NULL,
	[IdTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_TraitementDonneeCaracterePersonnel] PRIMARY KEY CLUSTERED 
(
	[IdDonneeCaracterePersonnel] ASC,
	[IdTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraitementDonneeCaractereSensible]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraitementDonneeCaractereSensible](
	[IdDonneeCaractereSensible] [bigint] NOT NULL,
	[IdTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_TraitementDonneeCaractereSensible] PRIMARY KEY CLUSTERED 
(
	[IdDonneeCaractereSensible] ASC,
	[IdTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraitementSupportDonnee]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraitementSupportDonnee](
	[IdSupportDonnee] [bigint] NOT NULL,
	[IdTraitement] [bigint] NOT NULL,
 CONSTRAINT [PK_TraitementSupportDonnee] PRIMARY KEY CLUSTERED 
(
	[IdSupportDonnee] ASC,
	[IdTraitement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeIncident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeIncident](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TypeIncident] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeIncident_Incident]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeIncident_Incident](
	[IdIncident] [bigint] NOT NULL,
	[IdTypeIncident] [bigint] NOT NULL,
	[TxtAutre] [varchar](max) NULL,
 CONSTRAINT [PK_TypeIncident_Incident] PRIMARY KEY CLUSTERED 
(
	[IdIncident] ASC,
	[IdTypeIncident] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [varchar](50) NOT NULL,
	[LogonName] [varchar](25) NOT NULL,
	[IdService] [bigint] NOT NULL,
	[IdRole] [bigint] NOT NULL,
	[LocalPwd] [varchar](250) NULL,
 CONSTRAINT [PK__Utilisat__3214EC07659E2A70] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vraisemblance]    Script Date: 20-04-22 15:12:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vraisemblance](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](75) NULL,
	[Tooltip] [varchar](max) NULL,
 CONSTRAINT [PK_Vraisemblance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccesIllegitime]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitime_Gravite] FOREIGN KEY([IdGravite])
REFERENCES [dbo].[Gravite] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitime] CHECK CONSTRAINT [FK_AccesIllegitime_Gravite]
GO
ALTER TABLE [dbo].[AccesIllegitime]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitime_Vraisemblance] FOREIGN KEY([IdVraisemblance])
REFERENCES [dbo].[Vraisemblance] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitime] CHECK CONSTRAINT [FK_AccesIllegitime_Vraisemblance]
GO
ALTER TABLE [dbo].[AccesIllegitimeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitimeMesureTraitement_AccesIllegitime] FOREIGN KEY([IdAccesIllegitime])
REFERENCES [dbo].[AccesIllegitime] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitimeMesureTraitement] CHECK CONSTRAINT [FK_AccesIllegitimeMesureTraitement_AccesIllegitime]
GO
ALTER TABLE [dbo].[AccesIllegitimeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitimeMesureTraitement_MesureTraitement] FOREIGN KEY([IdMesureTraitement])
REFERENCES [dbo].[MesureTraitement] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitimeMesureTraitement] CHECK CONSTRAINT [FK_AccesIllegitimeMesureTraitement_MesureTraitement]
GO
ALTER TABLE [dbo].[AccesIllegitimeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitimeSourceRisque_AccesIllegitime] FOREIGN KEY([IdAccesIllegitime])
REFERENCES [dbo].[AccesIllegitime] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitimeSourceRisque] CHECK CONSTRAINT [FK_AccesIllegitimeSourceRisque_AccesIllegitime]
GO
ALTER TABLE [dbo].[AccesIllegitimeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_AccesIllegitimeSourceRisque_SourceRisque] FOREIGN KEY([IdSourceRisque])
REFERENCES [dbo].[SourceRisque] ([Id])
GO
ALTER TABLE [dbo].[AccesIllegitimeSourceRisque] CHECK CONSTRAINT [FK_AccesIllegitimeSourceRisque_SourceRisque]
GO
ALTER TABLE [dbo].[AccessIllegitimeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_AccessIllegitimeSourceMenace_AccessIllegitime] FOREIGN KEY([IdAccessIllegitime])
REFERENCES [dbo].[AccesIllegitime] ([Id])
GO
ALTER TABLE [dbo].[AccessIllegitimeSourceMenace] CHECK CONSTRAINT [FK_AccessIllegitimeSourceMenace_AccessIllegitime]
GO
ALTER TABLE [dbo].[AccessIllegitimeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_AccessIllegitimeSourceMenace_SourceMenace] FOREIGN KEY([IdSourceMenace])
REFERENCES [dbo].[SourceMenace] ([Id])
GO
ALTER TABLE [dbo].[AccessIllegitimeSourceMenace] CHECK CONSTRAINT [FK_AccessIllegitimeSourceMenace_SourceMenace]
GO
ALTER TABLE [dbo].[DisparitionDonnee]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonnee_Gravite] FOREIGN KEY([IdGravite])
REFERENCES [dbo].[Gravite] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonnee] CHECK CONSTRAINT [FK_DisparitionDonnee_Gravite]
GO
ALTER TABLE [dbo].[DisparitionDonnee]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonnee_Vraisemblance] FOREIGN KEY([IdVraisemblance])
REFERENCES [dbo].[Vraisemblance] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonnee] CHECK CONSTRAINT [FK_DisparitionDonnee_Vraisemblance]
GO
ALTER TABLE [dbo].[DisparitionDonneeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeMesureTraitement_DisparitionDonnee] FOREIGN KEY([IdDisparitionDonnee])
REFERENCES [dbo].[DisparitionDonnee] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeMesureTraitement] CHECK CONSTRAINT [FK_DisparitionDonneeMesureTraitement_DisparitionDonnee]
GO
ALTER TABLE [dbo].[DisparitionDonneeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeMesureTraitement_MesureTraitement] FOREIGN KEY([IdMesureTraitement])
REFERENCES [dbo].[MesureTraitement] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeMesureTraitement] CHECK CONSTRAINT [FK_DisparitionDonneeMesureTraitement_MesureTraitement]
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeSourceMenace_DisparitionDonnee] FOREIGN KEY([IdDisparitionDonnee])
REFERENCES [dbo].[DisparitionDonnee] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceMenace] CHECK CONSTRAINT [FK_DisparitionDonneeSourceMenace_DisparitionDonnee]
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeSourceMenace_SourceMenace] FOREIGN KEY([IdSourceMenace])
REFERENCES [dbo].[SourceMenace] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceMenace] CHECK CONSTRAINT [FK_DisparitionDonneeSourceMenace_SourceMenace]
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeSourceRisque_DisparitionDonnee] FOREIGN KEY([IdDisparitionDonnee])
REFERENCES [dbo].[DisparitionDonnee] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceRisque] CHECK CONSTRAINT [FK_DisparitionDonneeSourceRisque_DisparitionDonnee]
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_DisparitionDonneeSourceRisque_SourceRisque] FOREIGN KEY([IdSourceRisque])
REFERENCES [dbo].[SourceRisque] ([Id])
GO
ALTER TABLE [dbo].[DisparitionDonneeSourceRisque] CHECK CONSTRAINT [FK_DisparitionDonneeSourceRisque_SourceRisque]
GO
ALTER TABLE [dbo].[Fichier]  WITH CHECK ADD  CONSTRAINT [FK_Fichier_Traitement] FOREIGN KEY([IdTraitement])
REFERENCES [dbo].[Traitement] ([Id])
GO
ALTER TABLE [dbo].[Fichier] CHECK CONSTRAINT [FK_Fichier_Traitement]
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD  CONSTRAINT [FK_CauseIncident_Incident] FOREIGN KEY([IdCauseIncident])
REFERENCES [dbo].[CauseIncident] ([Id])
GO
ALTER TABLE [dbo].[Incident] CHECK CONSTRAINT [FK_CauseIncident_Incident]
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD  CONSTRAINT [FK_FichierIncident_Incident] FOREIGN KEY([IdFichierIncident])
REFERENCES [dbo].[FichierIncident] ([Id])
GO
ALTER TABLE [dbo].[Incident] CHECK CONSTRAINT [FK_FichierIncident_Incident]
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD  CONSTRAINT [FK_LieuIncident_Incident] FOREIGN KEY([IdLieuIncident])
REFERENCES [dbo].[LieuIncident] ([Id])
GO
ALTER TABLE [dbo].[Incident] CHECK CONSTRAINT [FK_LieuIncident_Incident]
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Incident] FOREIGN KEY([IdAgent])
REFERENCES [dbo].[Utilisateur] ([Id])
GO
ALTER TABLE [dbo].[Incident] CHECK CONSTRAINT [FK_Utilisateur_Incident]
GO
ALTER TABLE [dbo].[MesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_MesureTraitement_Traitement] FOREIGN KEY([IdTraitement])
REFERENCES [dbo].[Traitement] ([Id])
GO
ALTER TABLE [dbo].[MesureTraitement] CHECK CONSTRAINT [FK_MesureTraitement_Traitement]
GO
ALTER TABLE [dbo].[ModificationNonDesiree]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesiree_Gravite] FOREIGN KEY([IdGravite])
REFERENCES [dbo].[Gravite] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesiree] CHECK CONSTRAINT [FK_ModificationNonDesiree_Gravite]
GO
ALTER TABLE [dbo].[ModificationNonDesiree]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesiree_Vraisemblance] FOREIGN KEY([IdVraisemblance])
REFERENCES [dbo].[Vraisemblance] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesiree] CHECK CONSTRAINT [FK_ModificationNonDesiree_Vraisemblance]
GO
ALTER TABLE [dbo].[ModificationNonDesireeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeMesureTraitement_MesureTraitement] FOREIGN KEY([IdModificationNonDesire])
REFERENCES [dbo].[MesureTraitement] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeMesureTraitement] CHECK CONSTRAINT [FK_ModificationNonDesireeMesureTraitement_MesureTraitement]
GO
ALTER TABLE [dbo].[ModificationNonDesireeMesureTraitement]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeMesureTraitement_ModificationNonDesiree] FOREIGN KEY([IdMesureTraitement])
REFERENCES [dbo].[ModificationNonDesiree] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeMesureTraitement] CHECK CONSTRAINT [FK_ModificationNonDesireeMesureTraitement_ModificationNonDesiree]
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeSourceMenace_ModificationNonDesiree] FOREIGN KEY([IdModificationNonDesiree])
REFERENCES [dbo].[ModificationNonDesiree] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceMenace] CHECK CONSTRAINT [FK_ModificationNonDesireeSourceMenace_ModificationNonDesiree]
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceMenace]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeSourceMenace_SourceMenace] FOREIGN KEY([IdSourceMenace])
REFERENCES [dbo].[SourceMenace] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceMenace] CHECK CONSTRAINT [FK_ModificationNonDesireeSourceMenace_SourceMenace]
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeSourceRisque_ModificationNonDesiree] FOREIGN KEY([IdModificationNonDesiree])
REFERENCES [dbo].[ModificationNonDesiree] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceRisque] CHECK CONSTRAINT [FK_ModificationNonDesireeSourceRisque_ModificationNonDesiree]
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceRisque]  WITH CHECK ADD  CONSTRAINT [FK_ModificationNonDesireeSourceRisque_SourceRisque] FOREIGN KEY([IdSourceRisque])
REFERENCES [dbo].[SourceRisque] ([Id])
GO
ALTER TABLE [dbo].[ModificationNonDesireeSourceRisque] CHECK CONSTRAINT [FK_ModificationNonDesireeSourceRisque_SourceRisque]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_AccesIllegitime] FOREIGN KEY([IdAccesIll])
REFERENCES [dbo].[AccesIllegitime] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_AccesIllegitime]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_DisparitionDonnee] FOREIGN KEY([IdDispDonnee])
REFERENCES [dbo].[DisparitionDonnee] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_DisparitionDonnee]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_DureeConservationDonnee] FOREIGN KEY([IdDureeConservationDonnee])
REFERENCES [dbo].[DureeConservationDonnee] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_DureeConservationDonnee]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_FinaliteDonnee] FOREIGN KEY([IdFinaliteDonnee])
REFERENCES [dbo].[FinaliteDonnee] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_FinaliteDonnee]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_LegitimationCaracterePersonnel] FOREIGN KEY([IdLegitimationPersonnel])
REFERENCES [dbo].[LegitimationCaracterePersonnel] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_LegitimationCaracterePersonnel]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_LegitimationCaractereSensible] FOREIGN KEY([IdLegitimationSensible])
REFERENCES [dbo].[LegitimationCaractereSensible] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_LegitimationCaractereSensible]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_ModificationNonDesiree] FOREIGN KEY([IdModNonDesiree])
REFERENCES [dbo].[ModificationNonDesiree] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_ModificationNonDesiree]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_PersonneConcernee] FOREIGN KEY([IdPersonneConcerne])
REFERENCES [dbo].[PersonneConcernee] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_PersonneConcernee]
GO
ALTER TABLE [dbo].[Traitement]  WITH CHECK ADD  CONSTRAINT [FK_Traitement_Service] FOREIGN KEY([IdService])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[Traitement] CHECK CONSTRAINT [FK_Traitement_Service]
GO
ALTER TABLE [dbo].[TraitementDonneeCaracterePersonnel]  WITH CHECK ADD  CONSTRAINT [FK_TraitementDonneeCaracterePersonnel_DonneeCaracterePersonnel] FOREIGN KEY([IdDonneeCaracterePersonnel])
REFERENCES [dbo].[DonneeCaracterePersonnel] ([Id])
GO
ALTER TABLE [dbo].[TraitementDonneeCaracterePersonnel] CHECK CONSTRAINT [FK_TraitementDonneeCaracterePersonnel_DonneeCaracterePersonnel]
GO
ALTER TABLE [dbo].[TraitementDonneeCaracterePersonnel]  WITH CHECK ADD  CONSTRAINT [FK_TraitementDonneeCaracterePersonnel_Traitement] FOREIGN KEY([IdTraitement])
REFERENCES [dbo].[Traitement] ([Id])
GO
ALTER TABLE [dbo].[TraitementDonneeCaracterePersonnel] CHECK CONSTRAINT [FK_TraitementDonneeCaracterePersonnel_Traitement]
GO
ALTER TABLE [dbo].[TraitementDonneeCaractereSensible]  WITH CHECK ADD  CONSTRAINT [FK_TraitementDonneeCaractereSensible_DonneeCaractereSensible] FOREIGN KEY([IdDonneeCaractereSensible])
REFERENCES [dbo].[DonneeCaractereSensible] ([Id])
GO
ALTER TABLE [dbo].[TraitementDonneeCaractereSensible] CHECK CONSTRAINT [FK_TraitementDonneeCaractereSensible_DonneeCaractereSensible]
GO
ALTER TABLE [dbo].[TraitementDonneeCaractereSensible]  WITH CHECK ADD  CONSTRAINT [FK_TraitementDonneeCaractereSensible_Traitement] FOREIGN KEY([IdTraitement])
REFERENCES [dbo].[Traitement] ([Id])
GO
ALTER TABLE [dbo].[TraitementDonneeCaractereSensible] CHECK CONSTRAINT [FK_TraitementDonneeCaractereSensible_Traitement]
GO
ALTER TABLE [dbo].[TraitementSupportDonnee]  WITH CHECK ADD  CONSTRAINT [FK_TraitementSupportDonnee_SupportDonnee] FOREIGN KEY([IdSupportDonnee])
REFERENCES [dbo].[SupportDonnee] ([Id])
GO
ALTER TABLE [dbo].[TraitementSupportDonnee] CHECK CONSTRAINT [FK_TraitementSupportDonnee_SupportDonnee]
GO
ALTER TABLE [dbo].[TraitementSupportDonnee]  WITH CHECK ADD  CONSTRAINT [FK_TraitementSupportDonnee_Traitement] FOREIGN KEY([IdTraitement])
REFERENCES [dbo].[Traitement] ([Id])
GO
ALTER TABLE [dbo].[TraitementSupportDonnee] CHECK CONSTRAINT [FK_TraitementSupportDonnee_Traitement]
GO
ALTER TABLE [dbo].[TypeIncident_Incident]  WITH CHECK ADD  CONSTRAINT [FK_Incident_TypeIncident_Incident] FOREIGN KEY([IdIncident])
REFERENCES [dbo].[Incident] ([Id])
GO
ALTER TABLE [dbo].[TypeIncident_Incident] CHECK CONSTRAINT [FK_Incident_TypeIncident_Incident]
GO
ALTER TABLE [dbo].[TypeIncident_Incident]  WITH CHECK ADD  CONSTRAINT [FK_TypeIncident_TypeIncident_Incident] FOREIGN KEY([IdTypeIncident])
REFERENCES [dbo].[TypeIncident] ([Id])
GO
ALTER TABLE [dbo].[TypeIncident_Incident] CHECK CONSTRAINT [FK_TypeIncident_TypeIncident_Incident]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_Role]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_service] FOREIGN KEY([IdService])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_service]
GO
USE [master]
GO
ALTER DATABASE [RegistreTraitementContext] SET  READ_WRITE 
GO
