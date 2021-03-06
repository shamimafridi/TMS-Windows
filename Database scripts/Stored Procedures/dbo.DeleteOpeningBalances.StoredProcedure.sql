USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteOpeningBalances]    Script Date: 5/5/2018 9:17:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOpeningBalances] @BranchCode AS  VARCHAR(10) = '',
                                               @ClosingDate AS DATETIME    = '',
                                               @GlCode AS      VARCHAR(20) = '',
                                               @DivisionCode AS VARCHAR(20) = ''
AS
     IF @DivisionCode <> ''
        AND @BranchCode <> ''
        AND @GlCode <> ''
         DELETE FROM OpeningBalances
         WHERE ClosingDate = @ClosingDate
               AND dbo.OpeningBalances.Branchcode = @BranchCode
               AND OpeningBalances.GLCode = @GlCode
               AND OpeningBalances.DivisionCode = @DivisionCode;
GO
