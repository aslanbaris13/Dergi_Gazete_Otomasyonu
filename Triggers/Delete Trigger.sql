-- Delete Trigger
--ALTER TRIGGER trgDeleteAbone
--ON Abone
--AFTER DELETE
--AS
--BEGIN
--    INSERT INTO DeletedAbone (Musteri_ID, Ad, Soyad, Sifre , Tel_No, Mail, Kayit_Tarihi, Adres, Silinme_Tarihi)
--    SELECT d.Musteri_ID, d.Ad, d.Soyad, d.Sifre , d.Tel_No, d.Mail, d.Kayit_Tarihi, d.Adres, GETDATE()
--    FROM deleted d;
--END;

ALTER TRIGGER trgDeleteAbone
ON Abone
FOR DELETE
AS
BEGIN
    -- Silinen kayýtlarý DeletedAbone tablosuna ekleme
    INSERT INTO DeletedAbone (Musteri_ID, Ad, Soyad, Sifre, Tel_No, Mail, Kayit_Tarihi, Adres, Silinme_Tarihi)
    SELECT d.Musteri_ID, d.Ad, d.Soyad, d.Sifre, d.Tel_No, d.Mail, d.Kayit_Tarihi, d.Adres, GETDATE()
    FROM deleted d;
END;