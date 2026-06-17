/* Write your T-SQL query statement below */


SELECT
    m.employee_id,
    m.name,
    COUNT(*) AS reports_count,
    CAST(ROUND(AVG(CAST(e.age AS FLOAT)), 0) AS INT) AS average_age
FROM Employees e
INNER JOIN Employees m
    ON m.employee_id = e.reports_to
GROUP BY
    m.employee_id,
    m.name
 ORDER BY m.employee_id;   