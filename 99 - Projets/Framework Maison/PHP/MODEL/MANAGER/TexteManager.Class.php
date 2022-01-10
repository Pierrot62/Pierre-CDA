<?php
class TexteManager
{
    public static function findByCodes($codeLangue, $codeTexte)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("SELECT " . $codeLangue . " FROM Texte WHERE codeTexte =:codeTexte");
        $q->bindValue(":codeTexte", $codeTexte, PDO::PARAM_STR);
        $q->execute();
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false) {
            return $results[$codeLangue]; // on ne retourne que le texte, pas un objet
        } else {
            return false;
        }
    }
    /**
     * Cette fonction sert a checker si le nom de la langue existe en tant que colonne 
     *
     * @param [string] La langue injectée dans l'URL
     * @return bool
     */
    public static function getLang($lang)
    {
        if (strlen($lang) <= 3) {
            $db = DbConnect::getDb();
            $q = $db->prepare('SHOW COLUMNS FROM texte LIKE :codeLangue'); // on vérifie que le nom de la colonne existe
            $q->bindValue(":codeLangue", $lang, PDO::PARAM_STR);
            $q->execute();
            $results = $q->fetch(PDO::FETCH_ASSOC);
            if ($results != false) {
                return true;
            } else {
                return false;
            }
        }
    }

}
