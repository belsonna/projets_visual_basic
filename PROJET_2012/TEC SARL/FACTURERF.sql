/*
   vendredi 24 août 201215:49:57
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
ALTER TABLE dbo.FACTURERF
	DROP CONSTRAINT FK_FACTURERF_COMMANDETEC
GO
COMMIT
select Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURERF
	DROP CONSTRAINT FK_FACTURERF_PRODUIT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURERF
	DROP CONSTRAINT FK_FACTURERF_PERSONNEL
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_FACTURERF
	(
	NumFacF varchar(50) NOT NULL,
	ComTecFacF varchar(50) NOT NULL,
	PersoFacF varchar(50) NOT NULL,
	DateFacF datetime NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.FACTURERF)
	 EXEC('INSERT INTO dbo.Tmp_FACTURERF (NumFacF, ComTecFacF, PersoFacF)
		SELECT NumFacF, ComTecFacF, PersoFacF FROM dbo.FACTURERF WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.FACTURERF
GO
EXECUTE sp_rename N'dbo.Tmp_FACTURERF', N'FACTURERF', 'OBJECT' 
GO
ALTER TABLE dbo.FACTURERF ADD CONSTRAINT
	PK_FACTURERF_1 PRIMARY KEY CLUSTERED 
	(
	NumFacF,
	ComTecFacF,
	PersoFacF
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FACTURERF ADD CONSTRAINT
	FK_FACTURERF_PERSONNEL FOREIGN KEY
	(
	PersoFacF
	) REFERENCES dbo.PERSONNEL
	(
	NumPer
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
select Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FACTURERF', 'Object', 'CONTROL') as Contr_Per 