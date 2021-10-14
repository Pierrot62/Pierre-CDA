-- 1 Afficher toutes les informations concernant les employés. 

SELECT * FROM `employe`

-- 2 Afficher toutes les informations concernant les départements. 

SELECT * FROM `dept`

-- 3 Afficher le nom, la date d'embauche, le numéro du supérieur, le numéro de département et le salaire de tous les employés.

SELECT `nom` , `dateemb`, `nosup`, `nodep`, `salaire` FROM `employe`

-- 4 Afficher le titre de tous les employés.

SELECT  `titre` FROM `employe`

-- 5 Afficher les différentes valeurs des titres des employés. 

SELECT DISTINCT `titre` FROM `employe`

-- 6 Afficher les différentes valeurs des titres des employés. 

SELECT `nom` , `noemp` , `nodep` FROM `employe` WHERE `titre` = 'secretaire'

-- 7 Afficher le nom et le numéro de département dont le numéro de département est supérieur à 40

SELECT `nom` , `nodept` FROM `dept` WHERE `nodept` > 40

-- 8 Afficher le nom et le prénom des employés dont le nom est alphabétiquement antérieur au prénom. 

SELECT `nom` , `prenom` FROM `employe` WHERE `nom` < `prenom`

-- 9 Afficher le nom, le salaire et le numéro du départementdes employés  dont le titre est « Représentant », le numéro de département est 35 et le salaire est supérieur à 20000.

SELECT `nom`, `salaire`, `nodep` FROM `employe` WHERE `titre` = 'Représentant' AND `nodep` = 35 AND `salaire` > 20000

-- 10 Afficher le nom, le titre et le salaire des employés dont le titre est «Représentant» ou dont le titre est «Président».

SELECT `nom`, `titre`, `salaire` FROM `employe` WHERE `titre` = "Représentant" OR `titre` = "Président";

-- 11 Afficher le nom, le titre, le numéro de département, le salaire des employés du département 34, dont le titre est « Représentant » ou « Secrétaire ».

SELECT `nom`, `titre`, `nodep`, `salaire` FROM `employe` WHERE `nodep` = 34 AND `titre` IN ("Représentant","Secrétaire")

-- 12 Afficher le nom, le titre, le numéro de département, le salaire des employés dont le titre est Représentant, ou dont le titre est Secrétaire dans le département numéro 34.

SELECT `nom`, `titre`, `nodep`, `salaire` FROM `employe` WHERE ( `nodep` = 34 AND `titre` = 'secretaire' ) OR `titre` = 'representant'

-- 13 Afficher le nom, et le salaire des employés dont le salaire est compris entre 20000 et 30000. 

SELECT `nom` , `salaire` FROM `employe` WHERE `salaire` BETWEEN 20000 AND 30000

------------------
WHERE IS 14 ????? 
------------------

-- 15 Afficher le nom des employés commençant par la lettre « H ». 

SELECT `nom` FROM `employe` WHERE `nom` LIKE 'H%'

-- 16 Afficher le nom des employés se terminant par la lettre « n ». 

SELECT `nom` FROM `employe` WHERE `nom` LIKE '%n'

-- 17 Afficher le nom des employés contenant la lettre « u » en 3ème position.

SELECT `nom` FROM `employe` WHERE SUBSTRING(`nom`,3,1) = "u"
SELECT `nom` FROM `employe` WHERE `nom` LIKE "__u%"

-- 18 Afficher le salaire et le nom des employés du service 41 classés par salaire croissant. 

SELECT `salaire`, `nom` FROM `employe` WHERE `nodep` = 41 ORDER BY `salaire`

-- 19 Afficher le salaire et le nom des employés du service 41 classés par salaire décroissant.

SELECT `salaire`, `nom` FROM `employe` WHERE `nodep` = 41 ORDER BY `salaire` DESC

-- 20 Afficher le titre, le salaire et le nom des employés classés par titre croissant et par salaire décroissant

SELECT `titre`, `salaire`, `nom` FROM `employe` ORDER BY `titre` , `salaire` DESC

-- 21 Afficher le taux de commission, le salaire et le nom des employés classés par taux de commission croissante. 

SELECT `tauxcom` , `salaire` , `nom` FROM `employe` ORDER BY `tauxcom`

-- 22 Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission n est pas renseigné. 

SELECT `nom`, `salaire` ,`tauxcom`, `titre` FROM `employe` WHERE `tauxcom` IS null

-- 23 Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission est renseigné.

SELECT `nom` , `salaire` , `tauxcom` , `titre` FROM `employe` WHERE `tauxcom` IS NOT null

-- 24 Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est inférieur à 15.

SELECT `nom`, `salaire`, `tauxcom`, `titre` FROM `employe` WHERE `tauxcom` < 15

-- 25 Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est supérieur à 15

SELECT `nom`, `salaire`, `tauxcom`, `titre` FROM `employe` WHERE `tauxcom` > 15

-- 26 Afficher le nom, le salaire, le taux de commission et la commission des employés dont le taux de commission nest pas nul. (la commission est calculée en multipliant le salaire par le taux de commission)

SELECT `nom`, `salaire`, `tauxcom`, ((`salaire`*`tauxcom`)/100) AS `commission` FROM `employe` WHERE `tauxcom` IS NOT NULL

-- 27 Afficher le nom, le salaire, le taux de commission, la commission des employés dont le taux de commission n est pas nul, classé par taux de commission croissant. 

SELECT `nom`, `salaire`, `tauxcom`, ((`salaire`*`tauxcom`)/100) as `commission` FROM `employe` WHERE `tauxcom` IS NOT NULL ORDER BY `tauxcom`