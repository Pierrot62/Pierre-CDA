<?php

echo '<main>';

if ($_GET["page"] == "ListeArticles") {
	echo '<div class="flex-0-1"></div>';

	echo '<div>';


	$objets = ArticlesManager::getList();

	//Création du template de la grid
	echo '<div class="grid-col-7-xl gridListe">';
	echo '<div class="caseListe grid-columns-span-7 titre">Catalogue</div>';


	// Affichage des ennregistrements de la base de données
	foreach ($objets as $value => $unObjet  ) {
		echo '<div></div>';
		echo '<div class="colonne articles">';
			echo '<div>';
				echo'<img src="./IMG/'.$unObjet->getPhotos().'"/>';
			echo'</div>';
			echo'<div class="infosArticle colonne">';
				echo'<div>';
					echo'<div class="mini">';
						echo'<p>'.$unObjet->getLibelleArticle().'</p>';
					echo'</div>';
					echo '<div class="mini"></div>';
					echo'<div class="mini">';
						echo'<p>'.$unObjet->getPrixArticle().'</p>';
					echo'</div>';
				echo'</div>';
			echo'</div>';
		echo'<div>';
	}
	//Derniere ligne du tableau (bouton retour)
	echo '<div class="caseListe grid-columns-span-6">
	<div></div>
	<div></div>
</div>';

	echo '</div>'; //Grid
	echo '</div>'; //Div
	echo '<div class="flex-0-1"></div>';
	echo '</main>';
} else if ($_GET["page"] == "ListeArticlesLigne") {
	echo '<div class="flex-0-1"></div>';

	echo '<div>';


	$objets = ArticlesManager::getList();
	//Création du template de la grid
	echo '<div class="grid-col-10 gridListe">';

	echo '<div class="caseListe grid-columns-span-10">Liste Articles</div>';
	echo '<div class="caseListe grid-columns-span-10">
   <div></div>
   <div></div>
   <div class="caseListe"><a href="index.php?page=FormArticles&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
   <div></div>
   <div></div>
   </div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="border caseListe">Libelle Article</div>';
	echo '<div class="border caseListe">Description</div>';
	echo '<div class="border caseListe">Prix</div>';
	echo '<div class="border caseListe">Type Article</div>';


	//Remplissage de div vide pour la structure de la grid
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';

	// Affichage des ennregistrements de la base de données
	foreach ($objets as $unObjet) {
		// var_dump($unObjet);
		echo '<div class="caseListe"></div>';
		echo '<div class="caseListe"><img src="./IMG/' . $unObjet->getPhotos() . '"/></div>';
		echo '<div class="caseListe">' . $unObjet->getLibelleArticle() . '</div>';
		echo '<div class="caseListe">' . $unObjet->getDescriptionArticle() . '</div>';
		echo '<div class="caseListe">' . $unObjet->getPrixArticle() . '</div>';
		echo '<div class="caseListe">' . TypesArticlesManager::findById($unObjet->getIdTypeArticle())->getLibelleTypeArticle() . '</div>';

		echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Afficher&id=' . $unObjet->getIdArticle() . '"><i class="fas fa-file-contract"></i></a></div>';

		echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Modifier&id=' . $unObjet->getIdArticle() . '"><i class="fas fa-pen"></i></a></div>';

		echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Supprimer&id=' . $unObjet->getIdArticle() . '"><i class="fas fa-trash-alt"></i></a></div>';
		echo '<div class="caseListe"></div>';
	}
	//Derniere ligne du tableau (bouton retour)
	echo '<div class="caseListe grid-columns-span-8">
	<div></div>
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	   <div></div>
   </div>';

	echo '</div>'; //Grid
	echo '</div>'; //Div
	echo '<div class="flex-0-1"></div>';
	echo '</main>';
}
