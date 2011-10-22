CREATE TABLE [dbo].[PlayVolunteer]
(
[PlayId] [int] NOT NULL,
[VolunteerId] [int] NOT NULL,
[JobId] [int] NOT NULL,
[Notes] [varchar] (2048) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PlayVolunteer] ADD CONSTRAINT [PK_PlayVolunteer] PRIMARY KEY CLUSTERED  ([PlayId], [VolunteerId], [JobId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PlayVolunteer] ADD CONSTRAINT [FK_PlayVolunteer_Job] FOREIGN KEY ([JobId]) REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[PlayVolunteer] ADD CONSTRAINT [FK_PlayVolunteer_Play] FOREIGN KEY ([PlayId]) REFERENCES [dbo].[Play] ([PlayId]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PlayVolunteer] ADD CONSTRAINT [FK_PlayVolunteer_Volunteer] FOREIGN KEY ([VolunteerId]) REFERENCES [dbo].[Volunteer] ([VolunteerId]) ON DELETE CASCADE ON UPDATE CASCADE
GO
