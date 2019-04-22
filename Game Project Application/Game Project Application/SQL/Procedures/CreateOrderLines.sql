CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId AS INT,
	@GameStoreInfoId AS INT,
	@Quantity AS INT,
	@UnitPrice AS DECIMAL(4,2)
AS

MERGE Games
INSERT INTO GameStore.OrderLines(OrderId,GameStoreInfoId,UnitPrice,Quantity)
	VALUES(@OrderId,@GameStoreInfoId,@UnitPrice,@Quantity);
GO


CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId AS INT,
	@GameStoreInfoId AS INT,
	@Quantity AS INT,
	@UnitPrice AS DECIMAL(4,2)
AS

SELECT *
FROM GameStore.OrderLines OL;

MERGE GameStore.OrderLines OL
	USING(
		SELECT T.OrderId, T.GameStoreInfoId, T.Quantity, T.UnitPrice 
		FROM(
			VALUES (1,1,1,1)
			)
		 T (OrderId,GameStoreInfoId,Quantity,UnitPrice)
	)TH(OrderId,GameStoreInfoId,Quantity,UnitPrice) ON TH.OrderId = OL.OrderId
WHEN MATCHED THEN
	UPDATE
	SET
		Quantity = Quantity + 1;
WHEN NOT MATCHED THEN
	INSERT INTO GameStore.OrderLines(OrderId,GameStoreInfoId,UnitPrice,Quantity)
	VALUES(1,1,1,1)
END;