<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ResultatsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe grid-columns-span-7">Liste des Resultats </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormResultats&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">Patient</div>';
echo '<div class="caseListe">Test</div>';
echo '<div class="caseListe">Date du test</div>';
echo '<div class="caseListe">Resultat du Test</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
$result = ($unObjet->getResultatTest() == 1) ? "Positif" : "Negatif";
echo '<div class="caseListe">'.UtilisateursManager::findById($unObjet->getIdUtilisateur())->getPrenom().'</div>';
echo '<div class="caseListe">'.TestsManager::findById($unObjet->getIdTest())->getLibelleTest().'</div>';
echo '<div class="caseListe">'.$unObjet->getDateTest().'</div>';
echo '<div class="caseListe">'.$result.'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormResultats&mode=Afficher&id='.$unObjet->getIdResultat().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormResultats&mode=Modifier&id='.$unObjet->getIdResultat().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormResultats&mode=Supprimer&id='.$unObjet->getIdResultat().'"><i class="fas fa-trash-alt"></i></a></div>';
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