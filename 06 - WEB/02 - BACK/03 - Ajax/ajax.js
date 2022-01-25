var section = document.getElementById("sec");
var dep = document.getElementById("departement");
var btn = document.getElementById("button");
btn.addEventListener("click", api);
var message = document.getElementById("message");
var enregs;

const req = new XMLHttpRequest();
const req2 = new XMLHttpRequest();

function api() {
    req2.open('GET', 'https://geo.api.gouv.fr/regions/'+dep.value+'/departements');
    req2.send();
}

req2.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        reponseDep = JSON.parse(this.responseText);
        if (reponseDep != "Not Found") {
            req.open('GET', 'https://teleservices-ea.agriculture.gouv.fr/arpent-resultats-api/api/arpent-resultats/resultats-grand-public/resultats?departement=' + dep.value, true);
            req.send();
        }else{
            dep.classList.add("erreur");
        }
    }
}

req.onreadystatechange = function (event) {


    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            reponse = JSON.parse(this.responseText);

            if (reponse.length == 0) {
                message.textContent = "Aucun resultat disponible ou le departement " + dep.value + " n'existe pas."
            } else {
                while (section.firstChild) {
                    section.removeChild(section.firstChild);
                    message.textContent = "";
                };
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
