CREATE TABLE Gazete (
    Gazete_Barkod_ID INT IDENTITY PRIMARY KEY,
    Gazete_Ad NVARCHAR(100) NOT NULL CHECK (LEN(Gazete_Ad) > 0),
    Gazete_Tur NVARCHAR(50) NOT NULL,
    Gazete_Ucret DECIMAL(10, 2) CHECK (Gazete_Ucret > 0),
    Gazete_Yayin_evi NVARCHAR(100) NOT NULL CHECK (LEN(Gazete_Yayin_evi) > 0)
);