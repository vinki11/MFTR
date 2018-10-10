CREATE TABLE Options (
    IdOptions int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Path varchar(500),
	ParentPrefix varchar(500),
	KidsPrefix varchar(500)
);


INSERT INTO [dbo].[Options]
           ([Path],ParentPrefix,KidsPrefix)
     VALUES
           (null,null,null)