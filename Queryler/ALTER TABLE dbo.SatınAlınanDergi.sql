ALTER TABLE dbo.SatýnAlýnanDergi
DROP CONSTRAINT FK_SatýnAlýnanDergi_Dergi;

-- Yeni kýsýtlamayý eklemek
ALTER TABLE dbo.SatýnAlýnanDergi
ADD CONSTRAINT FK_SatýnAlýnanDergi_Dergi
FOREIGN KEY (Dergi_Barkod_ID) REFERENCES dbo.Dergi(Dergi_Barkod_ID)
ON DELETE CASCADE;