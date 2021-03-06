USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteHistoryTransactionAudit]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteHistoryTransactionAudit]
@UserID		varchar(50) = '',
@ComputerID		varchar(50) = '',
@ProcessDateTime	datetime = null,
@Error			varchar(50) = '',
@DocumentDate		datetime = null,
@StationCode		Bigint = 0, 
@DocumentNature		varchar(50) = '',
@DocumentNo		varchar(50) = '',
@PartyCode		Bigint = 0, 
@PONature		varchar(50) = '',
@PONumber		varchar(50) = '',
@ItemCode		Bigint = 0, 
@Quantity		decimal(20,5)=0,
@AvailableQuantity	decimal(20,5)=0,
@BalanceQuantity	decimal(20,5)=0,
@POAvailableQuantity	decimal(20,5)=0,
@POBalanceQuantity	decimal(20,5)=0,
@GUID bigint = 0
AS

GO
