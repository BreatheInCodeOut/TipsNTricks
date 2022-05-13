--SQL SERVER: LAG & LEAD

-- Accesses data from a previous/subsequent (nth) row in the same resultset without the use of self-join

DECLARE @GoldRates TABLE (RateDate DATE, RatePerGram MONEY)

INSERT INTO @GoldRates (RateDate, RatePerGram)
VALUES
(GETDATE()-1, 4460), (GETDATE()-2, 4387), (GETDATE()-3, 4564),
(GETDATE()-4, 4460), (GETDATE()-5, 4489), (GETDATE()-6, 4960),
(GETDATE()-7, 4925), (GETDATE()-8, 4847), (GETDATE()-9, 4823), 
(GETDATE()-10, 4745), (GETDATE()-11, 4660), (GETDATE()-12, 4560)

SELECT RateDate,
LAG (RatePerGram) OVER(ORDER BY RateDate) AS PreviousDayRate, RatePerGram AS CurrentDayRate,
LEAD (RatePerGram) OVER (ORDER BY RateDate) AS NextDayDate
FROM @GoldRates

/*

(12 rows affected)
RateDate   PreviousDayRate       CurrentDayRate        NextDayDate
---------- --------------------- --------------------- ---------------------
2022-05-01 NULL                  4560.00               4660.00
2022-05-02 4560.00               4660.00               4745.00
2022-05-03 4660.00               4745.00               4823.00
2022-05-04 4745.00               4823.00               4847.00
2022-05-05 4823.00               4847.00               4925.00
2022-05-06 4847.00               4925.00               4960.00
2022-05-07 4925.00               4960.00               4489.00
2022-05-08 4960.00               4489.00               4460.00
2022-05-09 4489.00               4460.00               4564.00
2022-05-10 4460.00               4564.00               4387.00
2022-05-11 4564.00               4387.00               4460.00
2022-05-12 4387.00               4460.00               NULL

(12 rows affected)

*/