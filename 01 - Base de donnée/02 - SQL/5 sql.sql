A.	Requêtes simples

1.	Afficher les noms de département

SELECT nomdep FROM departement

2.	Afficher les numéros et noms de département

SELECT nodep, nomdep FROM departement

3.	Afficher toutes les propriétés des employés

SELECT * FROM employe

4.	Afficher les fonctions des employés

SELECT fonction FROM employe

5.	Afficher les fonctions des employés sans double

SELECT DISTINCT fonction FROM employe

6.	Afficher les noms des employés avec leur date d embauche, ainsi que la date d embauche augmentée d une journée

SELECT nomemp, datemb, DATE_FORMAT(datemb + 1,"%D %b %Y") AS "Date d'embauche + 1" FROM employe

7.	Afficher les noms des employés suivis d un espace, suivi de leur fonction

SELECT nomemp + " ", fonction FROM employe


B.	Requêtes avec clause “where”

1.	Donner la liste des numéros et noms des employés du département 30

SELECT noemp  nomemp FROM employe WHERE nodep = 30

2.	Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département

SELECT noemp, nomemp , nodep FROM employe

3.	Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30

SELECT nomdep, nodep FROM departement WHERE nodep >= 30

4.	Donner les noms, salaires et commissions des employés dont la commission excède le salaire

SELECT noemp, sala, comm FROM employe WHERE comm > sala

5.	Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 €

SELECT nomemp, sala FROM employe WHERE nomdep = 30 AND sala > 1500

6.	Donner la liste des noms, fonctions et salaires des directeurs et des présidents

SELECT nomemp, fonction, sala FROM employe WHERE fonction = "directeur" OR "presidents"

7.	Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 €

SELECT nomemp, fonction, sala FROM employe WHERE sala > 2500

SELECT nomemp, fonction, sala FROM employe WHERE fonctions = "directeur" OR sala > 2500

8.	Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10

SELECT nomemp, nodep FROM employe WHERE fonction = "directeur" OR "ouvrier" AND nodep = 10

9.	Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur

SELECT nomemp, fonction, nodep FROM employe WHERE nodep = 10 AND fonction != "ouvrier" OR "directeur"

10.	Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30

SELECT nomemp, fonction, nodep FROM employe WHERE fonction = "directeur" AND nodep != 30

11.	Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 €

SELECT nomemp, fonction, sala FROM employe WHERE sala BETWEEN 1200 AND 1300

12.	Donner la liste des noms, numéros de département et fonctions des employés
« ouvrier », « analyste » ou « vendeur »

SELECT nomemp, nodep, fonction FROM employe WHERE fonction IN ("ouvrier", "analyste", "vendeur")

13.	Donner les employés qui ne sont pas "vendeur"

SELECT * FROM employe WHERE fonction != "vendeur"

14.	Donner la liste des employés dont la première lettre du nom est un "C"

SELECT * FROM employe WHERE nomemp LIKE "C%"

15.	Donner la liste des employés qui n ont pas de commission

SELECT * FROM employe WHERE comm = ""

16.	Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20

SELECT * FROM employe WHERE comm != "" AND nodept IN (30, 20)



C.	Requêtes avec clause « order by »

1.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l ordre croissant des salaires

SELECT sala, fonction, noemp FROM employe WHERE nodept = 30 ORDER BY sala

2.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l ordre décroissant des salaires

SELECT sala, fonction, noemp FROM employe WHERE nodept = 30 ORDER BY sala DESC

3.	Donner la liste des employés triée selon l ordre croissant des fonctions et l ordre décroissant des salaires

SELECT * FROM employe ORDER BY fonction AND sala DESC

4.	Donner la liste des commissions, salaires et noms triée selon l ordre croissant des commissions

SELECT comm, sala, nomemp FROM employe ORDER BY comm

5.	Donner la liste des commissions, salaires et noms triée selon l ordre décroissant des commissions

SELECT comm, sala, nomemp FROM employe ORDER BY comm DESC



1.	Donner la ville dans laquelle travaille Costanza

SELECT ville FROM employe INNER JOIN departement ON employe.nodept = departement.nodep WHERE nomemp = "Costanza"

2.	Donner les noms, fonctions, et noms des départements des employés des départements 30 et 40

SELECT noemp, fonction, nomdep FROM employe INNER JOIN departement ON employe.nodept = departement.nodept WHERE employe.nodept IN (30, 40)

3.	Donner le grade, la fonction, le nom et le salaire de chaque employé

SELECT grade , fonction, noemp, sala FROM employe INNER JOIN grade ON employe. WHERE

4.	Donner la liste des noms et salaires des employés qui gagnent plus que leur responsable

SELECT noemp, sala, noresp as resp FROM employe WHERE  (SELECT sala FROM employe WHERE noemp = resp) > sala 

5.	Donner la liste des noms, salaires, fonctions des employés qui gagnent plus que Perou


E.	Requêtes avec fonctions et expressions numériques

1.	Donner les noms, salaires, commissions et revenus des 

SELECT noemp, sala, comm, (sala + comm) as revenue FROM employe WHERE fonction = "vendeur"	

2.	Donner les noms, salaires et les commissions des employés dont la commission est supérieure à 25% de leur salaire
3.	Donner la liste des vendeurs dans l ordre décroissant de leur commission divisée par leur salaire
4.	Donner le revenu annuel de chaque vendeur
5.	Donner le salaire quotidien des vendeurs
6.	Donner la moyenne des salaires des ouvriers
7.	Donner le total des salaires et des commissions des vendeurs
8.	Donner le revenu annuel moyen de tous les vendeurs
9.	Donner le plus haut salaire, le plus bas et l écart entre les deux
10.	Donner le nombre d employés du département 30
