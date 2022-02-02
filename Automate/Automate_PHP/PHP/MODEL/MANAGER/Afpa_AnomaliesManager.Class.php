<?php

class Afpa_AnomaliesManager 
{

	public static function add(Afpa_Anomalies $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Afpa_Anomalies $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Afpa_Anomalies $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Afpa_Anomalies::getAttributes(),"Afpa_Anomalies",["IdAnomalie" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Afpa_Anomalies::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Afpa_Anomalies",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}