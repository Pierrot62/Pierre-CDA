<?php
$elm = new Afpa_Couleurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_CouleursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_CouleursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_CouleursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Couleurs");