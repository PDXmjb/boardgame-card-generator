CREATE TABLE [dbo].[Owner]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OwnerName] NVARCHAR(100) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

CREATE TABLE [dbo].[Game]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GameName] NVARCHAR(100) NOT NULL,
	[OwnerId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Game_Owner] FOREIGN KEY ([OwnerId]) REFERENCES [Owner]([Id])
)
GO

CREATE TABLE [dbo].[Deck]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DeckName] NVARCHAR(100) NOT NULL,
	[GameId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Deck_Game] FOREIGN KEY ([GameId]) REFERENCES [Game]([Id])
)
GO

CREATE TABLE [dbo].[Card]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[DeckId] INT NOT NULL,
	[BackgroundImage] NVARCHAR(300),
	[BackgroundColor] NVARCHAR(300),
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Card_Deck] FOREIGN KEY ([DeckId]) REFERENCES [Deck]([Id])
)
GO

CREATE TABLE [dbo].[LabelPosition]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Name] VARCHAR(20) NOT NULL
)
GO

CREATE TABLE [dbo].[CardLabel]
(
	[Id] INT NOT NULL PRIMARY KEY, 
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

