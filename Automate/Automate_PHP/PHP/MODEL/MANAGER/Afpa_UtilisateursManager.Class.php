<?php

class Afpa_UtilisateursManager 
{

	public static function add(Afpa_Utilisateurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Utilisateurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Utilisateurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Utilisateurs::getAttributes(),"Afpa_Utilisateurs",["idUtilisateur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Utilisateurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Utilisateurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}