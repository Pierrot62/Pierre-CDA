<?php
$elm = new Vaccins($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = VaccinsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = VaccinsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = VaccinsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeVaccins");