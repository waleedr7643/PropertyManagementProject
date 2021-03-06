USE [PlotMS]
GO
/****** Object:  Table [dbo].[TMR_NomineeDetail]    Script Date: 30/04/2019 12:57:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMR_NomineeDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegistrationNo] [varchar](50) NOT NULL,
	[NomineeID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FatherOrHusbandName] [varchar](50) NOT NULL,
	[CNIC] [varchar](50) NOT NULL,
	[CurrentAddress1] [varchar](100) NOT NULL,
	[CurrentAddress2] [varchar](100) NOT NULL,
	[CurrentAddress3] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Relation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TMR_NomineeDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMR_Partner]    Script Date: 30/04/2019 12:57:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMR_Partner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegistrationNo] [varchar](50) NOT NULL,
	[PartnerID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FatherOrHusbandName] [varchar](50) NOT NULL,
	[CNIC] [varchar](50) NOT NULL,
	[CurrentAddress1] [varchar](100) NOT NULL,
	[CurrentAddress2] [varchar](100) NOT NULL,
	[CurrentAddress3] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Relation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TMR_Partner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
