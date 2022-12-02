SELECT prod.Name,cat.Name FROM Product prod
LEFT JOIN Enrollment en ON prod.Id = en.ProductId
LEFT JOIN Category cat ON cat.Id = en.CategoryId
ORDER BY prod.Name;