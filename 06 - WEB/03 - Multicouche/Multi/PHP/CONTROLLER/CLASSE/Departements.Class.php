<?php

class Departements 
{

	/*****************Attributs***************** */

	private $_IdDepartement;
	private $_Libelle;
	private static $_attributes=["IdDepartement","Libelle"];
	/***************** Accesseurs ***************** */


	public function getIdDepartement()
	{
		return $this->_IdDepartement;
	}

	public function setIdDepartement(int $IdDepartement)
	{
		$this->_IdDepartement=$IdDepartement;
	}

	public function getLibelle()
	{
		return $this->_Libelle;
	}

	public function setLibelle(string $Libelle)
	{
		$this->_Libelle=$Libelle;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
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
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdDepartement : ".$this->getIdDepartement()."Libelle : ".$this->getLibelle()."\n";
	}
}