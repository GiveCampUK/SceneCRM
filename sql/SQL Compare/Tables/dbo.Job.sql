CREATE TABLE [dbo].[Job]
(
[JobId] [int] NOT NULL IDENTITY(1, 1),
[Description] [varchar] (64) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Job] ADD CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED  ([JobId]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Defines the various roles - director, dramaturge, box office, etc - filled by volunteers', 'SCHEMA', N'dbo', 'TABLE', N'Job', NULL, NULL
GO
