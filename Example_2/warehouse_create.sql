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