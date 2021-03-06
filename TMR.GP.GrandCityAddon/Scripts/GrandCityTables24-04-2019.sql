USE [PlotMS]
GO
/****** Object:  Table [dbo].[TMR_Allocation]    Script Date: 24/04/2019 4:00:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMR_Allocation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Block] [varchar](50) NOT NULL,
	[Plot] [varchar](50) NOT NULL,
	[AllocationDate] [datetime] NOT NULL,
	[Remarks] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TMR_Allocation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMR_MemberRegistration]    Script Date: 24/04/2019 4:00:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMR_MemberRegistration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RegistrationNo] [varchar](50) NOT NULL,
	[ClientID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FatherOrHusbandType] [varchar](50) NOT NULL,
	[FatherOrHusbandName] [varchar](50) NOT NULL,
	[CNIC] [varchar](50) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[CurrentAddress] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[PhOff] [varchar](50) NOT NULL,
	[Res] [varchar](50) NOT NULL,
	[Mob] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[Plan] [varchar](50) NOT NULL,
	[Booking] [datetime] NOT NULL,
	[Block] [varchar](50) NOT NULL,
	[Plot] [varchar](50) NOT NULL,
	[UnitRate] [decimal](18, 0) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[FinanceAmt] [decimal](18, 0) NOT NULL,
	[RebatAmt] [decimal](18, 0) NOT NULL,
	[NetPrice] [decimal](18, 0) NOT NULL,
	[BookingPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_TMR_MemberRegistration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMR_NomineeDetail]    Script Date: 24/04/2019 4:00:22 PM ******/
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
	[FatherOrHusbandType] [varchar](50) NOT NULL,
	[FatherOrHusbandName] [varchar](50) NOT NULL,
	[CNIC] [varchar](50) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[CurrentAddress] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[PhOff] [varchar](50) NOT NULL,
	[Res] [varchar](50) NOT NULL,
	[Mob] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TMR_NomineeDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMRBlock]    Script Date: 24/04/2019 4:00:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMRBlock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Block No] [char](21) NOT NULL,
	[Block Name] [varchar](15) NOT NULL,
	[Khasra] [varchar](15) NOT NULL,
	[Khewat] [varchar](15) NOT NULL,
 CONSTRAINT [PK_TMR_Block] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[TMRProjects](
	[ProjectID] [varchar](50) NULL,
	[ProjectName] [varchar](100) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TMRProjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
