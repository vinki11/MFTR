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
  --EXEC('UPDATE Dossier
  --SET Dossier_ID = '''+@NewIDTemp+'''
  --FROM Dossier 
  --WHERE Dossier_ID = '''+@OldIdTemp+'''')

    UPDATE Dossier
  SET Dossier_ID = @NewIDTemp
  FROM Dossier
  WHERE Dossier_ID = @OldIdTemp

  UPDATE [Suivi]
  SET Dossier_ID = @NewIDTemp
  FROM [Suivi]
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
