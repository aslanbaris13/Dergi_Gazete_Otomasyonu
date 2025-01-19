CREATE PROCEDURE FilterYoneticiTumGazeteler
    @FilterValue NVARCHAR(100)
AS
BEGIN
    SELECT Gazete_Barkod_ID, Gazete_Ad, Gazete_Tur, Gazete_Ucret, Gazete_Yayin_evi
    FROM Gazete
    WHERE Gazete_Ad LIKE  @FilterValue + '%'
    OR Gazete_Tur LIKE  @FilterValue + '%'
    OR Gazete_Yayin_evi LIKE  @FilterValue + '%'
END