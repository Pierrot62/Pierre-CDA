<?php

class Afpa_SeuilsManager 
{

	public static function add(Afpa_Seuils $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Seuils $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Seuils $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Seuils::getAttributes(),"Afpa_Seuils",["IdSeuil" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Seuils::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Seuils",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}