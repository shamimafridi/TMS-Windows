USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFCombine]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectFSFCombine]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) ='',
@GLCode as char(14)=''



AS


IF 	@Option='ALL' 
	Select * from GL_GetFSFCombineTransactionVW
ELSE IF @Option='SRHGRID' 
	Select * from GL_GetFSFCombineTransactionVW
ELSE IF @Option='CASHFLOW' AND @GLCode<>''
	Select * from GL_GetFSFCombineVW
	WHERE LEFT(GlCode ,4)=@GLCode
ELSE IF @GlCode<>''
	Select * from GL_GetFSFCombineTransactionVW
	WHERE GL_GetFSFCombineTransactionVW.GLCode=@GLCode

GO
