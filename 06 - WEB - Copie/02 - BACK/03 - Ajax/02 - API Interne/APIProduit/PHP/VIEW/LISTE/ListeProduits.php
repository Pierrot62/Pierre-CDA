<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = ProduitsManager::getList();
$categ = CategoriesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-7 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-7">Liste des Produits </div>';
echo '<div class="caseListe grid-columns-span-7">
<div class="caseListe"><a href="index.php?page=FormProduits&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>';
echo '<select id="selectCateg" />';
for ($i=0; $i < count($categ) ; $i++) { 
	echo'<option value="'.$categ[$i]->getIdCategorie().'"/> '.$categ[$i]->getLibelleCategorie();
}
echo '</select>';
echo '</div>';

echo '<div class="caseListe labelListe">LibelleProduit</div>';
echo '<div class="caseListe labelListe">Prix</div>';
echo '<div class="caseListe labelListe">DateDePeremption</div>';
echo '<div class="caseListe labelListe">IdCategorie</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<template class="temp">';
echo '<div class="caseListe donneeListe ligne"></div>';
echo '<div class="caseListe donneeListe ligne"></div>';
echo '<div class="caseListe donneeListe ligne"></div>';
echo '<div class="caseListe donneeListe ligne"></div>';
echo '<div class="caseListe btn ligne"> <a href="index.php?page=FormProduits&mode=Afficher&id='.$unObjet->getIdProduit().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe btn ligne"> <a href="index.php?page=FormProduits&mode=Modifier&id='.$unObjet->getIdProduit().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe btn ligne"> <a href="index.php?page=FormProduits&mode=Supprimer&id='.$unObjet->getIdProduit().'"><i class="fas fa-trash-alt"></i></a></div>';
echo'</template>';
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