IF OBJECT_ID ( 'dbo.UpdateReferentId', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.UpdateReferentId;  
GO  

CREATE PROCEDURE dbo.UpdateReferentId
  @OldId varchar(150),
  @NewID varchar(150)
AS   
  
  DECLARE @OldIdTemp varchar(150),
		  @NewIDTemp varchar(150)
  
  SELECT @OldIdTemp = @OldId,
		 @NewIDTemp = @NewID

  -- Phase 1 Referent
  UPDATE Referent
  SET Referent_Id = @NewIDTemp
  FROM Dossier 
  WHERE Referent_Id = @OldIdTemp

  -- Phase 2 Enfants
  UPDATE Enfants
  SET Referent_Id = @NewIDTemp
  FROM Enfants 
  WHERE Referent_Id = @OldIdTemp

  -- Phase 3 Communications
  UPDATE Communication
  SET Referent_Id = @NewIDTemp
  FROM Communication 
  WHERE Referent_Id = @OldIdTemp

  -- Phase 4 LienReferrent
  UPDATE LienReferrent
  SET Referent_Id = @NewIDTemp
  FROM LienReferrent
  WHERE Referent_Id = @OldIdTemp
GO  



IF OBJECT_ID ( 'dbo.UpdateCommunicationFolderID', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.UpdateCommunicationFolderID;  
GO  

CREATE PROCEDURE dbo.UpdateCommunicationFolderID
  @OldId varchar(150),
  @NewID varchar(150)
AS   
  
  DECLARE @OldIdTemp varchar(150),
		  @NewIDTemp varchar(150)
  
  SELECT @OldIdTemp = @OldId,
		 @NewIDTemp = @NewID

  -- Phase 1 Communications
  UPDATE Communication
  SET Dossier_ID = @NewIDTemp
  FROM Communication 
  WHERE Dossier_ID = @OldIdTemp

GO  