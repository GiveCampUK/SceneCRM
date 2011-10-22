CREATE TABLE [dbo].[CourseVolunteer]
(
[CourseId] [int] NOT NULL,
[VolunteerId] [int] NOT NULL,
[JobId] [int] NOT NULL,
[Notes] [varchar] (2048) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseVolunteer] ADD CONSTRAINT [PK_CourseVolunteer] PRIMARY KEY CLUSTERED  ([CourseId], [VolunteerId], [JobId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseVolunteer] ADD CONSTRAINT [FK_CourseVolunteer_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[CourseVolunteer] ADD CONSTRAINT [FK_CourseVolunteer_Job] FOREIGN KEY ([JobId]) REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[CourseVolunteer] ADD CONSTRAINT [FK_CourseVolunteer_Volunteer] FOREIGN KEY ([VolunteerId]) REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
