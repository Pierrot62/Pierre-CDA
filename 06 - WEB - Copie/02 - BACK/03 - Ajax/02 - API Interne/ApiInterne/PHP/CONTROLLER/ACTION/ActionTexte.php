<?php
$elm = new Texte($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TexteManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TexteManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TexteManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTexte");