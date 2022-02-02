<?php

class Afpa_Temperatures 
{

	/*****************Attributs***************** */

	private $_IdTemperature;
	private $_ValeurTemperature;
	private $_DateTemperature;
	private static $_attributes=["IdTemperature","ValeurTemperature","DateTemperature"];
	/***************** Accesseurs ***************** */


	public function getIdTemperature()
	{
		return $this->_IdTemperature;
	}

	public function setIdTemperature(?int $IdTemperature)
	{
		$this->_IdTemperature=$IdTemperature;
	}

	public function getValeurTemperature()
	{
		return $this->_ValeurTemperature;
	}

	public function setValeurTemperature(?float $ValeurTemperature)
	{
		$this->_ValeurTemperature=$ValeurTemperature;
	}

	public function getDateTemperature()
	{
		return is_null($this->_DateTemperature)?null:$this->_DateTemperature->format('Y-n-j H:i:s');
	}

	public function setDateTemperature(?string $DateTemperature)
	{
		$this->_DateTemperature=is_null($DateTemperature)?null:DateTime::createFromFormat("Y-n-j H:i:s",$DateTemperature);
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
		return "IdTemperature : ".$this->getIdTemperature()."ValeurTemperature : ".$this->getValeurTemperature()."DateTemperature : ".$this->getDateTemperature()."\n";
	}
}