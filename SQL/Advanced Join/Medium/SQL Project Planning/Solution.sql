WITH B AS(
    SELECT
        DISTINCT
 -- *,
        CASE
            WHEN PREV_END_DATE IS NULL OR DATEDIFF(DAY, A.PREV_END_DATE, A.END_DATE) > 1 THEN
                A.START_DATE
            ELSE
                NULL
        END AS START_DATE,
        CASE
            WHEN DATEDIFF(DAY, A.PREV_END_DATE, A.END_DATE) > 1 THEN
                A.PREV_END_DATE
            ELSE
                NULL
        END AS END_DATE
    FROM
        (
            SELECT
                *,
                LAG(END_DATE,
                1) OVER(
            ORDER BY
                END_DATE ASC) AS PREV_END_DATE
            FROM
                PROJECTS
        ) A
)
SELECT
    T1.START_DATE,
    T1.END_DATE
FROM
    B
    INNER JOIN (
        SELECT
            LAG(START_DATE,
            1,
            (
            SELECT
                TOP 1 START_DATE
            FROM
                B
            ORDER BY
                START_DATE DESC)) OVER(ORDER BY START_DATE ASC) AS START_DATE,
                CASE
                    WHEN END_DATE IS NULL THEN
                        (
                            SELECT
                                TOP 1 END_DATE
                            FROM
                                PROJECTS
                            ORDER BY
                                START_DATE DESC
                        )
                    ELSE
                        END_DATE
                END AS END_DATE
            FROM
                B
    ) T1
    ON T1.START_DATE = B.START_DATE
WHERE
    B.START_DATE IS NOT NULL
ORDER BY
    DATEDIFF(DAY,T1.START_DATE,T1.END_DATE),
    B.START_DATE