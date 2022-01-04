<?php
class Employer
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_fonction;
    private $_salaire;
    private $_service;
    private $_agence;
    private $_enfant = [];

    /*****************Accesseurs***************** */

    // Nom
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = strtoUpper($nom);
    }

    // prenom
    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    // date embauche
    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche($dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    // fonction
    public function getFonction()
    {
        return $this->_fonction;
    }

    public function setFonction($fonction)
    {
        $this->_fonction = $fonction;
    }

    // Salaire
    public function getSalaire()
    {
        return $this->_salaire;
    }

    public function setSalaire($salaire)
    {
        $this->_salaire = $salaire;
    }

    // Service
    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }
    
    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence($agence)
    {
        $this->_agence = $agence;
    }
    
    public function getEnfant()
    {
        return $this->_enfant;
    }

    public function setEnfant($enfant)
    {
        $this->_enfant = $enfant;
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

    public function chequeVacances(){
        if ($this->anciennete() > 1) {
            return true;
        }
    }

    public function chequeNoel(){
        $tab = ["20" => 0, "30" => 0, "50" => 0];
        foreach ($this->getEnfant() as $enf) {
            if ($enf->chequeNoel() != 0) {
                $tab[$enf->chequeNoel()]+=1;
            }
        }
       return $tab;
    }

}
