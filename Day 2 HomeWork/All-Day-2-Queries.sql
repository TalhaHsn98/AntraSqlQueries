--Query 1
SELECT COUNT(*) FROM Production.Product
--Answer 504

--Query 2 
SELECT Count(*) FROM Production.product
WHERE ProductSubCategoryID is NOT null
--Answer 295

--Query 3 
SELECT ProductSubCategoryID, COUNT(*) as CountedProducts 
FROM Production.Product
GROUP BY ProductSubCategoryID
HAVING ProductSubCategoryID is NOT null
--Removed NULL as it was also counted as ID

--Query 4
SELECT Count(*) FROM Production.product
WHERE ProductSubCategoryID is null
--Ans 209

--Query 5
SELECT SUM(Quantity) as Total 
FROM Production.ProductInventory
--Ans 335974

--Query 6
SELECT ProductID,SUM(Quantity) as THESum
FROM Production.ProductInventory
WHERE Locationid = 40
GROUP BY ProductID 
Having Sum(Quantity) < 100


--Query 7
SELECT Shelf, ProductID,SUM(Quantity) as THESum
FROM Production.ProductInventory
WHERE Locationid = 40
GROUP BY ProductID, Shelf
Having Sum(Quantity) < 100

--Query 8
SELECT ProductID, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--Query 9
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--Query 10
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf


--Query 12
SELECT c.Name as Country, p.Name as Province 
FROM person.CountryRegion c
LEFT JOIN person.StateProvince p
ON p.CountryRegionCode = c.CountryRegionCode


--Query 13
SELECT c.Name as Country, p.Name as Province 
FROM person.CountryRegion c
LEFT JOIN person.StateProvince p
ON p.CountryRegionCode = c.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')


--Query 14
SELECT DISTINCT p.ProductName,p.ProductID
FROM [Order Details] OD
JOIN Products p
ON p.ProductID = OD.ProductID
JOIN Orders o
ON o.OrderID = OD.OrderID
WHERE DATEDIFF(YEAR, OrderDate, GETDATE()) < 27
--Answer No Rows in Last 27 years, NO orders in last 27 years
--Query 14, Alternate Checking last 28 years
SELECT DISTINCT p.ProductName,p.ProductID
FROM [Order Details] OD
JOIN Products p
ON p.ProductID = OD.ProductID
JOIN Orders o
ON o.OrderID = OD.OrderID
WHERE DATEDIFF(YEAR, OrderDate, GETDATE()) <= 28
--if we do 28 we get 77 rows


--Query 15
SELECT TOP 5 o.ShipPostalCode as ZipCode,SUM(od.Quantity) as TotalQuantity 
FROM Orders o
JOIN [Order Details] od 
ON o.OrderID = od.OrderID
WHERE ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY TotalQuantity DESC


--Query 16
SELECT TOP 5 o.ShipPostalCode as ZipCode,SUM(od.Quantity) as TotalQuantity 
FROM Orders o
JOIN [Order Details] od 
ON o.OrderID = od.OrderID
WHERE ShipPostalCode IS NOT NULL AND o.OrderDate >= DATEADD(YEAR, -27, GETDATE()) 
GROUP BY o.ShipPostalCode
ORDER BY TotalQuantity DESC
--Answer in the last 27 years no orders, so if we do -28 we get order atleast 
--FROM the year 1998


--Query 17
SELECT COUNT(CustomerId) AS NUMBER_OF_CUSTOMERS, city 
FROM Customers
GROUP BY city


--Query 18
SELECT COUNT(CustomerID) AS NUMBER_OF_CUSTOMERS, city 
FROM Customers
GROUP BY city
HAVING COUNT(CustomerID) > 2

--Query 19

SELECT ContactName, CompanyName, Convert(DATE, o.OrderDate) as OrderDate
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'

--Query 20

SELECT ContactName, MAX(o.OrderDate) as OrderDate
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName
ORDER BY OrderDate DESC

--Query 21

SELECT ContactName, SUM(od.quantity) as QuantityBought
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
JOIN [Order Details] od
ON o.ORDERID = od.OrderID 
GROUP BY c.ContactName
ORDER BY QuantityBought DESC


--Query 22

SELECT o.CustomerID, SUM(od.quantity) as QuantityBought
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
JOIN [Order Details] od
ON o.ORDERID = od.OrderID 
GROUP BY o.CustomerID
Having SUM(od.quantity) > 100
ORDER BY QuantityBought DESC


--Query 23
SELECT s.CompanyName AS [Supplier Company Name], 
sh.CompanyName AS [Shipping Company Name]
FROM Suppliers s
JOIN Products p
ON s.SupplierID = p.SupplierID
JOIN [Order Details] od
ON p.ProductID = od.ProductID
JOIN Orders o
ON od.OrderID = o.OrderID
JOIN Shippers sh
ON o.ShipVia = sh.ShipperID
GROUP BY s.CompanyName, sh.CompanyName
ORDER BY s.CompanyName, sh.CompanyName

--Query 24
SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od
ON o.OrderID = od.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
ORDER BY o.OrderDate, p.ProductName


--Query 25
SELECT 
e1.EmployeeID AS Employee1ID, 
e1.FirstName + ' ' + e1.LastName AS Employee1Name,
e2.EmployeeID AS Employee2ID, 
e2.FirstName + ' ' + e2.LastName AS Employee2Name,
e1.Title
FROM Employees e1
JOIN Employees e2
ON e1.Title = e2.Title 
AND e1.EmployeeID < e2.EmployeeID
ORDER BY e1.Title, e1.EmployeeID, e2.EmployeeID


--Query 26
SELECT 
e2.EmployeeID AS ManagerID, 
e2.FirstName + ' ' + e2.LastName AS ManagerName,
COUNT(e1.EmployeeID) AS ReportCount
FROM Employees e1
JOIN Employees e2
ON e1.ReportsTo = e2.EmployeeID
GROUP BY e2.EmployeeID, e2.FirstName, e2.LastName
HAVING COUNT(e1.EmployeeID) > 2
ORDER BY ReportCount DESC


--Query 27
SELECT 
City, 
CompanyName AS Name, 
ContactName, 
'Customer' AS Type
FROM Customers
WHERE City IS NOT NULL
UNION
SELECT 
City, 
CompanyName AS Name, 
ContactName, 
'Supplier' AS Type
FROM Suppliers
WHERE City IS NOT NULL
ORDER BY City, Type, Name
