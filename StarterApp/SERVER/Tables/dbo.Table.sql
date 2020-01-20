CREATE TABLE [dbo].Cards
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Card Name] NCHAR(30) NULL, 
    [Region] NCHAR(15) NULL, 
    [Mana Cost] INT NULL, 
    [Card Type] CHAR(8) NULL, 
    [Card Rarity] CHAR(8) NULL, 
    [Card Description] NVARCHAR(MAX) NULL
)
