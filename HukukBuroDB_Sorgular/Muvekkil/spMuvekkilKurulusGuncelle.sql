CREATE PROCEDURE spMuvekkilKurulusGuncelle
(
@Muvekkil_ID Integer Output,
@Muvekkil_Isim Varchar(50),
@MuvekkilVergiNo Varchar(10),
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
		MuvekkilVergiNo = @MuvekkilVergiNo,
		MuvekkilTelefonNo = @MuvekkilTelefonNo,
		MuvekkilAdres = @MuvekkilAdres,
		MuvekkilTipi = @MuvekkilTipi,
		MuvekkilSecimi = @MuvekkilSecimi
	WHERE 
		Muvekkil_ID = @Muvekkil_ID
	SELECT @Muvekkil_ID = @@IDENTITY
END

--EXEC spMuvekkilKurulusGuncelle 2, 'Bilgi Siber Güvenlik', 1478523691, '02164578912' , 'MECIDIYEKOY/ISTANBUL', 'DAVALI', 'KURULUÞ'