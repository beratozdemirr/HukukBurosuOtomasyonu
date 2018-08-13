CREATE PROCEDURE spKarsiTarafKisiGuncelle
(
@KarsiTaraf_ID Integer Output,
@KarsiTaraf_Isim Varchar(50),
@KarsiTarafTCNo Varchar(11),
@KarsiTarafSicilNo Varchar(13),
@KarsiTarafCinsiyet Varchar(5),
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
		KarsiTarafTCNo = @KarsiTarafTCNo,
		KarsiTarafSicilNo = @KarsiTarafSicilNo,
		KarsiTarafCinsiyet = @KarsiTarafCinsiyet,
		KarsiTarafTelefonNo = @KarsiTarafTelefonNo,
		KarsiTarafAdres = @KarsiTarafAdres,
		KarsiTarafTipi = @KarsiTarafTipi,
		KarsiTarafSecimi = @KarsiTarafSecimi
	WHERE 
		KarsiTaraf_ID = @KarsiTaraf_ID
	SELECT @KarsiTaraf_ID = @@IDENTITY
END