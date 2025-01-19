CREATE PROCEDURE FilterYoneticiTumAbonelerMail
    @FilterValue NVARCHAR(100)
AS
BEGIN
    SELECT Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres
    FROM Abone
    WHERE Mail LIKE  @FilterValue + '%'
   
END