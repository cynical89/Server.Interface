CREATE TABLE [dbo].[Games] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Active]      BIT              NOT NULL,
    [TimeAndDate] DATETIME         NOT NULL,
    [Map]         VARCHAR (25)     NOT NULL,
    [Player1]     VARCHAR (50)     NULL,
    [Player2]     VARCHAR (50)     NULL,
    [Player3]     VARCHAR (50)     NULL,
    [Player4]     VARCHAR (50)     NULL,
    [Player5]     VARCHAR (50)     NULL,
    [Player6]     VARCHAR (50)     NULL,
    [Player7]     VARCHAR (50)     NULL,
    [Player8]     VARCHAR (50)     NULL,
    [Player9]     VARCHAR (50)     NULL,
    [Player10]    VARCHAR (50)     NULL,
    [Player11]    VARCHAR (50)     NULL,
    [Player12]    VARCHAR (50)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
