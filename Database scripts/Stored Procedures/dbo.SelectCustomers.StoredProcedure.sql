USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomers]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCustomers]
@Option as  varchar(20)='',
@CustomerCode as varchar(10) =''

AS

IF 	@Option='ALL' 
	SELECT     Customers.CustomerCode, Customers.CustomerName, Customers.UrduTitle, Customers.Address, Customers.CityCode, Customers.GLCode, Customers.PostalCode, 
                      Customers.Telephone, Customers.Mobile, Customers.Fax, Customers.eMail, Customers.SalesTaxNumber, Customers.NationalTaxNumber, Customers.DefinitionDate, 
                      GL_GetCOACombineTransactionVW_2.GLDescription, Cities.City, Customers.ShortageGLCode, 
                      GL_GetCOACombineTransactionVW_1.GLDescription AS ShortageGLDescription, Customers.WHTaxGLCode, 
                      GL_GetCOACombineTransactionVW_WHTax.GLDescription AS WHTaxGLDescription
FROM         Customers LEFT OUTER JOIN
                      GL_GetCOACombineTransactionVW AS GL_GetCOACombineTransactionVW_WHTax ON 
                      Customers.WHTaxGLCode = GL_GetCOACombineTransactionVW_WHTax.GLCode LEFT OUTER JOIN
                      GL_GetCOACombineTransactionVW AS GL_GetCOACombineTransactionVW_1 ON 
                      Customers.ShortageGLCode = GL_GetCOACombineTransactionVW_1.GLCode LEFT OUTER JOIN
                      GL_GetCOACombineTransactionVW AS GL_GetCOACombineTransactionVW_2 ON 
                      Customers.GLCode = GL_GetCOACombineTransactionVW_2.GLCode LEFT OUTER JOIN
                      Cities ON Customers.CityCode = Cities.CityCode
ORDER BY Customers.CustomerCode

	

 ELSE IF @Option='AUTO' 
		SELECT     Top 1 CustomerCode+1 as CustomerCode
		FROM         dbo.Customers
		order by CustomerCode desc
ELSE IF @Option='SRHGRID'
		SELECT     dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.Customers.UrduTitle, dbo.Customers.Address, dbo.Customers.CityCode, dbo.Customers.GLCode, 
                      dbo.Customers.PostalCode, dbo.Customers.Telephone, dbo.Customers.Mobile, dbo.Customers.Fax, dbo.Customers.eMail, dbo.Customers.SalesTaxNumber, 
                      dbo.Customers.NationalTaxNumber, dbo.Customers.DefinitionDate, GL_GetCOACombineTransactionVW_1.GLDescription, dbo.Cities.City, 
                      dbo.Customers.ShortageGLCode, GL_GetCOACombineTransactionVW_1.GLDescription AS ShortageGLDescription, dbo.Customers.WHTaxGLCode, 
                      GL_GetCOACombineTransactionVW_WHTax.GLDescription AS WHTaxGLDescription
		FROM         dbo.Customers LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_WHTax ON 
                      dbo.Customers.WHTaxGLCode = GL_GetCOACombineTransactionVW_WHTax.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_1 ON 
                      dbo.Customers.ShortageGLCode = GL_GetCOACombineTransactionVW_1.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_2 ON 
                      dbo.Customers.GLCode = GL_GetCOACombineTransactionVW_2.GLCode LEFT OUTER JOIN
                      dbo.Cities ON dbo.Customers.CityCode = dbo.Cities.CityCode
		ORDER BY dbo.Customers.CustomerCode
ELSE
		SELECT     dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.Customers.UrduTitle, dbo.Customers.Address, dbo.Customers.CityCode, dbo.Customers.GLCode, 
                      dbo.Customers.PostalCode, dbo.Customers.Telephone, dbo.Customers.Mobile, dbo.Customers.Fax, dbo.Customers.eMail, dbo.Customers.SalesTaxNumber, 
                      dbo.Customers.NationalTaxNumber, dbo.Customers.DefinitionDate, GL_GetCOACombineTransactionVW_1.GLDescription, dbo.Cities.City, 
                      dbo.Customers.ShortageGLCode, GL_GetCOACombineTransactionVW_1.GLDescription AS ShortageGLDescription, dbo.Customers.WHTaxGLCode, 
                      GL_GetCOACombineTransactionVW_WHTax.GLDescription AS WHTaxGLDescription

		FROM         dbo.Customers LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_WHTax ON 
                      dbo.Customers.WHTaxGLCode = GL_GetCOACombineTransactionVW_WHTax.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_1 ON 
                      dbo.Customers.ShortageGLCode = GL_GetCOACombineTransactionVW_1.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_2 ON 
                      dbo.Customers.GLCode = GL_GetCOACombineTransactionVW_2.GLCode LEFT OUTER JOIN
                      dbo.Cities ON dbo.Customers.CityCode = dbo.Cities.CityCode
		WHERE CustomerCode=@CustomerCode
        ORDER BY dbo.Customers.CustomerCode

GO
