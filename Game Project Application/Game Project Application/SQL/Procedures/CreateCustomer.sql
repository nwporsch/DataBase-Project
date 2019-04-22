CREATE OR ALTER PROCEDURE GameStore.CreateCustomer
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(20),
	@Email NVARCHAR(64),
	@Address NVARCHAR(64),
	@City NVARCHAR(64),
	@State NVARCHAR(20)
AS

INSERT GameStore.Customers(FirstName, LastName, Email, Address, City, State)
VALUES (@FirstName, @LastName, @Email, @Address, @City, @State);

GO