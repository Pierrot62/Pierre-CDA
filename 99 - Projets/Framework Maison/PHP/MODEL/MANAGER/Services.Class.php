<?php

class Services
{

    public static function add($obj)
    {
        $db = DbConnect::getDb();
        $class = get_class($obj);
        $colonnes = $class::getAttributes();
        $requ = "INSERT INTO ".$class. "(";
        $values = "";
        
        for($i = 1; $i < count($colonnes); $i++)
        {
            $requ .= $colonnes[$i].",";
            $values .= ":".$colonnes[$i].",";
        }
        $requ = substr($requ,0,strlen($requ)-1);  
        $values = substr($values,0,strlen($values)-1);
        $requ .=") VALUES (".$values.")";

        $q = $db->prepare($requ);

        for($i = 1; $i < count($colonnes); $i++)
        {
            $methode = "get".ucfirst($colonnes[$i]);
            $q->bindValue(":".$colonnes[$i],$obj->$methode());  
        }
        $q->execute();
    }

    public static function update($obj)
    {
        // UPDATE Categories SET LibelleCategorie=:LibelleCategorie WHERE idCategorie=:idCategorie
        $db = DbConnect::getDb();
        $class = get_class($obj);
        $colonnes = $class::getAttributes();
        $requ = "UPDATE ".$class. " SET ";
        
        for($i = 1; $i < count($colonnes); $i++)
        {
            $requ .= $colonnes[$i]."=:".$colonnes[$i].",";
        }
        $requ = substr($requ,0,strlen($requ)-1);  
        $requ .=" WHERE ".$colonnes[0]."=:".$colonnes[0];


        $q = $db->prepare($requ);

        for($i = 0; $i < count($colonnes); $i++)
        {
            $methode = "get".ucfirst($colonnes[$i]);
            $q->bindValue(":".$colonnes[$i],$obj->$methode());  
        }
        $q->execute();
    }

    public static function delete($obj)
	{
 		$db=DbConnect::getDb();
        $class = get_class($obj);
        $colonnes = $class::getAttributes();
        $methode = "get".ucfirst($colonnes[0]);
        $q = $db->prepare("DELETE FROM ".$class." WHERE ".$colonnes[0]." = ".$obj->$methode());
	}

    private static function tableSelect($nomTable){
        return(" FROM " . $nomTable);
    }

    private static function limitSelect($limit){
        return(" LIMIT " . $limit);
    }
}
