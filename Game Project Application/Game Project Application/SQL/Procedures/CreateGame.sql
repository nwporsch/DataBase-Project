CREATE OR ALTER PROCEDURE GameStore.CreateGame
	@StoreId INT,
	@Title NVARCHAR(64),
	@UnitPrice DECIMAL(4,2),
	@IsUsed BIT,
	@Quantity INT,
	@GameId INT OUTPUT
AS

INSERT GameStore.Games(Store, Title, UnitPrice, IsUsed, Quantity)
Values(@StoreId, @Title, @UnitPrice, @IsUsed, @Quantity)

Set @GameId = SCOPE_IDENTITY();
GO