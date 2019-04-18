CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
@Title NVARCHAR(128),
@Genre NVARCHAR(128),
@UnitPrice DECIMAL(4,2),
@IsUsed BIT

AS

SELECT G.GameId, G.StoreId, G.Title, G.UnitPrice, G.Quantity, G.IsUsed, G.Title
FROM GameStore.Games G
WHERE G.Title = @Title AND G.UnitPrice = @UnitPrice AND G.IsUsed = @IsUsed
GO
