IF OBJECT_ID(N'GameStore.Platforms') IS NULL
BEGIN
   CREATE TABLE GameStore.Platforms
   (
      PlatformId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  PlatformName NVARCHAR(64) UNIQUE NOT NULL
   );
END;