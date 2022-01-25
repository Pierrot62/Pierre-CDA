var section = document.getElementById("sec");
var dep = document.getElementById("dep");
dep.addEventListener("change", recupResult);
var message = document.getElementById("message");
var enregs;

const req = new XMLHttpRequest();
const req2 = new XMLHttpRequest();

req2.open('GET', 'https://geo.api.gouv.fr/departements');
req2.send();
console.log("toto");



req2.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        reponseDep = JSON.parse(this.responseText);
        if (reponseDep != "Not Found") {
            for (let i = 0; i < reponseDep.length; i++) {
                var opt = document.createElement("option");
                opt.value = reponseDep[i].code;
                opt.text = + reponseDep[i].code + " - " + reponseDep[i].nom;
                dep.add(opt, null);
            }
           recupResult();
        } else {
            dep.classList.add("erreur"); add
        }
    }
}

function recupResult() {
    req.open('GET', 'https://teleservices-ea.agriculture.gouv.fr/arpent-resultats-api/api/arpent-resultats/resultats-grand-public/resultats?departement=' + dep.value, true);
    req.send();
}

function clear() {
    while (section.firstChild) {
        section.removeChild(section.firstChild);
        message.textContent = "";
    };
}

req.onreadystatechange = function api (event) {


    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            reponse = JSON.parse(this.responseText);

            if (reponse.length == 0) {
                clear();
                message.textContent = "Aucun resultat disponible pour le departement " + dep.value;
            } else {
               clear();
                message.textContent = reponse.length + " resultat(s) disponible pour le departement " + dep.value;
                for (let i = 0; i < reponse.length; i++) {

                    ligne = document.createElement("div");
                    console.log(ligne);
                    ligne.setAttribute("class", "ligne");
                    console.log(ligne);
                    console.log(reponse[i]);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].nom;
                    ligne.appendChild(elm);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].prenoms;
                    ligne.appendChild(elm);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].filiere;
                    ligne.appendChild(elm);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].option;
                    ligne.appendChild(elm);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].departement;
                    ligne.appendChild(elm);

                    elm = document.createElement("div");
                    elm.setAttribute("class", "elm");
                    elm.innerHTML = reponse[i].resultat;
                    ligne.appendChild(elm);

                    section.appendChild(ligne);
                }
            }

            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};
