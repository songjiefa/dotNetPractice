SELECT SUM(Hours) FROM dbo.[Table] WHERE Name = N'张军' AND	 Date >= '05/01/2007' AND	Date <='05/31/2007'

SELECT Name,SUM(Hours) FROM dbo.[Table] GROUP BY Name

SELECT Name,SUM(Hours) FROM dbo.[Table] WHERE Date > '04/30/2007'GROUP BY Name HAVING SUM(Hours) > 16 
