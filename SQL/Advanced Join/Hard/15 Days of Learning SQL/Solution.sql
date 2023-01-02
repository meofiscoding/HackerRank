WITH B AS(
    SELECT
        A.SUBMISSION_DATE,
        A.NUMBER_SUBMISSION,
        A.HACKER_ID,
        A.NAME,
        MAX(A.NUMBER_SUBMISSION) OVER (
        PARTITION BY A.SUBMISSION_DATE) AS MAX_SUBMISSION
    FROM
        (
            SELECT
                DISTINCT S.SUBMISSION_DATE,
                S.HACKER_ID,
                HACKERS.NAME,
                COUNT(S.SUBMISSION_ID) OVER (
                PARTITION BY S.HACKER_ID, S.SUBMISSION_DATE) AS NUMBER_SUBMISSION
            FROM
                SUBMISSIONS S
                INNER JOIN HACKERS
                ON S.HACKER_ID = HACKERS.HACKER_ID
        ) A
)
SELECT
    B.SUBMISSION_DATE,
    T2.TOTAL_HACKER,
    B.HACKER_ID,
    B.NAME
FROM
    B
    RIGHT JOIN (
        SELECT
            TOP 1 WITH TIES *
        FROM
            B
        WHERE
            B.NUMBER_SUBMISSION = B.MAX_SUBMISSION
        ORDER BY
            ROW_NUMBER() OVER (PARTITION BY B.SUBMISSION_DATE ORDER BY B.HACKER_ID)
    ) T1
    ON T1.SUBMISSION_DATE = B.SUBMISSION_DATE
    AND T1.HACKER_ID = B.HACKER_ID
 -- GET COMMON PEOPLE EACH DAY FROM STARTING DAY
    INNER JOIN (
        SELECT
            DISTINCT A.SUBMISSION_DATE,
            COUNT(A.SUBMISSION_DATE) OVER (
            PARTITION BY A.SUBMISSION_DATE) AS TOTAL_HACKER
        FROM
            (
                SELECT
                    DISTINCT S.SUBMISSION_DATE,
                    S.HACKER_ID,
                    T1.SUBMISSION_DATE AS DATE_COMPARE,
                    T1.HACKER_ID AS ID_COMPARE
                FROM
                    SUBMISSIONS S
                    INNER JOIN (
                        SELECT
                            *
                        FROM
                            SUBMISSIONS
                    ) T1
                    ON S.SUBMISSION_DATE >= T1.SUBMISSION_DATE
                    AND S.HACKER_ID = T1.HACKER_ID
            ) A
        GROUP BY
            A.SUBMISSION_DATE,
            HACKER_ID
        HAVING
            COUNT(A.HACKER_ID) = DATEPART(DD,
            A.SUBMISSION_DATE)
    ) T2
    ON T2.SUBMISSION_DATE = T1.SUBMISSION_DATE
ORDER BY
    B.SUBMISSION_DATE