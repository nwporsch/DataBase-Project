IF OBJECT_ID(N'GameStore.Games') IS NULL
BEGIN
   CREATE TABLE GameStore.Games
   (
      GameId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  StoreId INT NOT NULL,
	  Title NVARCHAR(64) NOT NULL,
	  UnitPrice INT NOT NULL,
	  IsUsed BIT NOT NULL,
	  Quantity INT NOT NULL
   );
END;