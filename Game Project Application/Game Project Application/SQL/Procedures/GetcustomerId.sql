CREATE OR ALTER PROCEDURE GameStore.GetCustomerId
	@Email NVARCHAR(64)
AS

SELECT C.CustomerId
FROM GameStore.Customers C
WHERE C.Email = @Email
GO