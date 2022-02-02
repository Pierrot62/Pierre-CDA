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
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionAfpa_Seuils&mode='.$_GET['mode'].'" method="post"/>';

	echo '<div class="caseForm titreForm col-span-form">Formulaire Afpa_Seuils</div>';
		echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdSeuil().'" name=IdSeuil></div>';
	echo '<label for=SeuilBas class="caseForm labelForm">'.texte("SeuilBas").'</label>';
	echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSeuilBas().'" name=SeuilBas pattern="'.$regex["*"].'"></div>';
	echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
	echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

	echo '<label for=SeuilHaut class="caseForm labelForm">'.texte("SeuilHaut").'</label>';
	echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSeuilHaut().'" name=SeuilHaut pattern="'.$regex["*"].'"></div>';
	echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
	echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

	echo '<label for=DateSeuil class="caseForm labelForm">'.texte("DateSeuil").'</label>';
	echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDateSeuil().'" name=DateSeuil pattern="'.$regex["*"].'"></div>';
	echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
	echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

	echo '<label for=Temps class="caseForm labelForm">'.texte("Temps").'</label>';
	echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getTemps().'" name=Temps pattern="'.$regex["*"].'"></div>';
	echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
	echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

	echo '<label for=Nature class="caseForm labelForm">'.texte("Nature").'</label>';
	echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getNature().'" name=Nature pattern="'.$regex["*"].'"></div>';
	echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
	echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

	echo '<div class="caseForm col-span-form">
		<div></div>
		<div><a href="index.php?page=ListeAfpa_Seuils"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
		<div class="flex-0-1"></div>';
		echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
		echo'<div></div>
		</div>';

echo'</form>';

echo '</main>';