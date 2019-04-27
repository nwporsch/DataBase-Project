--Selects a given orderline from the database
CREATE OR ALTER PROCEDURE GameStore.GetOrderLineId
	@OrderId INT,
    @GameStoreInfoId INT
AS

SELECT OL.OrderLineId
FROM GameStore.OrderLines OL
WHERE OL.OrderId = @OrderId AND OL.GameStoreInfoId = @GameStoreInfoId
GO