-- Afficher toutes les informations concernant les employés. 

SELECT * FROM employe

-- Afficher toutes les informations concernant les départements. 

SELECT * FROM dept

-- Afficher le nom, la date d'embauche, le numéro du supérieur, le numéro de département et le salaire de tous les employés.

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

SELECT `nom` , `prenom` FROM `employe` WHERE `nom` < `prenom`

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

-- Rechercher le numéro du département, le nom du département, le nom des employés classés par numéro de département (renommer les tables utilisées).

SELECT prenom, noregion , nodep FROM employe as toto LEFT JOIN dept as tata ON toto.nodep = tata.nodept ORDER BY nodep

-- Rechercher le nom des employés du département Distribution. 

SELECT employe.nom FROM employe INNER JOIN dept ON employe.nodep = dept.nodept WHERE dept.nom = "distribution"

-- Rechercher le nom et le salaire des employés qui gagnent plus que leur patron, et le nom et le salaire de leur patron. 

SELECT nom, salaire , SalaireBoss FROM employe WHERE  (SELECT `salaire` FROM employe WHERE noemp =  ) AS SalaireBoss AND- ----

-- Rechercher le nom et le titre des employés qui ont le même titre que Amartakaldire. 

SELECT nom, titre FROM employe WHERE titre = (SELECT titre FROM employe WHERE nom = "Amartakaldire")

-- Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus qu un seul employé du département 31, classés par numéro de département et salaire.

SELECT nom, salaire, nodep FROM employe WHERE salaire > (SELECT MIN(salaire) FROM employe WHERE nodep = 31) ORDER BY nodep , salaire

-- Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus que tous les employés du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe WHERE salaire > (SELECT MAX(salaire) FROM employe WHERE nodep = 31) ORDER BY nodep AND salaire

-- Rechercher le nom et le titre des employés du service 31 qui ont un titre que l on trouve dans le département 32. 

SELECT nom, titre  FROM employe WHERE titre IN (SELECT titre FROM employe WHERE nodep = 32) AND nodep = 31

-- Rechercher le nom et le titre des employés du service 31 qui ont un titre l on ne trouve pas dans le département 32. 

SELECT nom, titre  FROM employe WHERE titre NOT IN (SELECT titre FROM employe WHERE nodep = 32) AND nodep = 31

-- Rechercher le nom, le titre et le salaire des employés qui ont le même titre et le même salaire que Fairant. 

SELECT nom, titre, salaire FROM employe WHERE titre = fairent.titre AND salaire = fairent.salaire (SELECT titre, salaire FROM employe where nom = "Fairent" ) as fairent---------------

-- Rechercher le numéro de département, le nom du département, le nom des employés, en affichant aussi les départements dans lesquels il n y a personne, classés par numéro de département.

SELECT e.nodep, d.nom AS 'nom departement', e.nom AS 'nom employe' FROM employe AS e RIGHT JOIN dept AS d ON e.nodep = d.nodept ORDER BY e.nodep

-- 1. Calculer le nombre d'employés de chaque titre.

SELECT titre, COUNT(*) AS NbEmploye FROM employe GROUP BY titre

-- 2. Calculer la moyenne des salaires et leur somme, par région.

SELECT AVG(salaire) AS "Moyenne des salaire" , SUM(salaire) AS "Somme des salaire" , noregion FROM employe INNER JOIN dept ON employe.nodep = dept.nodept GROUP BY noregion

-- 3. Afficher les numéros des départements ayant au moins 3 employés. 

SELECT nodep FROM `employe` GROUP BY nodep HAVING count(nodep) > 2

-- 4. Afficher les lettres qui sont l'initiale d'au moins trois employés.

Select substring(nom,1,1) as 'initial'from employe group by initial having count(initial) > 2

-- 5. Rechercher le salaire maximum et le salaire minimum parmi tous les salariés et l'écart entre les deux. 

SELECT MIN(salaire) AS "SalaireMin" , MAX(salaire) AS "SalaireMax" , (MAX(salaire) - MIN(salaire)) AS "Ecart" FROM employe

