CREATE PROC spKarsiTarafKisiEkle
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
	INSERT INTO dbo.KarsiTaraf
	(
		KarsiTaraf_Isim,
		KarsiTarafTCNo,
		KarsiTarafSicilNo,
		KarsiTarafCinsiyet,
		KarsiTarafTelefonNo,
		KarsiTarafAdres,
		KarsiTarafTipi,
		KarsiTarafSecimi
	)
	VALUES
	(
		@KarsiTaraf_Isim,
		@KarsiTarafTCNo,
		@KarsiTarafSicilNo,
		@KarsiTarafCinsiyet,
		@KarsiTarafTelefonNo,
		@KarsiTarafAdres,
		@KarsiTarafTipi,
		@KarsiTarafSecimi
	)
	SELECT @KarsiTaraf_ID = @@IDENTITY
END
GO