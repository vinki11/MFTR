/****** Object:  Index [IX_Communication_Dossier_Adulte]    Script Date: 2019-10-29 19:05:34 ******/
CREATE NONCLUSTERED INDEX [IX_Communication_Dossier_Adulte] ON [dbo].[Communication]
(
	[Dossier_ID] ASC,
	[Adulte_ID] ASC
)
INCLUDE ( 	[DateEven],
	[DateComm],
	[Heure],
	[Motif],
	[Interlocuteur],
	[Note]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


