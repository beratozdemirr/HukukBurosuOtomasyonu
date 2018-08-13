CREATE PROCEDURE spBackupDB
AS
BEGIN
DECLARE @DosyaAdi Varchar(250),
@DatabaseAdi Varchar(150);

SET @DatabaseAdi = 'HukukBuroDB'
SET @DosyaAdi = 'C:\Users\Emirhan\Desktop\db_backup'+'backup_HukukBuroDB' + '.BAK';
BACKUP DATABASE @DatabaseAdi TO DISK = @DosyaAdi;

END