USE [PlotMS]
GO
/****** Object:  Table [dbo].[TMRBlock]    Script Date: 25/04/2019 10:03:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMRBlock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[BlockNo] [varchar](50) NOT NULL,
	[BlockName] [varchar](100) NOT NULL,
	[Khasra] [varchar](100) NOT NULL,
	[Khewat] [varchar](100) NOT NULL,
	[ProjectID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TMR_Block] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
