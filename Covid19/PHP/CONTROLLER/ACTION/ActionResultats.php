<?php
$elm = new Resultats($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ResultatsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ResultatsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ResultatsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeResultats");