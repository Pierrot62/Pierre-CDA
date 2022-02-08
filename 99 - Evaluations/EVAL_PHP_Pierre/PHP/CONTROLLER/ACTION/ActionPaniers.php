<?php
$elm = new Paniers($_POST);
var_dump($_SESSION);
switch ($_GET['mode']) {
	case "Ajouter": {
		$panier = PaniersManager::getList(null,["idClient" => $_SESSION["utilisateur"]->getIdUtilisateur()]);
		var_dump($panier);
		if (count($panier) == 0) {
			echo'TOTO';
			$elm->setIdClient($_SESSION["utilisateur"]->getIdUtilisateur());
			// $elm->
			var_dump($elm);
			PaniersManager::add($elm);

			$ligne = new LignesPaniers();
			$ligne->setIdArticle($_GET["id"]);
			var_dump($ligne);

			$ligne->setIdPanier($panier[0]->getIdPanier());
			$ligne->setQuantite(1);
			var_dump($ligne);
			$ligne = LignesPaniersManager::add($ligne);
			$elm = PaniersManager::add($elm);
			
			header('location:index.php?page=ListeLignesPaniers&idPanier='.$elm->getIdPanier());
		}else{
			$artile = ArticlesManager::findById($_GET["id"]);
			$ligne = new LignesPaniers();
			$ligne->setIdArticle($_GET["id"]);
			$ligne->setIdPanier($elm->getIdPanier());
			$ligne->setQuantite(1);
			var_dump($ligne);
			$ligne = LignesPaniersManager::add($ligne);

			header('location:index.php?page=ListeLignesPaniers&idPanier='.$elm->getIdPanier());
		}
		break;
	}
	case "Modifier": {
		$elm = PaniersManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PaniersManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePaniers");