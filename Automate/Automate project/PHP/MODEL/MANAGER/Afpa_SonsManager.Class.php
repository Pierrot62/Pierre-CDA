<?php

class Afpa_SonsManager 
{

	public static function add(Afpa_Sons $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Sons $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Sons $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Sons::getAttributes(),"Afpa_Sons",["IdSon" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Sons::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Sons",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}