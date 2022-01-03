/**
 * Initialisation / paramètres;
 */

//Taille de la grid
const taille = 5;
const randStart = 2;
var grille = document.getElementById("grid");
var cases = [];
gridSettings();
/****************************/




// au chargement de la page on définit la taille de la grille en css.
function gridSettings() {
    let stringGrid = "";
    for (let i = 0; i < taille; i++) {
        stringGrid += "2fr ";
        stringLigne = "l" + i;
        .
        for (let j = 0; j < taille; j++) {
            let caseTab = document.createElement("div");
            caseTab.classList.add("caseVide");
            caseTab.classList.add("center");
            caseTab.id = "l" + i + "c" + j;
            grille.appendChild(caseTab);
            cases.push(caseTab);
        }
    }
    grille.style.gridTemplateColumns = stringGrid;

    //on boucle x fois pour avoir des cases pleines de 2 au départ
    for (let i = 0; i < randStart; i++) {
        setRandomCase();
    }
}

function setRandomCase() {
    let randl = Math.floor(Math.random() * taille);
    let randc = Math.floor(Math.random() * taille);
    let laCase = document.getElementById(`l${randl}c${randc}`);
    if (laCase.textContent == "") {
        laCase.textContent = "2";
        laCase.classList.add("case");
        laCase.classList.remove("caseVide");
    } else {
        setRandomCase();
    }
}


// On check si la partie est terminée ou un coup est jouable.
function Result() {
    var cpt = 0;
    do {
        cpt++;
    } while (cases[cpt] != "");

    if (FlagCombinaison && cpt < cases.length - 1) {
        alert("Partie Terminée !");
    }
}

document.addEventListener('keydown', (e) => {
    if (!e.repeat) {
        switch (e.key) {
            case "ArrowRight":
                console.log("droite");
                break;
            case "ArrowLeft":
                console.log("gauche");
                break;
            case "ArrowUp":
                console.log("haut");
                break;
            case "ArrowDown":
                console.log("bas");
                break;
            default:
                console.log("Pas la bonne touche");
                break;
        }
    }
});

function DeplaceCase(){
    for (let i = 0; i < cases.length; i++) {

        if (!cases[i + 1].classList.contains("caseVide")) {
            if (cases[i+ 1].textContent == cases[i].textContent) {
                
            }
        }        
    }
}