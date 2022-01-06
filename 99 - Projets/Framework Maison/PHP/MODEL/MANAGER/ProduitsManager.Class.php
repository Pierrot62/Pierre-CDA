<?php
class ProduitsManager
{
    public static function add(Produits $obj)
    {
        Services::add($obj);
    }

    public static function update(Produits $obj)
    {
        Services::update($obj);
    }

    public static function delete(Produits $obj)
    {
        Services::delete($obj);
    }

    // Exemple d'appel a la fonction select 
    // Services::select(["idProduit", "libelleProduit", "prixProduit"],"produit", 1);

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;  // on verifie que id est numerique, evite l'injection SQL
        $q = $db->query("SELECT * FROM Produits WHERE idProduit=" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Produits($results);
        }
        else
        {
            return false;
        }
    }

    public static function getList()
    {   
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Produits");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Produits($donnees);
            }
        }
        return $liste;  // tableau contenant les objets Produits
    }

    public static function getListByCategorie($idCategorie)
    {
        $idCategorie=(int) $idCategorie;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Produits where idCategorie=$idCategorie");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Produits($donnees);
            }
        }
        return $liste;  // tableau contenant les objets Produits
    }
}
