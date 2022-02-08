<?php
if (isset($_SESSION["utilisateur"])) {
$role = $_SESSION["utilisateur"]->getRole();
echo'<nav>';
echo'<div></div>';
if ($role == 1) {
    echo'<div><a class="border" href=\'?page=ListeLignesPaniers\'>Paniers</a></div>';
    echo'<div><a class="border" href=\'?page=ListeArticles\'>Catalogue</a></div>';
}
else {    
    echo'<div><a class="border" href=\'?page=ListeArticlesLigne\'>Articles</a></div>';
    echo'<div><a class="border" href=\'?page=ListeTypesArticles\'>TypesArticles</a></div>';
    echo'<div><a class="border" href=\'?page=ListePaniers\'>Paniers</a></div>';
    echo'<div><a class="border" href=\'?page=ListeUtilisateurs\'>Client</a></div>';
    echo'<div><a class="border" href=\'?page=ListeArticles\'>Catalogue</a></div>';
}
echo'<div></div>';
echo'</nav>';
}