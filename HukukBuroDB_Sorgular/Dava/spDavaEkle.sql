CREATE PROCEDURE spDavaEkle
(
@Dava_ID Integer Output, 
@Muvekkil_ID Integer, 
@KarsiTaraf_ID Integer, 
@Personel_ID Integer, 
@Adliye_ID Integer, 
@DavaNo Integer, 
@DavaAcilisTarihi Date, 
@DavaTuru Varchar(30), 
@DavaMuvekkilTalep Varchar(255), 
@DavaTutari Money, 
@DavaSalonNo Varchar(5),  
@DavaGelecekOturumTarihi Date, 
@DavaSaati Time
)
AS
BEGIN
	INSERT INTO dbo.Dava
	(
		Muvekkil_ID, 
		KarsiTaraf_ID, 
		Personel_ID, 
		Adliye_ID, 
		DavaNo, 
		DavaAcilisTarihi, 
		DavaTuru, 
		DavaMuvekkilTalep, 
		DavaTutari, 
		DavaSalonNo, 
		DavaGelecekOturumTarihi, 
		DavaSaati
	)
	VALUES
	(
		@Muvekkil_ID, 
		@KarsiTaraf_ID, 
		@Personel_ID, 
		@Adliye_ID, 
		@DavaNo, 
		@DavaAcilisTarihi, 
		@DavaTuru, 
		@DavaMuvekkilTalep, 
		@DavaTutari, 
		@DavaSalonNo, 
		@DavaGelecekOturumTarihi, 
		@DavaSaati
	)
	SELECT @Dava_ID = @@IDENTITY
END
GO