INSERT INTO GameStore.Genres(GenreName)
VALUES('Action/Adventure'),
	('Platformer'),
	('First Person Shooter'),
	('Puzzle'),
	('Sports'),
	('Fighting'),
	('RPG'),
	('Simulation'),
	('Strategy'),
	('Horror')
GO

INSERT INTO GameStore.Platforms(PlatformName)
VALUES('Nintendo Switch'),
	('Playstation 3'),
	('Playstation 4'),
	('Xbox 360'),
	('Xbox One'),
	('PC'),
	('3DS'),
	('WiiU'),
	('Wii'),
	('Other')
GO

INSERT INTO GameStore.Stores(Address, City, State)
VALUES	('100 Bluemont Ave F', 'Manhattan', 'Kansas'),
		('810 Commons Pl', 'Manhattan', 'Kansas'),
		('5 Florence Place', 'Syracuse', 'New York'),
		('36019 Fairfield Alley', 'Savannah', 'Georgia'),
		('1 Algoma Street', 'Saint Paul', 'Minnesota'),
		('5 Scott Junction', 'Syracuse', 'New York'),
		('398 Everett Drive', 'Sacramento', 'California'),
		('82176 Becker Way', 'Houston', 'Texas'),
		('38355 Elgar Court', 'Charlotte', 'North Carolina'),
		('851 Atwood Way', 'New York City', 'New York'),
		('35510 Crowley Junction', 'Winston Salem', 'North Carolina'),
		('5 Clarendon Street', 'Fairfield', 'Connecticut'),
		('82260 Wayridge Alley', 'San Jose', 'California'),
		('73 Raven Junction', 'Fort Worth', 'Texas'),
		('7761 Carberry Parkway', 'Minneapolis', 'Minnesota')
GO
Select * from GameStore.Stores order by StoreId

INSERT INTO GameStore.Employees(StoreId, FirstName, LastName)
 VALUES	(1, 'Peri', 'Wones'),
		(2, 'Loralie', 'Daniaud'),
		(3, 'Susette', 'Spellicy'),
		(4, 'Kakalina', 'Shoreson'),
		(5, 'Kev', 'McCardle'),
		(6, 'Kassia', 'Thornally'),
		(1, 'Deva', 'Knagges'),
		(2, 'Nikolas', 'Jozwiak'),
		(3, 'Huntley', 'Fforde'),
		(4, 'Brittan', 'Jaggi'),
		(5, 'Cordelia', 'Grandin'),
		(6, 'Reamonn', 'Martina')
GO

INSERT INTO GameStore.Customers(FirstName, LastName, Email, Address, City, State)
VALUES	('Joe','Johnson', 'JJJohnson@yahoo.com', '123 Main st', 'Punxsutawney', 'Pennsylvania'),
		('Margaret','Miller', 'MMiller@gmail.com', '15346 S Circle', 'Steamboat', 'Colorado'),
		('Jullian','Thompson', 'JThompson@gmail.com', '736 Midland Ave', 'Manhattan', 'Kansas'),
		('Wayne','Richards', 'WRichards@sbcglobal.net', '1203 Anderson Ave', 'Buffalo', 'New York'),
		('Erika','Williams', 'EWilliams@wans.net', '1294 Massachusetts St', 'Lawrence', 'Kansas')
GO

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
		('Platformer','Super Mario Odyssey'),
		('Horror','Resident Evil 2'),
		('RPG','Kingdom Hearts 3'),
		('Simulation','Stardew Valley'),
		('Action/Adventure','Devil May Cry 5'),
		('Action/Adventure','Sekiro: Shadows Die Twice'),
		('Fighting','Mortal Kombat 11'),
		('First Person Shooter','Far Cry New Dawn'),
		('Platformer','Yoshi''s Crafted World'),
		('Action/Adventure','Anthem')
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
		('Madden 19','PC'),
		('Resident Evil 2','Xbox One'),
		('Resident Evil 2','Playstation 4'),
		('Resident Evil 2','PC'),
		('Kingdom Hearts 3','Xbox One'),
		('Kingdom Hearts 3','Playstation 4'),
		('Stardew Valley','PC'),
		('Stardew Valley','Nintendo Switch'),
		('Stardew Valley','Playstation 4'),
		('Stardew Valley','Xbox One'),
		('Devil May Cry 5','PC'),
		('Devil May Cry 5','Xbox One'),
		('Devil May Cry 5','Playstation 4'),
		('Sekiro: Shadows Die Twice','PC'),
		('Sekiro: Shadows Die Twice','Xbox One'),
		('Sekiro: Shadows Die Twice','Playstation 4'),
		('Mortal Kombat 11','PC'),
		('Mortal Kombat 11','Xbox One'),
		('Mortal Kombat 11','Playstation 4'),
		('Mortal Kombat 11','Nintendo Switch'),
		('Far Cry New Dawn','PC'),
		('Far Cry New Dawn','Xbox One'),
		('Far Cry New Dawn','Playstation 4'),
		('Yoshi''s Crafted World','Nintendo Switch'),
		('Anthem','PC'),
		('Anthem','Xbox One'),
		('Anthem','Playstation 4')
	) V (Title, PlatformName)
	INNER JOIN GameStore.Games G ON G.Title = V.Title
	INNER JOIN GameStore.Platforms P ON P.PlatformName = V.PlatformName
)
select * from GameStore.Stores Order by StoreId
--Variables to add new product to a store based on title & platform, location, condition, price, and quantity
DECLARE 
	@Title NVARCHAR(64)		= 'Anthem',
	@Platform NVARCHAR(30)	= 'Playstation 4',
	@Address NVARCHAR(64)	= '810 Commons Pl',
	@City NVARCHAR(30)		= 'Manhattan',
	@State NVARCHAR(20)		= 'Kansas',
	@Condition NVARCHAR(10)	= 'New',
	@Price Decimal(4,2)		= 59.99,
	@Quantity INT			= 10

