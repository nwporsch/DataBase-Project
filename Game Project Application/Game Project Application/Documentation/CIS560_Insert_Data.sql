INSERT INTO GameStore.Genres(GenreName)
VALUES('Action/Adventure'),
	('Platformer'),
	('First Person Shooter'),
	('Puzzle'),
	('Sports'),
	('Fighting')
GO

INSERT INTO GameStore.Platforms(PlatformName)
VALUES('Nintendo Switch'),
	('Playstation 3'),
	('Playstation 4'),
	('Xbox 360'),
	('Xbox One'),
	('PC')
GO

INSERT INTO GameStore.Stores(Address, City, State)
VALUES	('100 Bluemont Ave F', 'Manhattan', 'Kansas'),
		('810 Commons Pl', 'Manhattan', 'Kansas')

GO

INSERT INTO GameStore.Employees(StoreId, Name)
VALUES (1,'Jonah Myers'),(1,'Kalia Wilson'),(1,'Christine Thomas'),(1,'Sybil Cook'),(1,'Fuller Valdez'),(2,'August Lane'),(2,'Norman Ferrell'),(2,'Hop Carver'),(2,'Teegan White'),(2,'Charlie Day')

INSERT INTO GameStore.Customers(Name, Email, Address, City, State)
VALUES	('Joe Johnson', 'JJJohnson@yahoo.com', '123 Main st', 'Punxsutawney', 'Pennsylvania')

INSERT INTO GameStore.Conditions(Condition, Description)
VALUES (0,'New'), (1,'Used')

INSERT INTO GameStore.Games(GenreId, Title) (
SELECT GenreId, Title
FROM (
	VALUES 
		('Action/Adventure','Dark Souls'),
		('Fighting', 'Super Smash Bros Ultimate'),
		('First Person Shooter', 'DOOM'),
		('Puzzle','Tetris Effect'),
		('Sports','Madden 19'),
		('Platformer','Super Mario Odyssey')
	) V (GenreName, Title)
	INNER JOIN GameStore.Genres G ON G.GenreName = V.GenreName
)
GO

INSERT INTO GameStore.GamePlatform(GameId, PlatformId) (
SELECT GameId, PlatformId
FROM (
	VALUES 
		('Super Mario Odyssey', 'Nintendo Switch'),
		('Super Smash Bros Ultimate', 'Nintendo Switch'),
		('Tetris Effect', 'Playstation 4'),
		('DOOM', 'Playstation 4'),
		('DOOM', 'Xbox One'),
		('DOOM', 'PC'),
		('DOOM', 'Nintendo Switch'),
		('Dark Souls','Playstation 3'),
		('Dark Souls','Playstation 4'),
		('Dark Souls','Xbox 360'),
		('Dark Souls','Xbox One'),
		('Dark Souls','PC'),
		('Dark Souls','Nintendo Switch'),
		('Madden 19','Playstation 4'),
		('Madden 19','Xbox One'),
		('Madden 19','PC')
	) V (Title, PlatformName)
	INNER JOIN GameStore.Games G ON G.Title = V.Title
	INNER JOIN GameStore.Platforms P ON P.PlatformName = V.PlatformName
)

INSERT INTO GameStore.GameStoreInfo(StoreId, GamePlatformId, ConditionId, UnitPrice, Quantity) (
SELECT StoreId, GamePlatformId, ConditionId, UnitPrice, Quantity
FROM (
	VALUES 
		((SELECT GP.GameId, GP.PlatformId
		FROM GameStore.GamePlatform GP
		INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
		INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
		WHERE G.Title = 'Super Smash Bros Ultimate' AND P.PlatformName = 'Nintendo Switch'),
		(SELECT GP.PlatformId
		FROM GameStore.GamePlatform GP
		INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
		INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
		WHERE G.Title = 'Super Smash Bros Ultimate' AND P.PlatformName = 'Nintendo Switch'),
		'100 Bluemont Ave F','Manhattan','Kansas','New',59.99,12)
	) V (GameId, PlatformId, Address, City, State, Description, UnitPrice, Quantity)
	INNER JOIN GameStore.GamePlatform GP ON GP.GameId = V.GameId AND GP.PlatformId = V.PlatformId
	INNER JOIN GameStore.Stores S ON S.Address = V.Address AND S.City = V.City AND S.State = V.State
	INNER JOIN GameStore.Conditions C ON C.Description = V.Description
)
GO

select GP.GamePlatformId, G.Title, P.PlatformName
from GameStore.GamePlatform GP
INNER JOIN GameStore.Games G on GP.GameId = G.GameId
INNER JOIN GameStore.Platforms P on GP.PlatformId = P.PlatformId 

select G.Title, Ge.GenreName
from GameStore.Games G
Inner JOIN GameStore.Genres Ge on Ge.GenreId = g.GenreId

SELECT G.Title, P.PlatformName, S.Address, S.City, S.State, C.Description
FROM GameStore.GameStoreInfo GSI
INNER JOIN GameStore.GamePlatform GP ON GP.GamePlatformId = GSI.GamePlatformId
INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
INNER JOIN GameStore.Stores S ON S.StoreId = GSI.StoreId
INNER JOIN GameStore.Conditions C ON C.ConditionId = GSI.ConditionId
