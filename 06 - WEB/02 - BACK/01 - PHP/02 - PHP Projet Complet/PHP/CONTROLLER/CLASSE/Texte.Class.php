<?php

class Texte
{

	/*****************Attributs***************** */

	private $_idTexte;
	private $_codeTexte;
	private $_FR;
	private $_EN;

	/***************** Accesseurs ***************** */

    public function getEN()
	{
		return $this->_EN;
	}

	public function setEN($EN)
	{
		$this->_EN = $EN;
	}

	public function getFR()
	{
		return $this->_FR;
	}

	public function setFR($FR)
	{
		$this->_FR = $FR;
	}

	public function getCodeTexte()
	{
		return $this->_codeTexte;
	}

	public function setCodeTexte($codeTexte)
	{
		$this->_codeTexte = $codeTexte;
	}

	public function getIdTexte()
	{
		return $this->_idTexte;
	}

	public function setIdTexte($idTexte)
	{
		$this->_idTexte = $idTexte;
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
				$this->$methode($value);
			}
		}
	}

}