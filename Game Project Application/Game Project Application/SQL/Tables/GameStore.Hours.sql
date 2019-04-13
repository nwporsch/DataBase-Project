IF OBJECT_ID(N'GameStore.Hours') IS NULL
BEGIN
   CREATE TABLE GameStore.Hours
   (
      HourId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  StoreId INT FOREIGN KEY REFERENCES GameStore.Stores(StoreId) NOT NULL,
	  Day NVARCHAR(10) NOT NULL,
	  StartTime DATETIMEOFFSET NOT NULL,
	  EndTime DATETIMEOFFSET NOT NULL
   );
END;
--Not sure how we want to represent hours for a store. Might be a m-m relationship