CREATE DATABASE JOINS

USE JOINS

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName NVARCHAR(255)
);

-- Create the Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATETIME,
    TotalAmount DECIMAL(10, 2)
);

-- Insert sample data into the Customers table
INSERT INTO Customers (CustomerID, CustomerName)
VALUES
    (1, 'Customer A'),
    (2, 'Customer B'),
    (3, 'Customer C');

-- Insert sample data into the Orders table
INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES
    (101, 1, '2023-09-01', 100.00),
    (102, 2, '2023-09-02', 150.00),
    (103, 1, '2023-09-03', 75.00),
    (104, 3, '2023-09-04', 200.00),
    (105, 2, '2023-09-05', 50.00);