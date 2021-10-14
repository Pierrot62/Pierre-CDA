-- Afficher toutes les informations concernant les employés. 

SELECT * FROM employe

-- Afficher toutes les informations concernant les départements. 

SELECT * FROM dept

-- Afficher le nom, la date d'embauche, le numéro du supérieur, le 
-- numéro de département et le salaire de tous les employés.

SELECT `nom` , `dateemb`, `nosup`, `nodep`, `salaire`FROM `employe`

-- Afficher le titre de tous les employés.

SELECT  titre FROM employe

-- Afficher les différentes valeurs des titres des employés. 

SELECT DISTINCT titre FROM employe

-- Afficher les différentes valeurs des titres des employés. 

SELECT nom , noemp , nodep FROM employe WHERE titre = 'secretaire'

-- Afficher le nom et le numéro de département dont le numéro de département est supérieur à 40

SELECT nom , nodept FROM `dept` WHERE nodept > 40

-- Afficher le nom et le prénom des employés dont le nom est alphabétiquement antérieur au prénom. 


-- Afficher le nom, le salaire et le numéro du départementdes employés  dont le titre est « Représentant », le numéro de département est 35 et le salaire est supérieur à 20000. 

SELECT nom , salaire , nodep FROM employe WHERE nodep = 35 AND salaire > 20000

-- Afficher le nom, le titre et le salaire des employés dont le titre est « Représentant » ou dont le titre est « Président ». 

SELECT nom , titre, salaire FROM employe WHERE titre = 'president'

-- Afficher le nom, le titre, le numéro de département, le salaire des employés du département 34, dont le titre est « Représentant » ou « Secrétaire ».

SELECT nom , titre, nodep , salaire FROM employe WHERE nodep = 34 AND (titre = 'secretaire' OR titre = 'representant')

-- Afficher le nom, le titre, le numéro de département, le salaire des employés dont le titre est Représentant, ou dont le titre est Secrétaire dans le département numéro 34.

SELECT nom , titre, nodep , salaire FROM employe WHERE titre = 'representant' OR nodep = 34 AND titre = 'secretaire'

-- Afficher le nom, et le salaire des employés dont le salaire est compris entre 20000 et 30000. 

SELECT nom , salaire FROM employe WHERE salaire BETWEEN 20000 AND 30000

-- Afficher le nom des employés commençant par la lettre « H ». 
SELECT nom FROM employe WHERE nom LIKE 'h%'

-- Afficher le nom des employés se terminant par la lettre « n ». 
SELECT nom FROM employe WHERE nom LIKE '%n'

-- Afficher le nom des employés contenant la lettre « u » en 3ème position.

SELECT nom FROM employe WHERE SUBSTRING(nom,3,1)="u"

-- Afficher le salaire et le nom des employés du service 41 classés par salaire croissant. 

SELECT salaire, nom FROM employe ORDER BY salaire

-- Afficher le salaire et le nom des employés du service 41 classés par salaire décroissant.

SELECT salaire, nom FROM employe ORDER BY salaire DESC

-- Afficher le titre, le salaire et le nom des employés classés par titre croissant et par salaire décroissant

SELECT titre, nom, salaire, nom FROM employe ORDER BY titre DESC ...

-- Afficher le taux de commission, le salaire et le nom des employés classés par taux de commission croissante. 

SELECT tauxcom , salaire FROM employe ORDER BY tauxcom

-- Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission n est pas renseigné. 

SELECT nom, salaire ,tauxcom FROM employe WHERE tauxcom  IS null

-- Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission est renseigné.

SELECT nom , salaire , tauxcom , titre FROM employe WHERE tauxcom IS NOT null

-- Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est inférieur à 15.

SELECT nom, salaire, tauxcom, titre FROM employe WHERE tauxcom < 15

-- Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est supérieur à 15

SELECT nom, salaire, tauxcom, titre FROM employe WHERE tauxcom > 15

-- Afficher le nom, le salaire, le taux de commission et la commission des employés dont le taux de commission nest pas nul. (la commission est calculée en multipliant le salaire par le taux de commission)

SELECT nom, salaire, tauxcom, ((salaire*tauxcom)/100) as commission FROM employe WHERE tauxcom IS NOT NULL

-- Afficher le nom, le salaire, le taux de commission, la commission des employés dont le taux de commission n est pas nul, classé par taux de commission croissant. 

SELECT nom, salaire, tauxcom, ((salaire*tauxcom)/100) as commission FROM employe WHERE tauxcom IS NOT NULL ORDER BY tauxcom

-- Afficher le nom et le prénom (concaténés) des employés. Renommer les colonnes

SELECT (CONCAT(nom," ", prenom)) AS personne  FROM employe  

-- Afficher les 5 premières lettres du nom des employés

SELECT (SUBSTRING(nom,1,5)) AS nomEmployes FROM employe

-- Afficher le nom et le rang de la lettre « r » dans le nom des employés.

SELECT nom, (LOCATE("r", nom)) as "Rang de la lettre r" FROM employe

-- Afficher le nom, le nom en majuscule et le nom en minuscule de l employé dont le nom est Vrante. 

SELECT nom, UPPER(nom) AS "Non en majuscule" FROM employe where nom = "Vrante"

-- Afficher le nom et le nombre de caractères du nom des employés.

SELECT nom, LENGTH(nom) AS "Nombre de lettre" FROM employe

-- Rechercher le prénom des employés et le numéro de la région de leur département.

SELECT prenom, noregion , nodep FROM employe INNER JOIN dept ON employe.nodep = dept.nodept

Rechercher le numéro du département, le nom du département, le nom des employés classés par numéro de département (renommer les tables utilisées).

SELECT prenom, noregion , nodep FROM employe as toto LEFT JOIN dept as tata ON toto.nodep = tata.nodept GROUP BY nodep

Rechercher le nom des employés du département Distribution. 

SELECT employe.nom FROM employe INNER JOIN dept ON employe.nodep = dept.nodept WHERE dept.nom = "distribution"

Rechercher le nom et le salaire des employés qui gagnent plus que leur patron, et le nom et le salaire de leur patron. 

SELECT nom, salaire , (SELECT nom, salaire FROM employe WHERE titre = "president ")

Rechercher le nom et le titre des employés qui ont le même titre que Amartakaldire. 

SELECT nom, titre FROM employe WHERE titre = (SELECT titre FROM employe WHERE nom = "Amartakaldire")

Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus qu un seul employé du département 31, classés par numéro de département et salaire.

SELECT nom, salaire, nodep FROM employe WHERE salaire > (SELECT MIN(salaire) FROM employe WHERE nodep = 31)

Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus que tous les employés du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe WHERE salaire > (SELECT MAX(salaire) FROM employe WHERE nodep = 31) ORDER BY nodep AND salaire

Rechercher le nom et le titre des employés du service 31 qui ont un titre que l on trouve dans le département 32. 

SELECT nom, titre