CREATE PROCEDURE spPersonelEkle
(
@Personel_ID Integer Output, 
@PersonelAdiSoyadi Varchar(30), 
@PersonelKullaniciAdi Varchar(20), 
@PersonelSifre Varchar(20), 
@PersonelYetkisi Varchar(9), 
@isVeriOku Bit, 
@isVeriGir Bit, 
@isVeriGuncelle Bit, 
@isVeriSil Bit, 
@isRaporOlustur Bit, 
@isKullaniciIslemleri Bit
)
AS
BEGIN
	INSERT INTO dbo.Personel
	( 
		PersonelAdiSoyadi, 
		PersonelKullaniciAdi, 
		PersonelSifre, 
		PersonelYetkisi, 
		isVeriOku, 
		isVeriGir, 
		isVeriGuncelle, 
		isVeriSil, 
		isRaporOlustur, 
		isKullaniciIslemleri
	)
	VALUES
	(
		@PersonelAdiSoyadi, 
		@PersonelKullaniciAdi, 
		@PersonelSifre, 
		@PersonelYetkisi, 
		@isVeriOku, 
		@isVeriGir, 
		@isVeriGuncelle, 
		@isVeriSil, 
		@isRaporOlustur, 
		@isKullaniciIslemleri
	)
	SELECT @Personel_ID = @@IDENTITY
END
GO