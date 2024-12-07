CREATE TABLE Users
(
    userid        INT IDENTITY (1,1),
    user_login    VARCHAR(50) NOT NULL,
    user_password VARCHAR(50) NOT NULL,
    is_admin      BIT         NOT NULL
);
GO
INSERT INTO Users (user_login, user_password, is_admin)
VALUES ('admin', 'admin', 1)
INSERT INTO Users (user_login, user_password, is_admin)
VALUES ('agent', 'agent', 0)
GO

ALTER TABLE Agencies
    ADD is_active BIT NOT NULL DEFAULT 1;

ALTER TABLE Agents
    ADD is_active BIT NOT NULL DEFAULT 1;


-- Nov 13
alter table Suppliers add 
is_active bit default 1
go
UPDATE Suppliers
SET is_active = 1;

-- Nov 14

alter table Packages_Products_Suppliers add 
is_active bit default 1
go
UPDATE Packages_Products_Suppliers
SET is_active = 1;

--Nov 20

UPDATE Packages_Products_Suppliers
SET is_active = 1;

-- Nov 19
alter table Products add 
is_active bit default 1

UPDATE Products
SET is_active = 1;
alter table Packages add 
is_active bit default 1
go
UPDATE Packages
SET is_active = 1;

ALTER TABLE Customers
ADD Prefs VARCHAR(20);
GO

ALTER TABLE Customers
ADD ProfileImg VARCHAR(20);
GO
-- Rename the Users table : 
sp_rename 'Users','App_Users';


