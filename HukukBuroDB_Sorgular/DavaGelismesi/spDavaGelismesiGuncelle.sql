CREATE PROCEDURE spDavaGelismesiGuncelle
(
@Gelisme_ID Integer Output, 
@Muvekkil_ID Integer, 
@Dava_ID Integer, 
@GelismeAciklamasi Varchar(50), 
@GelismeTarihi Date, 
@DavaDurumu Varchar(10)
)
AS 
BEGIN
	UPDATE DavaGelismesi
	SET 
		Muvekkil_ID = @Muvekkil_ID,
		Dava_ID = @Dava_ID,
		GelismeAciklamasi = @GelismeAciklamasi,
		GelismeTarihi = @GelismeTarihi,
		DavaDurumu = @DavaDurumu
	WHERE 
		Gelisme_ID = @Gelisme_ID
	SELECT @Gelisme_ID = @@IDENTITY
END