-- 6. Rechercher le nombre de titres différents.

SELECT COUNT(DISTINCT titre) as "Nombre de titres" FROM employe

-- 7. Pour chaque titre, compter le nombre d'employés possédant ce titre.

SELECT titre, DISTINCT COUNT(titre) FROM employe

-- 8. Pour chaque nom de département, afficher le nom du département et le nombre d'employés.

SELECT d.nom, count(e.noemp) AS "Nb employes" FROM employe AS e INNER JOIN dept AS d ON d.nodept=e.nodep GROUP BY d.nom;

-- 9. Pour chaque nom de département, afficher le nom du département et le nombre d'employés.

SELECT titre, ROUND(AVG(salaire)) as "MoySalaire" FROM employe GROUP BY titre HAVING MoySalaire > (SELECT AVG(salaire) FROM employe WHERE titre="représentant")

-- 10.Rechercher le nombre de salaires renseignés et le nombre de taux de commission renseignés. 





FICHE 3


-- Quelles sont les commandes du fournisseur 09120 ?

SELECT * FROM entcom WHERE numfou = 09120

-- 2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées.

SELECT DISTINCT numfou FROM entcom

-- 3. Afficher le nombre de commandes fournisseurs passées, et le nombre de fournisseur concernés.

SELECT COUNT(*) AS "Commande passées", COUNT(DISTINCT numfou) AS "Nombre de fournisseur" FROM entcom

-- 4. Editer les produits ayant un stock inférieur ou égal au stock d'alerte et dont la quantité annuelle est inférieur est inférieure à 1000 (informations à fournir : n° produit, libellé produit, stock, stock actuel d'alerte, quantité annuelle)

SELECT codart, libart, stkphy , stkale , qteann FROM produit WHERE stkphy <= stkale AND qteann < 1000

-- 5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ?L’affichage (département, nom fournisseur) sera effectué par département décroissant, puis par ordre alphabétique

SELECT posfou , nomfou FROM fournis WHERE (LEFT(posfou,2) = 75 OR 78 OR 92 OR 77) 

-- 6. Quelles sont les commandes passées au mois de mars et avril ?

SELECT * FROM entcom WHERE MONTH(datcom) IN (3,4)

-- 7. Quelles sont les commandes du jour qui ont des observations particulières ?(Affichage numéro de commande, date de commande)

SELECT numcom, datcom FROM entcom WHERE obscom != ""

-- 8. Lister le total de chaque commande par total décroissant (Affichage numéro de commande et total)

SELECT numcom, priuni * qteliv FROM commandeLigne GROUP BY numcom

-- 9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans le calcul du total les articles commandés en quantité supérieure ou égale à 1000.(Affichage numéro de commande et total)

SELECT numcom, (priuni * qteliv) FROM commandeLigne WHERE priuni * qteliv > 10000 AND qteliv < 1000

-- 10.Lister les commandes par nom fournisseur (Afficher le nom du fournisseur, le numéro de commande et la date)

SELECT fournis.nomfou, entcom.numcom, entcom.datcom FROM entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou GROUP BY entcom.numfou ORDER BY entcom.datcom

-- 11.Sortir les produits des commandes ayant le mot "urgent' en observation?(Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et le sous total = quantité commandée * Prix unitaire)

SELECT entcom.numfou, fournis.nomfou, produit.libart, entcom.obscom, (qtecde * priuni) FROM entcom INNER JOIN ligcom ON entcom.numcom = ligcom.numcom INNER JOIN fournis ON entcom.numfou = fournis.numfou INNER JOIN produit ON ligcom.codart = produit.codart WHERE entcom.obscom LIKE "%urgent%"

-- 12.Coder de 2 manières différentes la requête suivante : Lister le nom des fournisseurs susceptibles de livrer au moins un article

SELECT fournis.nomfou, SUM(qte1+qte2+qte3) AS 'total' FROM vente INNER JOIN fournis ON vente.numfou = fournis.numfou GROUP BY nomfou HAVING total > 0

