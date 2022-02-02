<?php
$elm = new Afpa_Seuils($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_SeuilsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_SeuilsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_SeuilsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Seuils");