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