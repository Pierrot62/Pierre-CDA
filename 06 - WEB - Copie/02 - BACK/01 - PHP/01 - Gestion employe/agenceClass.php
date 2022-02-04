<?php
class Agence
{

    /*****************Attributs***************** */
    private $_nom;
    private $_adresse;
    private $_codePostal;
    private $_ville;
    private $_restaurant;


    /*****************Accesseurs***************** */
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getAdresse()
    {
        return $this->_adresse;
    }

    public function setAdresse($adresse)
    {
        $this->_adresse = $adresse;
    }
    
    public function getCodePostal()
    {
        return $this->_codePostal;
    }

    public function setCodePostal($codePostal)
    {
        $this->_codePostal = $codePostal;
    }
    
    public function getVille()
    {
        return $this->_ville;
    }

    public function setVille($ville)
    {
        $this->_ville = $ville;
    }
    
    public function getRestaurant()
    {
        return $this->_restaurant;
    }

    public function setRestaurant(bool $restaurant)
    {
        $this->_restaurant = $restaurant;
    }
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    public static function compareToNomPrenom($e1, $e2){
        if ($e1->getNom() > $e2->getNom()) {
            return 1;   
        }
        else if ($e1->getNom() < $e2->getNom()) {
            return -1;
        }
        else if ($e1->getPrenom() > $e2->getPrenom()) {
            return 1;
        }   
        else if ($e1->getPrenom() < $e2->getPrenom()) {
            return -1;
        }
        return 0;
    }

    public static function compareToServiceNomPrenom($e1, $e2){
        if ($e1->getService() > $e2->getService()) {
            return 1;   
        }
        else if ($e1->getService() < $e2->getService()) {
            return -1;
        }
        else{
            return self::compareToNomPrenom($e1,$e2);
        } 
    }

    /*****************Autres Méthodes***************** */

    public function anciennete(){
        $auj = new DateTime('now');
        return  date_diff($this->getDateEmbauche(),$auj)->format("%y");
    }

    public function calculPrime(){
        $auj = new DateTime('now');
        $montantPrime = (5 * $this->getSalaire()) /100; 
        $montantPrimeAnciennete = (2 * $this->getSalaire()) / 100 * $this->anciennete();
        $prime = $montantPrimeAnciennete + $montantPrime;
        if ($auj[1] == 11 && $auj[0] == 30) {
            echo "Une prime de ". $prime ."Euros vien de vous etre envoyer";
        }
    }
}
