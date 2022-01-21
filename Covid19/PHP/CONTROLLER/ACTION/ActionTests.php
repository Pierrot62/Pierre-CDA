<?php
$elm = new Tests($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TestsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TestsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TestsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTests");