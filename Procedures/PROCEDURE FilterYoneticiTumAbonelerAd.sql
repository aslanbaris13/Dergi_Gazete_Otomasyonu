CREATE PROCEDURE FilterYoneticiTumAbonelerAd
    @FilterValue NVARCHAR(100)
AS
BEGIN
    SELECT Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres
    FROM Abone
    WHERE Ad LIKE  @FilterValue + '%'
   
END