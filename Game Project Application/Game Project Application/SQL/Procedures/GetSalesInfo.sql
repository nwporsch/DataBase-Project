﻿--Retireves the sales information of a store. The information is displayed per month per year, 
--and gives how many sales made in a year and for how much
CREATE OR ALTER PROCEDURE GameStore.GetSalesInfo
	@StoreId INT
AS

WITH SalesTotalCte(StoreID, OrderYear, OrderMonth, Sales, OrderCount) AS
	(
		SELECT S.StoreId,
			YEAR(O.DatePlaced) OrderYear,
			MONTH(O.DatePlaced) OrderMonth,
			SUM(OL.Quantity * OL.UnitPrice) Sales,
			COUNT(O.OrderId)
		FROM GameStore.Orders O
			INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
			INNER JOIN GameStore.Stores S ON S.StoreId = @StoreId
		WHERE S.StoreId = @StoreId
		GROUP BY S.StoreId, MONTH(O.DatePlaced), YEAR(O.DatePlaced)
	)
SELECT S.StoreId, OT.OrderYear, OT.OrderMonth, OT.Sales,
	OT.OrderCount,
	SUM(OT.Sales) OVER(
		PARTITION BY OT.StoreId, OT.OrderYear
		ORDER BY OT.StoreId ASC
		ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS YearlySales,
	SUM(OT.OrderCount) OVER(
		PARTITION BY OT.StoreID, OT.OrderYear
		ORDER BY OT.StoreId ASC
		ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS YearlyOrders
FROM SalesTotalCte OT
	INNER JOIN GameStore.Stores S ON S.StoreId = OT.StoreId
ORDER BY S.StoreId, OT.OrderYear ASC, OT.OrderMonth ASC
