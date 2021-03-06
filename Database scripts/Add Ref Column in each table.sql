DECLARE @NAME VARCHAR(100);
DECLARE @SQL NVARCHAR(300);
DECLARE CUR CURSOR
FOR SELECT NAME
    FROM SYS.TABLES
    WHERE TYPE = 'U'
          AND SCHEMA_ID = 1;
OPEN CUR;
FETCH NEXT FROM CUR INTO @NAME;
WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @SQL = 'ALTER TABLE dbo.'+@NAME+' ADD
	RefNo nvarchar(200) NULL,
	UpdatedOn DATETIME NULL,
	UpdatedBy varchar(500) NULL

ALTER TABLE dbo.'+@NAME+' SET (LOCK_ESCALATION = TABLE)
';
        PRINT @SQL;
        EXEC Sp_executesql
             @SQL;
        FETCH NEXT FROM CUR INTO @NAME;
    END;
CLOSE CUR;
DEALLOCATE CUR; 