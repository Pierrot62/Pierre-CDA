<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = TexteManager::getList();
//Création du template de la grid
echo '<div class="grid-col-6 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-6">Liste des Texte </div>';
echo '<div class="caseListe grid-columns-span-6">
<div></div>
<div class="caseListe"><a href="index.php?page=FormTexte&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">CodeTexte</div>';
echo '<div class="caseListe labelListe">Fr</div>';
echo '<div class="caseListe labelListe">En</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getCodeTexte().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getFr().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getEn().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Afficher&id='.$unObjet->getIdTexte().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Modifier&id='.$unObjet->getIdTexte().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Supprimer&id='.$unObjet->getIdTexte().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-6">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';