CREATE PROCEDURE spDavaSonucuBul
(
@DavaSonucu Varchar(10)
)
AS
BEGIN
	SELECT *
	FROM dbo.DavaSonucu
	WHERE DavaSonucu = @DavaSonucu
END
GO