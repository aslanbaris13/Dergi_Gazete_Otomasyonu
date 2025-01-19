SELECT
    S.Satis_No,
    A.Musteri_ID,
    A.Ad,
    A.Soyad,
    D.Dergi_Barkod_ID,
    D.Dergi_Ad,
    D.Dergi_Tur,
    D.Dergi_Ucret
FROM
    SatýnAlýnanDergi S
INNER JOIN 
    Abone A ON S.Musteri_ID = A.Musteri_ID
INNER JOIN
    Dergi D ON S.Dergi_Barkod_ID = D.Dergi_Barkod_ID;