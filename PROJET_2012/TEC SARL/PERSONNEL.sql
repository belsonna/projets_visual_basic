/*
   lundi 20 août 201214:09:20
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
ALTER TABLE dbo.PERSONNEL ADD CONSTRAINT
	DF_PERSONNEL_NumPer DEFAULT 'non' FOR NumPer
GO
COMMIT
select Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.PERSONNEL', 'Object', 'CONTROL') as Contr_Per 