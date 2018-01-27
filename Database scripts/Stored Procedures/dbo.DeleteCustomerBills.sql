USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerBills]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerBills]

@Option as  varchar(3)='',
@BillNo as  varchar(10)=''

AS

begin transaction

exec DeleteCustomerBillsDetails @BillNo=@BillNo

--DELETE FROM CustomerBills 
--UPDATE dbo.CustomerBills  NO UPDATE REQUIRED BECUSE NO DETAIL INFORMATION EXIST IN THIS MASTER TABLE
--SET 
--0=0
--WHERE BillNo=@BillNo 
commit transaction

if @@error>0 
Rollback Transaction

GO
