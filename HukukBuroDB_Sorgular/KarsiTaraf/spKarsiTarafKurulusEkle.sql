CREATE PROC spKarsiTarafKurulusEkle
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
	INSERT INTO dbo.KarsiTaraf
	(
		KarsiTaraf_Isim,
		KarsiTarafVergiNo,
		KarsiTarafTelefonNo,
		KarsiTarafAdres,
		KarsiTarafTipi,
		KarsiTarafSecimi
	)
	VALUES
	(
		@KarsiTaraf_Isim,
		@KarsiTarafVergiNo,
		@KarsiTarafTelefonNo,
		@KarsiTarafAdres,
		@KarsiTarafTipi,
		@KarsiTarafSecimi
	)
	SELECT @KarsiTaraf_ID = @@IDENTITY
END
GO