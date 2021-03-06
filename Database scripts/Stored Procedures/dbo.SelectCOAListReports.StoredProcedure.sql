USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAListReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE  [dbo].[SelectCOAListReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999', @OPTION CHAR(50)='' ) 

AS
IF @OPTION='CONTROLLIST'
	SELECT     ControlCode, ControlDescription, DefinitionDate, '' AS GeneralCode, '' AS GeneralDescription,'' AS SubsidiaryCode, '' AS SubsidiaryDescription,'' AS SubSubCode, '' AS SubSubDescription
	FROM         dbo.COAControls
ELSE IF  @OPTION='GENERALLIST'
	SELECT     dbo.COAControls.ControlCode, dbo.COAGenerals.GeneralCode, dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralDescription, 
                      dbo.COAGenerals.DefinitionDate, '' AS GeneralCode, '' AS GeneralDescription,'' AS SubsidiaryCode, '' AS SubsidiaryDescription,'' AS SubSubCode, '' AS SubSubDescription
	FROM         dbo.COAControls RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode
ELSE IF @OPTION='SUBSIDIARYLIST'
	SELECT     dbo.COAControls.ControlCode, dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.COAControls.ControlDescription, 
	                      dbo.COAGenerals.GeneralDescription, dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.DefinitionDate
	FROM         dbo.COAControls RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode RIGHT OUTER JOIN
	                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
	                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode
ELSE IF @OPTION='SUBSUBSIDIARYLIST'
	SELECT     dbo.COAControls.ControlCode, dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.COAControls.ControlDescription, 
	              dbo.COAGenerals.GeneralDescription, dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
	              dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate
	FROM         dbo.COASubSubsidiaries LEFT OUTER JOIN
	              dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
	              dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
	              dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
	              dbo.COAControls RIGHT OUTER JOIN
	              dbo.COAGenerals ON dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
	              dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode
ELSE IF @OPTION='COAList'
	SELECT     SysFSFSubsidiaryCode,  SysFSFGeneralCode, RptCOAListing.ControlCode, RptCOAListing.ControlDescription, 
	                      RptCOAListing.GeneralCode, RptCOAListing.GeneralDescription, RptCOAListing.SubsidiaryCode, RptCOAListing.SubsidiaryDescription, 
	                      RptCOAListing.SubSubCode, RptCOAListing.SubSubDescription, RptCOAListing.DefinitionDate, RptCOAListing.ReportTitle, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.GLCode AS FSFGLCode, dbo.GL_GetFSFCombineLedTBRptVW.GLRptTitle AS FSFGLDescription, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.ControlCode AS FSFControlCode, dbo.GL_GetFSFCombineLedTBRptVW.ControlRptTitle AS FSFContro, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.GeneralCode AS FSFGeneralCode, dbo.GL_GetFSFCombineLedTBRptVW.GeneralRptTitle AS FSFGeneral, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.SubSidiaryCode AS FSFSubSidiaryCode, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.SubsidiaryRptTitle AS FSFSubsidiary, dbo.GL_GetFSFCombineLedTBRptVW.SubsubCode AS FSFSubsubCode, 
	                      dbo.GL_GetFSFCombineLedTBRptVW.SubSubRptTitle AS FSFSubsub
	FROM         (SELECT     ISNULL(dbo.COAControls.ControlCode, '') AS ControlCode, ISNULL(dbo.COAControls.ControlDescription, '') AS ControlDescription, 
	                      ISNULL(dbo.COAGenerals.GeneralCode, '') AS GeneralCode, ISNULL(dbo.COAGenerals.GeneralDescription, '') AS GeneralDescription, 
	                      ISNULL(dbo.COASubsidiaries.SubsidiaryCode, '') AS SubsidiaryCode, ISNULL(dbo.COASubsidiaries.SubsidiaryDescription, '') AS SubsidiaryDescription, 
	                      ISNULL(dbo.COASubSubsidiaries.SubSubsidiarycode, '') AS SubSubCode, ISNULL(dbo.COASubSubsidiaries.SubSubsidiaryDescription, '') AS SubSubDescription, 
	                      ISNULL(dbo.COASubSubsidiaries.DefinitionDate, '') AS DefinitionDate, ISNULL(dbo.COASubSubsidiaries.SubSubsidiaryDescription, '') AS ReportTitle, 
	                      COASubsidiaries.FSFGLCode AS SysFSFSubsidiaryCode, COAGenerals.FSFGLCode AS SysFSFGeneralCode, 
	                      (CASE ISNULL(COASubSubsidiaries.FSFGLCode, 0) WHEN 0 THEN (CASE ISNULL(COASubsidiaries.FSFGLCode, 0) 
	                      WHEN 0 THEN COAGenerals.FSFGLCode ELSE COASubsidiaries.FSFGLCode END) ELSE COASubSubsidiaries.FSFGLCode END) AS SysFSFGLCode
	FROM         dbo.COAControls LEFT OUTER JOIN
	                      dbo.COAGenerals LEFT OUTER JOIN
	                      dbo.COASubsidiaries LEFT OUTER JOIN
	                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
	                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode AND dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode ON 
	                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode ON 
	                      dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode) RptCOAListing LEFT OUTER JOIN
	                      dbo.GL_GetFSFCombineLedTBRptVW ON dbo.GL_GetFSFCombineLedTBRptVW.GLCode = RptCOAListing.SysFSFGlcode
	--WHERE     RptCOAListing. ControlCode+ RptCOAListing.GeneralCode+ RptCOAListing.SubsidiaryCode+ RptCOAListing.SubSubcode  BETWEEN @FromCode AND @ToCode  AND  RptCOAListing.DefinitionDate Between  @FromDate AND @ToDate

GO
