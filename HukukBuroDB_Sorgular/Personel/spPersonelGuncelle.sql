CREATE PROCEDURE spPersonelGuncelle
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
	UPDATE Personel
	SET 
		PersonelAdiSoyadi = @PersonelAdiSoyadi,
		PersonelKullaniciAdi = @PersonelKullaniciAdi,
		PersonelSifre = @PersonelSifre,
		PersonelYetkisi = @PersonelYetkisi,
		isVeriOku = @isVeriOku,
		isVeriGir = @isVeriGir,
		isVeriGuncelle = @isVeriGuncelle,
		isVeriSil = @isVeriSil,
		isRaporOlustur = @isRaporOlustur,
		isKullaniciIslemleri = @isKullaniciIslemleri
	WHERE 
		Personel_ID = @Personel_ID
	SELECT @Personel_ID = @@IDENTITY
END