/*
   vendredi 24 août 201215:42:55
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
ALTER TABLE dbo.FACTURERTEC
	DROP CONSTRAINT [FK_FACTURERTEC_COMMANDE COTCO]
GO
COMMIT
select Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COMMANDECOTCO', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURERTEC
	DROP CONSTRAINT FK_FACTURERTEC_PRODUIT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.FACTURERTEC
	DROP CONSTRAINT FK_FACTURERTEC_CLIENT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CLIENT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CLIENT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CLIENT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_FACTURERTEC
	(
	POFacT varchar(50) NOT NULL,
	NumFacT varchar(50) NOT NULL,
	CliFacT varchar(50) NOT NULL,
	DateFacT datetime NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.FACTURERTEC)
	 EXEC('INSERT INTO dbo.Tmp_FACTURERTEC (POFacT, NumFacT, CliFacT, DateFacT)
		SELECT POFacT, NumFacT, CliFacT, DateFacT FROM dbo.FACTURERTEC WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.FACTURERTEC
GO
EXECUTE sp_rename N'dbo.Tmp_FACTURERTEC', N'FACTURERTEC', 'OBJECT' 
GO
ALTER TABLE dbo.FACTURERTEC ADD CONSTRAINT
	PK_FACTURERTEC_1 PRIMARY KEY CLUSTERED 
	(
	POFacT,
	NumFacT,
	CliFacT
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.FACTURERTEC ADD CONSTRAINT
	FK_FACTURERTEC_CLIENT FOREIGN KEY
	(
	CliFacT
	) REFERENCES dbo.CLIENT
	(
	NomCli
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FACTURERTEC ADD CONSTRAINT
	[FK_FACTURERTEC_COMMANDE COTCO] FOREIGN KEY
	(
	POFacT
	) REFERENCES dbo.COMMANDECOTCO
	(
	NumPO
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FACTURERTEC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FACTURERTEC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FACTURERTEC', 'Object', 'CONTROL') as Contr_Per 