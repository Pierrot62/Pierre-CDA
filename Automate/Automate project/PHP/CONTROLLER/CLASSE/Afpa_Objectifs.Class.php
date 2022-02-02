<?php

class Afpa_Objectifs 
{

	/*****************Attributs***************** */

	private $_IdObjectif;
	private $_Rendement;
	private $_MaxNombreArretTemperature;
	private $_MaxNombreArretDecibel;
	private $_MaxPourcentDeclasses;
	private static $_attributes=["IdObjectif","Rendement","MaxNombreArretTemperature","MaxNombreArretDecibel","MaxPourcentDeclasses"];
	/***************** Accesseurs ***************** */


	public function getIdObjectif()
	{
		return $this->_IdObjectif;
	}

	public function setIdObjectif(?int $IdObjectif)
	{
		$this->_IdObjectif=$IdObjectif;
	}

	public function getRendement()
	{
		return $this->_Rendement;
	}

	public function setRendement(?int $Rendement)
	{
		$this->_Rendement=$Rendement;
	}

	public function getMaxNombreArretTemperature()
	{
		return $this->_MaxNombreArretTemperature;
	}

	public function setMaxNombreArretTemperature(?int $MaxNombreArretTemperature)
	{
		$this->_MaxNombreArretTemperature=$MaxNombreArretTemperature;
	}

	public function getMaxNombreArretDecibel()
	{
		return $this->_MaxNombreArretDecibel;
	}

	public function setMaxNombreArretDecibel(?int $MaxNombreArretDecibel)
	{
		$this->_MaxNombreArretDecibel=$MaxNombreArretDecibel;
	}

	public function getMaxPourcentDeclasses()
	{
		return $this->_MaxPourcentDeclasses;
	}

	public function setMaxPourcentDeclasses(?int $MaxPourcentDeclasses)
	{
		$this->_MaxPourcentDeclasses=$MaxPourcentDeclasses;
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
		return "IdObjectif : ".$this->getIdObjectif()."Rendement : ".$this->getRendement()."MaxNombreArretTemperature : ".$this->getMaxNombreArretTemperature()."MaxNombreArretDecibel : ".$this->getMaxNombreArretDecibel()."MaxPourcentDeclasses : ".$this->getMaxPourcentDeclasses()."\n";
	}
}