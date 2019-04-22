IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'GameStore'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [GameStore] AUTHORIZATION [dbo]');
END;

IF OBJECT_ID(N'GameStore.Platforms') IS NULL
BEGIN
   CREATE TABLE GameStore.Platforms
   (
      PlatformId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  PlatformName NVARCHAR(64) UNIQUE NOT NULL
   );
END;

IF OBJECT_ID(N'GameStore.Genres') IS NULL
BEGIN
   CREATE TABLE GameStore.Genres
   (
      GenreId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  GenreName NVARCHAR(64) UNIQUE NOT NULL
   );
END;


IF OBJECT_ID(N'GameStore.Stores') IS NULL
BEGIN
   CREATE TABLE GameStore.Stores
   (
      StoreId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Address NVARCHAR(64) UNIQUE NOT NULL,
	  City NVARCHAR(64) NOT NULL,
	  State NVARCHAR(20) NOT NULL

	  UNIQUE(Address, City, State)
   );
END;

IF OBJECT_ID(N'GameStore.Customers') IS NULL
BEGIN
   CREATE TABLE GameStore.Customers
   (
      CustomerId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  FirstName NVARCHAR(30) NOT NULL,
	  LastName NVARCHAR(30) NOT NULL,
	  Email NVARCHAR(64) UNIQUE NOT NULL,
	  Address NVARCHAR(64),
	  City NVARCHAR(64),
	  State NVARCHAR(20)
   );
END;

IF OBJECT_ID(N'GameStore.Games') IS NULL
BEGIN
   CREATE TABLE GameStore.Games
   (
      GameId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Title NVARCHAR(64) NOT NULL,
	  GenreId INT FOREIGN KEY REFERENCES GameStore.Genres(GenreId) NOT NULL

	  UNIQUE(Title)
   );
END;


IF OBJECT_ID(N'GameStore.GamePlatform') IS NULL
BEGIN
   CREATE TABLE GameStore.GamePlatform
   (	
	  GamePlatformId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId) NOT NULL,
	  PlatformId INT FOREIGN KEY REFERENCES GameStore.Platforms(PlatformId) NOT NULL

	  UNIQUE(GameId, PlatformId)
   );
END;

IF OBJECT_ID(N'GameStore.Conditions') IS NULL
BEGIN
   CREATE TABLE GameStore.Conditions
   (
      ConditionId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Condition BIT UNIQUE,
	  Description NVARCHAR(10) UNIQUE NOT NULL
   );
END;

IF OBJECT_ID(N'GameStore.GameStoreInfo') IS NULL
BEGIN
   CREATE TABLE GameStore.GameStoreInfo
   (	
	  GameStoreInfoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  GamePlatformId INT FOREIGN KEY REFERENCES GameStore.GamePlatform(GamePlatformId) NOT NULL,
	  ConditionId INT FOREIGN KEY REFERENCES GameStore.Conditions(ConditionId)NOT NULL,
	  UnitPrice DECIMAL(4,2) NOT NULL,
	  Quantity INT NOT NULL

	  UNIQUE(StoreId, GamePlatformId, ConditionId)
   );
END;

IF OBJECT_ID(N'GameStore.Orders') IS NULL
BEGIN
   CREATE TABLE GameStore.Orders
   (
      OrderId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  CustomerId INT FOREIGN KEY REFERENCES GameStore.Customers(CustomerId) NOT NULL,
	  DatePlaced DATETIMEOFFSET NOT NULL
   );
END;

IF OBJECT_ID(N'GameStore.OrderLines') IS NULL
BEGIN
   CREATE TABLE GameStore.OrderLines
   (
      OrderLineId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  OrderId INT FOREIGN KEY REFERENCES GameStore.Orders(OrderId)NOT NULL,
	  GameStoreInfoId INT FOREIGN KEY REFERENCES GameStore.GameStoreInfo(GameStoreInfoId) NOT NULL,
	  Quantity INT CHECK(Quantity >= 0) NOT NULL,
	  UnitPrice DECIMAL(4,2) CHECK(UnitPrice > 0) NOT NULL
   );
END;

IF OBJECT_ID(N'GameStore.Employees') IS NULL
BEGIN
   CREATE TABLE GameStore.Employees
   (
      EmployeeId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL

	  UNIQUE(StoreId, FirstName, LastName)
   );
END;

IF OBJECT_ID(N'GameStore.Hours') IS NULL
BEGIN
   CREATE TABLE GameStore.Hours
   (
      HoursId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  StartingTime TIME NOT NULL,
	  EndingTime TIME NOT NULL,
	  Description NVARCHAR(64) NOT NULL,

	  CHECK(StartingTime < EndingTime),
	  UNIQUE(StoreId, StartingTime, EndingTime)
   );
END;