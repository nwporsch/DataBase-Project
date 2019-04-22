CREATE OR ALTER PROCEDURE GameStore.CreateOrderLines
	@OrderId AS INT,
	@GameId AS INT,
	@Quantity AS INT,
	@UnitPrice AS DECIMAL(4,2)
AS

INSERT INTO GameStore.OrderLines(OrderId,GameId,UnitPrice,Quantity)
	VALUES(@OrderId,@GameId,@UnitPrice,@Quantity);
GO