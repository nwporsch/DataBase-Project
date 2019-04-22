CREATE OR ALTER PROCEDURE GameStore.CreateOrder
	@CustomerId AS INT
AS

INSERT INTO GameStore.Orders(CustomerId, DatePlaced) 
	VALUES(@CustomerId, SYSDATETIMEOFFSET());
GO