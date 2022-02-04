<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = DepartementsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-4 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-4">Liste des Departements </div>';
echo '<div class="caseListe grid-columns-span-4">
<div></div>
<div class="caseListe"><a href="index.php?page=FormDepartements&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">Libelle</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getLibelle().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormDepartements&mode=Afficher&id='.$unObjet->getIdDepartement().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormDepartements&mode=Modifier&id='.$unObjet->getIdDepartement().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormDepartements&mode=Supprimer&id='.$unObjet->getIdDepartement().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-4">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';