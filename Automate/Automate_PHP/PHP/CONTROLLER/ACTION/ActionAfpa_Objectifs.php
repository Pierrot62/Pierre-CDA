<?php
$elm = new Afpa_Objectifs($_POST);
var_dump($elm);
$elm->setRendement($elm->getRendement()*$_POST["multiplicateur"]);
$elm->setDate($_POST["Date"]." 00:00:00");
var_dump($elm);
switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_ObjectifsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_ObjectifsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_ObjectifsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Objectifs");