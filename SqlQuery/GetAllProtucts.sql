SELECT 
p.ProductName, c.CategotyName
FROM
Products p
LEFT JOIN 
Product_Category conPC
ON p.id = conPC.productID
LEFT JOIN  Categorys c
ON conPC.categorysID  = c.id