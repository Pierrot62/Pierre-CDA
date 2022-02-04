<?php
class Enfant
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_ddn;

    /*****************Accesseurs***************** */
   public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }
    
    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }
    
    public function getDdn()
    {
        return $this->_ddn;
    }

    public function setDdn($ddn)
    {
        $this->_ddn = $ddn;
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

    /*****************Autres Méthodes***************** */

    public function ageEnfant(){
        $auj = new DateTime('now');
        return date_diff($this->getDdn(),$auj)->format("%y");
    }
    public function chequeNoel(){
        $age = $this->ageEnfant();
        if ($age <= 10) {
            return 20;
        }else if($age >= 11 && $age <= 15){
            return 30;
        }else if ($age >= 15 && $age <= 18) {
            return 50;
        }else{
            return 0;
        }
    }
}
