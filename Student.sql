CREATE TABLE [dbo].[Student]
(
	[ssn] NCHAR(10) NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(10) NULL, 
    [fname] NVARCHAR(10) NULL, 
    [Religion] NCHAR(10) NULL, 
    [shenasname] NCHAR(10) NULL, 
    [address] NCHAR(50) NULL, 
    [email] NCHAR(20) NULL, 
    [postalcode] NCHAR(10) NULL, 
    [Bdate] DATE NULL, 
    [phone] NCHAR(10) NULL, 
    [pastPoint] FLOAT NULL, 
    [picture] NVARCHAR(60) NULL, 
    [classNo.] INT NULL, 
    [shomarepaye] INT NULL
)
