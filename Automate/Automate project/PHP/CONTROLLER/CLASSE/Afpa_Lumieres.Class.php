<?php

class Afpa_Lumieres 
{

	/*****************Attributs***************** */

	private $_IdLumiere;
	private $_ValeurLumiere;
	private $_DateLumiere;
	private static $_attributes=["IdLumiere","ValeurLumiere","DateLumiere"];
	/***************** Accesseurs ***************** */


	public function getIdLumiere()
	{
		return $this->_IdLumiere;
	}

	public function setIdLumiere(?int $IdLumiere)
	{
		$this->_IdLumiere=$IdLumiere;
	}

	public function getValeurLumiere()
	{
		return $this->_ValeurLumiere;
	}

	public function setValeurLumiere(?int $ValeurLumiere)
	{
		$this->_ValeurLumiere=$ValeurLumiere;
	}

	public function getDateLumiere()
	{
		return is_null($this->_DateLumiere)?null:$this->_DateLumiere->format('Y-n-j H:i:s');
	}

	public function setDateLumiere(?string $DateLumiere)
	{
		$this->_DateLumiere=is_null($DateLumiere)?null:DateTime::createFromFormat("Y-n-j H:i:s",$DateLumiere);
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
		return "IdLumiere : ".$this->getIdLumiere()."ValeurLumiere : ".$this->getValeurLumiere()."DateLumiere : ".$this->getDateLumiere()."\n";
	}
}