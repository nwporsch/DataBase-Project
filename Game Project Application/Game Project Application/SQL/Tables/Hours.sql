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