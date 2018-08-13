CREATE PROCEDURE spDavaSonucuSil
(
@DavaSonuc_ID integer
)
AS
DELETE FROM DavaSonucu WHERE DavaSonuc_ID = @DavaSonuc_ID
GO