CREATE PROCEDURE spAdliyeGuncelle
(
@Adliye_ID Integer Output, 
@AdliyeAdi Varchar(50), 
@AdliyeTelefonNo Varchar(11), 
@AdliyeAdres Varchar(50)
)
AS 
BEGIN
	UPDATE Adliye
	SET 
		AdliyeAdi = @AdliyeAdi,
		AdliyeTelefonNo = @AdliyeTelefonNo,
		AdliyeAdres = @AdliyeAdres
	WHERE 
		Adliye_ID = @Adliye_ID
	SELECT @Adliye_ID = @@IDENTITY
END