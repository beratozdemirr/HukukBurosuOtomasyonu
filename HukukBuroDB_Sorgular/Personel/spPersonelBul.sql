CREATE PROCEDURE spPersonelBul
(
@PersonelAdiSoyadi Varchar(30)
)
AS
BEGIN
	SELECT *
	FROM dbo.Personel
	WHERE PersonelAdiSoyadi = @PersonelAdiSoyadi
END
GO