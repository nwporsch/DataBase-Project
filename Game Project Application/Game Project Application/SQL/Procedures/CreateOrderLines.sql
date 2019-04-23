CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId INT,
	@OrderLineId INT,
	@GameStoreInfoId INT,
	@Quantity INT,
	@UnitPrice DECIMAL(4,2)
AS

WITH SourceCTE (OrderId,OrderLineId, GameStoreInfoId, Quantity, UnitPrice) AS
(
	SELECT V.OrderId, V.OrderLineId, V.GameStoreInfoId, V.Quantity, V.UnitPrice 
	FROM 
	(
		VALUES (@OrderId,@OrderLineId,@GameStoreInfoId,@Quantity,@UnitPrice)
	) V (OrderId,OrderLineId,GameStoreInfoId,Quantity,UnitPrice)
) 

MERGE GameStore.OrderLines OL
USING SourceCTE S ON S.OrderLineId = OL.OrderLineId AND S.OrderId = OL.OrderId
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = OL.Quantity + S.Quantity
WHEN NOT MATCHED AND EXISTS (SELECT * FROM GameStore.Orders O WHERE O.OrderId = S.OrderId) THEN
	INSERT (OrderId,GameStoreInfoId,UnitPrice,Quantity)
		VALUES(@OrderId,@GameStoreInfoId,@UnitPrice,@Quantity);