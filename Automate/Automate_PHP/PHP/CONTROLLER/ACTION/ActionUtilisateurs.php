<?php
$elm = new Afpa_Utilisateurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_UtilisateursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_UtilisateursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_UtilisateursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUtilisateurs");