<?php
$_POST["IdPanier"] = (int) $_POST["IdPanier"];
$elm = new LignesPaniers($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = LignesPaniersManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = LignesPaniersManager::update($elm);
		break;
	}
	case "Supprimer": {
		var_dump($elm);
		$elm = LignesPaniersManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeLignesPaniers&idPanier=".$_GET["_IdPanier"]."&idLigne=".$_GET["idLigne"]);