INSERT INTO GameStore.GameStoreInfo(StoreId, GamePlatformId, ConditionId, UnitPrice, Quantity) (
SELECT StoreId, GamePlatformId, ConditionId, UnitPrice, Quantity
FROM (
	VALUES 
		((SELECT GP.GameId
		FROM GameStore.GamePlatform GP
		INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
		INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
		WHERE G.Title = @Title AND P.PlatformName = @Platform),
		(SELECT GP.PlatformId
		FROM GameStore.GamePlatform GP
		INNER JOIN GameStore.Games G ON G.GameId = GP.GameId
		INNER JOIN GameStore.Platforms P ON P.PlatformId = GP.PlatformId
		WHERE G.Title = @Title AND P.PlatformName = @Platform),
		@Address, @City, @State, @Condition, @Price, @Quantity)
	) V (GameId, PlatformId, Address, City, State, Description, UnitPrice, Quantity)
	INNER JOIN GameStore.GamePlatform GP ON GP.GameId = V.GameId AND GP.PlatformId = V.PlatformId
	INNER JOIN GameStore.Stores S ON S.Address = V.Address AND S.City = V.City AND S.State = V.State
	INNER JOIN GameStore.Conditions C ON C.Description = V.Description
)
GO

INSERT INTO GameStore.Hours(StoreId, StartingTime, EndingTime, Description)
VALUES	(1,'7:00:00','20:00:00','Monday to Friday Hours'),
		(1,'9:00:00','20:00:00','Weekend Hours'),
		(2,'7:00:00','20:00:00','Monday to Friday Hours'),
		(2,'9:00:00','20:00:00','Weekend Hours'),
		(3,'6:00:00','22:00:00','Monday to Friday Hours'),
		(3,'8:00:00','20:00:00','Weekend Hours'),
		(4, '3:49:19', '22:53:03', 'Monday to Friday Hours'),
		(5, '1:17:34', '20:32:04', 'Monday to Friday Hours'),
		(6, '11:11:33', '23:24:06', 'Monday to Friday Hours'),
		(4, '5:48:04', '16:29:25', 'Weekend Hours'),
		(5, '1:37:28', '21:07:57', 'Weekend Hours'),
		(6, '3:01:52', '23:26:20', 'Weekend Hours')
GO

select * from  GameStore.Orders
select * from GameStore.Customers

INSERT INTO GameStore.Orders(CustomerId, DatePlaced)
VALUES	(1,'2017-01-03'),
		(1,'2017-02-03'),
		(1,'2017-03-03'),
		(1,'2017-04-03'),
		(1,'2017-05-03'),
		(1,'2017-06-03'),
		(1,'2017-07-03'),
		(1,'2017-08-03'),
		(1,'2017-09-03'),
		(1,'2017-10-03'),
		(1,'2017-11-03'),
		(1,'2017-12-03'),
		(1,'2017-01-22'),
		(1,'2017-02-22'),
		(1,'2017-03-22'),
		(1,'2017-04-22'),
		(1,'2017-05-22'),
		(1,'2017-06-22'),
		(1,'2017-07-22'),
		(1,'2017-08-22'),
		(1,'2017-09-22'),
		(1,'2017-10-22'),
		(1,'2017-11-22'),
		(1,'2017-12-22'),
		(1,'2018-01-03'),
		(1,'2018-02-03'),
		(1,'2018-03-03'),
		(1,'2018-04-03'),
		(1,'2018-05-03'),
		(1,'2018-06-03'),
		(1,'2018-07-03'),
		(1,'2018-08-03'),
		(1,'2018-09-03'),
		(1,'2018-10-03'),
		(1,'2018-11-03'),
		(1,'2018-12-03'),
		(1,'2018-01-22'),
		(1,'2018-02-22'),
		(1,'2018-03-22'),
		(1,'2018-04-22'),
		(1,'2018-05-22'),
		(1,'2018-06-22'),
		(1,'2018-07-22'),
		(1,'2018-08-22'),
		(1,'2018-09-22'),
		(1,'2018-10-22'),
		(1,'2018-11-22'),
		(1,'2018-12-22')
GO