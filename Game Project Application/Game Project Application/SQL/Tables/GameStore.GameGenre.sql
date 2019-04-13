IF OBJECT_ID(N'GameStore.GameGenre') IS NULL
BEGIN
   CREATE TABLE GameStore.GameGenre
   (
      GameId INT FOREIGN KEY REFERENCES GameStore.Games(GameId )NOT NULL,
	  GenreId INT FOREIGN KEY REFERENCES GameStore.Genres(GenreId) NOT NULL

	  PRIMARY KEY(GameId, GenreId)
   );
END;