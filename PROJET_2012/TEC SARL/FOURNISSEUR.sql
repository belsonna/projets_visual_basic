/*
   lundi 20 août 201214:08:26
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
ALTER TABLE dbo.FOURNISSEUR ADD
	partenaire varchar(3) NOT NULL CONSTRAINT DF_FOURNISSEUR_partenaire DEFAULT 'oui'
GO
COMMIT
select Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.FOURNISSEUR', 'Object', 'CONTROL') as Contr_Per 