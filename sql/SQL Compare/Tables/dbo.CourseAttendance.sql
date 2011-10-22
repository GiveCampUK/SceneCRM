CREATE TABLE [dbo].[CourseAttendance]
(
[ChildId] [int] NOT NULL,
[CourseId] [int] NOT NULL,
[Completed] [bit] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseAttendance] ADD CONSTRAINT [PK_CourseAttendance] PRIMARY KEY CLUSTERED  ([ChildId], [CourseId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CourseAttendance] ADD CONSTRAINT [FK_CourseAttendance_Child] FOREIGN KEY ([ChildId]) REFERENCES [dbo].[Child] ([ChildId]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CourseAttendance] ADD CONSTRAINT [FK_CourseAttendance_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]) ON DELETE CASCADE ON UPDATE CASCADE
GO
