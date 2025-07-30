
--Query1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--Query2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice = 0

--Query3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is NULL 

--Query4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is Not NULL

--Query5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is Not NULL AND ListPrice > 0

--Query6
SELECT Name + ' ' + Color As ProductDescription 
FROM Production.Product 
WHERE Color is NOT NULL

--Query7
SELECT TOP 6 'Name:' + ' ' + Name + ' -- COLOR: ' + Color As ProductDescription 
FROM Production.Product
WHERE Color is Not Null


--Query 8
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID Between 400 AND 500


--Query9
SELECT ProductID, Name, Color
FROM Production.Product
WHERE color IN ('black','blue')

--Query10
SELECT * FROM Production.Product
WHERE Name Like 'S%'

--Query11
SELECT TOP 6 Name, ListPrice
FROM Production.Product
WHERE Name Like 'S%'
ORDER BY Name

--Query12
SELECT TOP 5 Name, ListPrice
FROM Production.Product
WHERE Name Like 'S%' OR Name Like 'A%'
ORDER BY Name

--Query13
SELECT * FROM Production.Product
WHERE Name Like 'SPO%' AND Name NOT Like 'SPOK%'
ORDer BY NAME

--Query14
SELECT DISTINCT(COLOR) 
FROM Production.Product
WHERE Color Is NOT NULL
ORDER BY color DESC
 