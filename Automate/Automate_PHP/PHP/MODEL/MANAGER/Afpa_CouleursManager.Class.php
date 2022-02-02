<?php

class Afpa_CouleursManager 
{

	public static function add(Afpa_Couleurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Couleurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Couleurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Couleurs::getAttributes(),"Afpa_Couleurs",["IdCouleur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Couleurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Couleurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}