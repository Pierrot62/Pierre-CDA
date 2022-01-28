<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

// $objets = VillesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-5 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-5">Liste des Villes </div>';
echo '<div class="caseListe grid-columns-span-5">
<div class="caseListe btnAdd"><a href="index.php?page=FormVilles&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<select id="selectDep"></select>
</div>';

echo '<div class="caseListe labelListe">NomVille</div>';
echo '<div class="caseListe labelListe">IdDepartement</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe">Afficher</div>';
echo '<div class="caseListe">Modifier</div>';
echo '<div class="caseListe">Supprimer</div>';

//Affichage des ennregistrements de la base de données

//Template d'affichage
echo '<template class="liste">';
echo '<div class="caseListe donneeListe"></div>';
echo '<div class="caseListe donneeListe"></div>';

echo '<div class="caseListe"> <a href="index.php?page=FormVilles&mode=Afficher&id="><i class="fas fa-file-contract"></i></a></div>';

echo '<div class="caseListe btnEdit"><a href="index.php?page=FormVilles&mode=Modifier&id="><i class="fas fa-pen"></i></a></div>';

echo '<div class="caseListe btnDel"><i class="fas fa-trash-alt"></i></div>';

echo '</template>';

//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-5">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';