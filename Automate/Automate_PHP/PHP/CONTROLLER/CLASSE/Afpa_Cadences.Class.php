<?php

class Afpa_Cadences 
{

	/*****************Attributs***************** */

	private $_IdCadence;
	private $_NbProduit;
	private $_DateCadence;
	private static $_attributes=["IdCadence","NbProduit","DateCadence"];
	/***************** Accesseurs ***************** */


	public function getIdCadence()
	{
		return $this->_IdCadence;
	}

	public function setIdCadence(int $IdCadence)
	{
		$this->_IdCadence=$IdCadence;
	}

	public function getNbProduit()
	{
		return $this->_NbProduit;
	}

	public function setNbProduit(?int $NbProduit)
	{
		$this->_NbProduit=$NbProduit;
	}

	public function getDateCadence()
	{
		return is_null($this->_DateCadence)?null:$this->_DateCadence->format('Y-n-j H:i:s');
	}

	public function setDateCadence(?string $DateCadence)
	{
		$this->_DateCadence=is_null($DateCadence)?null:DateTime::createFromFormat("Y-n-j H:i:s",$DateCadence);
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
		return "IdCadence : ".$this->getIdCadence()."NbProduit : ".$this->getNbProduit()."DateCadence : ".$this->getDateCadence()."\n";
	}
}