CREATE PROCEDURE spMuvekkilKisiGuncelle
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
	UPDATE dbo.Muvekkil
	SET 
		Muvekkil_Isim = @Muvekkil_Isim,
		MuvekkilTCNo = @MuvekkilTCNo,
		MuvekkilSicilNo = @MuvekkilSicilNo,
		MuvekkilCinsiyet = @MuvekkilCinsiyet,
		MuvekkilTelefonNo = @MuvekkilTelefonNo,
		MuvekkilAdres = @MuvekkilAdres,
		MuvekkilTipi = @MuvekkilTipi,
		MuvekkilSecimi = @MuvekkilSecimi
	WHERE 
		Muvekkil_ID = @Muvekkil_ID
	SELECT @Muvekkil_ID = @@IDENTITY
END