CREATE TABLE [dbo].[Child]
(
[ChildId] [int] NOT NULL,
[Reference] [varchar] (16) COLLATE Latin1_General_CI_AI NOT NULL,
[FirstName] [varchar] (64) COLLATE Latin1_General_CI_AI NULL,
[Surname] [varchar] (64) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Child] ADD CONSTRAINT [PK_Child] PRIMARY KEY CLUSTERED  ([ChildId]) ON [PRIMARY]
GO
