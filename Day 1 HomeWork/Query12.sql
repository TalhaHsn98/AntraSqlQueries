SELECT TOP 5 Name, ListPrice
FROM Production.Product
WHERE Name Like 'S%' OR Name Like 'A%'
ORDER BY Name