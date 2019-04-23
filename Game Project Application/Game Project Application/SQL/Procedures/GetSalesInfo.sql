CREATE OR ALTER PROCEDURE GameStore.GetSalesInfo
	@NumberOfOrders INT,
	@TotalSales DECIMAL
AS

SELECT *
FROM GameStore.Orders O
	INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
WHERE MONTH(O.DatePlaced) = 


