# Example 2

## About <a name = "about"></a>

Database structure containing 4 tables, created from entities to ddl commands and verified with diagrams in Oracle SQL Developer

## Functions

The command that shows the current state of the warehouse:
```sql
SELECT Components.component_name, 
COALESCE(SUM(Deliveries.delivery_quantity), 0) - COALESCE(SUM(Issues.issue_quantity), 0) AS stock_quantity
FROM Components
LEFT JOIN Deliveries ON Components.component_id = Deliveries.component_id
LEFT JOIN Issues ON Components.component_id = Issues.component_id
GROUP BY Components.component_name ORDER BY stock_quantity DESC;
```
Result:

<img src="https://github.com/PKrystian/Bus_App/blob/senior/Example_2/task1.PNG"/>

A command that shows from which 3 suppliers we most often have deliveries:
```sql
SELECT Suppliers.supplier_name, COUNT(Deliveries.delivery_id) AS delivery_count
FROM Suppliers
INNER JOIN Deliveries ON Suppliers.supplier_id = Deliveries.supplier_id
GROUP BY Suppliers.supplier_name
ORDER BY delivery_count DESC
LIMIT 3;
```
Result:

<img src="https://github.com/PKrystian/Bus_App/blob/senior/Example_2/task2.PNG"/>

## Preview of DB

Logicial view of database:

<img src="https://github.com/PKrystian/Bus_App/blob/senior/Example_2/Logical.png"/>

After that DDL commands were done:
```sql
CREATE TABLE Suppliers (
  supplier_id INT not null CONSTRAINT pk_supp PRIMARY KEY,
  supplier_name VARCHAR(255) NOT null,
  contact_info VARCHAR(255) NOT null
);

CREATE TABLE Components (
  component_id INT not null CONSTRAINT pk_comp PRIMARY KEY,
  component_name VARCHAR(255) NOT null
);

CREATE TABLE Deliveries (
  delivery_id INT not null CONSTRAINT pk_deli PRIMARY KEY,
  delivery_date DATE NOT null,
  supplier_id INT NOT null CONSTRAINT fk_supp_deli references Suppliers(supplier_id),
  delivery_quantity NUMERIC(11) NOT null check(delivery_quantity >= 0),
  component_id INT NOT null CONSTRAINT fk_comp references Components(component_id)
);

CREATE TABLE Issues (
  issue_id INT not null CONSTRAINT pk_iss PRIMARY KEY,
  issue_date DATE NOT null,
  component_id INT NOT null CONSTRAINT fk_comp_iss references Components(component_id),
  issue_quantity NUMERIC(11) NOT null check(issue_quantity >= 0)
);
```

Relational view of database:

<img src="https://github.com/PKrystian/Bus_App/blob/senior/Example_2/Relational.png"/>

Inserting sample data:
```sql
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
```

## Built Using <a name = "built_using"></a>

<p align="left"> <a href="https://www.microsoft.com/en-us/sql-server" target="_blank" rel="noreferrer"> <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" alt="mssql" width="160" height="160"/> </a> <a href="https://www.oracle.com/" target="_blank" rel="noreferrer"><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/oracle/oracle-original.svg" alt="oracle" width="160" height="160"/> </a> </p>
