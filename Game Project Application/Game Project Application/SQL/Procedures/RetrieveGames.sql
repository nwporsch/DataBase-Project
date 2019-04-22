CREATE OR ALTER PROCEDURE GameStore.RetrieveGames
@Title NVARCHAR(128),
@Genre NVARCHAR(128),
@Platform NVARCHAR(128),
@MinPrice DECIMAL(4,2),
@MaxPrice DECIMAL(4,2),
@StoreId INT,
@IsUsed NVARCHAR(128)


AS

SELECT GP.GameId, GSI.StoreId, G.Title, GSI.UnitPrice, GSI.Quantity, C.Condition, GE.GenreName, P.PlatformName
FROM GameStore.GamePlatform GP
INNER JOIN GameStore.GameStoreInfo GSI ON GSI.GamePlatformId = GP.GamePlatformId
INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
INNER JOIN GameStore.Conditions C ON C.ConditionId = GSI.ConditionId
INNER JOIN GameStore.Genres GE ON GE.GenreId = G.GenreId
INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
WHERE GSI.StoreId = @StoreId
AND LOWER(G.Title) = CASE @Title
				WHEN N'*'
				THEN
					G.Title
				ELSE
					@Title
				END
AND LOWER(GE.GenreName) = CASE @Genre
				WHEN N'*'
				THEN
					GE.GenreName
				ELSE
					@Genre
				END
AND LOWER(C.Description) = CASE @IsUsed
				WHEN N'*'
				THEN
					C.Description
				ELSE
					@IsUsed
				END
AND LOWER(P.PlatformName) = CASE @Platform
				WHEN N'*'
				THEN
					P.PlatformName
				ELSE
					@Platform
				END
GROUP BY GSI.StoreId, GP.GameId, GSI.UnitPrice, G.Title, GSI.Quantity, C.Condition, GE.GenreName, P.PlatformName
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