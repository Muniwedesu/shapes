-- Никогда не использовал T-SQL, но запрос написал бы так.

SELECT product.product_id, category_id 
FROM product LEFT JOIN product_category
    ON product.product_id = product_category.product_id;