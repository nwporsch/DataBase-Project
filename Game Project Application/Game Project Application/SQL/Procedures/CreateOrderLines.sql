
CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId INT,
	@OrderLineId INT,
	@GameStoreInfoId INT,
	@Quantity INT,
	@UnitPrice DECIMAL(4,2)
AS

WITH SourceCTE (OrderId, GameStoreInfoId, Quantity, UnitPrice) AS
(

	SELECT V.OrderId, V.GameStoreInfoId, V.Quantity, V.UnitPrice 
	FROM 
	(
		VALUES (@OrderId,@GameStoreInfoId,@Quantity,@UnitPrice)
	) V (OrderId,GameStoreInfoId,Quantity,UnitPrice)
) 

MERGE GameStore.OrderLines OL
USING SourceCTE S ON S.OrderId = OL.OrderId AND OL.GameStoreInfoId = S.GameStoreInfoId
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = OL.Quantity + S.Quantity
WHEN NOT MATCHED AND EXISTS (SELECT * FROM GameStore.OrderLines L WHERE L.OrderId = S.OrderId) THEN
	INSERT (OrderId,GameStoreInfoId,UnitPrice,Quantity)
		VALUES(@OrderId,@GameStoreInfoId,@UnitPrice,@Quantity);