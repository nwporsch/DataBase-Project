CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
@Title NVARCHAR(128),
@Genre NVARCHAR(128),
@MinPrice DECIMAL(4,2),
@MaxPrice DECIMAL(4,2),
@IsUsed BIT

AS

SELECT G.GameId, G.StoreId, G.Title, G.UnitPrice, G.Quantity, G.IsUsed, G.Title
FROM GameStore.Games G
WHERE G.Title = CASE @Title
				WHEN N'*'
				THEN
					G.Title
				ELSE
					@Title
				END
GROUP BY G.StoreId, G.GameId, G.UnitPrice, G.Title, G.Quantity, G.IsUsed
HAVING G.UnitPrice >=
		CASE @MinPrice
				WHEN -1
				THEN
					MIN(G.UnitPrice)
				ELSE
					@MinPrice
				END
AND G.UnitPrice <=
		 CASE @MaxPrice
				WHEN -1
				THEN
					Max(G.UnitPrice)
				ELSE
					@MaxPrice
				END

GO