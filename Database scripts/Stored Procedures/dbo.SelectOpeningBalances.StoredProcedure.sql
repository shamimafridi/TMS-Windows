USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectOpeningBalances]    Script Date: 5/5/2018 9:17:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectOpeningBalances] @Option AS      VARCHAR(20) = '',
                                              @BranchCode AS  VARCHAR(10) = '',
                                              @ClosingDate AS DATETIME    = '',
                                              @GlCode AS      VARCHAR(20) = '',
                                              @DivisionCode AS VARCHAR(20) = ''
AS
     IF @Option = 'ALL'
         BEGIN
             SELECT dbo.OpeningBalances.ClosingDate,
                    dbo.Divisions.DivisionCode,
                    dbo.Divisions.Division,
                    dbo.Branches.BranchCode,
                    dbo.Branches.BranchDescription,
                    dbo.GL_GetCOACombineTransactionVW.GLCode,
                    dbo.GL_GetCOACombineTransactionVW.GLDescription,
                    dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
             FROM dbo.OpeningBalances
                  LEFT OUTER JOIN dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
                  LEFT OUTER JOIN dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode
                  LEFT OUTER JOIN dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode;
         END;
         ELSE
     IF @Option = 'SRHGRID'
         BEGIN
             SELECT *
             FROM OpeningBalances;
             SELECT dbo.OpeningBalances.ClosingDate,
                    dbo.Divisions.DivisionCode,
                    dbo.Divisions.Division,
                    dbo.Branches.BranchCode,
                    dbo.Branches.BranchDescription,
                    dbo.GL_GetCOACombineTransactionVW.GLCode,
                    dbo.GL_GetCOACombineTransactionVW.GLDescription,
                    dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
             FROM dbo.OpeningBalances
                  LEFT OUTER JOIN dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
                  LEFT OUTER JOIN dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode
                  LEFT OUTER JOIN dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode;
         END;
         ELSE
         BEGIN
             SELECT dbo.OpeningBalances.ClosingDate,
                    dbo.Divisions.DivisionCode,
                    dbo.Divisions.Division,
                    dbo.Branches.BranchCode,
                    dbo.Branches.BranchDescription,
                    dbo.GL_GetCOACombineTransactionVW.GLCode,
                    dbo.GL_GetCOACombineTransactionVW.GLDescription,
                    dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
             FROM dbo.OpeningBalances
                  LEFT OUTER JOIN dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
                  LEFT OUTER JOIN dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode
                  LEFT OUTER JOIN dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode
             WHERE ClosingDate = @ClosingDate
                   AND dbo.OpeningBalances.Branchcode = @BranchCode
                   AND OpeningBalances.GLCode = @GlCode
                   AND OpeningBalances.DivisionCode = @DivisionCode;
         END;
GO
