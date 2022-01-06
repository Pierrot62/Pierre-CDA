<?php

if (isset($_SESSION['utilisateur'])) {
    if ($_SESSION['utilisateur']->getRole() == 1) {

        $classeCouleur = "blue"; // l'admin voir les boutons bleu
    } else {
        $classeCouleur = "green"; //les utilisateurs Vert
    }

    echo '<nav>
    <button class="crudBtn crudBtnRetour ' . $classeCouleur . '"><a href="index.php?page=listeProduit">'.texte("navProductBtn").'</a></button>
    <button class="crudBtn crudBtnRetour ' . $classeCouleur . '"><a href="index.php?page=listeCategorie">'.texte("navCategoryBtn").'</a></button>
        </nav>';
}