-- 13.Coder de 2 manières différentes la requête suivante Lister les commandes (Numéro et date) dont le fournisseur est celui de la commande 70210 :

SELECT numcom, datcom FROM entcom WHERE numfou = (SELECT numfou FROM entcom WHERE numcom = 70210)

-- 14.Dans les articles susceptibles d’être vendus, lister les articles moins chers (basés sur Prix1) que le moins cher des rubans (article dont le premier caractère commence par R). On affichera le libellé de l’article et prix1

SELECT produit.libart, vente.prix1 FROM vente INNER JOIN produit ON vente.codart = produit.codart WHERE prix1 < (SELECT prix1 FROM vente INNER JOIN produit ON vente.libart WHERE produit.libart LIKE "r%")

-- 15.Editer la liste des fournisseurs susceptibles de livrer les produits dont le stock est inférieur ou égal à 150 % du stock d'alerte. La liste est triée par produit puis fournisseur

-- 16.Éditer la liste des fournisseurs susceptibles de livrer les produit dont le stock est inférieur ou égal à 150 % du stock d'alerte et un délai de livraison d'au plus 30 jours. La liste est triée par fournisseur puis produit

-- 17.Avec le même type de sélection que ci-dessus, sortir un total des stocks par fournisseur trié par total décroissant

-- 18.En fin d'année, sortir la liste des produits dont la quantité réellement commandée dépasse 90% de la quantité annuelle prévue.

-- 19.Calculer le chiffre d'affaire par fournisseur pour l'année 93 sachant que les prix indiqués sont hors taxes et que le taux de TVA est 20%.

CREATE VIEW CommandeLIgne AS
SELECT 
c.numcom, 
c.obscom, 
c.datcom, 
c.numfou, 
l.numlig, 
l.codart, 
l.qtecde, 
l.priuni, 
l.qteliv, 
l.derliv
FROM entcom AS c
RIGHT JOIN ligcom as l
ON c.numcom = l.numcom

CREATE VIEW  stagiaireFormation as
SELECT
    f.`idFormation`,
    f.`libelleFormation`,
    s.`idSessionFormation`,
    s.`numOffreFormation`,
    s.`dateDebut`,
    s.`dateFin`,
    p.`idPeriode`,
    p.`dateDebutPAE`,
    p.`dateFinPAE`,
    p.`dateRapportSuivi`,
    p.`objectifPAE`,
    pa.`idParticipation`,
    st.`idStagiaire`,
    st.`genreStagiaire`,
    st.`nomStagiaire`,
    st.`prenomStagiaire`,
    st.`numSecuStagiaire`,
    st.`numBenefStagiaire`,
    st.`dateNaissanceStagiaire`,
    st.`emailStagiaire`
FROM
    `formations` AS f
INNER JOIN sessionsformations AS s
ON
    f.idFormation = s.idFormation
INNER JOIN periodesstages AS p
ON
    s.idsessionFormation = p.idSessionFormation
INNER JOIN participations AS pa
ON
    pa.idsessionFormation = s.idsessionFormation
INNER JOIN stagiaires AS st
ON
    st.idStagiaire = pa.idStagiaire


    1. Application dune augmentation de tarif de 4% pour le prix 1, 2% pour le prix2 
pour le fournisseur 9180

UPDATE `vente` SET prix1 = prix1 + (4/100), prix2 = prix2 + (2/100) WHERE numfou = 9180

2. Dans la table vente, mettre à jour le prix2 des articles dont le prix2 est null, en affectant a valeur de prix.

UPDATE `vente` SET prix2 = prix1 WHERE prix2 = 0

3. Mettre à jour le champ obscom en positionnant '*****' pour toutes les commandes 
dont le fournisseur a un indice de satisfaction <5

UPDATE entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou SET obscom = CONCAT("*****", obscom) WHERE satisf < 5

4. Suppression du produit I110

DELETE FROM `produit` WHERE `codart` = "I110"

5. Suppression des entête de commande qui n ont aucune ligne

DELETE FROM `entcom` WHERE obscom = " "