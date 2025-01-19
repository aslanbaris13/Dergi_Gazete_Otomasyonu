ALTER PROCEDURE FilterYoneticiTumAboneler
    @FilterValue NVARCHAR(100)
AS
BEGIN
    SELECT Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres
    FROM Abone
    WHERE Musteri_ID LIKE  @FilterValue + '%' 
	OR Ad LIKE  @FilterValue + '%'
    OR Soyad LIKE  @FilterValue + '%'
	OR Tel_No LIKE  @FilterValue + '%'
	OR Mail LIKE  @FilterValue + '%'
	OR Kayit_Tarihi LIKE  @FilterValue + '%'
	OR Adres LIKE  @FilterValue + '%'
END