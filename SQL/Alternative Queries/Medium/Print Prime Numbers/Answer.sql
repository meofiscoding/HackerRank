-- First we will DECLARE a variable I with initial value 2.
DECLARE @I INT=2

-- Then we will DECLARE a variable PRIME with an initial value of 0 (this will set the value of PRIME).
DECLARE @PRIME INT = 0

-- Step 3: Table Definition 
-- We will create a temporary table variable that will hold prime numbers (using DECLARE and TABLE keywords).
DECLARE @OUTPUT TABLE (NUM INT)

-- Step 4: Now we will use nested while loop, same as we write a program for prime numbers.
WHILE @I<=1000
BEGIN
    DECLARE @J INT = @I-1
    SET @PRIME=1
    WHILE @J>1
    BEGIN
        IF @I % @J=0
        BEGIN
            SET @PRIME=0
        END
        SET @J=@J-1
    END
    IF @PRIME =1
    BEGIN
        INSERT @OUTPUT VALUES (@I)
    END
    SET @I=@I+1
END

-- Select concat with &
SELECT STRING_AGG(NUM,'&') FROM @OUTPUT

