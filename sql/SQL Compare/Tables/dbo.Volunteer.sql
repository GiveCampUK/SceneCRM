CREATE TABLE [dbo].[Volunteer]
(
[VolunteerId] [int] NOT NULL IDENTITY(1, 1),
[FirstName] [varchar] (64) COLLATE Latin1_General_CI_AI NULL,
[Surname] [varchar] (64) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Volunteer] ADD CONSTRAINT [PK_Volunteer] PRIMARY KEY CLUSTERED  ([VolunteerId]) ON [PRIMARY]
GO
