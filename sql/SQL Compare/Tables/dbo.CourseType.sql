CREATE TABLE [dbo].[CourseType]
(
[CourseTypeCode] [varchar] (8) COLLATE Latin1_General_CI_AI NOT NULL,
[CourseTypeName] [varchar] (64) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseType] ADD CONSTRAINT [PK_CourseType] PRIMARY KEY CLUSTERED  ([CourseTypeCode]) ON [PRIMARY]
GO
