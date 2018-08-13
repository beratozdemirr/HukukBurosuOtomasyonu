CREATE TRIGGER [dbo].[trDavaFiyatiniArtir]
	ON [dbo].[DavaGelismesi]
	FOR insert
AS
DECLARE
@DavaDurumu Varchar(10),
@Dava_ID int,
@Gelisme_ID int

select @DavaDurumu=DavaDurumu,@Dava_ID=Dava_ID from inserted

if(@DavaDurumu = 'ERTELENDÝ' )
begin 
update Dava set DavaTutari = DavaTutari+(DavaTutari*0.5) where Dava_ID = (select Dava_ID from DavaGelismesi where Gelisme_ID  = ( select top 1 Gelisme_ID  from DavaGelismesi order by Gelisme_ID desc ))
end


