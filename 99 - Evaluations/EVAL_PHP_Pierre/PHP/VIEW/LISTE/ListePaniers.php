<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = PaniersManager::getList();
//Création du template de la grid
echo '<div class="grid-col-2 gridListe">';

echo '<div class="caseListe grid-columns-span-2">Liste des Paniers </div>';
echo '<div class="caseListe grid-columns-span-2">
<div></div>
<div></div>
<div></div>
</div>';

echo '<div class="caseListe">Client</div>';
echo '<div class="caseListe">Nombre d\'article</div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
$client = UtilisateursManager::findById($unObjet->getIdClient());
$panier = PaniersManager::findByIdClient($unObjet->getIdClient());
$ligne = LignesPaniersManager::getListByIdPaniers(null,["IdPanier" => $panier->getIdPanier()]);
echo '<div class="caseListe">'.$client->getPrenom().' '.$client->getNom().'</div>';
echo '<div class="caseListe">'.count($ligne).'</div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-2">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';