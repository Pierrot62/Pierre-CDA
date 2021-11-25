CREATE TABLE TypesProduits(
   IdTypesProduit PRIMARY KEY VARCHAR(50),
   LibelleTypeProduit VARCHAR(100)
);

CREATE TABLE Categories(
   IdCategorie PRIMARY KEY VARCHAR(50),
   LibelleCategorie VARCHAR(100),
   IdTypesProduit VARCHAR(50) NOT NULL
);

CREATE TABLE Articles(
   IdArticle PRIMARY KEY VARCHAR(50),
   LibelleArticle VARCHAR(100) NOT NULL,
   QuantiteStockee INT NOT NULL,
   IdCategorie VARCHAR(50) NOT NULL
);


ALTER TABLE Categories ADD CONSTRAINT FK_Categories_Types_Types FOREIGN KEY (IdTypesProduit) REFERENCES TypesProduits (IdTypesProduit);
ALTER TABLE Produits ADD CONSTRAINT FK_Produits_Categorie FOREIGN KEY (IdCategorie) REFERENCES Categories (IdCategorie);
