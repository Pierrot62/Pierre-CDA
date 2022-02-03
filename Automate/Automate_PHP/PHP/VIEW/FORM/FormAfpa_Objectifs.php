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
	$elm = Afpa_ObjectifsManager::findById($_GET['id']);
} else {
	$elm = new Afpa_Objectifs();
}

echo '<main class="colonne">';
echo '<div class="bigEspace"></div>';
echo '<div>';
	echo '<div class="mini"></div>';
	echo '<div class="border center">';
		echo '<form class="GridFormSeuil" action="index.php?page=ActionAfpa_Objectifs&mode='.$_GET['mode'].'" method="post"/>';

			echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdObjectif().'" name=IdObjectif></div>';
			//ligne 1
			echo '<div class="caseForm donneeForm grid-columns-span-9">';
			echo '<label for=Rendement class="caseForm labelForm">'.texte("Rendement moyen").'</label>';
			echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getRendement().'" name=Rendement  pattern="'.$regex["num"].'" required ></div>';
				echo '<select name="multiplicateur" '.$disabled.' required>';
					echo '<option value="1" "Selected">/jour</option>';
					echo '<option value="24">/heure</option>';
					echo '<option value="1440">/min</option>';
				echo '</select>';
			echo '</div>';
			
			//ligne 2
			echo '<fieldset class="grid-columns-span-9 fieldsetFormSeuil">';
				echo '<legend>Max  nombre d\'arrêt</legend>';

				echo '<div class="phoneCol">';
					echo '<div>';
						echo '<label for=MaxNombreArretTemperature class="caseForm labelForm">'.texte("Temperature").'</label>';
						echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getMaxNombreArretTemperature().'" name=MaxNombreArretTemperature  pattern="'.$regex["num"].'" required ></div>';
						echo '<div class="center">°C</div>';
					echo '</div>';

					echo '<div class="demi espace"></div>';

					echo '<div>';
						echo '<label for=MaxNombreArretDecibel class="caseForm labelForm">'.texte("Sons").'</label>';
						echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getMaxNombreArretDecibel().'" name=MaxNombreArretDecibel pattern="'.$regex["num"].'" required ></div>';
						echo '<div class="center">Db</div>';
					echo '</div>';
				echo '</div>';
			echo '</fieldset>';

			//ligne 3
			$dateDuJour = new DateTime('NOW');
			echo '<label for=Date class="caseForm labelForm">'.texte("Date").'</label>';
			echo '<div class="caseForm donneeForm grid-columns-span-3"><input type="date" '.$disabled .'value="'.$elm->getDate().'" min="'.$dateDuJour->format('Y-m-d').'" name=Date pattern="'.$regex["date"].'" required ></div>';
			echo '<div></div>';
			echo '<label for=MaxPourcentDeclasses class="caseForm labelForm">'.texte("Déclassés Autorisés").'</label>';
			echo '<div class="caseForm donneeForm grid-columns-span-3"><input type="text" '.$disabled .'value="'.$elm->getMaxPourcentDeclasses().'" name=MaxPourcentDeclasses pattern="'.$regex["num"].'" required ><div class="center">%</div></div>';

			echo '<div class="grid-columns-span-9"></div>';
			echo '<div class="caseForm grid-columns-span-9">
					<div></div>
						<div><a href="index.php?page=ListeAfpa_Objectifs"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
						<div class="flex-0-1"></div>';
						echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
					echo'<div></div>
					</div>';

		echo'</form>';
	echo '</div>';
	echo '<div class="mini"></div>';
echo '</div>';
echo '</main>';