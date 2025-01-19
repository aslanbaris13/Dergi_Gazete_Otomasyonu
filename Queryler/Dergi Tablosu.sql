CREATE TABLE Dergi (
    Dergi_Barkod_ID INT IDENTITY PRIMARY KEY,
    Dergi_Ad NVARCHAR(100) NOT NULL CHECK (LEN(Dergi_Ad) > 0),
    Dergi_Tur NVARCHAR(50) NOT NULL,
    Dergi_Ucret DECIMAL(10, 2) CHECK (Dergi_Ucret > 0),
    Dergi_Yayin_evi NVARCHAR(100) NOT NULL CHECK (LEN(Dergi_Yayin_evi) > 0)
);