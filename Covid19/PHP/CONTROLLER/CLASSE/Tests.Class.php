<?php

class Tests 
{

	/*****************Attributs***************** */

	private $_IdTest;
	private $_LibelleTest;
	private $_PrixTest;
	private static $_attributes=["IdTest","LibelleTest","PrixTest"];
	/***************** Accesseurs ***************** */


	public function getIdTest()
	{
		return $this->_IdTest;
	}

	public function setIdTest(int $IdTest)
	{
		$this->_IdTest=$IdTest;
	}

	public function getLibelleTest()
	{
		return $this->_LibelleTest;
	}

	public function setLibelleTest(?string $LibelleTest)
	{
		$this->_LibelleTest=$LibelleTest;
	}

	public function getPrixTest()
	{
		return $this->_PrixTest;
	}

	public function setPrixTest(?float $PrixTest)
	{
		$this->_PrixTest=$PrixTest;
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
		return "IdTest : ".$this->getIdTest()."LibelleTest : ".$this->getLibelleTest()."PrixTest : ".$this->getPrixTest()."\n";
	}
}