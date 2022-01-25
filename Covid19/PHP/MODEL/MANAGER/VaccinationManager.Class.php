<?php

class VaccinationManager 
{

	public static function add(Vaccination $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Vaccination $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Vaccination $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Vaccination::getAttributes(),"Vaccination",["IdVaccination" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Vaccination::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Vaccination",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}