IF OBJECT_ID(N'GameStore.Platform') IS NULL
BEGIN
   CREATE TABLE GameStore.Platform
   (
      PlatformId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  PlatformName NVARCHAR(64)
   );
END;