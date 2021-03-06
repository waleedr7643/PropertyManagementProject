USE [PlotMS]
GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddSizeCode]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddSizeCode]
	@UnitSizeCode varchar(50) ,
	@UnitSizeDescription varchar(100) ,
	@Area decimal(8, 2),
	@UnitID varchar(50),
	@UnitDescription varchar(100),
	@Prefix varchar(5) ,
	@CurrentNumber varchar(10) ,
	@ID int
AS
BEGIN
	
	if @ID = 0 
		INSERT INTO TMR_SizeCodes(UnitSizeCode, UnitSizeDescription, Area, UoMID, 
								  UoMDescription, Prefix, CurrentNumber)
		VALUES        (@UnitSizeCode,@UnitSizeDescription, @Area, @UnitID, 
								  @UnitDescription, @Prefix, @CurrentNumber)
	else if @ID <> 0 
	UPDATE       TMR_SizeCodes
	SET                UnitSizeCode = @UnitSizeCode, UnitSizeDescription = @UnitSizeDescription, 
					Area = @Area, UoMID = @UnitID, UoMDescription = @UnitDescription, Prefix = @Prefix, 
					CurrentNumber = @CurrentNumber
					where ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddUnitCategory]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[TMR_USP_AddUnitCategory]
	@UnitCategoryID varchar(50),
	@UnitCategoryDescription varchar(100),
	@ID int
AS
BEGIN
	if @ID = 0
	Insert into TMR_UnitCategory (UnitCategoryID, UnitCategoryDescription)
	values (@UnitCategoryID, @UnitCategoryDescription)
	else
	if @ID <> 0
	Update TMR_UnitCategory set UnitCategoryID = @UnitCategoryID, UnitCategoryDescription = @UnitCategoryDescription
	where id = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddUnitNature]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddUnitNature]
	@UnitNatureID varchar(50),
	@UnitNatureDescription varchar(100),
	@ID int
AS
BEGIN
	if @ID = 0
	Insert into TMR_UnitNature (UnitNatureID, UnitNatureDescription)
	values (@UnitNatureID, @UnitNatureDescription)
	else
	if @ID <> 0
	Update TMR_UnitNature set UnitNatureID = @UnitNatureID, UnitNatureDescription = @UnitNatureDescription
	where id = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddUOMInfo]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddUOMInfo]
	@UnitID varchar(50),
	@UnitDescription varchar(100),
	@ID int
AS
BEGIN
	if @ID = 0
	Insert into TMR_UofM (UnitofMID, UnitofMDescription)
	values (@UnitID, @UnitDescription)
	else
	if @ID <> 0
	Update TMR_UofM set UnitofMID = @UnitID, UnitofMDescription = @UnitDescription
	where id = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetSizeCode]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetSizeCode]
	@ID int	
AS
BEGIN	
	if @ID = 0
	SELECT        UnitSizeCode, UnitSizeDescription, Area, UoMID, 
				  UoMDescription, Prefix, CurrentNumber, ID
	FROM          TMR_SizeCodes

	else 
	SELECT   UnitSizeCode, UnitSizeDescription, Area, UoMID,
				  UoMDescription, Prefix, CurrentNumber, ID
	FROM          TMR_SizeCodes where ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetUnitCategory]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetUnitCategory]	
AS
BEGIN
	Select UnitCategoryID, UnitCategoryDescription, ID from TMR_UnitCategory

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetUnitNature]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetUnitNature]	
AS
BEGIN
	Select UnitNatureID, UnitNatureDescription, ID from TMR_UnitNature

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetUOMInfo]    Script Date: 4/24/2019 3:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetUOMInfo]
AS
BEGIN
	select UnitofMID, UnitofMDescription, ID from TMR_UofM
END

GO
