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
// function result() {
//     let cpt = 0;

//     let cpt = 0;
//     let flagResult = true;

//     do {
//         let idColCaseEnCours = cases[cpt].getAttribute("id").substring(cases[cpt].getAttribute("id").indexOf("c") + 1) * 1;
//         let idligneCaseEnCours = cases[cpt].getAttribute("id").substring(cases[cpt].getAttribute("id").indexOf("l") + 1, cases[cpt].getAttribute("id").indexOf("c")) * 1;

//         if (!cases[cpt].classList.contains("caseVide"))
//         {
//             if (idligneCaseEnCours == 0)
//             {
//                 if (idColCaseEnCours == 0)
//                 {
//                     if (document.getElementById(`l${idligneCaseEnCours + 1}c${idColCaseEnCours}`).textContent = cases[cpt].textContent)
//                     {
                        
//                     }
//                 }
//             }
//         }
//         cpt++;
//     } while(cpt < taille*taille && flagResult == true)

    
//     for(let i = 0; i < cases.length ; i++)
//     {
//         let idColCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("c") + 1) * 1;
//         let idligneCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("l") + 1, cases[i].getAttribute("id").indexOf("c")) * 1;

//         if (!cases[i].classList.contains("caseVide"))
//         {
//             if ((cases[i].textContent != document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours + 1}`).textContent || document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours + 1}`) == undefined) && (cases[i].textContent != document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours - 1}`).textContent || document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours - 1}`) == undefined) && (cases[i].textContent != document.getElementById(`l${idligneCaseEnCours - 1}c${idColCaseEnCours}`).textContent || document.getElementById(`l${idligneCaseEnCours - 1}c${idColCaseEnCours}`) == undefined) && (cases[i].textContent != document.getElementById(`l${idligneCaseEnCours + 1}c${idColCaseEnCours}`).textContent || document.getElementById(`l${idligneCaseEnCours + 1}c${idColCaseEnCours}`) == undefined))
//             {
//                 cpt++;
//             }
//         }
//     }

    
//     if (cpt == taille*taille)
//     {
//         alert("perdu");
//     }
// }

document.addEventListener('keydown', (e) => {
    if (!e.repeat) {
        switch (e.key) {
            case "ArrowRight":
                deplacerCase("d");
                break;
            case "ArrowLeft":
                deplacerCase("g");
                break;
            case "ArrowUp":
                deplacerCase("h");
                break;
            case "ArrowDown":
                deplacerCase("b");
                break;
            default:
                console.log("Pas la bonne touche");
                break;
        }
    }
});

function deplacerCase(key) {
    switch (key) {
        case "d":
            for (let i = 0; i < cases.length; i++) {
                // *1 pour parseInt et on ajout 
                let idColCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("c") + 1) * 1;
                let idligneCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("l") + 1, cases[i].getAttribute("id").indexOf("c")) * 1;

                let caseSuiv = document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours + 1}`);

                if (cases[i].textContent != "") {
                    for (let j = idColCaseEnCours; j < taille - 1; j++) {
                        if (caseSuiv != undefined) {
                            if (!caseSuiv.classList.contains("caseVide")) {
                                if (caseSuiv.textContent == cases[i].textContent) {
                                    caseSuiv.textContent *= 2;
                                    cases[i].textContent = "";
                                    cases[i].classList.add("caseVide");
                                    cases[i].classList.remove("case");
                                }
                            } else {
                                caseSuiv.textContent = cases[i].textContent;
                                caseSuiv.classList.add("case");
                                caseSuiv.classList.remove("caseVide");

                                cases[i].textContent = "";
                                cases[i].classList.add("caseVide");
                                cases[i].classList.remove("case");
                            }
                        }
                    }
                }
            }
            break;
        case "g":
            for (let i = cases.length - 1; i >= 0; i--) {
                // *1 pour parseInt et on ajout 
                let idColCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("c") + 1) * 1;
                let idligneCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("l") + 1, cases[i].getAttribute("id").indexOf("c")) * 1;

                let caseSuiv = document.getElementById(`l${idligneCaseEnCours}c${idColCaseEnCours - 1}`);

                if (cases[i].textContent != "") {
                    for (let j = idColCaseEnCours; j < taille; j++) {
                        if (caseSuiv != undefined) {
                            if (!caseSuiv.classList.contains("caseVide")) {
                                if (caseSuiv.textContent == cases[i].textContent) {
                                    caseSuiv.textContent *= 2;
                                    cases[i].textContent = "";
                                    cases[i].classList.add("caseVide");
                                    cases[i].classList.remove("case");
                                }
                            } else {
                                caseSuiv.textContent = cases[i].textContent;
                                caseSuiv.classList.add("case");
                                caseSuiv.classList.remove("caseVide");

                                cases[i].textContent = "";
                                cases[i].classList.add("caseVide");
                                cases[i].classList.remove("case");
                            }
                        }
                    }
                }
            }
            break;

        case "h":
            for (let i = cases.length - 1; i >= 0; i--) {
                // *1 pour parseInt et on ajout 
                let idColCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("c") + 1) * 1;
                let idligneCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("l") + 1, cases[i].getAttribute("id").indexOf("c")) * 1;

                let caseSuiv = document.getElementById(`l${idligneCaseEnCours - 1}c${idColCaseEnCours}`);

                if (cases[i].textContent != "") {
                    for (let j = idColCaseEnCours; j < taille; j++) {
                        if (caseSuiv != undefined) {
                            if (!caseSuiv.classList.contains("caseVide")) {
                                if (caseSuiv.textContent == cases[i].textContent) {
                                    caseSuiv.textContent *= 2;
                                    cases[i].textContent = "";
                                    cases[i].classList.add("caseVide");
                                    cases[i].classList.remove("case");
                                }
                            } else {
                                caseSuiv.textContent = cases[i].textContent;
                                caseSuiv.classList.add("case");
                                caseSuiv.classList.remove("caseVide");

                                cases[i].textContent = "";
                                cases[i].classList.add("caseVide");
                                cases[i].classList.remove("case");
                            }
                        }
                    }
                }
            }
            break;

        case "b":
            for (let i = 0; i < cases.length; i++) {
                // *1 pour parseInt et on ajout 
                let idColCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("c") + 1) * 1;
                let idligneCaseEnCours = cases[i].getAttribute("id").substring(cases[i].getAttribute("id").indexOf("l") + 1, cases[i].getAttribute("id").indexOf("c")) * 1;

                let caseSuiv = document.getElementById(`l${idligneCaseEnCours + 1}c${idColCaseEnCours}`);

                if (cases[i].textContent != "") {
                    for (let j = idColCaseEnCours; j < taille; j++) {
                        if (caseSuiv != undefined) {
                            if (!caseSuiv.classList.contains("caseVide")) {
                                if (caseSuiv.textContent == cases[i].textContent) {
                                    caseSuiv.textContent *= 2;
                                    cases[i].textContent = "";
                                    cases[i].classList.add("caseVide");
                                    cases[i].classList.remove("case");
                                }
                            } else {
                                caseSuiv.textContent = cases[i].textContent;
                                caseSuiv.classList.add("case");
                                caseSuiv.classList.remove("caseVide");

                                cases[i].textContent = "";
                                cases[i].classList.add("caseVide");
                                cases[i].classList.remove("case");
                            }
                        }
                    }
                }
            }
            break;

        default:
            console.log("WTF !")
            break;
    }
    // result();
    setRandomCase();
}