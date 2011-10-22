CREATE TABLE [dbo].[CrbCheck]
(
[CrbCheckId] [int] NOT NULL IDENTITY(1, 1),
[VolunteerId] [int] NULL,
[CheckDate] [datetime] NULL,
[CrbNumber] [varchar] (32) COLLATE Latin1_General_CI_AI NULL,
[OnlineFormSent] [datetime] NULL,
[FormFilledOut] [datetime] NULL,
[DateCheckExpires] [datetime] NULL,
[IdComplete] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CrbCheck] ADD CONSTRAINT [PK_CrbCheck] PRIMARY KEY CLUSTERED  ([CrbCheckId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CrbCheck] ADD CONSTRAINT [FK_CrbCheck_Volunteer] FOREIGN KEY ([VolunteerId]) REFERENCES [dbo].[Volunteer] ([VolunteerId]) ON DELETE CASCADE ON UPDATE CASCADE
GO
