/*
   lundi 20 août 201214:28:42
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
ALTER TABLE dbo.LIVRERF
	DROP CONSTRAINT FK_LIVRERF_COMMANDETEC
GO
COMMIT
select Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COMMANDETEC', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.LIVRERF
	DROP CONSTRAINT FK_LIVRERF_PRODUIT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LIVRERF
	(
	ComTec varchar(50) NOT NULL,
	ProLiv varchar(50) NOT NULL,
	NumLivF varchar(50) NOT NULL,
	QteLiv real NOT NULL,
	PULiv real NOT NULL,
	MtanLiv  AS QteLiv*PULiv
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.LIVRERF)
	 EXEC('INSERT INTO dbo.Tmp_LIVRERF (ComTec, ProLiv, NumLivF, QteLiv, PULiv)
		SELECT ComTec, ProLiv, NumLivF, QteLiv, PULiv FROM dbo.LIVRERF WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LIVRERF
GO
EXECUTE sp_rename N'dbo.Tmp_LIVRERF', N'LIVRERF', 'OBJECT' 
GO
ALTER TABLE dbo.LIVRERF ADD CONSTRAINT
	PK_LIVRERF_1 PRIMARY KEY CLUSTERED 
	(
	ComTec,
	ProLiv,
	NumLivF
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LIVRERF ADD CONSTRAINT
	FK_LIVRERF_PRODUIT FOREIGN KEY
	(
	ProLiv
	) REFERENCES dbo.PRODUIT
	(
	NomPro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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