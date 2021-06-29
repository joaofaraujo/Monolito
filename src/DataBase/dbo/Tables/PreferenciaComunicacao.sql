CREATE TABLE [dbo].[PreferenciaComunicacao] (
    [Id]        BIGINT   IDENTITY (1, 1) NOT NULL,
    [IdCliente] BIGINT   NOT NULL,
    [Canal]     SMALLINT NOT NULL,
    CONSTRAINT [PK_PreferenciaComunicacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PreferenciaComunicacao_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id])
);

