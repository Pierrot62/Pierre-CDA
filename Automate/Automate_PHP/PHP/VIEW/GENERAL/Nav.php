
 
 <nav  id ="menu" class=" invisible background Alan">
<ul>
<?php 
// echo $nom;
    if ($nom != "ListeAfpa_Anomalies") {
        echo '<li><a href=?page=ListeAfpa_Anomalies">Anomalies</a><li>';
    }
    if ($nom != "ListeAfpa_Seuils" && $_SESSION['utilisateur']->getRole() > 1) {
        echo '<li><a href="?page=ListeAfpa_Seuils">Seuils</a><li>';
    }
    if ($nom != "Accueil") {
    echo '<li><a href="?page=Accueil">Accueil</a><li>';
    }
    if ($nom != "ListeAfpa_Lumieres") {
        echo '<li><a href="?page=ListeAfpa_Lumieres">Lumieres</a><li>';
        }
    if ($nom != "ListeAfpa_Objectifs" && $_SESSION['utilisateur']->getRole() > 1) {
            echo '<li><a href="?page=ListeAfpa_Objectifs">Objectifs</a><li>';
        }
    if ($nom != "ListeAfpa_Sons") {
            echo '<li><a href="?page=ListeAfpa_Sons">Sons</a><li>';
    }
    if ($nom != "ListeAfpa_Temperatures") {
        echo '<li><a href="?page=ListeAfpa_Temperatures">Températures</a><li>';
}

    

?>


</ul>
</nav> 
</div>
