USE [PlotMS]
GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddBlock]    Script Date: 25/04/2019 10:05:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 12/04/2019
-- Description:	To Insert Block Information
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddBlock] 
	@Blockno varchar(50) , @Blockname varchar(100), @Khasra varchar(100) , @Khewat varchar(100), @ProjectID varchar(50) 
AS
BEGIN
INSERT INTO TMRBlock (BlockNo,BlockName,Khasra,Khewat,ProjectID)
values (@Blockno,@Blockname,@Khasra,@Khewat,@ProjectID)
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_VIEWBLOCK]    Script Date: 25/04/2019 10:05:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 12/04/2019
-- Description:	TMR_VIEWLIST_BLOCK
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_VIEWBLOCK]
	
AS
BEGIN
select BlockNo , BlockName, Khasra , Khewat, id from  TMRBlock
END

GO
