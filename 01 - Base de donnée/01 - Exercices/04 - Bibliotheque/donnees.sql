INSERT INTO categoriesProfessionnelles VALUES (1,"Ouvrier");
INSERT INTO categoriesProfessionnelles VALUES (2,"Employer");
INSERT INTO categoriesProfessionnelles VALUES (3,"Techniciens");
INSERT INTO categoriesProfessionnelles VALUES (4,"Agens de maitrise");
INSERT INTO categoriesProfessionnelles VALUES (5,"Ingénieurs");
INSERT INTO categoriesProfessionnelles VALUES (6,"Cadres");
INSERT INTO categoriesProfessionnelles VALUES (7,"Dieu");

INSERT INTO abonnes VALUES (1,"Jean","116 route de Lyon","36372752",1998-03-23,1986-03-23,"6");
INSERT INTO abonnes VALUES (2,"Morice","29 rue Banaudon","74344564",1967-08-18,1955-08-18,"5");
INSERT INTO abonnes VALUES (3,"Jeanne","72 rue des Coudriers","48457499",1990-03-08,1980-03-08,"2");
INSERT INTO abonnes VALUES (4,"Albert","83 Avenue De Marlioz","49534733",2001-05-06,1989-05-06,"1");
INSERT INTO abonnes VALUES (5,"Robert","16 Rue Bonnet","48564547",2000-11-29,1990-11-29,"1");
INSERT INTO abonnes VALUES (6,"Jaqueline","64 rue Saint Germain","23344567",1976-12-14,1956-12-14,"7");
INSERT INTO abonnes VALUES (7,"Adrien","66 rue du Général Aileret","14987543",1989-11-15,1958-11-15,"3");

INSERT INTO EmpruntExemplaires VALUES (1,1,2,1998-03-27,1998-04-27);
INSERT INTO EmpruntExemplaires VALUES (2,1,3,1998-03-27,X);
INSERT INTO EmpruntExemplaires VALUES (3,4,6,1989-06-15,1989-06-25);
INSERT INTO EmpruntExemplaires VALUES (4,5,2,2000-11-23,2000-11-27);
INSERT INTO EmpruntExemplaires VALUES (5,6,5,1976-12-14,1976-12-24);
INSERT INTO EmpruntExemplaires VALUES (6,6,3,1976-12-14,1976-12-27);
INSERT INTO EmpruntExemplaires VALUES (7,3,2,1990-03-08,1990-08-25);

INSERT INTO Reservation VALUES (1,2,3,X,"24/11/2001","");
INSERT INTO Reservation VALUES (2,4,5,3,"13/08/2012","");
INSERT INTO Reservation VALUES (3,5,6,X,"37655","");
INSERT INTO Reservation VALUES (4,5,7,2,"38445","");
INSERT INTO Reservation VALUES (5,3,7,2,"15/3/2000","");
INSERT INTO Reservation VALUES (6,1,3,X,"25/6/2001","");
INSERT INTO Reservation VALUES (7,5,2,X,"27/4/2002","");

INSERT INTO EtatsReservation VALUES ("1","En Attente");
INSERT INTO EtatsReservation VALUES ("2","Satisfait");
INSERT INTO EtatsReservation VALUES ("3","Non Satisfait");
INSERT INTO EtatsReservation VALUES ("4","x");
INSERT INTO EtatsReservation VALUES ("5","x");
INSERT INTO EtatsReservation VALUES ("6","x");
INSERT INTO EtatsReservation VALUES ("7","x");

INSERT INTO Livres VALUES (1,1,1,"L'Insoutenable Légèreté de l'être",347233)	;
INSERT INTO Livres VALUES (2,1,,"J'irai cracher sur vos tombes",384239)	;
INSERT INTO Livres VALUES (3,3,,"Voyage au bout de la nuit",454834)	;
INSERT INTO Livres VALUES (4,2,,"Les Androïdes rêvent-ils de moutons électriques ?",439058)	;
INSERT INTO Livres VALUES (5,6,,"L'Écume des jours ",588540)	;
INSERT INTO Livres VALUES (6,5,,"Les Androïdes rêvent-ils de moutons électriques ?",439058)	;
INSERT INTO Livres VALUES (7,7,,"Les Raisins de la colère",754352)	;

INSERT INTO Usures VALUES (1,"Exploser");
INSERT INTO Usures VALUES (2,"Plus de couverture");
INSERT INTO Usures VALUES (3,"Manque de pages");
INSERT INTO Usures VALUES (4,"Bruler");
INSERT INTO Usures VALUES (5,"Bon état");
INSERT INTO Usures VALUES (6,"Neuf");
INSERT INTO Usures VALUES (7,"Tester sur le terrain");
