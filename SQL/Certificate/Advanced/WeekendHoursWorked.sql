SET NOCOUNT ON;

    SELECT 
        emp_id, CAST([TIMESTAMP] AS DATE)
        -- datediff(HOUR, MIN([TIMESTAMP]), MAX([TIMESTAMP])) as [Hours Worked]
        FROM  ATTENDANCE
        WHERE
            DATEPART(DW, [TIMESTAMP]) IN (1, 7)
        group by 
            emp_id
    
GO


