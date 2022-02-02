<?php

class Afpa_Couleurs 
{

	/*****************Attributs***************** */

	private $_IdCouleur;
	private $_Red;
	private $_Green;
	private $_Blue;
	private static $_attributes=["IdCouleur","Red","Green","Blue"];
	/***************** Accesseurs ***************** */


	public function getIdCouleur()
	{
		return $this->_IdCouleur;
	}

	public function setIdCouleur(int $IdCouleur)
	{
		$this->_IdCouleur=$IdCouleur;
	}

	public function getRed()
	{
		return $this->_Red;
	}

	public function setRed(?int $Red)
	{
		$this->_Red=$Red;
	}

	public function getGreen()
	{
		return $this->_Green;
	}

	public function setGreen(?int $Green)
	{
		$this->_Green=$Green;
	}

	public function getBlue()
	{
		return $this->_Blue;
	}

	public function setBlue(?int $Blue)
	{
		$this->_Blue=$Blue;
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
		return "IdCouleur : ".$this->getIdCouleur()."Red : ".$this->getRed()."Green : ".$this->getGreen()."Blue : ".$this->getBlue()."\n";
	}
}