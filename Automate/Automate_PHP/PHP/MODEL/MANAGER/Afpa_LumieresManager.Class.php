<?php

class Afpa_LumieresManager 
{

	public static function add(Afpa_Lumieres $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Lumieres $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Lumieres $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Lumieres::getAttributes(),"Afpa_Lumieres",["IdLumiere" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Lumieres::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Lumieres",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}