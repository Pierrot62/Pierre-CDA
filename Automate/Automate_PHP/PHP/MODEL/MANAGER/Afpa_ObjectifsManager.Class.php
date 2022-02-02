<?php

class Afpa_ObjectifsManager 
{

	public static function add(Afpa_Objectifs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Objectifs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Objectifs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Objectifs::getAttributes(),"Afpa_Objectifs",["IdObjectif" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Objectifs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Objectifs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}