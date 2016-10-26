IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ProjectW14].[dbo].[Basket]') AND type in (N'U'))
drop table [ProjectW14].[dbo].[Basket]

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[ProjectW14].[dbo].[Items]') AND type in (N'U'))
drop table [ProjectW14].[dbo].[Items]

CREATE TABLE [ProjectW14].[dbo].[Basket] (
    [Id] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [ItemName] [varchar] (255) NOT NULL,
    [ItemPrice] DECIMAL NOT NULL
) 

CREATE TABLE [ProjectW14].[dbo].[Items] (
    [Id] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [ItemName] [varchar] (255) NOT NULL,
    [ItemPrice] DECIMAL NOT NULL
)

INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item1', 1);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item2', 1);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item3', 2);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item4', 3);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item5', 5);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item6', 8);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item7', 13);
INSERT INTO Items (ItemName, ItemPrice) VALUES ('Item8', 21);

/*
INSERT INTO Basket (ItemName, ItemPrice) VALUES ('Item1', 1);
*/