CREATE VIEW vwEverything (Category,Continent,Country,EventName,EventDate) AS	
SELECT TOP (459) CategoryName, ContinentName, CountryName, EventName, EventDate
FROM tblCategory, tblEvent, tblCountry,tblContinent
ORDER BY NEWID();

SELECT COUNT(EventName) AS EventCount, Category
FROM vwEverything
WHERE Continent = 'Africa'
GROUP BY Category
ORDER BY COUNT(EventName) DESC;

SELECT * FROM vwEverything

DROP VIEW vwEverything
