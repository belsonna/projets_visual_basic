/*
   lundi 20 août 201214:29:57
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
ALTER TABLE dbo.LIVRERTEC
	DROP CONSTRAINT [FK_LIVRERTEC_COMMANDE COTCO]
GO
COMMIT
select Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.LIVRERTEC
	DROP CONSTRAINT FK_LIVRERTEC_PRODUIT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_LIVRERTEC
	(
	POLiv varchar(50) NOT NULL,
	ProPOLivT varchar(50) NOT NULL,
	NumLivT varchar(50) NOT NULL,
	QteLivT real NOT NULL,
	PULivT real NOT NULL,
	MtanLivT  AS QteLivT*PULivT,
	DateLivT datetime NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.LIVRERTEC)
	 EXEC('INSERT INTO dbo.Tmp_LIVRERTEC (POLiv, ProPOLivT, NumLivT, QteLivT, PULivT, DateLivT)
		SELECT POLiv, ProPOLivT, NumLivT, QteLivT, PULivT, DateLivT FROM dbo.LIVRERTEC WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.LIVRERTEC
GO
EXECUTE sp_rename N'dbo.Tmp_LIVRERTEC', N'LIVRERTEC', 'OBJECT' 
GO
ALTER TABLE dbo.LIVRERTEC ADD CONSTRAINT
	PK_LIVRERTEC PRIMARY KEY CLUSTERED 
	(
	POLiv,
	ProPOLivT,
	NumLivT
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.LIVRERTEC ADD CONSTRAINT
	FK_LIVRERTEC_PRODUIT FOREIGN KEY
	(
	ProPOLivT
	) REFERENCES dbo.PRODUIT
	(
	NomPro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.LIVRERTEC ADD CONSTRAINT
	[FK_LIVRERTEC_COMMANDE COTCO] FOREIGN KEY
	(
	POLiv
	) REFERENCES dbo.COMMANDECOTCO
	(
	NumPO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.LIVRERTEC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.LIVRERTEC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.LIVRERTEC', 'Object', 'CONTROL') as Contr_Per 