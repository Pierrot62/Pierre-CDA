<?php
$elm = new Utilisateurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm->setRole(1);
		$elm->setMotDePasse(crypte(ucfirst($elm->getNom())."".ucfirst($elm->getPrenom())));
		$elm = UtilisateursManager::add($elm);
		
		break;
	}
	case "Modifier": {
		$elm->setMotDePasse(crypte(ucfirst($elm->getNom())."".ucfirst($elm->getPrenom())));
		$elm = UtilisateursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$panier = PaniersManager::findByIdClient($elm->getIdUtilisateur());
		$ligne = LignesPaniersManager::getListByIdPaniers(null,$panier->getIdPanier());
		for ($i=0; $i < count($ligne) ; $i++) { 
			LignesPaniersManager::delete($ligne[$i]);
		}
		PaniersManager::delete($panier);
		$elm = UtilisateursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUtilisateurs");