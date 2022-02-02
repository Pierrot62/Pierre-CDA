<?php

class Afpa_Anomalies 
{

	/*****************Attributs***************** */

	private $_IdAnomalie;
	private $_DateAnomalie;
	private $_TypeAnomalie;
	private $_NbDeclasses;
	private $_IdErreur;
	private static $_attributes=["IdAnomalie","DateAnomalie","TypeAnomalie","NbDeclasses","IdErreur"];
	/***************** Accesseurs ***************** */


	public function getIdAnomalie()
	{
		return $this->_IdAnomalie;
	}

	public function setIdAnomalie(int $IdAnomalie)
	{
		$this->_IdAnomalie=$IdAnomalie;
	}

	public function getDateAnomalie()
	{
		return is_null($this->_DateAnomalie)?null:$this->_DateAnomalie->format('Y-n-j H:i:s');
	}

	public function setDateAnomalie(?string $DateAnomalie)
	{
		$this->_DateAnomalie=is_null($DateAnomalie)?null:DateTime::createFromFormat("Y-n-j H:i:s",$DateAnomalie);
	}

	public function getTypeAnomalie()
	{
		return $this->_TypeAnomalie;
	}

	public function setTypeAnomalie(?string $TypeAnomalie)
	{
		$this->_TypeAnomalie=$TypeAnomalie;
	}

	public function getNbDeclasses()
	{
		return $this->_NbDeclasses;
	}

	public function setNbDeclasses(?int $NbDeclasses)
	{
		$this->_NbDeclasses=$NbDeclasses;
	}

	public function getIdErreur()
	{
		return $this->_IdErreur;
	}

	public function setIdErreur(int $IdErreur)
	{
		$this->_IdErreur=$IdErreur;
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
		return "IdAnomalie : ".$this->getIdAnomalie()."DateAnomalie : ".$this->getDateAnomalie()."TypeAnomalie : ".$this->getTypeAnomalie()."NbDeclasses : ".$this->getNbDeclasses()."IdErreur : ".$this->getIdErreur()."\n";
	}
}