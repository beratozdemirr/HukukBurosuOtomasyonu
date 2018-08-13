CREATE PROCEDURE spMuvekkilTipiBul
(
@MuvekkilTipi Varchar(18)
)
AS
BEGIN
	SELECT *
	FROM dbo.Muvekkil
	WHERE MuvekkilTipi = @MuvekkilTipi
END
GO
