<?php
$elm = new Afpa_Cadences($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_CadencesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_CadencesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_CadencesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Cadences");