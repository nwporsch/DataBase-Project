--CREATE OR ALTER PROCEDURE GameStore.GetCustomerId
--	@StoreId INT
--AS

SELECT S.Address, S.City, S.State, H.StartingTime, H.EndingTime, H.Description, SUM(GSI.Quantity) AS GameCount,  
FROM GameStore.Stores S
INNER JOIN GameStore.Hours H ON H.StoreId = S.StoreId
INNER JOIN GameStore.GameStoreInfo GSI ON GSI.StoreId = S.StoreId
INNER JOIN GameStore.OrderLines OL ON OL.

