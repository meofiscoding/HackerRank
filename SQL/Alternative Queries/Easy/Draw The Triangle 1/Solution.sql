DECLARE @Counter INT;
SET @Counter=20
WHILE ( @Counter >=1)
BEGIN
    PRINT REPLICATE('* ' , @Counter)
    SET @Counter  = @Counter  - 1
END