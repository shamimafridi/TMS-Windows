USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVouchersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVouchersDetails]

@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@BranchCode as varchar(10) ='',
@TransactionNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM VocherDetails 
ELSE
	DELETE FROM VoucherDetails  
	WHERE 
	VoucherNature=@TransactionNature AND VoucherNo=@TransactionNo and BranchCode= @BranchCode

GO
