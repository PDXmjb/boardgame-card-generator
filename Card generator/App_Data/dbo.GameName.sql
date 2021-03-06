﻿CREATE TABLE [dbo].[Owner]
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

CREATE TABLE [dbo].[CardLabel]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[CardId] INT NOT NULL,
	[Row] INT NOT NULL,
	[Column] INT NOT NULL,
	[BackgroundImage] NVARCHAR(300),
	[BackgroundColor] NVARCHAR(300),
	[AdditionalCSS] NVARCHAR(500),
	[Label] NVARCHAR(200),
	PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_CardLabel_Card] FOREIGN KEY ([CardId]) REFERENCES [Card]([Id]),
)
GO


INSERT INTO [Owner] (OwnerName) 
VALUES ('Mike Brooks');

INSERT INTO Game (GameName, OwnerId) 
VALUES ('CrusaderCards', 1);

INSERT INTO Deck (DeckName, GameId) 
VALUES ('Deck1', 1);

INSERT INTO [Card] (DeckId, BackgroundImage, BackgroundColor) 
VALUES (1, 'https://i.imgur.com/nYhlAzc.jpg', '#555');

INSERT INTO CardLabel (CardId, [Row], [Column], [BackgroundImage], [BackgroundColor], [AdditionalCSS], Label) 
VALUES (1, 1, 1, null, 'purple', 'border: 1px solid black; border-radius:40px;', '1VP');
INSERT INTO CardLabel (CardId, [Row], [Column], [BackgroundImage], [BackgroundColor], [AdditionalCSS], Label) 
VALUES (1, 1, 2, null, null, 'font-size: 50px', 'Knight');
INSERT INTO CardLabel (CardId, [Row], [Column], [BackgroundImage], [BackgroundColor], [AdditionalCSS], Label) 
VALUES (1, 2, 2, 'https://i.imgur.com/NYF2Ki7.jpg', null, 'border: 1px solid black; border-radius:40px;', null);
