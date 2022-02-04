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

echo '<div class="caseForm col-span-form">Formulaire Texte</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdTexte().'" name=IdTexte></div>';
};
echo '<div class="caseForm">CodeTexte</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getCodeTexte(); echo ' name=CodeTexte pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">Fr</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getFr(); echo ' name=Fr pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">En</div>';
echo '<div class="caseForm"><input type="text" '.$disabled;
echo ($mode == "Ajouter") ? "" : " value=".$elm->getEn(); echo ' name=En pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeTexte"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';