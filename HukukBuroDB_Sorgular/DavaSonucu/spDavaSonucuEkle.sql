CREATE PROCEDURE spDavaSonucuEkle
(
@DavaSonuc_ID Integer Output, 
@Muvekkil_ID Integer, 
@KarsiTaraf_ID Integer, 
@DavaBitisTarihi Date, 
@DavaSonucu Varchar(9)
)
AS
BEGIN
	INSERT INTO dbo.DavaSonucu
	( 
		Muvekkil_ID, 
		KarsiTaraf_ID, 
		DavaBitisTarihi, 
		DavaSonucu
	)
	VALUES
	( 
		@Muvekkil_ID, 
		@KarsiTaraf_ID, 
		@DavaBitisTarihi, 
		@DavaSonucu
	)
	SELECT @DavaSonuc_ID = @@IDENTITY
END
GO