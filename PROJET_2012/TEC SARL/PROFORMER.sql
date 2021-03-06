/*
   lundi 20 août 201217:37:30
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
ALTER TABLE dbo.PROFORMER
	DROP CONSTRAINT FK_PROFORMER_PROFORMA
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.PROFORMER
	DROP CONSTRAINT FK_PROFORMER_PRODUIT
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PRODUIT', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PROFORMER
	(
	NumProfer varchar(50) NOT NULL,
	ProfProfer varchar(50) NOT NULL,
	ProProf varchar(50) NOT NULL,
	Qtee real NOT NULL,
	PUe real NOT NULL,
	Montante  AS Qtee*PUe
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.PROFORMER)
	 EXEC('INSERT INTO dbo.Tmp_PROFORMER (NumProfer, ProfProfer, ProProf, Qtee, PUe)
		SELECT NumProfer, ProfProfer, ProProf, Qtee, PUe FROM dbo.PROFORMER WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.PROFORMER
GO
EXECUTE sp_rename N'dbo.Tmp_PROFORMER', N'PROFORMER', 'OBJECT' 
GO
ALTER TABLE dbo.PROFORMER ADD CONSTRAINT
	PK_PROFORMER_1 PRIMARY KEY CLUSTERED 
	(
	NumProfer,
	ProfProfer,
	ProProf
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PROFORMER ADD CONSTRAINT
	FK_PROFORMER_PRODUIT FOREIGN KEY
	(
	ProProf
	) REFERENCES dbo.PRODUIT
	(
	NomPro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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