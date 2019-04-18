CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
AS

SELECT G.GameId, G.StoreId, G.GameTitle, G.UnitPrice, G.Quantity, G.IsUsed. G.Title
FROM GameStore.Games G
GO
