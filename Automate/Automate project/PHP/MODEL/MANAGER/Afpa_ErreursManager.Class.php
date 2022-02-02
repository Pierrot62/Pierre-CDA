<?php

class Afpa_ErreursManager 
{

	public static function add(Afpa_Erreurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Erreurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Erreurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Erreurs::getAttributes(),"Afpa_Erreurs",["IdErreur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Erreurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Erreurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}