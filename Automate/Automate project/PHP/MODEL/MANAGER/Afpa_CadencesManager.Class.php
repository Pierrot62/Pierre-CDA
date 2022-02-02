<?php

class Afpa_CadencesManager 
{

	public static function add(Afpa_Cadences $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Cadences $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Cadences $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Cadences::getAttributes(),"Afpa_Cadences",["IdCadence" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Cadences::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Cadences",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}