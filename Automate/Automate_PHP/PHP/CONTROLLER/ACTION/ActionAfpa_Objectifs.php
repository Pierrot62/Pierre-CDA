<?php
$elm = new Afpa_Objectifs($_POST);

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