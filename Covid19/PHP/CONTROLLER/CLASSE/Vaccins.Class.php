<?php

class Vaccins 
{

	/*****************Attributs***************** */

	private $_IdVaccin;
	private $_LibelleVaccin;
	private static $_attributes=["IdVaccin","LibelleVaccin"];
	/***************** Accesseurs ***************** */


	public function getIdVaccin()
	{
		return $this->_IdVaccin;
	}

	public function setIdVaccin(int $IdVaccin)
	{
		$this->_IdVaccin=$IdVaccin;
	}

	public function getLibelleVaccin()
	{
		return $this->_LibelleVaccin;
	}

	public function setLibelleVaccin(?string $LibelleVaccin)
	{
		$this->_LibelleVaccin=$LibelleVaccin;
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
		return "IdVaccin : ".$this->getIdVaccin()."LibelleVaccin : ".$this->getLibelleVaccin()."\n";
	}
}