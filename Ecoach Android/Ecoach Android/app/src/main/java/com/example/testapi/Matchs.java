package com.example.testapi;

import java.util.Date;

public class Matchs {

    private String id;
    private String numero_match;
    private Date date_heure_match;
    private String categorie_equipe_local;
    private String score_match;
    private String equipe_local;
    private String equipe_adverse;
    private String lieu_match;
    private String lien_feuille_de_match;

    @Override
    public String toString() {
        return "Numero de match : " + this.numero_match + " | Date et Heure du match : " + this.date_heure_match + " | Equipe local : " + this.equipe_local + " | Equipe adverse : " + this.equipe_adverse + " | Lieu du match : " + this.lieu_match;
    }

}
