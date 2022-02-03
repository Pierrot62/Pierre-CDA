<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

if (isset($_GET['id'])) {
	$elm = Afpa_SeuilsManager::findById($_GET['id']);
} else {
	$elm = new Afpa_Seuils();
}
echo '<main class="colonne">';
echo '<div class="bigEspace"></div>';
echo '<div>';
	echo '<div class="mini"></div>';
	echo '<div class="border center">';
		echo '<form class="GridFormSeuil" action="index.php?page=ActionAfpa_Seuils&mode='.$_GET['mode'].'" method="post"/>';

			echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdSeuil().'" name=IdSeuil></div>';
			//ligne 1
			echo '<div class="caseForm donneeForm grid-columns-span-9">';
				echo '<select name="nature" '.$disabled.' required>';
					echo '<option value="">Sélectionner un élément a qui appliqué le seuil</option>';
					echo '<option value="1" '. (($elm->getNature() == 1)?"Selected":"") .'>Températures</option>';
					echo '<option value="2" '. (($elm->getNature() == 2)?"Selected":"") .'>Sons</option>';
					echo '<option value="3" '. (($elm->getNature() == 3)?"Selected":"") .'>Lumières</option>';
				echo '</select>';
			echo '</div>';
			
			//ligne 2
			echo '<fieldset class="grid-columns-span-9 fieldsetFormSeuil">';
				echo '<legend>Seuil</legend>';

				echo '<div class="phoneCol">';
					echo '<div>';
						echo '<label for=SeuilBas class="caseForm labelForm">'.texte("Seuil Bas").'</label>';
						echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSeuilBas().'" name=SeuilBas pattern="'.$regex["num"].'" required ></div>';
						echo '<div class="center">°C</div>';
					echo '</div>';

					echo '<div class="demi espace"></div>';

					echo '<div>';
						echo '<label for=SeuilHaut class="caseForm labelForm">'.texte("Seuil Haut").'</label>';
						echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSeuilHaut().'" name=SeuilHaut pattern="'.$regex["num"].'" required ></div>';
						echo '<div class="center">°C</div>';
					echo '</div>';
				echo '</div>';
			echo '</fieldset>';

			//ligne 3
			$dateDuJour = new DateTime('NOW');
			echo '<label for=DateSeuil class="caseForm labelForm">'.texte("Date").'</label>';
			echo '<div class="caseForm donneeForm grid-columns-span-3"><input type="date" '.$disabled .'value="'.$elm->getDateSeuil().'" min="'.$dateDuJour->format('Y-m-d').'" name=DateSeuil pattern="'.$regex["date"].'" required ></div>';
			echo '<div></div>';
			echo '<label for=Temps class="caseForm labelForm">'.texte("Temps (mins)").'</label>';
			echo '<div class="caseForm donneeForm grid-columns-span-3"><input type="text" '.$disabled .'value="'.$elm->getTemps().'" name=Temps pattern="'.$regex["num"].'" required ></div>';

			echo '<div class="grid-columns-span-9"></div>';
			echo '<div class="caseForm grid-columns-span-9">
					<div></div>
						<div><a href="index.php?page=ListeAfpa_Seuils"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
						<div class="flex-0-1"></div>';
						echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
					echo'<div></div>
					</div>';

		echo'</form>';
	echo '</div>';
	echo '<div class="mini"></div>';
echo '</div>';
echo '</main>';