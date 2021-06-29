CREATE TABLE [dbo].[Tracking] (
    [Id]             BIGINT           IDENTITY (1, 1) NOT NULL,
    [IdDisparo]      UNIQUEIDENTIFIER NOT NULL,
    [IdCliente]      BIGINT           NOT NULL,
    [Disparo]        INT              NOT NULL,
    [CanalDisparado] INT              NOT NULL,
    [DataDisparo]    DATETIME2 (7)    NOT NULL,
    CONSTRAINT [PK_Tracking] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tracking_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id])
);

