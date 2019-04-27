--Creates or updates order lines in the database. When a new game is added to the order, the procedure either adds it to the order
--if another copy of the game is not in the order, or, if there aldready exists a copy of the game in the order, the quantity 
--ordered is updated instead. 
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


/*SELECT *
FROM GameStore.Customers C
INNER JOIN GameStore.Orders O ON O.CustomerId = C.CustomerId
INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId*/