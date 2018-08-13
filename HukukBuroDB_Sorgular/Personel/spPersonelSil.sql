CREATE PROCEDURE spPersonelSil
(
@Personel_ID integer
)
AS
DELETE FROM Personel WHERE Personel_ID = @Personel_ID
GO