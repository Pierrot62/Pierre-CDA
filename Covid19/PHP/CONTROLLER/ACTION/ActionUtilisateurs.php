<?php
$elm = new Utilisateurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm->setMotDePasse(crypte($elm->getMotDePasse()));
		$elm = UtilisateursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm->setMotDePasse(crypte($elm->getMotDePasse()));
		$elm = UtilisateursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = UtilisateursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUtilisateurs");