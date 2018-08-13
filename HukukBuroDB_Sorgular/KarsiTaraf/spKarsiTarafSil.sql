CREATE PROCEDURE spKarsiTarafSil
(
@KarsiTaraf_ID integer
)
AS
DELETE FROM KarsiTaraf WHERE KarsiTaraf_ID = @KarsiTaraf_ID
GO