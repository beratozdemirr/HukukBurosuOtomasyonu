CREATE PROC spRestoreDB
(
	@DosyaYolu nvarchar(250)
)
AS
BEGIN
	RESTORE DATABASE HukukBuroDB FROM DISK=@DosyaYolu
	WITH MOVE 'HukukBuroDB' TO 'c:\Program Files\Microsoft SQL Server\MSSQL11.EMIRHANSQLSERVER\MSSQL\DATA\HukukBuroDB.mdf',
	MOVE 'HukukBuroDB_log' TO 'c:\Program Files\Microsoft SQL Server\MSSQL11.EMIRHANSQLSERVER\MSSQL\DATA\HukukBuroDB_log.ldf',
	REPLACE
END

--DROP PROC spRestoreDB

--RESTORE FILELISTONLY FROM DISK = 'C:\Users\Emirhan\Desktop\db_backupbackup_HukukBuroDB.BAK'


--KULLANMAMAYA ÇALIÞ
--ALTER DATABASE [HukukBuroDB]
--SET SINGLE_USER
----This rolls back all uncommitted transactions in the db.
--WITH ROLLBACK IMMEDIATE
--GO

