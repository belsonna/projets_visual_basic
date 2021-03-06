/*
   dimanche 19 août 201210:42:07
   Utilisateur : 
   Serveur : BELONA-PC
   Base de données : LOCAL BUYING HOUSE
   Application : 
*/

/* Pour éviter les problèmes éventuels de perte de données, passez attentivement ce script en revue avant de l'exécuter en dehors du contexte du Concepteur de bases de données.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_COMMANDETEC
	(
	NumTec varchar(50) NOT NULL,
	ProfTec varchar(50) NOT NULL,
	ObjetTec varchar(255) NOT NULL,
	DateTec datetime NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.COMMANDETEC)
	 EXEC('INSERT INTO dbo.Tmp_COMMANDETEC (NumTec, ProfTec, ObjetTec, DateTec)
		SELECT NumTec, ProfTec, ObjetTec, CONVERT(datetime, DateTec) FROM dbo.COMMANDETEC WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.LIVRERF
	DROP CONSTRAINT FK_LIVRERF_COMMANDETEC
GO
ALTER TABLE dbo.FACTURERF
	DROP CONSTRAINT FK_FACTURERF_COMMANDETEC
GO
DROP TABLE dbo.COMMANDETEC
GO
EXECUTE sp_rename N'dbo.Tmp_COMMANDETEC', N'COMMANDETEC', 'OBJECT' 
GO
ALTER TABLE dbo.COMMANDETEC ADD CONSTRAINT
	PK_COMMANDE PRIMARY KEY CLUSTERED 
	(
	NumTec
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURERF ADD CONSTRAINT
	FK_FACTURERF_COMMANDETEC FOREIGN KEY
	(
	ComTecFacF
	) REFERENCES dbo.COMMANDETEC
	(
	NumTec
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.LIVRERF ADD CONSTRAINT
	FK_LIVRERF_COMMANDETEC FOREIGN KEY
	(
	ComTec
	) REFERENCES dbo.COMMANDETEC
	(
	NumTec
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.LIVRERF', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.LIVRERF', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.LIVRERF', 'Object', 'CONTROL') as Contr_Per 