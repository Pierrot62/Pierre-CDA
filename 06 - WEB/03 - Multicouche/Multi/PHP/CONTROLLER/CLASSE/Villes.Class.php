<?php

class Villes 
{

	/*****************Attributs***************** */

	private $_IdVille;
	private $_NomVille;
	private $_IdDepartement;
	private static $_attributes=["IdVille","NomVille","IdDepartement"];
	/***************** Accesseurs ***************** */


	public function getIdVille()
	{
		return $this->_IdVille;
	}

	public function setIdVille(int $IdVille)
	{
		$this->_IdVille=$IdVille;
	}

	public function getNomVille()
	{
		return $this->_NomVille;
	}

	public function setNomVille(string $NomVille)
	{
		$this->_NomVille=$NomVille;
	}

	public function getIdDepartement()
	{
		return $this->_IdDepartement;
	}

	public function setIdDepartement(int $IdDepartement)
	{
		$this->_IdDepartement=$IdDepartement;
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
		return "IdVille : ".$this->getIdVille()."NomVille : ".$this->getNomVille()."IdDepartement : ".$this->getIdDepartement()."\n";
	}
}