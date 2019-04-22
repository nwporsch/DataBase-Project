CREATE OR ALTER PROCEDURE GameStore.GetOrderId
	@CustomerId INT
AS

SELECT O.OrderId
FROM GameStore.Orders O
	LEFT JOIN GameStore.OrderLines OL ON O.OrderId = OL.OrderId
WHERE O.CustomerId = @CustomerId
GROUP BY O.OrderId
HAVING COUNT(OL.OrderId) = 0
GO