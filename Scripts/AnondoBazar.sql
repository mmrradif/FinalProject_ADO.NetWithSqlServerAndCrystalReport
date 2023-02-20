CREATE DATABASE AnondoBazar
Go

USE AnondoBazar
GO

CREATE TABLE tblSupplier(
	supplierId INT NOT NULL PRIMARY KEY IDENTITY,
	supplierName VARCHAR(50) NOT NULL,
	supplierAddress VARCHAR(100) NOT NULL,
	supplierPhone VARCHAR(50) NOT NULL,
	supplierRemarks VARCHAR(100) NOT NULL
)
Go

--INSERT INTO tblSupplier(supplierName,supplierAddress,supplierPhone,supplierRemarks) VALUES(@sName,@sAdd,@sPhone,@sRemarks);

SELECT * FROM tblSupplier
Go


-- ------------------------
CREATE TABLE tblAdmin(
	adminId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adminName VARCHAR(50) NOT NULL,
	adminUserName VARCHAR(100) NOT NULL,
	adminPassword VARCHAR(50) NOT NULL
)
Go

--INSERT INTO tblAdmin(adminName,adminUserName,adminPassword) VALUES(@aN,@aUN,@aP);\

SELECT * FROM tblAdmin
GO

SELECT adminId,adminName,adminUserName,adminPassword FROM tblAdmin 

SELECT adminId, adminUserName FROM tblAdmin



------------------------------ EMPLOYEE

CREATE TABLE tblEmployee(
	employeeId INT NOT NULL PRIMARY KEY IDENTITY(100,1),
	employeeName VARCHAR(50) NOT NULL,
	employeeUserName VARCHAR(100) NOT NULL,
	employeePassword VARCHAR(50) NOT NULL,
	employeJoinDate DATE NOT NULL,
	employeeMaterialStatus NVARCHAR(20) NOT NULL,
	employeeBasicSalary MONEY NOT NULL,
	employeeCreatedBy INT REFERENCES tblAdmin(adminId) NOT NULL,
	employeePhoto VARBINARY(MAX) NULL
)
Go

--INSERT INTO tblEmployee(employeeName,employeeUserName,employeePassword,employeJoinDate,employeeMaterialStatus,employeeBasicSalary,employeeCreatedBy,employeePhoto) VALUES(@eN,@eUN,@eP,@eJD,@eMS,@eBS,@eCB,@ePhoto)

SELECT * FROM tblEmployee
SELECT * FROM tblAdmin

SELECT e.employeeId, e.employeeName, e.employeeUserName, e.employeePassword, A.adminUserName as 'Created By', E.employeePhoto FROM tblEmployee e INNER JOIN tblAdmin a ON e.employeeCreatedBy = a.adminId


-- BRAND

CREATE TABLE tblBrand(
	brandId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	brandName VARCHAR(50) NOT NULL
)
Go

SELECT * FROM tblBrand

--INSERT INTO tblBrand VALUES()

SELECT * FROM tblBrand

-- CATEGORY

CREATE TABLE tblCategory(
	categoryId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	categoryName VARCHAR(50) NOT NULL
)
Go

SELECT * FROM tblBrand

--INSERT INTO tblCategory VALUES()

SELECT categoryId, categoryName FROM tblCategory


CREATE TABLE tblProducts(
	productId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	productName VARCHAR(50) NOT NULL,
	productDescription VARCHAR(100) NOT NULL,
	productQuantity int NOT NULL,
	productCreatedByAdmin INT REFERENCES tblAdmin(adminId) NOT NULL,
	productSupplier INT REFERENCES tblSupplier(supplierId) NOT NULL,
	productBrand INT REFERENCES tblBrand(brandId) NOT NULL,
	productCategory INT REFERENCES tblCategory(categoryId) NOT NULL,
)
Go



--INSERT INTO tblProducts(productName,productDescription,productQuantity,productCreatedByAdmin,productSupplier,productBrand,productCategory) VALUES(@pN,@pD,@pQ,@pA,@pS,@pB,@pC)

SELECT p.productId,p.productName,p.productDescription,p.productQuantity,a.adminUserName,s.supplierName,b.brandName,c.categoryName FROM tblProducts p INNER JOIN tblAdmin a ON p.productCreatedByAdmin=a.adminId INNER JOIN tblSupplier s ON p.productSupplier=s.supplierId INNER JOIN tblBrand b ON p.productBrand=b.brandId INNER JOIN tblCategory c ON p.productCategory=c.categoryId

SELECT productId,productName,productDescription,productQuantity,productCreatedByAdmin,productSupplier,productBrand,productCategory FROM tblProducts


-- TRANSACTION

CREATE TABLE tblcustomer(

	customerId INT PRIMARY KEY IDENTITY(100,1),
	customerName VARCHAR(50) NOT NULL,
	customerAddress VARCHAR(100) NOT NULL
)

CREATE TABLE tblBill(

	customerId INT REFERENCES tblcustomer(customerId),
	productId INT REFERENCES tblProducts(productId),
	totalTaka VARCHAR(50) NOT NULL,
	PRIMARY KEY(customerId,productId)
)

SELECT * FROM tblBill

SELECT * FROM tblcustomer

select * from tblProducts

SELECT * FROM tblEmployee WHERE employeeName='mahbur';