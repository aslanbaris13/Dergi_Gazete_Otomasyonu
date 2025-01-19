-- Insert Trigger
CREATE TRIGGER trgInsertAbone
ON Abone
AFTER INSERT
AS
BEGIN
    PRINT 'Yeni bir abone eklendi.'
END;
