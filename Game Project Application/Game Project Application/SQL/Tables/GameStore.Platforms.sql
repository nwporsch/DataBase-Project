IF OBJECT_ID(N'GameStore.Platform') IS NULL
BEGIN
   CREATE TABLE GameStore.Platform
   (
      PlatformId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  PlatformName NVARCHAR(64) UNIQUE NOT NULL
   );
END;