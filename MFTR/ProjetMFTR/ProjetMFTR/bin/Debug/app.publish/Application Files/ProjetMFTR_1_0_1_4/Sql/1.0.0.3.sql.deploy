/****** Object:  Index [Communication$Communication#Referent]    Script Date: 2018-09-11 23:00:20 ******/
DROP INDEX [Communication$Communication#Referent] ON [dbo].[Communication]
GO

SET ANSI_PADDING ON
GO

alter table Communication
alter column Referent_ID varchar(50)

/****** Object:  Index [Communication$Communication#Referent]    Script Date: 2018-09-11 23:00:20 ******/
CREATE NONCLUSTERED INDEX [Communication$Communication#Referent] ON [dbo].[Communication]
(
	[Referent_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [LienReferrent$ReferentLienReferrent]    Script Date: 2018-09-11 23:01:41 ******/
DROP INDEX [LienReferrent$ReferentLienReferrent] ON [dbo].[LienReferrent]
GO

SET ANSI_PADDING ON
GO

ALTER TABLE [dbo].[LienReferrent] DROP CONSTRAINT [LienReferrent$ReferentLienReferrent]
GO

alter table LienReferrent
alter column Referent_ID varchar(50)

ALTER TABLE [dbo].[LienReferrent]  WITH NOCHECK ADD  CONSTRAINT [LienReferrent$ReferentLienReferrent] FOREIGN KEY([Referent_ID])
REFERENCES [dbo].[Referent] ([Referent_ID])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[LienReferrent] NOCHECK CONSTRAINT [LienReferrent$ReferentLienReferrent]
GO

/****** Object:  Index [LienReferrent$ReferentLienReferrent]    Script Date: 2018-09-11 23:01:41 ******/
CREATE NONCLUSTERED INDEX [LienReferrent$ReferentLienReferrent] ON [dbo].[LienReferrent]
(
	[Referent_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


ALTER TABLE [dbo].[Referent] DROP CONSTRAINT [Referent$PrimaryKey] WITH ( ONLINE = OFF )
GO

SET ANSI_PADDING ON
GO

alter table Referent
alter column Referent_ID varchar(50) not null

/****** Object:  Index [Referent$PrimaryKey]    Script Date: 2018-09-11 23:04:55 ******/
ALTER TABLE [dbo].[Referent] ADD  CONSTRAINT [Referent$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Referent_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

update Referent
set Referent_ID = LTRIM(RTRIM(Referent_ID))

update Communication
set Referent_ID = LTRIM(RTRIM(Referent_ID))

update LienReferrent
set Referent_ID = LTRIM(RTRIM(Referent_ID))