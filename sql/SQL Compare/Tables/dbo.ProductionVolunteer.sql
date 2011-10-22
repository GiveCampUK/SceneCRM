CREATE TABLE [dbo].[ProductionVolunteer]
(
[VounteerId] [int] NOT NULL,
[JobId] [int] NOT NULL,
[ProductionId] [int] NOT NULL,
[Notes] [varchar] (2048) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductionVolunteer] ADD CONSTRAINT [PK_ProductionVolunteer] PRIMARY KEY CLUSTERED  ([VounteerId], [JobId], [ProductionId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductionVolunteer] ADD CONSTRAINT [FK_ProductionVolunteer_Production] FOREIGN KEY ([ProductionId]) REFERENCES [dbo].[Production] ([ProductionId])
GO
ALTER TABLE [dbo].[ProductionVolunteer] ADD CONSTRAINT [FK_ProductionVolunteer_Volunteer] FOREIGN KEY ([VounteerId]) REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
