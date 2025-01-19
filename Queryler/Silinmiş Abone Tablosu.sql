CREATE TABLE DeletedAbone (
    Musteri_ID INT,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    Tel_No NVARCHAR(15),
    Mail NVARCHAR(100),
    Kayit_Tarihi DATE,
    Adres NVARCHAR(255),
    Silinme_Tarihi DATE DEFAULT GETDATE()
);
