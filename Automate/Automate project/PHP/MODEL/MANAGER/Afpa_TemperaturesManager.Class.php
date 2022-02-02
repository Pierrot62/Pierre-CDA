<?php

class Afpa_TemperaturesManager 
{

	public static function add(Afpa_Temperatures $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Temperatures $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Temperatures $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Temperatures::getAttributes(),"Afpa_Temperatures",["IdTemperature" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Temperatures::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Temperatures",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}