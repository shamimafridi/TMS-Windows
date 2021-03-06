USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateDetailHistoryTransactionAudit]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDetailHistoryTransactionAudit]
@UserID		varchar(50) = '',
@ComputerID		varchar(50) = '',
@ProcessDateTime	datetime = null,
@Error			varchar(50) = '',
@TransactionDate	datetime = null,
@StationCode		bigint = 0, 
@TransactionNature	varchar(50) = '',
@TransactionNo		varchar(50) = '',
@PartyCode		Bigint = 0, 
@PONature		varchar(50) = '',
@PONumber		varchar(50) = '',
@ItemCode		Bigint = 0, 
@Quantity		decimal(20,5)=0,
@AvailableQuantity	decimal(20,5)=0,
@BalanceQuantity	decimal(20,5)=0,
@POAvailableQuantity	decimal(20,5)=0,
@POBalanceQuantity	decimal(20,5)=0,
@GUID 	                bigint = 0,
@NewRecord	bit = 0
 
AS
	IF @NewRecord = 1 
		BEGIN
			INSERT INTO dbo.MM_HistoryTransactionAuditTAB (UserID, ComputerID, ProcessDateTime, Error, TransactionDate, StationCode, TransactionNature, TransactionNo, PartyCode, PONature, PONumber,ItemCode, Quantity, AvailableQuantity, BalanceQuantity, POAvailableQuantity, POBalanceQuantity) 
			VALUES  ( @UserID, @ComputerID, @ProcessDateTime, @Error, @TransactionDate, @StationCode, @TransactionNature, @TransactionNo, @PartyCode, @PONature, @PONumber,@ItemCode, @Quantity, @AvailableQuantity, @BalanceQuantity, @POAvailableQuantity, @POBalanceQuantity) 
		END

GO
