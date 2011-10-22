CREATE TABLE [dbo].[Play]
(
[PlayId] [int] NOT NULL IDENTITY(1, 1),
[ChildId] [int] NOT NULL,
[Title] [varchar] (128) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Play] ADD CONSTRAINT [PK_Play] PRIMARY KEY CLUSTERED  ([PlayId]) ON [PRIMARY]
GO
