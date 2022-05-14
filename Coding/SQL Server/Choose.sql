--CHOOSE - Returns the item at the specified index from a list of values

SELECT EmployeeId,
	   CHOOSE(DATEPART(QUARTER, DateOfJoin),
			'Q1: Jan - Mar', 'Q2: Apr - Jun', 'Q3: Jul - Sep', 'Q4: Oct - Dec')
FROM dbo.Employee