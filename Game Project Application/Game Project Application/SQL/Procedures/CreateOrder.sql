--Adds a new order to the database based on the customerId provided.
CREATE OR ALTER PROCEDURE GameStore.CreateOrder
	@CustomerId AS INT
AS

INSERT INTO GameStore.Orders(CustomerId, DatePlaced) 
	VALUES(@CustomerId, SYSDATETIMEOFFSET());
GO