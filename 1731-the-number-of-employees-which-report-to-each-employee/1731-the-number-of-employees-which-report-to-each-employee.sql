/* Write your T-SQL query statement below */

-- Write your PostgreSQL query statement below
SELECT t1.employee_id, t1.name, COUNT(t2.employee_id) AS reports_count,
    CAST(ROUND(AVG(CAST(t2.age AS FLOAT)), 0) AS INT) AS average_age
FROM Employees t1
JOIN Employees t2
    ON t1.employee_id = t2.reports_to
GROUP BY t1.employee_id, t1.name
ORDER BY t1.employee_id;