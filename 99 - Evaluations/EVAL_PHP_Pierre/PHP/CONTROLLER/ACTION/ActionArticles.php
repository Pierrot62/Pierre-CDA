<?php
$elm = new Articles($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		move_uploaded_file($_FILES["photos"]["tmp_name"],'./IMG/'.$_FILES["photos"]["name"]);
		$elm->setPhotos($_FILES["photos"]["name"]);
		var_dump($elm);
 		$elm = ArticlesManager::add($elm);
		break;
	}
	case "Modifier": {
		if ($_FILES["name"] != '') {
			$elm->setPhotos(ArticlesManager::findById($elm->getIdArticle())->getPhotos());
		}else{
			unlink("./IMG/".ArticlesManager::findById($elm->getIdArticle())->getPhotos());
			move_uploaded_file($_FILES["photos"][$elm->getLibelleArticle()],'./IMG/'.$_FILES["photos"][$elm->getLibelleArticle()]);
			$elm->setPhotos($_FILES["photos"]["name"]);
		}
		var_dump($elm);
		var_dump($_FILES);
		$elm = ArticlesManager::update($elm);
		break;
	}
	case "Supprimer": {
		unlink("./IMG/".ArticlesManager::findById($elm->getIdArticle())->getPhotos());
		$elm = ArticlesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeArticles");