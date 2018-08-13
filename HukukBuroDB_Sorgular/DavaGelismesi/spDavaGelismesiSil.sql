CREATE PROCEDURE spDavaGelismesiSil
(
@Gelisme_ID integer
)
AS
DELETE FROM DavaGelismesi WHERE Gelisme_ID = @Gelisme_ID
GO