CREATE PROCEDURE spDavaDurumuBul
(
@DavaDurumu Varchar(10)
)
AS
BEGIN
	SELECT *
	FROM dbo.DavaGelismesi
	WHERE DavaDurumu = @DavaDurumu
END
GO