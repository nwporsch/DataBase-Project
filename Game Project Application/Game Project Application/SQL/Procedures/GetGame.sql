CREATE OR ALTER PROCEDURE GameStore.GetGame
	@GameId INT
AS

SELECT G.StoreId, G.GameTitle, G.UnitPrice, G.Quantity, G.IsUsed
FROM GameStore.Games G
WHERE G.GameId = @GameId
GO