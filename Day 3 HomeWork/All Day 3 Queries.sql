--Query 1
SELECT DISTINCT city FROM Employees
WHERE city IN 
(
SELECT city FROM customers
)


----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 2
--Using Sub Query
SELECT DISTINCT city FROM customers
WHERE city NOT IN
(
SELECT city FROM Employees
)

--NOT using Sub Query
SELECT DISTINCT e.city, c.City FROM customers c
LEFT JOIN employees e
ON e.City = c.City
WHERE e.city is NULL


----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 3
SELECT p.ProductName,p.ProductID, SUM(Quantity) As ToralQuantities
FROM [Order Details] od
JOIN Products p
ON od.ProductID = p.ProductID
GROUP by p.ProductName, p.ProductID
ORDER BY ProductID 

----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 4
--for total quantity of products ordered
SELECT c.City, SUM(od.Quantity) AS total_quant_of_Products
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
JOIn [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY c.City
Order BY total_quant_of_Products DESC
--Query 4
--for different number of total products ordered
SELECT c.City, COUNT(DISTINCT od.ProductID) AS number_oF_Different_products
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
JOIn [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY c.City
Order BY number_oF_Different_products DESC


----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 5

SELECT City, COUNT(CustomerID) AS Numb_customers 
FROM customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2


----------------------------------------------------------------------
----------------------------------------------------------------------

--query 6

SELECT c.City, COUNT(DISTINCT od.ProductID) AS number_oF_Different_products
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
JOIn [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductId) >= 2
Order BY number_oF_Different_products DESC



----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 7


SELECT DISTINCT(o.CustomerID), c.CompanyName, c.City,o.ShipCity
FROM ORDERS o
JOIN Customers c
ON c.CustomerID = o.CustomerID
WHERE o.ShipCity != c.City



----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 8

SELECT 
p.ProductName,
AVG(od.UnitPrice) AS AvgPrice,
c.City AS TopCustomerCity,
SUM(od.Quantity) AS TotalOrdered
FROM [Order Details] od
JOIN Products p
ON od.ProductID = p.ProductID
JOIN Orders o
ON od.OrderID = o.OrderID
JOIN Customers c
ON o.CustomerID = c.CustomerID
WHERE od.ProductID IN (
SELECT TOP 5 od.ProductID
FROM [Order Details] od
GROUP BY od.ProductID
ORDER BY SUM(od.Quantity) DESC
)
GROUP BY p.ProductName, p.ProductID, c.City
HAVING SUM(od.Quantity) = (
SELECT MAX(SumQty)
FROM (
SELECT SUM(od2.Quantity) AS SumQty
FROM [Order Details] od2
JOIN Orders o2 ON od2.OrderID = o2.OrderID
JOIN Customers c2 ON o2.CustomerID = c2.CustomerID
WHERE od2.ProductID = p.ProductID
GROUP BY c2.City
) AS CitySums
)
ORDER BY TotalOrdered DESC




----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 9

--Using Sub Query
SELECT e.City
FROM Employees e
WHERE e.City NOT IN (
SELECT DISTINCT o.ShipCity
FROM orders o
 )


--NOT using SubQuery
SELECT e.city
FROM Employees e
LEFT JOIN orders o
ON o.ShipCity = e.City
WHERE o.shipcity is NULL
 
----------------------------------------------------------------------
----------------------------------------------------------------------

--Query 10

SELECT empCity.City
FROM (
SELECT TOP 1 e.City, COUNT(*) AS OrderCount
FROM Orders o
JOIN Employees e ON o.EmployeeID = e.EmployeeID
GROUP BY e.City
ORDER BY OrderCount DESC
) AS empCity
JOIN 
(
SELECT TOP 1 o.ShipCity AS City, SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.ShipCity
ORDER BY TotalQuantity DESC
) AS shipCity
ON empCity.City = shipCity.City





----------------------------------------------------------------------
----------------------------------------------------------------------


--Query 11

--Scenario 1 (if there exists a unique key)
--To remove a duplicate row first of all we have to check if there exists
--a unique key. If suppose there is a unique key and we have duplicate rows
--then we can take the MIN or MAX of the id and group by the other columns.
--We can delete wehre the id is not in the sub query For Example:

DELETE FROM Customers
WHERE CustomerID NOT IN 
(
SELECT min(CustomerID)
FROM Customers
GROUP BY CompanyNameName, City
)


--Scenarion 2 (If there is no unique key)
--IN this approach what we can do is if we dont have a unique key 
--then we can use partition by and row number to add a row number
--then we can delete the duplicate row numbers using cte. for example:


WITH CTE AS (
SELECT *,
ROW_NUMBER() OVER (PARTITION BY CompanyName, city) AS rn
FROM Customers
)
DELETE FROM CTE
WHERE rn > 1;