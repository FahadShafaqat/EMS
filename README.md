# EMS
 A System for Employee Management for small Businesses

 This System can do Functionalities like:
 1) Add Employee
 2) Delete Employee
 3) Update Employee

SQL: 
CREATE DATABASE Employee_Management;

DROP TABLE Employees;
CREATE TABLE Employees(

	EmployeeID			VARCHAR(20) PRIMARY KEY,
	Employee_Name		VARCHAR(40),
	Employee_Position	VARCHAR(40),
	Employee_Salary		Decimal(20,2)
);

SELECT * FROM Employees;
