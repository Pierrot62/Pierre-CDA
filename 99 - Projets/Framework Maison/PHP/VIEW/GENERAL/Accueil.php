<div class="demiPage">
<h2><?php echo texte("accueil")?></h2>
</div>


<?php
    $nomTable = "Produits";
    $req = services::tableSelect($nomTable);
    $limit = "1 , 3";
    echo services::limitSelect($req, $limit);
?>