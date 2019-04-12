IF OBJECT_ID(N'GameStore.Stores') IS NULL
BEGIN
   CREATE TABLE GameStore.Stores
   (
      StoreId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  Address NVARCHAR(64) NOT NULL,
	  City NVARCHAR(64) NOT NULL
   );
END;

/**************************
Unique constraints
***************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'GameStore.Stores')
         AND kc.[name] = N'UK_GameStore_Stores_Address'
   )
BEGIN
   ALTER TABLE Person.AddressType
   ADD CONSTRAINT [UK_GameStore_Stores_Address] UNIQUE NONCLUSTERED
   (
      [Address], [City]
   )
END;
