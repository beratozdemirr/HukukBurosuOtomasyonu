CREATE PROC spAdliyeEkle
(
@Adliye_ID Integer Output, 
@AdliyeAdi Varchar(50), 
@AdliyeTelefonNo Varchar(11), 
@AdliyeAdres Varchar(50)
)
AS
BEGIN
	INSERT INTO dbo.Adliye
	( 
		AdliyeAdi,
		AdliyeTelefonNo, 
		AdliyeAdres	
	)
	VALUES
	(
		@AdliyeAdi, 
		@AdliyeTelefonNo, 
		@AdliyeAdres
	)
	SELECT @Adliye_ID = @@IDENTITY
END
GO
