USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionDocumentReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE  [dbo].[SelectTransactionDocumentReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromPartyCode as varchar(10)='0000000',@ToPartyCode as varchar(10)='99999999999',  @FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999',@TransactionNature as varchar(10) = '' ,@FromTransactionNumber as varchar(20)='0000000000',@ToTransactionNumber as varchar(10)='9999999999', @OPTION CHAR(10)='' ) 

AS

IF @TransactionNature=10 OR @TransactionNature=30
		SELECT     dbo.Transactions.TransactionNature, dbo.Transactions.TransactionNo, dbo.Transactions.TransactionDate, dbo.Transactions.MiscPartyName, 
		                      dbo.Transactions.Description, dbo.Items.ItemCategoryCode + dbo.Items.ItemCode AS ItemCode, dbo.Items.Item, 
		                      dbo.Customers.CityCode AS CusCityCode, dbo.Suppliers.CityCode AS SuppCityCode, CustumerCity.City AS CustCity, SupplierCity.City AS SupCity, 
		                      dbo.Units.UnitCode, dbo.Units.Unit, dbo.ItemCategories.ItemCategoryCode, dbo.ItemCategories.ItemCategory, dbo.Suppliers.SupplierCode, 
		                      dbo.Suppliers.SupplierName, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.TransactionDetails.QuantityIssued, 
		                      dbo.TransactionDetails.QuantityReceived, dbo.TransactionDetails.Price, dbo.TransactionDetails.Rate, dbo.TransactionDetails.BonusReceived, 
		                      dbo.TransactionDetails.BonusIssued, dbo.TransactionDetails.Discount, dbo.TransactionDetails.Remarks
		FROM         dbo.Cities CustumerCity RIGHT OUTER JOIN
		                      dbo.Customers RIGHT OUTER JOIN
		                      dbo.Transactions ON dbo.Customers.CustomerCode = dbo.Transactions.CustomerCode LEFT OUTER JOIN
		                      dbo.Suppliers LEFT OUTER JOIN
		                      dbo.Cities SupplierCity ON dbo.Suppliers.CityCode = SupplierCity.CityCode ON dbo.Transactions.SupplierCode = dbo.Suppliers.SupplierCode ON 
		                      CustumerCity.CityCode = dbo.Customers.CityCode LEFT OUTER JOIN
		                      dbo.TransactionDetails LEFT OUTER JOIN
		                      dbo.ItemCategories RIGHT OUTER JOIN
		                      dbo.Items RIGHT OUTER JOIN
		                      dbo.Units ON dbo.Items.UnitCode = dbo.Units.UnitCode ON dbo.ItemCategories.ItemCategoryCode = dbo.Items.ItemCategoryCode ON 
		                      dbo.TransactionDetails.ItemCode = dbo.Items.ItemCode AND dbo.TransactionDetails.ItemCategoryCode = dbo.Items.ItemCategoryCode ON 
		                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
		                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature
		WHERE Suppliers.SupplierCode  BETWEEN     @FromPartyCode  AND
			 @TOPartyCode  AND Transactions.TransactionNO   BETWEEN     @FromCode   AND   @ToCode    
			 AND Transactions.TransactionDate   BETWEEN  @FromDate   AND  @ToDate 
			 AND Transactions.TransactionNature   = @TransactionNature 
			 ORDER BY dbo.Transactions.TransactionNo

ELSE  
		SELECT     dbo.Transactions.TransactionNature, dbo.Transactions.TransactionNo, dbo.Transactions.TransactionDate, dbo.Transactions.MiscPartyName, 
		                      dbo.Transactions.Description, dbo.Items.ItemCategoryCode + dbo.Items.ItemCode AS ItemCode, dbo.Items.Item, 
		                      dbo.Customers.CityCode AS CusCityCode, dbo.Suppliers.CityCode AS SuppCityCode, CustumerCity.City AS CustCity, SupplierCity.City AS SupCity, 
		                      dbo.Units.UnitCode, dbo.Units.Unit, dbo.ItemCategories.ItemCategoryCode, dbo.ItemCategories.ItemCategory, dbo.Suppliers.SupplierCode, 
		                      dbo.Suppliers.SupplierName, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.TransactionDetails.QuantityIssued, 
		                      dbo.TransactionDetails.QuantityReceived, dbo.TransactionDetails.Price, dbo.TransactionDetails.Rate, dbo.TransactionDetails.BonusReceived, 
		                      dbo.TransactionDetails.BonusIssued, dbo.TransactionDetails.Discount, dbo.TransactionDetails.Remarks
		FROM         dbo.Cities CustumerCity RIGHT OUTER JOIN
		                      dbo.Customers RIGHT OUTER JOIN
		                      dbo.Transactions ON dbo.Customers.CustomerCode = dbo.Transactions.CustomerCode LEFT OUTER JOIN
		                      dbo.Suppliers LEFT OUTER JOIN
		                      dbo.Cities SupplierCity ON dbo.Suppliers.CityCode = SupplierCity.CityCode ON dbo.Transactions.SupplierCode = dbo.Suppliers.SupplierCode ON 
		                      CustumerCity.CityCode = dbo.Customers.CityCode LEFT OUTER JOIN
		                      dbo.TransactionDetails LEFT OUTER JOIN
		                      dbo.ItemCategories RIGHT OUTER JOIN
		                      dbo.Items RIGHT OUTER JOIN
		                      dbo.Units ON dbo.Items.UnitCode = dbo.Units.UnitCode ON dbo.ItemCategories.ItemCategoryCode = dbo.Items.ItemCategoryCode ON 
		                      dbo.TransactionDetails.ItemCode = dbo.Items.ItemCode AND dbo.TransactionDetails.ItemCategoryCode = dbo.Items.ItemCategoryCode ON 
		                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
		                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature
		WHERE Customers.CustomerCode  BETWEEN     @FromPartyCode  AND
			 @TOPartyCode  AND Transactions.TransactionNO   BETWEEN     @FromCode   AND   @ToCode    
			 AND Transactions.TransactionDate   BETWEEN  @FromDate   AND  @ToDate 
			 AND Transactions.TransactionNature   = @TransactionNature 
			 ORDER BY dbo.Transactions.TransactionNo

GO
