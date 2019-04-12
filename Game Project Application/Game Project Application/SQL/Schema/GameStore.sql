IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'GameStore'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [GameStore] AUTHORIZATION [dbo]');
END;
