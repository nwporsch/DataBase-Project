IF OBJECT_ID(N'GameStore.GamePlatform') IS NULL
BEGIN
   CREATE TABLE GameStore.GamePlatform
   (
      GameId INT NOT NULL,
	  PlatformID INT NOT NULL
   );
END;