CREATE PROC spMuvekkilKisiEkle
(
@Muvekkil_ID Integer Output,
@Muvekkil_Isim Varchar(50),
@MuvekkilTCNo Varchar(11),
@MuvekkilSicilNo Varchar(13),
@MuvekkilCinsiyet Varchar(5),
@MuvekkilTelefonNo Varchar(11),
@MuvekkilAdres Varchar(50),
@MuvekkilTipi Varchar(18),
@MuvekkilSecimi Varchar(7)
)
AS
BEGIN
	INSERT INTO dbo.Muvekkil
	(
		Muvekkil_Isim,
		MuvekkilTCNo,
		MuvekkilSicilNo,
		MuvekkilCinsiyet,
		MuvekkilTelefonNo,
		MuvekkilAdres,
		MuvekkilTipi,
		MuvekkilSecimi
	)
	VALUES
	(
		@Muvekkil_Isim,
		@MuvekkilTCNo,
		@MuvekkilSicilNo,
		@MuvekkilCinsiyet,
		@MuvekkilTelefonNo,
		@MuvekkilAdres,
		@MuvekkilTipi,
		@MuvekkilSecimi
	)
	SELECT @Muvekkil_ID = @@IDENTITY
END
GO

