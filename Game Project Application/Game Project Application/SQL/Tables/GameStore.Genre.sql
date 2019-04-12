IF OBJECT_ID(N'GameStore.Genre') IS NULL
BEGIN
   CREATE TABLE GameStore.Genre
   (
      GenreId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  GenreName NVARCHAR(64)
   );
END;