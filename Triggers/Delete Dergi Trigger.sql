-- Delete Trigger
--CREATE Trigger trgDeletedDergi
--ON Dergi
--AFTER DELETE
--AS
--BEGIN
--    INSERT INTO DeletedDergi (Dergi_Barkod_ID, Dergi_Ad, Dergi_Tur, Dergi_Ucret, Dergi_YayinEvi)
--    SELECT d.Dergi_Barkod_ID, d.Dergi_Ad, d.Dergi_Tur, d.Dergi_Ucret , d.Dergi_Yayin_Evi
--    FROM�deleted�d;
--END;
Alter TRIGGER trgDeletedDergi
ON Dergi
INSTEAD OF DELETE
AS
BEGIN
    -- Silinen kay�tlar� DeletedDergi tablosuna ekleme
    INSERT INTO DeletedDergi (Dergi_Barkod_ID, Dergi_Ad, Dergi_Tur, Dergi_Ucret, Dergi_Yayin_evi)
    SELECT d.Dergi_Barkod_ID, d.Dergi_Ad, d.Dergi_Tur, d.Dergi_Ucret, d.Dergi_Yayin_Evi
    FROM deleted d;

    -- As�l tablo Dergi'den kay�tlar� silme i�lemini ger�ekle�tir
    DELETE FROM Dergi
    WHERE Dergi_Barkod_ID IN (SELECT Dergi_Barkod_ID FROM deleted);
END;