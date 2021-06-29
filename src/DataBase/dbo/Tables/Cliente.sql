CREATE TABLE [dbo].[Cliente] (
    [Id]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [Nome]    VARCHAR (300) NOT NULL,
    [Email]   VARCHAR (300) NOT NULL,
    [Celular] VARCHAR (20)  NOT NULL,
    [CPF]     VARCHAR (11)  NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Id] ASC)
);

