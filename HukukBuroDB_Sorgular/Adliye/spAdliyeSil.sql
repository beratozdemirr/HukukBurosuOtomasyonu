CREATE PROCEDURE spAdliyeSil
(
@Adliye_ID integer
)
AS
DELETE FROM Adliye WHERE Adliye_ID = @Adliye_ID
GO