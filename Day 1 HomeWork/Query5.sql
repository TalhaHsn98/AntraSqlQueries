SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is Not NULL AND ListPrice > 0