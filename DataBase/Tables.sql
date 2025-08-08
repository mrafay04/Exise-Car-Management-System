use CarDB;

CREATE TABLE Owners (
    OwnerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    CNIC NVARCHAR(20) NOT NULL,
    Contact NVARCHAR(20) NOT NULL
);
select *from Owners

CREATE TABLE Vehicle (
    VehicleID INT PRIMARY KEY IDENTITY,
    VehicleNumber VARCHAR(20),
    VehicleType VARCHAR(50),
    ModelYear INT,
    EngineNumber VARCHAR(50),
    ChassisNumber VARCHAR(50),
    Color VARCHAR(50),
    OwnerName VARCHAR(100),
    CNIC VARCHAR(20)
);