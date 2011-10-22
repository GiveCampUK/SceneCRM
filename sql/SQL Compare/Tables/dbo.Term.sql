CREATE TABLE [dbo].[Term]
(
[TermId] [int] NOT NULL,
[TermName] [varchar] (16) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Term] ADD CONSTRAINT [PK_Term] PRIMARY KEY CLUSTERED  ([TermId]) ON [PRIMARY]
GO
