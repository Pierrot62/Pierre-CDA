<?php
$elm = new Afpa_Lumieres($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_LumieresManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_LumieresManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_LumieresManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Lumieres");