--Selects a store based on a given storeId and displays the information about a store, such as its
--address, hours of operation, and its current stock and sales total
CREATE OR ALTER PROCEDURE GameStore.GetStoreInfo
	@StoreId INT
AS

SELECT S. StoreId, S.Address, S.City, S.State, H.StartingTime, H.EndingTime, H.Description, SUM(GSI.Quantity) AS GameCount, IIF(SUM(OL.Quantity * OL.UnitPrice) IS NULL, 0, SUM(OL.Quantity * OL.UnitPrice))  AS TotalSales
FROM GameStore.Stores S
INNER JOIN GameStore.Hours H ON H.StoreId = S.StoreId
INNER JOIN GameStore.GameStoreInfo GSI ON GSI.StoreId = S.StoreId
LEFT JOIN GameStore.OrderLines OL ON OL.GameStoreInfoId = GSI.GameStoreInfoId
WHERE S.StoreId = @StoreId
GROUP BY S.StoreId, S.Address, S.City, S.State, H.StartingTime, H.EndingTime, H.Description;