<?php
$elm = new Villes($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = VillesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = VillesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = VillesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeVilles");