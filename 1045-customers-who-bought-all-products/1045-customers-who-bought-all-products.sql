/* Write your T-SQL query statement below */
DECLARE @total INT
set @total = (select count(*)from Product);


select distinct customer_id from
(
select * , DENSE_RANK() OVER(partition by customer_id ORDER BY product_key) as dn
from Customer
) temp
where temp.dn = @total;