-- Update Trigger
--CREATE TRIGGER trgUpdateAbone
--ON Abone
--AFTER UPDATE
--AS
--BEGIN
--    INSERT INTO UpdatedAbone (Musteri_ID, Ad, Soyad, Tel_No, Mail, Kayit_Tarihi, Adres, Guncellenme_Tarihi)
--    SELECT d.Musteri_ID, d.Ad, d.Soyad, d.Tel_No, d.Mail, d.Kayit_Tarihi, d.Adres, GETDATE()
--    FROM deleted d;
--END;

ALTER TRIGGER trgUpdateAbone
ON Abone
FOR UPDATE
AS
BEGIN
    INSERT INTO UpdatedAbone (Musteri_ID, Ad, Soyad, Tel_No, Mail, Kayit_Tarihi, Adres, Guncellenme_Tarihi)
    SELECT d.Musteri_ID, d.Ad, d.Soyad, d.Tel_No, d.Mail, d.Kayit_Tarihi, d.Adres, GETDATE()
    FROM deleted d;
END;

