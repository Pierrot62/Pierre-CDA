<?php
$elm = new Afpa_Erreurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_ErreursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_ErreursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_ErreursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Erreurs");