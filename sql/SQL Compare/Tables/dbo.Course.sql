CREATE TABLE [dbo].[Course]
(
[CourseId] [int] NOT NULL,
[CourseTypeCode] [varchar] (8) COLLATE Latin1_General_CI_AI NULL,
[TermId] [int] NULL,
[Year] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course] ADD CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED  ([CourseId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course] ADD CONSTRAINT [FK_Course_CourseType] FOREIGN KEY ([CourseTypeCode]) REFERENCES [dbo].[CourseType] ([CourseTypeCode])
GO
ALTER TABLE [dbo].[Course] ADD CONSTRAINT [FK_Course_Term] FOREIGN KEY ([TermId]) REFERENCES [dbo].[Term] ([TermId])
GO
