CREATE OR ALTER PROCEDURE GameStore.GetSalesInfo
	@Month INT,
	@StoreId INT
AS

WITH OrderTotalCte(StoreID, OrderYear, OrderMonth, Sales, OrderCount) AS
	(
		SELECT S.StoreId,
			YEAR(O.OrderDate) OrderYear,
			MONTH(O.OrderDate) OrderMonth,
			SUM(OL.Quantity * OL.UnitPrice) Sales,
			COUNT(O.OrderId)
		FROM GameStore.Orders O
			INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
			INNER JOIN GameStore.Stores S ON S.StoreId = @StoreId
		GROUP BY S.StoreId, MONTH(O.OrderDate), YEAR(O.OrderDate)
	)
SELECT S.StoreId, OT.OrderYear, OT.OrderMonth, OT.Sales,
	SUM(OT.Sales) OVER(
		PARTITION BY OT.StoreId, OT.OrderYear
		ORDER BY OT.StoreId ASC
		ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS YtdTotal,
	SUM(OT.Sales) OVER(
		PARTITION BY OT.StoreId, OT.OrderMonth
		ORDER BY OT.StoreId ASC
		ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS MonthTotal
FROM OrderTotalCte OT
	INNER JOIN GameStore.Stores S ON S.StoreId = SC.StoreId
WHERE S.StoreId = @StoreId
ORDER BY S.StoreId, OT.OrderYear ASC, OT.OrderMonth ASC
