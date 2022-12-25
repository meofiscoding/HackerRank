DECLARE @Counter INT;
SET @Counter=1
WHILE ( @Counter <= 20)
BEGIN
    PRINT REPLICATE('* ' , @Counter)
    SET @Counter  = @Counter  + 1
END