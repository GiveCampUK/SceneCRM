CREATE TABLE [dbo].[VolunteerCapability]
(
[VolunteerId] [int] NOT NULL,
[JobId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VolunteerCapability] ADD CONSTRAINT [PK_VolunteerCapability] PRIMARY KEY CLUSTERED  ([VolunteerId], [JobId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VolunteerCapability] ADD CONSTRAINT [FK_VolunteerCapability_Job] FOREIGN KEY ([JobId]) REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[VolunteerCapability] ADD CONSTRAINT [FK_VolunteerCapability_Volunteer] FOREIGN KEY ([VolunteerId]) REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
