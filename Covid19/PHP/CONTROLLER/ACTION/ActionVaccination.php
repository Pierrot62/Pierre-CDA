<?php
$elm = new Vaccination($_POST);
$elm->setDateVaccination($elm->getDateVaccination()->format("Y-m-d"));

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = VaccinationManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = VaccinationManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = VaccinationManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeVaccination");