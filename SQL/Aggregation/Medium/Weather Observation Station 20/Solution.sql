WITH A AS (
    SELECT
        ROW_NUMBER() OVER(
    ORDER BY
        LAT_N) AS NUM_ROW,
        LAT_N
    FROM
        STATION
)
SELECT
    CAST(LAT_N AS DECIMAL(10,4))
FROM
    A
WHERE
    A.NUM_ROW = (
        SELECT
            CEILING(COUNT(*) * 1./2 )
        FROM
            STATION
    )