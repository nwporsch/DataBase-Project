CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId AS INT,
	@GameStoreInfoId AS INT,
	@Quantity AS INT,
	@UnitPrice AS DECIMAL(4,2)
AS

MERGE GameStore.OrderLines OL
	USING(
		SELECT T.OrderId, T.GameStoreInfoId, T.Quantity, T.UnitPrice 
		FROM(
			VALUES (@OrderId,@GameStoreInfoId,@Quantity,@UnitPrice)
			)
		 T (OrderId,GameStoreInfoId,Quantity,UnitPrice)
	)TH(OrderId,GameStoreInfoId,Quantity,UnitPrice) ON TH.OrderId = OL.OrderId
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = OL.Quantity + TH.Quantity
WHEN NOT MATCHED THEN
	INSERT (OrderId,GameStoreInfoId,UnitPrice,Quantity)
		VALUES(@OrderId,@GameStoreInfoId,@UnitPrice,@Quantity);