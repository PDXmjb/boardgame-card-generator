SELECT * FROM [Owner]

INSERT INTO [Owner] (OwnerName) VALUES ('Mike') GO
INSERT INTO [Game] (GameName, OwnerId) VALUES ('CrusaderCards', 1) GO
INSERT INTO [Deck] (DeckName, GameId) VALUES ('AllCards', 1) GO


CREATE TABLE [dbo].[Owner]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [OwnerName] NVARCHAR(100) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

CREATE TABLE [dbo].[Game]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [GameName] NVARCHAR(100) NOT NULL,
	[OwnerId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Game_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [Owner]([Id])
)
GO

CREATE TABLE [dbo].[Deck]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [DeckName] NVARCHAR(100) NOT NULL,
	[GameId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Deck_Game] FOREIGN KEY ([GameId]) REFERENCES [Game]([Id])
)
GO

CREATE TABLE [dbo].[Card]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[DeckId] INT NOT NULL,
	[BackgroundImage] NVARCHAR(300),
	[BackgroundColor] NVARCHAR(300),
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Card_Deck] FOREIGN KEY ([DeckId]) REFERENCES [Deck]([Id])
)
GO

CREATE TABLE [dbo].[LabelPosition]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[Name] VARCHAR(20) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

CREATE TABLE [dbo].[CardLabel]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[CardId] INT NOT NULL,
	[LabelPositionId] INT NOT NULL,
	[BackgroundImage] NVARCHAR(300),
	[BackgroundColor] NVARCHAR(300),
	[AdditionalCSS] NVARCHAR(500),
	[Label] NVARCHAR(200),
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_CardLabel_Card] FOREIGN KEY ([CardId]) REFERENCES [Card]([Id]),
	CONSTRAINT [FK_CardLabel_LabelPosition] FOREIGN KEY ([LabelPositionId]) REFERENCES [LabelPosition]([Id])
)
GO

