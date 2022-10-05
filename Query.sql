SELECT *, row_number() over(ORDER BY p.Id) as row_num FROM Имя_продукта as p
LEFT JOIN  Имя_категории as cat on cat.Id = p.categoryId;