CREATE PROCEDURE spMuvekkil_IsmiBul
(
@Muvekkil_Isim Varchar(50)
)
AS
BEGIN
	SELECT *
	FROM dbo.Muvekkil
	WHERE Muvekkil_Isim = @Muvekkil_Isim
END
GO

