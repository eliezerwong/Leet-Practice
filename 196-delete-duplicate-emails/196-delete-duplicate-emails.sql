/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
delete p1 
from person p1, person p2 
where p1.email = p2.email and p1.id > p2.id 