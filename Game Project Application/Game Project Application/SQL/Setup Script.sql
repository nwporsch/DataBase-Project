--Script to run to setup database

DROP TABLE IF EXISTS GameStore.OrderLines;
DROP TABLE IF EXISTS GameStore.Orders;
DROP TABLE IF EXISTS GameStore.Customers;
DROP TABLE IF EXISTS GameStore.Employees;
DROP TABLE IF EXISTS GameStore.GameGenres;
DROP TABLE IF EXISTS GameStore.GamePlatforms;
--DROP TABLE IF EXISTS GameStore.Genres;
--DROP TABLE IF EXISTS GameStore.Platforms;

DROP TABLE IF EXISTS GameStore.Games;
--DROP TABLE IF EXISTS GameStore.Stores;

--Schema
IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'GameStore'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [GameStore] AUTHORIZATION [dbo]');
END;

--Stores
IF OBJECT_ID(N'GameStore.Stores') IS NULL
BEGIN
   CREATE TABLE GameStore.Stores
   (
      StoreId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Address NVARCHAR(64) UNIQUE NOT NULL,
	  City NVARCHAR(64) NOT NULL
   );
END;

--Employees
IF OBJECT_ID(N'GameStore.Employees') IS NULL
BEGIN
   CREATE TABLE GameStore.Employees
   (
      EmployeeId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL,
   );
END;

--Genre
IF OBJECT_ID(N'GameStore.Genres') IS NULL
BEGIN
   CREATE TABLE GameStore.Genres
   (
      GenreId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  GenreName NVARCHAR(64) UNIQUE NOT NULL
   );
END;

--Platforms
IF OBJECT_ID(N'GameStore.Platforms') IS NULL
BEGIN
   CREATE TABLE GameStore.Platforms
   (
      PlatformId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  PlatformName NVARCHAR(64) UNIQUE NOT NULL
   );
END;

--Games
IF OBJECT_ID(N'GameStore.Games') IS NULL
BEGIN
   CREATE TABLE GameStore.Games
   (
      GameId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  Title NVARCHAR(64) NOT NULL,
	  UnitPrice DECIMAL(4,2) CHECK(UnitPrice > 0) NOT NULL,
	  IsUsed BIT NOT NULL,
	  Quantity INT CHECK(Quantity >= 0) NOT NULL
   );
END;

--Game Genre
IF OBJECT_ID(N'GameStore.GameGenre') IS NULL
BEGIN
   CREATE TABLE GameStore.GameGenre
   (
      GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId )NOT NULL,
	  GenreId INT FOREIGN KEY REFERENCES GameStore.Genres(GenreId) NOT NULL

	  PRIMARY KEY(GameId, GenreId)
   );
END;

--Game Platform
IF OBJECT_ID(N'GameStore.GamePlatform') IS NULL
BEGIN
   CREATE TABLE GameStore.GamePlatform
   (
      GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId) NOT NULL,
	  PlatformId INT FOREIGN KEY REFERENCES GameStore.Platforms(PlatformId) NOT NULL

	  PRIMARY KEY(GameId, PlatformId)
   );
END;

--Customers
IF OBJECT_ID(N'GameStore.Customers') IS NULL
BEGIN
   CREATE TABLE GameStore.Customers
   (
      CustomerId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  FirstName NVARCHAR(20) NOT NULL,
	  LastName NVARCHAR(20) NOT NULL,
	  Email NVARCHAR(64) UNIQUE NOT NULL,
	  Address NVARCHAR(64),
	  City NVARCHAR(64),
	  State NVARCHAR(20)
   );
END;

--Orders
IF OBJECT_ID(N'GameStore.Orders') IS NULL
BEGIN
   CREATE TABLE GameStore.Orders
   (
      OrderId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  CustomerId INT FOREIGN KEY REFERENCES GameStore.Customers(CustomerId) NOT NULL,
	  DatePlaced DATETIMEOFFSET NOT NULL
   );
END;

--OrderLines
IF OBJECT_ID(N'GameStore.OrderLines') IS NULL
BEGIN
   CREATE TABLE GameStore.OrderLines
   (
      OrderId INT FOREIGN KEY REFERENCES GameStore.Orders(OrderId )NOT NULL,
	  GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId) NOT NULL,
	  Quantity INT CHECK(Quantity >= 0) NOT NULL,
	  UnitPrice DECIMAL(4,2) CHECK(UnitPrice > 0) NOT NULL

	  PRIMARY KEY(OrderId, GameId)
   );
END;

