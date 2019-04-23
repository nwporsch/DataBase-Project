CREATE OR ALTER PROCEDURE GameStore.RetrieveOrders
@OrderId INT,
@First NVARCHAR(20),
@Last NVARCHAR(20),
@Email NVARCHAR(64)

AS

SELECT O.OrderId, C.FirstName, C.LastName, C.Email, SUM(OL.Quantity) AS Count, SUM(OL.Quantity * OL.UnitPrice) AS Total
FROM GameStore.Orders O
INNER JOIN GameStore.Customers C ON C.CustomerId = O.CustomerId
INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
GROUP BY O.OrderId, C.CustomerId, C.FirstName, C.LastName, C.Email
ORDER BY C.CustomerId ASC, O.OrderId ASC, C.LastName ASC, C.FirstName ASC
GO



--CREATE OR ALTER PROCEDURE GameStore.RetrieveOrders
--@OrderId INT,
--@First NVARCHAR(20),
--@Last NVARCHAR(20),
--@Email NVARCHAR(64)

--AS

--SELECT O.OrderId, C.FirstName, C.LastName, C.Email, SUM(OL.Quantity) AS Count, SUM(OL.Quantity * OL.UnitPrice) AS Total
--FROM GameStore.Orders O
--INNER JOIN GameStore.Customers C ON C.CustomerId = O.CustomerId
--INNER JOIN GameStore.OrderLines OL ON OL.OrderId = O.OrderId
--WHERE O.OrderId = @OrderId AND
--LOWER(C.FirstName) = CASE @First
--				WHEN N'*'
--				THEN
--					C.FirstName
--				ELSE
--					@First
--				END
--AND LOWER(C.LastName) = CASE @Last
--				WHEN N'*'
--				THEN
--					C.LastName
--				ELSE
--					@Last
--				END
--AND LOWER(C.Email) = CASE @Email
--				WHEN N'*'
--				THEN
--					C.Email
--				ELSE
--					@Email
--				END
--GROUP BY O.OrderId, C.CustomerId, C.FirstName, C.LastName, C.Email
--ORDER BY C.CustomerId ASC, O.OrderId ASC, C.LastName ASC, C.FirstName ASC



--SELECT *
--FROM GameStore.OrderLines