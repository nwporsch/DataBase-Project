--Creates the CreateGame procedure to add a new game to the Games table
CREATE OR ALTER PROCEDURE GameStore.CreateGame
	@StoreId INT,
	@Title NVARCHAR(64),
	@UnitPrice DECIMAL(4,2),
	@IsUsed BIT,
	@Quantity INT,
	@GameId INT OUTPUT
AS

INSERT GameStore.Games(StoreId, Title, UnitPrice, IsUsed, Quantity)
Values(@StoreId, @Title, @UnitPrice, @IsUsed, @Quantity)

Set @GameId = SCOPE_IDENTITY();
GO

--Creates the CreateCustomer procedure to add new a customer to Customers table
CREATE OR ALTER PROCEDURE GameStore.CreateCustomer
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(20),
	@Email NVARCHAR(64),
	@Address NVARCHAR(64),
	@City NVARCHAR(64),
	@State NVARCHAR(20),
	@CustomerId INT OUTPUT
AS

INSERT GameStore.Customers(FirstName, LastName, Email, Address, City, State)
VALUES (@FirstName, @LastName, @Email, @Address, @City, @State)

SET @CustomerId = SCOPE_IDENTITY();
GO

--Creates the GetGame Procedure to return a specified game from the Games table
CREATE OR ALTER PROCEDURE GameStore.GetGame
	@GameId INT
AS

SELECT G.StoreId, G.Title, G.UnitPrice, G.Quantity, G.IsUsed
FROM GameStore.Games G
WHERE G.GameId = @GameId
GO

--Creates the RetrieveGames procedure to return all games in the Games table
CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
AS

SELECT G.GameId, G.StoreId, G.Title, P.PlatformName, G.UnitPrice, G.Quantity, G.IsUsed
FROM GameStore.Games G
--INNER JOIN GameStore.GameGenre GG ON GG.GameId = G.GameId
INNER JOIN GameStore.GamePlatform GP ON GP.GameId = G.GameId
--INNER JOIN GameStore.Genres Ge ON Ge.GenreId = GG.GenreId
INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
