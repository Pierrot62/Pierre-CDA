<?php

class Afpa_Erreurs 
{

	/*****************Attributs***************** */

	private $_IdErreur;
	private $_MessageErreur;
	private static $_attributes=["IdErreur","MessageErreur"];
	/***************** Accesseurs ***************** */


	public function getIdErreur()
	{
		return $this->_IdErreur;
	}

	public function setIdErreur(int $IdErreur)
	{
		$this->_IdErreur=$IdErreur;
	}

	public function getMessageErreur()
	{
		return $this->_MessageErreur;
	}

	public function setMessageErreur(?string $MessageErreur)
	{
		$this->_MessageErreur=$MessageErreur;
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
		return "IdErreur : ".$this->getIdErreur()."MessageErreur : ".$this->getMessageErreur()."\n";
	}
}