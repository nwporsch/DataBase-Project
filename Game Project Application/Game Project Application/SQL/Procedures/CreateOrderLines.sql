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
		T(OrderId, GameStoreInfoId, Quantity, UnitPrice)
		)TH(OrderId,GameStoreInfoId, Quantity, UnitPrice) ON EXISTS (SELECT * 
																	 FROM GameStore.OrderLines OL
																		
																	WHERE OL.OrderId = @OrderId
																	AND OL.GameStoreInfoId = @GameStoreInfoId
																	)
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = OL.Quantity + TH.Quantity
WHEN NOT MATCHED AND EXISTS (SELECT * FROM GameStore.Orders O WHERE O.OrderId = @OrderId) THEN
	INSERT (OrderId,GameStoreInfoId,Quantity,UnitPrice)
		VALUES(TH.OrderId,TH.GameStoreInfoId,TH.Quantity,TH.UnitPrice);