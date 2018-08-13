CREATE PROCEDURE spDavaTuruBul
(
@DavaTuru Varchar(30)
)
AS
BEGIN
	SELECT *
	FROM dbo.Dava
	WHERE DavaTuru = @DavaTuru
END
GO
