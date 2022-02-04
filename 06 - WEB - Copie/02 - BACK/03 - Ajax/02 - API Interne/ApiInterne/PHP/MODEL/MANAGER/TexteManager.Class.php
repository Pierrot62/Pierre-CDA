<?php

class TexteManager 
{

	public static function add(Texte $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Texte $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Texte $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Texte::getAttributes(),"Texte",["idTexte" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Texte::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Texte",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}