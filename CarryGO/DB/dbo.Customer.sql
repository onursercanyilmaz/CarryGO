CREATE TABLE [dbo].[Customer]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [CustomerName] NVARCHAR(50) NOT NULL, 
    [CustomerLastName] NVARCHAR(50) NOT NULL, 
    [CustomerPhone] DECIMAL NOT NULL, 
    [CustomerAddress] TEXT NOT NULL, 
    [CustomerEmail] NVARCHAR(50) NOT NULL, 
    [CustomerGender] INT NOT NULL, 
    CONSTRAINT [FK_Gender_Customer] FOREIGN KEY ([Customer]) REFERENCES [Gender]([GenderID])
)
