CREATE OR ALTER PROCEDURE GameStore.CreateCustomer
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(20),
	@Email NVARCHAR(64),
	@Address NVARCHAR(64),
	@City NVARCHAR(64),
	@State NVARCHAR(20)
AS

MERGE GameStore.Customers C
	USING(
		SELECT T.FirstName, T.LastName, T.Email, T.Address, T.City, T.State
		FROM(
			VALUES (@FirstName,@LastName,@Email,@Address, @City, @State)
			)
		T(FirstName, LastName, Email, Address, City, State)
		)TH(FirstName,LastName, Email, Address, City, State) ON EXISTS (SELECT * 
																	 FROM GameStore.Customers C
																		
																	WHERE C.Email = TH.Email AND C.FirstName = TH.FirstName AND C.LastName = TH.LastName AND C.Address = TH.Address AND C.City = TH.City AND C.State = TH.State
																	)

WHEN NOT MATCHED AND NOT EXISTS (SELECT * 
							 FROM GameStore.Customers C									
							 WHERE C.Email = TH.Email
							) THEN

	INSERT (FirstName, LastName, Email, Address, City, State)
		VALUES (@FirstName, @LastName, @Email, @Address, @City, @State);
GO