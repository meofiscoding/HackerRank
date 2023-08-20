SET NOCOUNT ON;

WITH WorkHours AS (
    SELECT 
        emp_id,
        CAST([TIMESTAMP] AS DATE) AS work_date,
        DATEDIFF(HOUR, MIN([TIMESTAMP]), MAX([TIMESTAMP])) as [Hours Worked]
    FROM ATTENDANCE
    WHERE DATEPART(DW, [TIMESTAMP]) IN (1, 7)
    GROUP BY emp_id, CAST([TIMESTAMP] AS DATE)
)
SELECT
    emp_id,
    SUM([Hours Worked]) AS [Total Hours Worked]
FROM WorkHours
GROUP BY emp_id
order by [Total Hours Worked]

GO

-- i think this is the correct version
-- SET NOCOUNT ON;
-- SELECT 
--     emp_id,
--     SUM(DATEDIFF(HOUR, MIN([TIMESTAMP]), MAX([TIMESTAMP]))) as [Total Hours Worked]
-- FROM  ATTENDANCE
-- WHERE
--     DATEPART(DW, [TIMESTAMP]) IN (1, 7)
-- GROUP BY emp_id;

-- GO
