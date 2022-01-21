<?php

class Resultats 
{

	/*****************Attributs***************** */

	private $_IdResultat;
	private $_IdUtilisateur;
	private $_IdTest;
	private $_DateTest;
	private $_ResultatTest;
	private static $_attributes=["IdResultat","IdUtilisateur","IdTest","DateTest","ResultatTest"];
	/***************** Accesseurs ***************** */


	public function getIdResultat()
	{
		return $this->_IdResultat;
	}

	public function setIdResultat(int $IdResultat)
	{
		$this->_IdResultat=$IdResultat;
	}

	public function getIdUtilisateur()
	{
		return $this->_IdUtilisateur;
	}

	public function setIdUtilisateur(?int $IdUtilisateur)
	{
		$this->_IdUtilisateur=$IdUtilisateur;
	}

	public function getIdTest()
	{
		return $this->_IdTest;
	}

	public function setIdTest(?int $IdTest)
	{
		$this->_IdTest=$IdTest;
	}

	public function getDateTest()
	{
		return is_null($this->_DateTest)?null:$this->_DateTest->format('Y-n-j');
	}

	public function setDateTest(?string $DateTest)
	{
		$this->_DateTest=is_null($DateTest)?null:DateTime::createFromFormat("Y-n-j",$DateTest);
	}

	public function getResultatTest()
	{
		return $this->_ResultatTest;
	}

	public function setResultatTest(?int $ResultatTest)
	{
		$this->_ResultatTest=$ResultatTest;
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
		return "IdResultat : ".$this->getIdResultat()."IdUtilisateur : ".$this->getIdUtilisateur()."IdTest : ".$this->getIdTest()."DateTest : ".$this->getDateTest()."ResultatTest : ".$this->getResultatTest()."\n";
	}
}