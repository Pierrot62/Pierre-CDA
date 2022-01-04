<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/style.css">
    <title>NOM DU SITE</title>
</head>

<body>

   <?php

    require "employerClass.php";
    require "agenceClass.php";
    require "enfantClass.php";

    $enf[] = new Enfant(["nom" => "Tomtom", "prenom" => "Titi","ddn" => new DateTime("2000-10-20")]);
    $enf[] = new Enfant(["nom" => "Tomtom", "prenom" => "Toto","ddn" => new DateTime("2019-10-20")]);
    $enf[] = new Enfant(["nom" => "Jaquet", "prenom" => "Jojo","ddn" => new DateTime("2010-10-20")]);

    $a[] = new Agence(["nom" => "HKCom", "adresse" => "9 rue des champignons", "codePostal" => "59800", "ville" => "Dunkerque","restaurant"=>true]);    
    $a[] = new Agence(["nom" => "Afpa", "adresse" => "48 avenue de la gironde", "codePostal" => "59000", "ville" => "Dunkerque","restaurant"=>false]);

    $e[] = new Employer(["nom" => "Courquin", "prenom" => "Pierre", "dateEmbauche" => new DateTime("2014-10-27"), "fonction" => "Dev Back","salaire" => 1200, "service" => "Developpement", "agence" => $a[0], "enfant" => [$enf[0],$enf[2]]]);
    $e[] = new Employer(["nom" => "Durant", "prenom" => "Maxence", "dateEmbauche" => new DateTime("12-03-2006"), "fonction" => "Serveur","salaire" => 1, "service" => "Poubelle", "agence" => $a[1], "enfant" => []]);
    $e[] = new Employer(["nom" => "Balair", "prenom" => "Quentin", "dateEmbauche" => new DateTime("2009-11-05"), "fonction" => "Dev front","salaire" => 30, "service" => "Developpement", "agence" => $a[0], "enfant" => [$enf[1]]]);
    $e[] = new Employer(["nom" => "Mayeux", "prenom" => "Bruno", "dateEmbauche" => new DateTime("1950-12-01"), "fonction" => "Chef     d'equipe", "salaire" => 65, "service" => "Direction", "agence" => $a[0], "enfant" => []]);
    $e[] = new Employer(["nom" => "Barato", "prenom" => "Marvine", "dateEmbauche" => new DateTime("2016-04-30"), "fonction" => "Dev     Wordpress", "salaire" => 25, "service" => "Developpement", "agence" => $a[1], "enfant" => []]);

    echo ("Liste des employer de la societe \"NO CMS\" <div></div>");
    echo "<div></div>************************<div></div>";
    foreach ($e as $key => $emp) {
        echo "<div></div> Nom : " . $emp->getNom() . "<div></div>" .
        "Prenom : " . $emp->getPrenom() . "<div></div>" .
        // "Date d'embauche : ". $emp->getDateEmbauche()."<div></div>".
        "Salaire : " . $emp->getSalaire() . "<div></div>" .
        "Fonction : " . $emp->getFonction() . "<div></div>" .
        "Service : " . $emp->getService() . "<div></div>
            *******<div></div>" .
        "Nom : " . $emp->getAgence()->getNom() . "<div></div>" .
        "Adresse : " . $emp->getAgence()->getAdresse() . "<div></div>" .
        "Code Postal : " . $emp->getAgence()->getCodePostal() . "<div></div>" .
        "Ville : " . $emp->getAgence()->getVille() . "<div></div>";

        echo $emp->getAgence()->getRestaurant() == false ? "L'agence de dispose pas de restaurant d'entreprise" : "L'agence dispose d'un restaurant d'entreprise <div></div>";
        echo $emp->chequeVacances() == true ? "L'employé dispose de cheque vacances" : "L'employé ne dispose pas de cheque vacance";
        echo "<div></div>********Enfant(s)*********<div></div>";
        foreach ($emp->getEnfant() as $key => $enf) {
            echo "Nom : ".$enf->getNom()." <div></div>"; 
            echo "Prenom : ".$enf->getPrenom()." <div></div>"; 
            echo "Age : ".$enf->ageEnfant()." <div></div>"; 
            echo "********** <div></div>";
        }
        echo "<div></div>************************<div></div>";
        $cheque = $emp->chequeNoel();
        if (array_sum($cheque) != 0) {
            echo "L'employer a le droit a des cheque noel : <div></div>".
            "Cheque de 20Euros : ". $cheque[20]."<div></div>".
            "Cheque de 30Euros : ". $cheque[30]."<div></div>".
            "Cheque de 50Euros : ". $cheque[50]."<div></div>";
        }
    }

    $auj = new DateTime('2022-11-30');
    $anne = $auj->format("Y");
    if ($auj == new DateTime($anne . "-12-31")) {
        foreach ($e as $emp) {
            echo "L'ordre de transfert a été envoyé à la banque pour " . $elt->getNom() . " " . $elt->getPrenom() . " d'un montant de " .$elt->prime() . "<div></div>************************<div></div>";
        }
    }

   echo "Nombre d'employés dans l'entreprise : ". count($e). "<div></div>";
   
//    Tri des employés
   usort($e,array("Employer","compareToNomPrenom"));
   usort($e,array("Employer","compareToServiceNomPrenom"));

//    masse salariale
    $masse = 0;
    foreach ($e as $key => $emp) {
        $masse += $emp->getSalaire();
    }

    echo "La masse salariale est de :". $masse ."Euro <div></div>";


?>

</body>

</html>