<body class="colonne">
    <header>
        <div class="demi"></div>
        <div><img src="./IMG/Logo_afpa.jpg" alt=""></div>
        <div class="titre"><?php echo $titre; ?></div>
        <div class="colonne">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="texteColore">'.texte("bjr").' ' . $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=deconnection">'.texte("disconnectBtn").'</a></div>';
            } else {
                echo '<a href="index.php?page=connection">'.texte("connectBtn").'</a>';
            }
            ?>

        </div>
        <div class="demi"></div>
    </header>