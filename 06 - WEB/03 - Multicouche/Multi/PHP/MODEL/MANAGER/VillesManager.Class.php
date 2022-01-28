<?php

class VillesManager 
{

	public static function add(Villes $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Villes $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Villes $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Villes::getAttributes(),"Villes",["IdVille" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Villes::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Villes",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}