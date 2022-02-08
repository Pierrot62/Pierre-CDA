<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

if (isset($_GET['idLigne'])) {
	$elm = LignesPaniersManager::findById($_GET['idLigne']);
} else {
	$elm = new LignesPaniers();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionLignesPaniers&mode='.$_GET['mode'].'&idLigne='.$_GET["idLigne"].'&idPanier='.$_GET["idPanier"].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire LignesPaniers</div>';
if ($mode == "Modifier" || $mode == "Supprimer") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdLignePanier().'" name=IdLignePanier></div>';
}
echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdPanier().'" name=IdPanier></div>';
echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdArticle().'" name=IdArticle></div>';
echo '<div class="caseForm">Article</div>';
echo '<div class="caseForm">';
echo '<input type="text" '.$disabled.' value="'.ArticlesManager::findById($elm->getIdArticle())->getLibelleArticle().'"  pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';


echo '<div class="caseForm">Quantite</div>';
echo '<div class="caseForm"><input type="text" '.$disabled.' value="'.$elm->getQuantite().'" name=Quantite pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeLignesPaniers&idLigne='.$_GET["idLigne"].'&idPanier='.$_GET["idPanier"].'"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';