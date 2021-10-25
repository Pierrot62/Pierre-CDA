<?php


if (isset($_FILES['fichier']))
{
$xml = simplexml_load_file($_FILES['fichier']['tmp_name']);
$json = json_encode($xml);
$myArray = json_decode($json, true);

/*
$myArray['Table'][$i]['Name'] => name = Nom de la table
$myArray['Table'][$i]['Column'] => C'est un Tableau avec des tableaux qui seront les colonnes de la table
$myArray['Table'][$i]['Column'][$i]['Name'] => Nom de la colonne
$myArray['Table'][$i]['Column'][$i]['Type'] => Type de la colonne
$myArray['Table'][$i]['PK']['Key'] => les clés primaires /!\ si la clé primaire contient une ',' c'est une table associative !
$myArray['Table'][$i]['FK'][$i]['Key'] => le nom de la clé étrangère
$myArray['Table'][$i]['FK'][$i]['Reference'] => nom de la références (c'est le truc qui a apres references en SQL)
 */

$fileName = str_replace(" ", "_", substr($_FILES['fichier']['name'], 0 ,strlen($_FILES['fichier']['name']) -4));
$SQLFile = fopen($fileName . '.sql', 'w');

$SQLSnippet = 
      "#========================================\n"
    . "#             SCRIPT MYSQL"
    . "\n#========================================\n"
    . "\nDROP DATABASE IF EXISTS " . $fileName . ' DEFAULT CHARACTER SET utf8 ;'
    . "\nCREATE DATABASE " . $fileName . ';'
    . "\nUSE " . $fileName . ';';

$tableNameArr = [];
$tabFK = [];

// On boucle sur les tables ..
for ($i = 0; $i < count($myArray['Table']); $i++) {
    // on regarde si la table contient des Foreign Keys ..
    if (isset($myArray['Table'][$i]['FK'])) {

        // On regarde si dans les Fk il y en a qu'une ou plusieurs, SI $myArray['Table'][$i]['FK'] contient des tableaux associatifs c'est qu'il y a qu'un Fk sinon Il y en a plusieurs.
        if (!(is_array($myArray['Table'][$i]['FK']) && array_diff_key($myArray['Table'][$i]['FK'], array_keys(array_keys($myArray['Table'][$i]['FK']))))) {
            // On récupères les FK dans un tableau
            for ($j = 0; $j < count($myArray['Table'][$i]['FK']); $j++) {
                $tableNameArr[] = $myArray['Table'][$i]['Name'];
                $tabFK[] = [$myArray['Table'][$i]['FK'][$j]['Key'], $myArray['Table'][$i]['FK'][$j]['Reference']];
            }
        } else {
            // On récupère les FK dans un tableau
            $tableNameArr[] = $myArray['Table'][$i]['Name'];
            $tabFK[] = [$myArray['Table'][$i]['FK']['Key'], $myArray['Table'][$i]['FK']['Reference']];
        }
    }

    // on affiche la table et ses attributs
    $SQLSnippet .= 
          "\n\n#========================================\n"
        . "# Table : " . $myArray['Table'][$i]['Name']
        . "\n#========================================\n"
        . "CREATE TABLE " . $myArray['Table'][$i]['Name'] . "(\n";


    if (strpos($myArray['Table'][$i]['PK']['Key'],",") != false)
    {
        // Ici on met une nouvelle primary key quand c'est une table associative mais il faut quand même check apres si on nous envoie encore des INT AUTO_INCREMENT pourles tranformaer en INT
        $SQLSnippet .= "\t" . "id".$myArray['Table'][$i]['Name']." INT AUTO_INCREMENT PRIMARY KEY ,";

        if ($myArray['Table'][$i]['Column'][0]['Type'] == "INT AUTO_INCREMENT") {
            $SQLSnippet .= "\n\t" . $myArray['Table'][$i]['Column'][0]['Name'] . " INT ";
        } else {
            $SQLSnippet .= "\t" . $myArray['Table'][$i]['Column'][0]['Name'] . " " . $myArray['Table'][$i]['Column'][0]['Type'];
        }
    }else {
    // Le premier attribut c'est forcément un id MAIS on verifie si celle ci est un int AUTO_INCREMENT sinon c'est un id Naturel d
    // A VOIR ICI SI C'EST UN ID NATUREL EST IL UNE PRIMARY KEY ?
    if ($myArray['Table'][$i]['Column'][0]['Type'] == "INT AUTO_INCREMENT") {
        $SQLSnippet .= "\t" . $myArray['Table'][$i]['Column'][0]['Name'] . " " . $myArray['Table'][$i]['Column'][0]['Type'] . " PRIMARY KEY";
    } else {
        $SQLSnippet .= "\t" . $myArray['Table'][$i]['Column'][0]['Name'] . " " . $myArray['Table'][$i]['Column'][0]['Type'];
    }
}
    for ($g = 1; $g < count($myArray['Table'][$i]['Column']); $g++) {
        
        if ($g < count($myArray['Table'][$i]['Column'])) {
            $SQLSnippet .= " ,";
        }

        // Quand un MLD fait mets un FK dans une table il le type en INT AUTO_INCREMENT sauf que c'est une FK on veut juste le typer en INT donc on verifie ici.
        if ($myArray['Table'][$i]['Column'][$g]['Type'] == "INT AUTO_INCREMENT") {
            $SQLSnippet .= "\n\t" . $myArray['Table'][$i]['Column'][$g]['Name'] . " INT ";
        } else {
            $SQLSnippet .= "\n\t" . $myArray['Table'][$i]['Column'][$g]['Name'] . " " . $myArray['Table'][$i]['Column'][$g]['Type'];
        }
        if (isset($myArray['Table'][$i]['Column'][$g]['Property'])) {
            $SQLSnippet .= ' '.$myArray['Table'][$i]['Column'][$g]['Property'];
        }
    }
    $SQLSnippet .= "\n)ENGINE = InnoDB;";

}


// On sépare pour les alter table
$SQLSnippet .= "\n";

for ($k = 0; $k < count($tableNameArr); $k++) {
    $SQLSnippet .= "\nALTER TABLE " . $tableNameArr[$k] . " ADD CONSTRAINT FK_" . $tableNameArr[$k] . "_" . stristr($tabFK[$k][1], "(", true) . " FOREIGN KEY(" . $tabFK[$k][0] . ") REFERENCES " . $tabFK[$k][1] . ";";
}

fputs($SQLFile, $SQLSnippet);

if (file_exists($fileName.'.sql'))
{
    echo'<h1>Le fichier a été généré avec succès.</h1>';
}
}

shell_exec('mysql.bat');

header("Refresh:3; url=index.php");
