<?php

class ResultatsManager 
{

	public static function add(Resultats $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Resultats $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Resultats $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Resultats::getAttributes(),"Resultats",["IdResultat" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Resultats::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Resultats",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}