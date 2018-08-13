CREATE PROCEDURE spKarsiTarafTipiBul
(
@KarsiTarafTipi Varchar(18)
)
AS
BEGIN
	SELECT *
	FROM dbo.KarsiTaraf
	WHERE KarsiTarafTipi = @KarsiTarafTipi
END
GO
