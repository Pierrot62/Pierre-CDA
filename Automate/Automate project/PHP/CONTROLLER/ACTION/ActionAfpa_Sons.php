<?php
$elm = new Afpa_Sons($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_SonsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_SonsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_SonsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Sons");