<?php

class VaccinsManager 
{

	public static function add(Vaccins $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Vaccins $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Vaccins $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Vaccins::getAttributes(),"Vaccins",["IdVaccin" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Vaccins::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Vaccins",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}