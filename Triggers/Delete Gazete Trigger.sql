  --Delete Trigger
--  CREATE Trigger trgDeletedGazete
--  ON Gazete
--  AFTER DELETE
--  AS
--  BEGIN
--      INSERT INTO DeletedGazete (Gazete_Barkod_ID, Gazete_Ad, Gazete_Tur, Gazete_Ucret, Gazete_YayinEvi)
--	  SELECT g.Gazete_Barkod_ID, g.Gazete_Ad, g.Gazete_Tur, g.Gazete_Ucret, g.Gazete_Yayin_Evi
--	  FROM deleted g;
--END;

Alter TRIGGER trgDeletedGazete
ON Gazete
INSTEAD OF DELETE
AS
BEGIN
    -- Silinen kay�tlar� DeletedGazete tablosuna ekleme
    INSERT INTO DeletedGazete (Gazete_Barkod_ID, Gazete_Ad, Gazete_Tur, Gazete_Ucret, Gazete_Yayin_evi)
    SELECT g.Gazete_Barkod_ID, g.Gazete_Ad, g.Gazete_Tur, g.Gazete_Ucret, g.Gazete_Yayin_Evi
    FROM deleted g;

    -- As�l tablo Gazete'den kay�tlar� silme i�lemini ger�ekle�tir
    DELETE FROM Gazete
    WHERE Gazete_Barkod_ID IN (SELECT Gazete_Barkod_ID FROM deleted);
END;