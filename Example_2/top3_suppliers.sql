SELECT Suppliers.supplier_name, COUNT(Deliveries.delivery_id) AS delivery_count
FROM Suppliers
INNER JOIN Deliveries ON Suppliers.supplier_id = Deliveries.supplier_id
GROUP BY Suppliers.supplier_name
ORDER BY delivery_count DESC
LIMIT 3;