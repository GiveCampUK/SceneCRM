CREATE TABLE [dbo].[Production]
(
[ProductionId] [int] NOT NULL IDENTITY(1, 1),
[Title] [varchar] (64) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Production] ADD CONSTRAINT [PK_Production] PRIMARY KEY CLUSTERED  ([ProductionId]) ON [PRIMARY]
GO
