1 - SELECT * FROM villes_france WHERE LENGTH(ville_nom) >= 40

2 - SELECT * FROM departements WHERE departement_code like '97%'

3 - SELECT * FROM departements WHERE departement_code IN ("02","59","60","62","80") /!\ J'ai pas trouver l'autre facon de faire

4 - SELECT ville_nom, departement_nom FROM villes_france INNER JOIN departements ON villes_france.ville_departement = departements.departement_id ORDER BY ville_population_2012

5 - SELECT departement_nom, departement_code, COUNT(ville_nom) as "Nombre_de_communes" FROM departements INNER JOIN villes_france ON departements.departement_code = villes_france.ville_departement  GROUP BY departement_nom ORDER BY Nombre_de_communes DESC

6 - SELECT departement_nom FROM departements INNER JOIN villes_france ON departements.departement_code = villes_france.ville_departement GROUP BY departement_nom ORDER BY SUM(ville_surface) DESC 

7 - SELECT COUNT(ville_nom) AS nombreDeVille FROM villes_france WHERE ville_nom like "Saint%"

8 - Franchement celle la j''en sais rien

9 - SELECT * FROM villes_france GROUP BY ville_nom HAVING ville_surface > AVG(ville_surface)

10 - SELECT * FROM departements INNER JOIN villes_france ON departements.departement_code = villes_france.ville_departement GROUP BY departement_nom HAVING SUM(ville_population_2012) > 1500000

11 - UPDATE villes_france SET ville_nom = REPLACE(ville_nom, "-" , " ") WHERE ville_nom LIKE 'SAINT-%'

12 - SELECT * FROM villes_france ORDER BY ville_surface LIMIT 50

13 - ALTER TABLE regions ADD region_nbDepartement INT NOT NULL AFTER region_nom


    J''etait entrain de regarde comment faire les For, mais pas assez de temps et rien compris
    
14 - CREATE PROCEDURE MajRegion() UPDATE regions SET region_nbDepartement = (SELECT COUNT(departement_regionId) FROM departements ) GROUP BY departement_regionId

15 - CREATE VIEW tout AS
SELECT
    v.`ville_id`,
    v.`ville_departement`,
    v.`ville_slug`,
    v.`ville_nom`,
    v.`ville_nom_simple`,
    v.`ville_nom_reel`,
    v.`ville_nom_soundex`,
    v.`ville_nom_metaphone`,
    v.`ville_code_postal`,
    v.`ville_commune`,
    v.`ville_code_commune`,
    v.`ville_arrondissement`,
    v.`ville_canton`,
    v.`ville_amdi`,
    v.`ville_population_2010`,
    v.`ville_population_1999`,
    v.`ville_population_2012`,
    v.`ville_densite_2010`,
    v.`ville_surface`,
    v.`ville_longitude_deg`,
    v.`ville_latitude_deg`,
    v.`ville_longitude_grd`,
    v.`ville_latitude_grd`,
    v.`ville_longitude_dms`,
    v.`ville_latitude_dms`,
    v.`ville_zmin`,
    v.`ville_zmax`,
    d.`departement_id`,
    d.`departement_code`,
    d.`departement_nom`,
    d.`departement_nom_uppercase`,
    d.`departement_slug`,
    d.`departement_nom_soundex`,
    d.`departement_regionId`,
    r.`region_id`,
    r.`region_nom`,
    r.`region_nbDepartement`

    FROM villes_france as v
    INNER JOIN departements as d ON v.ville_departement = d.departement_code 
    INNER JOIN regions as r ON d.departement_regionId = r.region_id 



remote: Support for password authentication was removed on August 13, 2021. Please use a personal access token instead.
remote: Please see https://github.blog/2020-12-15-token-authentication-requireme
emote: Support for password authentication was removed 
ssh-keygen -t ed25519 -C "courquin.pierre62@gmail.com"
