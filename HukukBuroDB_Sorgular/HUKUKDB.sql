--CREATE DATABASE HukukBuroDB
-----------------------------

CREATE TABLE Muvekkil(
Muvekkil_ID Integer Primary Key Identity(1,1),
Muvekkil_Isim Varchar(50) Not Null,
MuvekkilTCNo Varchar(11)
	Constraint ck_MuvTcNo
	Check(MuvekkilTCNo LIKE '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][02468]'),
MuvekkilVergiNo Varchar(10)
	Constraint ck_MuvVergiNo
	Check(MuvekkilVergiNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
MuvekkilSicilNo Varchar(13)
	Constraint ck_MuvSicilNo
	Check(MuvekkilSicilNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
MuvekkilCinsiyet Varchar(5)
	Constraint ck_MuvCinsiyet
	Check(MuvekkilCinsiyet IN('BAY', 'BAYAN')),
MuvekkilTelefonNo Varchar(11) Not Null
	Constraint ck_MuvTelefonNo
	Check(MuvekkilTelefonNo LIKE '[0][5][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR MuvekkilTelefonNo LIKE '[0][2,3,4][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
MuvekkilAdres Varchar(50) Not Null,
MuvekkilTipi Varchar(18) Not Null
	Constraint ck_MuvTipi
	Check(MuvekkilTipi IN('ALACAKLI', 'BORÇLU', 'HÝSSEDAR', 'MAÐDUR', 'DAVALI')),
MuvekkilSecimi Varchar(7) Not Null
	Constraint ck_MuvSecimi
	Check(MuvekkilSecimi IN('KÝÞÝ', 'KURULUÞ'))
)

CREATE TABLE KarsiTaraf(
KarsiTaraf_ID Integer Primary Key Identity(100,1),
KarsiTaraf_Isim Varchar(50) Not Null,
KarsiTarafTCNo Varchar(11)
	Constraint ck_KTTcNo
	Check(KarsiTarafTCNo LIKE '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][02468]'),
KarsiTarafVergiNo Varchar(10)
	Constraint ck_KTVergiNo
	Check(KarsiTarafVergiNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
KarsiTarafSicilNo Varchar(13)
	Constraint ck_KTSicilNo
	Check(KarsiTarafSicilNo LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
KarsiTarafCinsiyet Varchar(5)
	Constraint ck_KTCinsiyet
	Check(KarsiTarafCinsiyet IN('BAY', 'BAYAN')),
KarsiTarafTelefonNo Varchar(11) Not Null
	Constraint ck_KTTelefonNo
	Check(KarsiTarafTelefonNo LIKE '[0][5][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR KarsiTarafTelefonNo LIKE '[0][2,3,4][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
KarsiTarafAdres Varchar(50) Not Null,
KarsiTarafTipi Varchar(18) Not Null
	Constraint ck_KTTipi
	Check(KarsiTarafTipi IN('ALACAKLI', 'BORÇLU', 'HÝSSEDAR', 'DAVALI')),
KarsiTarafSecimi Varchar (7) Not Null
	Constraint ck_ktSecimi
	Check (KarsiTarafSecimi IN ('KÝÞÝ','KURULUÞ'))
)

CREATE TABLE Adliye(
Adliye_ID Integer Primary Key Identity(1000,1),
AdliyeAdi Varchar(50) Not Null,
AdliyeTelefonNo Varchar(11) Not Null
	Constraint ck_AdliyeTelefonNo
	Check(AdliyeTelefonNo LIKE '[0][2,3,4][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
AdliyeAdres Varchar(50) Not Null
)

CREATE TABLE Personel(
Personel_ID Integer Primary Key Identity(1,1),
PersonelAdiSoyadi Varchar(30) Not Null,
PersonelKullaniciAdi Varchar(20) Not Null,
PersonelSifre Varchar(20) Not Null,
PersonelYetkisi Varchar(9) Not Null
	Constraint ck_PersonelYetkilisi
	Check(PersonelYetkisi IN('ADMÝN', 'KULLANICI')),
isVeriOku bit Not Null,
isVeriGir bit Not Null,
isVeriGuncelle bit Not Null,
isVeriSil bit Not Null,
isRaporOlustur bit Not Null,
isKullaniciIslemleri bit Not Null
)

CREATE TABLE Dava(
Dava_ID Integer Primary Key Identity(1,1),
Muvekkil_ID Integer Not Null
	Constraint fk_DavaMuvID
	Foreign Key(Muvekkil_ID) References Muvekkil(Muvekkil_ID),
KarsiTaraf_ID Integer Not Null
	Constraint fk_DavaKtID
	Foreign Key(KarsiTaraf_ID) References KarsiTaraf(KarsiTaraf_ID),
Personel_ID Integer Not Null
	Constraint fk_DavaPerID
	Foreign Key(Personel_ID) References Personel(Personel_ID),
Adliye_ID Integer Not Null
	Constraint fk_DavaAdliyeID
	Foreign Key(Adliye_ID) References Adliye(Adliye_ID),
DavaNo Integer Not Null
	Constraint ck_lenDavaNo
	Check(Len(DavaNo) = 7),
DavaAcilisTarihi Date Not Null, --DEFAULT GETDATE ALACAK EKLE!!
DavaTuru Varchar(30) Not Null
	Constraint ck_DavaTuru
	Check(DavaTuru IN('KÝRA DAVALARI', 'AÝLE DAVALARI', 'MÝRAS DAVALARI', 'BORÇ DAVALARI', 'ÞÝRKET DAVALARI', 'ÝCRA DAVALARI','KÝÞÝLÝK HAKLARI DAVALARI')),
DavaMuvekkilTalep Varchar(255) Not Null,
DavaTutari Money Not Null,
DavaSalonNo Varchar(5) Not Null,
DavaOturumSayisi Tinyint
	Default 1,
DavaGelecekOturumTarihi Date Not Null,
DavaSaati Time Not Null
)

CREATE TABLE DavaGelismesi(
Gelisme_ID Integer Primary Key Identity(1,1),
Muvekkil_ID Integer Not Null
	Constraint fk_GelismeMuvID
	Foreign Key(Muvekkil_ID) References Muvekkil(Muvekkil_ID),
Dava_ID Integer Not Null
	Constraint fk_GelismeDavaID
	Foreign Key(Dava_ID) References Dava(Dava_ID),
GelismeAciklamasi Varchar(50) Not Null,
GelismeTarihi Date Not Null
	Default Getdate(),
DavaDurumu Varchar(10) Not Null
	Constraint ck_DavaDurumu
	Check(DavaDurumu IN('ERTELENDÝ', 'SONUÇLANDI'))
)

CREATE TABLE DavaSonucu(
DavaSonuc_ID Integer Primary Key Identity(1,1),
Muvekkil_ID Integer Not Null
	Constraint fk_SonucMuvID
	Foreign Key(Muvekkil_ID) References Muvekkil(Muvekkil_ID),
KarsiTaraf_ID Integer Not Null
	Constraint fk_SonucKtID
	Foreign Key(KarsiTaraf_ID) References KarsiTaraf(KarsiTaraf_ID),
DavaBitisTarihi Date Not Null,
DavaSonucu Varchar(9) Not Null
	Constraint ck_DavaSonucu
	Check(DavaSonucu IN('BAÞARILI', 'BAÞARISIZ'))
)

CREATE TABLE SilinmisDavaKayitlari
(
SilinmisKayit_ID Integer Not Null,
Muvekkil_ID Integer Not Null,
KarsiTaraf_ID Integer Not Null,
DavaBitisTarihi Date Not Null,
DavaSonucu Varchar(9) Not Null
)


--DROP DATABASE HukukBuroDB

--CREATE DATABASE HukukBuroDB

--USE HukukBuroDB









