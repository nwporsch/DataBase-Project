IF OBJECT_ID(N'GameStore.GameGenre') IS NULL
BEGIN
   CREATE TABLE GameStore.GameGenre
   (
      GameId INT NOT NULL,
	  GenreId INT NOT NULL
   );
END;