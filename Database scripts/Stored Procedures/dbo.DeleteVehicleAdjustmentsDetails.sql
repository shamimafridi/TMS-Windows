USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleAdjustmentsDetails]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVehicleAdjustmentsDetails]

@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@BranchCode as varchar(10) ='',
@TransactionNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM VocherDetails 
ELSE
	DELETE FROM VehicleAdjustmentDetails  
	WHERE 
	VehicleAdjustmentNature=@TransactionNature AND VehicleAdjustmentNo=@TransactionNo and BranchCode= @BranchCode

GO
