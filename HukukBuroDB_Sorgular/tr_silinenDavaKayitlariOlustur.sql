CREATE TRIGGER [dbo].[silinenDavaKayitlariOlustur]
	ON [dbo].[DavaSonucu]
	FOR DELETE
AS
    INSERT INTO [dbo].[SilinmisDavaKayitlari] ([SilinmisKayit_ID], [Muvekkil_ID], [KarsiTaraf_ID], [DavaBitisTarihi], [DavaSonucu])
       SELECT 
            [DavaSonuc_ID], [Muvekkil_ID], [KarsiTaraf_ID], [DavaBitisTarihi], [DavaSonucu]
       FROM [deleted]

	
