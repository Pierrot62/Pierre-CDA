<body class="colonne ">
    <header class="background">
        <div class="demi Alan"></div>
        
        <div><img src="./IMG/pingouin.png" alt=""></div>
        <div class="titre"><?php echo $titre; ?></div>
        <div class="colonne">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center">'. texte("Deconnexion") .'</a></div>';
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
                echo '<a href="index.php?page=Inscription" class="center">'. texte("Inscription") .'</a>';
                echo '<div></div>';
            }
            ?>

        </div>
        <div class="demi">
        <?php
            //Si utilisateur est connecté affichage du menu.
            if (isset($_SESSION['utilisateur'])) {
                echo '<div id="menu-burger">
                    <div class="bar1"></div>
                    <div class="bar2"></div>
                    <div class="bar3"></div>
                </div>';
            }
        ?>
        </div>
    </header>
    <div class="relative">