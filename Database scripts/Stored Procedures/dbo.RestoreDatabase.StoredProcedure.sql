USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[RestoreDatabase]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
