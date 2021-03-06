USE [PlotMS]
GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddNomineeInfo]    Script Date: 30/04/2019 1:00:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_AddNomineeInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddNomineeInfo]
@RegistrationNo varchar(50) , @NomineeID varchar(50), @Name varchar(50) ,@FatherORHusband varchar(50),
@CNIC varchar(50) , @CurrentAddress1 varchar(100), @CurrentAddress2 varchar(100), @CurrentAddress3 varchar(100),
@Country varchar(50) , @City varchar(50), @Relation varchar(50) 

AS
BEGIN
declare @count int;
 
set @count = (select count(8) from TMR_NomineeDetail where RegistrationNo = @RegistrationNo)

if(@count = 0)

INSERT INTO TMR_NomineeDetail(RegistrationNo, NomineeID, Name, FatherOrHusbandName, CNIC, 
CurrentAddress1, CurrentAddress2, CurrentAddress3, Country, City, Relation)
									
values (@RegistrationNo, @NomineeID, @Name, @FatherORHusband, @CNIC, 
@CurrentAddress1, @CurrentAddress2, @CurrentAddress3,
@Country, @City, @Relation)

else if (@count <> 0)

UPDATE TMR_NomineeDetail set RegistrationNo = @RegistrationNo, NomineeID = @NomineeID, Name = @Name,  
FatherOrHusbandName = @FatherORHusband, CNIC = @CNIC, CurrentAddress1 = @CurrentAddress1,
CurrentAddress2 = @CurrentAddress2, CurrentAddress3 = @CurrentAddress3, Country = @Country,
City = @City, Relation = @Relation where RegistrationNo = @RegistrationNo

END


GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddPartnerInfo]    Script Date: 30/04/2019 1:00:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 27/04/2019
-- Description:	TMR_AddPartnerInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddPartnerInfo]
@RegistrationNo varchar(50) , @PartnerID varchar(50), @Name varchar(50) ,@FatherORHusband varchar(50),
@CNIC varchar(50) , @CurrentAddress1 varchar(100), @CurrentAddress2 varchar(100), @CurrentAddress3 varchar(100),
@Country varchar(50) , @City varchar(50), @Relation varchar(50) 
AS
BEGIN
declare @count int;
 
set @count = (select count(8) from TMR_Partner where RegistrationNo = @RegistrationNo)

if(@count = 0)

INSERT INTO TMR_Partner(RegistrationNo, PartnerID, Name, FatherOrHusbandName, CNIC, 
CurrentAddress1, CurrentAddress2, CurrentAddress3, Country, City, Relation)
									
values (@RegistrationNo, @PartnerID, @Name, @FatherORHusband, @CNIC, 
@CurrentAddress1, @CurrentAddress2, @CurrentAddress3,
@Country, @City, @Relation)

else if (@count <> 0)

UPDATE TMR_Partner set RegistrationNo = @RegistrationNo, PartnerID = @PartnerID, Name = @Name,  
FatherOrHusbandName = @FatherORHusband, CNIC = @CNIC, CurrentAddress1 = @CurrentAddress1,
CurrentAddress2 = @CurrentAddress2, CurrentAddress3 = @CurrentAddress3, Country = @Country,
City = @City, Relation = @Relation where RegistrationNo = @RegistrationNo

END


GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetNomineeInfo]    Script Date: 30/04/2019 1:00:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_VIEWNomineeInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetNomineeInfo] 
	@reg varchar(50)
AS
BEGIN
select  RegistrationNo, NomineeID, Name, FatherOrHusbandName, CNIC, CurrentAddress1,
CurrentAddress2, CurrentAddress3, Country, City,Relation,id

from TMR_NomineeDetail

where RegistrationNo = @reg
END


GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetPartnerInfo]    Script Date: 30/04/2019 1:00:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_VIEWPartnerInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetPartnerInfo] 
	@reg varchar(50)
AS
BEGIN
select  RegistrationNo, PartnerID, Name, FatherOrHusbandName, CNIC, CurrentAddress1,
CurrentAddress2, CurrentAddress3, Country, City,Relation,id

from TMR_Partner

where RegistrationNo = @reg
END


GO
