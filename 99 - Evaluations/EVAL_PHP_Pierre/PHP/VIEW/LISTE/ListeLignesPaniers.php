<?php

echo '<main>';

echo '<div class="flex-0-1"></div>';

echo '<div>';

if (!isset($_GET["idPanier"])) {
	$idPan = PaniersManager::findByIdClient($_SESSION["utilisateur"]->getIdUtilisateur())->getIdPanier();
} else {
	$idPan = $_GET['idPanier'];
}
$objets = LignesPaniersManager::getListByIdPaniers(null, ["IdPanier" => $idPan]);
if ($objets == null) {
	echo '<div><p>Pas de ligne dispo pour ce panier</p></div>';

} else {
	//Création du template de la grid
	echo '<div class="grid-col-4 gridListe">';

	echo '<div class="caseListe grid-columns-span-4">Liste des LignesPaniers </div>';
	echo '<div class="caseListe grid-columns-span-4">
<div></div>
<div></div>
<div></div>
</div>';

	echo '<div class="caseListe">Article</div>';
	echo '<div class="caseListe">Quantite</div>';

	//Remplissage de div vide pour la structure de la grid
	echo '<div class="caseListe"></div>';
	echo '<div class="caseListe"></div>';

	// Affichage des ennregistrements de la base de données
	foreach ($objets as $unObjet) {
		$article = ArticlesManager::findById($unObjet->getIdArticle());
		echo '<div class="caseListe">' . $article->getLibelleArticle() . '</div>';
		echo '<div class="caseListe">' . $unObjet->getQuantite() . '</div>';

		echo '<div class="caseListe"> <a href="index.php?page=FormLignesPaniers&mode=Modifier&idPanier=' . $idPan . '&idLigne=' . $unObjet->getIdLignePanier() . '"><i class="fas fa-pen"></i></a></div>';

		echo '<div class="caseListe"> <a href="index.php?page=FormLignesPaniers&mode=Supprimer&idPanier=' . $idPan . '&idLigne=' . $unObjet->getIdLignePanier() . '"><i class="fas fa-trash-alt"></i></a></div>';
	}
	//Derniere ligne du tableau (bouton retour)
	echo '<div class="caseListe grid-columns-span-4">
	<div></div>
	<a href="index.php?page=ListeArticles"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

	echo '</div>'; //Grid
	echo '</div>'; //Div
	echo '<div class="flex-0-1"></div>';
	echo '</main>';
}
