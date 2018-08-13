CREATE PROC spMuvekkilKurulusEkle
(
@Muvekkil_ID Integer Output,
@Muvekkil_Isim Varchar(50),
@MuvekkilVergiNo Varchar(10),
@MuvekkilTelefonNo Varchar(11),
@MuvekkilAdres Varchar(50),
@MuvekkilTipi Varchar(18),
@MuvekkilSecimi Varchar (7)
)
AS
BEGIN
	INSERT INTO dbo.Muvekkil
	(
		Muvekkil_Isim,
		MuvekkilVergiNo,
		MuvekkilTelefonNo,
		MuvekkilAdres,
		MuvekkilTipi,
		MuvekkilSecimi
	)
	VALUES
	(
		@Muvekkil_Isim,
		@MuvekkilVergiNo,
		@MuvekkilTelefonNo,
		@MuvekkilAdres,
		@MuvekkilTipi,
		@MuvekkilSecimi
	)
	SELECT @Muvekkil_ID = @@IDENTITY
END
GO

