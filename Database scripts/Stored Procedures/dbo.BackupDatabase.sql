USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[BackupDatabase]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
