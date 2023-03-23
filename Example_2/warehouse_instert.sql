INSERT INTO Suppliers (supplier_id, supplier_name, contact_info) VALUES
(1, 'ABC Company', 'abc@example.com'),
(2, 'XYZ Industries', 'xyz@example.com'),
(3, 'QQQ Corporation', 'qqq@example.com'),
(4, 'ZZZ Corporation', 'zzz@example.com');

INSERT INTO Components (component_id, component_name) VALUES
(1, 'Thing A'),
(2, 'Thing B'),
(3, 'Thing C'),
(4, 'Thing D');

INSERT INTO Deliveries (delivery_id, delivery_date, supplier_id, delivery_quantity, component_id) VALUES
(1, '2022-01-01', 1, 100, 1),
(2, '2022-01-02', 2, 50, 2),
(3, '2022-01-03', 3, 75, 1),
(4, '2022-01-04', 4, 200, 3),
(5, '2022-01-03', 1, 100, 2),
(6, '2022-01-04', 1, 100, 3);

INSERT INTO Issues (issue_id, issue_date, component_id, issue_quantity) VALUES 
(1, '2022-02-01', 1, 10),
(2, '2022-02-02', 2, 5),
(3, '2022-02-03', 1, 20),
(4, '2022-02-04', 3, 15);