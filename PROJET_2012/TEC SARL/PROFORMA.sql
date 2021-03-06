/*
   lundi 20 août 201213:22:06
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
ALTER TABLE dbo.PROFORMA
	DROP CONSTRAINT FK_PROFORMA_COTATION
GO
COMMIT
select Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.PROFORMA
	DROP CONSTRAINT FK_PROFORMA_FOURNISSEUR
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.PROFORMA
	DROP CONSTRAINT [FK_PROFORMA_TYPE PRODUIT]
GO
COMMIT
select Has_Perms_By_Name(N'dbo.TYPEPRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.TYPEPRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.TYPEPRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.PROFORMA
	DROP CONSTRAINT DF_PROFORMA_abouti
GO
CREATE TABLE dbo.Tmp_PROFORMA
	(
	NumProf varchar(50) NOT NULL,
	ObjetProf varchar(100) NOT NULL,
	DateProf datetime NOT NULL,
	TypeProf varchar(50) NOT NULL,
	CotProf varchar(50) NOT NULL,
	FourProf varchar(50) NOT NULL,
	abouti varchar(3) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_PROFORMA ADD CONSTRAINT
	DF_PROFORMA_abouti DEFAULT ('oui') FOR abouti
GO
IF EXISTS(SELECT * FROM dbo.PROFORMA)
	 EXEC('INSERT INTO dbo.Tmp_PROFORMA (NumProf, ObjetProf, DateProf, TypeProf, CotProf, FourProf, abouti)
		SELECT NumProf, ObjetProf, DateProf, TypeProf, CotProf, FourProf, CONVERT(varchar(3), abouti) FROM dbo.PROFORMA WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.PROFORMER
	DROP CONSTRAINT FK_PROFORMER_PROFORMA
GO
DROP TABLE dbo.PROFORMA
GO
EXECUTE sp_rename N'dbo.Tmp_PROFORMA', N'PROFORMA', 'OBJECT' 
GO
ALTER TABLE dbo.PROFORMA ADD CONSTRAINT
	PK_PROFORMA PRIMARY KEY CLUSTERED 
	(
	NumProf
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PROFORMA ADD CONSTRAINT
	[FK_PROFORMA_TYPE PRODUIT] FOREIGN KEY
	(
	TypeProf
	) REFERENCES dbo.TYPEPRODUIT
	(
	Nomtype
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PROFORMA ADD CONSTRAINT
	FK_PROFORMA_FOURNISSEUR FOREIGN KEY
	(
	FourProf
	) REFERENCES dbo.FOURNISSEUR
	(
	NomFour
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PROFORMA ADD CONSTRAINT
	FK_PROFORMA_COTATION FOREIGN KEY
	(
	CotProf
	) REFERENCES dbo.COTATION
	(
	NumCot
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.PROFORMER ADD CONSTRAINT
	FK_PROFORMER_PROFORMA FOREIGN KEY
	(
	ProfProfer
	) REFERENCES dbo.PROFORMA
	(
	NumProf
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PROFORMER', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PROFORMER', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PROFORMER', 'Object', 'CONTROL') as Contr_Per 