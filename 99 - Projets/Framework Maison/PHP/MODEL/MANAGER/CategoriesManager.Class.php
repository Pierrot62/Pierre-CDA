<?php


class CategoriesManager 
{
	public static function add(Categories $obj)
	{
		Services::add($obj);
	}

	public static function update(Categories $obj)
	{

		Services::update($obj);
	}
	public static function delete(Categories $obj)
	{

		Services::delete($obj);
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Categories WHERE idCategorie =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Categories($results);
		}
		else
		{
			return false;
		}
	}
	public static function getList()
	{
 		$db=DbConnect::getDb();
		$liste = [];
		$q = $db->query("SELECT * FROM Categories");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Categories($donnees);
			}
		}
		return $liste;
	}
}