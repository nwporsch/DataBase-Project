IF OBJECT_ID(N'GameStore.GamePlatform') IS NULL
BEGIN
   CREATE TABLE GameStore.GamePlatform
   (
      GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId) NOT NULL,
	  PlatformId INT FOREIGN KEY REFERENCES GameStore.Platforms(PlatformId) NOT NULL

	  PRIMARY KEY(GameId, PlatformId)
   );
END;