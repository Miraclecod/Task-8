SELECT Products.Name, Categore.Name 
	FROM Products
	LEFT OUTER JOIN Categore
	ON Products.id = Categore.Products_id 
	
	