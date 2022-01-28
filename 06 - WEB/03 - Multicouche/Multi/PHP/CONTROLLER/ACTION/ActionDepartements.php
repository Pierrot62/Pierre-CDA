<?php
$elm = new Departements($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = DepartementsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = DepartementsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = DepartementsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeDepartements");