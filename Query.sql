SELECT * FROM Имя_продукта as p
LEFT JOIN  Имя_категории as cat on cat.Id = p.categoryId;