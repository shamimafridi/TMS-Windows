USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectChartOfAccounts]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectChartOfAccounts]
@Option as  varchar(20)='',
@CustomerID as varchar(10) =''

AS

IF 	@Option='ALL' 
	SELECT * FROM ChartOfAccounts
ELSE
	SELECT * FROM ChartOfAccounts

GO
