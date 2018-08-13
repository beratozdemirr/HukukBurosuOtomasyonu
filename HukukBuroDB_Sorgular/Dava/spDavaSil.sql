CREATE PROCEDURE spDavaSil
(
@Dava_ID integer
)
AS
DELETE FROM Dava WHERE Dava_ID = @Dava_ID
GO