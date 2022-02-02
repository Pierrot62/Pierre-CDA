<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TextesManager::checkIfLangExist($_GET['lang'])) {
	 // tester si la langue est gérée
	$_SESSION['lang'] = $_GET['lang'];
}else if (isset($_COOKIE['lang'])) {
	$_SESSION['lang'] = $_COOKIE['lang'];
}else{
	$_SESSION['lang'] = 'FR';
}
//Crée un cookie lang sur la machine de l'utilisateur d'une durée de 10h.
setcookie("lang", $_SESSION['lang'], time()+36000, '/');
/******Fin des langues******/

$routes=[
	"Default"=>["PHP/VIEW/FORM/","FormInscriptionConnexion","Connexion & Inscription",0,false],
	"Accueil"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],

	"ActionConnexion"=>["PHP/CONTROLLER/ACTION/","ActionConnexion","Action de la connexion",0,false],
	"ActionInscription"=>["PHP/CONTROLLER/ACTION/","ActionInscription","Action de l'inscription",0,false],
	"ActionDeconnexion"=>["PHP/CONTROLLER/ACTION/","ActionDeconnexion","Action de deconnexion",0,false],

	"ListeMailAPI"=>["PHP/MODEL/API/","ListeMailAPI", "ListeMailAPI",0,true],

	"ListeAfpa_Anomalies"=>["PHP/VIEW/LISTE/","ListeAfpa_Anomalies","Liste Afpa_Anomalies",0,false],
	"FormAfpa_Anomalies"=>["PHP/VIEW/FORM/","FormAfpa_Anomalies","Formulaire Afpa_Anomalies",0,false],
	"ActionAfpa_Anomalies"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Anomalies","Action Afpa_Anomalies",0,false],

	"ListeAfpa_Cadences"=>["PHP/VIEW/LISTE/","ListeAfpa_Cadences","Liste Afpa_Cadences",0,false],
	"FormAfpa_Cadences"=>["PHP/VIEW/FORM/","FormAfpa_Cadences","Formulaire Afpa_Cadences",0,false],
	"ActionAfpa_Cadences"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Cadences","Action Afpa_Cadences",0,false],

	"ListeAfpa_Couleurs"=>["PHP/VIEW/LISTE/","ListeAfpa_Couleurs","Liste Afpa_Couleurs",0,false],
	"FormAfpa_Couleurs"=>["PHP/VIEW/FORM/","FormAfpa_Couleurs","Formulaire Afpa_Couleurs",0,false],
	"ActionAfpa_Couleurs"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Couleurs","Action Afpa_Couleurs",0,false],

	"ListeAfpa_Erreurs"=>["PHP/VIEW/LISTE/","ListeAfpa_Erreurs","Liste Afpa_Erreurs",0,false],
	"FormAfpa_Erreurs"=>["PHP/VIEW/FORM/","FormAfpa_Erreurs","Formulaire Afpa_Erreurs",0,false],
	"ActionAfpa_Erreurs"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Erreurs","Action Afpa_Erreurs",0,false],

	"ListeAfpa_Lumieres"=>["PHP/VIEW/LISTE/","ListeAfpa_Lumieres","Liste Afpa_Lumieres",0,false],
	"FormAfpa_Lumieres"=>["PHP/VIEW/FORM/","FormAfpa_Lumieres","Formulaire Afpa_Lumieres",0,false],
	"ActionAfpa_Lumieres"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Lumieres","Action Afpa_Lumieres",0,false],

	"ListeAfpa_Objectifs"=>["PHP/VIEW/LISTE/","ListeAfpa_Objectifs","Liste Afpa_Objectifs",0,false],
	"FormAfpa_Objectifs"=>["PHP/VIEW/FORM/","FormAfpa_Objectifs","Formulaire Afpa_Objectifs",0,false],
	"ActionAfpa_Objectifs"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Objectifs","Action Afpa_Objectifs",0,false],

	"ListeAfpa_Seuils"=>["PHP/VIEW/LISTE/","ListeAfpa_Seuils","Liste Afpa_Seuils",0,false],
	"FormAfpa_Seuils"=>["PHP/VIEW/FORM/","FormAfpa_Seuils","Formulaire Afpa_Seuils",0,false],
	"ActionAfpa_Seuils"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Seuils","Action Afpa_Seuils",0,false],

	"ListeAfpa_Sons"=>["PHP/VIEW/LISTE/","ListeAfpa_Sons","Liste Afpa_Sons",0,false],
	"FormAfpa_Sons"=>["PHP/VIEW/FORM/","FormAfpa_Sons","Formulaire Afpa_Sons",0,false],
	"ActionAfpa_Sons"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Sons","Action Afpa_Sons",0,false],

	"ListeAfpa_Temperatures"=>["PHP/VIEW/LISTE/","ListeAfpa_Temperatures","Liste Afpa_Temperatures",0,false],
	"FormAfpa_Temperatures"=>["PHP/VIEW/FORM/","FormAfpa_Temperatures","Formulaire Afpa_Temperatures",0,false],
	"ActionAfpa_Temperatures"=>["PHP/CONTROLLER/ACTION/","ActionAfpa_Temperatures","Action Afpa_Temperatures",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

];

if(isset($_GET["page"]))
{

	$page=$_GET["page"];

	if(isset($routes[$page]))
	{
		AfficherPage($routes[$page]);
	}
	else
	{
		AfficherPage($routes["Default"]);
	}
}
else
{
	AfficherPage($routes["Default"]);
}