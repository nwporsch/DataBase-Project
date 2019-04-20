CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
@Title NVARCHAR(128),
@Genre NVARCHAR(128),
@MinPrice DECIMAL(4,2),
@MaxPrice DECIMAL(4,2),
@StoreId INT,
@IsUsed BIT

AS

SELECT GP.GameId, GSI.StoreId, G.Title, GSI.UnitPrice, GSI.Quantity, C.Condition, G.Title
FROM GameStore.GamePlatform GP
INNER JOIN GameStore.GameStoreInfo GSI ON GSI.GamePlatformId = GP.GamePlatformId
INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
INNER JOIN GameStore.Conditions C ON C.ConditionId = GSI.ConditionId
WHERE GSI.StoreId = @StoreId
AND G.Title = CASE @Title
				WHEN N'*'
				THEN
					G.Title
				ELSE
					@Title
				END
GROUP BY GSI.StoreId, GP.GameId, GSI.UnitPrice, G.Title, GSI.Quantity, C.Condition
HAVING GSI.UnitPrice >=
		CASE @MinPrice
				WHEN -1
				THEN
					MIN(GSI.UnitPrice)
				ELSE
					@MinPrice
				END
AND GSI.UnitPrice <=
		 CASE @MaxPrice
				WHEN -1
				THEN
					Max(GSI.UnitPrice)
				ELSE
					@MaxPrice
				END

GO