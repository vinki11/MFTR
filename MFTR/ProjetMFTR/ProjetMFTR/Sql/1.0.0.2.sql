ALTER TABLE [dbo].[Services] DROP CONSTRAINT [SSMA_CC$Services$Frequence$validation_rule]
GO

ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [SSMA_CC$Services$Frequence$validation_rule] 
CHECK  (([Frequence]='Hebdomadaire' OR [Frequence]='Bimensuel' OR [Frequence]='Mensuel' OR [Frequence]='Sur demande'))
GO

ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [SSMA_CC$Services$Frequence$validation_rule]
GO

alter table services
alter column Frequence varchar(50)

alter table services
alter column Journee varchar(50)

alter table services
alter column Duree varchar(50)

alter table services
alter column nom varchar(50)

