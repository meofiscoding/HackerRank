WITH A AS (
    SELECT
        SALARY * MONTHS AS TOTAL_EARNING
    FROM
        EMPLOYEE
    WHERE
        (SALARY * MONTHS) = (
            SELECT
                MAX(SALARY * MONTHS)
            FROM
                EMPLOYEE
        )
)
SELECT
    CONCAT(TOTAL_EARNING,
    ' ',
    COUNT(*))
FROM
    A
GROUP BY
    TOTAL_EARNING