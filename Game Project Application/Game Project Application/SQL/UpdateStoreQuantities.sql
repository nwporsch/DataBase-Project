CREATE OR ALTER PROCEDURE GameStore.UpdateStoreQuantities
	@OrderLineId INT,
	@GameStoreInfoId INT,
	@Quantity INT
AS

WITH SourceCTE (OrderLineId, GameStoreInfoId, Quantity) AS
(

	SELECT V.OrderLineId, V.GameStoreInfoId, V.Quantity
	FROM 
	(
		VALUES (@OrderLineId,@GameStoreInfoId,@Quantity)
	) V (OrderLineId,GameStoreInfoId,Quantity)
) 

MERGE GameStore.GameStoreInfo GSI
USING SourceCTE S ON GSI.GameStoreInfoId = S.GameStoreInfoId AND EXISTS (SELECT * FROM GameStore.OrderLines OL WHERE OL.OrderLineId = S.OrderLineId)
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = GSI.Quantity - S.Quantity;
