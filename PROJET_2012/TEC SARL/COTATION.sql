/*
   dimanche 19 août 201210:43:57
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
CREATE TABLE dbo.Tmp_COTATION
	(
	NumCot varchar(50) NOT NULL,
	ObjetCot varchar(255) NOT NULL,
	DateCot datetime NOT NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.COTATION)
	 EXEC('INSERT INTO dbo.Tmp_COTATION (NumCot, ObjetCot, DateCot)
		SELECT NumCot, ObjetCot, CONVERT(datetime, DateCot) FROM dbo.COTATION WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.PROFORMA
	DROP CONSTRAINT FK_PROFORMA_COTATION
GO
DROP TABLE dbo.COTATION
GO
EXECUTE sp_rename N'dbo.Tmp_COTATION', N'COTATION', 'OBJECT' 
GO
ALTER TABLE dbo.COTATION ADD CONSTRAINT
	PK_COTATION PRIMARY KEY CLUSTERED 
	(
	NumCot
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.COTATION', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
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
select Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PROFORMA', 'Object', 'CONTROL') as Contr_Per 