<?php

class TestsManager 
{

	public static function add(Tests $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Tests $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Tests $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Tests::getAttributes(),"Tests",["IdTest" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Tests::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Tests",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}