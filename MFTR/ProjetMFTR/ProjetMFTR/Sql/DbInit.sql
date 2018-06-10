CREATE TABLE Intervenant (
    intervenant_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nom nvarchar(100) NOT NULL,
	actif bit Default 0
);

CREATE TABLE Suivi (
    suivi_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    dateSuivi date NOT NULL,
    moment nvarchar(150),
	remarque nvarchar(MAX),
	enfant_id int NOT NULL,
	dossier_id nvarchar(150) NOT NULL,
	intervenant_id int NOT NULL,
	Foreign Key (intervenant_id) References intervenant(intervenant_id),
	Foreign Key (enfant_id) References enfants(enfant_id),
	Foreign Key (dossier_id) References dossier(dossier_id)
);

ALTER TABLE dossier DROP CONSTRAINT [DF__Dossier__Actif__06CD04F7];

alter table dossier
alter column actif varchar(10) null



INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Alexye-Eve Gélinas',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Élisabeth Royer',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Jessica Bergeron',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Joliane Tellier',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Kassandra Lavigne',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Lysiane Deshaye',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Marika Pruneau',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Mathilde Fallu',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Nathan Grenier Gauvin',1)
INSERT INTO [dbo].[Intervenant]([nom],[actif]) VALUES('Yanni Gélinas',1)