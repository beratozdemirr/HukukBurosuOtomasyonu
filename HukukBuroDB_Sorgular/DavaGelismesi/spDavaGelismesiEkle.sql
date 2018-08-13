CREATE PROCEDURE spDavaGelismesiEkle
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
	INSERT INTO dbo.DavaGelismesi
	( 
		Muvekkil_ID, 
		Dava_ID, 
		GelismeAciklamasi, 
		GelismeTarihi, 
		DavaDurumu
	)
	VALUES
	( 
		@Muvekkil_ID, 
		@Dava_ID, 
		@GelismeAciklamasi, 
		@GelismeTarihi, 
		@DavaDurumu
	)
	SELECT @Gelisme_ID = @@IDENTITY
END
GO