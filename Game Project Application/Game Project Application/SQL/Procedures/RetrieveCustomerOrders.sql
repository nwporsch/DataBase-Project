CREATE OR ALTER PROCEDURE GameStore.RetrieveCustomerOrders
@CustomerId INT,
@First NVARCHAR(20),
@Last NVARCHAR(20),
@Email NVARCHAR(64)

AS

WITH OrderTotalCte(CustomerId, OrderId, OrderTotal) 
AS(
	SELECT O.CustomerId, O.OrderId,
	SUM(OL.Quantity * OL.UnitPrice)
	FROM GameStore.Orders O
	INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
	GROUP BY O.OrderId, O.CustomerId)
SELECT OT.CustomerId, OT.OrderId, C.FirstName, C.LastName, C.Email, 
	SUM(OT.OrderTotal) OVER(PARTITION BY OT.CustomerID ORDER BY OT.OrderID ASC ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS RunningTotal,
	OT.OrderTotal
FROM OrderTotalCte OT
INNER JOIN GameStore.Customers C ON C.CustomerId = OT.CustomerId
WHERE OT.CustomerId = CASE @CustomerId
				WHEN -1
				THEN
					OT.CustomerId
				ELSE
					@CustomerId
				END
AND LOWER(C.FirstName) = CASE @First
				WHEN N'*'
				THEN
					LOWER(C.FirstName)
				ELSE
					LOWER(@First)
				END
AND LOWER(C.LastName) = CASE @Last
				WHEN N'*'
				THEN
					LOWER(C.LastName)
				ELSE
					LOWER(@Last)
				END
AND LOWER(C.Email) = CASE @Email
				WHEN N'*'
				THEN
					LOWER(C.Email)
				ELSE
					LOWER(@Email)
				END
ORDER BY OT.CustomerId ASC, OT.OrderId ASC, C.LastName ASC, C.FirstName ASC
GO