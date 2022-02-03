<?php
global $regex;

if ($_POST['motDePasse'] == $_POST['confirmPassword']) {
    $adresseUsed = Afpa_UtilisateursManager::getList(['adresseMail'],['adresseMail' => $_POST['adresseMail']]);
     if($adresseUsed == null && preg_match('/'.$regex["email"].'/', $_POST['adresseMail']) == 1){
        $u = new Afpa_Utilisateurs($_POST);
        $u -> setRole(1);
        $u->setMotDePasse(crypte($u->getMotDePasse()));
        Afpa_UtilisateursManager::add($u);
        $_SESSION['utilisateur'] = $u;
        header("location:index.php?page=Accueil");
     }
     else {
        header("location:index.php?page=Default");
    }
} else {
    header("location:index.php?page=Default");
}


