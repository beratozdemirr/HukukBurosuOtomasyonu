CREATE PROCEDURE spMuvekkilSil
(
@Muvekkil_ID integer
)
AS
DELETE FROM Muvekkil WHERE Muvekkil_ID = @Muvekkil_ID
GO