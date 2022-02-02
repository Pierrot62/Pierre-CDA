<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = Afpa_AnomaliesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-7">Liste des Afpa_Anomalies </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormAfpa_Anomalies&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">DateAnomalie</div>';
echo '<div class="caseListe labelListe">TypeAnomalie</div>';
echo '<div class="caseListe labelListe">NbDeclasses</div>';
echo '<div class="caseListe labelListe">IdErreur</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getDateAnomalie().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getTypeAnomalie().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getNbDeclasses().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getIdErreur().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Anomalies&mode=Afficher&id='.$unObjet->getIdAnomalie().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Anomalies&mode=Modifier&id='.$unObjet->getIdAnomalie().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Anomalies&mode=Supprimer&id='.$unObjet->getIdAnomalie().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-7">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';