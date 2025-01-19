ALTER TABLE dbo.Sat�nAl�nanDergi
DROP CONSTRAINT FK_Sat�nAl�nanDergi_Dergi;

-- Yeni k�s�tlamay� eklemek
ALTER TABLE dbo.Sat�nAl�nanDergi
ADD CONSTRAINT FK_Sat�nAl�nanDergi_Dergi
FOREIGN KEY (Dergi_Barkod_ID) REFERENCES dbo.Dergi(Dergi_Barkod_ID)
ON DELETE CASCADE;