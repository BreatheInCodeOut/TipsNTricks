--OFFSET and FETCH is used to limit the rows returned

SELECT FROM dbo.Students ORDER BY Class, Section
OFFSET 5 ROWS --Skips the first 5 rows and returns all remaining rows

SELECT * FROM dbo.Student ORDER BY Class, Section 
OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY --returns the first 10 rows

/* 
Use the OFFSET and FETCH clauses instead of the TOP clause to implement a query paging solution and 
limit the number of rows sent to a client application */