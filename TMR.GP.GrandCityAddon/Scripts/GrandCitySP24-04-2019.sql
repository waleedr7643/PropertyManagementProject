USE [PlotMS]
GO
/****** Object:  StoredProcedure [dbo].[TMR_AddAllocation]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 22/04/2019
-- Description:	TMR_AddAllocation
-- =============================================
CREATE PROCEDURE [dbo].[TMR_AddAllocation]
	 @Block varchar(50), @Plot varchar(50), @AllocationDate datetime, @Remarks varchar(50)
AS
BEGIN
	INSERT INTO TMR_Allocation(Block, Plot, AllocationDate, Remarks)

values (@Block, @Plot,@AllocationDate, @Remarks)
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_AddMemberRegistration]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_AddMemberRegistration
-- =============================================
CREATE PROCEDURE [dbo].[TMR_AddMemberRegistration] 
@RegistrationNo varchar(50) , @ClientID varchar(50), @Name varchar(50) , @FatherORHusbandType varchar(50),@FatherORHusband varchar(50),
@CNIC varchar(50) , @Nationality varchar(50), @DOB datetime , @CurrentAddress varchar(100),
@Country varchar(50) , @City varchar(50), @PhOff varchar(50) , @Res varchar(50),
@Mob varchar(50) , @Fax varchar(50), @EmailAddress varchar(100) , @Plan varchar(50) ,
@Booking datetime , @Block varchar(50), @Plot varchar(50) , @UnitRate decimal(18, 0),
@TotalPrice decimal(18, 0) , @FinanceAmt decimal(18, 0), @RebatAmt decimal(18, 0) , @NetRetailPrice decimal(18, 0),
@BookingPrice decimal(18, 0)

AS
BEGIN

declare @count int;
 
set @count = (select count(8) from TMR_MemberRegistration where ClientID = @ClientID)

if(@count = 0)

INSERT INTO TMR_MemberRegistration(RegistrationNo, ClientID, Name,FatherOrHusbandType, FatherOrHusbandName, CNIC, Nationality, DOB, CurrentAddress, Country,
                                    City, PhOff, Res, Mob, Fax, EmailAddress, [Plan], Booking, Block, Plot, UnitRate, TotalPrice, FinanceAmt,
									RebatAmt, NetPrice, BookingPrice)
values (@RegistrationNo, @ClientID, @Name, @FatherORHusbandType, @FatherORHusband, @CNIC, @Nationality, @DOB, @CurrentAddress,
        @Country, @City, @PhOff, @Res, @Mob, @Fax, @EmailAddress, @Plan, @Booking, @Block, @Plot, @UnitRate, @TotalPrice,
		@FinanceAmt, @RebatAmt, @NetRetailPrice, @BookingPrice)

else if (@count <> 0)

UPDATE TMR_MemberRegistration set RegistrationNo = @RegistrationNo, ClientID = @ClientID, Name = @Name, FatherOrHusbandType = @FatherORHusbandType, 
FatherOrHusbandName = @FatherORHusband, CNIC = @CNIC, Nationality = @Nationality, DOB = @DOB, CurrentAddress = @CurrentAddress, Country = @Country,
City = @City, PhOff = @PhOff, Res = @Res, Mob = @Mob, Fax = @Fax, EmailAddress = @EmailAddress,
 [Plan] = @Plan, Booking = @Booking, Block = @Block, Plot = @Plot, UnitRate = @UnitRate, TotalPrice = @TotalPrice, 
 FinanceAmt = @FinanceAmt,RebatAmt = @RebatAmt, NetPrice = @NetRetailPrice, BookingPrice = @BookingPrice
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_AddNomineeInfo]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_AddNomineeInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_AddNomineeInfo]
@RegistrationNo varchar(50) , @NomineeID varchar(50), @Name varchar(50) , @FatherORHusbandType varchar(50),@FatherORHusband varchar(50),
@CNIC varchar(50) , @Nationality varchar(50), @DOB datetime , @CurrentAddress varchar(100),
@Country varchar(50) , @City varchar(50), @PhOff varchar(50) , @Res varchar(50),
@Mob varchar(50) , @Fax varchar(50), @EmailAddress varchar(100)
AS
BEGIN
declare @count int;
 
set @count = (select count(8) from TMR_NomineeDetail where NomineeID = @NomineeID)

if(@count = 0)

INSERT INTO TMR_NomineeDetail(RegistrationNo, NomineeID, Name,FatherOrHusbandType, FatherOrHusbandName, CNIC, Nationality, DOB, CurrentAddress, Country,
                                    City, PhOff, Res, Mob, Fax, EmailAddress)
									
values (@RegistrationNo, @NomineeID, @Name, @FatherORHusbandType, @FatherORHusband, @CNIC, @Nationality, @DOB, @CurrentAddress,
        @Country, @City, @PhOff, @Res, @Mob, @Fax, @EmailAddress)

else if (@count <> 0)

UPDATE TMR_NomineeDetail set RegistrationNo = @RegistrationNo, NomineeID = @NomineeID, Name = @Name, FatherOrHusbandType = @FatherORHusbandType, 
FatherOrHusbandName = @FatherORHusband, CNIC = @CNIC, Nationality = @Nationality, DOB = @DOB, CurrentAddress = @CurrentAddress, Country = @Country,
City = @City, PhOff = @PhOff, Res = @Res, Mob = @Mob, Fax = @Fax, EmailAddress = @EmailAddress

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_UPDATEBLOCK]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 12/04/2019
-- Description:	TMR_INSERT
-- =============================================
CREATE PROCEDURE [dbo].[TMR_UPDATEBLOCK]
	@Blockno char(10) , @Blockname varchar(15), @Khasra varchar(15) , @Khewat varchar(15) , @id int
AS
BEGIN
UPDATE  TMR_Block  set [Block No] = @Blockno ,[Block Name] = @Blockname,Khasra = @Khasra ,Khewat = @Khewat where id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddBlock]    Script Date: 24/04/2019 4:03:58 PM ******/
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
	@Blockno char(10) , @Blockname varchar(15), @Khasra varchar(15) , @Khewat varchar(15)
