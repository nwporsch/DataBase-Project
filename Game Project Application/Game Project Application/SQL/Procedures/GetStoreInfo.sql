CREATE OR ALTER PROCEDURE GameStore.GetStoreInfo
	@StoreId INT
AS

SELECT S. StoreId, S.Address, S.City, S.State, H.StartingTime, H.EndingTime, H.Description, SUM(GSI.Quantity) AS GameCount, SUM(OL.Quantity * OL.UnitPrice) AS TotalSales
FROM GameStore.Stores S
INNER JOIN GameStore.Hours H ON H.StoreId = S.StoreId
INNER JOIN GameStore.GameStoreInfo GSI ON GSI.StoreId = S.StoreId
INNER JOIN GameStore.OrderLines OL ON OL.GameStoreInfoId = GSI.GameStoreInfoId
WHERE S.StoreId = @StoreId
GROUP BY S.StoreId, S.Address, S.City, S.State, H.StartingTime, H.EndingTime, H.Description;
