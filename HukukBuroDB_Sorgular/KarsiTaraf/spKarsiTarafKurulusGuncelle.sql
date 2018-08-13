CREATE PROCEDURE spKarsiTarafKurulusGuncelle
(
@KarsiTaraf_ID Integer Output,
@KarsiTaraf_Isim Varchar(50),
@KarsiTarafVergiNo Varchar(10),
@KarsiTarafTelefonNo Varchar(11),
@KarsiTarafAdres Varchar(50),
@KarsiTarafTipi Varchar(18),
@KarsiTarafSecimi Varchar (7)
)
AS 
BEGIN
	UPDATE dbo.KarsiTaraf
	SET 
		KarsiTaraf_Isim = @KarsiTaraf_Isim,
		KarsiTarafVergiNo = @KarsiTarafVergiNo,
		KarsiTarafTelefonNo = @KarsiTarafTelefonNo,
		KarsiTarafAdres = @KarsiTarafAdres,
		KarsiTarafTipi = @KarsiTarafTipi,
		KarsiTarafSecimi = @KarsiTarafSecimi
	WHERE 
		KarsiTaraf_ID = @KarsiTaraf_ID
	SELECT @KarsiTaraf_ID = @@IDENTITY
END