CREATE OR ALTER PROCEDURE GameStore.GetSalesInfo
	@Month INT,
	@StoreId INT
AS

WITH SalesTotalCte(StoreID, OrderYear, OrderMonth, Sales, OrderCount) AS
	(
		SELECT S.StoreId,
			YEAR(O.OrderDate) OrderYear,
			MONTH(O.OrderDate) OrderMonth,
			SUM(OL.Quantity * OL.UnitPrice) Sales,
			COUNT(O.OrderId)
		FROM GameStore.Orders O
			INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
			INNER JOIN GameStore.Stores S ON S.StoreId = @StoreId
		WHERE S.StoreId = @StoreId AND (MONTH(OT.OrderMonth) = @Month OR YEAR(OT.OrderYear) = @Month)
		GROUP BY S.StoreId, MONTH(O.OrderDate), YEAR(O.OrderDate)
	)
SELECT S.StoreId, OT.OrderYear, OT.OrderMonth, OT.Sales,
	OT.OrderCount,
	SUM(OT.Sales) OVER(
		PARTITION BY OT.StoreId
		ORDER BY OT.StoreId ASC
		ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS Total
FROM SalesTotalCte OT
	INNER JOIN GameStore.Stores S ON S.StoreId = SC.StoreId
ORDER BY S.StoreId, OT.OrderYear ASC, OT.OrderMonth ASC
