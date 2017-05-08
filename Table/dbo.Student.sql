CREATE TABLE [dbo].[Student] (
    [Ssn] INT NOT NULL,
    [name] NVARCHAR(10) NULL, 
    [fname] NVARCHAR(20) NULL, 
    [shenasname] NCHAR(10) NULL, 
    [address] NVARCHAR(50) NULL, 
    [religion] NVARCHAR(10) NULL, 
    [emial] NVARCHAR(20) NULL, 
    [postalCode] NCHAR(10) NULL, 
    [phone] NCHAR(10) NULL, 
    [classNo] INT NULL, 
    [pastPoint] FLOAT NULL, 
    [picture] NVARCHAR(50) NULL, 
    [fatherName] NCHAR(10) NULL, 
    [bdate] DATE NULL, 
    [payeTahsili] INT NULL, 
    PRIMARY KEY CLUSTERED ([Ssn] ASC)
);

