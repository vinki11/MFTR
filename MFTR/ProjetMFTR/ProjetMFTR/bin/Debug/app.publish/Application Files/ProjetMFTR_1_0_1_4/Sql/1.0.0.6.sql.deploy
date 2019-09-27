IF OBJECT_ID ( 'dbo.UpdateFolderIds', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.UpdateFolderIds;  
GO  

CREATE PROCEDURE dbo.UpdateFolderIds
  @OldId varchar(150),
  @NewID varchar(150)
AS   
  
  DECLARE @OldIdTemp varchar(150),
		  @NewIDTemp varchar(150)
  
  SELECT @OldIdTemp = @OldId,
		 @NewIDTemp = @NewID

  -- Phase 1 Dossier
  UPDATE Dossier
  SET Dossier_ID = @NewIDTemp
  FROM Dossier 
  WHERE Dossier_ID = @OldIdTemp

  -- Phase 2 Adultes
  UPDATE Adultes
  SET Dossier_ID = @NewIDTemp
  FROM Adultes 
  WHERE Dossier_ID = @OldIdTemp

  -- Phase 3 Enfants
  UPDATE Enfants
  SET Dossier_ID = @NewIDTemp
  FROM Enfants 
  WHERE Dossier_ID = @OldIdTemp

  -- Phase 4 Communications
  UPDATE Communication
  SET Dossier_ID = @NewIDTemp
  FROM Communication 
  WHERE Dossier_ID = @OldIdTemp

  -- Phase 5 Services
  UPDATE [Services]
  SET Dossier_ID = @NewIDTemp
  FROM [Services]
  WHERE Dossier_ID = @OldIdTemp
GO  


/****** Object:  Index [Dossier$#Dossier]    Script Date: 2019-07-24 19:41:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Dossier_DossierID] ON [dbo].[Dossier]
(
	[Dossier_ID] ASC,
	[Referent_Id] ASC
)INCLUDE(Ouverture) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

/****** Object:  Index [Adultes$Dossier2Adultes]    Script Date: 2019-07-24 19:45:09 ******/
CREATE NONCLUSTERED INDEX [Adultes_Dossier_Includes] ON [dbo].[Adultes]
(
	[Adulte_ID] ASC,
	[Dossier_ID] ASC
)INCLUDE(Nom,Prenom,Courriel,Note) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [Suivi_Dossier] ON [dbo].[Suivi]
(
	[suivi_id] ASC,
	[dossier_id] ASC,
	[dateSuivi] ASC
)INCLUDE(enfant_id, intervenant_id) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [Referent_Adultes] ON [dbo].[Referent]
(
	[Referent_ID] ASC,
	[Adulte_ID] ASC
)INCLUDE(Nom) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [Parent_Adulte_Includes] ON [dbo].[Parent]
(
	[Parent_ID] ASC,
	[Adulte_ID] ASC
)INCLUDE(Statut,Sexe,Naissance,Photo) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [Enfants_Dossier_Includes] ON [dbo].[Enfants]
(
	[Enfant_ID] ASC,
	[Dossier_ID] ASC,
	[Naissance] ASC
)INCLUDE(Nom,Prenom,Sexe,Notes,Referent_Id,Photo) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO