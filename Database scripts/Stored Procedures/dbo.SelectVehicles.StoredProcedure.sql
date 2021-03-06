USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicles]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicles]
@Option as  varchar(20)='',
@VehicleCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Vehicles.VehicleCode, dbo.Vehicles.VehicleDescription, dbo.Vehicles.DefinitionDate, dbo.Vehicles.InstallmentGLCode, 
			GL_GetCOACombineTransactionVW_Installment.GLDescription AS InstallmentGLDescription, dbo.Vehicles.FreightGLCode, 
			GL_GetCOACombineTransactionVW_Freight.GLDescription AS FreightGLDescription, dbo.Vehicles.LoanGLCode, 
			GL_GetCOACombineTransactionVW_1.GLDescription AS LoanGLDescription, dbo.VehicleOwners.OwnerCode, dbo.VehicleOwners.OwnerName, 
			dbo.Vehicles.CommissionGLCode, GL_GetCOACombineTransactionVW_Commission.GLDescription as CommissionGLDescription
			, GL_GetCOACombineTransactionVW_Commission.GLDescription AS CommissionGLDescription, dbo.Customers.CustomerCode, 
			dbo.Customers.CustomerName as Customer,dbo.[Vehicles].Capacity ,dbo.[Vehicles].IsThirdParty   
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
		ORDER BY  dbo.Vehicles.VehicleCode
ELSE IF @Option='COMBO'
		SELECT     dbo.Vehicles.VehicleCode
		FROM Vehicles
ELSE IF @Option='SRHGRID'
		SELECT     dbo.Vehicles.VehicleCode, dbo.Vehicles.VehicleDescription, dbo.Vehicles.DefinitionDate, dbo.Vehicles.InstallmentGLCode, 
		      GL_GetCOACombineTransactionVW_Installment.GLDescription AS InstallmentGLDescription, dbo.Vehicles.FreightGLCode, 
		      GL_GetCOACombineTransactionVW_Freight.GLDescription AS FreightGLDescription, dbo.Vehicles.LoanGLCode, 
		      GL_GetCOACombineTransactionVW_1.GLDescription AS LoanGLDescription, dbo.VehicleOwners.OwnerCode, dbo.VehicleOwners.OwnerName, 
		    dbo.[Vehicles].IsThirdParty,
		      dbo.Vehicles.CommissionGLCode, GL_GetCOACombineTransactionVW_Commission.GLDescription as CommissionGLDescription
		FROM         dbo.Vehicles LEFT OUTER JOIN
		      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Commission ON 
		      dbo.Vehicles.CommissionGLCode = GL_GetCOACombineTransactionVW_Commission.GLCode LEFT OUTER JOIN
		      dbo.VehicleOwners ON dbo.Vehicles.OwnerCode = dbo.VehicleOwners.OwnerCode LEFT OUTER JOIN
		      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Freight ON 
		      dbo.Vehicles.FreightGLCode = GL_GetCOACombineTransactionVW_Freight.GLCode LEFT OUTER JOIN
		      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Installment ON 
		      dbo.Vehicles.InstallmentGLCode = GL_GetCOACombineTransactionVW_Installment.GLCode LEFT OUTER JOIN
		      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_1 ON dbo.Vehicles.LoanGLCode = GL_GetCOACombineTransactionVW_1.GLCode

ELSE
		SELECT     dbo.Vehicles.VehicleCode, dbo.Vehicles.VehicleDescription, dbo.Vehicles.DefinitionDate, dbo.Vehicles.InstallmentGLCode, 
				GL_GetCOACombineTransactionVW_Installment.GLDescription AS InstallmentGLDescription, dbo.Vehicles.FreightGLCode, 
				GL_GetCOACombineTransactionVW_Freight.GLDescription AS FreightGLDescription, dbo.Vehicles.LoanGLCode, 
				GL_GetCOACombineTransactionVW_1.GLDescription AS LoanGLDescription, dbo.VehicleOwners.OwnerCode, dbo.VehicleOwners.OwnerName, 
				dbo.Vehicles.CommissionGLCode, GL_GetCOACombineTransactionVW_Commission.GLDescription as CommissionGLDescription,
				dbo.Customers.CustomerCode, dbo.[Vehicles].Capacity  ,
				dbo.Customers.CustomerName as Customer,dbo.[Vehicles].IsThirdParty
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
		 WHERE dbo.Vehicles.VehicleCode =@VehicleCode
         ORDER BY dbo.Vehicles.VehicleCode

GO
