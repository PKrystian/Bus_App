SELECT Components.component_name, 
COALESCE(SUM(Deliveries.delivery_quantity), 0) - COALESCE(SUM(Issues.issue_quantity), 0) AS stock_quantity
FROM Components
LEFT JOIN Deliveries ON Components.component_id = Deliveries.component_id
LEFT JOIN Issues ON Components.component_id = Issues.component_id
GROUP BY Components.component_name ORDER BY stock_quantity DESC;