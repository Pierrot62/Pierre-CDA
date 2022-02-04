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
	$elm = TexteManager::findById($_GET['id']);
} else {
	$elm = new Texte();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionTexte&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Texte</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdTexte().'" name=IdTexte></div>';
echo '<label for=CodeTexte class="caseForm labelForm">'.texte("CodeTexte").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getCodeTexte().'" name=CodeTexte pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Fr class="caseForm labelForm">'.texte("Fr").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getFr().'" name=Fr pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=En class="caseForm labelForm">'.texte("En").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getEn().'" name=En pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeTexte"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';