<?php
$elm = new Afpa_Anomalies($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Afpa_AnomaliesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Afpa_AnomaliesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Afpa_AnomaliesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAfpa_Anomalies");