<?php

 echo '<main>';
	echo '<div class="flex-0-1"></div>';
	echo '<div>';
	$objets = Afpa_SeuilsManager::getList();
		//Création du template de la grid
		echo '<div class="grid-col-8 gridListe">';

			echo '<div class="grid-columns-span-8">
						<div class="bigEspace"></div>
  				  </div>';

			echo '<div class="grid-columns-span-8">
						<div></div>
						<div class="caseListe"><a href="index.php?page=FormAfpa_Seuils&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
						<div></div>
				  </div>';

			echo '<div class="grid-columns-span-8">
						<div class="espace"></div>
				  </div>';

			echo '<div class="caseListe labelListe">Nature</div>';
			echo '<div class="caseListe labelListe">Seuil Bas</div>';
			echo '<div class="caseListe labelListe">Seuil Haut</div>';
			echo '<div class="caseListe labelListe">Temps d\'arrêt (mins)</div>';
			echo '<div class="caseListe labelListe">Date</div>';


			//Remplissage de div vide pour la structure de la grid
			echo '<div></div>';
			echo '<div></div>';
			echo '<div></div>';

			// Affichage des ennregistrements de la base de données
			foreach($objets as $unObjet)
			{
				switch ($unObjet->getNature()) {
					case 1 :
						$nature = "Températures";
						break;
					case 2 :
						$nature = "Sons";
						break;
					case 3 :
						$nature = "Lumières";
						break;
					default:
						$nature = "";
						break;
				}

				echo '<div class="caseListe donneeListe">'.$nature.'</div>';
				echo '<div class="caseListe donneeListe">'.$unObjet->getSeuilBas().'</div>';
				echo '<div class="caseListe donneeListe">'.$unObjet->getSeuilHaut().'</div>';
				echo '<div class="caseListe donneeListe">'.$unObjet->getTemps().'</div>';
				echo '<div class="caseListe donneeListe">'.$unObjet->getDateSeuil().'</div>';
				echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Seuils&mode=Afficher&id='.$unObjet->getIdSeuil().'"><i class="fas fa-file-contract"></i></a></div>';
																	
				echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Seuils&mode=Modifier&id='.$unObjet->getIdSeuil().'"><i class="fas fa-pen"></i></a></div>';
																	
				echo '<div class="caseListe"> <a href="index.php?page=FormAfpa_Seuils&mode=Supprimer&id='.$unObjet->getIdSeuil().'"><i class="fas fa-trash-alt"></i></a></div>';
			}

			echo '<div class="grid-columns-span-8">
						<div class="espace"></div>
	  			  </div>';

		echo'</div>'; //Grid
	echo'</div>'; //Div
	echo '<div class="flex-0-1"></div>';
echo '</main>';