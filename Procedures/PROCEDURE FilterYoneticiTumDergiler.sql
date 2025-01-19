CREATE PROCEDURE FilterYoneticiTumDergiler
    @FilterValue NVARCHAR(100)
AS
BEGIN
    SELECT Dergi_Barkod_ID, Dergi_Ad, Dergi_Tur, Dergi_Ucret, Dergi_Yayin_evi
    FROM Dergi
    WHERE Dergi_Ad LIKE  @FilterValue + '%'
    OR Dergi_Tur LIKE  @FilterValue + '%'
    OR Dergi_Yayin_evi LIKE  @FilterValue + '%'
END
