<?php

class Afpa_Sons 
{

	/*****************Attributs***************** */

	private $_IdSon;
	private $_ValeurSon;
	private $_DateSon;
	private static $_attributes=["IdSon","ValeurSon","DateSon"];
	/***************** Accesseurs ***************** */


	public function getIdSon()
	{
		return $this->_IdSon;
	}

	public function setIdSon(int $IdSon)
	{
		$this->_IdSon=$IdSon;
	}

	public function getValeurSon()
	{
		return $this->_ValeurSon;
	}

	public function setValeurSon(?float $ValeurSon)
	{
		$this->_ValeurSon=$ValeurSon;
	}

	public function getDateSon()
	{
		return is_null($this->_DateSon)?null:$this->_DateSon->format('Y-n-j H:i:s');
	}

	public function setDateSon(?string $DateSon)
	{
		$this->_DateSon=is_null($DateSon)?null:DateTime::createFromFormat("Y-n-j H:i:s",$DateSon);
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
		return "IdSon : ".$this->getIdSon()."ValeurSon : ".$this->getValeurSon()."DateSon : ".$this->getDateSon()."\n";
	}
}