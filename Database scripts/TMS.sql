USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[RestoreDatabase]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[RestoreDatabase]
@FileName varchar(200) ='C:\BIS aa.bak',
@temp_dump varchar(255)='',
@database varchar(255)=''
as
set @temp_dump='C:\'
set @database='BIS'

Restore database BIS From disk= @FileName

--END HARD DISK BACKUP--
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Regions](
	[RegionCode] [char](3) NOT NULL,
	[RegionName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[RegionCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectNodesSetup]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProjectNodesSetup](
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[NodeName] [nvarchar](50) NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[TableNature] [char](10) NOT NULL,
	[NodeType] [nvarchar](50) NOT NULL,
	[ShowNode] [tinyint] NOT NULL,
	[ImageIndex] [int] NOT NULL,
	[SortingOrder] [int] NULL,
	[SystemType] [char](2) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GL_DetailPaymentVoucherTAB]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GL_DetailPaymentVoucherTAB](
	[BranchCode] [bigint] NOT NULL,
	[DocumentNo] [varchar](10) NOT NULL,
	[DocumentNature] [bigint] NOT NULL,
	[APVNo] [varchar](10) NOT NULL,
	[APVNatureCode] [bigint] NOT NULL,
	[RecordNo] [int] NOT NULL,
	[SupplierBillNo] [varchar](50) NOT NULL,
	[APVAmount] [numeric](20, 5) NOT NULL,
	[PaymentTypeCode] [bigint] NOT NULL,
	[TaxRate] [numeric](20, 5) NOT NULL,
	[TaxValue] [numeric](20, 5) NOT NULL,
	[GLCode] [bigint] NULL,
	[DivisionCode] [bigint] NULL,
	[OldRef] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StationPoints]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StationPoints](
	[StationPointCode] [char](3) NOT NULL,
	[StationPointName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[PointNo] [numeric](18, 0) NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_StationPoints] PRIMARY KEY CLUSTERED 
(
	[StationPointCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SetupTables]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SetupTables](
	[TableName] [nvarchar](50) NULL,
	[AlternateTable] [nvarchar](50) NULL,
	[TableNature] [nvarchar](50) NULL,
	[TableType] [char](10) NULL,
	[ShowTable] [tinyint] NULL,
	[ss] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionNatures]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransactionNatures](
	[NatureCode] [char](2) NOT NULL,
	[Nature] [varchar](50) NOT NULL,
	[Term] [varchar](50) NOT NULL,
	[System] [char](10) NULL,
	[IsPaymentVoucher] [tinyint] NULL,
 CONSTRAINT [PK_TransactionNatures] PRIMARY KEY CLUSTERED 
(
	[NatureCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionActivities]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransactionActivities](
	[GUID] [bigint] NOT NULL,
	[ParentGUID] [bigint] NOT NULL,
	[FormTypeCode] [int] NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[TransactionTime] [varchar](50) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[ComputerID] [varchar](50) NULL,
	[ActionPerformed] [varchar](1) NULL,
	[ReferenceText] [varchar](100) NULL,
 CONSTRAINT [PK_MM_TransactionActivityTAB] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TempTransDetailVBill]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempTransDetailVBill](
	[MODE] [varchar](6) NOT NULL,
	[TransactionNature] [char](3) NOT NULL,
	[TransactionNo] [char](10) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[RecordNo] [bigint] NOT NULL,
	[CustomerReference] [char](20) NULL,
	[VehicleCode] [char](10) NULL,
	[StationPointCode] [char](3) NULL,
	[DestinationPointCode] [char](3) NULL,
	[ProductCode] [char](3) NULL,
	[Quantity] [decimal](20, 5) NULL,
	[Rate] [decimal](20, 5) NULL,
	[Debit] [decimal](20, 5) NULL,
	[Credit] [decimal](20, 5) NULL,
	[Commission] [decimal](20, 5) NULL,
	[ShortageQuantity] [decimal](20, 5) NULL,
	[Shortage] [decimal](20, 5) NULL,
	[QuantityValue] [decimal](20, 5) NULL,
	[OwnerCode] [char](5) NULL,
	[OwnerName] [varchar](100) NULL,
	[UrduOwnerName] [nvarchar](500) NULL,
	[ProductUrdu] [nvarchar](200) NULL,
	[StationPointName] [varchar](100) NOT NULL,
	[StationPointUrdu] [nvarchar](200) NULL,
	[DestinationPointName] [varchar](100) NOT NULL,
	[DestinationPointUrdu] [nvarchar](200) NULL,
	[GLCode] [char](12) NULL,
	[GLDescription] [varchar](100) NULL,
	[GLDescriptionINV] [nvarchar](2000) NULL,
	[CustomerCode] [char](5) NULL,
	[CustomerName] [varchar](100) NULL,
	[UrduCustomerName] [nvarchar](200) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TempTransDetailTrialFSF]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempTransDetailTrialFSF](
	[BranchCode] [char](2) NOT NULL,
	[BranchRptTitle] [varchar](100) NULL,
	[DivisionCode] [char](3) NOT NULL,
	[DivisionRptTitle] [varchar](100) NULL,
	[GLCode] [char](12) NOT NULL,
	[GLRptTitle] [varchar](100) NOT NULL,
	[ControlCode] [char](2) NULL,
	[ControlRptTitle] [varchar](100) NULL,
	[GeneralCode] [char](4) NULL,
	[GeneralRptTitle] [varchar](100) NULL,
	[SubSidiaryCode] [char](8) NULL,
	[SubsidiaryRptTitle] [varchar](100) NULL,
	[SubsubCode] [char](12) NULL,
	[SubSubRptTitle] [varchar](100) NOT NULL,
	[FSFGLCode] [varchar](21) NULL,
	[FSFGLRptTitle] [varchar](100) NOT NULL,
	[FSFControlCode] [varchar](20) NULL,
	[FSFControlRptTitle] [varchar](100) NULL,
	[FSFGeneralCode] [varchar](40) NULL,
	[FSFGeneralRptTitle] [varchar](100) NULL,
	[FSFSubSidiaryCode] [varchar](42) NULL,
	[FSFSubsidiaryRptTitle] [varchar](100) NULL,
	[FSFSubsubCode] [varchar](44) NULL,
	[FSFSubSubRptTitle] [varchar](100) NOT NULL,
	[OpeningBalance] [int] NOT NULL,
	[DebitBalance] [decimal](38, 5) NULL,
	[CreditBalance] [decimal](38, 5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TempTransDetailLedgerTrial]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempTransDetailLedgerTrial](
	[BranchCode] [char](2) NOT NULL,
	[BranchRptTitle] [varchar](100) NULL,
	[DivisionCode] [char](3) NOT NULL,
	[DivisionRptTitle] [varchar](100) NULL,
	[GLCode] [char](12) NOT NULL,
	[GLRptTitle] [varchar](100) NOT NULL,
	[ControlCode] [char](2) NULL,
	[ControlRptTitle] [varchar](100) NULL,
	[GeneralCode] [char](4) NULL,
	[GeneralRptTitle] [varchar](100) NULL,
	[SubSidiaryCode] [char](8) NULL,
	[SubsidiaryRptTitle] [varchar](100) NULL,
	[SubsubCode] [char](12) NULL,
	[SubSubRptTitle] [varchar](100) NOT NULL,
	[OpeningBalance] [int] NOT NULL,
	[DebitBalance] [decimal](38, 5) NULL,
	[CreditBalance] [decimal](38, 5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TempTransDetailLedger]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempTransDetailLedger](
	[BranchCode] [char](2) NOT NULL,
	[BranchRptTitle] [varchar](100) NULL,
	[DivisionCode] [char](3) NOT NULL,
	[DivisionRptTitle] [varchar](100) NULL,
	[GLCode] [char](12) NOT NULL,
	[GLRptTitle] [varchar](100) NOT NULL,
	[NatureCode] [char](2) NOT NULL,
	[NatureRptTitle] [varchar](50) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[VoucherNo] [char](10) NOT NULL,
	[OldRef] [char](12) NULL,
	[Narration] [varchar](100) NULL,
	[NarrationMain] [varchar](250) NULL,
	[RecordNo] [bigint] NOT NULL,
	[Reference] [varchar](100) NULL,
	[Debit] [decimal](20, 5) NULL,
	[Credit] [decimal](20, 5) NULL,
	[ControlCode] [char](2) NULL,
	[ControlRptTitle] [varchar](100) NULL,
	[GeneralCode] [char](4) NULL,
	[GeneralRptTitle] [varchar](100) NULL,
	[SubSidiaryCode] [char](8) NULL,
	[SubsidiaryRptTitle] [varchar](100) NULL,
	[SubsubCode] [char](12) NULL,
	[SubSubRptTitle] [varchar](100) NOT NULL,
	[Posted] [bit] NULL,
	[Locked] [bit] NULL,
	[DetailRecordNo] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TempTransDetailCF]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempTransDetailCF](
	[BranchCode] [char](2) NOT NULL,
	[BranchRptTitle] [varchar](100) NULL,
	[DivisionCode] [char](3) NOT NULL,
	[DivisionRptTitle] [varchar](100) NULL,
	[GLCode] [char](12) NOT NULL,
	[GLRptTitle] [varchar](100) NOT NULL,
	[NatureCode] [char](2) NOT NULL,
	[NatureRptTitle] [varchar](50) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[VoucherNo] [char](10) NOT NULL,
	[OldRef] [char](12) NULL,
	[Narration] [varchar](100) NULL,
	[NarrationMain] [varchar](250) NULL,
	[RecordNo] [bigint] NOT NULL,
	[Reference] [varchar](100) NULL,
	[Debit] [decimal](20, 5) NULL,
	[Credit] [decimal](20, 5) NULL,
	[ControlCode] [char](2) NULL,
	[ControlRptTitle] [varchar](100) NULL,
	[GeneralCode] [char](4) NULL,
	[GeneralRptTitle] [varchar](100) NULL,
	[SubSidiaryCode] [char](8) NULL,
	[SubsidiaryRptTitle] [varchar](100) NULL,
	[SubsubCode] [char](12) NULL,
	[SubSubRptTitle] [varchar](100) NOT NULL,
	[ApplyGrouping] [varchar](1) NOT NULL,
	[Posted] [bit] NULL,
	[Locked] [bit] NULL,
	[DetailRecordNo] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoucherDetails]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoucherDetails](
	[BranchCode] [char](2) NULL,
	[VoucherNature] [char](2) NOT NULL,
	[VoucherNo] [char](10) NOT NULL,
	[GLCode] [char](20) NOT NULL,
	[DivisionCode] [char](3) NOT NULL,
	[Reference] [varchar](100) NULL,
	[Debit] [decimal](20, 5) NULL,
	[Credit] [decimal](20, 5) NULL,
	[Narration] [varchar](100) NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[DeleteVihicles]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteVihicles]
@VihicleCode nchar(8)=''
AS
	IF @VihicleCode <> ''
		DELETE FROM Vihicles 
		WHERE ( VihicleCode= @VihicleCode)
GO
/****** Object:  Table [dbo].[UserSecurities]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserSecurities](
	[UserID] [varchar](25) NOT NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](50) NOT NULL,
	[EmpCode] [varchar](10) NULL,
	[IsLoggedIn] [bit] NULL,
	[IsAdministrator] [bit] NOT NULL,
	[NormalShutDown] [bit] NULL,
	[IsActive] [bit] NULL,
	[S_Account] [varchar](3) NULL,
	[T_Order] [varchar](3) NULL,
	[R_RecVoucher] [bit] NULL,
 CONSTRAINT [PK_MSL_UserSecurityTAB] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsedTransactionsDetail]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsedTransactionsDetail](
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[VoucherNature] [char](10) NOT NULL,
	[VoucherNo] [varchar](10) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[GLCode] [char](14) NOT NULL,
	[BillNo] [varchar](50) NOT NULL,
	[RefVoucherNature] [char](19) NOT NULL,
	[RefVoucherNo] [varchar](10) NOT NULL,
	[RefVoucherDate] [datetime] NOT NULL,
	[RefBillNo] [varchar](50) NOT NULL,
	[AmountUsed] [numeric](20, 5) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateTransactionsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateTransactionsDetails]

@BranchCode char(2) = ''  ,
@TransactionNature char(2) = ''  ,
@TransactionNo varchar(16)=' '  ,
@GLCode as  varchar(12)=''  ,
@GLDescription as  varchar(12)=''  ,
@DivisionCode  char(5) ='' ,
@Division  varchar(15) ='' ,
@Quantity decimal=0.00,
@Rate decimal=0.00,
@Amount decimal=0.00,
@NewRecord as bigint

 AS 



 IF @TransactionNature='30' or  @TransactionNature='40' 
		INSERT INTO TransactionDetails (BranchCode, TransactionNature ,TransactionNo, GLCode,DivisionCode, Quantity , Rate, Amount) 
		                       VALUES  (@BranchCode, @TransactionNature ,@TransactionNo  ,@GLCode, @DivisionCode,@Quantity,@Rate, @Amount)
GO
/****** Object:  Table [dbo].[GeneratedReferences]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GeneratedReferences](
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[GenFrom] [varchar](10) NOT NULL,
	[FormName] [varchar](50) NOT NULL,
	[FromBranchCode] [char](3) NULL,
	[TransactionNature] [char](3) NOT NULL,
	[TransactionNo] [varchar](10) NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[DocumentNature] [char](3) NOT NULL,
	[DocumentNo] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FSFSubSubsidiaries]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FSFSubSubsidiaries](
	[ControlCode] [char](1) NULL,
	[GeneralCode] [char](1) NULL,
	[SubsidiaryCode] [char](2) NOT NULL,
	[SubSubsidiaryCode] [varchar](2) NOT NULL,
	[SubSubsidiaryDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[ReportTitle] [varchar](100) NULL,
	[GUID] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FSFSubsidiaries]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FSFSubsidiaries](
	[ControlCode] [char](1) NULL,
	[GeneralCode] [char](1) NOT NULL,
	[SubsidiaryCode] [varchar](2) NOT NULL,
	[SubsidiaryDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[ReportTitle] [varchar](100) NULL,
	[GUID] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FSFGenerals]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FSFGenerals](
	[ControlCode] [char](1) NOT NULL,
	[GeneralCode] [varchar](20) NOT NULL,
	[GeneralDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[ReportTitle] [varchar](100) NULL,
	[GUID] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FSFControls]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FSFControls](
	[ControlCode] [varchar](20) NOT NULL,
	[ControlDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[ReportTitle] [varchar](100) NULL,
	[GUID] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Divisions]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Divisions](
	[DivisionCode] [char](3) NOT NULL,
	[Division] [varchar](100) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_Divisions] PRIMARY KEY CLUSTERED 
(
	[DivisionCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DestinationPoints]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DestinationPoints](
	[DestinationPointCode] [char](3) NOT NULL,
	[DestinationPointName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[PointNo] [numeric](18, 0) NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_DestinationPoints] PRIMARY KEY CLUSTERED 
(
	[DestinationPointCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COAControls]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COAControls](
	[ControlCode] [char](2) NOT NULL,
	[ControlDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[FSFGLCode] [char](10) NULL,
 CONSTRAINT [COAControls_PK] PRIMARY KEY NONCLUSTERED 
(
	[ControlCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[CityCode] [char](3) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_MSL_CityTAB] PRIMARY KEY CLUSTERED 
(
	[CityCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_City] UNIQUE NONCLUSTERED 
(
	[City] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SelectChartOfAccounts]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  Table [dbo].[Branches]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branches](
	[BranchCode] [char](2) NOT NULL,
	[BranchDescription] [varchar](100) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GLCode] [char](14) NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[BackupDatabase]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[BackupDatabase]
@FileName varchar(200) ='C:\BIS aa.bak',
@temp_dump varchar(255)='',
@database varchar(255)=''
as
set @temp_dump='C:\'
set @database='BIS'
backup database BIS to disk= @FileName
with
init
--END HARD DISK BACKUP--
GO
/****** Object:  UserDefinedFunction [dbo].[DateToKey]    Script Date: 12/01/2017 23:44:32 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION  [dbo].[DateToKey] ( @DateValue as datetime )  
RETURNS varchar(4)  
AS  
BEGIN 
	DECLARE @ReturnValue as varchar( 4 )
	SET @ReturnValue = Right( Year(@DateValue) , 2 ) + REPLICATE( '0' , 2 - LEN( Month(@DateValue) ) ) + CONVERT( Varchar(10), Month(@DateValue) )
	RETURN @ReturnValue
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCountries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCountries]
@CountryCode char(3) = ''  ,
@ItemGroupCode char(4),
@Country varchar(10),
@ItemGroup varchar(10),
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Country(CountryCode, Country) 
		VALUES  ( @CountryCode, @Country ) 
	     END
	ELSE 
	     BEGIN
		UPDATE Country
		SET CountryCode=@CountryCode,
		Country = @Country
		WHERE  ( CountryCode = @CountryCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[DeleteHistoryTransactionAudit]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteHistoryTransactionAudit]
@UserID		varchar(50) = '',
@ComputerID		varchar(50) = '',
@ProcessDateTime	datetime = null,
@Error			varchar(50) = '',
@DocumentDate		datetime = null,
@StationCode		Bigint = 0, 
@DocumentNature		varchar(50) = '',
@DocumentNo		varchar(50) = '',
@PartyCode		Bigint = 0, 
@PONature		varchar(50) = '',
@PONumber		varchar(50) = '',
@ItemCode		Bigint = 0, 
@Quantity		decimal(20,5)=0,
@AvailableQuantity	decimal(20,5)=0,
@BalanceQuantity	decimal(20,5)=0,
@POAvailableQuantity	decimal(20,5)=0,
@POBalanceQuantity	decimal(20,5)=0,
@GUID bigint = 0
AS
GO
/****** Object:  Table [dbo].[HistoryTransactionAudit]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoryTransactionAudit](
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](50) NULL,
	[ComputerID] [varchar](50) NULL,
	[ProcessDateTime] [datetime] NOT NULL,
	[Error] [varchar](50) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[DocumentNature] [varchar](50) NOT NULL,
	[TransactionNo] [varchar](50) NOT NULL,
	[PartyCode] [bigint] NOT NULL,
	[ItemCode] [bigint] NOT NULL,
	[Quantity] [decimal](20, 5) NOT NULL,
	[AvailableQuantity] [decimal](20, 5) NOT NULL,
	[BalanceQuantity] [decimal](20, 5) NOT NULL,
 CONSTRAINT [PK_MM_HistoryTransactionAuditTAB] PRIMARY KEY CLUSTERED 
(
	[RecordNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GL_MasterPaymentVoucherTAB]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GL_MasterPaymentVoucherTAB](
	[BranchCode] [bigint] NOT NULL,
	[DocumentNo] [varchar](10) NOT NULL,
	[DocumentNature] [bigint] NOT NULL,
	[DocumentDate] [datetime] NOT NULL,
	[TransactionTypeCode] [bigint] NULL,
	[SupplierCode] [bigint] NOT NULL,
	[MiscPartyName] [varchar](100) NOT NULL,
	[CreditAccountCode] [bigint] NOT NULL,
	[CreditAccountReference] [varchar](50) NOT NULL,
	[Narration] [varchar](200) NOT NULL,
	[PaymentBankCode] [bigint] NOT NULL,
	[ChequeNo] [varchar](50) NULL,
	[ChequeDate] [datetime] NULL,
	[TaxChallanNo] [varchar](50) NULL,
	[DepositDate] [datetime] NULL,
	[Locked] [bit] NOT NULL,
	[Posted] [bit] NOT NULL,
	[RecordNo] [bigint] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[OldRef] [varchar](50) NULL,
	[RecordCreator] [varchar](50) NOT NULL,
	[RecordOwner] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentVouchers]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentVouchers](
	[BranchCode] [char](19) NOT NULL,
	[VoucherNo] [varchar](10) NOT NULL,
	[VoucherNature] [char](19) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[TransactionTypeCode] [char](19) NULL,
	[SupplierCode] [char](19) NOT NULL,
	[MiscPartyName] [varchar](100) NOT NULL,
	[CreditAccountCode] [char](19) NOT NULL,
	[CreditAccountReference] [varchar](50) NOT NULL,
	[Narration] [varchar](200) NOT NULL,
	[PaymentBankCode] [bigint] NOT NULL,
	[ChequeNo] [varchar](50) NULL,
	[ChequeDate] [datetime] NULL,
	[TaxChallanNo] [varchar](50) NULL,
	[DepositDate] [datetime] NULL,
	[Locked] [bit] NOT NULL,
	[Posted] [bit] NOT NULL,
	[RecordNo] [bigint] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[OldRef] [varchar](50) NULL,
	[RecordCreator] [varchar](50) NOT NULL,
	[RecordOwner] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentVoucherDetails]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentVoucherDetails](
	[BranchCode] [char](19) NOT NULL,
	[VoucherNo] [varchar](10) NOT NULL,
	[VoucherNature] [char](19) NOT NULL,
	[APVNo] [varchar](10) NOT NULL,
	[APVNatureCode] [bigint] NOT NULL,
	[RecordNo] [int] NOT NULL,
	[SupplierBillNo] [varchar](50) NOT NULL,
	[APVAmount] [numeric](20, 5) NOT NULL,
	[PaymentTypeCode] [bigint] NOT NULL,
	[TaxRate] [numeric](20, 5) NOT NULL,
	[TaxValue] [numeric](20, 5) NOT NULL,
	[GLCode] [bigint] NULL,
	[DivisionCode] [bigint] NULL,
	[OldRef] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PayableAccounts]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PayableAccounts](
	[BranchCode] [bigint] NOT NULL,
	[DocumentNature] [bigint] NOT NULL,
	[DocumentNo] [varchar](10) NOT NULL,
	[DocumentDate] [datetime] NOT NULL,
	[PartyCode] [bigint] NOT NULL,
	[MiscPartyName] [varchar](100) NOT NULL,
	[PartyReference] [varchar](50) NOT NULL,
	[PartyReferenceDate] [datetime] NULL,
	[InternalReference] [varchar](50) NOT NULL,
	[InternalReferenceDate] [datetime] NULL,
	[Description] [varchar](250) NOT NULL,
	[CreditDays] [int] NOT NULL,
	[Locked] [bit] NOT NULL,
	[Posted] [bit] NOT NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[GUID] [bigint] NOT NULL,
	[OldRef] [varchar](50) NULL,
 CONSTRAINT [PK_MM_MasterAccountPayableTAB] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[DocumentNature] ASC,
	[DocumentNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdatePacking]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdatePacking]
@PackingCode char(3) = ''  ,
@Packing varchar(100),
@ReportTitle varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Packing(PackingCode, Packing,DefinitionDate,ReportTitle,GUID) 
		VALUES  ( @PackingCode, @Packing ,@DefinitionDate,@ReportTitle,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Packing
		SET PackingCode=@PackingCode,
		DefinitionDate=@DefinitionDate,
		Packing = @Packing,
		ReportTitle = @ReportTitle
		WHERE  ( PackingCode = @PackingCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrdersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateOrdersDetails]
 @OrderNature nchar(2) = ''  ,
 @OrderNumber varchar(16)=' '  ,
 @ItemCode  varchar(50)=' '  ,
 @Item  varchar(50)=' '  ,
@Quantity decimal=0.00,
@Price decimal=0.00,
@Amount varchar(100)='',
-- @Particuler  varchar(100) = '',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
	--	DELETE FROM OrderDetails WHERE  ( OrderNature = @OrderNature AND DocumentNo=@DocumentNo ) 

		INSERT INTO OrderDetails ( OrderNature ,OrderNumber, ItemCode,Quantity,Price ) 
		                                         VALUES  ( @OrderNature ,@OrderNumber  ,@ItemCode,@Quantity ,@Price ) 
	     END
	ELSE 
	     BEGIN
		UPDATE OrderDetails
		Set  
			ItemCode=@ItemCode,
			Quantity=@Quantity,
			Price=@Price
--			Amount=@Particuler
		WHERE  ( OrderNature = @OrderNature AND OrderNumber=@OrderNumber ) 
 	     END
GO
/****** Object:  Table [dbo].[Options]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Options](
	[OptionID] [bigint] IDENTITY(1,1) NOT NULL,
	[OptionName] [varchar](100) NULL,
	[OptionValue] [varchar](50) NULL,
	[OptionDescription] [varchar](200) NULL,
 CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED 
(
	[OptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OpeningBalances]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OpeningBalances](
	[ClosingDate] [datetime] NOT NULL,
	[BranchCode] [char](2) NOT NULL,
	[DivisionCode] [char](3) NOT NULL,
	[GLCode] [char](14) NOT NULL,
	[DebitBalance] [numeric](20, 5) NOT NULL,
	[CreditBalance] [numeric](20, 5) NOT NULL,
	[GUID] [bigint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateDetailHistoryTransactionAudit]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDetailHistoryTransactionAudit]
@UserID		varchar(50) = '',
@ComputerID		varchar(50) = '',
@ProcessDateTime	datetime = null,
@Error			varchar(50) = '',
@TransactionDate	datetime = null,
@StationCode		bigint = 0, 
@TransactionNature	varchar(50) = '',
@TransactionNo		varchar(50) = '',
@PartyCode		Bigint = 0, 
@PONature		varchar(50) = '',
@PONumber		varchar(50) = '',
@ItemCode		Bigint = 0, 
@Quantity		decimal(20,5)=0,
@AvailableQuantity	decimal(20,5)=0,
@BalanceQuantity	decimal(20,5)=0,
@POAvailableQuantity	decimal(20,5)=0,
@POBalanceQuantity	decimal(20,5)=0,
@GUID 	                bigint = 0,
@NewRecord	bit = 0
 
AS
	IF @NewRecord = 1 
		BEGIN
			INSERT INTO dbo.MM_HistoryTransactionAuditTAB (UserID, ComputerID, ProcessDateTime, Error, TransactionDate, StationCode, TransactionNature, TransactionNo, PartyCode, PONature, PONumber,ItemCode, Quantity, AvailableQuantity, BalanceQuantity, POAvailableQuantity, POBalanceQuantity) 
			VALUES  ( @UserID, @ComputerID, @ProcessDateTime, @Error, @TransactionDate, @StationCode, @TransactionNature, @TransactionNo, @PartyCode, @PONature, @PONumber,@ItemCode, @Quantity, @AvailableQuantity, @BalanceQuantity, @POAvailableQuantity, @POBalanceQuantity) 
		END
GO
/****** Object:  UserDefinedFunction [dbo].[KeyValue]    Script Date: 12/01/2017 23:44:32 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION  [dbo].[KeyValue]( @DateValue as varchar(4) , @TransNo as varchar(10)  )  
RETURNS  varchar(10)  AS  
BEGIN 
	DECLARE @ReferenceNo as bigint
	DECLARE @TransactionNo as varchar(10)
		
	SET @ReferenceNo = SUBSTRING ( ISNULL ( @TransNo , '000000' ) , 5 , 6 ) + 1
	SET @TransactionNo = @DateValue + REPLICATE ( '0', 6 - LEN(@ReferenceNo)) + CONVERT(VARCHAR(10),@ReferenceNo)
	SET @TransactionNo = CONVERT (VARCHAR(10),@TransactionNo )
	RETURN @TransactionNo 
END
GO
/****** Object:  Table [dbo].[Items]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemCode] [char](5) NOT NULL,
	[Item] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[ItemValue] [decimal](20, 5) NOT NULL,
	[GLCode] [varchar](12) NULL,
	[GUID] [bigint] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateItemCategory]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[InsertUpdateItemCategory]

	@NewRecord bit=0,
	@ItemCategoryCode nvarchar(1),
	@ItemCategory nvarchar(50)


AS
	IF @NewRecord=1 
		BEGIN
		INSERT INTO ItemCategory (ItemCategoryCode,ItemCategory) 
			values(@itemCategoryCode,@ItemCategory)
		END
	ELSE
		BEGIN	
		UPDATE ItemCategory SET 
			ItemCategoryCode = @ItemCategoryCode, 
			ItemCategory = @ItemCategory 
			WHERE (ItemCategoryCode = @ItemCategoryCode) AND (ItemCategory = @ItemCategory)
		END
GO
/****** Object:  StoredProcedure [dbo].[InsertItemCategory]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertItemCategory]
(
	@ItemCategoryCode nvarchar(1),
	@ItemCategory nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO ItemCategory(ItemCategoryCode, ItemCategory) VALUES (@ItemCategoryCode, @ItemCategory);
	SELECT ItemCategoryCode, ItemCategory FROM ItemCategory WHERE (ItemCategoryCode = @ItemCategoryCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrdersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteOrdersDetails]

@Option as  varchar(3)='',
@OrderNumber as integer =0,
@OrderNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM OrderDetails 
ELSE
	DELETE FROM OrderDetails WHERE OrderNumber=@OrderNumber AND OrderNature=@OrderNature
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteTransactionsDetails]

@Option as  varchar(3)='',
@TransactionNo as integer =0,
@BranchCode as varchar(10)=' ',
@TransactionNature as  varchar(3)=''
AS

	DELETE FROM TransactionDetails WHERE TransactionNo=@TransactionNo AND TransactionNature=@TransactionNature  and BranchCode=@BranchCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteSuppliersDetails]

@Option as  varchar(3)='',
@SupplierCode as varchar(10) ='',
@ItemCode as varchar(7)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM TransactionDetails 
ELSE
	DELETE FROM ItemSuppliers WHERE SupplierCode=@SupplierCode
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductCode] [char](3) NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[Rate] [decimal](20, 5) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductRates]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductRates](
	[ProductCode] [char](3) NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[StationPointCode] [char](3) NOT NULL,
	[DestinationPointCode] [char](3) NOT NULL,
	[TripAdvanceAmount] [decimal](20, 5) NULL,
	[Rate] [decimal](20, 5) NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_ProductRate] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC,
	[EffectiveDate] ASC,
	[StationPointCode] ASC,
	[DestinationPointCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[DeleteStationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteStationPoints]
@StationPointCode nchar(5)=''
AS
	IF @StationPointCode <> ''
		DELETE FROM StationPoints 
		WHERE ( StationPointCode= @StationPointCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteRegions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteRegions]
@RegionCode nchar(5)=''
AS
	IF @RegionCode <> ''
		DELETE FROM Regions 
		WHERE ( RegionCode= @RegionCode)
GO
/****** Object:  View [dbo].[CreditDebitNotEqual]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CreditDebitNotEqual]
AS
SELECT     BranchCode, VoucherNature, VoucherNo, SUM(Debit) AS Debit, SUM(Credit) AS Credit
FROM         dbo.VoucherDetails
GROUP BY BranchCode, VoucherNature, VoucherNo
HAVING      (SUM(Debit) - SUM(Credit) <> 0)
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserSecurities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteUserSecurities]
(
	@UserID char(100)
	
)
AS
	
	DELETE FROM UserSecurities
	WHERE (UserID = @UserID)
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOAControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCOAControls]
@ControlCode nchar(5)=''
AS
	IF @ControlCode <> ''
		DELETE FROM COAControls
		WHERE ( ControlCode= @ControlCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteCities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCities]
@CityCode nchar(5)=''
AS
	IF @CityCode <> ''
		DELETE FROM Cities 
		WHERE ( CityCode= @CityCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranches]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteBranches]
@BranchCode nchar(5)=''
AS
	IF @BranchCode <> ''
		DELETE FROM Branches 
		WHERE ( BranchCode= @BranchCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteProducts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProducts]
@ProductCode nchar(5)=''
AS
	IF @ProductCode <> ''
		DELETE FROM Products 
		WHERE ( ProductCode= @ProductCode)
GO
/****** Object:  View [dbo].[GL_GetFSFCombineVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GL_GetFSFCombineVW]
AS
SELECT     ControlCode + GeneralCode AS GLCode, GeneralDescription AS GLDescription
FROM         dbo.FSFGenerals
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, dbo.FSFSubsidiaries.SubsidiaryDescription AS GlDescription

FROM         dbo.FSFSubsidiaries LEFT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GlDescription

FROM         dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode
GO
/****** Object:  View [dbo].[GL_GetFSFCombineTransactionVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
--drop  view GL_GetFSFCombineTransactionVW
create view [dbo].[GL_GetFSFCombineTransactionVW]
as
SELECT     dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GLCode, dbo.FSFGenerals.GeneralDescription AS GLDescription
FROM         dbo.FSFGenerals LEFT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode
WHERE     (dbo.FSFSubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS GLDescription 
FROM         dbo.FSFSubsidiaries LEFT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode AND 
                      dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode
WHERE     dbo.FSFSubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLDescription 
FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode
GO
/****** Object:  View [dbo].[GL_GetFSFCombineLedTBRptVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
create view  [dbo].[GL_GetFSFCombineLedTBRptVW]
as
SELECT     dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GLCode, dbo.FSFGenerals.GeneralDescription AS GLRptTitle, dbo.FSFControls.ControlCode, 
                      dbo.FSFControls.ControlDescription AS ControlRptTitle, dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, 
                      dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, '' AS SubSidiaryCode, '' AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle

FROM         dbo.FSFGenerals LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode LEFT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode
WHERE     (dbo.FSFSubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS GLRptTitle, dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription AS ControlRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle

FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
                      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode AND dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode ON 
                      dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
WHERE     dbo.FSFSubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLRptTitle, dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription AS ControlRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode AS SubsubCode,
                       dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLSubSubRptTitle

FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteGeneratedReferences]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteGeneratedReferences]

@GenFrom varchar(10) = '' ,
@FormName varchar(50) = '' ,
@TransactionNature char(3) = '' ,
@TransactionNo varchar (10) = '',
@BranchCode char(3)  = '' ,
@DocumentNature char(10) = '' ,
@DocumentNo varchar (10) = '' 

AS 
	IF  EXISTS ( SELECT * FROM  GeneratedReferences  WHERE  GenFrom = @GenFrom AND
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   BranchCode = @BranchCode and
			   TransactionNo = @TransactionNo AND 
			   DocumentNature = @DocumentNature )
		
	     BEGIN
		--print 'Exist'
		Delete   from  GeneratedReferences
		WHERE  GenFrom = @GenFrom AND  
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   TransactionNo = @TransactionNo AND 
			   BranchCode = @BranchCode and
			   DocumentNature = @DocumentNature
 	     END
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFSubSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteFSFSubSubsidiaries]
@ControlCode nchar(5)='',
@GeneralCode nchar(10)='',
@SubsidiaryCode1 nchar(10)='',
@SubSubsidiaryCode nchar(10)=''
AS


Set @ControlCode =LEFT(@SubsidiaryCode1,1)    --  1
Set @GeneralCode =SUBSTRING(@SubsidiaryCode1, 2 ,1)  -- 001
Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 3,5)


	IF @ControlCode <> '' and @GeneralCode<>'' and @SubsidiaryCode1<>'' and @SubSubsidiaryCode <>''
		DELETE FROM FSFSubSubsidiaries
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode) and  (SubsidiaryCode=@SubsidiaryCode1) and (SubSubsidiaryCode=@SubSubsidiaryCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteFSFSubsidiaries]
@ControlCode char(5)='',
@GeneralCode char(10)='',
@SubsidiaryCode1 char(10)='',
@SubsidiaryCode char(10)='',
@SubSubsidiaryCode char(10)=''
AS


Set @ControlCode =LEFT(@GeneralCode, 1)    --  1
Set @GeneralCode =SUBSTRING(@GeneralCode, 2 ,1)  -- 001
--Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 5,8)


	IF @ControlCode <> '' and @GeneralCode<>'' and @SubsidiaryCode<>'' 
		DELETE FROM FSFSubsidiaries
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode) and  (SubsidiaryCode=@SubsidiaryCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteFSFGenerals]
@ControlCode nchar(5)='',
@GeneralCode nchar(5)=''
AS
	IF @ControlCode <> '' and @GeneralCode<>''
		DELETE FROM FSFGenerals
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteFSFControls]
@ControlCode nchar(5)=''
AS
	IF @ControlCode <> ''
		DELETE FROM FSFControls
		WHERE ( ControlCode= @ControlCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteDivisions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteDivisions]
@DivisionCode nchar(5)=''
AS
	IF @DivisionCode <> ''
		DELETE FROM Divisions 
		WHERE ( DivisionCode= @DivisionCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteDestinationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteDestinationPoints]
@DestinationPointCode nchar(5)=''
AS
	IF @DestinationPointCode <> ''
		DELETE FROM DestinationPoints 
		WHERE ( DestinationPointCode= @DestinationPointCode)
GO
/****** Object:  Table [dbo].[COAGenerals]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COAGenerals](
	[ControlCode] [char](2) NOT NULL,
	[GeneralCode] [char](2) NOT NULL,
	[GeneralDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[FSFGLCode] [char](10) NULL,
 CONSTRAINT [COAGenerals_PK] PRIMARY KEY NONCLUSTERED 
(
	[GeneralCode] ASC,
	[ControlCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerCode] [char](5) NOT NULL,
	[CustomerName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[Address] [varchar](100) NULL,
	[CityCode] [char](3) NOT NULL,
	[GLCode] [char](14) NULL,
	[ShortageGLCode] [char](14) NULL,
	[WHTaxGLCode] [char](14) NULL,
	[PostalCode] [varchar](10) NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Mobile] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[eMail] [varchar](50) NULL,
	[SalesTaxNumber] [varchar](20) NULL,
	[NationalTaxNumber] [varchar](20) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[DeleteVouchersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVouchersDetails]

@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@BranchCode as varchar(10) ='',
@TransactionNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM VocherDetails 
ELSE
	DELETE FROM VoucherDetails  
	WHERE 
	VoucherNature=@TransactionNature AND VoucherNo=@TransactionNo and BranchCode= @BranchCode
GO
/****** Object:  StoredProcedure [dbo].[UpdateStationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateStationPoints]
@StationPointCode char(3) = ''  ,
@StationPointName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@PointNo as numeric=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO StationPoints(StationPointCode,StationPointName,UrduTitle ,DefinitionDate,  PointNo) 
		VALUES  ( @StationPointCode, @StationPointName,@UrduTitle ,@DefinitionDate,  @PointNo) 
	     END
	ELSE 
	     BEGIN
		UPDATE StationPoints
		SET StationPointCode=@StationPointCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		 PointNo= @PointNo,
		StationPointName = @StationPointName
		WHERE  ( StationPointCode = @StationPointCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRegions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateRegions]
@RegionCode char(3) = ''  ,
@RegionName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Regions(RegionCode,RegionName,UrduTitle ,DefinitionDate) 
		VALUES  ( @RegionCode, @RegionName,@UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Regions
		SET RegionCode=@RegionCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		RegionName = @RegionName
		WHERE  ( RegionCode = @RegionCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProducts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProducts]
@ProductCode char(3) = ''  ,
@ProductName varchar(100),
@UrduTitle nVarchar(200),
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Products(ProductCode, ProductName,UrduTitle ,DefinitionDate) 
		VALUES  ( @ProductCode, @ProductName, @UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Products
		SET ProductCode=@ProductCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		ProductName = @ProductName
		WHERE  ( ProductCode = @ProductCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateGeneratedReferences]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateGeneratedReferences]

@GenFrom varchar(10) = '' ,
@FormName varchar(50) = '' ,
@TransactionNature char(3) = '' ,
@TransactionNo varchar (10) = '',
@BranchCode char(3)  = '' ,
@DocumentNature char(10) = '' ,
@DocumentNo varchar (10) = '' 

AS 
	IF  EXISTS ( SELECT * FROM  GeneratedReferences  WHERE  GenFrom = @GenFrom AND
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   BranchCode = @BranchCode and
			   TransactionNo = @TransactionNo AND 
			   DocumentNature = @DocumentNature )
		
	     BEGIN
		--print 'Exist'
		UPDATE    GeneratedReferences
		SET    FromBranchCode = @BranchCode ,BranchCode = @BranchCode , DocumentNature = @DocumentNature , DocumentNo = @DocumentNo 

		WHERE  GenFrom = @GenFrom AND  
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   TransactionNo = @TransactionNo AND 
			   BranchCode = @BranchCode and
			   DocumentNature = @DocumentNature
 	     END
	ELSE 

	     BEGIN
		--print 'Not Exist'		
		INSERT INTO GeneratedReferences
                      		(FromBranchCode,GenFrom, FormName,  TransactionNature, TransactionNo, BranchCode, DocumentNature, DocumentNo)
		VALUES     (@BranchCode, @GenFrom, @FormName, @TransactionNature, @TransactionNo, @BranchCode, @DocumentNature, @DocumentNo)
	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFSubSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateFSFSubSubsidiaries]
@ControlCode char(2) = ''  ,
@GeneralCode char(3) = '' ,
@SubsidiaryCode1   char(9) = ''  ,
@ControlDescription varchar(100),
@GeneralDescription varchar(100),
@SubsidiaryDescription varchar(100),
@SubSubsidiaryCode char(10) = ''  ,
@SubSubsidiaryDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 
                            ------- example @Subsidiarycode1 = 01 01 0001         =9 degit
Set @ControlCode =LEFT(@SubsidiaryCode1,1)    --  1
Set @GeneralCode =SUBSTRING(@SubsidiaryCode1, 2 ,1)  -- 001
Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 3,5)   --- 1 001 00001
--print @SubsidiaryCode1
--print @GeneralCode
--print @ControlCode



	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFSubSubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubSubsidiaryCode,SubSubsidiaryDescription,DefinitionDate,GUID) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode1, @SubSubsidiaryCode, @SubSubsidiaryDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFSubSubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		SubSubsidiaryDescription = @SubSubsidiaryDescription
		WHERE  (SubSubsidiaryCode=@SubSubsidiaryCode AND SubsidiaryCode=@SubsidiaryCode1 AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateFSFSubsidiaries]
@ControlCode char(10) = ''  ,
@GeneralCode char(10) = ''  ,
@GeneralDescription varchar(200),
@SubsidiaryCode char(10) = ''  ,
@ControlDescription varchar(100),
@SubsidiaryDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 

Set @ControlCode =LEFT(@GeneralCode,1) 
Set @GeneralCode =substring(@GeneralCode,2, 1 ) 


	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFSubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubsidiaryDescription,DefinitionDate,GUID) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode,@SubsidiaryDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFSubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		SubsidiaryDescription = @SubsidiaryDescription
		WHERE  (SubsidiaryCode=@SubsidiaryCode AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateFSFGenerals]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@GeneralCode char(4) = ''  ,
@GeneralDescription as  varchar(100)='',
@DefinitionDate DateTime='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
--set @ControlCode =left(@GeneralCode,1) 
--set @GeneralCode =right(@GeneralCode,3) 
--Select  @GeneralCode as gen
--select @ControlCode as con
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFGenerals(ControlCode,GeneralCode, GeneralDescription,DefinitionDate,GUID) 
				VALUES  ( @ControlCode,@GeneralCode, @GeneralDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFGenerals
		SET 
		DefinitionDate=@DefinitionDate,
		GeneralDescription = @GeneralDescription
		WHERE  (GeneralCode= @GeneralCode and ControlCode=@ControlCode )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateFSFControls]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFControls(ControlCode, ControlDescription,DefinitionDate,GUID) 
		VALUES  ( @ControlCode, @ControlDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFControls
		SET ControlCode=@ControlCode,
		DefinitionDate=@DefinitionDate,
		ControlDescription = @ControlDescription
		WHERE  (ControlCode = @ControlCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDivisions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDivisions]
@DivisionCode char(3) = ''  ,
@Division varchar(100),
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Divisions(DivisionCode, Division,DefinitionDate) 
		VALUES  ( @DivisionCode, @Division ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Divisions
		SET DivisionCode=@DivisionCode,
		DefinitionDate=@DefinitionDate,
		Division = @Division
		WHERE  ( DivisionCode = @DivisionCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDestinationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateDestinationPoints]
@DestinationPointCode char(3) = ''  ,
@DestinationPointName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@PointNo as numeric=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO DestinationPoints(DestinationPointCode,DestinationPointName,UrduTitle ,DefinitionDate,  PointNo) 
		VALUES  ( @DestinationPointCode, @DestinationPointName,@UrduTitle ,@DefinitionDate,  @PointNo) 
	     END
	ELSE 
	     BEGIN
		UPDATE DestinationPoints
		SET DestinationPointCode=@DestinationPointCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		PointNo= @PointNo,
		DestinationPointName = @DestinationPointName
		WHERE  ( DestinationPointCode = @DestinationPointCode  )
 	     END
GO
/****** Object:  Table [dbo].[VehicleOwners]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehicleOwners](
	[OwnerCode] [char](5) NOT NULL,
	[OwnerName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](500) NULL,
	[Address] [varchar](100) NULL,
	[CityCode] [char](3) NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Mobile] [varchar](50) NULL,
	[eMail] [varchar](50) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
 CONSTRAINT [PK_VehicleOwners] PRIMARY KEY CLUSTERED 
(
	[OwnerCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateVouchersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateVouchersDetails]

@TransactionNature char(2) = ''  ,
@BranchCode char(2) = ''  ,
@TransactionNo varchar(16)=' '  ,
@GLCode  varchar(50)=' '  ,
@GLDescription  varchar(50)=' '  ,
@Debit decimal(20,5)=0.00,
@Credit decimal(20,5)=0.00,
@DivisionCode char(5) = '' ,
@Division varchar(5) = '',
@Narration  varchar(100) = '',
@Reference  varchar(100) = '',
@NewRecord as bigint=0
 AS 
if @DivisionCode =''
begin
set @DivisionCode ='001'
end
	


	IF @NewRecord = 1 
	     BEGIN
	
		INSERT INTO VoucherDetails (BranchCode, VoucherNature ,VoucherNo, GLCode,  DivisionCode,Debit ,Credit ,Reference, Narration) 
		              VALUES  (@BranchCode, @TransactionNature ,@TransactionNo ,@GLCode ,@DivisionCode , @Debit,@Credit, @Reference, @Narration) 
	
	     END
/*
	ELSE 
	     BEGIN
		UPDATE VoucherDetails
		Set  
			GLCode=@GLCode,
			Debit=@Debit,
			Credit=@Credit,
			Particuler=@Particuler
		WHERE  ( VoucherNature = @VoucherNature AND DocumentNo=@DocumentNo ) 
 	     END*/
GO
/****** Object:  Table [dbo].[Vouchers]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vouchers](
	[BranchCode] [char](2) NOT NULL,
	[VoucherNature] [char](2) NOT NULL,
	[VoucherNo] [char](10) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[Description] [varchar](250) NULL,
	[Locked] [bit] NULL,
	[Posted] [bit] NULL,
	[IsAutoGenerated] [bit] NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[CreditDays] [bigint] NULL,
	[OldRef] [char](12) NULL,
	[UrduTitle] [nvarchar](2000) NULL,
	[GUID] [int] NOT NULL,
 CONSTRAINT [PK_Vouchers] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[VoucherNature] ASC,
	[VoucherNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserSecurities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateUserSecurities]
@UserID varchar(25) = ''  ,
@UserName varchar(100)='',
@Password as varchar(100)='',
@IsAdministrator as bit=0,
@IsActive bit=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO UserSecurities(UserID, UserName,Password,IsAdministrator,IsActive) 
		VALUES  ( @UserID, @UserName,@Password,@IsAdministrator,@IsActive ) 
	     END
	ELSE 
	     BEGIN
		UPDATE UserSecurities
		SET UserName=@UserName,
		IsActive = @IsActive,
Password=@Password,
	IsAdministrator=@IsAdministrator

		WHERE  ( UserID = @UserID  )
 	     END
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierCode] [char](5) NOT NULL,
	[SupplierName] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[Address] [varchar](100) NULL,
	[CityCode] [char](3) NOT NULL,
	[PostalCode] [varchar](10) NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Mobile] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[eMail] [varchar](50) NULL,
	[SalesTaxNumber] [varchar](20) NULL,
	[NationalTaxNumber] [varchar](20) NULL,
	[TaxCircle] [varchar](100) NULL,
	[TaxZone] [varchar](100) NULL,
	[DefinitionDate] [datetime] NULL,
	[GUID] [bigint] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionTypes]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransactionTypes](
	[TransactionTypeCode] [char](2) NOT NULL,
	[TransactionType] [varchar](100) NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[DefinitionDate] [datetime] NULL,
	[Nature] [char](2) NULL,
	[GLCode] [char](12) NULL,
 CONSTRAINT [PK_AdjustmentType] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOAControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCOAControls]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO COAControls(ControlCode, ControlDescription,DefinitionDate,GUID) 
		VALUES  ( @ControlCode, @ControlDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE COAControls
		SET ControlCode=@ControlCode,
		DefinitionDate=@DefinitionDate,
		ControlDescription = @ControlDescription
		WHERE  (ControlCode = @ControlCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCities]
@CityCode char(3) = ''  ,
@City varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Cities(CityCode, City, UrduTitle, DefinitionDate) 
		VALUES  ( @CityCode, @City,@UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Cities
		SET CityCode=@CityCode,
		UrduTitle=@UrduTitle,
		DefinitionDate=@DefinitionDate,
		City = @City
		WHERE  ( CityCode = @CityCode  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBranches]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateBranches]
@BranchCode char(3) = ''  ,
@BranchName varchar(100),
@DefinitionDate Datetime='',
@GLCode  char(14)='',
@GLDescription  char(14)='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Branches(BranchCode, BranchDescription,DefinitionDate, GLCode) 
		VALUES  ( @BranchCode, @BranchName ,@DefinitionDate, @GLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE Branches
		SET BranchCode=@BranchCode,
		DefinitionDate=@DefinitionDate,
		BranchDescription = @BranchName,
		GLCode=@GLCode
		WHERE  ( BranchCode = @BranchCode  )
 	     END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTransactionNatures]    Script Date: 12/01/2017 23:44:32 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTransactionNatures] ( @NatureCode varchar(2000),@System as Char(10)='' )
RETURNS @TransNatureList TABLE
   (
	Nature  varchar( 100 ) ,
	Term  varchar ( 50 ),
	NatureCode  varchar( 100 ) 
	
   )

AS
BEGIN
	DECLARE @Pattern  as varchar( 2004 )
	SET @Pattern = LTRIM ( RTRIM ( @NatureCode ) )
	
	IF LEFT ( @Pattern  , 1 ) <> ','
		SET @Pattern = ',' + @Pattern
	IF RIGHT (  @Pattern  , 1 ) <> ','
		SET @Pattern = @Pattern + ','
	
	INSERT @TransNatureList 
		SELECT     Nature, Term, NatureCode
			FROM         dbo.TransactionNatures
	                   WHERE @Pattern LIKE '%,' +  LTRIM ( RTRIM ( dbo.TransactionNatures.NatureCode ) )  + ',%' OR @Pattern = ',' AND [System]=@System
	
   RETURN
END
GO
/****** Object:  Table [dbo].[ProductValues]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductValues](
	[ProductCode] [char](3) NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[QuantityValue] [decimal](20, 5) NULL,
 CONSTRAINT [PK_ProductValues] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC,
	[EffectiveDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAControls]
@Option as  varchar(20)='',
@ControlCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.COAControls
        ORDER BY dbo.COAControls.ControlCode
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT ControlCode, ControlDescription, DefinitionDate
	FROM         dbo.COAControls
	ORDER BY ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 ControlCode+1 as ControlCode
		 FROM dbo.COAControls
	ORDER BY ControlCode desc
ELSE
	SELECT * FROM COAControls WHERE ControlCode=@ControlCode
    ORDER BY dbo.COAControls.ControlCode
GO
/****** Object:  StoredProcedure [dbo].[SelectCities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCities]
@Option as  varchar(20)='',
@CityCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Cities.CityCode, dbo.Cities.City,DefinitionDate,UrduTitle
		FROM        dbo.Cities 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Cities
	ORDER BY CityCode
ELSE
	SELECT * FROM Cities WHERE CityCode=@CityCode
GO
/****** Object:  StoredProcedure [dbo].[SelectStationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectStationPoints]
@Option as  varchar(20)='',
@StationPointCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName,DefinitionDate,UrduTitle, PointNo
		FROM        dbo.StationPoints 
        ORDER BY dbo.StationPoints.StationPointCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.StationPoints
	ORDER BY StationPointCode
ELSE
	SELECT * FROM StationPoints 
	WHERE StationPointCode=@StationPointCode
GO
/****** Object:  StoredProcedure [dbo].[SelectRegions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectRegions]
@Option as  varchar(20)='',
@RegionCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Regions.RegionCode, dbo.Regions.RegionName,DefinitionDate,UrduTitle
		FROM        dbo.Regions 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Regions
	ORDER BY RegionCode
ELSE
	SELECT * FROM Regions 
	WHERE RegionCode=@RegionCode
GO
/****** Object:  StoredProcedure [dbo].[SelectUserSecurities]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SelectUserSecurities] (  @UserName varchar(100) = ''  , @Password varchar(50) = ''  , @EmpCode varchar(10) = ''  , @IsLoggedIn bit = 0  , @IsAdministrator bit = 0  , @NormalShutDown bit = 0  , @IsActive bit = 0  , @S_Account varchar(3) = ''  , @T_Order varchar(3) = ''  , @R_RecVoucher bit = 0  , @Option as  varchar(20)='',@UserID as varchar(25) ='')
 AS 

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.UserSecurities
ELSE IF @Option='SRHGRID' 
	SELECT * FROM dbo.UserSecurities
	ORDER BY UserID
ELSE
	SELECT     UserID, UserName, IsLoggedIn, IsAdministrator,Password,IsActive
	FROM         dbo.UserSecurities WHERE UserID=@UserID
GO
/****** Object:  StoredProcedure [dbo].[SelectGeneratedReferences]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectGeneratedReferences]

@GenFrom varchar(3) = '' ,
@FormName varchar(100) = '' ,
@TransactionNature char(3) = 0 ,
@TransactionNo varchar (10) = '',
@BranchCode char(3)  = '' ,
@DocumentNature char(3) = '' ,
@DocumentNo varchar (10) = 0 ,
@ChequeNo as varchar(50) = '',
@BankCode as bigint = 0 ,
@OPTION Varchar(50)='' 
  
AS 


IF @OPTION='CHECK_IF_EXIST'
	BEGIN

	SELECT     dbo.GeneratedReferences.*, dbo.Branches.BranchCode AS BranchCode, dbo.Branches.BranchDescription AS BranchName
	FROM         dbo.GeneratedReferences LEFT OUTER JOIN
	                      dbo.Branches ON dbo.GeneratedReferences.BranchCode = dbo.Branches.BranchCode
	WHERE     (dbo.GeneratedReferences.GenFrom = @GenFrom) AND 
		  (dbo.GeneratedReferences.BranchCode = @BranchCode) AND 
		  (dbo.GeneratedReferences.FormName = @FormName) AND 
		  (dbo.GeneratedReferences.TransactionNature = @TransactionNature) AND 
	          (dbo.GeneratedReferences.TransactionNo = @TransactionNo) AND 
		  (dbo.GeneratedReferences.DocumentNature = @DocumentNature) OR @DocumentNature=''
	END
GO
/****** Object:  StoredProcedure [dbo].[SelectProducts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectProducts]
@Option as  varchar(20)='',
@ProductCode as varchar(10) =''


AS

IF	@Option='ALL' 
		SELECT     dbo.Products.ProductCode, dbo.Products.ProductName,DefinitionDate,UrduTitle
		FROM        dbo.Products 
        ORDER BY DBO.Products.ProductCode 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Products
	ORDER BY ProductCode
ELSE
	SELECT * FROM Products WHERE ProductCode=@ProductCode
    ORDER BY DBO.Products.ProductCode
GO
/****** Object:  StoredProcedure [dbo].[SelectDivisions]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDivisions]
@Option as  varchar(20)='',
@DivisionCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Divisions.DivisionCode, dbo.Divisions.Division,DefinitionDate
		FROM        dbo.Divisions 
        ORDER BY DBO.Divisions.DivisionCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Divisions
	ORDER BY DivisionCode
ELSE IF @Option='COMBO'
	SELECT     DivisionCode ,Division
		FROM         dbo.Divisions
	ORDER BY DivisionCode
ELSE
	SELECT * FROM Divisions WHERE DivisionCode=@DivisionCode
    ORDER BY DBO.Divisions.DivisionCode
GO
/****** Object:  StoredProcedure [dbo].[SelectDestinationPoints]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDestinationPoints]
@Option as  varchar(20)='',
@DestinationPointCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.DestinationPoints.DestinationPointCode, dbo.DestinationPoints.DestinationPointName,DefinitionDate,UrduTitle, PointNo
		FROM        dbo.DestinationPoints 
        ORDER BY  dbo.DestinationPoints.DestinationPointCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.DestinationPoints
	ORDER BY DestinationPointCode
ELSE
	SELECT * FROM DestinationPoints 
	WHERE DestinationPointCode=@DestinationPointCode
    ORDER BY dbo.DestinationPoints.DestinationPointCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFSubsidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(1) ='',
@GeneralCode  as varchar(10) ='',
@SubsidiaryCode as varchar(8) ='',
@FSFSubsidiary as varchar(5) =''

AS
IF 	@Option='ALL' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
	                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
	                      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode RIGHT OUTER JOIN
	                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		                      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode RIGHT OUTER JOIN
		                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode
         ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubsidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription, dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, 
                      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
FROM         dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
                      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubsidiaryCode +1 as SubsidiaryCode
		FROM dbo.FSFSubsidiaries
		ORDER BY dbo.FSFSubsidiaries.SubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT     TOP 100 PERCENT ControlCode + GeneralCode + SubsidiaryCode AS GLCode, SubsidiaryDescription AS GLDescription
		FROM         dbo.FSFSubsidiaries
		ORDER BY SubsidiaryCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		              dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		              dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		              dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
		              dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		              dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
		WHERE dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode =@GeneralCode  AND dbo.FSFSubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode

ELSE
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
		      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
		WHERE dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode =@GeneralCode  AND dbo.FSFSubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFGenerals]
@Option as  varchar(100)='',
@ControlCode as varchar(10) ='',
@GeneralCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
                	      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
		FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
        ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT dbo.FSFGenerals.ControlCode, dbo.FSFControls.ControlDescription, dbo.FSFGenerals.GeneralCode AS GeneralCode, 
                      dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate
	FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	ORDER BY dbo.FSFGenerals.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
	SELECT     TOP 100 PERCENT dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, 
                      dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.ControlCode, dbo.FSFControls.ControlDescription
	FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	ORDER BY dbo.FSFGenerals.GeneralCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 GeneralCode +1 as GeneralCode
		FROM dbo.FSFGenerals
	ORDER BY GeneralCode desc
ELSE IF @Option='PKVALIDATION'
 
	SELECT     dbo.FSFControls.ControlCode,dbo.FSFGenerals.GeneralCode as GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
		      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
	FROM         dbo.FSFControls RIGHT OUTER JOIN
	   	      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
	WHERE dbo.FSFGenerals.GeneralCode=@GeneralCode AND  dbo.FSFGenerals.ControlCode=@ControlCode
    ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode
ELSE
	SELECT     dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
                	      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
		FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
	 WHERE  dbo.FSFGenerals.GeneralCode=@GeneralCode AND  dbo.FSFGenerals.ControlCode=@ControlCode
     ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFControls]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFControls]
@Option as  varchar(20)='',
@ControlCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.FSFControls
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT ControlCode, ControlDescription, DefinitionDate
	FROM         dbo.FSFControls
    ORDER BY ControlCode

ELSE IF @Option='AUTO' 
		SELECT     Top 1 ControlCode+1 as ControlCode
		 FROM dbo.FSFControls
	ORDER BY ControlCode desc
ELSE
	SELECT * FROM FSFControls WHERE ControlCode=@ControlCode
    ORDER BY ControlCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFCombine]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectProductRates]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectProductRates]
@Option as  varchar(20)='',
@EffectiveDate as datetime='',
@StationPointCode as char(3)='',
@DestinationPointCode as char(3)='',
@ProductCode as char(5) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, 
                      dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
		FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
ELSE IF @Option='SRHGRID'
		SELECT     TOP 100 PERCENT dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, 
                      dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
		FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
		ORDER BY dbo.ProductRates.ProductCode , dbo.ProductRates.EffectiveDate desc
ELSE IF @Option='LASTVALUE'
		SELECT     TOP 1 Rate
	FROM         dbo.ProductRates
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
			dbo.ProductRates.StationPointCode=@StationPointCode and
			 dbo.ProductRates.DestinationPointCode=@DestinationPointCode
		ORDER BY dbo.ProductRates.EffectiveDate desc
		
ELSE
	SELECT     dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, 
                      dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
		dbo.ProductRates.EffectiveDate=@EffectiveDate and
		 dbo.ProductRates.StationPointCode=@StationPointCode and
		 dbo.ProductRates.DestinationPointCode=@DestinationPointCode
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleOwners]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleOwners]
@Option as  varchar(20)='',
@OwnerCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.VehicleOwners LEFT OUTER JOIN
                      dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode
        ORDER BY dbo.VehicleOwners.OwnerCode
 ELSE IF @Option='AUTO' 
		SELECT     Top 1 OwnerCode+1 as OwnerCode
		FROM         dbo.VehicleOwners
		order by OwnerCode desc
ELSE IF @Option='SRHGRID'
		SELECT     TOP 100 PERCENT *, dbo.Cities.City AS Expr1
		FROM         dbo.VehicleOwners LEFT OUTER JOIN
		                      dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode
		ORDER BY dbo.VehicleOwners.OwnerCode

ELSE
	SELECT     *
	FROM         dbo.VehicleOwners LEFT OUTER JOIN
        dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode 
	WHERE OwnerCode=@OwnerCode
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionDocumentReports]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectSuppliers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectSuppliers]
@Option as  varchar(20)='',
@SupplierCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.Suppliers LEFT OUTER JOIN
                      dbo.Cities ON dbo.Suppliers.CityCode = dbo.Cities.CityCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SupplierCode+1 as SupplierCode
		FROM         dbo.Suppliers
		order by SupplierCode desc
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Suppliers 
ELSE
	SELECT * FROM Suppliers WHERE SupplierCode=@SupplierCode
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionNatures]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionNatures]  ( @SelectedTransNatureCode as varchar(1000)='',@OPTION as Varchar(100)='',@System as Char(10)='',@TransactionNatureCode as char(10)='')
AS
	IF @OPTION='TRL'
		SELECT     *
		FROM         dbo.GetTransactionNatures(@SelectedTransNatureCode,@System) GetTransactionNatures
	ELSE IF @OPTION='ALL'
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]=@System
		ELSE IF @OPTION='SRHGRID'
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]='IN'
		ELSE 
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]=@System and 
		TransactionNatures.NatureCode =@TransactionNatureCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFSubSubSidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFSubSubSidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) =''



AS



IF 	@Option='ALL' 
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
        ORDER BY dbo.FSFSubSubsidiaries.ControlCode,dbo.FSFSubSubsidiaries.GeneralCode,dbo.FSFSubSubsidiaries.SubsidiaryCode,dbo.FSFSubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		                      dbo.FSFControls.ControlDescription
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFControls.ControlCode, 
                      dbo.FSFControls.ControlDescription, dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFSubsidiaries.SubsidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
        ORDER BY dbo.FSFSubSubsidiaries.ControlCode,dbo.FSFSubSubsidiaries.GeneralCode,dbo.FSFSubSubsidiaries.SubsidiaryCode,dbo.FSFSubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubSubsidiaryCode +1 as SubSubsidiaryCode
		FROM dbo.FSFSubSubsidiaries
		ORDER BY dbo.FSFSubSubsidiaries.SubSubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT GlCode,GlDescription FROM GL_GetFSFCombineTransactionVW
		Order By GLCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	 WHERE  dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode	

ELSE
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	 WHERE  dbo.FSFSubSubsidiaries.ControlCode=@ControlCode AND  dbo.FSFSubSubsidiaries.GeneralCode=@GeneralCode AND dbo.FSFSubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAGenerals]
@Option as  varchar(100)='',
@ControlCode as varchar(10) ='',
@GeneralCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
		ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode 
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT dbo.COAGenerals.ControlCode, dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralCode AS GeneralCode, 
                      dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate
	FROM         dbo.COAGenerals LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	ORDER BY dbo.COAGenerals.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
	SELECT     TOP 100 PERCENT dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, 
                      dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.ControlCode, dbo.COAControls.ControlDescription
	FROM         dbo.COAGenerals LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	ORDER BY dbo.COAGenerals.GeneralCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 GeneralCode +1 as GeneralCode
		FROM dbo.COAGenerals
	ORDER BY GeneralCode desc
ELSE IF @Option='PKVALIDATION'
 
	SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
                   	   dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	WHERE dbo.COAGenerals.GeneralCode=@GeneralCode AND  dbo.COAGenerals.ControlCode=@ControlCode
	ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode 
ELSE
	SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
                     	   dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	WHERE  dbo.COAGenerals.GeneralCode=@GeneralCode AND  dbo.COAGenerals.ControlCode=@ControlCode
    ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleOwners]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVehicleOwners]
@OwnerCode nchar(5)=''
AS
	IF @OwnerCode <> ''
		DELETE From VehicleOwners Where ( OwnerCode= @OwnerCode)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOAGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCOAGenerals]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@GeneralCode char(4) = ''  ,
@GeneralDescription as  varchar(100)='',
@DefinitionDate DateTime='',
@FSFGLCode char(14) = ''  ,
@FSFGLDescription char(14) = ''  ,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
--set @ControlCode =left(@GeneralCode,1) 
--set @GeneralCode =right(@GeneralCode,3) 
--Select  @GeneralCode as gen
--select @ControlCode as con
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO COAGenerals(ControlCode,GeneralCode, GeneralDescription,DefinitionDate,GUID,FSFGLCode) 
				VALUES  ( @ControlCode,@GeneralCode, @GeneralDescription ,@DefinitionDate,@GUID,@FSFGLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE COAGenerals
		SET 
		DefinitionDate=@DefinitionDate,
		GeneralDescription = @GeneralDescription,
		FSFGLCode=@FSFGLCode
		WHERE  (GeneralCode= @GeneralCode and ControlCode=@ControlCode )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[SelectProductValues]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectProductValues]
@Option as  varchar(20)='',
@EffectiveDate as datetime='',
@ProductCode as char(5) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		      dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
ELSE IF @Option='SRHGRID'
		SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
		ORDER BY dbo.ProductValues.ProductCode
ELSE IF @Option='LASTVALUE'
		SELECT    TOP 1 dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues 
		ORDER BY dbo.ProductValues.EffectiveDate Desc
ELSE
			SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		      dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
		WHERE dbo.ProductValues.ProductCode=@ProductCode and
		dbo.ProductValues.EffectiveDate=@EffectiveDate
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleOwners]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVehicleOwners] 

@OwnerCode varchar(5) = ''  ,
@OwnerName varchar(100)=' '  ,
@UrduTitle nVarchar(500)=' '  ,
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3),
@Email varchar(100)='',
@TelePhone varchar(100),
@DefinitionDate varchar(100)='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO VehicleOwners( OwnerCode ,OwnerName ,UrduTitle,Address, CityCode,TelePhone,DefinitionDate,GUID) 
		VALUES  ( @OwnerCode ,@OwnerName,@UrduTitle ,@Address, @CityCode,@TelePhone, @DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE VehicleOwners
		SET
		OwnerName=@OwnerName,
 		CityCode=@CityCode,
		UrduTitle=@UrduTitle,
	 	Email=@Email,
		Address=@Address,
		TelePhone=@TelePhone,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( OwnerCode = @OwnerCode )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTransactionTypes]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateTransactionTypes]
@TransactionTypeCode char(3) = ''  ,
@TransactionType varchar(100) = ''  ,
@NatureCode varchar(3)='',
@Nature varchar(3)='',
@UrduTitle nvarchar(100)='',
@DefinitionDate Datetime='',
@GLCode char(12)='',
@GLDescription char(1)='',
@NewRecord as bigint
 AS 



	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO TransactionTypes(TransactionTypeCode, Nature, TransactionType, UrduTitle , DefinitionDate,GLCode ) 
				VALUES  ( @TransactionTypeCode, @NatureCode, @TransactionType,@UrduTitle ,@DefinitionDate,@GLCode)
	     END
	ELSE 
	     BEGIN
		UPDATE TransactionTypes
		SET TransactionTypeCode=@TransactionTypeCode,
		TransactionType=@TransactionType ,
		UrduTitle =@UrduTitle ,
		GLCode=@GLCode,
		DefinitionDate=@DefinitionDate

		WHERE  ( TransactionTypeCode = @TransactionTypeCode  )	AND
			Nature=@NatureCode

 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProductValues]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProductValues]
@ProductCode char(3) = ''  ,
@ProductName char(3) = ''  ,
@EffectiveDate Datetime='',
@QuantityValue as decimal(20,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO ProductValues(ProductCode, EffectiveDate, QuantityValue ) 
				VALUES  ( @ProductCode, @EffectiveDate,@QuantityValue )
	     END
	ELSE 
	     BEGIN
		UPDATE ProductValues
		SET ProductCode=@ProductCode,
		EffectiveDate=@EffectiveDate,
		QuantityValue=@QuantityValue
		
		WHERE  ( ProductCode = @ProductCode  )	AND
			EffectiveDate=@EffectiveDate	



 	     END
GO
/****** Object:  Table [dbo].[Vehicles ]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicles ](
	[VehicleCode] [char](10) NOT NULL,
	[VehicleDescription] [varchar](100) NOT NULL,
	[UrduTitle] [nvarchar](200) NULL,
	[Capacity] [varchar](50) NULL,
	[OwnerCode] [char](5) NOT NULL,
	[CustomerCode] [char](5) NULL,
	[InstallmentGLCode] [char](12) NOT NULL,
	[FreightGLCode] [char](12) NOT NULL,
	[LoanGLCode] [char](12) NOT NULL,
	[CommissionGLCode] [char](12) NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[IsThirdParty] [bit] NULL,
	[GUID] [bigint] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateVouchers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateVouchers]
    @BranchCode CHAR(2) = '',
    @TransactionNature CHAR(2) = '',
    @BranchName CHAR(2) = '',
    @TransactionNo VARCHAR(15) = ' ',
    @UrduTitle NVARCHAR(500) = ' ',
    @TransactionDate DATETIME = ' ',
    @Description VARCHAR(200) = '',
    @Locked TINYINT = 0,
    @IsAutoGenerated TINYINT = 0,
    @Posted TINYINT = 0,
    @GUID AS INTEGER = 0,
    @NewRecord AS BIGINT = 0
AS 
    DECLARE @VoucherNo VARCHAR(10)
    DECLARE @DateValue VARCHAR(4)



    IF @NewRecord = 1 
        BEGIN
            SET @DateValue = dbo.DateToKey(@TransactionDate) 
            SELECT TOP 1
                    @VoucherNo = VoucherNo
            FROM    dbo.Vouchers
            WHERE   ( BranchCode = @BranchCode )
                    AND ( VoucherNature = @TransactionNature )
                    AND ( LEFT(VoucherNo, 4) = @DateValue )
            ORDER BY VoucherNo DESC
            SET @VoucherNo = dbo.KeyValue(@DateValue, @VoucherNo)
            SELECT  @VoucherNo AS TransactionNo

            INSERT  INTO Vouchers
                    (
                      BranchCode,
                      VoucherNature,
                      VoucherNo,
                      VoucherDate,
                      Description,
                      UrduTitle,
                      IsAutoGenerated,
                      GUID
                    )
            VALUES  (
                      @BranchCode,
                      @TransactionNature,
                      @VoucherNo,
                      @TransactionDate,
                      @Description,
                      @UrduTitle,
                      @IsAutoGenerated,
                      @GUID
                    ) 
        END
    ELSE 
        BEGIN
            SELECT  @TransactionNo AS TransactionNo
            UPDATE  Vouchers
            SET     VoucherNature = @TransactionNature,
                    VoucherNo = @TransactionNo,
                    UrduTitle = @UrduTitle,
                    VoucherDate = @TransactionDate,
                    [Description] = @Description
            WHERE   ( VoucherNature = @TransactionNature
                      AND VoucherNo = @TransactionNo
                      AND BranchCode = @BranchCode
                      --AND IsAutoGenerated = 0
                    )
		
        END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCustomers] 

@CustomerCode varchar(5) = ''  ,
@CustomerName varchar(100)=' '  ,
@UrduTitle nVarchar(200)='',
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3)='',
@GLCode char(14)='',
@GLDescription char(14),
@ShortageGLCode char(14)='',
@WHTaxGLCode char(14),
@WHTaxGLDescription char(14)='',
@ShortageGLDescription char(14)='',
@Fax varchar(50)='',
@Email varchar(100)='',
@TelePhone varchar(100),
@NationalTaxNumber varchar(100),
@SalesTaxNumber varchar(30),
@DefinitionDate varchar(100)='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Customers( CustomerCode ,CustomerName, UrduTitle ,Address, CityCode,TelePhone,Fax,NationalTaxNumber,SalesTaxNumber,PostalCode,DefinitionDate, ShortageGLCode,   GLCode,WHTaxGLCode, GUID) 
		VALUES  ( @CustomerCode ,@CustomerName,@UrduTitle ,@Address, @CityCode,@TelePhone,@Fax,@NationalTaxNumber,@SalesTaxNumber,@PostalCode,@DefinitionDate, @ShortageGLCode ,@GLCode,@WHTaxGLCode, @GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Customers
		SET
		CustomerName=@CustomerName,
 		CityCode=@CityCode,
		Fax=@Fax,
		ShortageGLCode=@ShortageGLCode,
		GLCode=@GLCode,
		UrduTitle=@UrduTitle,
		Email=@Email,
		WHTaxGLCode=@WHTaxGLCode,
		Address=@Address,
		TelePhone=@TelePhone,
		NationalTaxNumber=	@NationalTaxNumber,
		SalesTaxNumber=@SalesTaxNumber,
		PostalCode=@PostalCode,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( CustomerCode = @CustomerCode )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProductRates]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProductRates]
@ProductCode char(3) = ''  ,
@ProductName char(3) = ''  ,
@StationPointCode varchar(3)='',
@StationPointDescription varchar(3)='',
@DestinationPointDescription varchar(3)='',
@DestinationPointCode varchar(3)='',
@EffectiveDate Datetime='',
@Rate as decimal(20,5)=0.00,
@TripAdvanceAmount as Decimal(18,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO ProductRates(ProductCode, StationPointCode, DestinationPointCode, EffectiveDate, Rate, TripAdvanceAmount) 
				VALUES  ( @ProductCode, @StationPointCode,@DestinationPointCode ,@EffectiveDate,@Rate ,@TripAdvanceAmount )
	     END
	ELSE 
	     BEGIN
		UPDATE ProductRates
		SET ProductCode=@ProductCode,
		StationPointCode=@StationPointCode,
		DestinationPointCode=@DestinationPointCode,
		EffectiveDate=@EffectiveDate,
		Rate=@Rate,
		TripAdvanceAmount=@TripAdvanceAmount

		WHERE  ( ProductCode = @ProductCode  )	AND
			EffectiveDate=@EffectiveDate	AND 
			StationPointCode=@StationPointCode	AND 
			DestinationPointCode=@DestinationPointCode



 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSuppliers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateSuppliers] 

@SupplierCode varchar(5) = ''  ,
@SupplierName varchar(100)=' '  ,
@UrduTitle nVarchar(500)=' '  ,
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3),
@Fax varchar(50)='',
@Email varchar(100)='',
@TelePhone varchar(100),
@NationalTaxNumber varchar(100),
@SalesTaxNumber varchar(30),
@DefinitionDate varchar(100)='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Suppliers( SupplierCode ,SupplierName,UrduTitle  ,Address, CityCode,TelePhone,Fax,NationalTaxNumber,SalesTaxNumber,PostalCode,DefinitionDate,GUID) 
		VALUES  ( @SupplierCode ,@SupplierName,@UrduTitle ,@Address, @CityCode,@TelePhone,@Fax,@NationalTaxNumber,@SalesTaxNumber,@PostalCode,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Suppliers
		SET
		SupplierName=@SupplierName,
 		CityCode=@CityCode,
		UrduTitle=@UrduTitle,
		Fax=@Fax,
		Email=@Email,
		Address=@Address,
		TelePhone=@TelePhone,
		NationalTaxNumber=	@NationalTaxNumber,
		SalesTaxNumber=@SalesTaxNumber,
		PostalCode=@PostalCode,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( SupplierCode = @SupplierCode )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[DeleteVouchers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVouchers]
    @Option AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = ''
AS 
    BEGIN TRANSACTION
    DELETE  FROM VoucherDetails
    WHERE   VoucherNo = @TransactionNo
            AND VoucherNature = @TransactionNature
            AND BranchCode = @BranchCode


    UPDATE  Vouchers
    SET     Description = 'The Voucher Has been Deleted',
            UrduTitle= ''
            
    WHERE   VoucherNo = @TransactionNo
            AND VoucherNature = @TransactionNature
            AND BranchCode = @BranchCode
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION
GO
/****** Object:  Table [dbo].[CustomerBills]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerBills](
	[BillNo] [char](10) NOT NULL,
	[CustomerCode] [char](5) NULL,
	[BillDate] [datetime] NULL,
	[IsReceipt] [tinyint] NULL,
 CONSTRAINT [PK_BillsGeneration] PRIMARY KEY CLUSTERED 
(
	[BillNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COASubsidiaries]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COASubsidiaries](
	[ControlCode] [char](2) NOT NULL,
	[GeneralCode] [char](2) NOT NULL,
	[SubsidiaryCode] [char](4) NOT NULL,
	[SubsidiaryDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[FSFGLCode] [char](10) NULL,
 CONSTRAINT [COASubsidiary_PK] PRIMARY KEY NONCLUSTERED 
(
	[SubsidiaryCode] ASC,
	[ControlCode] ASC,
	[GeneralCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCustomers]
@CustomerCode nchar(5)=''
AS
	IF @CustomerCode <> ''
		DELETE From Customers Where ( CustomerCode= @CustomerCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductRates]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProductRates]

@ProductCode as char(5)='',
@FromRegionCode as char(3)='',
@ToRegionCode as  char(3)='',
@EffectiveDate as  Datetime=''
AS

	IF @ProductCode <> '' AND @EffectiveDate <>'' AND @FromRegionCode <>'' AND @ToRegionCode <>''
		DELETE FROM ProductRates 
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
			dbo.ProductRates.EffectiveDate=@EffectiveDate and
			 dbo.ProductRates.StationPointCode=@FromRegionCode and
			 dbo.ProductRates.DestinationPointCode=@ToRegionCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionTypes]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTransactionTypes]
@NatureCode nchar(5)='',
@TransactionTypeCode nchar(5)=''
AS
	IF @TransactionTypeCode <> '' 
		DELETE FROM dbo.TransactionTypes
		WHERE ( dbo.TransactionTypes.TransactionTypeCode= @TransactionTypeCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteSuppliers]
@SupplierCode char(10)=''
AS
	IF @SupplierCode <> ''
		DELETE From Suppliers Where ( SupplierCode= @SupplierCode)
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductValues]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProductValues]

@ProductCode as char(5)='',
@EffectiveDate as  Datetime=''
AS

	IF @ProductCode <> '' AND @EffectiveDate <>'' 
		DELETE FROM ProductValues 
		WHERE dbo.ProductValues.ProductCode=@ProductCode and
			dbo.ProductValues.EffectiveDate=@EffectiveDate
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoices](
	[BranchCode] [char](2) NOT NULL,
	[TransactionNo] [char](10) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[CustomerReference] [char](20) NULL,
	[Description] [varchar](250) NULL,
	[PartyCode] [char](5) NULL,
	[VehicleCode] [char](10) NOT NULL,
	[DueDate] [datetime] NULL,
	[StationPointCode] [char](3) NULL,
	[DestinationPointCode] [char](3) NULL,
	[ProductCode] [char](3) NULL,
	[TripAdvanceReference] [char](10) NULL,
	[TripAdvance] [decimal](20, 5) NULL,
	[Quantity] [decimal](20, 5) NULL,
	[Rate] [decimal](20, 5) NULL,
	[Commission] [decimal](20, 5) NULL,
	[CommissionRate] [int] NULL,
	[ShortageQuantity] [decimal](20, 5) NULL,
	[QuantityValue] [decimal](20, 5) NULL,
	[Shortage] [decimal](20, 5) NULL,
	[Amount] [decimal](20, 5) NULL,
	[Locked] [bit] NULL,
	[Posted] [bit] NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[GUID] [int] NOT NULL,
	[IsTripCanceled] [bit] NULL,
	[IsBilled] [tinyint] NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[TransactionNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'When Trip canceled then no transaction will occured' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'IsTripCanceled'
GO
/****** Object:  Table [dbo].[COASubSubsidiaries]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COASubSubsidiaries](
	[ControlCode] [char](2) NOT NULL,
	[GeneralCode] [char](2) NOT NULL,
	[SubsidiaryCode] [char](4) NOT NULL,
	[SubSubsidiaryCode] [char](4) NOT NULL,
	[SubSubsidiaryDescription] [varchar](100) NOT NULL,
	[DefinitionDate] [datetime] NOT NULL,
	[GUID] [bigint] NOT NULL,
	[FSFGLCode] [char](10) NULL,
 CONSTRAINT [PK_COASubSubsidiaries] PRIMARY KEY CLUSTERED 
(
	[ControlCode] ASC,
	[GeneralCode] ASC,
	[SubsidiaryCode] ASC,
	[SubSubsidiaryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehicleAdjustments]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehicleAdjustments](
	[BranchCode] [char](2) NOT NULL,
	[VehicleAdjustmentNature] [char](2) NOT NULL,
	[VehicleAdjustmentNo] [char](10) NOT NULL,
	[VehicleAdjustmentDate] [datetime] NOT NULL,
	[VehicleCode] [char](10) NULL,
	[Description] [varchar](250) NULL,
	[Mode] [varchar](20) NULL,
	[ChequeNo] [char](15) NULL,
	[Locked] [bit] NULL,
	[Posted] [bit] NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[CreditDays] [bigint] NULL,
	[OldRef] [char](12) NULL,
	[UrduTitle] [nvarchar](2000) NULL,
	[GUID] [int] NOT NULL,
 CONSTRAINT [PK_VehicleAdjustments] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[VehicleAdjustmentNature] ASC,
	[VehicleAdjustmentNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerBills]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCustomerBills]
@BillNo char(10) = ''  ,
@CustomerCode varchar(10),
@CustomerName varchar(10),
@BillDate Datetime=null,
@NewRecord as bigint
AS

DECLARE @TransactionNo varchar(10)
DECLARE @DateValue varchar(4)

	IF @NewRecord = 1 
	     BEGIN

		SET @DateValue = dbo.DateToKey( @BillDate ) 
		SELECT  TOP 1   @TransactionNo = BillNo FROM dbo.CustomerBills WHERE ( LEFT( BillNo , 4 )  = @DateValue ) ORDER BY BillNo DESC
		SET @TransactionNo = dbo.KeyValue( @DateValue , @TransactionNo )
		SELECT @TransactionNo as BillNo

		INSERT INTO CustomerBills(BillNo, CustomerCode,BillDate) 
		VALUES  ( @BillNo, @CustomerCode,@BillDate) 
	     END
	ELSE 
	     BEGIN
		SELECT @BillNo as BillNo
		UPDATE CustomerBills
		SET 
		BillNo= @BillNo,
		CustomerCode=@CustomerCode,
		BillDate=@BillDate
		WHERE  ( BillNo = @BillNo  )
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOASubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCOASubsidiaries]
@ControlCode char(10) = ''  ,
@GeneralCode char(10) = ''  ,
@GeneralDescription varchar(200),
@SubsidiaryCode char(10) = ''  ,
@ControlDescription varchar(100),
@SubsidiaryDescription varchar(100),
@FSFGLCode char(14) = ''  ,
@FSFGLDescription char(14) = ''  ,
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 

Set @ControlCode =LEFT(@GeneralCode,2) 
Set @GeneralCode =substring(@GeneralCode,3, 4 ) 


	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO COASubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubsidiaryDescription,DefinitionDate,GUID, FSFGLCode) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode,@SubsidiaryDescription ,@DefinitionDate,@GUID, @FSFGLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE COASubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		SubsidiaryDescription = @SubsidiaryDescription,
		FSFGLCode=@FSFGLCode
		WHERE  (SubsidiaryCode=@SubsidiaryCode AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END
GO
/****** Object:  UserDefinedFunction [dbo].[GetFreightGLCode]    Script Date: 12/01/2017 23:44:32 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[GetFreightGLCode](@FromVehicleCode as varchar(10)='',@ToVehicleCode as varchar(10)='')

RETURNS varchar(8000)

AS
BEGIN

DECLARE @GLCode varchar(8000)

SET @GLCode  = ''


	SELECT @GLCode =

	Case @GLCode  
	WHEN '' THEN ISNULL(FreightGLCode , '')
	ELSE  ISNULL(FreightGLCode,'')  + ',' + ISNULL(@GLCode , '')
	END
	From
	dbo.Vehicles
	WHERE VehicleCode BETWEEN  @FromVehicleCode and @ToVehicleCode



RETURN(@GLCode )

END
GO
/****** Object:  UserDefinedFunction [dbo].[GetCOAValidation]    Script Date: 12/01/2017 23:44:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     FUNCTION [dbo].[GetCOAValidation] 
( @COACode AS VARCHAR(50) )
RETURNS TINYINT
AS BEGIN 
      DECLARE @RtnGlCode AS TINYINT

	
      SET @RtnGlCode =  CONVERT( TINYINT,( SELECT  DISTINCT
                                    1 AS GLCode
                         FROM       dbo.VoucherDetails
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.[Vehicles]
                         WHERE      InstallmentGLCode = @COACode
                                    OR FreightGLCode = @COACode
                                    OR LoanGLCode = @COACode
                                    OR CommissionGLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.Customers
                         WHERE      ShortageGLCode = @COACode
                                    OR WHTaxGLCode = @COACode
                                    OR GLCode = @COACode
                                    
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.PaymentVoucherDetails
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.UsedTransactionsDetail
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.Branches
                         WHERE      GLCode = @COACode  ) )
                       
	
	
      RETURN    ISNULL( @RtnGlCode,0)
               
   END
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicles]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[DeleteVehicles]
@VehicleCode nchar(10)=''
AS
	IF @VehicleCode <> ''
		DELETE FROM Vehicles
		WHERE ( VehicleCode= @VehicleCode)
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receipts](
	[BranchCode] [char](2) NOT NULL,
	[ReceiptNo] [char](10) NOT NULL,
	[BillNo] [char](10) NOT NULL,
	[CustomerCode] [char](5) NULL,
	[ReceiptDate] [datetime] NULL,
	[Description] [varchar](200) NULL,
	[Amount] [decimal](20, 5) NULL,
	[Shortage] [decimal](20, 5) NULL,
	[TaxRate] [decimal](20, 5) NULL,
	[SaleTaxValue] [decimal](20, 5) NULL,
	[AmountIncSaleTax] [decimal](20, 5) NULL,
	[TotalAmount] [decimal](20, 5) NULL,
	[Locked] [tinyint] NULL,
	[Posted] [tinyint] NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ReceiptDetails] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[ReceiptNo] ASC,
	[BillNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SelectCOASubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOASubsidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(1) ='',
@GeneralCode  as varchar(10) ='',
@SubsidiaryCode as varchar(8) ='',
@COASubsidiary as varchar(5) =''

AS
IF 	@Option='ALL' 
        SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
        FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
		                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate
		FROM         dbo.COAGenerals LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode RIGHT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubsidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, 
                      dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription
FROM         dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND 
                      dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubsidiaryCode +1 as SubsidiaryCode
		FROM dbo.COASubsidiaries
		ORDER BY dbo.COASubsidiaries.SubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT     TOP 100 PERCENT ControlCode + GeneralCode + SubsidiaryCode AS GLCode, SubsidiaryDescription AS GLDescription
		FROM         dbo.COASubsidiaries
		ORDER BY SubsidiaryCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		WHERE dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode =@GeneralCode  AND dbo.COASubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode

ELSE
			SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		WHERE dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode =@GeneralCode  AND dbo.COASubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode
GO
/****** Object:  StoredProcedure [dbo].[SelectReceipts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectReceipts]

@Option as  varchar(20)='',
@BranchCode as  varchar(20)='',
@TransactionNo as integer =0,
@FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
@YearMonth as varchar(4)='',
@CustomerCode as char(10)='',
@BillNo as char(12)=''
AS

	IF @Option='ALL'  
		SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo, dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
        ELSE 
                IF @Option = 'DateFilter' ---Date Filter for ALL Voucher Generation
                SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo, dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
		      where dbo.Receipts.Posted=0 and dbo.Receipts.ReceiptDate between @FromDate and @ToDate
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
                
	ELSE IF @Option='AUTO' 
		SELECT TOP 1 ReceiptNo as TransactionNo FROM Receipts 
			WHERE ( SUBSTRING( CAST( ReceiptNo AS varchar(4) ) ,1,4) = @YearMonth )   AND BranchCode=@BranchCode
			Order By ReceiptNo DESC

	Else IF @Option='SRHGRID'  
			SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo , dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
			--WHERE dbo.Receipts.PartyCode="CustomerCode"

	ELSE
		SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo , dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
		WHERE dbo.Receipts.ReceiptNo=@TransactionNo and  dbo.Receipts.BranchCode= @BranchCode
		and  dbo.Receipts.BillNo= @BillNo
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoices]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[SelectInvoices]
    @Option AS VARCHAR(20) = '',
    @BranchCode AS VARCHAR(2) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @YearMonth AS VARCHAR(4) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
    @CustomerCode AS CHAR(10) = ''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.Invoices.BranchCode,
                dbo.Invoices.TransactionNo,
                dbo.Invoices.TransactionDate,
                dbo.Invoices.CustomerReference,
                dbo.Invoices.VehicleCode,
                dbo.[Vehicles ].VehicleDescription,
                dbo.Customers.CustomerCode,
                dbo.Customers.CustomerName,
                dbo.Invoices.StationPointCode,
                dbo.StationPoints.StationPointName AS StationPointName,
                dbo.Invoices.DestinationPointCode,
                dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
                dbo.Invoices.DueDate,
                dbo.Invoices.ProductCode,
                dbo.Products.ProductName,
                dbo.Invoices.Description,
                dbo.Invoices.Locked,
                dbo.Invoices.Posted,
                dbo.Invoices.RecordNo,
                dbo.Invoices.IsTripCanceled,
                dbo.Invoices.IsTripCanceled AS Expr1,
                dbo.Branches.BranchDescription AS BranchName,
                dbo.Invoices.Quantity,
                dbo.Invoices.Rate,
                dbo.Invoices.Commission,
                dbo.Invoices.CommissionRate ,
                dbo.Invoices.Shortage,
                dbo.Invoices.ShortageQuantity,
                dbo.Invoices.QuantityValue,
                dbo.Invoices.Amount,
                dbo.Invoices.TripAdvanceReference,
                dbo.Invoices.TripAdvance
        FROM    dbo.Invoices
                LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
        WHERE   dbo.Invoices.Posted = 0
        ORDER BY dbo.Invoices.BranchCode,
                dbo.Invoices.TransactionNo

    ELSE 
        IF @Option = 'AUTO' 
            SELECT TOP 1
                    TransactionNo
            FROM    Invoices
            WHERE   ( SUBSTRING(CAST(TransactionNo AS VARCHAR(4)), 1, 4) = @YearMonth )
                    AND BranchCode = @BranchCode
            ORDER BY TransactionNo DESC

        ELSE 
            IF @Option = 'SRHGRID' 
                SELECT  dbo.Invoices.BranchCode,
                        dbo.Invoices.TransactionNo AS InvoiceNo,
                        dbo.Invoices.TransactionDate AS InvoiceDate,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Invoices.Description,
                        dbo.Invoices.Amount,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.QuantityValue
                FROM    dbo.Invoices
                        LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                        LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                WHERE   dbo.Invoices.PartyCode = @CustomerCode
                        AND dbo.Invoices.IsBilled = 0
			
            ELSE 
                IF @Option = 'DateFilter' ---Date Filter for ALL Voucher Generation
                    SELECT  dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo,
                            dbo.Invoices.TransactionDate,
                            dbo.Invoices.CustomerReference,
                            dbo.Invoices.VehicleCode,
                            dbo.[Vehicles ].VehicleDescription,
                            dbo.Customers.CustomerCode,
                            dbo.Customers.CustomerName,
                            dbo.Invoices.StationPointCode,
                            dbo.StationPoints.StationPointName AS StationPointName,
                            dbo.Invoices.DestinationPointCode,
                            dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
                            dbo.Invoices.DueDate,
                            dbo.Invoices.ProductCode,
                            dbo.Products.ProductName,
                            dbo.Invoices.Description,
                            dbo.Invoices.Locked,
                            dbo.Invoices.Posted,
                            dbo.Invoices.RecordNo,
                            dbo.Invoices.IsTripCanceled,
                            dbo.Invoices.IsTripCanceled AS Expr1,
                            dbo.Branches.BranchDescription AS BranchName,
                            dbo.Invoices.Quantity,
                            dbo.Invoices.Rate,
                            dbo.Invoices.Commission,
                            dbo.Invoices.Shortage,
                            dbo.Invoices.ShortageQuantity,
                            dbo.Invoices.QuantityValue,
                            dbo.Invoices.Amount,
                            dbo.Invoices.TripAdvanceReference,
                            dbo.Invoices.TripAdvance
                    FROM    dbo.Invoices
                            LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                            LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                            LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                            LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                            LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
                    WHERE   dbo.Invoices.Posted = 0
                    ORDER BY DBO.Invoices.RecordNo,
                            dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo
                            
                ELSE 
                    SELECT  dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo,
                            dbo.Invoices.TransactionDate,
                            dbo.Invoices.CustomerReference,
                            dbo.Invoices.VehicleCode,
                            dbo.[Vehicles ].VehicleDescription,
                            dbo.Customers.CustomerCode,
                            dbo.Customers.CustomerName,
                            dbo.Invoices.StationPointCode,
                            dbo.StationPoints.StationPointName AS StationPointName,
                            dbo.Invoices.DestinationPointCode,
                            dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
                            dbo.Invoices.DueDate,
                            dbo.Invoices.ProductCode,
                            dbo.Products.ProductName,
                            dbo.Invoices.Description,
                            dbo.Invoices.Locked,
                            dbo.Invoices.Posted,
                            dbo.Invoices.RecordNo,
                            dbo.Invoices.IsTripCanceled,
                            dbo.Invoices.IsTripCanceled AS Expr1,
                            dbo.Branches.BranchDescription AS BranchName,
                            dbo.Invoices.Quantity,
                            dbo.Invoices.Rate,
                            dbo.Invoices.Commission,
                            dbo.Invoices.CommissionRate ,
                            dbo.Invoices.Shortage,
                            dbo.Invoices.ShortageQuantity,
                            dbo.Invoices.QuantityValue,
                            dbo.Invoices.Amount,
                            dbo.Invoices.TripAdvanceReference,
                            dbo.Invoices.TripAdvance
                    FROM    dbo.Invoices
                            LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                            LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                            LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                            LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                            LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
                    WHERE   dbo.Invoices.TransactionNo = @TransactionNo
                            AND dbo.Invoices.BranchCode = @BranchCode
                            AND dbo.Invoices.Posted = 0
                    ORDER BY dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAValidation]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAValidation]
    @TableName NCHAR(50) = '',
    @COACode NCHAR(50) = '',
    @ValidationType NCHAR(50) = '',
    @rtnGLCode  TINYINT
AS 
    IF @ValidationType = 'DELETE' 
	BEGIN
		SET @rtnGlCode= dbo.GetCOAValidation((@COACode)) 
		IF @rtnGlcode=1 
		RETURN(99)
		print 'The COA Code is exist already in some Transaction therefor can not deleted'
	
	
	end
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAListReports]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateCOASubSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCOASubSubsidiaries]
@ControlCode char(2) = ''  ,
@GeneralCode char(3) = '' ,
@SubsidiaryCode1   char(9) = ''  ,
@ControlDescription varchar(100),
@GeneralDescription varchar(100),
@SubsidiaryDescription varchar(100),
@SubSubsidiaryCode char(10) = ''  ,
@FSFGLCode char(15) = ''  ,
@FSFGLDescription char(15) = ''  ,
@SubSubsidiaryDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 
                            ------- example @Subsidiarycode1 = 01 01 0001         =9 degit
Set @ControlCode =LEFT(@SubsidiaryCode1,2)    --  1
Set @GeneralCode =SUBSTRING(@SubsidiaryCode1, 3 ,2)  -- 001
Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 5,8)   --- 1 001 00001
--print @SubsidiaryCode1
--print @GeneralCode
--print @ControlCode



	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO COASubSubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubSubsidiaryCode,SubSubsidiaryDescription,DefinitionDate,GUID, FSFGLCode) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode1, @SubSubsidiaryCode, @SubSubsidiaryDescription ,@DefinitionDate,@GUID, @FSFGLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE COASubSubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		FSFGLCode=@FSFGLCode,
		SubSubsidiaryDescription = @SubSubsidiaryDescription
		WHERE  (SubSubsidiaryCode=@SubSubsidiaryCode AND SubsidiaryCode=@SubsidiaryCode1 AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END
GO
/****** Object:  Table [dbo].[VehicleAdjustmentDetails]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehicleAdjustmentDetails](
	[BranchCode] [char](2) NOT NULL,
	[VehicleAdjustmentNature] [char](2) NOT NULL,
	[VehicleAdjustmentNo] [char](10) NOT NULL,
	[TransactionTypeCode] [char](2) NOT NULL,
	[Amount] [decimal](20, 5) NULL,
	[UrduDescription] [nvarchar](200) NULL,
	[GLCode] [char](50) NULL,
	[DivisionCode] [char](3) NULL,
	[InvoiceRefNo] [char](10) NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_VehicleAdjustmentDetails] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC,
	[VehicleAdjustmentNature] ASC,
	[VehicleAdjustmentNo] ASC,
	[TransactionTypeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceipts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceipts]
 @TransactionNo varchar(15)=' '  ,
 @ReceiptDate  datetime=' '  ,
 @BranchCode varchar(5)=' '  ,
 @BranchName varchar(5)=' '  ,
 @BillNo varchar(15)=' '  ,
 @CustomerCode varchar(5)=' '  ,
 @CustomerName varchar(5)=' '  ,
 @Description  varchar(200) = '',
 @TaxRate  Decimal(20,5) = 0.00,
 @SaleTaxValue  Decimal(20,5) = 0.00,
 @AmountIncSaleTax  Decimal(20,5) = 0.00,
 @Amount  Decimal(20,5) = 0.00,
 @TotalAmount  Decimal(20,5) = 0.00,
 @Shortage  Decimal(20,5) = 0.00,
 @RecordNo as bigint=0,
@GUID as bigint=0,
@NewRecord as bigint=0
AS

DECLARE @ReceiptNo varchar(10)
DECLARE @DateValue varchar(4)



	IF @NewRecord = 1 
	     BEGIN
		SET @DateValue = dbo.DateToKey( @ReceiptDate ) 
		SELECT  TOP 1   @ReceiptNo = ReceiptNo FROM dbo.Receipts WHERE (BranchCode = @BranchCode ) AND ( LEFT( ReceiptNo , 4 )  = @DateValue ) ORDER BY ReceiptNo DESC
		SET @ReceiptNo = dbo.KeyValue( @DateValue , @ReceiptNo )
		SELECT @ReceiptNo as TransactionNo

			INSERT INTO Receipts ( BranchCode,  ReceiptNo,BillNo ,ReceiptDate,CustomerCode,  Description, TaxRate ,SaleTaxValue ,Amount,AmountIncSaleTax,Shortage, TotalAmount ) 
			VALUES       (@BranchCode, @TransactionNo, @BillNo ,@ReceiptDate,@CustomerCode,@Description, @TaxRate, @SaleTaxValue ,@Amount, @AmountIncSaleTax, @Shortage,  @TotalAmount) 
			

			UPDATE CustomerBills --UPDATE CUSTOMER BILL WILL RECEIPT
			SET
				IsReceipt=1 
			WHERE BillNo=@BillNo
				

	     END
	ELSE 

	     BEGIN
		SELECT @TransactionNo as TransactionNo	
		UPDATE Receipts
			SET	ReceiptNo =@TransactionNo ,
			ReceiptDate=@ReceiptDate,
			CustomerCode=@CustomerCode,
			Billno= @BillNo,
			AmountIncSaleTax=@AmountIncSaleTax  ,
			Amount=@Amount, 
			TaxRate=@TaxRate, 
			SaleTaxValue=@SaleTaxValue, 
			Shortage =@Shortage,
			TotalAmount=@TotalAmount
		--	Narration=@Narration
		WHERE  (ReceiptNo=@TransactionNo )
		AND	(BranchCode =@BranchCode)
		AND	(BranchCode =@BranchCode)
		AND	(BillNo =@BillNo)
 	     END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePosting]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE  UpdatePosting
CREATE PROCEDURE  [dbo].[UpdatePosting]

@BranchCode CHAR(3) = ''  , 
@DivisionCode CHAR(3) = ''  , 
@VoucherNature CHAR(3) = '' , 
@VoucherNo varchar(10) = ''  , 
@VoucherDate datetime = NULL , 
@GLCode bigint = 0 , 
@BillNo varchar(50) = '' , 
@RefVoucherNature char(3) = '' ,
@RefVoucherNo varchar(10) = '' ,
@RefVoucherDate datetime = NULL , 
@RefBillNo as varchar( 50 ) = '' , 
@AmountUsed as decimal( 20 , 5 ) = 0 ,

@DebitBalance  as decimal( 20 , 5 ) = 0 ,
@CreditBalance as decimal( 20 , 5 ) = 0 ,

@nType int = 0 ,
@PostingDate datetime = 0 ,


@ToDate datetime  = NULL ,
@FromDocNo varchar(10) = '' ,
@ToDocNo varchar(10) = '' ,
@TransactionType as varchar( 1000 ) = '0' ,
@GUID as bigint = 0
AS 

IF  @nType = 2		-- INSERTING TRANS USED VALUES
	BEGIN
	INSERT INTO UsedTransactionsDetail
                      	(BranchCode, VoucherNature, VoucherNo, VoucherDate, GLCode, BillNo, RefVoucherNature, 
		RefVoucherNo, RefVoucherDate, RefBillNo, AmountUsed)
	VALUES     (@BranchCode, @VoucherNature, @VoucherNo, @VoucherDate, @GLCode, @BillNo, @RefVoucherNature, 
		@RefVoucherNo, @RefVoucherDate, @RefBillNo, @AmountUsed )
	END
ELSE IF  @nType = 3		-- POSTING OF MASTER TRANS
	BEGIN
	UPDATE    Vouchers
	SET              Locked = 1, Posted = 1
	WHERE  Vouchers.VoucherDate <= @PostingDate  

	UPDATE    PaymentVouchers
	SET              Locked = 1, Posted = 1
	WHERE  PaymentVouchers.VoucherDate <= @PostingDate  

	UPDATE    Invoices
	SET              Locked = 1, Posted = 1
	WHERE  Invoices.TransactionDate <= @PostingDate

	UPDATE    Receipts
	SET              Locked = 1, Posted = 1
	WHERE  Receipts.ReceiptDate <= @PostingDate

	END
ELSE IF  @nType = 4		-- UNPOSTING OF MASTER TRANS
	BEGIN
	UPDATE    Vouchers
	SET              Posted = 0
	WHERE  Vouchers.VoucherDate >= @PostingDate  
	
	UPDATE    PaymentVouchers
	SET              Posted = 0
	WHERE  PaymentVouchers.VoucherDate >= @PostingDate  

	UPDATE    Invoices
	SET              Posted = 0
	WHERE  Invoices.TransactionDate >= @PostingDate 

	UPDATE    Receipts
	SET              Posted = 0
	WHERE  Receipts.ReceiptDate >= @PostingDate 

	END

ELSE IF @nType = 5		-- UPDATING OPENING BALANCE
	BEGIN
		IF EXISTS ( SELECT * FROM OpeningBalances WHERE BranchCode = @BranchCode AND GLCode = @GLCode AND DivisionCode = @DivisionCode AND MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate ) )
			BEGIN
				UPDATE OpeningBalances
				SET    ClosingDate = @PostingDate  , DebitBalance = @DebitBalance, CreditBalance = @CreditBalance, GUID = @GUID
				WHERE BranchCode = @BranchCode AND GLCode = @GLCode AND DivisionCode = @DivisionCode AND MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )
			END
		ELSE
			BEGIN			
				INSERT INTO OpeningBalances
				                      (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)
				VALUES     (@PostingDate, @BranchCode, @DivisionCode, @GLCode, @DebitBalance, @CreditBalance, @GUID)
			END
	END 
ELSE IF  @nType = 6		-- DELETING TRANS USED VALUES
	BEGIN
	DELETE FROM UsedTransactionsDetail
	WHERE  RefVoucherDate >= @PostingDate OR VoucherDate >= @PostingDate
	END
ELSE IF  @nType = 7		-- DELETING CLOSING BALANCE OF POST DATED
	BEGIN
	DELETE FROM OpeningBalances 
	WHERE  ClosingDate > @PostingDate 
	END
ELSE IF  @nType = 8		-- UNLOCKING OF MASTER TRANS
	BEGIN
	DECLARE @SQLStr as varchar(8000)
	
	SET @SQLStr = ' UPDATE   Vouchers
	SET            Locked = 0
	WHERE   ( BranchCode = ''' + CAST ( @BranchCode as  varchar(30) )  + ''' ) AND
		( VoucherNature IN ( ' + @TransactionType + ' ) ) AND
		( ( VoucherDate BETWEEN ''' + CAST ( @PostingDate as  varchar(40) )  + ''' AND ''' + CAST ( @ToDate as  varchar(40) ) + ''' ) AND
		( VoucherNo BETWEEN  ''' + @FromDocNo + ''' AND ''' +@ToDocNo + ''' ))'

	EXEC ( @SQLStr )
print @SqlStr

	SET @SQLStr = ' UPDATE   PaymentVouchers
	SET            Locked = 0
	WHERE   ( BranchCode = ''' + CAST ( @BranchCode as  varchar(30) )  + ''' ) AND
		( VoucherNature IN ( ' + @TransactionType + ' ) ) AND
		( ( VoucherDate BETWEEN ''' + CAST ( @PostingDate as  varchar(40) )  + ''' AND ''' + CAST ( @ToDate as  varchar(40) ) + ''' ) AND
		( VoucherNo BETWEEN  ''' + @FromDocNo + ''' AND ''' +@ToDocNo + ''' ))'

	EXEC ( @SQLStr )

	END

ELSE IF @nType = 9
	BEGIN
/*
	DELETE FROM  OpeningBalances  WHERE MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )

	INSERT INTO OpeningBalances  (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)

	SELECT   @PostingDate as ClosingDate,  dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode, 
	                  SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) AS DebitSum , 0 as CreditSum , 0 as GUID
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode
	HAVING     SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) > 0
	
	UNION ALL
	
	SELECT   @PostingDate as ClosingDate,  dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode, 
	                  0 AS DebitSum , SUM(dbo.VoucherDetails.Credit) - SUM(dbo.VoucherDetails.Debit) as CreditSum , 0 as GUID
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode
	HAVING     SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) <= 0
*/
	DECLARE @DocDate     as datetime
	BEGIN TRANSACTION
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter

	SELECT     dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode, 
	                      MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate INTO #OpeningDate
	FROM         dbo.OpeningBalances 
	WHERE     (dbo.OpeningBalances.ClosingDate <= @PostingDate )
	GROUP BY dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
	SELECT     dbo.OpeningBalances.ClosingDate, dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, 
	      dbo.OpeningBalances.GLCode, dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS OpeningBalance INTO #OpeningTAB
	FROM         dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
	      dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate AND 
	      dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode AND 
	      dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
	SELECT @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate) + 1,0) FROM #OpeningDate
	PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate INTO #TransMaster
	FROM         dbo.Vouchers 
	WHERE  (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate BETWEEN @DocDate AND @PostingDate)
	
	-- SELECT Detail Transaction With Date
	SELECT     dbo.VoucherDetails.BranchCode, #TransMaster.VoucherDate, dbo.VoucherDetails.GLCode, 
		      dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit INTO #TransDetail
	FROM         #TransMaster INNER JOIN
		      dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode AND 
		      #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
		      #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo 
	
	-- Select Transaction Balance
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, SUM(#TransDetail.Debit) 
		      - SUM(#TransDetail.Credit) AS TransBalance INTO #TransBalTAB
	FROM         #TransDetail LEFT OUTER JOIN
		      #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode AND 
		      #TransDetail.VoucherDate > #OpeningDate.ClosingDate AND 
		      #TransDetail.GLCode = #OpeningDate.GLCode AND #TransDetail.DivisionCode = #OpeningDate.DivisionCode
	GROUP BY #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode
	
	---   Final Opening Balance 
	SELECT     BranchCode, DivisionCode, GLCode, SUM(OpeningBalance) AS OpeningBalance INTO #TransTAB
	FROM         (SELECT     BranchCode, DivisionCode, GLCode, OpeningBalance
	                       FROM          #OpeningTAB
	                       UNION ALL
	                       SELECT     BranchCode, DivisionCode, GLCode, TransBalance
	                       FROM         #TransBalTAB) TransTAB
	GROUP BY BranchCode, DivisionCode, GLCode

	DELETE FROM  OpeningBalances  WHERE MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )

	INSERT INTO OpeningBalances  (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)

	SELECT   @PostingDate as ClosingDate,  BranchCode, DivisionCode, GLCode, 
			OpeningBalance ,  0 as CreditBal , 0 as GUID
	FROM     #TransTAB
	WHERE 	OpeningBalance > 0

	UNION ALL
	
	SELECT   @PostingDate as ClosingDate,  BranchCode, DivisionCode, GLCode, 
			0 as DebitBal , ABS(OpeningBalance) as CreditBal, 0 as GUID
	FROM     #TransTAB
	WHERE 	OpeningBalance <= 0 
	COMMIT TRANSACTION
END
GO
/****** Object:  View [dbo].[VIEW1]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW1]
AS
SELECT     dbo.Invoices.BranchCode, dbo.Invoices.TransactionNo, dbo.Invoices.PartyCode, dbo.Invoices.VehicleCode
FROM         dbo.Invoices INNER JOIN
                      dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode INNER JOIN
                      dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleAdjustments]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVehicleAdjustments]
    @BranchCode CHAR(2) = '',
    @TransactionNature CHAR(2) = '',
    @BranchName CHAR(2) = '',
    @TransactionNo VARCHAR(15) = ' ',
    @VehicleCode CHAR(15) = ' ',
    @Mode CHAR(15) = ' ',
    @VehicleDescription CHAR(15) = ' ',
    @ChequeNo VARCHAR(15) = ' ',
    @UrduTitle NVARCHAR(500) = ' ',
    @TransactionDate DATETIME = ' ',
    @Description VARCHAR(200) = '',
    @Locked TINYINT = 0,
    @Posted TINYINT = 0,
    @GUID AS INTEGER = 0,
    @NewRecord AS BIGINT = 0
AS 
    DECLARE @VehicleAdjustmentNo VARCHAR(10)
    DECLARE @DateValue VARCHAR(4)



    IF @NewRecord = 1 
        BEGIN
            SET @DateValue = dbo.DateToKey(@TransactionDate) 
            SELECT TOP 1
                    @VehicleAdjustmentNo = VehicleAdjustmentNo
            FROM    dbo.VehicleAdjustments
            WHERE   ( BranchCode = @BranchCode )
                    AND ( VehicleAdjustmentNature = @TransactionNature )
                    AND ( LEFT(VehicleAdjustmentNo, 4) = @DateValue )
            ORDER BY VehicleAdjustmentNo DESC
            SET @VehicleAdjustmentNo = dbo.KeyValue(@DateValue,
                                                    @VehicleAdjustmentNo)
            SELECT  @VehicleAdjustmentNo AS TransactionNo

            INSERT  INTO VehicleAdjustments
                    (
                      BranchCode,
                      VehicleAdjustmentNature,
                      VehicleAdjustmentNo,
                      VehicleAdjustmentDate,
                      Description,
                      Mode,
                      VehicleCode,
                      ChequeNo,
                      UrduTitle,
                      GUID
                    )
            VALUES  (
                      @BranchCode,
                      @TransactionNature,
                      @VehicleAdjustmentNo,
                      @TransactionDate,
                      @Description,
                      @Mode,
                      @VehicleCode,
                      @ChequeNo,
                      @UrduTitle,
                      @GUID
                    ) 
        END
    ELSE 
        BEGIN
            SELECT  @TransactionNo AS TransactionNo
            UPDATE  VehicleAdjustments
            SET     VehicleAdjustmentNature = @TransactionNature,
                    VehicleAdjustmentNo = @TransactionNo,
                    UrduTitle = @UrduTitle,
                    VehicleCode = @VehicleCode,
                    Mode = @Mode,
                    VehicleAdjustmentDate = @TransactionDate,
                    ChequeNo = @ChequeNo,
                    Description = @Description
            WHERE   ( VehicleAdjustmentNature = @TransactionNature
                      AND VehicleAdjustmentNo = @TransactionNo
                      AND BranchCode = @BranchCode
                    )
		
        END
GO
/****** Object:  Table [dbo].[CustomerBillDetails]    Script Date: 12/01/2017 23:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerBillDetails](
	[BillNo] [char](10) NOT NULL,
	[BranchCode] [char](2) NOT NULL,
	[InvoiceNo] [char](10) NOT NULL,
	[RecordNo] [bigint] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](20, 5) NULL,
	[Shortage] [decimal](20, 5) NULL,
 CONSTRAINT [PK_CustomerBillDetails] PRIMARY KEY CLUSTERED 
(
	[BillNo] ASC,
	[BranchCode] ASC,
	[InvoiceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[GL_GetCOACombineVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop VIEW dbo.GL_GetCOACombineVW
CREATE VIEW [dbo].[GL_GetCOACombineVW]
AS
SELECT     ControlCode + GeneralCode AS GLCode, GeneralDescription AS GLDescription, dbo.COAGenerals.FSFGLCode AS SysFSFGLCode
FROM         dbo.COAGenerals
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, dbo.COASubsidiaries.SubsidiaryDescription AS GlDescription
	, (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) AS SysFSFGLCode
FROM         dbo.COASubsidiaries LEFT OUTER JOIN
                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GlDescription
		, (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) 
                      ELSE dbo.COASubSubsidiaries.FSFGLCode END) AS SysFSFGLCode
FROM         dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode
GO
/****** Object:  View [dbo].[GL_GetCOACombineTransactionVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
--drop  view GL_GetCOACombineTransactionVW
create view [dbo].[GL_GetCOACombineTransactionVW]
as
SELECT     dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GLCode, dbo.COAGenerals.GeneralDescription AS GLDescription, dbo.COAGenerals.FSFGLCode
FROM         dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode
WHERE     (dbo.COASubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS GLDescription ,COASubsidiaries.FSFGLCode
FROM         dbo.COASubsidiaries LEFT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode AND 
                      dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode
WHERE     dbo.COASubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.COASubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLDescription ,dbo.COASubSubsidiaries.FSFGLCode
FROM         dbo.COASubsidiaries RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode
GO
/****** Object:  View [dbo].[GL_GetCOACombineLedTBRptVW]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
create view  [dbo].[GL_GetCOACombineLedTBRptVW]
as
SELECT     dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GLCode, dbo.COAGenerals.GeneralDescription AS GLRptTitle, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription AS ControlRptTitle, dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, 
                      dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, '' AS SubSidiaryCode, '' AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle,
		      (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode LEFT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode
WHERE     (dbo.COASubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS GLRptTitle, dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription AS ControlRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle,
                      (CASE ISNULL(dbo.COASubSubsidiaries.FSFGLCode, 0) WHEN 0 THEN (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN COAGenerals.FSFGLCode ELSE COASubsidiaries.FSFGLCode END) ELSE dbo.COASubSubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAControls RIGHT OUTER JOIN
                      dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND 
                      dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode AND dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode ON 
                      dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode
WHERE     dbo.COASubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.COASubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLRptTitle, dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription AS ControlRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode AS SubsubCode,
                       dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLSubSubRptTitle
		     , (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0)  WHEN 0 THEN (CASE ISNULL(COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN COAGenerals.FSFGLCode ELSE COASubsidiaries.FSFGLCode END) ELSE COASubSubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAControls RIGHT OUTER JOIN
                      dbo.COAGenerals ON dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteReceipts]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceipts]
    @Option AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(12) = '',
    @BranchCode AS VARCHAR(3) = '',
    @BillNo AS VARCHAR(12) = ''
AS 
    BEGIN TRANSACTION

--DELETE FROM Receipts 
    UPDATE  Receipts
    SET     Amount = 0,
            AmountIncSaleTax = 0,
            Shortage = 0,
            Description = 'This Receipt has been Deleted',
            TaxRate = 0,
            TotalAmount = 0
    WHERE   ReceiptNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND BillNo = @BillNo

    UPDATE  dbo.CustomerBills
    SET     IsReceipt = 0
    WHERE   BillNo = @BillNo
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOASubSubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[DeleteCOASubSubsidiaries]
      @ControlCode NCHAR(5) = '',
      @GeneralCode NCHAR(10) = '',
      @SubsidiaryCode1 NCHAR(10) = '',
      @SubSubsidiaryCode NCHAR(10) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@SubsidiaryCode1) + @SubSubsidiaryCode
      SET @ControlCode = LEFT(@SubsidiaryCode1, 2)    --  1
      SET @GeneralCode = SUBSTRING(@SubsidiaryCode1, 3, 2)  -- 001
      SET @SubsidiaryCode1 = SUBSTRING(@SubsidiaryCode1, 5, 8)

	
      IF @ControlCode <> ''
            AND @GeneralCode <> ''
            AND @SubsidiaryCode1 <> ''
            AND @SubSubsidiaryCode <> '' 
            BEGIN
                  SET @rtnGlCode = dbo.GetCOAValidation(@GLCode)  
      
                  IF @rtnGlcode = 1 
                        BEGIN
                              RAISERROR ( 'The COA Code is exist already in some Transaction therefor can not deleted',
                                    16, 1, '', '', '' )

                              RETURN ( 99 )
                        END
                  ELSE 
                        BEGIN			
                              DELETE      FROM COASubSubsidiaries
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                                          AND ( SubsidiaryCode = @SubsidiaryCode1 )
                                          AND ( SubSubsidiaryCode = @SubSubsidiaryCode )

                        END
            END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOASubsidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE  PROCEDURE [dbo].[DeleteCOASubsidiaries]
      @ControlCode CHAR(5) = '',
      @GeneralCode CHAR(10) = '',
      @SubsidiaryCode1 CHAR(10) = '',
      @SubsidiaryCode CHAR(10) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@GeneralCode) + @SubsidiaryCode

      SET @ControlCode = LEFT(@GeneralCode, 2)    --  1
      SET @GeneralCode = SUBSTRING(@GeneralCode, 3, 2)  -- 001

      IF @ControlCode <> ''
            AND @GeneralCode <> ''
            AND @SubsidiaryCode <> '' 
            BEGIN
                  SET @rtnGlCode = dbo.GetCOAValidation(@GLCode)  
      
                  IF @rtnGlcode = 1 
                        BEGIN
                              RAISERROR ( 'The COA Code is exist already in some Transaction therefor can not deleted',
                                    16, 1, '', '', '' )

                              RETURN ( 99 )
                        END
                  ELSE 
                        BEGIN		
                              DELETE      FROM COASubsidiaries
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                                          AND ( SubsidiaryCode = @SubsidiaryCode )
                        END 
            END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOAGenerals]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE  PROCEDURE [dbo].[DeleteCOAGenerals]
      @ControlCode NCHAR(5) = '',
      @GeneralCode NCHAR(5) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@ControlCode) + @GeneralCode
      
      IF @ControlCode <> ''
            AND @GeneralCode <> '' 
            BEGIN
                  SET @rtnGlCode = dbo.GetCOAValidation(@GLCode)  
      
                  IF @rtnGlcode = 1 
                        BEGIN
                              RAISERROR ( 'The COA Code is exist already in some Transaction therefor can not deleted',
                                    16, 1, '', '', '' )

                              RETURN ( 99 )
                        END
                  ELSE 
                        BEGIN	
                              DELETE      FROM COAGenerals
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                        END
            END
GO
/****** Object:  StoredProcedure [dbo].[DeleteInvoices]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteInvoices]
    @Option AS VARCHAR(3) = '',
    @TransactionNo AS CHAR(10) = '',
    @BranchCode AS VARCHAR(3) = ''
AS 
    DECLARE @RefNo VARCHAR(10)
    DECLARE @AdjNo VARCHAR(10)
        
    BEGIN TRANSACTION

        
    UPDATE  dbo.VehicleAdjustmentDetails
    SET     InvoiceRefNo = ''
    WHERE   InvoiceRefNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
        
       
    --DELETE  FROM Invoices
    UPDATE  dbo.Invoices
    SET     Description = 'Invoice has been Deleted',
            CustomerReference = '',
            TripAdvanceReference = '',
            TripAdvance = 0,
            Quantity = 0,
            Rate = 0,
            Amount = 0,
            Shortage=0,
            Commission=0,
            ShortageQuantity=0,
            QuantityValue=0
    WHERE   TransactionNo = @TransactionNo
            AND BranchCode = @BranchCode
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerBillsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerBillsDetails]

@Option as  varchar(3)='',
@BillNo as varchar(10) ='',
@InvoiceNo as varchar(10) ='',
@BranchCode as varchar(10) =''

AS

DECLARE @BCode as char(3)
DECLARE @InNo as char(12)

DECLARE Bill_Cursor CURSOR FOR
SELECT  InvoiceNo, BranchCode FROM CustomerBillDetails
	
OPEN Bill_Cursor
	
FETCH NEXT FROM Bill_Cursor
INTO @InNo, @BCode
WHILE @@FETCH_STATUS = 0
BEGIN
	UPDATE Invoices
		Set IsBilled=0
	WHERE TransactionNo=@InNo
	AND BranchCode=@BCode
   FETCH NEXT FROM Bill_Cursor
   INTO @InNo, @BCode
END
CLOSE Bill_Cursor
DEALLOCATE Bill_Cursor


	
	DELETE FROM CustomerBillDetails  
	WHERE 
	BillNo=@BillNo
GO
/****** Object:  View [dbo].[vwTransDetail]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwTransDetail]
AS
SELECT  'ADJ' TYPE ,
        VA.BranchCode ,
        VA.Description,
        VAD.VehicleAdjustmentNature AS TransactionNature ,
        VAD.VehicleAdjustmentNo AS TransactionNo ,
        VA.VehicleAdjustmentDate AS TransactionDate ,
        VAD.TransactionTypeCode ,
        CASE VAD.VehicleAdjustmentNature
          WHEN 'CR' THEN Amount
          WHEN 'BR' THEN Amount
          WHEN 'AR' THEN Amount
          WHEN 'VR' THEN Amount
          ELSE 0
        END AS AmountReceived ,
        CASE VAD.VehicleAdjustmentNature
          WHEN 'CP' THEN Amount
          WHEN 'BP' THEN Amount
          WHEN 'AP' THEN Amount
          WHEN 'VP' THEN Amount
          ELSE 0
        END AS AmountPaid ,
        VA.RecordNo ,
        VA.VehicleCode
FROM    dbo.VehicleAdjustments AS VA
        INNER JOIN dbo.VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode
                                                          AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature
                                                          AND VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo
UNION
SELECT  'INV' TYPE ,
        I.BranchCode ,
        I.Description,
        'VR' AS TransactionNature ,
        I.TransactionNo ,
        I.TransactionDate ,
        '12' ,
        Amount - Shortage AS AmountReceived ,
        0 AS AmountPaid ,
        I.RecordNo ,
        I.VehicleCode
FROM    dbo.Invoices I
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[4] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3405
         Alias = 1710
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetail'
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleAdjustmentsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateVehicleAdjustmentsDetails]

@TransactionNature char(2) = ''  ,
@BranchCode char(2) = ''  ,
@TransactionNo varchar(16)=' '  ,
@GLCode  varchar(50)=' '  ,
@GLDescription  varchar(50)=' '  ,
@Amount decimal(20,5)=0.00,
@TypeCode char(5) = '' ,
@Type char(5) = '' ,
@DivisionCode char(5) = '' ,
@Division varchar(5) = '',
@Mode  varchar(100) = '',
@UrduDescription  nvarchar(200) = '',
@NewRecord as bigint=0
 AS 
if @DivisionCode =''
begin
set @DivisionCode ='001'
end
	


	IF @NewRecord = 1 
	     BEGIN
	
		INSERT INTO VehicleAdjustmentDetails (BranchCode, VehicleAdjustmentNature ,VehicleAdjustmentNo, TransactionTypeCode,  GLCode,  DivisionCode,Amount  , UrduDescription) 
		              VALUES  (@BranchCode, @TransactionNature ,@TransactionNo , @TypeCode,   @GLCode ,@DivisionCode , @Amount,  @UrduDescription) 
	
	     END
/*
	ELSE 
	     BEGIN
		UPDATE VehicleAdjustmentDetails
		Set  
			GLCode=@GLCode,
			Debit=@Debit,
			Credit=@Credit,
			Particuler=@Particuler
		WHERE  ( VehicleAdjustmentNature = @VehicleAdjustmentNature AND DocumentNo=@DocumentNo ) 
 	     END*/
GO
/****** Object:  View [dbo].[VIEW3]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW3]
AS
SELECT     dbo.Vehicles.VehicleCode, dbo.Vehicles.VehicleDescription, dbo.Vehicles.DefinitionDate, dbo.Vehicles.InstallmentGLCode, 
                      GL_GetCOACombineTransactionVW_Installment.GLDescription AS InstallmentGLDescription, dbo.Vehicles.FreightGLCode, 
                      GL_GetCOACombineTransactionVW_Freight.GLDescription AS FreightGLDescription, dbo.Vehicles.LoanGLCode, 
                      GL_GetCOACombineTransactionVW_1.GLDescription AS LoanGLDescription, dbo.VehicleOwners.OwnerCode, dbo.VehicleOwners.OwnerName, 
                      dbo.Vehicles.CommissionGLCode, GL_GetCOACombineTransactionVW_Commission.GLDescription AS CommissionGLDescription
FROM         dbo.Vehicles LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Commission ON 
                      dbo.Vehicles.CommissionGLCode = GL_GetCOACombineTransactionVW_Commission.GLCode LEFT OUTER JOIN
                      dbo.VehicleOwners ON dbo.Vehicles.OwnerCode = dbo.VehicleOwners.OwnerCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Freight ON 
                      dbo.Vehicles.FreightGLCode = GL_GetCOACombineTransactionVW_Freight.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_Installment ON 
                      dbo.Vehicles.InstallmentGLCode = GL_GetCOACombineTransactionVW_Installment.GLCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW GL_GetCOACombineTransactionVW_1 ON 
                      dbo.Vehicles.LoanGLCode = GL_GetCOACombineTransactionVW_1.GLCode
GO
/****** Object:  View [dbo].[VIEW2]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW2]
AS
SELECT     dbo.GL_GetCOACombineVW.GLCode, dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralDescription, dbo.COASubsidiaries.SubsidiaryDescription
FROM         dbo.GL_GetCOACombineVW LEFT OUTER JOIN
                      dbo.COASubsidiaries ON 
                      dbo.GL_GetCOACombineVW.GLCode = dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode LEFT OUTER JOIN
                      dbo.COAGenerals ON dbo.GL_GetCOACombineVW.GLCode = dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode LEFT OUTER JOIN
                      dbo.COAControls ON dbo.GL_GetCOACombineVW.GLCode = dbo.COAControls.ControlCode
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicles]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicles]    Script Date: 11/27/2017 13:58:23 ******/

CREATE PROCEDURE [dbo].[UpdateVehicles]
    @VehicleCode CHAR(10) = '' ,
    @VehicleDescription VARCHAR(100) = '' ,
    @OwnerCode AS VARCHAR(12) = '' ,
    @IsThirdParty AS BIT = 0 ,
    @OwnerName AS VARCHAR(12) = '' ,
    @Capacity AS VARCHAR(20) = '' ,
    @InstallmentGLCode AS VARCHAR(12) = '' ,
    @InstallmentGLDescription AS VARCHAR(12) = '' ,
    @FreightGLCode AS VARCHAR(12) = '' ,
    @FreightGLDescription AS VARCHAR(12) = '' ,
    @LoanGLCode AS VARCHAR(12) = '' ,
    @CustomerCode AS VARCHAR(5) = '' ,
    @Customer AS VARCHAR(12) = '' ,
    @LoanGLDescription AS VARCHAR(12) = '' ,
    @CommissionGLCode AS VARCHAR(12) = '' ,
    @CommissionGLDescription AS VARCHAR(12) = '' ,
    @DefinitionDate DATETIME = '' ,
    @NewRecord AS BIGINT
AS 
    BEGIN TRANSACTION
    BEGIN TRY
	 
	 --work for freght coa auto generation
	 --there should be a HEAD OPEN WITH SAME ID IN SUBSIDARY
	 
        DECLARE @SubSubIdForFreghtCode VARCHAR(10)
        DECLARE @SubSubIdForCommissionCode VARCHAR(10)
        DECLARE @SubsidoryCodeForFreghtCode VARCHAR(10)
        DECLARE @SubsidoryCodeForCommission VARCHAR(10)
        IF @IsThirdParty = 1 
            BEGIN
                SELECT  @SubSubIdForFreghtCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '02'
                        AND GeneralCode = '01'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)

                SELECT  @SubSubIdForFreghtCode = ISNULL(@SubSubIdForFreghtCode,
                                                        '0000');
		
                SET @SubsidoryCodeForFreghtCode = CAST('0201' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	

                SELECT  @SubSubIdForFreghtCode = RIGHT('0000'
                                                       + ISNULL(CAST(@SubSubIdForFreghtCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)		 	
                SELECT  @SubSubIdForCommissionCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '02'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
		 
		
                SELECT  @SubSubIdForCommissionCode = ISNULL(@SubSubIdForCommissionCode,
                                                            '0000');
		
                SELECT  @SubSubIdForCommissionCode = RIGHT('0000'
                                                           + ISNULL(CAST(@SubSubIdForCommissionCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)
                SET @SubsidoryCodeForCommission = CAST('0502' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	 
			 
		
            END
        ELSE 
            BEGIN
                SELECT  @SubSubIdForFreghtCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '01'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
                SELECT  @SubSubIdForFreghtCode = ISNULL(@SubSubIdForFreghtCode,
                                                        '0000');
                SELECT  @SubSubIdForFreghtCode = RIGHT('0000'
                                                       + ISNULL(CAST(@SubSubIdForFreghtCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)

                SET @SubsidoryCodeForFreghtCode = CAST('0501' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	
		--work for commission coa auto generation

       


                SELECT  @SubSubIdForCommissionCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '02'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
        
                SELECT  @SubSubIdForCommissionCode = ISNULL(@SubSubIdForCommissionCode,
                                                            '0000');
		
                SELECT  @SubSubIdForCommissionCode = RIGHT('0000'
                                                           + ( CAST(@SubSubIdForCommissionCode
                                                              + 1 AS VARCHAR(10)) ),
                                                           4)
                SET @SubsidoryCodeForCommission = CAST('0502' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	 
                PRINT @SubsidoryCodeForCommission
            END
        IF @NewRecord = 1 
            BEGIN		
	  --  PRINT @COUNT;
	    
		--PRINT CAST(@COUNT AS VARCHAR(45)) +@CustomerCode +'SUB '+@SubSubIdForFreghtCode +'SSSS'
                PRINT @SubSubIdForCommissionCode
		 
                EXEC UpdateCOASubSubsidiaries @NewRecord = 1, @FSFGLCode = N'',
                    @FSFGLDescription = '', @ControlDescription = '',
                    @GeneralDescription = '', @SubsidiaryDescription = '',
                    @SubsidiaryCode1 = @SubsidoryCodeForFreghtCode,
                    @DefinitionDate = @DefinitionDate,
                    @SubSubsidiaryCode = @SubSubIdForFreghtCode,
                    @SubSubsidiaryDescription = @VehicleDescription
	    
                EXEC UpdateCOASubSubsidiaries @NewRecord = 1, @FSFGLCode = N'',
                    @FSFGLDescription = '', @ControlDescription = '',
                    @GeneralDescription = '', @SubsidiaryDescription = '',
                    @SubsidiaryCode1 = @SubsidoryCodeForCommission,
                    @DefinitionDate = @DefinitionDate,
                    @SubSubsidiaryCode = @SubSubIdForCommissionCode,
                    @SubSubsidiaryDescription = @VehicleDescription
	    
		
                INSERT  INTO dbo.Vehicles
                        ( VehicleCode ,
                          VehicleDescription ,
                          DefinitionDate ,
                          OwnerCode ,
                          InstallmentGLCode ,
                          FreightGLCode ,
                          LoanGLCode ,
                          CommissionGLCode ,
                          CustomerCode ,
                          Capacity ,
                          IsThirdParty
                        )
                VALUES  ( @VehicleCode ,
                          @VehicleDescription ,
                          @DefinitionDate ,
                          @OwnerCode ,
                          @InstallmentGLCode ,
                          @FreightGLCode ,
                          @LoanGLCode ,
                          @CommissionGLCode ,
                          @CustomerCode ,
                          @Capacity ,
                          @IsThirdParty 
                        ) 
	    
	    
                UPDATE  dbo.[Vehicles ]
                SET     FreightGLCode = @SubsidoryCodeForFreghtCode
                        + @SubSubIdForFreghtCode ,
                        CommissionGLCode = @SubsidoryCodeForCommission
                        + @SubSubIdForCommissionCode
                WHERE   VehicleCode = @VehicleCode
		
	     
            END
        ELSE 
            BEGIN
	     
                IF ( @FreightGLCode = ''
                     OR @FreightGLCode IS NULL
                   )
	    -- print'dd'+ @SubSubIdForFreghtCode
                    BEGIN
                        EXEC UpdateCOASubSubsidiaries @NewRecord = 1,
                            @FSFGLCode = N'', @FSFGLDescription = '',
                            @ControlDescription = '', @GeneralDescription = '',
                            @SubsidiaryDescription = '',
                            @SubsidiaryCode1 = @SubsidoryCodeForFreghtCode,
                            @DefinitionDate = @DefinitionDate,
                            @SubSubsidiaryCode = @SubSubIdForFreghtCode,
                            @SubSubsidiaryDescription = @VehicleDescription
                        SET @FreightGLCode = @SubsidoryCodeForFreghtCode
                            + @SubSubIdForFreghtCode
                        PRINT @FreightGLCode
                    END
	     
                IF ( @CommissionGLCode = ''
                     OR @CommissionGLCode IS NULL
                   ) 
                    BEGIN
	    -- print @SubSubIdForFreghtCode
	    
                        EXEC UpdateCOASubSubsidiaries @NewRecord = 1,
                            @FSFGLCode = N'', @FSFGLDescription = '',
                            @ControlDescription = '', @GeneralDescription = '',
                            @SubsidiaryDescription = '',
                            @SubsidiaryCode1 = @SubsidoryCodeForCommission,
                            @DefinitionDate = @DefinitionDate,
                            @SubSubsidiaryCode = @SubSubIdForCommissionCode,
                            @SubSubsidiaryDescription = @VehicleDescription
				
	    
                        SET @CommissionGLCode = @SubsidoryCodeForCommission
                            + @SubSubIdForCommissionCode
                    END
		
		
                UPDATE  Vehicles
                SET     VehicleCode = @VehicleCode ,
                        DefinitionDate = @DefinitionDate ,
                        VehicleDescription = @VehicleDescription ,
                        OwnerCode = @OwnerCode ,
                        InstallmentGLCode = @InstallmentGLCode ,
                        FreightGLCode = @FreightGLCode ,
                        IsThirdParty = @IsThirdParty ,
                        CustomerCode = @CustomerCode ,
                        LoanGLCode = @LoanGLCode ,
                        CommissionGLCode = @CommissionGLCode ,
                        Capacity = @Capacity
                WHERE   ( VehicleCode = @VehicleCode )
            END
        COMMIT
    END TRY
    BEGIN CATCH
        DECLARE @MSG VARCHAR(500)
        SET @MSG = ERROR_MESSAGE()
        PRINT @MSG
        RAISERROR ( @MSG, 12,1);
        ROLLBACK TRANSACTION
    END CATCH
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvoices]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[UpdateInvoices]
    @TransactionNo VARCHAR(15) = ' ',
    @BranchCode VARCHAR(5) = ' ',
    @BranchName VARCHAR(5) = ' ',
    @CustomerCode VARCHAR(5) = ' ',
    @CustomerName VARCHAR(5) = ' ',
    @CustomerReference VARCHAR(50) = ' ',
    @VehicleCode VARCHAR(15) = ' ',
    @VehicleDescription VARCHAR(15) = ' ',
    @StationPointCode VARCHAR(15) = ' ',
    @StationPointName VARCHAR(15) = ' ',
    @DestinationPointCode VARCHAR(15) = ' ',
    @DestinationPointName VARCHAR(15) = ' ',
    @ProductCode VARCHAR(15) = ' ',
    @ProductName VARCHAR(15) = ' ',
    @TransactionDate DATETIME = ' ',
    @SupplierCode VARCHAR(10) = ' ',
    @SupplierName VARCHAR(10) = ' ',
    @Description VARCHAR(200) = '',
    @Rate DECIMAL(20, 5) = 0.00,
    @TripAdvanceReference CHAR(10) = '',
    @TripAdvance DECIMAL(20, 5) = 0.00,
    @Quantity NUMERIC(20, 5) = 0.00,
    @Amount DECIMAL(20, 5) = 0.00,
    @Commission DECIMAL(20, 5) = 0.00,
    @CommissionRate DECIMAL(2, 0) = 0,
    @ShortageQuantity DECIMAL(20, 5) = 0.00,
    @QuantityValue DECIMAL(20, 5) = 0.00,
    @Shortage DECIMAL(20, 5) = 0.00,
    @RecordNo AS BIGINT = 0,
    @GUID AS BIGINT = 0,
    @NewRecord AS BIGINT = 0
AS 
    DECLARE @InvoiceNo VARCHAR(10)
    DECLARE @RefNo VARCHAR(10)
    DECLARE @AdjNo VARCHAR(10)
    DECLARE @DateValue VARCHAR(4)
   
   
      --Getting Invoice No if already exist in Vehicel Adjustment
    SELECT  @RefNo = InvoiceRefNo,
            @AdjNo = VehicleAdjustmentNo
    FROM    dbo.VehicleAdjustmentDetails
    WHERE   InvoiceRefNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
    IF  ISNULL(@RefNo,'') <> ''  
       
            UPDATE  dbo.VehicleAdjustmentDetails
            SET     InvoiceRefNo = ''
            WHERE   VehicleAdjustmentNo = @AdjNo
                    AND BranchCode = @BranchCode
                    AND VehicleAdjustmentNature = 'VP'
   
     
    
    UPDATE  dbo.VehicleAdjustmentDetails
    SET     InvoiceRefNo = @TransactionNo
    WHERE   VehicleAdjustmentNo = @TripAdvanceReference
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
    
  --(Invoice)	
    IF @NewRecord = 1 
        BEGIN

            SET @DateValue = dbo.DateToKey(@TransactionDate) 
            SELECT TOP 1
                    @InvoiceNo = TransactionNo
            FROM    dbo.Invoices
            WHERE   ( BranchCode = @BranchCode )
                    AND ( LEFT(TransactionNo, 4) = @DateValue )
            ORDER BY TransactionNo DESC
            SET @InvoiceNo = dbo.KeyValue(@DateValue, @InvoiceNo)
            SELECT  @InvoiceNo AS TransactionNo


            INSERT  INTO Invoices
                    (
                      BranchCode,
                      TransactionNo,
                      TransactionDate,
                      PartyCode,
                      VehicleCode,
                      StationPointCode,
                      DestinationPointCode,
                      ProductCode,
                      CustomerReference,
                      Description,
                      Rate,
                      Quantity,
                      Amount,
                      TripAdvanceReference,
                      TripAdvance,
                      Commission,
                      CommissionRate,
                      Shortage,
                      QuantityValue,
                      ShortageQuantity,
                      GUID
                              
                    )
            VALUES  (
                      @BranchCode,
                      @TransactionNo,
                      @TransactionDate,
                      @CustomerCode,
                      @VehicleCode,
                      @StationPointCode,
                      @DestinationPointCode,
                      @ProductCode,
                      @CustomerReference,
                      @Description,
                      @Rate,
                      @Quantity,
                      @Amount,
                      @TripAdvanceReference,
                      @TripAdvance,
                      @Commission,
                      @CommissionRate,
                      @Shortage,
                      @QuantityValue,
                      @ShortageQuantity,
                      @GUID
                              
                    ) 

        END
    ELSE 
        BEGIN
            SELECT  @TransactionNo AS TransactionNo
            UPDATE  Invoices
            SET     TransactionNo = @TransactionNo,
                    TransactionDate = @TransactionDate,
                    PartyCode = @CustomerCode,
                    VehicleCode = @VehicleCode,
                    StationPointCode = @StationPointCode,
                    DestinationPointCode = @DestinationPointCode,
                    ProductCode = @ProductCode,
                    TripAdvanceReference = @TripAdvanceReference,
                    TripAdvance = @TripAdvance,
                    Quantity = @Quantity,
                    CustomerReference = @CustomerReference,
                    Amount = @Amount,
                    Rate = @Rate,
                    Commission = @Commission,
                    CommissionRate=@CommissionRate,
                    Shortage = @Shortage,
                    QuantityValue = @QuantityValue,
                    ShortageQuantity = @ShortageQuantity

		--	Narration=@Narration
            WHERE   ( TransactionNo = @TransactionNo
                      AND BranchCode = @BranchCode
                    )
                   

        END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerBillsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerBillsDetails]

@BillNo char(10) = ''  ,
@BranchCode varchar(10),
@Branch varchar(10),
@TokenNo varchar(10),
@DestinationPoint varchar(10),
@StationPoint varchar(10),
@InvoiceNo varchar(10),
@InvoiceDate Datetime='',
@Vehicle varchar(10)='',
@Product varchar(10)='',
@Amount decimal(18,5)=0.00,
@Shortage decimal(18,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO CustomerBillDetails(BillNo,BranchCode, InvoiceNo, Amount,Shortage) 
					VALUES  ( @BillNo, @BranchCode, @InvoiceNo, @Amount, @Shortage) 
		UPDATE Invoices 
			SET
			 IsBilled=1 
				WHERE TransactionNo=@InvoiceNo
				AND BranchCode=@BranchCode
	     END
GO
/****** Object:  StoredProcedure [dbo].[SelectVouchersDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectVouchersDetails]
@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@TransactionNature as varchar(3) ='',
@BranchCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     dbo.VoucherDetails.BranchCode,dbo.VoucherDetails.VoucherNature AS TransactionNature, dbo.VoucherDetails.VoucherNo AS TransactionNo, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineVW.GLDescription, dbo.VoucherDetails.DivisionCode, dbo.Divisions.Division
		FROM         dbo.VoucherDetails LEFT OUTER JOIN
                      dbo.Branches ON dbo.VoucherDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
		Order by RecordNo
ELSE
		SELECT     dbo.VoucherDetails.BranchCode,dbo.VoucherDetails.VoucherNature AS TransactionNature, dbo.VoucherDetails.VoucherNo  AS TransactionNo, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, 
		                      dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineVW.GLDescription, dbo.VoucherDetails.DivisionCode, dbo.Divisions.Division
		                      
		FROM         dbo.VoucherDetails LEFT OUTER JOIN
		                      dbo.Branches ON dbo.VoucherDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
		                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
		                      dbo.GL_GetCOACombineVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
		
		WHERE VoucherNo=@TransactionNo AND VoucherNature=@TransactionNature AND VoucherDetails.BranchCode=@BranchCode
		Order by RecordNo
GO
/****** Object:  StoredProcedure [dbo].[SelectVouchers]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVouchers]

@Option as  varchar(20)='',
@BranchCode as char(10) ='',
@TransactionNo as char(10) ='',
@TransactionNature as  char(3)='',
@Nature as  char(3)='',
@YearMonth as varchar(4)=''
AS



	IF @Option='ALL'  
		SELECT     dbo.Vouchers.VoucherNature AS TransactionNature, dbo.Vouchers.VoucherNo AS TransactionNo, dbo.Vouchers.VoucherDate AS TransactionDate, 
                      dbo.Vouchers.Description, dbo.Vouchers.UrduTitle , dbo.Vouchers.Locked, dbo.Vouchers.Posted, dbo.Vouchers.RecordNo, dbo.Vouchers.GUID, dbo.Vouchers.BranchCode, 
                      dbo.Branches.BranchDescription AS BranchName ,dbo.Vouchers.IsAutoGenerated
		FROM         dbo.Vouchers LEFT OUTER JOIN
                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode
		WHERE dbo.Vouchers.VoucherNature=@TransactionNature
        ORDER BY dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature , dbo.Vouchers.VoucherNo 
	ELSE IF @Option='AUTO' 
		SELECT TOP 1 VoucherNo as TransactionNo FROM dbo.Vouchers 
		WHERE ( SUBSTRING( CAST( VoucherNo AS varchar(4) ) ,1,4) = @YearMonth ) AND VoucherNature = @TransactionNature AND BranchCode = @BranchCode   
		ORDER BY VoucherNo DESC
	ELSE IF @Option='REPORT'  
		SELECT     dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, dbo.Vouchers.VoucherDate, dbo.Vouchers.Description, dbo.VoucherDetails.Reference, 
		      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
		      dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription
		FROM         dbo.VoucherDetails INNER JOIN
		      dbo.Vouchers ON dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo AND dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature LEFT OUTER JOIN
		      dbo.GL_GetCOACombineTransactionVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
		      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode
		WHERE dbo.Vouchers.VoucherNature=@TransactionNature AND dbo.Vouchers.VoucherNo=@TransactionNo
		 ORDER BY dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature , dbo.Vouchers.VoucherNo 
	ELSE
		SELECT     dbo.Vouchers.VoucherNature AS TransactionNature, dbo.Vouchers.VoucherNo AS TransactionNo, dbo.Vouchers.VoucherDate AS TransactionDate, 
                      dbo.Vouchers.Description,dbo.Vouchers.UrduTitle, dbo.Vouchers.Locked, dbo.Vouchers.Posted, dbo.Vouchers.RecordNo, dbo.Vouchers.GUID, dbo.Vouchers.BranchCode, 
                      dbo.Branches.BranchDescription AS BranchName,dbo.Vouchers.IsAutoGenerated
		FROM         dbo.Vouchers LEFT OUTER JOIN
                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode

		WHERE dbo.Vouchers.VoucherNature=@TransactionNature AND Vouchers.VoucherNo=@TransactionNo AND Vouchers.BranchCode=@BranchCode
GO
/****** Object:  StoredProcedure [dbo].[SelectVoucherListReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE  [dbo].[SelectVoucherListReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999',@VoucherNature as varchar(2000) = '' ,@FromTransactionNumber as varchar(20)='0000000000',@ToTransactionNumber as varchar(10)='9999999999', @OPTION CHAR(10)='',@FromGLCode char(10)='',@ToGLCode char(10)='' ) 

AS

SELECT     dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, dbo.Vouchers.VoucherDate, dbo.Vouchers.Description, dbo.VoucherDetails.Reference, 
                      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineTransactionVW.GLCode, 
                      dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, 
                      dbo.Branches.BranchDescription, dbo.Vouchers.UrduTitle , dbo.Branches.BranchDescription as BranchName , dbo.Vouchers.VoucherNature as TransactionNature, dbo.Vouchers.VoucherNo as  TransactionNo,  dbo.Vouchers.VoucherDate as TransactionDate,IsAutoGenerated
FROM         dbo.Vouchers INNER JOIN
                      dbo.VoucherDetails ON dbo.Vouchers.VoucherNo = dbo.VoucherDetails.VoucherNo AND dbo.Vouchers.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
                      dbo.Vouchers.BranchCode = dbo.VoucherDetails.BranchCode INNER JOIN
                      dbo.GetTransactionNatures(@VoucherNature,'GL') GetTransactionNatures ON dbo.Vouchers.VoucherNature = GetTransactionNatures.NatureCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
WHERE dbo.Vouchers.VoucherNo BETWEEN @FromCode AND @ToCode 
	AND dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate
	AND dbo.VoucherDetails.GLCode BETWEEN @FromGlCode AND @ToGlCode
GO
/****** Object:  StoredProcedure [dbo].[SelectVoucherDocumentReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SelectVoucherDocumentReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromPartyCode as varchar(10)='0000000',@ToPartyCode as varchar(10)='99999999999',  @FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999',@TransactionNature as varchar(500) = '' ,@FromTransactionNumber as varchar(20)='0000000000',@ToTransactionNumber as varchar(10)='9999999999', @OPTION CHAR(10)='' ) 

AS

	SELECT     dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, dbo.Vouchers.VoucherDate, dbo.Vouchers.Description, dbo.VoucherDetails.Reference, 
                      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo AND dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode INNER JOIN
	                      dbo.GetTransactionNatures(@TransactionNature, 'GL') GetTransactionNatures ON dbo.VoucherDetails.VoucherNature = GetTransactionNatures.NatureCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
	                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
	                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode
	WHERE dbo.Vouchers.VoucherNo BETWEEN @FromCode AND @ToCode AND
	dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicles]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectCOACombine]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectCOACombine]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) ='',
@GLCode as char(14)=''



AS


IF 	@Option='ALL' 
	Select * from GL_GetCOACombineTransactionVW
ELSE IF @Option='SRHGRID' 
	Select * from GL_GetCOACombineTransactionVW
ELSE IF @Option='CASHFLOW' AND @GLCode<>''
	Select * from GL_GetCOACombineVW
	WHERE LEFT(GlCode ,4)=@GLCode
ELSE IF @GlCode<>''
	Select * from GL_GetCOACombineTransactionVW
	WHERE GL_GetCOACombineTransactionVW.GLCode=@GLCode
GO
/****** Object:  StoredProcedure [dbo].[SelectCashFlowStatementReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE [dbo].[SelectCashFlowStatementReports]
CREATE PROCEDURE [dbo].[SelectCashFlowStatementReports]   -- ntype 0 3 1 4
@FromBranchCode varchar(10)='',  
@ToBranchCode varchar(10)='' , 
@FromDivisionCode varchar(10)='',  
@ToDivisionCode varchar(10)='' , 
@GLCode varchar(1000)='',  
--@ToGLCode varchar(50)='', 
@FromDate DateTime= NULL ,  
@ToDate DateTime= NULL, 
@nType bigint =0 , 
@VoucherNatureCode   varchar(100) = '' ,
@ReportSD as varchar ( 10 ) = 'DET' ,
@Posted bit = 1,
@PostedED bit = 0
AS
IF @nType = 0 --OPENING 1
	BEGIN			
	DECLARE @DocDate   as datetime
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
		DROP TABLE  TempCOAOpening
	END
	
	-- SELECT Division with Filter
	SELECT     DivisionCode as SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO 	#DivisionTAB
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX #IX_DivisionTAB ON #DivisionTAB ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
--select * from #TemCashCOAWithDetailTrans
/*
SELECT     VoucherDetails.VoucherNature, VoucherDetails.VoucherNo, VoucherDetails.Debit AS Expr5, 
                      VoucherDetails.Credit AS Expr6
FROM         VoucherDetails INNER JOIN
                      TempcashAccnts ON VoucherDetails.VoucherNature = TempcashAccnts.VoucherNature AND 
                      VoucherDetails.VoucherNo = TempcashAccnts.VoucherNo
ORDER BY VoucherDetails.VoucherNo */
	-- SELECT Branch with Filter
	SELECT     BranchCode as SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle 
	INTO #BranchTAB
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTAB ON #BranchTAB ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT GLAccount with Filter
	SELECT     GLCode as SysGLCode , GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle 
	INTO 	#COACombineLedTBRptVW
	FROM          dbo.GL_GetCOACombineLedTBRptVW
	--( ',' + @SupplierTypeCode + ',' LIKE '%,' + CAST( SupplierTypeCode  as varchar) + ',%' OR @SupplierTypeCode = '' )
	WHERE ',' + @GLCode + ',' LIKE '%,' + CAST(  dbo.GL_GetCOACombineLedTBRptVW.GLCode  as varchar) + ',%' OR @GLCode = ''     
	  
	CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	-- SELECT Last Closing Date For dbo.OpeningBalances Filter
	SELECT      dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode,  dbo.OpeningBalances.GLCode, 
	                      MAX( dbo.OpeningBalances.ClosingDate) AS ClosingDate 
	INTO #OpeningDate
	FROM          dbo.OpeningBalances INNER JOIN
	                      #BranchTAB ON  dbo.OpeningBalances.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
	                      #COACombineLedTBRptVW ON  dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.SysGLCode INNER JOIN
	                      #DivisionTAB ON  dbo.OpeningBalances.DivisionCode = #DivisionTAB.SysDivisionCode
	WHERE     ( dbo.OpeningBalances.ClosingDate <= @ToDate )
	GROUP BY  dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode,  dbo.OpeningBalances.GLCode
	CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	-- SELECT OpeningBalance From dbo.OpeningBalances With ClosingDate Filter
	SELECT      dbo.OpeningBalances.ClosingDate,  dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode, 
	       dbo.OpeningBalances.GLCode,  dbo.OpeningBalances.DebitBalance -  dbo.OpeningBalances.CreditBalance AS OpeningBalance 
	INTO #OpeningTAB
	FROM          dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON  dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
	       dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate AND 
	       dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode AND 
	       dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
	SELECT @DocDate = ISNULL( MIN(#OpeningDate.ClosingDate) , 0 ) + 1 FROM #OpeningDate
	--PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate 
	INTO #TransMaster
	FROM         dbo.Vouchers INNER JOIN
		#BranchTAB ON dbo.Vouchers.BranchCode = #BranchTAB.SysBranchCode
	WHERE     (dbo.Vouchers.VoucherDate BETWEEN @DocDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- SELECT Detail Transaction With Date
	SELECT     dbo.VoucherDetails.BranchCode, #TransMaster.VoucherDate, dbo.VoucherDetails.GLCode, 
		      dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit 
	INTO #TransDetail
	FROM         #TransMaster INNER JOIN
		      dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode AND 
		      #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
		      #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo INNER JOIN
		      #DivisionTAB ON dbo.VoucherDetails.DivisionCode = #DivisionTAB.SysDivisionCode 
	CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, DivisionCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- Select Transaction Balance
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, #TransDetail.Debit ,
		      #TransDetail.Credit, #TransDetail.Debit 
		      - #TransDetail.Credit AS TransBalance 
	INTO #TransBalTAB
	FROM         #TransDetail LEFT OUTER JOIN
		      #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode AND 
		      #TransDetail.VoucherDate > #OpeningDate.ClosingDate AND 
		      #TransDetail.GLCode = #OpeningDate.GLCode AND #TransDetail.DivisionCode = #OpeningDate.DivisionCode
	--GROUP BY #TransDetail.BranchCode, #TransDetail.Division, #TransDetail.GLCode
	
	---   Final Opening Balance 
	SELECT     BranchCode, DivisionCode, GLCode, SUM(OpeningBalance) AS OpeningBalance INTO #TransTAB
	FROM         (SELECT     BranchCode, DivisionCode, GLCode, OpeningBalance
	                       FROM          #OpeningTAB
	                       UNION ALL
	                       SELECT     BranchCode, DivisionCode, GLCode, TransBalance
	                       FROM         #TransBalTAB) TransTAB
	GROUP BY BranchCode, DivisionCode, GLCode
	
	--- Final Opening Balance With Titles
	SELECT     #BranchTAB.BranchCode, #BranchTAB.BranchRptTitle, #DivisionTAB.DivisionCode, 
		      #DivisionTAB.DivisionRptTitle, #COACombineLedTBRptVW.GLCode, #COACombineLedTBRptVW.GLRptTitle, 
		      #COACombineLedTBRptVW.ControlCode, #COACombineLedTBRptVW.ControlRptTitle, 
		      #COACombineLedTBRptVW.GeneralCode, #COACombineLedTBRptVW.GeneralRptTitle, 
		      #COACombineLedTBRptVW.SubSidiaryCode, #COACombineLedTBRptVW.SubsidiaryRptTitle, 
		      #COACombineLedTBRptVW.SubsubCode, #COACombineLedTBRptVW.SubSubRptTitle, 
		      #TransTAB.OpeningBalance INTO TempCOAOpening
	FROM         #TransTAB INNER JOIN
		      #BranchTAB ON #TransTAB.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
		      #DivisionTAB ON #TransTAB.DivisionCode = #DivisionTAB.SysDivisionCode INNER JOIN
		      #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.SysGLCode
	WHERE     #TransTAB.OpeningBalance <> 0
	END
ELSE IF @nType =1			--Account Ledger ALL Transaction 
	BEGIN
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailCF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		DROP TABLE  TempTransDetailCF
		END
	SELECT     DivisionCode as SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO 	#DivisionTABT
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX [#IX_DivisionTABT ] ON #DivisionTABT ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	SELECT    BranchCode as  SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle INTO #BranchTABT
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTABT ON #BranchTABT ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]	
	
	SELECT    GLCode as  SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, '1' as  ApplyGrouping,
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle INTO #COACombineLedTBRptVWT
	FROM          dbo.GL_GetCOACombineLedTBRptVW
	
	
	--WHERE ',' + @GLCode + ',' LIKE '%,' + CAST(  GetCOACombineLedTBRptVW.GLCode  as varchar) + ',%' OR @GLCode = ''     
	
	CREATE INDEX #IX_COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT    NatureCode as  SysNatureCode, NatureCode, Nature, Nature  AS NatureRptTitle INTO #NatureTABT
	FROM          dbo.TransactionNatures 
	WHERE ',' + @VoucherNatureCode + ',' LIKE '%,' + CAST( NatureCode as varchar) + ',%' OR @VoucherNatureCode = ''
	CREATE INDEX #IX_NatureTABT ON #NatureTABT ( NatureCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate, dbo.Vouchers.Description as Narration, dbo.Vouchers.RecordNo, dbo.Vouchers.OldRef ,
		dbo.Vouchers.Posted, dbo.Vouchers.Locked 
	INTO #TransMasterT
	FROM         dbo.Vouchers INNER JOIN
		#BranchTABT ON dbo.Vouchers.BranchCode = #BranchTABT.SysBranchCode
	WHERE     (dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	
	CREATE INDEX #IX_TransMasterT ON #TransMasterT ( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
-----Shamim
	SELECT     VoucherDetails.BranchCode, VoucherDetails.VoucherNature, VoucherDetails.VoucherNo
                      
INTO #TemCashCOAWithDetailTrans
FROM         VoucherDetails LEFT OUTER JOIN
                      #COACombineLedTBRptVWT ON VoucherDetails.GLCode = #COACombineLedTBRptVWT.SysGLCode
--WHERE     (#COACombineLedTBRptVWT.GLCode LIKE  '1501%')
 
 WHERE ',' + @GLCode  + ',' LIKE '%,' + CAST( #COACombineLedTBRptVWT.GLCode  as varchar) + ',%' 
 
 CREATE INDEX #IX_TemCashCOAWithDetailTrans ON #TemCashCOAWithDetailTrans( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     #BranchTABT.BranchCode, #BranchTABT.BranchRptTitle, #DivisionTABT.DivisionCode, #DivisionTABT.DivisionRptTitle, 
		#COACombineLedTBRptVWT.GLCode, #COACombineLedTBRptVWT.GLRptTitle, #NatureTABT.NatureCode, 
		#NatureTABT.NatureRptTitle, #TransMasterT.VoucherDate, dbo.VoucherDetails.VoucherNo, #TransMasterT.OldRef , 
		dbo.VoucherDetails.Narration, #TransMasterT.Narration AS NarrationMain, #TransMasterT.RecordNo, 
		dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, 
		#COACombineLedTBRptVWT.ControlCode, #COACombineLedTBRptVWT.ControlRptTitle, 
		#COACombineLedTBRptVWT.GeneralCode, #COACombineLedTBRptVWT.GeneralRptTitle, 
		#COACombineLedTBRptVWT.SubSidiaryCode, #COACombineLedTBRptVWT.SubsidiaryRptTitle, 
		#COACombineLedTBRptVWT.SubsubCode, #COACombineLedTBRptVWT.SubSubRptTitle, #COACombineLedTBRptVWT.ApplyGrouping, #TransMasterT.Posted, 
		#TransMasterT.Locked, dbo.VoucherDetails.RecordNo AS DetailRecordNo
	INTO TempTransDetailCF
	FROM         dbo.VoucherDetails INNER JOIN
		      #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.SysNatureCode INNER JOIN
		      #BranchTABT ON dbo.VoucherDetails.BranchCode = #BranchTABT.SysBranchCode INNER JOIN
		      #DivisionTABT ON dbo.VoucherDetails.DivisionCode = #DivisionTABT.SysDivisionCode INNER JOIN
		      #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.SysGLCode INNER JOIN
		      #TransMasterT ON dbo.VoucherDetails.BranchCode = #TransMasterT.BranchCode AND 
		      dbo.VoucherDetails.VoucherNature = #TransMasterT.VoucherNature AND 
		      dbo.VoucherDetails.VoucherNo = #TransMasterT.VoucherNo INNER JOIN
              #TemCashCOAWithDetailTrans ON VoucherDetails.VoucherNature = #TemCashCOAWithDetailTrans.VoucherNature AND 
              VoucherDetails.VoucherNo = #TemCashCOAWithDetailTrans.VoucherNo and VoucherDetails.BranchCode = #TemCashCOAWithDetailTrans.BranchCode
	--select * from TempTransDetail	
	END
	
	
ELSE IF @nType  = 3		--  GET COA Opening FROM TempTAB
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TempCOAOpening
		DROP TABLE  TempCOAOpening
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
ELSE IF @nType  = 4		--  GET Transaction Detail
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailCF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TempTransDetailCF 
		ORDER BY BranchCode, GLCode, VoucherDate, RecordNo 
		--DROP TABLE  TempTransDetailCF
		END
   
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
GO
/****** Object:  StoredProcedure [dbo].[SelectBranches]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectBranches]
@Option as  varchar(20)='',
@BranchCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
			dbo.GL_GetCOACombineVW.GLDescription
		FROM         dbo.Branches LEFT OUTER JOIN
			dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
ELSE IF @Option='SRHGRID'
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
                      dbo.GL_GetCOACombineVW.GLDescription
	FROM         dbo.Branches LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
	ORDER BY dbo.Branches.BranchCode
ELSE
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
                      dbo.GL_GetCOACombineVW.GLDescription
	FROM         dbo.Branches LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
        WHERE dbo.Branches.BranchCode =@BranchCode
GO
/****** Object:  View [dbo].[QryOtherAmountExcInvoice]    Script Date: 12/01/2017 23:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QryOtherAmountExcInvoice]
AS
SELECT     VoucherDetails_1.VoucherNature, VoucherDetails_1.Debit, VoucherDetails_1.Credit, VoucherDetails_1.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription,
                       dbo.GL_GetCOACombineTransactionVW.GLCode AS Expr1, dbo.Vouchers.VoucherDate
FROM         dbo.GL_GetCOACombineTransactionVW INNER JOIN
                      dbo.VoucherDetails VoucherDetails_1 ON dbo.GL_GetCOACombineTransactionVW.GLCode = VoucherDetails_1.GLCode INNER JOIN
                      dbo.Vouchers ON VoucherDetails_1.BranchCode = dbo.Vouchers.BranchCode AND VoucherDetails_1.VoucherNature = dbo.Vouchers.VoucherNature AND 
                      VoucherDetails_1.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                      dbo.VoucherDetails VoucherDetails_2 ON VoucherDetails_1.VoucherNo = VoucherDetails_2.VoucherNo AND 
                      VoucherDetails_1.BranchCode = VoucherDetails_2.BranchCode AND VoucherDetails_1.VoucherNature = VoucherDetails_2.VoucherNature
WHERE     (dbo.GL_GetCOACombineTransactionVW.GLCode <> '020100010001') AND (VoucherDetails_2.GLCode = '020100010001') AND 
                      (dbo.GL_GetCOACombineTransactionVW.GLCode <> '010100010001')
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleAdjustmentsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVehicleAdjustmentsDetails]

@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@BranchCode as varchar(10) ='',
@TransactionNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM VocherDetails 
ELSE
	DELETE FROM VehicleAdjustmentDetails  
	WHERE 
	VehicleAdjustmentNature=@TransactionNature AND VehicleAdjustmentNo=@TransactionNo and BranchCode= @BranchCode
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleAdjustments]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[DeleteVehicleAdjustments]
    @Option AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = ''
AS 
    DECLARE @RefNo AS CHAR(10)
    

    SELECT TOP 1
            @RefNo = ISNULL( TripAdvanceReference,'')
    FROM    dbo.Invoices
    WHERE   BranchCode = @BranchCode
            AND TripAdvanceReference = @TransactionNo AND @TransactionNature='VP'
	
    IF  ISNULL(@RefNo,'') <> '' 
        BEGIN
            
            RAISERROR ( 'The Adjustment Code is exist already in some Invoices therefor can not deleted',
                16, 1, '', '', '' )

            RETURN ( 99 )	
             
        END
    ELSE 
        BEGIN 
            BEGIN TRANSACTION
            DELETE  FROM VehicleAdjustmentDetails
            
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
                    
                    
            --DELETE  FROM VehicleAdjustments
            UPDATE dbo.VehicleAdjustments
            SET
            Description='This Document has been Deleted',
            UrduTitle=''
            
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
            COMMIT TRANSACTION
        END

    

    IF @@error > 0 
        ROLLBACK TRANSACTION
GO
/****** Object:  StoredProcedure [dbo].[SelectPosting]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SelectPosting]
@PostingDate  Datetime = '01 Feb 2006' ,
@Debitors as varchar(12)='',
@Creditors as varchar(12)='',
@nType int = 0

AS

DECLARE @DuplicateInvoices	as varchar(50)
DECLARE @EmptyInvoiceNo 	as varchar(50)
DECLARE @PaymentWithoutInvoiceNo	as varchar(50)
DECLARE @PaymentExced	as varchar(50)

SET @PaymentWithoutInvoiceNo = 'Payment Invoice No. doesn''t exist'
SET @EmptyInvoiceNo = 'Empty Invoice No.' 
SET @DuplicateInvoices = 'Duplication of Invoice No.'	
SET @PaymentExced = 'Payment excess from Invoice'  



--SELECT @Debitors = nValue from SetupProfileTAB WHERE FieldName = 'Debitors'
--SELECT @Creditors = nValue from SetupProfileTAB WHERE FieldName = 'Creditors'


IF @nType = 1
	BEGIN
		SELECT     MAX(VoucherDate) AS ClosingDate
		FROM         dbo.Vouchers
		WHERE  Posted = 1
	END
ELSE IF @nType = 2
	BEGIN

-- ######################## START #COACombinePTAB
SELECT     GLCode as SysGLCode, GLCode, GLDescription,  GLDescription as ReportTitle 
INTO 	#COACombinePTAB
FROM       GL_GetCOACombineTransactionVW
WHERE     (GLCode LIKE @Debitors + '%') OR (GLCode LIKE @Creditors + '%')
-- ######################## END

CREATE INDEX #IX_SysCOACombinePTAB ON #COACombinePTAB ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_UDCOACombinePTAB ON #COACombinePTAB ( GLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
	DROP TABLE  TEMP_PostingResult
	END
-- ######################## START #ALL_InvoiceTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
                      dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
                      AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, SUM(ISNULL(dbo.UsedTransactionsDetail.AmountUsed, 
                      0)) AS AmountUsed, dbo.Vouchers.RecordNo 
INTO TEMP_PostingResult
FROM         dbo.VoucherDetails LEFT OUTER JOIN
                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                      dbo.UsedTransactionsDetail ON dbo.VoucherDetails.BranchCode = dbo.UsedTransactionsDetail.BranchCode AND 
                      dbo.VoucherDetails.GLCode = dbo.UsedTransactionsDetail.GLCode AND 
                      dbo.VoucherDetails.Reference = dbo.UsedTransactionsDetail.BillNo LEFT OUTER JOIN
                      #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
                      dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, dbo.Vouchers.CreditDays, 
                      dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, dbo.Vouchers.RecordNo
HAVING   
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Debit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Credit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	/*AND  
               ((dbo.VoucherDetails.Debit + dbo.VoucherDetails.Credit ) > SUM(ISNULL(dbo.UsedTransactionsDetail.AmountUsed, 0))) AND 
               ( dbo.Vouchers.VoucherDate <= @PostingDate )*/
-- ######################## END



-- ######################## START #UP_InvoicePaymentTAB
INSERT INTO TEMP_PostingResult
SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit, 
              dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, 0 AS AmountUsed, 
              dbo.Vouchers.RecordNo
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	AND
            (dbo.Vouchers.VoucherDate <= @PostingDate ) AND (dbo.Vouchers.Posted = 0)
-- ######################## END

-- ######################## START #P_InvoicePaymentTAB
INSERT INTO TEMP_PostingResult
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, 
              SUM(dbo.VoucherDetails.Debit) AS Debit, SUM(dbo.VoucherDetails.Credit) AS Credit, 
              #COACombinePTAB.GLCode, DetailTransactionUsed.AmountUsed AS AmountUsed, dbo.Vouchers.RecordNo 
FROM         dbo.VoucherDetails LEFT OUTER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                  ( SELECT     BranchCode, RefVoucherNature, RefVoucherNo, GLCode, RefVoucherDate, RefBillNo, SUM(AmountUsed) AS AmountUsed
                    FROM          dbo.UsedTransactionsDetail
                    GROUP BY BranchCode, RefVoucherNature, RefVoucherNo, GLCode, RefVoucherDate, RefBillNo) DetailTransactionUsed ON 
              dbo.VoucherDetails.BranchCode = DetailTransactionUsed.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = DetailTransactionUsed.RefVoucherNature AND 
              dbo.VoucherDetails.VoucherNo = DetailTransactionUsed.RefVoucherNo AND 
              dbo.VoucherDetails.GLCode = DetailTransactionUsed.GLCode AND 
              dbo.VoucherDetails.Reference = DetailTransactionUsed.RefBillNo LEFT OUTER JOIN
              #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
WHERE
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	AND      (dbo.Vouchers.Posted = 1 ) 
GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0), 
              dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode, #COACombinePTAB.GLCode, 
              DetailTransactionUsed.AmountUsed, dbo.Vouchers.RecordNo
HAVING  ( SUM(dbo.VoucherDetails.Debit) + SUM(dbo.VoucherDetails.Credit) > DetailTransactionUsed.AmountUsed )

-- ######################## END

	END

ELSE IF @nType = 3 	-- GET FOR POSTING
	BEGIN

	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TEMP_PostingResult
		ORDER BY BranchCode, GLCode, VoucherDate 
		DROP TABLE  TEMP_PostingResult
		END
	ELSE
		BEGIN
			SELECT      0 AS SysBranchCode, '' AS BranchCode, '' AS Branch, 
				'' AS SysNatureCode, '' AS NatureCode, '' AS Nature, 0 AS DisplayNode, 
				0 AS IsPaymentVoucher, '' AS VoucherNo, '01 Jan 2004' AS VoucherDate, 
				'' AS Reference, 0 AS CrditDays, 0 AS SysGLCode, '' AS GLCode, '' AS GLDescription, 
				'' AS InvoiceAmount, 0 AS PaymentAmount  
			WHERE 0 = 1
		END
	END

ELSE IF @nType = 4 	-- GET AUDIT FOR ALL   -- 	
	BEGIN

	DECLARE @AuditResult TABLE
	   (
		BranchCode  char(3) , 
		VoucherNature  char(10) , 
		VoucherNo  varchar(10),  
		VoucherDate  datetime , 
		Reference  varchar(50), 
		CrditDays  int,
		SysGLCode char (14),
		InvoiceAmount Decimal(20,5),
	 	PaymentAmount Decimal(20,5),
		ErrorDesc varchar(50)
	   )		

/*
CREATE INDEX #IX_AuditResultBranch ON @AuditResult ( BranchCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_AuditResultGLCode ON @AuditResult ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_AuditResultNature ON @AuditResult ( VoucherNature )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
*/

-- ######################## START #COACombineTAB
SELECT     GLCode as SysGLCode, GLCode, GLDescription, GLDescription as ReportTitle INTO #COACombineTAB
FROM       dbo.GL_GetCOACombineTransactionVW
WHERE     (GLCode LIKE @Debitors + '%') OR (GLCode LIKE @Creditors + '%')
-- ######################## END

CREATE INDEX #IX_#SysCOACombineTAB ON #COACombineTAB ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_UDCOACombineTAB ON #COACombineTAB ( GLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## START #ALL_InvoiceTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit + 
              dbo.VoucherDetails.Credit AS InvoiceAmount 
INTO 	#ALL_InvoiceTAB
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombineTAB ON dbo.VoucherDetails.GLCode = #COACombineTAB.SysGLCode 
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Debit > 0)  AND (#COACombineTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Credit > 0) AND (#COACombineTAB.GLCode LIKE @Creditors + '%') )
	)	AND 	(dbo.Vouchers.VoucherDate <= @PostingDate ) 

CREATE INDEX #IX_ALL_InvoiceTAB ON #ALL_InvoiceTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## END


-- ######################## START #UP_InvoicePaymentTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
	dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, dbo.VoucherDetails.GLCode AS SysGLCode, 
	dbo.VoucherDetails.Debit + dbo.VoucherDetails.Credit AS PaymentAmount 
INTO 	#UP_InvoicePaymentTAB
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombineTAB ON dbo.VoucherDetails.GLCode = #COACombineTAB.SysGLCode 
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombineTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombineTAB.GLCode LIKE @Creditors + '%') )
	)	AND 	(dbo.Vouchers.VoucherDate <= @PostingDate ) 
		AND 	(dbo.Vouchers.Posted = 0 ) 

CREATE INDEX #IX_UP_InvoicePaymentTAB ON #UP_InvoicePaymentTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END


-- ######################## START #Duplicate_InvoiceNoTAB
SELECT BranchCode, Reference, SysGLCode 
INTO 	#Duplicate_InvoiceNoTAB
FROM #ALL_InvoiceTAB
GROUP BY BranchCode, SysGLCode, Reference 
HAVING Count( SysGLCode ) > 1

CREATE INDEX #IX_Duplicate_InvoiceNoTAB ON #Duplicate_InvoiceNoTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## END

-- ######################## START #Tot_InvoicePaymentTAB
SELECT     BranchCode, Reference, SysGLCode, SUM(PaymentAmount) AS PaymentAmount 
INTO 	#Tot_InvoicePaymentTAB
FROM (	SELECT     BranchCode, Reference, SysGLCode, SUM(PaymentAmount) AS PaymentAmount
	FROM         #UP_InvoicePaymentTAB
	GROUP BY BranchCode, Reference, SysGLCode
	UNION ALL
	SELECT     BranchCode, BillNo, GLCode, SUM(AmountUsed) AS PaymentAmount
	FROM         dbo.UsedTransactionsDetail
	GROUP BY BranchCode, BillNo, GLCode ) TotPayments
GROUP BY BranchCode, Reference, SysGLCode

CREATE INDEX #IX_Tot_InvoicePaymentTAB ON #Tot_InvoicePaymentTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END

-- ######################## START #AExcess_InvoiceNoTAB
SELECT     #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.Reference, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount 
INTO 	#AExcess_InvoiceNoTAB
FROM    #ALL_InvoiceTAB INNER JOIN
	#Tot_InvoicePaymentTAB ON #ALL_InvoiceTAB.BranchCode = #Tot_InvoicePaymentTAB.BranchCode AND 
	#ALL_InvoiceTAB.Reference = #Tot_InvoicePaymentTAB.Reference AND 
	#ALL_InvoiceTAB.SysGLCode = #Tot_InvoicePaymentTAB.SysGLCode AND 
	#ALL_InvoiceTAB.InvoiceAmount < #Tot_InvoicePaymentTAB.PaymentAmount

CREATE INDEX #IX_AExcess_InvoiceNoTAB ON #AExcess_InvoiceNoTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END

-- ######################## START 
-- ######################## DUPLICATE INVOICE
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT  #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.VoucherNature, 
		#ALL_InvoiceTAB.VoucherNo, #ALL_InvoiceTAB.VoucherDate, #ALL_InvoiceTAB.Reference, 
		#ALL_InvoiceTAB.CreditDays, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount, 
		0 AS PaymentAmount, @DuplicateInvoices as ErrorDesc 
	FROM #ALL_InvoiceTAB INNER JOIN #Duplicate_InvoiceNoTAB ON
		#ALL_InvoiceTAB.BranchCode = #Duplicate_InvoiceNoTAB.BranchCode AND
		#ALL_InvoiceTAB.Reference = #Duplicate_InvoiceNoTAB.Reference AND
		#ALL_InvoiceTAB.SysGLCode = #Duplicate_InvoiceNoTAB.SysGLCode
-- ######################## DUPLICATE INVOICE
-- ######################## END 

-- ######################## START 
-- ######################## EMPTY INVOICE NO
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT  #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.VoucherNature, 
		#ALL_InvoiceTAB.VoucherNo, #ALL_InvoiceTAB.VoucherDate, #ALL_InvoiceTAB.Reference, 
		#ALL_InvoiceTAB.CreditDays, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount, 
		0 AS PaymentAmount, @EmptyInvoiceNo  as ErrorDesc 
	FROM #ALL_InvoiceTAB 
	WHERE #ALL_InvoiceTAB.Reference = ''
-- ######################## EMPTY INVOICE NO
-- ######################## END 


-- ######################## START 
-- ######################## PAYMENT INVOICE NO MISMATCH
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT     #UP_InvoicePaymentTAB.BranchCode, #UP_InvoicePaymentTAB.VoucherNature, #UP_InvoicePaymentTAB.VoucherNo, #UP_InvoicePaymentTAB.VoucherDate, 
		#UP_InvoicePaymentTAB.Reference, #ALL_InvoiceTAB.CreditDays, #UP_InvoicePaymentTAB.SysGLCode, 0 AS InvoiceAmount, #UP_InvoicePaymentTAB.PaymentAmount,
		@PaymentWithoutInvoiceNo as ErrorDesc 		
	FROM         #ALL_InvoiceTAB RIGHT OUTER JOIN
	                      #UP_InvoicePaymentTAB ON #ALL_InvoiceTAB.SysGLCode = #UP_InvoicePaymentTAB.SysGLCode AND 
	                      #ALL_InvoiceTAB.BranchCode = #UP_InvoicePaymentTAB.BranchCode AND 
	                      #ALL_InvoiceTAB.Reference = #UP_InvoicePaymentTAB.Reference
	WHERE     (#ALL_InvoiceTAB.InvoiceAmount IS NULL) AND (#UP_InvoicePaymentTAB.Reference <> '')
-- ######################## PAYMENT INVOICE NO MISMATCH
-- ######################## END


-- ######################## START 
-- ######################## PAYMENT EXCESS FROM INVOICE
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT     #UP_InvoicePaymentTAB.BranchCode, #UP_InvoicePaymentTAB.VoucherNature, #UP_InvoicePaymentTAB.VoucherNo, #UP_InvoicePaymentTAB.VoucherDate, 
		#UP_InvoicePaymentTAB.Reference, 0 as CreditDays, #UP_InvoicePaymentTAB.SysGLCode, #AExcess_InvoiceNoTAB.InvoiceAmount AS InvoiceAmount, #UP_InvoicePaymentTAB.PaymentAmount,
		@PaymentExced as ErrorDesc 		
	FROM  #AExcess_InvoiceNoTAB INNER JOIN
		#UP_InvoicePaymentTAB ON #AExcess_InvoiceNoTAB.SysGLCode = #UP_InvoicePaymentTAB.SysGLCode AND 
		#AExcess_InvoiceNoTAB.Reference = #UP_InvoicePaymentTAB.Reference AND
		#AExcess_InvoiceNoTAB.BranchCode = #UP_InvoicePaymentTAB.BranchCode
	WHERE     (#UP_InvoicePaymentTAB.Reference <> '')
-- ######################## PAYMENT EXCESS FROM INVOICE
-- ######################## END

-- ######################## START AUDIT RESULT

IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
	DROP TABLE  TEMP_PostingResult
	END

SELECT     AuditResult.ErrorDesc , AuditResult.BranchCode AS SysBranchCode, dbo.Branches.BranchCode, dbo.Branches.BranchDescription as Branch, 
      AuditResult.VoucherNature AS SysNatureCode, dbo.TransactionNatures.NatureCode, dbo.TransactionNatures.Nature, 
      dbo.TransactionNatures.IsPaymentVoucher, AuditResult.VoucherNo, AuditResult.VoucherDate, AuditResult.Reference, 
      AuditResult.CrditDays, AuditResult.SysGLCode, #COACombineTAB.GLCode, 
      #COACombineTAB.GLDescription, AuditResult.InvoiceAmount, AuditResult.PaymentAmount  
INTO TEMP_PostingResult
FROM         @AuditResult AuditResult LEFT OUTER JOIN
      #COACombineTAB ON AuditResult.SysGLCode = #COACombineTAB.SysGLCode LEFT OUTER JOIN
      dbo.TransactionNatures ON AuditResult.VoucherNature = dbo.TransactionNatures.NatureCode LEFT OUTER JOIN
      dbo.Branches ON AuditResult.BranchCode = dbo.Branches.BranchCode 
-- ######################## END AUDIT RESULT


/*
-- TEMP CODE
DROP TABLE #COACombineTAB
DROP TABLE #ALL_InvoiceTAB
DROP TABLE #UP_InvoicePaymentTAB
DROP TABLE #Tot_InvoicePaymentTAB
DROP TABLE #Duplicate_InvoiceNoTAB
DROP TABLE #AExcess_InvoiceNoTAB
*/

	END

ELSE IF @nType  = 5
	BEGIN

	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TEMP_PostingResult
		DROP TABLE  TEMP_PostingResult
		END
	ELSE
		BEGIN
			SELECT     '' AS ErrorDesc , 0 AS SysBranchCode, '' AS BranchCode, '' AS Branch, 
				'' AS SysNatureCode, '' AS NatureCode, '' AS Nature, 0 AS DisplayNode, 
				0 AS IsPaymentVoucher, '' AS VoucherNo, '01 Jan 2004' AS VoucherDate, 
				'' AS Reference, 0 AS CrditDays, 0 AS SysGLCode, '' AS GLCode, '' AS GLDescription, 
				'' AS InvoiceAmount, 0 AS PaymentAmount  
			WHERE 0 = 1
		END
	END

ELSE IF @nType  = 6 		-- OPENING BALANCE
	BEGIN
	SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.DivisionCode as Division, dbo.VoucherDetails.GLCode, 
	                      SUM(dbo.VoucherDetails.Debit) AS DebitSum, SUM(dbo.VoucherDetails.Credit) AS CreditSum
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.GLCode
	END
GO
/****** Object:  StoredProcedure [dbo].[SelectOpeningBalances]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectOpeningBalances]
@Option as  varchar(20)='',
@BranchCode as varchar(10) ='',
@ClosingDate as datetime=''

AS

IF @Option='ALL' 
		SELECT     dbo.OpeningBalances.ClosingDate,dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, 
                      dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
FROM         dbo.OpeningBalances LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode
ELSE IF @Option='SRHGRID'
	SELECT * FROM OpeningBalances
ELSE
		SELECT     dbo.OpeningBalances.ClosingDate, dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, 
                      dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
FROM         dbo.OpeningBalances LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode
WHERE ClosingDate=@ClosingDate AND dbo.OpeningBalances.Branchcode=@BranchCode
GO
/****** Object:  StoredProcedure [dbo].[SelectListReports]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectGeneralLedgerReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectGeneralLedgerReports]
    @FromBranchCode VARCHAR(10) = '' ,
    @ToBranchCode VARCHAR(10) = '' ,
    @FromDivisionCode VARCHAR(10) = '' ,
    @ToDivisionCode VARCHAR(10) = '' ,
    @FromGLCode VARCHAR(50) = '' ,
    @ToGLCode VARCHAR(50) = '' ,
    @FromDate DATETIME = NULL ,
    @ToDate DATETIME = NULL ,
    @nType BIGINT = 0 ,
    @VoucherNatureCode VARCHAR(100) = '' ,
    @ReportSD AS VARCHAR(10) = 'DET' ,
    @Posted BIT = 1 ,
    @PostedED BIT = 0
AS 
    IF @nType = 0 --OPENING 1
        BEGIN			
            DECLARE @DocDate AS DATETIME
	
            IF EXISTS ( SELECT  *
                        FROM    sysobjects
                        WHERE   ID = OBJECT_ID(N'TempCOAOpeningLedger')
                                AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                BEGIN
                    DROP TABLE  TempCOAOpeningLedger
                END
	
	-- SELECT Division with Filter
            SELECT  DivisionCode AS SysDivisionCode ,
                    DivisionCode ,
                    Division ,
                    Division AS DivisionRptTitle
            INTO    #Divisions
            FROM    dbo.Divisions
            WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                 AND     @ToDivisionCode )
	
            CREATE INDEX #IX_Divisions ON #Divisions (   DivisionCode )
            WITH   SORT_IN_TEMPDB
            ON [PRIMARY]
	-- SELECT Branch with Filter
            SELECT  BranchCode AS SysBranchCode ,
                    BranchCode ,
                    BranchDescription AS Branch ,
                    BranchDescription AS BranchRptTitle
            INTO    #Branches
            FROM    dbo.Branches
            WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                              AND     @ToBranchCode )
	
            CREATE INDEX #IX_Branches ON #Branches (   BranchCode )
            WITH   SORT_IN_TEMPDB
            ON [PRIMARY]
	-- SELECT GLAccount with Filter
            SELECT  GLCode ,
                    GLRptTitle ,
                    ControlCode ,
                    ControlRptTitle ,
                    GeneralCode ,
                    GeneralRptTitle ,
                    SubSidiaryCode ,
                    SubsidiaryRptTitle ,
                    SubsubCode ,
                    SubSubRptTitle
            INTO    #COACombineLedTBRptVW
            FROM    dbo.GL_GetCOACombineLedTBRptVW
            WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                            AND
                                                              @ToGLCode )
	
            CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW (   GLCode )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode ,
                    MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.OpeningBalances
                    INNER JOIN #Branches ON dbo.OpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #COACombineLedTBRptVW ON dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.GLCode
                    INNER JOIN #Divisions ON dbo.OpeningBalances.DivisionCode = #Divisions.DivisionCode
            WHERE   ( dbo.OpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.OpeningBalances.ClosingDate ,
                    dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode ,
                    dbo.OpeningBalances.DebitBalance
                    - dbo.OpeningBalances.CreditBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.OpeningBalances
                    INNER JOIN #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode
                                               AND dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
	--PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.Vouchers.BranchCode ,
                    dbo.Vouchers.VoucherNature ,
                    dbo.Vouchers.VoucherNo ,
                    dbo.Vouchers.VoucherDate
            INTO    #TransMaster
            FROM    dbo.Vouchers
                    INNER JOIN #Branches ON dbo.Vouchers.BranchCode = #Branches.BranchCode
            WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @DocDate
                                               AND     @ToDate )
                    AND ( dbo.Vouchers.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]	
	-- SELECT Detail Transaction With Date
            SELECT  dbo.VoucherDetails.BranchCode ,
                    #TransMaster.VoucherDate ,
                    dbo.VoucherDetails.GLCode ,
                    dbo.VoucherDetails.DivisionCode AS Division ,
                    dbo.VoucherDetails.Debit ,
                    dbo.VoucherDetails.Credit
            INTO    #TransDetail
            FROM    #TransMaster
                    INNER JOIN dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode
                                                     AND #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature
                                                     AND #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo
                    INNER JOIN #Divisions ON dbo.VoucherDetails.DivisionCode = #Divisions.DivisionCode
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, Division )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]	
	-- Select Transaction Balance
            SELECT  #TransDetail.BranchCode ,
                    #TransDetail.Division ,
                    #TransDetail.GLCode ,
                    SUM(#TransDetail.Debit) - SUM(#TransDetail.Credit) AS TransBalance
            INTO    #TransBalTAB
            FROM    #TransDetail
                    LEFT OUTER JOIN #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode
                                                    AND #TransDetail.VoucherDate > #OpeningDate.ClosingDate
                                                    AND #TransDetail.GLCode = #OpeningDate.GLCode
                                                    AND #TransDetail.Division = #OpeningDate.DivisionCode
            GROUP BY #TransDetail.BranchCode ,
                    #TransDetail.Division ,
                    #TransDetail.GLCode
	
	---   Final Opening Balance 
            SELECT  BranchCode ,
                    DivisionCode ,
                    GLCode ,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode ,
                                DivisionCode ,
                                GLCode ,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode ,
                                Division ,
                                GLCode ,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode ,
                    DivisionCode ,
                    GLCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode ,
                    #Branches.BranchRptTitle ,
                    #Divisions.DivisionCode ,
                    #Divisions.DivisionRptTitle ,
                    #COACombineLedTBRptVW.GLCode ,
                    #COACombineLedTBRptVW.GLRptTitle ,
                    #COACombineLedTBRptVW.ControlCode ,
                    #COACombineLedTBRptVW.ControlRptTitle ,
                    #COACombineLedTBRptVW.GeneralCode ,
                    #COACombineLedTBRptVW.GeneralRptTitle ,
                    #COACombineLedTBRptVW.SubSidiaryCode ,
                    #COACombineLedTBRptVW.SubsidiaryRptTitle ,
                    #COACombineLedTBRptVW.SubsubCode ,
                    #COACombineLedTBRptVW.SubSubRptTitle ,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpeningLedger
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #Divisions ON #TransTAB.DivisionCode = #Divisions.DivisionCode
                    INNER JOIN #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.GLCode
            WHERE   #TransTAB.OpeningBalance <> 0
        END
    ELSE 
        IF @nType = 1			--Account Ledger ALL Transaction 
            BEGIN
	
                IF EXISTS ( SELECT  *
                            FROM    sysobjects
                            WHERE   ID = OBJECT_ID(N'TempTransDetailLedger')
                                    AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                    BEGIN
                        DROP TABLE  TempTransDetailLedger
                    END
                SELECT  DivisionCode AS SysDivisionCode ,
                        DivisionCode ,
                        Division ,
                        Division AS DivisionRptTitle
                INTO    #DivisionsT
                FROM    dbo.Divisions
                WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                     AND     @ToDivisionCode )
	
                CREATE INDEX [#IX_DivisionsT ] ON #DivisionsT (   DivisionCode )
                WITH   SORT_IN_TEMPDB
                ON [PRIMARY]
                SELECT  BranchCode AS SysBranchCode ,
                        BranchCode ,
                        BranchDescription AS Branch ,
                        BranchDescription AS BranchRptTitle
                INTO    #BranchesT
                FROM    dbo.Branches
                WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                                  AND     @ToBranchCode )
	
                CREATE INDEX #IX_BranchesT ON #BranchesT (   BranchCode )
                WITH   SORT_IN_TEMPDB
                ON [PRIMARY]	
	
                SELECT  GLCode ,
                        GLRptTitle ,
                        ControlCode ,
                        ControlRptTitle ,
                        GeneralCode ,
                        GeneralRptTitle ,
                        SubSidiaryCode ,
                        SubsidiaryRptTitle ,
                        SubsubCode ,
                        SubSubRptTitle
                INTO    #COACombineLedTBRptVWT
                FROM    dbo.GL_GetCOACombineLedTBRptVW
                WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                              AND
                                                              @ToGLCode )
                CREATE INDEX #IX_COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( GLCode )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]
	
                SELECT  NatureCode AS SysNatureCode ,
                        NatureCode ,
                        Nature ,
                        Nature AS NatureRptTitle
                INTO    #NatureTABT
                FROM    dbo.TransactionNatures
                WHERE   ',' + @VoucherNatureCode + ',' LIKE '%,'
                        + CAST(NatureCode AS VARCHAR) + ',%'
                        OR @VoucherNatureCode = ''
                CREATE INDEX #IX_NatureTABT ON #NatureTABT (   NatureCode )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]

                SELECT  dbo.Vouchers.BranchCode ,
                        dbo.Vouchers.VoucherNature ,
                        dbo.Vouchers.VoucherNo ,
                        dbo.Vouchers.VoucherDate ,
                        dbo.Vouchers.Description ,
                        dbo.Vouchers.RecordNo ,
                        dbo.Vouchers.OldRef ,
                        dbo.Vouchers.Posted ,
                        dbo.Vouchers.Locked
                INTO    #TransMasterT
                FROM    dbo.Vouchers
                        INNER JOIN #BranchesT ON dbo.Vouchers.BranchCode = #BranchesT.BranchCode
                WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                   AND     @ToDate )
                        AND ( dbo.Vouchers.Posted = @Posted
                              OR @PostedED = 0
                            ) 
	
                CREATE INDEX #IX_TransMasterT ON #TransMasterT ( BranchCode, VoucherNature, VoucherNo )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]


                SELECT  #BranchesT.BranchCode ,
                        #BranchesT.BranchRptTitle ,
                        #DivisionsT.DivisionCode ,
                        #DivisionsT.DivisionRptTitle ,
                        #COACombineLedTBRptVWT.GLCode ,
                        #COACombineLedTBRptVWT.GLRptTitle ,
                        #NatureTABT.NatureCode ,
                        #NatureTABT.NatureRptTitle ,
                        #TransMasterT.VoucherDate ,
                        dbo.VoucherDetails.VoucherNo ,
                        #TransMasterT.OldRef ,
                        dbo.VoucherDetails.Narration ,
                        #TransMasterT.Description AS NarrationMain ,
                        #TransMasterT.RecordNo ,
                        dbo.VoucherDetails.Reference ,
                        dbo.VoucherDetails.Debit ,
                        dbo.VoucherDetails.Credit ,
                        #COACombineLedTBRptVWT.ControlCode ,
                        #COACombineLedTBRptVWT.ControlRptTitle ,
                        #COACombineLedTBRptVWT.GeneralCode ,
                        #COACombineLedTBRptVWT.GeneralRptTitle ,
                        #COACombineLedTBRptVWT.SubSidiaryCode ,
                        #COACombineLedTBRptVWT.SubsidiaryRptTitle ,
                        #COACombineLedTBRptVWT.SubsubCode ,
                        #COACombineLedTBRptVWT.SubSubRptTitle ,
                        #TransMasterT.Posted ,
                        #TransMasterT.Locked ,
                        dbo.VoucherDetails.RecordNo AS DetailRecordNo
                INTO    TempTransDetailLedger
                FROM    dbo.VoucherDetails
                        INNER JOIN #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.NatureCode
                        INNER JOIN #BranchesT ON dbo.VoucherDetails.BranchCode = #BranchesT.BranchCode
                        INNER JOIN #DivisionsT ON dbo.VoucherDetails.DivisionCode = #DivisionsT.DivisionCode
                        INNER JOIN #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.GLCode
                        INNER JOIN #TransMasterT ON dbo.VoucherDetails.BranchCode = #TransMasterT.BranchCode
                                                    AND dbo.VoucherDetails.VoucherNature = #TransMasterT.VoucherNature
                                                    AND dbo.VoucherDetails.VoucherNo = #TransMasterT.VoucherNo
	--  WHERE     (#TransMasterT.VoucherDate BETWEEN  @FromDate AND @ToDate ) 
	 -- ORDER BY  #TransMaster.VoucherDate, dbo.VoucherDetails.VoucherNo
	
/*
	SELECT     #BranchesT.BranchCode, #BranchesT.BranchRptTitle, #DivisionsT.DivisionCode, #DivisionsT.DivisionRptTitle, 
	      #COACombineLedTBRptVWT.GLCode, #COACombineLedTBRptVWT.GLRptTitle, #NatureTABT.NatureCode, 
	      #NatureTABT.NatureRptTitle, dbo.Vouchers.VoucherDate, dbo.VoucherDetails.VoucherNo, 
	      dbo.VoucherDetails.Narration, dbo.Vouchers.Narration AS NarrationMain, dbo.VoucherDetails.Reference, 
	      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, #COACombineLedTBRptVWT.ControlCode, 
	      #COACombineLedTBRptVWT.ControlRptTitle, #COACombineLedTBRptVWT.GeneralCode, 
	      #COACombineLedTBRptVWT.GeneralRptTitle, #COACombineLedTBRptVWT.SubSidiaryCode, 
	      #COACombineLedTBRptVWT.SubsidiaryRptTitle, #COACombineLedTBRptVWT.SubsubCode, 
	      #COACombineLedTBRptVWT.SubSubRptTitle INTO TempTransDetailLedger
	FROM         dbo.VoucherDetails INNER JOIN
	      #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.NatureCode INNER JOIN
	      #BranchesT ON dbo.VoucherDetails.BranchCode = #BranchesT.BranchCode INNER JOIN
	      #DivisionsT ON dbo.VoucherDetails.Division = #DivisionsT.DivisionCode INNER JOIN
	      #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.GLCode LEFT OUTER JOIN
	      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	 WHERE     (dbo.Vouchers.VoucherDate BETWEEN  @FromDate AND @ToDate )
	 ORDER BY  dbo.Vouchers.VoucherDate, dbo.VoucherDetails.VoucherNo
*/		
            END
        ELSE 
            IF @nType = 2 
                BEGIN
                    IF EXISTS ( SELECT  *
                                FROM    sysobjects
                                WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                        AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                        BEGIN
                            DROP TABLE  TempTransDetailLedgerTrial
                        END
                    SELECT  DivisionCode AS SysDivisionCode ,
                            DivisionCode ,
                            Division ,
                            Division AS DivisionRptTitle
                    INTO    #DivisionsTr
                    FROM    dbo.Divisions
                    WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                         AND  @ToDivisionCode )
                    CREATE INDEX [#IX_DivisionsTr ] ON #DivisionsTr (   DivisionCode )
                    WITH   SORT_IN_TEMPDB
                    ON [PRIMARY]
	
                    SELECT  BranchCode AS SysBranchCode ,
                            BranchCode ,
                            BranchDescription AS Branch ,
                            BranchDescription AS BranchRptTitle
                    INTO    #BranchesTr
                    FROM    dbo.Branches
                    WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                                      AND     @ToBranchCode )
                    CREATE INDEX #IX_BranchesTr ON #BranchesTr (   BranchCode )
                    WITH   SORT_IN_TEMPDB
                    ON [PRIMARY]
	
                    SELECT  GLCode ,
                            GLRptTitle ,
                            ControlCode ,
                            ControlRptTitle ,
                            GeneralCode ,
                            GeneralRptTitle ,
                            SubSidiaryCode ,
                            SubsidiaryRptTitle ,
                            SubsubCode ,
                            SubSubRptTitle
                    INTO    #COACombineLedTBRptVWTr
                    FROM    dbo.GL_GetCOACombineLedTBRptVW
                    WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                              AND
                                                              @ToGLCode )
	
                    CREATE INDEX #IX_COACombineLedTBRptVWTr ON #COACombineLedTBRptVWTr (   GLCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
                    SELECT  NatureCode AS SysNatureCode ,
                            NatureCode ,
                            Nature ,
                            Nature AS NatureRptTitle
                    INTO    #NatureTABTr
                    FROM    dbo.TransactionNatures
                    WHERE   ',' + @VoucherNatureCode + ',' LIKE '%,'
                            + CAST(NatureCode AS VARCHAR) + ',%'
                            OR @VoucherNatureCode = ''
	
                    CREATE INDEX #IX_NatureTABTr ON #NatureTABTr (   NatureCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
	
                    SELECT  #BranchesTr.BranchCode ,
                            #BranchesTr.BranchRptTitle ,
                            #DivisionsTr.DivisionCode ,
                            #DivisionsTr.DivisionRptTitle ,
                            dbo.VoucherDetails.GLCode ,
                            SUM(dbo.VoucherDetails.Debit) AS DebitBalance ,
                            SUM(dbo.VoucherDetails.Credit) AS CreditBalance
                    INTO    #ConsTrans
                    FROM    dbo.VoucherDetails
                            INNER JOIN #NatureTABTr ON dbo.VoucherDetails.VoucherNature = #NatureTABTr.NatureCode
                            INNER JOIN #BranchesTr ON dbo.VoucherDetails.BranchCode = #BranchesTr.BranchCode
                            INNER JOIN #DivisionsTr ON dbo.VoucherDetails.DivisionCode = #DivisionsTr.DivisionCode
                            INNER JOIN #COACombineLedTBRptVWTr ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWTr.GLCode
                            LEFT OUTER JOIN dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode
                                                            AND dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature
                                                            AND dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
                    WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                       AND    @ToDate )
                            AND ( dbo.Vouchers.Posted = @Posted
                                  OR @PostedED = 0
                                )
                    GROUP BY #BranchesTr.BranchCode ,
                            #BranchesTr.BranchRptTitle ,
                            #DivisionsTr.DivisionCode ,
                            #DivisionsTr.DivisionRptTitle ,
                            dbo.VoucherDetails.GLCode
	
                    CREATE INDEX #IX_ConsTrans ON #ConsTrans ( GLCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
/*	SELECT     #ConsTrans.BranchCode, #ConsTrans.BranchRptTitle, #ConsTrans.DivisionCode, #ConsTrans.DivisionRptTitle, 
	                      #ConsTrans.DebitBalance, #ConsTrans.CreditBalance, #COACombineLedTBRptVWTr.GLCode, #COACombineLedTBRptVWTr.GLRptTitle, 
	                      #COACombineLedTBRptVWTr.ControlCode, #COACombineLedTBRptVWTr.ControlRptTitle, 
	                      #COACombineLedTBRptVWTr.GeneralCode, #COACombineLedTBRptVWTr.GeneralRptTitle, 
	                      #COACombineLedTBRptVWTr.SubSidiaryCode, #COACombineLedTBRptVWTr.SubsidiaryRptTitle, 
	                      #COACombineLedTBRptVWTr.SubsubCode, #COACombineLedTBRptVWTr.SubSubRptTitle INTO TempTransDetailLedgerTrial
	FROM         #ConsTrans INNER JOIN
	                      #COACombineLedTBRptVWTr ON  #ConsTrans.GLCode = #COACombineLedTBRptVWTr.GLCode*/
                    SELECT  #ConsTrans.BranchCode ,
                            #ConsTrans.BranchRptTitle ,
                            #ConsTrans.DivisionCode ,
                            #ConsTrans.DivisionRptTitle ,
                            #COACombineLedTBRptVWTr.GLCode ,
                            #COACombineLedTBRptVWTr.GLRptTitle ,
                            #COACombineLedTBRptVWTr.ControlCode ,
                            #COACombineLedTBRptVWTr.ControlRptTitle ,
                            #COACombineLedTBRptVWTr.GeneralCode ,
                            #COACombineLedTBRptVWTr.GeneralRptTitle ,
                            #COACombineLedTBRptVWTr.SubSidiaryCode ,
                            #COACombineLedTBRptVWTr.SubsidiaryRptTitle ,
                            #COACombineLedTBRptVWTr.SubsubCode ,
                            #COACombineLedTBRptVWTr.SubSubRptTitle ,
                            0 AS OpeningBalance ,
                            #ConsTrans.DebitBalance ,
                            #ConsTrans.CreditBalance
                    INTO    TempTransDetailLedgerTrial
                    FROM    #ConsTrans
                            INNER JOIN #COACombineLedTBRptVWTr ON #ConsTrans.GLCode = #COACombineLedTBRptVWTr.GLCode
                END
            ELSE 
                IF @nType = 3		--  GET COA Opening FROM TempTAB
                    BEGIN
                        IF EXISTS ( SELECT  *
                                    FROM    sysobjects
                                    WHERE   ID = OBJECT_ID(N'TempCOAOpeningLedger')
                                            AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                            BEGIN
                                SELECT  *
                                FROM    TempCOAOpeningLedger
                                DROP TABLE  TempCOAOpeningLedger
                            END
                        ELSE 
                            BEGIN
                                SELECT  '' AS Error
                                WHERE   0 = 1
                            END
                    END
                ELSE 
                    IF @nType = 4		--  GET Transaction Detail
                        BEGIN
                            IF EXISTS ( SELECT  *
                                        FROM    sysobjects
                                        WHERE   ID = OBJECT_ID(N'TempTransDetailLedger')
                                                AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                BEGIN
                                    SELECT  *
                                    FROM    TempTransDetailLedger
                                    ORDER BY BranchCode ,
                                            GLCode ,
                                            VoucherDate ,
                                            RecordNo 
		--DROP TABLE  TempTransDetailLedger
                                END
                            ELSE 
                                BEGIN
                                    SELECT  '' AS Error
                                    WHERE   0 = 1
                                END
                        END
                    ELSE 
                        IF @nType = 5		--  GET Transaction Detail for Trial Balance
                            BEGIN
/*	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailLedgerTrial' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT   *	FROM         dbo.TempTransDetailLedgerTrial
		DROP TABLE  TempTransDetailLedgerTrial
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END*/
                                IF EXISTS ( SELECT  *
                                            FROM    sysobjects
                                            WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                    AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                    BEGIN
                                        SELECT  BranchCode ,
                                                BranchRptTitle ,
                                                DivisionCode ,
                                                DivisionRptTitle ,
                                                GLCode ,
                                                GLRptTitle ,
                                                ControlCode ,
                                                ControlRptTitle ,
                                                GeneralCode ,
                                                GeneralRptTitle ,
                                                SubSidiaryCode ,
                                                SubsidiaryRptTitle ,
                                                SubsubCode ,
                                                SubSubRptTitle ,
                                                SUM(OpeningBalance) AS OpBalance ,
                                                SUM(DebitBalance) AS DBBalance ,
                                                SUM(CreditBalance) AS CrBalance
                                        FROM    ( SELECT    BranchCode ,
                                                            BranchRptTitle ,
                                                            DivisionCode ,
                                                            DivisionRptTitle ,
                                                            GLCode ,
                                                            GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            SubsubCode ,
                                                            SubSubRptTitle ,
                                                            OpeningBalance ,
                                                            0 AS DebitBalance ,
                                                            0 AS CreditBalance
                                                  FROM      dbo.TempCOAOpeningLedger
                                                  UNION ALL
                                                  SELECT    BranchCode ,
                                                            BranchRptTitle ,
                                                            DivisionCode ,
                                                            DivisionRptTitle ,
                                                            GLCode ,
                                                            GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            SubsubCode ,
                                                            SubSubRptTitle ,
                                                            OpeningBalance ,
                                                            DebitBalance ,
                                                            CreditBalance
                                                  FROM      dbo.TempTransDetailLedgerTrial
                                                ) TrialBalance
                                        GROUP BY BranchCode ,
                                                BranchRptTitle ,
                                                DivisionCode ,
                                                DivisionRptTitle ,
                                                GLCode ,
                                                GLRptTitle ,
                                                ControlCode ,
                                                ControlRptTitle ,
                                                GeneralCode ,
                                                GeneralRptTitle ,
                                                SubSidiaryCode ,
                                                SubsidiaryRptTitle ,
                                                SubsubCode ,
                                                SubSubRptTitle 
                                    END
                                ELSE 
                                    BEGIN
                                        SELECT  '' AS Error
                                        WHERE   0 = 1
                                    END
                            END
                        ELSE 
                            IF @nType = 101		--  GET Trial Balance Consolidate , Control Wise
                                BEGIN
                                    IF EXISTS ( SELECT  *
                                                FROM    sysobjects
                                                WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                        AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                        BEGIN
                                            SELECT  '' AS BranchCode ,
                                                    '' AS BranchRptTitle ,
                                                    '' AS DivisionCode ,
                                                    '' AS DivisionRptTitle ,
                                                    '' AS GLCode ,
                                                    '' AS GLRptTitle ,
                                                    ControlCode ,
                                                    ControlRptTitle ,
                                                    '' AS GeneralCode ,
                                                    '' AS GeneralRptTitle ,
                                                    '' AS SubSidiaryCode ,
                                                    '' AS SubsidiaryRptTitle ,
                                                    '' AS SubsubCode ,
                                                    '' AS SubSubRptTitle ,
                                                    SUM(OpeningBalance) AS OpBalance ,
                                                    SUM(DebitBalance) AS DbBalance ,
                                                    SUM(CreditBalance) AS CrBalance
                                            FROM    ( SELECT  BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                      FROM    dbo.TempCOAOpeningLedger
                                                      UNION ALL
                                                      SELECT  BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                      FROM    dbo.TempTransDetailLedgerTrial
                                                    ) Balances
                                            GROUP BY ControlCode ,
                                                    ControlRptTitle
                                            HAVING  ( ABS(SUM(OpeningBalance))
                                                      + ABS(SUM(DebitBalance))
                                                      + ABS(SUM(CreditBalance)) <> 0
                                                      AND @ReportSD = 'DET'
                                                    )
                                                    OR ( SUM(OpeningBalance)
                                                         + SUM(DebitBalance)
                                                         - SUM(CreditBalance) <> 0
                                                         AND @ReportSD = 'SUM'
                                                       ) 
                                        END
                                    ELSE 
                                        BEGIN
                                            SELECT  '' AS Error
                                            WHERE   0 = 1
                                        END
                                END
                            ELSE 
                                IF @nType = 104		--  GET Trial Balance Consolidate , General Wise
                                    BEGIN
                                        IF EXISTS ( SELECT  *
                                                    FROM    sysobjects
                                                    WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                            AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                            BEGIN
                                                SELECT  '' AS BranchCode ,
                                                        '' AS BranchRptTitle ,
                                                        '' AS DivisionCode ,
                                                        '' AS DivisionRptTitle ,
                                                        '' AS GLCode ,
                                                        '' AS GLRptTitle ,
                                                        ControlCode ,
                                                        ControlRptTitle ,
                                                        GeneralCode ,
                                                        GeneralRptTitle ,
                                                        '' AS SubSidiaryCode ,
                                                        '' AS SubsidiaryRptTitle ,
                                                        '' AS SubsubCode ,
                                                        '' AS SubSubRptTitle ,
                                                        SUM(OpeningBalance) AS OpBalance ,
                                                        SUM(DebitBalance) AS DbBalance ,
                                                        SUM(CreditBalance) AS CrBalance
                                                FROM    ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                          FROM
                                                              dbo.TempCOAOpeningLedger
                                                          UNION ALL
                                                          SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                          FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                        ) Balances
                                                GROUP BY ControlCode ,
                                                        ControlRptTitle ,
                                                        GeneralCode ,
                                                        GeneralRptTitle
                                                HAVING  ( ABS(SUM(OpeningBalance))
                                                          + ABS(SUM(DebitBalance))
                                                          + ABS(SUM(CreditBalance)) <> 0
                                                          AND @ReportSD = 'DET'
                                                        )
                                                        OR ( SUM(OpeningBalance)
                                                             + SUM(DebitBalance)
                                                             - SUM(CreditBalance) <> 0
                                                             AND @ReportSD = 'SUM'
                                                           ) 
                                            END
                                        ELSE 
                                            BEGIN
                                                SELECT  '' AS Error
                                                WHERE   0 = 1
                                            END
                                    END
                                ELSE 
                                    IF @nType = 108		--  GET Trial Balance Consolidate , Subsidiary Wise
                                        BEGIN
                                            IF EXISTS ( SELECT
                                                              *
                                                        FROM  sysobjects
                                                        WHERE ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                BEGIN
                                                    SELECT  '' AS BranchCode ,
                                                            '' AS BranchRptTitle ,
                                                            '' AS DivisionCode ,
                                                            '' AS DivisionRptTitle ,
                                                            '' AS GLCode ,
                                                            '' AS GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            '' AS SubsubCode ,
                                                            '' AS SubSubRptTitle ,
                                                            SUM(OpeningBalance) AS OpBalance ,
                                                            SUM(DebitBalance) AS DbBalance ,
                                                            SUM(CreditBalance) AS CrBalance
                                                    FROM    ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                            ) Balances
                                                    GROUP BY ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle
                                                    HAVING  ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                            )
                                                            OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                END
                                            ELSE 
                                                BEGIN
                                                    SELECT  '' AS Error
                                                    WHERE   0 = 1
                                                END
                                        END
                                    ELSE 
                                        IF @nType = 112		--  GET Trial Balance Consolidate , Subsidiary Wise
                                            BEGIN
                                                IF EXISTS ( SELECT
                                                              *
                                                            FROM
                                                              sysobjects
                                                            WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                    BEGIN
                                                        SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                        FROM  ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                        GROUP BY ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                        HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                    END
                                                ELSE 
                                                    BEGIN
                                                        SELECT
                                                              '' AS Error
                                                        WHERE 0 = 1
                                                    END
                                            END
                                        ELSE 
                                            IF @nType = 102		--  GET Trial Balance Branch , Control Wise
                                                BEGIN
                                                    IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                        BEGIN
                                                            SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              '' AS GeneralCode ,
                                                              '' AS GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                            FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                            GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle
                                                            HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                        END
                                                    ELSE 
                                                        BEGIN
                                                            SELECT
                                                              '' AS Error
                                                            WHERE
                                                              0 = 1
                                                        END
                                                END
                                            ELSE 
                                                IF @nType = 105		--  GET Trial Balance Branch , General Wise
                                                    BEGIN
                                                        IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                            BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                            END
                                                        ELSE 
                                                            BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                            END
                                                    END
                                                ELSE 
                                                    IF @nType = 109		--  GET Trial Balance Branch , Subsidiary Wise
                                                        BEGIN
                                                            IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                            ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                        END
                                                    ELSE 
                                                        IF @nType = 113		--  GET Trial Balance Branch , Subsidiary Wise
                                                            BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                            END
                                                        ELSE 
                                                            IF @nType = 103
                                                              OR @nType = 121 		--  GET Trial Balance Division , Control Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              '' AS GeneralCode ,
                                                              '' AS GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                            ELSE 
                                                              IF @nType = 106
                                                              OR @nType = 124 		--  GET Trial Balance Division , General Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                              ELSE 
                                                              IF @nType = 110
                                                              OR @nType = 128 		--  GET Trial Balance Division  , Subsidiary Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                              ELSE 
                                                              IF @nType = 114
                                                              OR @nType = 132 		--  GET Trial Balance Division  , Subsidiary Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
GO
/****** Object:  StoredProcedure [dbo].[SelectCOASubSubSidiaries]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOASubSubSidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) =''



AS



IF 	@Option='ALL' 
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
        ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
		                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription
		FROM         dbo.COAGenerals RIGHT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.COASubSubsidiaries.SubSubsidiaryCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COASubsidiaries.SubsidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate
		FROM         dbo.COASubsidiaries RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
		ORDER BY dbo.COASubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubSubsidiaryCode +1 as SubSubsidiaryCode
		FROM dbo.COASubSubsidiaries
		ORDER BY dbo.COASubSubsidiaries.SubSubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT GlCode,GlDescription FROM GL_GetCOACombineTransactionVW
		Order By GLCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	 WHERE  dbo.COASubSubsidiaries.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.COASubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode	
     ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode

ELSE
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	 WHERE  dbo.COASubSubsidiaries.ControlCode=@ControlCode AND  dbo.COASubSubsidiaries.GeneralCode=@GeneralCode AND dbo.COASubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.COASubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode
     ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode
GO
/****** Object:  StoredProcedure [dbo].[SelectFinancialStatementReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE SelectFinancialStatementReports  
CREATE PROCEDURE [dbo].[SelectFinancialStatementReports]  
@FromBranchCode varchar(10)='',  
@ToBranchCode varchar(10)='' , 
@FromDivisionCode varchar(10)='',  
@ToDivisionCode varchar(10)='' , 
@FromGLCode varchar(50)='',  
@ToGLCode varchar(50)='', 
@FromFSFCode varchar(50)='',  
@ToFSFCode varchar(50)='', 
@FromDate DateTime= NULL ,  
@ToDate DateTime= NULL, 
@nType bigint =0 , 
@VoucherNatureCode   varchar(100) = '' ,
@ReportSD as varchar ( 10 ) = 'DET' ,
@Posted bit = 1,
@PostedED bit = 0
--2   112   3   0
AS
IF @nType = 0 --OPENING 1
	BEGIN			
	DECLARE @DocDate   as datetime
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
		DROP TABLE  TempCOAOpening
	END
	
	-- SELECT Division with Filter
	SELECT     DivisionCode as   SysDivisionCode, DivisionCode, Division, Division  AS DivisionRptTitle 
	INTO 	#DivisionTAB
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX #IX_DivisionTAB ON #DivisionTAB ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT Branch with Filter
	SELECT   BranchCode as   SysBranchCode, BranchCode, BranchDescription, BranchDescription as  BranchRptTitle 
	INTO #BranchTAB
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTAB ON #BranchTAB ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT GLAccount with Filter
	SELECT     GLCode as SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle ,SysFSFGLCode
	INTO 	#COACombineLedTBRptVW
	FROM         dbo.GL_GetCOACombineLedTBRptVW
	WHERE  (dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	---- shamim
	
	SELECT    GLCode as  SysGLCode, GLCode as FSFGLCode, GLRptTitle as FSFGLRptTitle, ControlCode as FSFControlCode, ControlRptTitle as FSFControlRptTitle, GeneralCode as FSFGeneralCode , GeneralRptTitle as FSFGeneralRptTitle, 
		SubSidiaryCode as FSFSubSidiaryCode, SubsidiaryRptTitle as FSFSubsidiaryRptTitle, SubsubCode as FSFSubsubCode, SubSubRptTitle as FSFSubSubRptTitle
	INTO 	#FSFCombineLedTBRptVW
	FROM         dbo.GL_GetFSFCombineLedTBRptVW

	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.ControlCode BETWEEN @FromFSFCode AND @ToFSFCode ) --Fin. Stat.
		OR 
		  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromFSFCode AND @ToFSFCode )	    --FSCodes
--MAK
	CREATE INDEX #IX_FSFCombineLedTBRptVW ON #FSFCombineLedTBRptVW ( FSFGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #COACombineLedTBRptVW.SysGLCode, #COACombineLedTBRptVW.GLCode, #COACombineLedTBRptVW.GLRptTitle, #COACombineLedTBRptVW.ControlCode, #COACombineLedTBRptVW.ControlRptTitle, #COACombineLedTBRptVW.GeneralCode, #COACombineLedTBRptVW.GeneralRptTitle, 
		#COACombineLedTBRptVW.SubSidiaryCode, #COACombineLedTBRptVW.SubsidiaryRptTitle, #COACombineLedTBRptVW.SubsubCode, #COACombineLedTBRptVW.SubSubRptTitle,#COACombineLedTBRptVW.SysFSFGLCode,
		#FSFCombineLedTBRptVW.FSFGLCode, #FSFCombineLedTBRptVW.FSFGLRptTitle, #FSFCombineLedTBRptVW.FSFControlCode, #FSFCombineLedTBRptVW.FSFControlRptTitle, #FSFCombineLedTBRptVW.FSFGeneralCode , #FSFCombineLedTBRptVW.FSFGeneralRptTitle, 
		#FSFCombineLedTBRptVW.FSFSubSidiaryCode, #FSFCombineLedTBRptVW.FSFSubsidiaryRptTitle, #FSFCombineLedTBRptVW.FSFSubsubCode, #FSFCombineLedTBRptVW.FSFSubSubRptTitle
	Into #COAAndFSFCombineVW
	From   #FSFCombineLedTBRptVW  INNER JOIN
    
    #COACombineLedTBRptVW
    ON #FSFCombineLedTBRptVW.FSFGLCode= #COACombineLedTBRptVW.SysFSFGLCode
	
	
	
	
	----
	
	
	
	
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
	SELECT     dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode, 
	                      MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate 
	INTO #OpeningDate
	FROM         dbo.OpeningBalances INNER JOIN
	                      #BranchTAB ON dbo.OpeningBalances.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
	                      #COAAndFSFCombineVW ON dbo.OpeningBalances.GLCode = #COAAndFSFCombineVW.SysGLCode INNER JOIN
	                      #DivisionTAB ON dbo.OpeningBalances.DivisionCode = #DivisionTAB.SysDivisionCode
	WHERE     (dbo.OpeningBalances.ClosingDate <= @ToDate )
	GROUP BY dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode
	CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
	SELECT     dbo.OpeningBalances.ClosingDate, dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, 
	      dbo.OpeningBalances.GLCode, dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS OpeningBalance 
	INTO #OpeningTAB
	FROM         dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
	      dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate AND 
	      dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode AND 
	      dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
	SELECT @DocDate = ISNULL( MIN(#OpeningDate.ClosingDate) , 0 ) + 1 FROM #OpeningDate
	--PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate 
	INTO #TransMaster
	FROM         dbo.Vouchers INNER JOIN
		#BranchTAB ON dbo.Vouchers.BranchCode = #BranchTAB.SysBranchCode
	WHERE     (dbo.Vouchers.VoucherDate BETWEEN @DocDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- SELECT Detail Transaction With Date
	SELECT     dbo.VoucherDetails.BranchCode, #TransMaster.VoucherDate, dbo.VoucherDetails.GLCode, 
		      dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit 
	INTO #TransDetail
	FROM         #TransMaster INNER JOIN
		      dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode AND 
		      #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
		      #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo INNER JOIN
		      #DivisionTAB ON dbo.VoucherDetails.DivisionCode = #DivisionTAB.SysDivisionCode
	
	CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, DivisionCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- Select Transaction Balance
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, SUM(#TransDetail.Debit) 
		      - SUM(#TransDetail.Credit) AS TransBalance 
	INTO #TransBalTAB
	FROM         #TransDetail LEFT OUTER JOIN
		      #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode AND 
		      #TransDetail.VoucherDate > #OpeningDate.ClosingDate AND 
		      #TransDetail.GLCode = #OpeningDate.GLCode AND #TransDetail.DivisionCode = #OpeningDate.DivisionCode
	GROUP BY #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode
	
	---   Final Opening Balance 
	SELECT     BranchCode, DivisionCode, GLCode, SUM(OpeningBalance) AS OpeningBalance INTO #TransTAB
	FROM         (SELECT     BranchCode, DivisionCode, GLCode, OpeningBalance
	                       FROM          #OpeningTAB
	                       UNION ALL
	                       SELECT     BranchCode, DivisionCode, GLCode, TransBalance
	                       FROM         #TransBalTAB) TransTAB
	GROUP BY BranchCode, DivisionCode, GLCode
	
	--- Final Opening Balance With Titles
	SELECT    #BranchTAB.BranchCode, #BranchTAB.BranchRptTitle, #DivisionTAB.DivisionCode, 
		      #DivisionTAB.DivisionRptTitle, #COAAndFSFCombineVW.GLCode, #COAAndFSFCombineVW.GLRptTitle, 
		      #COAAndFSFCombineVW.ControlCode, #COAAndFSFCombineVW.ControlRptTitle, 
		      #COAAndFSFCombineVW.GeneralCode, #COAAndFSFCombineVW.GeneralRptTitle, 
		      #COAAndFSFCombineVW.SubSidiaryCode, #COAAndFSFCombineVW.SubsidiaryRptTitle, 
		      #COAAndFSFCombineVW.SubsubCode, #COAAndFSFCombineVW.SubSubRptTitle, 	      
		      #COAAndFSFCombineVW.FSFGLCode, #COAAndFSFCombineVW.FSFGLRptTitle, 
		      #COAAndFSFCombineVW.FSFControlCode, #COAAndFSFCombineVW.FSFControlRptTitle, 
		      #COAAndFSFCombineVW.FSFGeneralCode, #COAAndFSFCombineVW.FSFGeneralRptTitle, 
		      #COAAndFSFCombineVW.FSFSubSidiaryCode, #COAAndFSFCombineVW.FSFSubsidiaryRptTitle, 
		      #COAAndFSFCombineVW.FSFSubsubCode, #COAAndFSFCombineVW.FSFSubSubRptTitle, 	      
		      
		      #TransTAB.OpeningBalance INTO TempCOAOpening
	FROM         #TransTAB INNER JOIN
		      #BranchTAB ON #TransTAB.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
		      #DivisionTAB ON #TransTAB.DivisionCode = #DivisionTAB.SysDivisionCode INNER JOIN
		      #COAAndFSFCombineVW ON #TransTAB.GLCode = #COAAndFSFCombineVW.SysGLCode
	WHERE     #TransTAB.OpeningBalance <> 0
	END
	
	
ELSE IF @nType = 2
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		DROP TABLE  TempTransDetailTrialFSF
		END
	SELECT    DivisionCode as  SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO #DivisionTABTr
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	CREATE INDEX [#IX_DivisionTABTr ] ON #DivisionTABTr ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
	SELECT  BranchCode as    SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle 
	INTO 	#BranchTABTr
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	CREATE INDEX #IX_BranchTABTr ON #BranchTABTr ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
	SELECT     GLCode as SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, SysFSFGLCode 
	INTO 	#COACombineLedTBRptVWTr
	FROM         dbo.GL_GetCOACombineLedTBRptVW
	WHERE  (dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	
	CREATE INDEX #IX_COACombineLedTBRptVWTr ON #COACombineLedTBRptVWTr ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
		
	---- shamim
	
	SELECT     GLCode as SysFSFGLCode, GLCode as FSFGLCode, GLRptTitle as FSFGLRptTitle, ControlCode as FSFControlCode, ControlRptTitle as FSFControlRptTitle, GeneralCode as FSFGeneralCode , GeneralRptTitle as FSFGeneralRptTitle, 
		SubSidiaryCode as FSFSubSidiaryCode, SubsidiaryRptTitle as FSFSubsidiaryRptTitle, SubsubCode as FSFSubsubCode, SubSubRptTitle as FSFSubSubRptTitle
	INTO 	#FSFCombineLedTBRptVWTr
	FROM         dbo.GL_GetFSFCombineLedTBRptVW
--MAK
--	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.ControlCode BETWEEN @FromFSFCode AND @ToFSFCode )	
		OR 
		  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromFSFCode AND @ToFSFCode )	
--MAK	
	CREATE INDEX #IX_FSFCombineLedTBRptVWTr ON #FSFCombineLedTBRptVWTr ( SysFSFGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #COACombineLedTBRptVWTr.SysGLCode, #COACombineLedTBRptVWTr.GLCode, #COACombineLedTBRptVWTr.GLRptTitle, #COACombineLedTBRptVWTr.ControlCode, #COACombineLedTBRptVWTr.ControlRptTitle, #COACombineLedTBRptVWTr.GeneralCode, #COACombineLedTBRptVWTr.GeneralRptTitle, 
		#COACombineLedTBRptVWTr.SubSidiaryCode, #COACombineLedTBRptVWTr.SubsidiaryRptTitle, #COACombineLedTBRptVWTr.SubsubCode, #COACombineLedTBRptVWTr.SubSubRptTitle, #COACombineLedTBRptVWTr.SysFSFGLCode ,
		#FSFCombineLedTBRptVWTr.FSFGLCode, #FSFCombineLedTBRptVWTr.FSFGLRptTitle, #FSFCombineLedTBRptVWTr.FSFControlCode, #FSFCombineLedTBRptVWTr.FSFControlRptTitle, #FSFCombineLedTBRptVWTr.FSFGeneralCode , #FSFCombineLedTBRptVWTr.FSFGeneralRptTitle, 
		#FSFCombineLedTBRptVWTr.FSFSubSidiaryCode, #FSFCombineLedTBRptVWTr.FSFSubsidiaryRptTitle, #FSFCombineLedTBRptVWTr.FSFSubsubCode, #FSFCombineLedTBRptVWTr.FSFSubSubRptTitle
	Into #COAAndFSFCombineQuery
	
	From  #COACombineLedTBRptVWTr  INNER JOIN
    #FSFCombineLedTBRptVWTr ON 
    #COACombineLedTBRptVWTr.SysFSFGLCode=#FSFCombineLedTBRptVWTr.SysFSFGLCode
     
	--From  #FSFCombineLedTBRptVWTr  LEFT OUTER JOIN
    --#COACombineLedTBRptVWTr ON #FSFCombineLedTBRptVWTr.SysFSFGLCode= #COACombineLedTBRptVWTr.SysFSFGLCode
		
	
	
	SELECT     NatureCode as SysNatureCode, NatureCode, Nature, Nature AS NatureRptTitle INTO #NatureTABTr
	FROM         dbo.TransactionNatures 
	WHERE ',' + @VoucherNatureCode + ',' LIKE '%,' + CAST( NatureCode as varchar) + ',%' OR @VoucherNatureCode = ''
	
	CREATE INDEX #IX_NatureTABTr ON #NatureTABTr ( NatureCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #BranchTABTr.BranchCode, #BranchTABTr.BranchRptTitle, #DivisionTABTr.DivisionCode, #DivisionTABTr.DivisionRptTitle, 
	      dbo.VoucherDetails.GLCode, 
	      SUM( dbo.VoucherDetails.Debit ) AS DebitBalance , SUM (dbo.VoucherDetails.Credit ) as CreditBalance 
	INTO #ConsTrans
	FROM 	   dbo.VoucherDetails INNER JOIN
	      #NatureTABTr ON dbo.VoucherDetails.VoucherNature = #NatureTABTr.SysNatureCode INNER JOIN
	      #BranchTABTr ON dbo.VoucherDetails.BranchCode = #BranchTABTr.SysBranchCode INNER JOIN
	      #DivisionTABTr ON dbo.VoucherDetails.DivisionCode = #DivisionTABTr.SysDivisionCode INNER JOIN
	      #COAAndFSFCombineQuery ON dbo.VoucherDetails.GLCode = #COAAndFSFCombineQuery.SysGLCode LEFT OUTER JOIN
	      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	 WHERE     (dbo.Vouchers.VoucherDate BETWEEN  @FromDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	GROUP BY #BranchTABTr.BranchCode, #BranchTABTr.BranchRptTitle, #DivisionTABTr.DivisionCode, #DivisionTABTr.DivisionRptTitle, 
		              dbo.VoucherDetails.GLCode
	
	CREATE INDEX #IX_ConsTrans ON #ConsTrans ( GLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     #ConsTrans.BranchCode, #ConsTrans.BranchRptTitle, #ConsTrans.DivisionCode, #ConsTrans.DivisionRptTitle, 
	                      #COAAndFSFCombineQuery.GLCode, #COAAndFSFCombineQuery.GLRptTitle, 
	                      #COAAndFSFCombineQuery.ControlCode, #COAAndFSFCombineQuery.ControlRptTitle, 
	                      #COAAndFSFCombineQuery.GeneralCode, #COAAndFSFCombineQuery.GeneralRptTitle, 
	                      #COAAndFSFCombineQuery.SubSidiaryCode, #COAAndFSFCombineQuery.SubsidiaryRptTitle, 
	                      #COAAndFSFCombineQuery.SubsubCode, #COAAndFSFCombineQuery.SubSubRptTitle ,
	                      
	                      #COAAndFSFCombineQuery.FSFGLCode, #COAAndFSFCombineQuery.FSFGLRptTitle, 
	                      #COAAndFSFCombineQuery.FSFControlCode, #COAAndFSFCombineQuery.FSFControlRptTitle, 
	                      #COAAndFSFCombineQuery.FSFGeneralCode, #COAAndFSFCombineQuery.FSFGeneralRptTitle, 
	                      #COAAndFSFCombineQuery.FSFSubSidiaryCode, #COAAndFSFCombineQuery.FSFSubsidiaryRptTitle, 
	                      #COAAndFSFCombineQuery.FSFSubsubCode, #COAAndFSFCombineQuery.FSFSubSubRptTitle ,0 as OpeningBalance ,
	                      #ConsTrans.DebitBalance, #ConsTrans.CreditBalance
						  
						  INTO TempTransDetailTrialFSF
	FROM         #ConsTrans INNER JOIN
	                     #COAAndFSFCombineQuery ON  #ConsTrans.GLCode = #COAAndFSFCombineQuery.SysGLCode
	END
ELSE IF @nType  = 3		--  GET COA Opening FROM TempTAB
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TempCOAOpening
		DROP TABLE  TempCOAOpening
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
ELSE IF @nType  = 112		--  GET Trial Balance Consolidate , Subsidiary Wise
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		
		BEGIN
		
		SELECT     '' AS BranchCode, '' AS BranchRptTitle, '' AS DivisionCode, '' AS DivisionRptTitle, '' as GLCode,'' as  GLRptTitle, ControlCode, ControlRptTitle, 
		                      GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, FSFGLCode, FSFGLRptTitle, FSFControlCode,
		                      FSFControlRptTitle, FSFGeneralCode, FSFGeneralRptTitle, FSFSubSidiaryCode, FSFSubsidiaryRptTitle,FSFSubsubCode, FSFSubSubRptTitle,
		                      SUM(OpeningBalance) AS OpBalance, SUM(DebitBalance) AS DbBalance, SUM(CreditBalance) AS CrBalance
		FROM         (SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                              GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,
		                                              
		                                               
	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle,	                                              
		                                              
		                                               OpeningBalance, 0 AS DebitBalance, 
		                                              0 AS CreditBalance
		                       FROM          dbo.TempCOAOpening
		                       UNION ALL
		                       SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                             GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,
		                  FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle,
		                                             
		                                              OpeningBalance, DebitBalance, CreditBalance
		                       FROM         dbo.TempTransDetailTrialFSF) Balances
		GROUP BY ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle
		HAVING ( ABS( SUM(OpeningBalance) ) + 
			     ABS( SUM(DebitBalance) ) + ABS( SUM(CreditBalance) ) <> 0 AND @ReportSD = 'DET' ) 
						OR
				 (  SUM(OpeningBalance) + SUM(DebitBalance) - SUM(CreditBalance)  <> 0 AND @ReportSD = 'SUM' ) 
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
--MAK
--For new report "Notes To Financial Statements "
ELSE IF @nType  = 113		--  GET Trial Balance Branch , Subsidiary Wise
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT     BranchCode, BranchRptTitle, '' AS DivisionCode, '' AS DivisionRptTitle, '' as GLCode,'' as  GLRptTitle, ControlCode, ControlRptTitle, 
		                      GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, 
		                      SUM(OpeningBalance) AS OpBalance, SUM(DebitBalance) AS DbBalance, SUM(CreditBalance) AS CrBalance
, FSFGLCode, FSFGLRptTitle, FSFControlCode,
		                      FSFControlRptTitle, FSFGeneralCode, FSFGeneralRptTitle, FSFSubSidiaryCode, FSFSubsidiaryRptTitle,FSFSubsubCode, FSFSubSubRptTitle
		FROM         (SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                              GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, OpeningBalance, 0 AS DebitBalance, 
		                                              0 AS CreditBalance
,	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle	                                              
		                       FROM          dbo.TempCOAOpening
		                       UNION ALL
		                       SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                             GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, OpeningBalance, DebitBalance, CreditBalance
,	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle	                                              
		                       FROM         dbo.TempTransDetailTrialFSF) Balances
		GROUP BY BranchCode, BranchRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle
			,FSFGLCode, FSFGLRptTitle, 
			FSFControlCode, FSFControlRptTitle, 
			FSFGeneralCode, FSFGeneralRptTitle, 
			FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
			FSFSubsubCode, FSFSubSubRptTitle
		HAVING ( ABS( SUM(OpeningBalance) ) + 
			     ABS( SUM(DebitBalance) ) + ABS( SUM(CreditBalance) ) <> 0 AND @ReportSD = 'DET' ) 
						OR
				 (  SUM(OpeningBalance) + SUM(DebitBalance) - SUM(CreditBalance)  <> 0 AND @ReportSD = 'SUM' ) 
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomers]    Script Date: 12/01/2017 23:44:31 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectCustomerBillsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCustomerBillsDetails]
@Option as  varchar(3)='',
@BillNo as varchar(10) ='',
@TransactionNature as varchar(3) ='',
@BranchCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     CustomerBillDetails.BillNo, CustomerBillDetails.BranchCode, CustomerBillDetails.InvoiceNo, Branches.BranchDescription, 
                      CustomerBillDetails.BranchCode + ' - ' + Branches.BranchDescription AS Branch, Invoices.TransactionDate AS InvoiceDate, 
                      [Vehicles ].VehicleCode + ' - ' + [Vehicles ].VehicleDescription AS Vehicle, Invoices.Quantity, Invoices.Rate, Invoices.Amount, 
                      Products.ProductCode + ' - ' + Products.ProductName AS Product, CustomerBillDetails.Shortage, Invoices.CustomerReference as TokenNo, 
                      StationPoints.StationPointCode + ' - ' + StationPoints.StationPointName as StationPoint, DestinationPoints.DestinationPointCode + ' - ' + 
                      DestinationPoints.DestinationPointName as DestinationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode RIGHT OUTER JOIN
                      CustomerBillDetails ON Invoices.BranchCode = CustomerBillDetails.BranchCode AND Invoices.TransactionNo = CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo
Else
		SELECT     dbo.CustomerBillDetails.BillNo, dbo.CustomerBillDetails.BranchCode, dbo.CustomerBillDetails.InvoiceNo, dbo.Branches.BranchDescription, 
		              dbo.CustomerBillDetails.BranchCode + ' - ' + dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionDate AS InvoiceDate, 
		              dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, 
		              dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product, dbo.CustomerBillDetails.Shortage
		, Invoices.CustomerReference as TokenNo, 
                      StationPoints.StationPointCode + ' - ' + StationPoints.StationPointName as StationPoint, DestinationPoints.DestinationPointCode + ' - ' + 
                      DestinationPoints.DestinationPointName as DestinationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode RIGHT OUTER JOIN
                      CustomerBillDetails ON Invoices.BranchCode = CustomerBillDetails.BranchCode AND Invoices.TransactionNo = CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomerBills]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectCustomerBills]

@Option as  varchar(20)='',
@BillNo as char(10) ='',
@CustomerCode as char(10) ='',
@YearMonth as varchar(4)='',
@ToInvoiceNo as varchar(10)='',
@FromInvoiceNo as varchar(10)='',
@FromInvoiceDate as Datetime='',
@ToInvoiceDate as datetime='',
@TransactionNature as varchar(10)=''

AS



	IF @Option='ALL'  
		SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
		FROM         dbo.CustomerBills LEFT OUTER JOIN
			      dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
	ELSE IF @Option='AUTO' 
		SELECT TOP 1 BillNo as BillNo FROM dbo.CustomerBills 
		WHERE ( SUBSTRING( CAST( BillNo AS varchar(4) ) ,1,4) = @YearMonth )
		ORDER BY BillNo DESC
	ELSE IF @Option='FILTERINVOICES'  --FILTER ON BILL GENERATION
		IF @FromInvoiceNo <> '' OR @ToInvoiceNo <> ''
			SELECT   Invoices.CustomerReference AS TokenNo,  dbo.Invoices.BranchCode, dbo.Branches.BranchDescription, dbo.Invoices.BranchCode + ' - ' +  dbo.Branches.BranchDescription as Branch,dbo.Invoices.TransactionNo AS InvoiceNo, dbo.Invoices.TransactionDate AS InvoiceDate, 
				dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, dbo.Invoices.Shortage,dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, 
				dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product,
				DestinationPoints.DestinationPointCode + ' - ' +  DestinationPoints.DestinationPointName AS DestinationPoint, StationPoints.StationPointCode 
                      + ' - ' + StationPoints.StationPointName as StationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode

			WHERE dbo.Invoices.TransactionNo BETWEEN @FromInvoiceNo AND @ToInvoiceNo AND dbo.Invoices.PArtyCode=@CustomerCode
				AND dbo.Invoices.IsBilled=0
			ORDER BY dbo.Invoices.BranchCode,dbo.Invoices.TransactionDate
		ELSE
			SELECT     Invoices.CustomerReference AS TokenNo,  Invoices.BranchCode, Branches.BranchDescription, Invoices.BranchCode + ' - ' + Branches.BranchDescription AS Branch, 
                      Invoices.TransactionNo AS InvoiceNo, Invoices.TransactionDate AS InvoiceDate, Invoices.Quantity, Invoices.Rate, Invoices.Amount, Invoices.Shortage, 
                      [Vehicles ].VehicleCode + ' - ' + [Vehicles ].VehicleDescription AS Vehicle, Products.ProductCode + ' - ' + Products.ProductName AS Product, 
                      DestinationPoints.DestinationPointCode+ ' - ' +  DestinationPoints.DestinationPointName AS DestinationPoint, StationPoints.StationPointCode 
                      + ' - ' + StationPoints.StationPointName as StationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode
			WHERE dbo.Invoices.TransactionDate BETWEEN @FromInvoiceDate AND @ToInvoiceDate AND dbo.Invoices.PArtyCode=@CustomerCode
			AND dbo.Invoices.IsBilled=0
			ORDER BY dbo.Invoices.BranchCode,dbo.Invoices.TransactionDate

		ELSE IF @Option='FILTER_BILL'  --FILTER BILL ON RECEIPT VOUCHER
			SELECT     dbo.CustomerBills.BillNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, SUM(dbo.CustomerBillDetails.Amount) AS Amount, 
			      dbo.CustomerBills.BillDate, SUM(dbo.CustomerBillDetails.Shortage) AS Shortage
			FROM         dbo.Customers RIGHT OUTER JOIN
			      dbo.CustomerBills ON dbo.Customers.CustomerCode = dbo.CustomerBills.CustomerCode RIGHT OUTER JOIN
			      dbo.CustomerBillDetails ON dbo.CustomerBills.BillNo = dbo.CustomerBillDetails.BillNo
			WHERE dbo.CustomerBills.IsReceipt=0
			GROUP BY dbo.CustomerBills.BillNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.CustomerBills.BillDate
			HAVING  dbo.Customers.CustomerCode=@CustomerCode
	ELSE IF @Option='REPORT'
		SELECT     dbo.CustomerBillDetails.BillNo, dbo.CustomerBillDetails.BranchCode, dbo.CustomerBillDetails.InvoiceNo, dbo.Branches.BranchDescription, 
                      dbo.CustomerBillDetails.BranchCode + ' - ' + dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionDate AS InvoiceDate, 
                      dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, 
                      dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product, dbo.CustomerBillDetails.Shortage, dbo.Customers.CustomerCode, 
                      dbo.Customers.CustomerName, dbo.Customers.UrduTitle, dbo.Customers.Address, dbo.Customers.NationalTaxNumber, dbo.Customers.SalesTaxNumber, 
                      dbo.Customers.Telephone, dbo.Customers.Fax, dbo.Products.ProductCode, dbo.Products.ProductName, dbo.[Vehicles ].VehicleCode, 
                      dbo.[Vehicles ].VehicleDescription, dbo.DestinationPoints.DestinationPointCode AS DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS Destination,
                       dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName, dbo.Invoices.CustomerReference, dbo.Invoices.BranchCode AS InvBranchCode, 
                      dbo.CustomerBills.BillDate
		FROM         dbo.Products RIGHT OUTER JOIN
                      dbo.Invoices LEFT OUTER JOIN
                      dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode ON 
                      dbo.Products.ProductCode = dbo.Invoices.ProductCode LEFT OUTER JOIN
                      dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode RIGHT OUTER JOIN
                      dbo.CustomerBills INNER JOIN
                      dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode RIGHT OUTER JOIN
                      dbo.CustomerBillDetails ON dbo.CustomerBills.BillNo = dbo.CustomerBillDetails.BillNo ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode AND 
                      dbo.Invoices.BranchCode = dbo.CustomerBillDetails.BranchCode AND dbo.Invoices.TransactionNo = dbo.CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo
	ELSE IF @Option='PKVALIDATION' 
			SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
			FROM         dbo.CustomerBills LEFT OUTER JOIN
			  		dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
			WHERE dbo.CustomerBills.BillNo=@BillNo
	ELSE
		SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
			FROM         dbo.CustomerBills LEFT OUTER JOIN
			dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
			WHERE dbo.CustomerBills.BillNo=@BillNo AND dbo.Customers.CustomerCode=@CustomerCode
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionListReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionListReports]
    (
      @FromCode VARCHAR(20) = '',
      @ToCode VARCHAR(20) = '',
      @StationCode AS BIGINT = 0,
      @FromVehicleCode AS VARCHAR(10) = '0000000',
      @ToVehicleCode AS VARCHAR(10) = '99999999999',
      @FromDate DATETIME = '1/1/2000',
      @ToDate DATETIME = '12/31/9999',
      @TransactionNature AS VARCHAR(2000) = '',
      @FromTransactionNumber AS VARCHAR(20) = '0000000000',
      @ToTransactionNumber AS VARCHAR(10) = '9999999999',
      @OPTION CHAR(10) = '',
      @FromItemCode CHAR(10) = '',
      @ToItemCode CHAR(10) = '' 
    )
AS 
    SELECT  dbo.TransactionNatures.NatureCode,
            dbo.TransactionNatures.Nature,
            dbo.Branches.BranchCode,
            dbo.Branches.BranchDescription AS BranchName,
            dbo.[Vehicles ].VehicleCode,
            [Vehicles ].VehicleDescription,
            dbo.TransactionTypes.TransactionTypeCode,
            dbo.TransactionTypes.TransactionType,
            dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
            dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
            dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
            dbo.VehicleAdjustments.Description,
            dbo.VehicleAdjustments.Mode,
            dbo.VehicleAdjustments.UrduTitle,
            dbo.VehicleAdjustments.ChequeNo,
            dbo.VehicleAdjustmentDetails.Amount,
            dbo.GL_GetCOACombineLedTBRptVW.GLCode,
            dbo.GL_GetCOACombineLedTBRptVW.GLRptTitle
    FROM    dbo.TransactionNatures
            LEFT OUTER JOIN dbo.GetTransactionNatures(@TransactionNature, 'IN')
            AS GetTransactionNatures_1 ON dbo.TransactionNatures.NatureCode = GetTransactionNatures_1.NatureCode
            RIGHT OUTER JOIN dbo.VehicleAdjustments
            INNER JOIN dbo.VehicleAdjustmentDetails ON dbo.VehicleAdjustments.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                       AND dbo.VehicleAdjustments.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                       AND dbo.VehicleAdjustments.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
            INNER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                                               AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
            LEFT OUTER JOIN dbo.GL_GetCOACombineLedTBRptVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineLedTBRptVW.GLCode
            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
            LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode ON dbo.TransactionNatures.NatureCode = dbo.TransactionTypes.Nature
    WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNo BETWEEN @FromCode
                                                       AND     @ToCode
            AND dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                             AND     @ToDate
                                                             AND
                                                             dbo.VehicleAdjustments.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
    ORDER BY dbo.VehicleAdjustments.BranchCode,
            dbo.VehicleAdjustments.VehicleAdjustmentNo
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleFreightStatementsReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectVehicleFreightStatementsReports]  
@BranchCode varchar(10)='',  
@FromPartyCode varchar(10)='',  
@ToPartyCode varchar(10)='' , 
@FromCode varchar(10)='',  
@ToCode varchar(10)='' , 
@FromVehicleCode as char(10)='',
@ToVehicleCode as char(10)='',
@FromDate DateTime= NULL, 
@ToDate DateTime= NULL, 
@OPTION AS varchar(100)='',
@nType bigint =0 

AS

IF @BranchCode=''
	BEGIN
SELECT     Branches.BranchCode, Branches.BranchDescription AS Branch, Invoices.TransactionNo, Invoices.TransactionDate, 
                      Invoices.CustomerReference AS TokenNo, Customers.CustomerCode, Customers.CustomerName, DestinationPoints.DestinationPointCode, 
                      DestinationPoints.DestinationPointName, StationPoints.StationPointCode, StationPoints.StationPointName, Products.ProductCode, 
                      Products.ProductName, Invoices.Quantity, Invoices.Rate, Invoices.Commission, Invoices.ShortageQuantity, Invoices.QuantityValue, Invoices.Shortage, 
                      Invoices.Amount, Invoices.IsBilled, [Vehicles ].VehicleCode, [Vehicles ].VehicleDescription, '' AS BillNo
FROM         Invoices LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Customers ON Invoices.PartyCode = Customers.CustomerCode
	WHERE dbo.Customers.CustomerCode BETWEEN @FromPartyCode AND	@ToPartyCode 
		AND dbo.Invoices.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
		AND dbo.Invoices.TransactionNo BETWEEN @FromCode AND @ToCode
		AND dbo.Invoices.TransactionDate BETWEEN @FromDate AND @ToDate
	END
ELSE
	BEGIN
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionNo, dbo.Invoices.TransactionDate, 
	                      dbo.Invoices.CustomerReference AS TokenNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.DestinationPoints.DestinationPointCode, 
	                      dbo.DestinationPoints.DestinationPointName, dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName, dbo.Products.ProductCode, 
	                      dbo.Products.ProductName, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Commission, dbo.Invoices.ShortageQuantity, dbo.Invoices.QuantityValue, 
	                      dbo.Invoices.Shortage, dbo.Invoices.Amount, dbo.Invoices.IsBilled, dbo.[Vehicles ].VehicleCode, dbo.[Vehicles ].VehicleDescription, 
	                      dbo.CustomerBillDetails.BillNo
	FROM         dbo.Invoices LEFT OUTER JOIN
	                      dbo.CustomerBillDetails ON dbo.Invoices.BranchCode = dbo.CustomerBillDetails.BranchCode AND 
	                      dbo.Invoices.TransactionNo = dbo.CustomerBillDetails.InvoiceNo LEFT OUTER JOIN
	                      dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode LEFT OUTER JOIN
	                      dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode AND 
	                      dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode LEFT OUTER JOIN
	                      dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
	                      dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
	                      dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode LEFT OUTER JOIN
	                      dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
	WHERE  dbo.Branches.BranchCode=@BranchCode
		AND  dbo.Customers.CustomerCode BETWEEN @FromPartyCode AND	@ToPartyCode 
		AND dbo.Invoices.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
		AND dbo.Invoices.TransactionNo BETWEEN @FromCode AND @ToCode
		AND dbo.Invoices.TransactionDate BETWEEN @FromDate AND @ToDate
	END
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleBillsReportsWGL]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE SelectVehicleBillsReports  
CREATE PROCEDURE [dbo].[SelectVehicleBillsReportsWGL]
    @FromBranchCode VARCHAR(10) = '',
    @ToBranchCode VARCHAR(10) = '',
    @FromDivisionCode VARCHAR(10) = '',
    @ToDivisionCode VARCHAR(10) = '',
    @FromOwnerCode AS CHAR(10) = '',
    @ToOwnerCode AS CHAR(10) = '',
    @FromVehicleCode VARCHAR(50) = '',
    @ToVehicleCode AS CHAR(10) = '',
    @FromDate DATETIME = NULL,
    @ToDate DATETIME = NULL,
    @nType BIGINT = 0,
    @VehicleAdjustmentNatureCode VARCHAR(100) = '',
    @ReportSD AS VARCHAR(10) = 'DET',
    @Posted BIT = 1,
    @PostedED BIT = 0

--Receipt= ReceiptAmount
--Payment=PaymentAmount
AS 
    IF @nType = 0 --OPENING 1
        BEGIN			
            DECLARE @DocDate AS DATETIME
	
            IF EXISTS ( SELECT  *
                        FROM    sysobjects
                        WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                BEGIN
                    DROP TABLE  TempCOAOpening
                END
	
	-- SELECT Branch with Filter
            SELECT  BranchCode AS SysBranchCode,
                    BranchCode,
                    BranchDescription AS Branch,
                    BranchDescription AS BranchRptTitle
            INTO    #Branches
            FROM    dbo.Branches
	--WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
            CREATE INDEX #IX_Branches ON #Branches ( BranchCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]

            SELECT  OwnerCode,
                    OwnerName,
                    UrduTitle AS UrduOwnerName
            INTO    #VehicleOwnersT
            FROM    dbo.VehicleOwners
            WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                  AND     @ToOwnerCode )

	
            CREATE INDEX #IX_VehicleOwnersT ON #VehicleOwnersT ( OwnerCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
            
            SELECT  dbo.Vehicles.VehicleCode,
                    dbo.Vehicles.VehicleDescription,
                    dbo.Vehicles.UrduTitle AS UrduVehicleName,
                    dbo.Vehicles.FreightGlCode,
                    dbo.Vehicles.OwnerCode,
                    dbo.Customers.CustomerCode,
                    dbo.Customers.CustomerName,
                    dbo.Customers.UrduTitle AS UrduCustomerName,
                    dbo.Vehicles.Capacity,
                    #VehicleOwnersT.OwnerName,
                    #VehicleOwnersT.UrduOwnerName
            INTO    #VehicleT
            FROM    dbo.Vehicles
                    LEFT OUTER JOIN #VehicleOwnersT ON dbo.Vehicles.OwnerCode = #VehicleOwnersT.OwnerCode
                    LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
            WHERE   ( dbo.Vehicles.VehicleCode BETWEEN @FromVehicleCode
                                               AND     @ToVehicleCode )
	--WHERE	(dbo.Vehicles.VehicleCode ='LSA 3940')

            CREATE INDEX [#IX_VehiclesT ] ON #VehicleT ( VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
     


	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode,
                    MAX(dbo.VehicleOpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.VehicleOpeningBalances
                    INNER JOIN #Branches ON dbo.VehicleOpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #VehicleT ON dbo.VehicleOpeningBalances.VehicleCode = #VehicleT.VehicleCode
            WHERE   ( dbo.VehicleOpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, VehicleCode, ClosingDate )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.VehicleOpeningBalances.ClosingDate,
                    dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode,
                    dbo.VehicleOpeningBalances.PaymentBalance
                    - dbo.VehicleOpeningBalances.ReceiptBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.VehicleOpeningBalances
                    INNER JOIN #OpeningDate ON dbo.VehicleOpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.VehicleOpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.VehicleOpeningBalances.VehicleCode = #OpeningDate.VehicleCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
          
	


	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentDate,
                    dbo.VehicleAdjustments.VehicleCode,
                    dbo.VehicleAdjustments.RecordNo
            INTO    #TransMasterOP
            FROM    dbo.VehicleAdjustments
            WHERE   ( dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @DocDate
                                                                   AND     @ToDate )
                    AND ( dbo.VehicleAdjustments.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMasterOP ( BranchCode, VehicleAdjustmentNature, VehicleAdjustmentNo )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	

	-- SELECT Detail Transaction With Date
            SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                    #TransMasterOP.VehicleAdjustmentDate,
                    #TransMasterOP.VehicleCode,
                    #TransMasterOP.RecordNo,
                    CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                               1)
                      WHEN 'R' THEN dbo.VehicleAdjustmentDetails.Amount
                      ELSE 0
                    END AS ReceiptAmount,
                    CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                               1)
                      WHEN 'P' THEN dbo.VehicleAdjustmentDetails.Amount
                      ELSE 0
                    END AS PaymentAmount
            INTO    #TransDetail
            FROM    #TransMasterOP
                    INNER JOIN dbo.VehicleAdjustmentDetails ON #TransMasterOP.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                               AND #TransMasterOP.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                               AND #TransMasterOP.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
               
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VehicleAdjustmentDate, VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
            
            
            SELECT  BranchCode,
                    TransactionDate,
                    VehicleCode,
                    RecordNo,
                    Amount - ( Commission + Shortage ) AS ReceiptAmount,
                    0 AS PaymentAmount
            INTO    #TransMasterInvOP
            FROM    dbo.Invoices
            WHERE   ( TransactionDate BETWEEN @DocDate AND @ToDate )
                    AND ( Posted = @Posted
                          OR @PostedED = 0
                        )
            CREATE INDEX #TransMasterInvOP ON #TransMasterInvOP ( BranchCode, TransactionDate, VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY] 
            
            SELECT  *
            INTO #OpCombine
            FROM    ( SELECT    *
                      FROM      #TransDetail
                      UNION ALL
                      SELECT    *
                      FROM      #TransMasterInvOP
                    ) OP
            
	-- Select Transaction Balance
            SELECT  #OpCombine.BranchCode,
                    #OpCombine.VehicleCode,
                    SUM(#OpCombine.PaymentAmount)
                    - SUM(#OpCombine.ReceiptAmount) AS TransBalance
            INTO    #TransBalTAB
            FROM    #OpCombine
                    LEFT OUTER JOIN #OpeningDate ON #OpCombine.BranchCode = #OpeningDate.BranchCode
                                                    AND #OpCombine.VehicleAdjustmentDate > #OpeningDate.ClosingDate
                                                    AND #OpCombine.VehicleCode = #OpeningDate.VehicleCode
            GROUP BY #OpCombine.BranchCode,
                    #OpCombine.VehicleCode
	
	---   Final Opening Balance 
            SELECT  BranchCode,
                    VehicleCode,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode,
                                VehicleCode,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode,
                                VehicleCode,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode,
                    VehicleCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode,
                    #Branches.BranchRptTitle,
                    #VehicleT.VehicleCode,
                    #VehicleT.UrduCustomerName,
                    #VehicleT.OwnerCode,
                    #VehicleT.OwnerName,
                    #VehicleT.UrduOwnerName,
                    #VehicleT.CustomerCode,
                    #VehicleT.CustomerName,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpening
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #VehicleT ON #TransTAB.VehicleCode = #VehicleT.VehicleCode
            WHERE   #TransTAB.OpeningBalance <> 0
            
          
          
           
            
        END
    ELSE 
        IF @nType = 1			--Vehicle Bills All Transaction
            BEGIN
	
                IF EXISTS ( SELECT  *
                            FROM    sysobjects
                            WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                    AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                    BEGIN
                        DROP TABLE  TempTransDetailVBill
                    END

                --DECLARE @SelectedVehVehicleCode AS VARCHAR(8000)
                --SET @SelectedVehVehicleCode = GetFreightVehicleCode(@FromVehicleCode, @ToVehicleCode)
                --SET @SelectedVehVehicleCode = LTRIM(RTRIM(@SelectedVehVehicleCode))

		
                SELECT  dbo.Vehicles.VehicleCode,
                        dbo.Vehicles.VehicleDescription,
                        dbo.Vehicles.UrduTitle AS UrduVehicleName,
                        dbo.Vehicles.FreightGLCode,
                        dbo.Vehicles.OwnerCode,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Customers.UrduTitle AS UrduCustomerName,
                        dbo.[Vehicles ].Capacity
                INTO    #VehicleTAB
                FROM    dbo.Vehicles
                        LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
                WHERE   dbo.Vehicles.vehicleCode BETWEEN @FromVehicleCode
                                                 AND     @ToVehicleCode
	



                CREATE INDEX [#IX_VehiclesT ] ON #VehicleTAB ( VehicleCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT  OwnerCode,
                        OwnerName,
                        UrduTitle AS UrduOwnerName
                INTO    #VehicleOwnersTAB
                FROM    dbo.VehicleOwners
                WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                      AND     @ToOwnerCode )

	
	
                CREATE INDEX #IX_VehicleOwnersT ON #VehicleOwnersTAB ( OwnerCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
                

                SELECT  dbo.VehicleAdjustments.BranchCode,
                        dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate,
                        dbo.VehicleAdjustments.VehicleCode,
                        dbo.VehicleAdjustments.UrduTitle,
                        dbo.VehicleAdjustments.RecordNo
                INTO    #TransMasterTAB
                FROM    dbo.VehicleAdjustments
                        INNER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                WHERE   ( dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                                       AND     @ToDate )
                        AND ( dbo.VehicleAdjustments.Posted = @Posted
                              OR @PostedED = 0
                            )
                    

                CREATE INDEX #IX_TransMasterTAB ON #TransMasterTAB ( BranchCode, VehicleAdjustmentNature, VehicleAdjustmentNo )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
	
	---SELECT ALL INFORMATION OF SELECTED VEHICLE excluding trips
	

                SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                        dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature,
                        dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo,
                        #VehicleTAB.VehicleCode,
                        #VehicleTAB.OwnerCode,
                        #VehicleOwnersTAB.UrduOwnerName,
                        #VehicleTAB.CustomerCode,
                        #VehicleTAB.CustomerName,
                        #VehicleTAB.UrduCustomerName,
                        #VehicleTAB.Capacity,
                        dbo.VehicleAdjustmentDetails.TransactionTypeCode,
                        CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                                   1)
                          WHEN 'R' THEN dbo.VehicleAdjustmentDetails.Amount
                          ELSE 0
                        END AS ReceiptAmount,
                        CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                                   1)
                          WHEN 'P' THEN dbo.VehicleAdjustmentDetails.Amount
                          ELSE 0
                        END AS PaymentAmount
                INTO    #DetailVehicleAdjustments
                FROM    #VehicleOwnersTAB
                        RIGHT OUTER JOIN #TransMasterTAB
                        LEFT OUTER JOIN #VehicleTAB ON #TransMasterTAB.VehicleCode = #VehicleTAB.VehicleCode
                        RIGHT OUTER JOIN dbo.VehicleAdjustmentDetails ON #TransMasterTAB.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                                         AND #TransMasterTAB.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                                         AND #TransMasterTAB.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo ON #VehicleOwnersTAB.OwnerCode = #VehicleTAB.OwnerCode
            
	

	---SELECT ALL TRIP INFORMATION
	
                SELECT  #VehicleTAB.VehicleCode,
                        #VehicleTAB.VehicleDescription,
                        dbo.Invoices.TransactionNo,
                        dbo.Invoices.TransactionDate,
                        dbo.Invoices.CustomerReference,
                        dbo.Invoices.RecordNo,
                        dbo.Invoices.StationPointCode,
                        dbo.Invoices.DestinationPointCode,
                        dbo.Invoices.ProductCode,
                        dbo.Invoices.Quantity,
                        dbo.Invoices.Rate,
                        0 AS PaymentAmount,
                        0 AS ReceiptAmount,
                        #VehicleTAB.UrduCustomerName,
                        dbo.Invoices.Commission,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.Shortage,
                        dbo.Invoices.QuantityValue,
                        #VehicleOwnersTAB.OwnerCode,
                        #VehicleTAB.CustomerCode,
                        #VehicleTAB.CustomerName,
                        #VehicleOwnersTAB.OwnerName,
                        #VehicleOwnersTAB.UrduOwnerName,
                        dbo.StationPoints.StationPointName,
                        dbo.StationPoints.UrduTitle AS StationPointUrdu,
                        TripAdvance,
                        dbo.DestinationPoints.DestinationPointName,
                        dbo.DestinationPoints.UrduTitle AS DestinationPointUrdu,
                        dbo.Products.UrduTitle AS ProductUrdu,
                        #VehicleTAB.Capacity
                INTO    VehicleTrips
                FROM    dbo.StationPoints
                        INNER JOIN dbo.Products
                        INNER JOIN dbo.Invoices ON dbo.Products.ProductCode = dbo.Invoices.ProductCode ON dbo.StationPoints.StationPointCode = dbo.Invoices.StationPointCode
                        INNER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                        LEFT OUTER JOIN #VehicleOwnersTAB
                        RIGHT OUTER JOIN #VehicleTAB ON #VehicleOwnersTAB.OwnerCode = #VehicleTAB.OwnerCode ON dbo.Invoices.VehicleCode = #VehicleTAB.VehicleCode
                WHERE   ( dbo.Invoices.TransactionDate BETWEEN @FromDate
                                                       AND     @ToDate )
                        AND ( dbo.Invoices.Amount <> 0 )
	-- select * from VehicleTrips



                SELECT  *
                INTO    TempTransDetailVBill
                FROM    ( SELECT    'TRIP' AS MODE,
                                    TransactionNo,
                                    TransactionDate,
                                    RecordNo,
                                    CustomerReference,
                                    VehicleCode,
                                    StationPointCode,
                                    DestinationPointCode,
                                    ProductCode,
                                    Quantity,
                                    Rate,
                                    PaymentAmount,
                                    ReceiptAmount,
                                    Commission,
                                    ShortageQuantity,
                                    Shortage,
                                    QuantityValue,
                                    OwnerCode,
                                    OwnerName,
                                    UrduOwnerName,
                                    ProductUrdu,
                                    StationPointName,
                                    StationPointUrdu,
                                    DestinationPointName,
                                    DestinationPointUrdu,
                                    StationPointUrdu + ' - '
                                    + DestinationPointUrdu AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    '' AS Narration,
                                    TripAdvance
                          FROM      VehicleTrips
                          UNION ALL
                          SELECT    'OTHERS' AS MODE,
                                    #DetailVehicleAdjustments.VehicleAdjustmentNo,
                                    #TransMasterTAB.VehicleAdjustmentDate,
                                    #TransMasterTAB.RecordNo,
                                    '' AS CustomRef,
                                    #DetailVehicleAdjustments.VehicleCode,
                                    '' AS StationPointCode,
                                    '' AS DestinationPointCode,
                                    '' AS ProductCode,
                                    0 AS Quantity,
                                    0 AS Rate,
                                    #DetailVehicleAdjustments.PaymentAmount,
                                    #DetailVehicleAdjustments.ReceiptAmount,
                                    0 AS Commission,
                                    0 AS ShortageQuantity,
                                    0 AS Shortage,
                                    0 AS QuantityValue,
                                    #DetailVehicleAdjustments.OwnerCode,
                                    '' AS OwnerName,
                                    #DetailVehicleAdjustments.UrduOwnerName,
                                    '' AS ProductUrdu,
                                    '' AS StationPointName,
                                    '' AS StationPointUrdu,
                                    '' AS DestinationPointName,
                                    '' AS DestinationPointUrdu,
                                    #TransMasterTAB.UrduTitle AS GLDescription,
                                    #DetailVehicleAdjustments.CustomerCode,
                                    #DetailVehicleAdjustments.CustomerName,
                                    #DetailVehicleAdjustments.UrduCustomerName,
                                    #DetailVehicleAdjustments.Capacity,
                                    #DetailVehicleAdjustments.TransactionTypeCode AS Narration,
                                    0 AS TripAdvance
                          FROM      #TransMasterTAB
                                    INNER JOIN #DetailVehicleAdjustments ON #TransMasterTAB.BranchCode = #DetailVehicleAdjustments.BranchCode
                                                                           AND #TransMasterTAB.VehicleAdjustmentNature = #DetailVehicleAdjustments.VehicleAdjustmentNature
                                                                           AND #TransMasterTAB.VehicleAdjustmentNo = #DetailVehicleAdjustments.VehicleAdjustmentNo
                                    LEFT OUTER JOIN #VehicleTAB ON #DetailVehicleAdjustments.VehicleCode = #VehicleTAB.VehicleCode
                        ) Bills
                WHERE   ( TransactionDate BETWEEN @FromDate AND @ToDate )
                        AND ( VehicleCode BETWEEN @FromVehicleCode
                                          AND     @ToVehicleCode )
                        AND ( OwnerCode BETWEEN @FromOwnerCode AND @ToOwnerCode )
	--AND  ',' + @SelectedVehVehicleCode + ','   NOT LIKE '%,' + CAST(  VehicleCode as varchar) + ',%' OR @SelectedVehVehicleCode = ''


              
                
             
               
           
                DROP TABLE VehicleTrips

            END
        ELSE 
            IF @nType = 4		--  GET Transaction Detail
                BEGIN
                    IF EXISTS ( SELECT  *
                                FROM    sysobjects
                                WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                        AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                        BEGIN
                            SELECT  *
                            FROM    TempTransDetailVBill
                            ORDER BY TransactionDate,
                                    TransactionNo
		--DROP TABLE  TempTransDetailVBill
                        END
                    ELSE 
                        BEGIN
                            SELECT  '' AS Error
                            WHERE   0 = 1
                        END
                END
            ELSE 
                IF @nType = 3 
                    BEGIN
                        IF EXISTS ( SELECT  *
                                    FROM    sysobjects
                                    WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                            AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                            BEGIN
                                SELECT  *
                                FROM    TempCOAOpening
                                DROP TABLE  TempCOAOpening
                            END
                        ELSE 
                            BEGIN
                                SELECT  '' AS Error
                                WHERE   0 = 1
                            END
                    END
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleBillsReports]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleBillsReports]
    @FromBranchCode VARCHAR(10) = '',
    @ToBranchCode VARCHAR(10) = '',
    @FromDivisionCode VARCHAR(10) = '',
    @ToDivisionCode VARCHAR(10) = '',
    @FromOwnerCode AS CHAR(10) = '',
    @ToOwnerCode AS CHAR(10) = '',
    @FromGLCode VARCHAR(50) = '',
    @FromVehicleCode AS CHAR(10) = '',
    @ToVehicleCode AS CHAR(10) = '',
    @ToGLCode VARCHAR(50) = '',
    @FromDate DATETIME = NULL,
    @ToDate DATETIME = NULL,
    @nType BIGINT = 0,
    @VoucherNatureCode VARCHAR(100) = '',
    @ReportSD AS VARCHAR(10) = 'DET',
    @Posted BIT = 1,
    @PostedED BIT = 0
AS 
    IF @nType = 0 --OPENING 1
        BEGIN			
            DECLARE @DocDate AS DATETIME
	
            IF EXISTS ( SELECT  *
                        FROM    sysobjects
                        WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                BEGIN
                    DROP TABLE  TempCOAOpening
                END
	
	-- SELECT Division with Filter
            SELECT  DivisionCode AS SysDivisionCode,
                    DivisionCode,
                    Division,
                    Division AS DivisionRptTitle
            INTO    #Divisions
            FROM    dbo.Divisions
	--WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
            CREATE INDEX #IX_Divisions ON #Divisions ( DivisionCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	-- SELECT Branch with Filter
            SELECT  BranchCode AS SysBranchCode,
                    BranchCode,
                    BranchDescription AS Branch,
                    BranchDescription AS BranchRptTitle
            INTO    #Branches
            FROM    dbo.Branches
	--WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
            CREATE INDEX #IX_Branches ON #Branches ( BranchCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]

            SELECT  dbo.Vehicles.VehicleCode,
                    dbo.Vehicles.VehicleDescription,
                    dbo.Vehicles.UrduTitle AS UrduVehicleName,
                    dbo.Vehicles.FreightGLCode,
                    dbo.Vehicles.OwnerCode,
                    dbo.Customers.CustomerCode,
                    dbo.Customers.CustomerName,
                    dbo.Customers.UrduTitle AS UrduCustomerName,
                    dbo.Vehicles.Capacity
            INTO    #VehiclesTAB
            FROM    dbo.Vehicles
                    LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
            WHERE   ( dbo.Vehicles.VehicleCode BETWEEN @FromVehicleCode
                                               AND     @ToVehicleCode )
	--WHERE	(dbo.Vehicles.VehicleCode ='LSA 3940')

            CREATE INDEX [#IX_VehiclesT ] ON #VehiclesTAB ( VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]

            SELECT  OwnerCode,
                    OwnerName,
                    UrduTitle AS UrduOwnerName
            INTO    #VehicleOwners
            FROM    dbo.VehicleOwners
            WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                  AND     @ToOwnerCode )

	
            CREATE INDEX #IX_#VehicleOwners ON #VehicleOwners ( OwnerCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	

	-- SELECT GLAccount with Filter on Vehicle & Owner

            SELECT  dbo.GL_GetCOACombineLedTBRptVW.GLCode,
                    dbo.GL_GetCOACombineLedTBRptVW.GLRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.ControlCode,
                    dbo.GL_GetCOACombineLedTBRptVW.ControlRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.GeneralCode,
                    dbo.GL_GetCOACombineLedTBRptVW.GeneralRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.SubSidiaryCode,
                    dbo.GL_GetCOACombineLedTBRptVW.SubsidiaryRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.SubsubCode,
                    dbo.GL_GetCOACombineLedTBRptVW.SubSubRptTitle,
                    dbo.#VehiclesTAB.VehicleCode,
                    dbo.#VehiclesTAB.VehicleDescription,
                    dbo.VehicleOwners.OwnerCode,
                    dbo.VehicleOwners.OwnerName,
                    dbo.VehicleOwners.UrduTitle AS UrduOwnerName,
                    dbo.#VehiclesTAB.CustomerCode,
                    dbo.#VehiclesTAB.CustomerName,
                    dbo.#VehiclesTAB.UrduCustomerName
            INTO    #COACombineLedTBRptVW
            FROM    dbo.GL_GetCOACombineLedTBRptVW
                    INNER JOIN dbo.#VehiclesTAB ON dbo.GL_GetCOACombineLedTBRptVW.GLCode = dbo.#VehiclesTAB.FreightGLCode
                    LEFT OUTER JOIN dbo.VehicleOwners ON dbo.#VehiclesTAB.OwnerCode = dbo.VehicleOwners.OwnerCode
	
            CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( GLCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
            
            


	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode,
                    MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.OpeningBalances
                    INNER JOIN #Branches ON dbo.OpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #COACombineLedTBRptVW ON dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.GLCode
                    INNER JOIN #Divisions ON dbo.OpeningBalances.DivisionCode = #Divisions.DivisionCode
            WHERE   ( dbo.OpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.OpeningBalances.ClosingDate,
                    dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode,
                    dbo.OpeningBalances.DebitBalance
                    - dbo.OpeningBalances.CreditBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.OpeningBalances
                    INNER JOIN #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode
                                               AND dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
            PRINT @DocDate
	


	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.Vouchers.BranchCode,
                    dbo.Vouchers.VoucherNature,
                    dbo.Vouchers.VoucherNo,
                    dbo.Vouchers.VoucherDate,
                    dbo.Vouchers.RecordNo
            INTO    #TransMasterTAB
            FROM    dbo.Vouchers
                    INNER JOIN #Branches ON dbo.Vouchers.BranchCode = #Branches.BranchCode
            WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @DocDate
                                               AND     @ToDate )
                    AND ( dbo.Vouchers.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMasterTAB ( BranchCode, VoucherNature, VoucherNo )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
	-- SELECT Detail Transaction With Date
            SELECT  dbo.VoucherDetails.BranchCode,
                    #TransMasterTAB.VoucherDate,
                    dbo.VoucherDetails.GLCode,
                    #TransMasterTAB.RecordNo,
                    dbo.VoucherDetails.DivisionCode AS Division,
                    dbo.VoucherDetails.Debit,
                    dbo.VoucherDetails.Credit
            INTO    #TransDetail
            FROM    #TransMasterTAB
                    INNER JOIN dbo.VoucherDetails ON #TransMasterTAB.BranchCode = dbo.VoucherDetails.BranchCode
                                                     AND #TransMasterTAB.VoucherNature = dbo.VoucherDetails.VoucherNature
                                                     AND #TransMasterTAB.VoucherNo = dbo.VoucherDetails.VoucherNo
                    INNER JOIN #Divisions ON dbo.VoucherDetails.DivisionCode = #Divisions.DivisionCode
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, Division )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
	-- Select Transaction Balance
            SELECT  #TransDetail.BranchCode,
                    #TransDetail.Division,
                    #TransDetail.GLCode,
                    SUM(#TransDetail.Debit) - SUM(#TransDetail.Credit) AS TransBalance
            INTO    #TransBalTAB
            FROM    #TransDetail
                    LEFT OUTER JOIN #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode
                                                    AND #TransDetail.VoucherDate > #OpeningDate.ClosingDate
                                                    AND #TransDetail.GLCode = #OpeningDate.GLCode
                                                    AND #TransDetail.Division = #OpeningDate.DivisionCode
            GROUP BY #TransDetail.BranchCode,
                    #TransDetail.Division,
                    #TransDetail.GLCode
	
	---   Final Opening Balance 
            SELECT  BranchCode,
                    DivisionCode,
                    GLCode,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode,
                                DivisionCode,
                                GLCode,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode,
                                Division,
                                GLCode,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode,
                    DivisionCode,
                    GLCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode,
                    #Branches.BranchRptTitle,
                    #Divisions.DivisionCode,
                    #Divisions.DivisionRptTitle,
                    #COACombineLedTBRptVW.GLCode,
                    #COACombineLedTBRptVW.GLRptTitle AS GLDescription,
                    #COACombineLedTBRptVW.VehicleCode,
                    #COACombineLedTBRptVW.UrduCustomerName,
                    #COACombineLedTBRptVW.OwnerCode,
                    #COACombineLedTBRptVW.OwnerName,
                    #COACombineLedTBRptVW.UrduOwnerName,
                    #COACombineLedTBRptVW.CustomerCode,
                    #COACombineLedTBRptVW.CustomerName,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpening
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #Divisions ON #TransTAB.DivisionCode = #Divisions.DivisionCode
                    INNER JOIN #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.GLCode
            WHERE   #TransTAB.OpeningBalance <> 0
        END
    ELSE 
        IF @nType = 1			--Vehicle Bills All Transaction
            BEGIN
	
                IF EXISTS ( SELECT  *
                            FROM    sysobjects
                            WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                    AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                    BEGIN
                        DROP TABLE  TempTransDetailVBill
                    END

                DECLARE @SelectedVehGLCode AS VARCHAR(8000)
                SET @SelectedVehGLCode = dbo.GetFreightGLCode(@FromVehicleCode, @ToVehicleCode)
                SET @SelectedVehGLCode = LTRIM(RTRIM(@SelectedVehGLCode))

		
                SELECT  dbo.Vehicles.VehicleCode,
                        dbo.Vehicles.VehicleDescription,
                        dbo.Vehicles.UrduTitle AS UrduVehicleName,
                        dbo.Vehicles.FreightGLCode,
                        dbo.Vehicles.OwnerCode,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Customers.UrduTitle AS UrduCustomerName,
                        dbo.[Vehicles ].Capacity
                INTO    #VehiclesT
                FROM    dbo.Vehicles
                        LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
                WHERE   dbo.Vehicles.vehicleCode BETWEEN @FromVehicleCode
                                                 AND     @ToVehicleCode
	



                CREATE INDEX [#IX_VehiclesT ] ON #VehiclesT ( VehicleCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT  OwnerCode,
                        OwnerName,
                        UrduTitle AS UrduOwnerName
                INTO    #VehicleOwnersTAB
                FROM    dbo.VehicleOwners
                WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                      AND     @ToOwnerCode )

	
	
                CREATE INDEX #IX_#VehicleOwnersTAB ON #VehicleOwnersTAB ( OwnerCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
                SELECT  GLCode,
                        GLRptTitle,
                        ControlCode,
                        ControlRptTitle,
                        GeneralCode,
                        GeneralRptTitle,
                        SubSidiaryCode,
                        SubsidiaryRptTitle,
                        SubsubCode,
                        SubSubRptTitle
                INTO    #COACombineLedTBRptVWT
                FROM    dbo.GL_GetCOACombineLedTBRptVW

                CREATE INDEX #IX_#COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( GLCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT DISTINCT dbo.Vouchers.BranchCode,
                        dbo.Vouchers.VoucherNature,
                        dbo.Vouchers.VoucherNo,
                        dbo.Vouchers.VoucherDate,
                        dbo.Vouchers.UrduTitle,
                        dbo.Vouchers.RecordNo
                INTO    #TransMaster
                FROM    dbo.Vouchers
                        INNER JOIN dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode
                WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                   AND     @ToDate )
                        AND ( dbo.Vouchers.Posted = @Posted
                              OR @PostedED = 0
                            )
                        AND ( dbo.Vouchers.VoucherNature <> 'SV' )

                CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
	
	---SELECT ALL INFORMATION OF SELECTED VEHICLE excluding trips
	

                SELECT   dbo.VoucherDetails.BranchCode,
                        dbo.VoucherDetails.VoucherNature,
                        dbo.VoucherDetails.VoucherNo,
                        dbo.#VehiclesT.VehicleCode,
                        dbo.#VehiclesT.OwnerCode,
                        dbo.#VehicleOwnersTAB.UrduOwnerName,
                        dbo.#VehiclesT.CustomerCode,
                        dbo.#VehiclesT.CustomerName,
                        dbo.#VehiclesT.UrduCustomerName,
                        dbo.#VehiclesT.Capacity
                INTO    #DetailVehicleVouchers
                FROM    dbo.VoucherDetails
                        INNER JOIN dbo.#VehiclesT ON dbo.VoucherDetails.GLCode = dbo.#VehiclesT.FreightGLCode
                        LEFT OUTER JOIN dbo.#VehicleOwnersTAB ON dbo.#VehiclesT.OwnerCode = dbo.#VehicleOwnersTAB.OwnerCode
                        LEFT OUTER JOIN dbo.#TransMaster ON dbo.VoucherDetails.BranchCode = dbo.#TransMaster.BranchCode
                                                           AND dbo.VoucherDetails.VoucherNature = dbo.#TransMaster.VoucherNature
                                                           AND dbo.VoucherDetails.VoucherNo = dbo.#TransMaster.VoucherNo
                WHERE   ( dbo.VoucherDetails.VoucherNature <> 'SV' )



	---SELECTED ALL INFORMATION  vehicle transaction i.e. instalment , trip advance etc
	
                SELECT  dbo.VoucherDetails.BranchCode,
                        dbo.VoucherDetails.VoucherNature,
                        dbo.VoucherDetails.VoucherNo,
                        #DetailVehicleVouchers.VehicleCode,
                        #DetailVehicleVouchers.CustomerCode,
                        #DetailVehicleVouchers.Capacity,
                        dbo.VoucherDetails.Narration,
                        #DetailVehicleVouchers.CustomerName,
                        #DetailVehicleVouchers.UrduCustomerName,
                        #DetailVehicleVouchers.OwnerCode,
                        #DetailVehicleVouchers.UrduOwnerName,
                        dbo.VoucherDetails.Debit,
                        dbo.VoucherDetails.Credit,
                        dbo.VoucherDetails.GLCode
                INTO    #DetailExcVehicleVouchers
                FROM    dbo.VoucherDetails
                        INNER JOIN dbo.#DetailVehicleVouchers ON dbo.VoucherDetails.BranchCode = dbo.#DetailVehicleVouchers.BranchCode
                                                                AND dbo.VoucherDetails.VoucherNature = dbo.#DetailVehicleVouchers.VoucherNature
                                                                AND dbo.VoucherDetails.VoucherNo = dbo.#DetailVehicleVouchers.VoucherNo
                WHERE   dbo.VoucherDetails.GLCode IN ( SELECT   FreightGLCode
                                                       FROM     #VehiclesT )
	--Where   ',' + @SelectedVehGLCode + ','  LIKE '%,' + CAST(  dbo.VoucherDetails.GLCode as varchar) + ',%' OR @SelectedVehGLCode = ''	          
	
--SELECT * FROM #DetailExcVehicleVouchers
	---SELECT ALL TRIP INFORMATION
	
                SELECT  dbo.#VehiclesT.VehicleCode,
                        dbo.#VehiclesT.VehicleDescription,
                        dbo.Invoices.TransactionNo,
                        dbo.Invoices.TransactionDate,
                        dbo.Invoices.CustomerReference,
                        dbo.Invoices.RecordNo,
                        dbo.Invoices.StationPointCode,
                        dbo.Invoices.DestinationPointCode,
                        dbo.Invoices.ProductCode,
                        dbo.Invoices.Quantity,
                        dbo.Invoices.Rate,
                        0 AS Debit,
                        0 AS Credit,
                        dbo.#VehiclesT.UrduCustomerName,
                        dbo.Invoices.Commission,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.Shortage,
                        dbo.Invoices.QuantityValue,
                        dbo.#VehicleOwnersTAB.OwnerCode,
                        dbo.#VehiclesT.CustomerCode,
                        dbo.#VehiclesT.CustomerName,
                        dbo.#VehicleOwnersTAB.OwnerName,
                        dbo.#VehicleOwnersTAB.UrduOwnerName,
                        dbo.StationPoints.StationPointName,
                        dbo.StationPoints.UrduTitle AS StationPointUrdu,
                        TripAdvance,
                        dbo.DestinationPoints.DestinationPointName,
                        dbo.DestinationPoints.UrduTitle AS DestinationPointUrdu,
                        dbo.Products.UrduTitle AS ProductUrdu,
                        dbo.#VehiclesT.Capacity
                INTO    #VehiclesTrips
                FROM    dbo.StationPoints
                        INNER JOIN dbo.Products
                        INNER JOIN dbo.Invoices ON dbo.Products.ProductCode = dbo.Invoices.ProductCode ON dbo.StationPoints.StationPointCode = dbo.Invoices.StationPointCode
                        INNER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                        LEFT OUTER JOIN dbo.#VehicleOwnersTAB
                        RIGHT OUTER JOIN dbo.#VehiclesT ON dbo.#VehicleOwnersTAB.OwnerCode = dbo.#VehiclesT.OwnerCode ON dbo.Invoices.VehicleCode = dbo.#VehiclesT.VehicleCode
                WHERE   ( dbo.Invoices.TransactionDate BETWEEN @FromDate
                                                       AND     @ToDate )
                        AND dbo.Invoices.Amount <> 0
	-- select * from #VehiclesTrips



                SELECT  *
                INTO    TempTransDetailVBill
                FROM    ( SELECT    'TRIP' AS MODE,
                                    TransactionNo,
                                    TransactionDate,
                                    RecordNo,
                                    CustomerReference,
                                    VehicleCode,
                                    StationPointCode,
                                    DestinationPointCode,
                                    ProductCode,
                                    Quantity,
                                    Rate,
                                    Debit,
                                    Credit,
                                    Commission,
                                    ShortageQuantity,
                                    Shortage,
                                    QuantityValue,
                                    OwnerCode,
                                    OwnerName,
                                    UrduOwnerName,
                                    ProductUrdu,
                                    StationPointName,
                                    StationPointUrdu,
                                    DestinationPointName,
                                    DestinationPointUrdu,
                                    '' AS GLCode,
                                    StationPointUrdu + ' - '
                                    + DestinationPointUrdu AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    '' AS Narration,
                                    TripAdvance
                          FROM      dbo.#VehiclesTrips
                          UNION ALL
                          SELECT    'OTHERS' AS MODE,
                                    dbo.#DetailExcVehicleVouchers.VoucherNo,
                                    dbo.#TransMaster.VoucherDate,
                                    dbo.#TransMaster.RecordNo,
                                    '' AS CustomRef,
                                    #DetailExcVehicleVouchers.VehicleCode,
                                    '' AS StationPointCode,
                                    '' AS DestinationPointCode,
                                    '' AS ProductCode,
                                    0 AS Quantity,
                                    0 AS Rate,
                                    dbo.#DetailExcVehicleVouchers.Debit,
                                    dbo.#DetailExcVehicleVouchers.Credit,
                                    0 AS Commission,
                                    0 AS ShortageQuantity,
                                    0 AS Shortage,
                                    0 AS QuantityValue,
                                    #DetailExcVehicleVouchers.OwnerCode,
                                    '' AS OwnerName,
                                    #DetailExcVehicleVouchers.UrduOwnerName,
                                    '' AS ProductUrdu,
                                    '' AS StationPointName,
                                    '' AS StationPointUrdu,
                                    '' AS DestinationPointName,
                                    '' AS DestinationPointUrdu,
                                    dbo.#COACombineLedTBRptVWT.GLCode,
                                    dbo.#TransMaster.UrduTitle AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    #DetailExcVehicleVouchers.Narration,
                                    0 AS TripAdvance
                          FROM      dbo.#TransMaster
                                    INNER JOIN dbo.#DetailExcVehicleVouchers ON dbo.#TransMaster.BranchCode = dbo.#DetailExcVehicleVouchers.BranchCode
                                                                               AND dbo.#TransMaster.VoucherNature = dbo.#DetailExcVehicleVouchers.VoucherNature
                                                                               AND dbo.#TransMaster.VoucherNo = dbo.#DetailExcVehicleVouchers.VoucherNo
                                    LEFT OUTER JOIN dbo.#COACombineLedTBRptVWT ON dbo.#DetailExcVehicleVouchers.GLCode = dbo.#COACombineLedTBRptVWT.GLCode
                        ) Bills
                WHERE   ( TransactionDate BETWEEN @FromDate AND @ToDate )
                        AND ( VehicleCode BETWEEN @FromVehicleCode
                                          AND     @ToVehicleCode )
                        AND ( OwnerCode BETWEEN @FromOwnerCode AND @ToOwnerCode )
	--AND  ',' + @SelectedVehGLCode + ','   NOT LIKE '%,' + CAST(  GLCODE as varchar) + ',%' OR @SelectedVehGLCode = ''

          
                
             
             

            END
        ELSE 
            IF @nType = 4		--  GET Transaction Detail
                BEGIN
                    IF EXISTS ( SELECT  *
                                FROM    sysobjects
                                WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                        AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                        BEGIN
                            SELECT  *
                            FROM    TempTransDetailVBill
                            ORDER BY TransactionDate,
                                    TransactionNo
		--DROP TABLE  TempTransDetailVBill
                        END
                    ELSE 
                        BEGIN
                            SELECT  '' AS Error
                            WHERE   0 = 1
                        END
                END
            ELSE 
                IF @nType = 3 
                    BEGIN
                        IF EXISTS ( SELECT  *
                                    FROM    sysobjects
                                    WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                            AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                            BEGIN
                                SELECT  *
                                FROM    TempCOAOpening
                                DROP TABLE  TempCOAOpening
                            END
                        ELSE 
                            BEGIN
                                SELECT  '' AS Error
                                WHERE   0 = 1
                            END
                    END
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleAdjustmentsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleAdjustmentsDetails]
    @Option AS VARCHAR(300) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(10) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = ''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                dbo.VehicleAdjustmentDetails.GLCode,
                dbo.GL_GetCOACombineVW.GLDescription,
                dbo.VehicleAdjustmentDetails.DivisionCode,
                dbo.Divisions.Division,
                dbo.TransactionTypes.TransactionTypeCode AS TypeCode,
                dbo.TransactionTypes.TransactionType AS Type,
                dbo.VehicleAdjustmentDetails.Amount,
                dbo.VehicleAdjustmentDetails.UrduDescription
        FROM    dbo.VehicleAdjustmentDetails
                LEFT OUTER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustmentDetails.BranchCode = dbo.Branches.BranchCode
                LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                LEFT OUTER JOIN dbo.GL_GetCOACombineVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
    ELSE 
        IF @Option = 'DateFilter' 
            SELECT  VehicleAdjustmentDetails.BranchCode,
                    VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                    VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                    VehicleAdjustmentDetails.GLCode,
                    GL_GetCOACombineVW.GLDescription,
                    VehicleAdjustmentDetails.DivisionCode,
                    Divisions.Division,
                    TransactionTypes.TransactionTypeCode AS TypeCode,
                    TransactionTypes.TransactionType AS Type,
                    VehicleAdjustmentDetails.Amount,
                    VehicleAdjustmentDetails.UrduDescription
            FROM    VehicleAdjustmentDetails
                    INNER JOIN VehicleAdjustments ON VehicleAdjustmentDetails.BranchCode = VehicleAdjustments.BranchCode
                                                     AND VehicleAdjustmentDetails.VehicleAdjustmentNature = VehicleAdjustments.VehicleAdjustmentNature
                                                     AND VehicleAdjustmentDetails.VehicleAdjustmentNo = VehicleAdjustments.VehicleAdjustmentNo
                    LEFT OUTER JOIN Branches ON VehicleAdjustmentDetails.BranchCode = Branches.BranchCode
                    LEFT OUTER JOIN TransactionTypes ON VehicleAdjustmentDetails.TransactionTypeCode = TransactionTypes.TransactionTypeCode
                    LEFT OUTER JOIN Divisions ON VehicleAdjustmentDetails.DivisionCode = Divisions.DivisionCode
                    LEFT OUTER JOIN GL_GetCOACombineVW ON VehicleAdjustmentDetails.GLCode = GL_GetCOACombineVW.GLCode
            WHERE   dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                                 AND     @ToDate
                    AND dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
            ORDER BY dbo.VehicleAdjustments.RecordNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo
        ELSE 
            SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                    dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                    dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                    dbo.VehicleAdjustmentDetails.GLCode,
                    dbo.GL_GetCOACombineVW.GLDescription,
                    dbo.VehicleAdjustmentDetails.DivisionCode,
                    dbo.Divisions.Division,
                    dbo.TransactionTypes.TransactionTypeCode AS TypeCode,
                    dbo.TransactionTypes.TransactionType AS Type,
                    dbo.VehicleAdjustmentDetails.Amount,
                    dbo.VehicleAdjustmentDetails.UrduDescription
            FROM    dbo.VehicleAdjustmentDetails
                    LEFT OUTER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                    LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustmentDetails.BranchCode = dbo.Branches.BranchCode
                    LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                    LEFT OUTER JOIN dbo.GL_GetCOACombineVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND VehicleAdjustmentDetails.BranchCode = @BranchCode
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleAdjustments]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec SelectVehicleAdjustments @VehicleCode = N'PP-0226', @BranchCode = N'01', @TransactionDate = 'Nov  6 2009 12:00AM', @TransactionTypeCode = N'01', @TransactionNo = N'0911000001', @OPTION = N'FILTER_ADVANCE_WithNo'


CREATE  PROCEDURE [dbo].[SelectVehicleAdjustments]
    @Option AS VARCHAR(40) = '',
    @BranchCode AS CHAR(10) = '',
    @TransactionNo AS CHAR(10) = '',
    @TransactionNature AS CHAR(3) = '',
    @TransactionDate AS DATETIME = '',
    @Nature AS CHAR(3) = '',
    @VehicleCode AS CHAR(10) = '',
    @InvoiceNo AS VARCHAR(10) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
    @TransactionTypeCode CHAR(2) = '',
    @YearMonth AS VARCHAR(4) = ''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                dbo.VehicleAdjustments.Description,
                dbo.VehicleAdjustments.UrduTitle,
                dbo.VehicleAdjustments.Locked,
                dbo.VehicleAdjustments.Posted,
                dbo.VehicleAdjustments.RecordNo,
                dbo.VehicleAdjustments.GUID,
                dbo.VehicleAdjustments.BranchCode,
                dbo.Branches.BranchDescription AS BranchName,
                dbo.[Vehicles ].VehicleCode,
                dbo.[Vehicles ].VehicleDescription,
                dbo.VehicleAdjustments.ChequeNo,
                dbo.VehicleAdjustments.Mode
        FROM    dbo.VehicleAdjustments
                LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
        WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
        ORDER BY dbo.VehicleAdjustments.BranchCode,
                dbo.VehicleAdjustments.VehicleAdjustmentNature,
                dbo.VehicleAdjustments.VehicleAdjustmentNo 
    ELSE 
        IF @Option = 'DateFilter' 
            SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                    dbo.VehicleAdjustments.Description,
                    dbo.VehicleAdjustments.UrduTitle,
                    dbo.VehicleAdjustments.Locked,
                    dbo.VehicleAdjustments.Posted,
                    dbo.VehicleAdjustments.RecordNo,
                    dbo.VehicleAdjustments.GUID,
                    dbo.VehicleAdjustments.BranchCode,
                    dbo.Branches.BranchDescription AS BranchName,
                    dbo.[Vehicles ].VehicleCode,
                    dbo.[Vehicles ].VehicleDescription,
                    dbo.VehicleAdjustments.ChequeNo,
                    dbo.VehicleAdjustments.Mode
            FROM    dbo.VehicleAdjustments
                    LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                    LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
            WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                    AND dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @fromDate
                                                                     AND     @ToDate
            ORDER BY dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo 
        ELSE 
            IF @option = 'FILTER_ADVANCE' 
                SELECT  dbo.[Vehicles ].VehicleCode,
                        dbo.Branches.BranchCode,
                        dbo.Branches.BranchDescription AS BranchName,
                        dbo.VehicleAdjustmentDetails.Amount,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate,
                        dbo.VehicleAdjustments.VehicleAdjustmentNature
                FROM    dbo.VehicleAdjustments
                        RIGHT OUTER JOIN dbo.VehicleAdjustmentDetails ON dbo.VehicleAdjustments.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                                         AND dbo.VehicleAdjustments.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                                         AND dbo.VehicleAdjustments.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
                        LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                        LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                WHERE   ( dbo.[Vehicles ].VehicleCode = @VehicleCode
                          AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = @TransactionTypeCode
                          AND dbo.VehicleAdjustments.BranchCode = @BranchCode
                          AND dbo.VehicleAdjustments.VehicleAdjustmentDate <= @TransactionDate
                         -- AND DBO.VehicleAdjustmentDetails.InvoiceRefNo = ''
                          
                        )
                        --true when new record
                        AND NOT (
                        --FALSE when edit
                                  DBO.VehicleAdjustmentDetails.InvoiceRefNo <> @InvoiceNo
                                  AND DBO.VehicleAdjustmentDetails.InvoiceRefNo <> ''
                                )
    IF @option = 'FILTER_ADVANCE_WithNo' 
        SELECT  dbo.[Vehicles ].VehicleCode,
                dbo.Branches.BranchCode,
                dbo.Branches.BranchDescription AS BranchName,
                dbo.VehicleAdjustments.VehicleAdjustmentNature,
                dbo.VehicleAdjustments.VehicleAdjustmentNo,
                dbo.VehicleAdjustments.VehicleAdjustmentDate,
                dbo.VehicleAdjustmentDetails.Amount
        FROM    dbo.VehicleAdjustments
                RIGHT OUTER JOIN dbo.VehicleAdjustmentDetails ON dbo.VehicleAdjustments.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                                 AND dbo.VehicleAdjustments.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                                 AND dbo.VehicleAdjustments.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
                LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
        WHERE   dbo.[Vehicles ].VehicleCode = @VehicleCode
                AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = @TransactionTypeCode
                AND dbo.VehicleAdjustments.BranchCode = @BranchCode
                AND dbo.VehicleAdjustments.VehicleAdjustmentDate <= @TransactionDate
                AND dbo.VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
              --  AND DBO.VehicleAdjustmentDetails.InvoiceRefNo = ''
                AND NOT (
                        --FALSE when edit
                          DBO.VehicleAdjustmentDetails.InvoiceRefNo <> @InvoiceNo
                          AND DBO.VehicleAdjustmentDetails.InvoiceRefNo <> ''
                        )
    ELSE 
        IF @Option = 'AUTO' 
            SELECT TOP 1
                    VehicleAdjustmentNo AS TransactionNo
            FROM    dbo.VehicleAdjustments
            WHERE   ( SUBSTRING(CAST(VehicleAdjustmentNo AS VARCHAR(4)), 1, 4) = @YearMonth )
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
            ORDER BY VehicleAdjustmentNo DESC
        ELSE 
            IF @Option = 'REPORT' 
                SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate,
                        dbo.VehicleAdjustments.Description,
                        dbo.VehicleAdjustmentDetails.UrduDescription,
                        dbo.VehicleAdjustmentDetails.Amount,
                        dbo.Branches.BranchCode,
                        dbo.Branches.BranchDescription,
                        dbo.Divisions.DivisionCode,
                        dbo.Divisions.Division,
                        dbo.GL_GetCOACombineTransactionVW.GLCode,
                        dbo.VehicleAdjustments.Mode,
                        dbo.GL_GetCOACombineTransactionVW.GLDescription,
                        dbo.[Vehicles ].VehicleCode,
                        dbo.[Vehicles ].VehicleDescription,
                        dbo.VehicleAdjustments.ChequeNo
                FROM    dbo.VehicleAdjustmentDetails
                        INNER JOIN dbo.VehicleAdjustments ON dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo = dbo.VehicleAdjustments.VehicleAdjustmentNo
                                                             AND dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature = dbo.VehicleAdjustments.VehicleAdjustmentNature
                        LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                        LEFT OUTER JOIN dbo.GL_GetCOACombineTransactionVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
                        LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                        LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                        AND dbo.VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
                ORDER BY dbo.VehicleAdjustments.BranchCode,
                        dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo 
            ELSE 
                SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                        dbo.VehicleAdjustments.Description,
                        dbo.VehicleAdjustments.UrduTitle,
                        dbo.VehicleAdjustments.Locked,
                        dbo.VehicleAdjustments.Posted,
                        dbo.VehicleAdjustments.RecordNo,
                        dbo.VehicleAdjustments.GUID,
                        dbo.VehicleAdjustments.BranchCode,
                        dbo.Branches.BranchDescription AS BranchName,
                        dbo.VehicleAdjustments.ChequeNo,
                        dbo.VehicleAdjustments.Mode,
                        dbo.[Vehicles ].VehicleCode,
                        dbo.[Vehicles ].VehicleDescription,
                        dbo.VehicleAdjustments.Mode
                FROM    dbo.VehicleAdjustments
                        LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                        LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                        AND VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
                        AND VehicleAdjustments.BranchCode = @BranchCode
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionTypes]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectTransactionTypes]
    (
      @OPTION AS VARCHAR(100) = '' ,
      @TransactionTypeCode AS VARCHAR(100) = '' ,
      @NatureCode AS VARCHAR(100) = ''

      
    )
AS 
    IF @OPTION = 'TRL' 
        SELECT  TransactionTypes.TransactionTypeCode ,
                TransactionTypes.TransactionType ,
                TransactionTypes.UrduTitle ,
                TransactionTypes.DefinitionDate ,
                TransactionNatures.NatureCode ,
                TransactionTypes.Nature ,
                GL.GLCode ,
                GL.GLDescription
        FROM    TransactionTypes
                INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
                LEFT  JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
        WHERE   ( TransactionNatures.System = 'IN' )
    ELSE 
        IF @Option = 'AUTO' 
            SELECT TOP 1
                    TransactionTypeCode + 1 AS TransactionTypeCode
            FROM    dbo.TransactionTypes
            ORDER BY TransactionTypeCode DESC
        ELSE 
            IF @OPTION = 'ALL' 
                SELECT  TransactionTypes.TransactionTypeCode ,
                        TransactionTypes.TransactionType ,
                        TransactionTypes.UrduTitle ,
                        TransactionTypes.DefinitionDate ,
                        TransactionNatures.NatureCode ,
                        TransactionTypes.Nature ,
                        GL.GLCode ,
                        GL.GLDescription
                FROM    TransactionTypes
                        INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
                        LEFT  JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
                WHERE   ( TransactionNatures.System = 'IN' )
            ELSE 
                IF @OPTION = 'COMBO' 
                    SELECT  TransactionTypeCode AS TypeCode ,
                            TransactionType AS Type ,
                            UrduTitle
                    FROM    TransactionTypes
                    WHERE   Nature = @NatureCode
                ELSE 
                    IF @OPTION = 'SRHGRID' 
                        SELECT  TransactionTypes.TransactionTypeCode ,
                                TransactionTypes.TransactionType ,
                                TransactionTypes.UrduTitle ,
                                TransactionTypes.DefinitionDate ,
                                TransactionNatures.NatureCode ,
                                TransactionTypes.Nature
                        FROM    TransactionTypes
                                INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
                    ELSE 
                        IF @OPTION = N'PKVALIDATION' 
                            SELECT  TransactionTypes.TransactionTypeCode ,
                                    TransactionTypes.TransactionType ,
                                    TransactionTypes.UrduTitle ,
                                    TransactionTypes.DefinitionDate ,
                                    TransactionNatures.NatureCode ,
                                    TransactionTypes.Nature
                            FROM    TransactionTypes
                                    INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
                            WHERE   TransactionTypeCode = @TransactionTypeCode
                                    AND NatureCode = @NatureCode
                        ELSE 
                            SELECT  TransactionTypes.TransactionTypeCode ,
                                    TransactionTypes.TransactionType ,
                                    TransactionTypes.UrduTitle ,
                                    TransactionTypes.DefinitionDate ,
                                    TransactionNatures.NatureCode ,
                                    TransactionTypes.Nature ,
                                    GL.GLCode ,
                                    GL.GLDescription
                            FROM    TransactionTypes
                                    INNER JOIN TransactionNatures ON TransactionTypes.Nature = TransactionNatures.NatureCode
                                    LEFT  JOIN GL_GetCOACombineTransactionVW GL ON TransactionTypes.GLCode = GL.GLCode
                            WHERE   TransactionTypeCode = @TransactionTypeCode
                                    AND NatureCode = @NatureCode
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionsDetails]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionsDetails]


@Option as  varchar(20)='',
@BranchCode as  varchar(2)='',
@TransactionNo as integer =0,
@TransactionNature as  varchar(3)=''
AS
/*
NOTE : YOU MUST CONTAINS THE SAME NUMBER OF COLUMN SPECIFYING ON THE GRID THE SAME NAME
		WHICH CONTAINS THE CAPTION OF THE APEX GRID COLUMN
	CALCULATING FIELD NAME NOT THE SAME BUT MUST SELECT E.G 0.00 as Amt 
	if you specify 0.00 as Amount then the grid formula will not working. 
*/

	IF @TransactionNature='40' --Invoice
	IF 	@Option='ALL' 

		SELECT     dbo.TransactionDetails.BranchCode, dbo.TransactionDetails.TransactionNature, dbo.TransactionDetails.TransactionNo, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.TransactionDetails.Quantity, 
                      dbo.TransactionDetails.Rate, dbo.TransactionDetails.Amount, dbo.Divisions.DivisionCode, dbo.Divisions.Division
		FROM         dbo.Transactions INNER JOIN
		                      dbo.TransactionDetails ON dbo.Transactions.BranchCode = dbo.TransactionDetails.BranchCode AND 
		                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
		                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature LEFT OUTER JOIN
		                      dbo.Branches ON dbo.TransactionDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
		                      dbo.GL_GetCOACombineTransactionVW ON dbo.TransactionDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
		                      dbo.Divisions ON dbo.TransactionDetails.DivisionCode = dbo.Divisions.DivisionCode 
	ELSE
	SELECT     dbo.TransactionDetails.BranchCode, dbo.TransactionDetails.TransactionNature, dbo.TransactionDetails.TransactionNo, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.TransactionDetails.Quantity, 
                      dbo.TransactionDetails.Rate, dbo.TransactionDetails.Amount, dbo.Divisions.DivisionCode, dbo.Divisions.Division
FROM         dbo.Transactions INNER JOIN
                      dbo.TransactionDetails ON dbo.Transactions.BranchCode = dbo.TransactionDetails.BranchCode AND 
                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature LEFT OUTER JOIN
                      dbo.Branches ON dbo.TransactionDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.TransactionDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.TransactionDetails.DivisionCode = dbo.Divisions.DivisionCode
		WHERE dbo.Transactions.TransactionNo=@TransactionNo AND Transactions.TransactionNature=@TransactionNature and Transactions.BranchCode=@BranchCode
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleLedgerReport]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleLedgerReport]
    @FromVehicleCode AS CHAR(12) = '' ,
    @ToVehicleCode AS CHAR(12) = '' ,
    @FromDate AS DATETIME = '' ,
    @ToDate AS DATETIME = ''
AS 
    SELECT  TR.BranchCode ,
            TR.TransactionNo ,
            CASE WHEN TR.Type = 'INV' THEN 'INV'
                 ELSE TR.TransactionNature
            END TransactionNature ,
            TR.TransactionDate ,
            TR.VehicleCode ,
            TR.AmountReceived ,
            TR.AmountPaid ,
            CASE WHEN TR.Type = 'INV' THEN 'TRIP'
                 ELSE TT.TransactionType
            END TransactionType ,
            TR.Description ,
            AmtRec ,
            AmtIss ,
            Balance
    FROM    dbo.vwTransDetail TR
            CROSS APPLY ( SELECT    SUM([AmountReceived]) AS AmtRec ,
                                    SUM([AmountPaid]) AS AmtIss ,
                                    SUM([AmountReceived]) - SUM([AmountPaid]) AS Balance
                          FROM      dbo.vwTransDetail
                          WHERE     RecordNo <= TR.RecordNo
                                    AND TR.VehicleCode = VehicleCode
                                    AND TR.BranchCode = BranchCode
                                   -- AND TR.TransactionTypeCode = TransactionTypeCode
                        ) AS rt
            INNER JOIN dbo.Branches ON TR.BranchCode = dbo.Branches.BranchCode
            INNER JOIN dbo.Vehicles ON TR.VehicleCode = dbo.Vehicles.VehicleCode
            INNER JOIN dbo.TransactionTypes TT ON TR.TransactionTypeCode = TT.TransactionTypeCode
    WHERE   ( ( TR.TransactionDate BETWEEN @FromDate AND @ToDate
                OR @FromDate = ''
                OR @FromDate IS NULL
                OR @ToDate = ''
                OR @ToDate IS NULL
              )
              AND ( TR.VehicleCode BETWEEN @FromVehicleCode
                                   AND     @ToVehicleCode
                    OR @FromVehicleCode = ''
                    OR @FromVehicleCode IS NULL
                    OR @ToVehicleCode = ''
                    OR @ToVehicleCode IS NULL
                  )
            )
    ORDER BY TR.TransactionDate ,
            TR.RecordNo
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerBills]    Script Date: 12/01/2017 23:44:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerBills]

@Option as  varchar(3)='',
@BillNo as  varchar(10)=''

AS

begin transaction

exec DeleteCustomerBillsDetails @BillNo=@BillNo

--DELETE FROM CustomerBills 
--UPDATE dbo.CustomerBills  NO UPDATE REQUIRED BECUSE NO DETAIL INFORMATION EXIST IN THIS MASTER TABLE
--SET 
--0=0
--WHERE BillNo=@BillNo 
commit transaction

if @@error>0 
Rollback Transaction
GO
/****** Object:  Default [DF_Branches_GLCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Branches] ADD  CONSTRAINT [DF_Branches_GLCode]  DEFAULT ('') FOR [GLCode]
GO
/****** Object:  Default [DF_COAControls_FSFGLCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COAControls] ADD  CONSTRAINT [DF_COAControls_FSFGLCode]  DEFAULT ('') FOR [FSFGLCode]
GO
/****** Object:  Default [DF_COAGenerals_FSFGLCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COAGenerals] ADD  CONSTRAINT [DF_COAGenerals_FSFGLCode]  DEFAULT ('') FOR [FSFGLCode]
GO
/****** Object:  Default [DF_COASubsidiaries_FSFGLCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COASubsidiaries] ADD  CONSTRAINT [DF_COASubsidiaries_FSFGLCode]  DEFAULT ('') FOR [FSFGLCode]
GO
/****** Object:  Default [DF_COASubSubsidiaries_FSFGLCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COASubSubsidiaries] ADD  CONSTRAINT [DF_COASubSubsidiaries_FSFGLCode]  DEFAULT ('') FOR [FSFGLCode]
GO
/****** Object:  Default [DF_CustomerBillDetails_Shortage]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[CustomerBillDetails] ADD  CONSTRAINT [DF_CustomerBillDetails_Shortage]  DEFAULT (0) FOR [Shortage]
GO
/****** Object:  Default [DF_CustomerBills_IsReceipt]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[CustomerBills] ADD  CONSTRAINT [DF_CustomerBills_IsReceipt]  DEFAULT (0) FOR [IsReceipt]
GO
/****** Object:  Default [DF_Customers_GLCdoe]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_GLCdoe]  DEFAULT ('') FOR [GLCode]
GO
/****** Object:  Default [DF_DestinationPoints_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[DestinationPoints] ADD  CONSTRAINT [DF_DestinationPoints_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_DestinationPoints_PointNo]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[DestinationPoints] ADD  CONSTRAINT [DF_DestinationPoints_PointNo]  DEFAULT (0) FOR [PointNo]
GO
/****** Object:  Default [DF_Invoices_TripAdvanceReference]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_TripAdvanceReference]  DEFAULT ('') FOR [TripAdvanceReference]
GO
/****** Object:  Default [DF_Invoices_Quantity1_3]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Quantity1_3]  DEFAULT (0.00) FOR [TripAdvance]
GO
/****** Object:  Default [DF_Invoices_Quantity]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Quantity]  DEFAULT (0.00) FOR [Quantity]
GO
/****** Object:  Default [DF_Invoices_Quantity1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Quantity1]  DEFAULT (0.00) FOR [Rate]
GO
/****** Object:  Default [DF_Invoices_Quantity1_2]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Quantity1_2]  DEFAULT (0.00) FOR [Commission]
GO
/****** Object:  Default [DF_Invoices_CommissionRate]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_CommissionRate]  DEFAULT (10) FOR [CommissionRate]
GO
/****** Object:  Default [DF_Invoices_Shortage1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Shortage1]  DEFAULT (0.00) FOR [ShortageQuantity]
GO
/****** Object:  Default [DF_Invoices_ShortageQuantity1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_ShortageQuantity1]  DEFAULT (0.00) FOR [QuantityValue]
GO
/****** Object:  Default [DF_Invoices_Commission1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Commission1]  DEFAULT (0.00) FOR [Shortage]
GO
/****** Object:  Default [DF_Invoices_Quantity1_1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_Quantity1_1]  DEFAULT (0.00) FOR [Amount]
GO
/****** Object:  Default [DF__Receivables__Locked__6A5BAED2]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF__Receivables__Locked__6A5BAED2]  DEFAULT (0) FOR [Locked]
GO
/****** Object:  Default [DF__Receivables__Posted__6B4FD30B]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF__Receivables__Posted__6B4FD30B]  DEFAULT (0) FOR [Posted]
GO
/****** Object:  Default [DF_Transactions_IsTripCanceled]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Transactions_IsTripCanceled]  DEFAULT (0) FOR [IsTripCanceled]
GO
/****** Object:  Default [DF_Invoices_IsBilled]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices] ADD  CONSTRAINT [DF_Invoices_IsBilled]  DEFAULT (0) FOR [IsBilled]
GO
/****** Object:  Default [DF__PayableAc__Docum__65AC084E]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[PayableAccounts] ADD  DEFAULT (0) FOR [DocumentNature]
GO
/****** Object:  Default [DF__PayableAc__Locke__66A02C87]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[PayableAccounts] ADD  DEFAULT (0) FOR [Locked]
GO
/****** Object:  Default [DF__PayableAc__Poste__679450C0]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[PayableAccounts] ADD  DEFAULT (0) FOR [Posted]
GO
/****** Object:  Default [DF_Products_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_ProjectNodesSetup_SystemType]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[ProjectNodesSetup] ADD  CONSTRAINT [DF_ProjectNodesSetup_SystemType]  DEFAULT (' ') FOR [SystemType]
GO
/****** Object:  Default [DF_Receipts_Locked]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Receipts] ADD  CONSTRAINT [DF_Receipts_Locked]  DEFAULT (0) FOR [Locked]
GO
/****** Object:  Default [DF_Receipts_Posted]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Receipts] ADD  CONSTRAINT [DF_Receipts_Posted]  DEFAULT (0) FOR [Posted]
GO
/****** Object:  Default [DF_Regions_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Regions] ADD  CONSTRAINT [DF_Regions_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_StationPoints_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[StationPoints] ADD  CONSTRAINT [DF_StationPoints_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_StationPoints_PointNo]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[StationPoints] ADD  CONSTRAINT [DF_StationPoints_PointNo]  DEFAULT (0) FOR [PointNo]
GO
/****** Object:  Default [DF__Transacti__Paren__529933DA]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[TransactionActivities] ADD  DEFAULT (0) FOR [ParentGUID]
GO
/****** Object:  Default [DF_VehicleAdjustmentDetails_DivisionCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails] ADD  CONSTRAINT [DF_VehicleAdjustmentDetails_DivisionCode]  DEFAULT ('') FOR [TransactionTypeCode]
GO
/****** Object:  Default [DF__VehicleAdjustmentDe__Debit__74D93D45]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails] ADD  CONSTRAINT [DF__VehicleAdjustmentDe__Debit__74D93D45]  DEFAULT (0) FOR [Amount]
GO
/****** Object:  Default [DF_VehicleAdjustmentDetails_InvoiceRefNo]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails] ADD  CONSTRAINT [DF_VehicleAdjustmentDetails_InvoiceRefNo]  DEFAULT ('') FOR [InvoiceRefNo]
GO
/****** Object:  Default [DF__VehicleAdjustments__Vouche__69678A99]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments] ADD  CONSTRAINT [DF__VehicleAdjustments__Vouche__69678A99]  DEFAULT ('0') FOR [VehicleAdjustmentNature]
GO
/****** Object:  Default [DF__VehicleAdjustments__Locked__6A5BAED2]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments] ADD  CONSTRAINT [DF__VehicleAdjustments__Locked__6A5BAED2]  DEFAULT (0) FOR [Locked]
GO
/****** Object:  Default [DF__VehicleAdjustments__Posted__6B4FD30B]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments] ADD  CONSTRAINT [DF__VehicleAdjustments__Posted__6B4FD30B]  DEFAULT (0) FOR [Posted]
GO
/****** Object:  Default [DF_VehicleAdjustments_OldRef]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments] ADD  CONSTRAINT [DF_VehicleAdjustments_OldRef]  DEFAULT ('') FOR [OldRef]
GO
/****** Object:  Default [DF_VehicleAdjustments_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments] ADD  CONSTRAINT [DF_VehicleAdjustments_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_Vehicles _UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vehicles ] ADD  CONSTRAINT [DF_Vehicles _UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  Default [DF_Vehicles _IsThirdParty]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vehicles ] ADD  CONSTRAINT [DF_Vehicles _IsThirdParty]  DEFAULT ((0)) FOR [IsThirdParty]
GO
/****** Object:  Default [DF_VoucherDetails_DivisionCode]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VoucherDetails] ADD  CONSTRAINT [DF_VoucherDetails_DivisionCode]  DEFAULT ('') FOR [DivisionCode]
GO
/****** Object:  Default [DF__VoucherDe__Refer__73E5190C]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VoucherDetails] ADD  CONSTRAINT [DF__VoucherDe__Refer__73E5190C]  DEFAULT ('0') FOR [Reference]
GO
/****** Object:  Default [DF__VoucherDe__Debit__74D93D45]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VoucherDetails] ADD  CONSTRAINT [DF__VoucherDe__Debit__74D93D45]  DEFAULT (0) FOR [Debit]
GO
/****** Object:  Default [DF__VoucherDe__Credi__75CD617E]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VoucherDetails] ADD  CONSTRAINT [DF__VoucherDe__Credi__75CD617E]  DEFAULT (0) FOR [Credit]
GO
/****** Object:  Default [DF__Vouchers__Vouche__69678A99]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF__Vouchers__Vouche__69678A99]  DEFAULT ('0') FOR [VoucherNature]
GO
/****** Object:  Default [DF__Vouchers__Locked__6A5BAED2]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF__Vouchers__Locked__6A5BAED2]  DEFAULT (0) FOR [Locked]
GO
/****** Object:  Default [DF__Vouchers__Posted__6B4FD30B]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF__Vouchers__Posted__6B4FD30B]  DEFAULT (0) FOR [Posted]
GO
/****** Object:  Default [DF_Vouchers_Posted1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF_Vouchers_Posted1]  DEFAULT (0) FOR [IsAutoGenerated]
GO
/****** Object:  Default [DF_Vouchers_OldRef]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF_Vouchers_OldRef]  DEFAULT ('') FOR [OldRef]
GO
/****** Object:  Default [DF_Vouchers_UrduTitle]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers] ADD  CONSTRAINT [DF_Vouchers_UrduTitle]  DEFAULT ('') FOR [UrduTitle]
GO
/****** Object:  ForeignKey [COAControls_COAGenerals_FK1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COAGenerals]  WITH NOCHECK ADD  CONSTRAINT [COAControls_COAGenerals_FK1] FOREIGN KEY([ControlCode])
REFERENCES [dbo].[COAControls] ([ControlCode])
GO
ALTER TABLE [dbo].[COAGenerals] CHECK CONSTRAINT [COAControls_COAGenerals_FK1]
GO
/****** Object:  ForeignKey [COAGenerals_COASubsidiaries_FK1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COASubsidiaries]  WITH NOCHECK ADD  CONSTRAINT [COAGenerals_COASubsidiaries_FK1] FOREIGN KEY([GeneralCode], [ControlCode])
REFERENCES [dbo].[COAGenerals] ([GeneralCode], [ControlCode])
GO
ALTER TABLE [dbo].[COASubsidiaries] CHECK CONSTRAINT [COAGenerals_COASubsidiaries_FK1]
GO
/****** Object:  ForeignKey [FK_COASubSubsidiaries_COASubsidiaries1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[COASubSubsidiaries]  WITH NOCHECK ADD  CONSTRAINT [FK_COASubSubsidiaries_COASubsidiaries1] FOREIGN KEY([SubsidiaryCode], [ControlCode], [GeneralCode])
REFERENCES [dbo].[COASubsidiaries] ([SubsidiaryCode], [ControlCode], [GeneralCode])
GO
ALTER TABLE [dbo].[COASubSubsidiaries] CHECK CONSTRAINT [FK_COASubSubsidiaries_COASubsidiaries1]
GO
/****** Object:  ForeignKey [FK_CustomerBillDetails_CustomerBills]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[CustomerBillDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBillDetails_CustomerBills] FOREIGN KEY([BillNo])
REFERENCES [dbo].[CustomerBills] ([BillNo])
GO
ALTER TABLE [dbo].[CustomerBillDetails] CHECK CONSTRAINT [FK_CustomerBillDetails_CustomerBills]
GO
/****** Object:  ForeignKey [FK_CustomerBillDetails_Invoices]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[CustomerBillDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerBillDetails_Invoices] FOREIGN KEY([BranchCode], [InvoiceNo])
REFERENCES [dbo].[Invoices] ([BranchCode], [TransactionNo])
GO
ALTER TABLE [dbo].[CustomerBillDetails] CHECK CONSTRAINT [FK_CustomerBillDetails_Invoices]
GO
/****** Object:  ForeignKey [FK_CustomerBills_Customers]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[CustomerBills]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerBills_Customers] FOREIGN KEY([CustomerCode])
REFERENCES [dbo].[Customers] ([CustomerCode])
GO
ALTER TABLE [dbo].[CustomerBills] CHECK CONSTRAINT [FK_CustomerBills_Customers]
GO
/****** Object:  ForeignKey [Cities_Customers_FK1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Customers]  WITH NOCHECK ADD  CONSTRAINT [Cities_Customers_FK1] FOREIGN KEY([CityCode])
REFERENCES [dbo].[Cities] ([CityCode])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [Cities_Customers_FK1]
GO
/****** Object:  ForeignKey [FK_Invoices_DestinationPoints]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Invoices_DestinationPoints] FOREIGN KEY([DestinationPointCode])
REFERENCES [dbo].[DestinationPoints] ([DestinationPointCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_DestinationPoints]
GO
/****** Object:  ForeignKey [FK_Invoices_StationPoints]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Invoices_StationPoints] FOREIGN KEY([StationPointCode])
REFERENCES [dbo].[StationPoints] ([StationPointCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_StationPoints]
GO
/****** Object:  ForeignKey [FK_Invoices_StationPoints1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Invoices_StationPoints1] FOREIGN KEY([StationPointCode])
REFERENCES [dbo].[StationPoints] ([StationPointCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_StationPoints1]
GO
/****** Object:  ForeignKey [FK_Receivables_Branches]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Receivables_Branches] FOREIGN KEY([BranchCode])
REFERENCES [dbo].[Branches] ([BranchCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Receivables_Branches]
GO
/****** Object:  ForeignKey [FK_Transactions_Customers]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Transactions_Customers] FOREIGN KEY([PartyCode])
REFERENCES [dbo].[Customers] ([CustomerCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Transactions_Customers]
GO
/****** Object:  ForeignKey [FK_Transactions_Products]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Transactions_Products] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Transactions_Products]
GO
/****** Object:  ForeignKey [FK_Transactions_Vehicles ]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Invoices]  WITH NOCHECK ADD  CONSTRAINT [FK_Transactions_Vehicles ] FOREIGN KEY([VehicleCode])
REFERENCES [dbo].[Vehicles ] ([VehicleCode])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Transactions_Vehicles ]
GO
/****** Object:  ForeignKey [FK_ProductRate_Products]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[ProductRates]  WITH NOCHECK ADD  CONSTRAINT [FK_ProductRate_Products] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[ProductRates] CHECK CONSTRAINT [FK_ProductRate_Products]
GO
/****** Object:  ForeignKey [FK_ProductRates_DestinationPoints]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[ProductRates]  WITH CHECK ADD  CONSTRAINT [FK_ProductRates_DestinationPoints] FOREIGN KEY([DestinationPointCode])
REFERENCES [dbo].[DestinationPoints] ([DestinationPointCode])
GO
ALTER TABLE [dbo].[ProductRates] CHECK CONSTRAINT [FK_ProductRates_DestinationPoints]
GO
/****** Object:  ForeignKey [FK_ProductRates_StationPoints]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[ProductRates]  WITH CHECK ADD  CONSTRAINT [FK_ProductRates_StationPoints] FOREIGN KEY([StationPointCode])
REFERENCES [dbo].[StationPoints] ([StationPointCode])
GO
ALTER TABLE [dbo].[ProductRates] CHECK CONSTRAINT [FK_ProductRates_StationPoints]
GO
/****** Object:  ForeignKey [FK_ProductValues_Products]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[ProductValues]  WITH NOCHECK ADD  CONSTRAINT [FK_ProductValues_Products] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[ProductValues] CHECK CONSTRAINT [FK_ProductValues_Products]
GO
/****** Object:  ForeignKey [FK_Receipts_Branches]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Receipts]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipts_Branches] FOREIGN KEY([BranchCode])
REFERENCES [dbo].[Branches] ([BranchCode])
GO
ALTER TABLE [dbo].[Receipts] CHECK CONSTRAINT [FK_Receipts_Branches]
GO
/****** Object:  ForeignKey [FK_Receipts_CustomerBills]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Receipts]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipts_CustomerBills] FOREIGN KEY([BillNo])
REFERENCES [dbo].[CustomerBills] ([BillNo])
GO
ALTER TABLE [dbo].[Receipts] CHECK CONSTRAINT [FK_Receipts_CustomerBills]
GO
/****** Object:  ForeignKey [FK_Receipts_Customers]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Receipts]  WITH NOCHECK ADD  CONSTRAINT [FK_Receipts_Customers] FOREIGN KEY([CustomerCode])
REFERENCES [dbo].[Customers] ([CustomerCode])
GO
ALTER TABLE [dbo].[Receipts] CHECK CONSTRAINT [FK_Receipts_Customers]
GO
/****** Object:  ForeignKey [Cities_Suppliers_FK1]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Suppliers]  WITH NOCHECK ADD  CONSTRAINT [Cities_Suppliers_FK1] FOREIGN KEY([CityCode])
REFERENCES [dbo].[Cities] ([CityCode])
GO
ALTER TABLE [dbo].[Suppliers] CHECK CONSTRAINT [Cities_Suppliers_FK1]
GO
/****** Object:  ForeignKey [FK_AdjustmentTypes_TransactionNatures]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[TransactionTypes]  WITH CHECK ADD  CONSTRAINT [FK_AdjustmentTypes_TransactionNatures] FOREIGN KEY([Nature])
REFERENCES [dbo].[TransactionNatures] ([NatureCode])
GO
ALTER TABLE [dbo].[TransactionTypes] CHECK CONSTRAINT [FK_AdjustmentTypes_TransactionNatures]
GO
/****** Object:  ForeignKey [FK_VehicleAdjustmentDetails_AdjustmentType]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleAdjustmentDetails_AdjustmentType] FOREIGN KEY([TransactionTypeCode])
REFERENCES [dbo].[TransactionTypes] ([TransactionTypeCode])
GO
ALTER TABLE [dbo].[VehicleAdjustmentDetails] CHECK CONSTRAINT [FK_VehicleAdjustmentDetails_AdjustmentType]
GO
/****** Object:  ForeignKey [FK_VehicleAdjustmentDetails_TransactionTypes]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleAdjustmentDetails_TransactionTypes] FOREIGN KEY([TransactionTypeCode])
REFERENCES [dbo].[TransactionTypes] ([TransactionTypeCode])
GO
ALTER TABLE [dbo].[VehicleAdjustmentDetails] CHECK CONSTRAINT [FK_VehicleAdjustmentDetails_TransactionTypes]
GO
/****** Object:  ForeignKey [FK_VehicleAdjustmentDetails_VehicleAdjustments]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustmentDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleAdjustmentDetails_VehicleAdjustments] FOREIGN KEY([BranchCode], [VehicleAdjustmentNature], [VehicleAdjustmentNo])
REFERENCES [dbo].[VehicleAdjustments] ([BranchCode], [VehicleAdjustmentNature], [VehicleAdjustmentNo])
GO
ALTER TABLE [dbo].[VehicleAdjustmentDetails] CHECK CONSTRAINT [FK_VehicleAdjustmentDetails_VehicleAdjustments]
GO
/****** Object:  ForeignKey [FK_VehicleAdjustments_Branches]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleAdjustments_Branches] FOREIGN KEY([BranchCode])
REFERENCES [dbo].[Branches] ([BranchCode])
GO
ALTER TABLE [dbo].[VehicleAdjustments] CHECK CONSTRAINT [FK_VehicleAdjustments_Branches]
GO
/****** Object:  ForeignKey [FK_VehicleAdjustments_Vehicles ]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleAdjustments]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleAdjustments_Vehicles ] FOREIGN KEY([VehicleCode])
REFERENCES [dbo].[Vehicles ] ([VehicleCode])
GO
ALTER TABLE [dbo].[VehicleAdjustments] CHECK CONSTRAINT [FK_VehicleAdjustments_Vehicles ]
GO
/****** Object:  ForeignKey [FK_VehicleOwners_Cities]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[VehicleOwners]  WITH NOCHECK ADD  CONSTRAINT [FK_VehicleOwners_Cities] FOREIGN KEY([CityCode])
REFERENCES [dbo].[Cities] ([CityCode])
GO
ALTER TABLE [dbo].[VehicleOwners] CHECK CONSTRAINT [FK_VehicleOwners_Cities]
GO
/****** Object:  ForeignKey [FK_Vehicles _Customers]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vehicles ]  WITH NOCHECK ADD  CONSTRAINT [FK_Vehicles _Customers] FOREIGN KEY([CustomerCode])
REFERENCES [dbo].[Customers] ([CustomerCode])
GO
ALTER TABLE [dbo].[Vehicles ] CHECK CONSTRAINT [FK_Vehicles _Customers]
GO
/****** Object:  ForeignKey [FK_Vehicles _VehicleOwners]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vehicles ]  WITH NOCHECK ADD  CONSTRAINT [FK_Vehicles _VehicleOwners] FOREIGN KEY([OwnerCode])
REFERENCES [dbo].[VehicleOwners] ([OwnerCode])
GO
ALTER TABLE [dbo].[Vehicles ] CHECK CONSTRAINT [FK_Vehicles _VehicleOwners]
GO
/****** Object:  ForeignKey [FK_Vouchers_Branches]    Script Date: 12/01/2017 23:44:27 ******/
ALTER TABLE [dbo].[Vouchers]  WITH NOCHECK ADD  CONSTRAINT [FK_Vouchers_Branches] FOREIGN KEY([BranchCode])
REFERENCES [dbo].[Branches] ([BranchCode])
GO
ALTER TABLE [dbo].[Vouchers] CHECK CONSTRAINT [FK_Vouchers_Branches]
GO