AS
BEGIN
INSERT INTO TMRBlock ([Block No],[Block Name],Khasra,Khewat)
values (@Blockno,@Blockname,@Khasra,@Khewat)
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_AddProject]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sajjad Hasan
-- Create date: 23 April 2019
-- Description:	To insert project information
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_AddProject]
	@ProjectID varchar(50), @ProjectName varchar(100), @ID int
AS
BEGIN
	if @ID = 0
		Insert into TMRProjects (ProjectID, ProjectName)
		values (@ProjectID, @ProjectName)	
	else 
		update TMRProjects set ProjectID = @ProjectID, ProjectName = @ProjectName
		where id = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_USP_GetAllProjects]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sajjad Hasan
-- Create date: 23 April 2019
-- Description:	To insert project information
-- =============================================
CREATE PROCEDURE [dbo].[TMR_USP_GetAllProjects]
	
AS
BEGIN
	Select ProjectID, ProjectName, ID from TMRProjects
END

GO
/****** Object:  StoredProcedure [dbo].[TMR_VIEWMemberRegistration]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_VIEWMemberRegistration
-- =============================================
CREATE PROCEDURE [dbo].[TMR_VIEWMemberRegistration] 
	@cid varchar(50)
AS
BEGIN

select  RegistrationNo, ClientID, Name, FatherOrHusbandType, FatherOrHusbandName, CNIC, Nationality, DOB, CurrentAddress, Country,
        City, PhOff, Res, Mob, Fax, EmailAddress, [Plan], Booking, Block, Plot, UnitRate, TotalPrice, FinanceAmt,
		RebatAmt, NetPrice, BookingPrice

from TMR_MemberRegistration

where ClientID = @cid

END

GO
/****** Object:  StoredProcedure [dbo].[TMR_VIEWNomineeInfo]    Script Date: 24/04/2019 4:03:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		waleed
-- Create date: 17/04/2019
-- Description:	TMR_VIEWNomineeInfo
-- =============================================
CREATE PROCEDURE [dbo].[TMR_VIEWNomineeInfo] 
	@nid varchar(50)
AS
BEGIN
select  RegistrationNo, NomineeID, Name, FatherOrHusbandType, FatherOrHusbandName, CNIC, Nationality, DOB, CurrentAddress, Country,
        City, PhOff, Res, Mob, Fax, EmailAddress

from TMR_NomineeDetail

where NomineeID = @nid
END

GO
