CREATE PROCEDURE spDavaSonucuGuncelle
(
@DavaSonuc_ID Integer Output, 
@Muvekkil_ID Integer, 
@KarsiTaraf_ID Integer, 
@DavaBitisTarihi Date, 
@DavaSonucu Varchar(9)
)
AS 
BEGIN
	UPDATE DavaSonucu
	SET 
		Muvekkil_ID = @Muvekkil_ID,
		KarsiTaraf_ID = @KarsiTaraf_ID,
		DavaBitisTarihi = @DavaBitisTarihi,
		DavaSonucu = @DavaSonucu
	WHERE 
		DavaSonuc_ID = @DavaSonuc_ID
	SELECT @DavaSonuc_ID = @@IDENTITY
END