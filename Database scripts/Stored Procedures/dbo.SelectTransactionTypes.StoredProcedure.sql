USE [TMS_ALI];
GO

/****** Object:  StoredProcedure [dbo].[SelectTransactionTypes]    Script Date: 03-Feb-18 9:47:12 PM ******/

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
ALTER PROCEDURE [dbo].[SelectTransactionTypes]
(@OPTION AS              VARCHAR(100) = '',
 @TransactionTypeCode AS VARCHAR(100) = '',
 @NatureCode AS          VARCHAR(100) = ''
)
AS
     IF @OPTION = 'TRL'
         SELECT TransactionTypes.TransactionTypeCode,
                TransactionTypes.TransactionType,
                TransactionTypes.UrduTitle,
                TransactionTypes.DefinitionDate,
                TransactionNatures.NatureCode,
                TransactionTypes.Nature,
                GL.GLCode,
                GL.GLDescription
         FROM TransactionTypes
              INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
              LEFT JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
         WHERE(TransactionNatures.System = 'IN');
         ELSE
     IF @Option = 'AUTO'
         SELECT TOP 1 TransactionTypeCode + 1 AS TransactionTypeCode
         FROM dbo.TransactionTypes
         ORDER BY TransactionTypeCode DESC;
         ELSE
     IF @OPTION = 'ALL'
         SELECT TransactionTypes.TransactionTypeCode,
                TransactionTypes.TransactionType,
                TransactionTypes.UrduTitle,
                TransactionTypes.DefinitionDate,
                TransactionNatures.NatureCode,
                TransactionTypes.Nature,
                GL.GLCode,
                GL.GLDescription
         FROM TransactionTypes
              INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
              LEFT JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
         WHERE(TransactionNatures.System = 'IN');
         ELSE
     IF @OPTION = 'COMBO'
         SELECT TransactionTypeCode AS TypeCode,
                TransactionType AS Type,
                UrduTitle
         FROM TransactionTypes
         WHERE Nature = @NatureCode;
         ELSE
     IF @OPTION = 'SRHGRID'
	   SELECT TransactionTypes.TransactionTypeCode,
                TransactionTypes.TransactionType,
                TransactionTypes.UrduTitle,
                TransactionTypes.DefinitionDate,
                TransactionNatures.NatureCode,
                TransactionTypes.Nature,
                GL.GLCode,
                GL.GLDescription
         FROM TransactionTypes
              INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
              LEFT JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
         ELSE
     IF @OPTION = N'PKVALIDATION'
         SELECT TransactionTypes.TransactionTypeCode,
                TransactionTypes.TransactionType,
                TransactionTypes.UrduTitle,
                TransactionTypes.DefinitionDate,
                TransactionNatures.NatureCode,
                TransactionTypes.Nature,
                GL.GLCode,
                GL.GLDescription
         FROM TransactionTypes
              INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
              LEFT JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
         WHERE TransactionTypeCode = @TransactionTypeCode
               AND NatureCode = @NatureCode;
         ELSE
     SELECT TransactionTypes.TransactionTypeCode,
            TransactionTypes.TransactionType,
            TransactionTypes.UrduTitle,
            TransactionTypes.DefinitionDate,
            TransactionNatures.NatureCode,
            TransactionTypes.Nature,
            GL.GLCode,
            GL.GLDescription
     FROM TransactionTypes
          INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
          LEFT JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
     WHERE TransactionTypeCode = @TransactionTypeCode
           AND NatureCode = @NatureCode;
GO
