CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmployeeGender] INT NOT NULL, 
    [EmployeeEmail] NVARCHAR(50) NOT NULL, 
    [EmployeePassword] INT NOT NULL, 
    [EmployeeAddress] TEXT NOT NULL, 
    [EmployeePhone] INT NOT NULL, 
    [DepartmentID] INT NOT NULL
)
