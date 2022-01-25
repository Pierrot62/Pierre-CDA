<?php

class Vaccination 
{

	/*****************Attributs***************** */

	private $_IdVaccination;
	private $_IdUtilisateur;
	private $_IdVaccin;
	private $_DateVaccination;
	private static $_attributes=["IdVaccination","IdUtilisateur","IdVaccin","DateVaccination"];
	/***************** Accesseurs ***************** */


	public function getIdVaccination()
	{
		return $this->_IdVaccination;
	}

	public function setIdVaccination(int $IdVaccination)
	{
		$this->_IdVaccination=$IdVaccination;
	}

	public function getIdUtilisateur()
	{
		return $this->_IdUtilisateur;
	}

	public function setIdUtilisateur(?int $IdUtilisateur)
	{
		$this->_IdUtilisateur=$IdUtilisateur;
	}

	public function getIdVaccin()
	{
		return $this->_IdVaccin;
	}

	public function setIdVaccin(?int $IdVaccin)
	{
		$this->_IdVaccin=$IdVaccin;
	}

	public function getDateVaccination()
	{
		return is_null($this->_DateVaccination)?null:$this->_DateVaccination->format('Y-n-j');
	}

	public function setDateVaccination(?string $DateVaccination)
	{
		$this->_DateVaccination=is_null($DateVaccination)?null:DateTime::createFromFormat("Y-n-j",$DateVaccination);
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
		return "IdVaccination : ".$this->getIdVaccination()."IdUtilisateur : ".$this->getIdUtilisateur()."IdVaccin : ".$this->getIdVaccin()."DateVaccination : ".$this->getDateVaccination()."\n";
	}
}