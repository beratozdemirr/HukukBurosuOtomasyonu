CREATE PROCEDURE spDavaGuncelle
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
	UPDATE Dava
	SET 
		Muvekkil_ID = @Muvekkil_ID, 
		KarsiTaraf_ID = @KarsiTaraf_ID, 
		Personel_ID = @Personel_ID, 
		Adliye_ID = @Adliye_ID, 
		DavaNo = @DavaNo, 
		DavaAcilisTarihi = @DavaAcilisTarihi, 
		DavaTuru = @DavaTuru, 
		DavaMuvekkilTalep = @DavaMuvekkilTalep, 
		DavaTutari = @DavaTutari, 
		DavaSalonNo = @DavaSalonNo, 
		DavaGelecekOturumTarihi = @DavaGelecekOturumTarihi, 
		DavaSaati = @DavaSaati
	WHERE 
		Dava_ID = @Dava_ID
	SELECT @Dava_ID = @@IDENTITY
END