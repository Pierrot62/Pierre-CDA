<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = Afpa_ObjectifsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="grid-columns-span-8">
<div class="bigEspace"></div>
</div>';

echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormAfpa_Objectifs&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="grid-columns-span-8">
<div class="espace"></div>
</div>';

echo '<div class="caseListe labelListe">Rendement</div>';
echo '<div class="caseListe labelListe">MaxNombreArretTemperature</div>';
echo '<div class="caseListe labelListe">MaxNombreArretDecibel</div>';
echo '<div class="caseListe labelListe">MaxPourcentDeclasses</div>';
echo '<div class="caseListe labelListe">Date</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div></div>';
echo '<div></div>';
echo '<div></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getRendement().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getMaxNombreArretTemperature().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getMaxNombreArretDecibel().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getMaxPourcentDeclasses().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getDate().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Objectifs&mode=Afficher&id='.$unObjet->getIdObjectif().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Objectifs&mode=Modifier&id='.$unObjet->getIdObjectif().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Objectifs&mode=Supprimer&id='.$unObjet->getIdObjectif().'"><i class="fas fa-trash-alt"></i></a></div>';
}
echo '<div class="grid-columns-span-8">
<div class="espace"></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';