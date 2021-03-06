USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectListReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SelectListReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromManufacturerCode as varchar(10)='0000000',@ToManufacturerCode as varchar(10)='99999999999',  @FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999', @OPTION CHAR(100)='' ) 

AS
IF @OPTION='VehicleList'
	BEGIN
	SELECT     TOP 100 PERCENT dbo.Vehicles.VehicleCode, dbo.Vehicles.VehicleDescription, dbo.Vehicles.DefinitionDate, dbo.Vehicles.InstallmentGLCode, 
	                      GL_GetCOACombineTransactionVW_Installment.GLDescription AS InstallmentGLDescription, dbo.Vehicles.FreightGLCode, 
	                      GL_GetCOACombineTransactionVW_Freight.GLDescription AS FreightGLDescription, dbo.Vehicles.LoanGLCode, 
	                      GL_GetCOACombineTransactionVW_1.GLDescription AS LoanGLDescription, dbo.VehicleOwners.OwnerCode, dbo.VehicleOwners.OwnerName, 
	                      dbo.Vehicles.CommissionGLCode, GL_GetCOACombineTransactionVW_Commission.GLDescription AS CommissionGLDescription, dbo.Customers.CustomerCode, 
	                      dbo.Customers.CustomerName
	FROM         dbo.Vehicles LEFT OUTER JOIN
	                      dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Commission ON 
	                      dbo.Vehicles.CommissionGLCode = GL_GetCOACombineTransactionVW_Commission.GLCode LEFT OUTER JOIN
	                      dbo.VehicleOwners ON dbo.Vehicles.OwnerCode = dbo.VehicleOwners.OwnerCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Freight ON 
	                      dbo.Vehicles.FreightGLCode = GL_GetCOACombineTransactionVW_Freight.GLCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Installment ON 
	                      dbo.Vehicles.InstallmentGLCode = GL_GetCOACombineTransactionVW_Installment.GLCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_1 ON dbo.Vehicles.LoanGLCode = GL_GetCOACombineTransactionVW_1.GLCode
	WHERE dbo.Vehicles.VehicleCode BETWEEN @FromCode AND @ToCode
	AND  dbo.Vehicles.DefinitionDate BETWEEN @FromDate AND @ToDate
	ORDER BY dbo.Vehicles.VehicleCode
    END

GO
