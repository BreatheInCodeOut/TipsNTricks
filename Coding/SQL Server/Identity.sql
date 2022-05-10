--4 different ways to retrieve the newly generated identity value after rows have been inserted into a table

--[1]
@@IDENTITY
-- Returns the last identity value generated in any table in the current session but from any Scope

--[2]
SCOPE_IDENTITY()
--Returns the last identity value generated in any table in the current Session and within the current Scope

--[3]
IDENT_CURRENT('table_or_view')
-- Returns the identity value generated for a specific table in any session and any scope

--[4]
OUTPUT

DECLARE @MyTableVar TABLE (NewID SMALLINT); 
    
INSERT dbo.Employee  
    OUTPUT INSERTED.EmployeeID
        INTO @MyTableVar  
VALUES (N'Michele', GETDATE());

/* Returns information from, or expressions based on, each row affected by an INSERT, UPDATE, DELETE, or MERGE statement
   Can return multiple values unlike others. */

-- *Scope is the current query or the current stored procedure 
-- *Session is the database connection