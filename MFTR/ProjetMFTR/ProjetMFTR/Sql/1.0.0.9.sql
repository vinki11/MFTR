--ALTER TABLE Intervenant ADD Username varchar(255) NULL
--ALTER TABLE Intervenant ADD [Password] varchar(255) NULL

--GO


--CREATE TABLE Payments (
--    IDPayments int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--    DatePayment datetime NOT NULL,
--    Carrier nvarchar(120),
--	[Service] varchar(50),
--	IDKid int NOT NULL,
--	IDFolder nvarchar(150) NOT NULL,
--	IDParent int NOT NULL,
--	Amount decimal (18,4) NOT NULL,
--	IDIntervenant int NOT NULL,
--	Foreign Key (IDParent) References parent(Parent_id),
--	Foreign Key (IDKid) References enfants(enfant_id),
--	Foreign Key (IDFolder) References dossier(dossier_id),
--	Foreign Key (IDIntervenant) References Intervenant(intervenant_id)
--);

--GO


--CREATE NONCLUSTERED INDEX [IX_Payments_IDFolder_DatePayment] ON [dbo].[Payments]
--(
--	[IDFolder] ASC,
--	[DatePayment] ASC
--)
--INCLUDE ( 	[Carrier],
--	[Service],
--	[Amount],
--	[IDIntervenant]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--GO





--CREATE TABLE AuthentificationLog (
--    IDAuth int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--    DateAuth datetime NOT NULL,
--    UserAttempt varchar(120),
--	PassAttempt varchar(120),
--	SessionID varchar(80)
--);

--GO


--/****** Object:  Index [Dossier_DossierID]    Script Date: 2019-11-24 16:00:07 ******/
--DROP INDEX [Dossier_DossierID] ON [dbo].[Dossier]
--GO

--SET ANSI_PADDING ON
--GO

--/****** Object:  Index [Dossier_DossierID]    Script Date: 2019-11-24 16:00:07 ******/
--CREATE UNIQUE NONCLUSTERED INDEX [Dossier_DossierID] ON [dbo].[Dossier]
--(
--	[Dossier_ID] ASC,
--	[Ouverture] DESC,
--	[Referent_ID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--GO

