function getParamByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

var page = getParamByName("page");
var mode = getParamByName("mode");
var id = getParamByName("id");
    var donneeForm = document.getElementsByClassName("donneeForm");

if (page == "ListeVilles"){
    //recupInfo
    var temp = document.getElementsByClassName("liste")[0];
    var grid = document.getElementsByClassName("gridListe")[0];
    var btnAdd = document.getElementsByClassName("btnAdd")[0];
    var selectDep = document.getElementById("selectDep");
    selectDep.addEventListener("change", recupVille);

    //Const Requete
    const requGetVille = new XMLHttpRequest();
    const requGetDep = new XMLHttpRequest();
    const requDelVille = new XMLHttpRequest();
    const requVilleId = new XMLHttpRequest();

    function recupVille() {
        /**** GET */
        requGetVille.open('GET', 'https://localhost:44398/api/Villes/ByDep/'+ selectDep.value, true);
        requGetVille.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        requGetVille.send();
        }
        
        /**** GET */
        requGetDep.open('GET', 'https://localhost:44398/api/Departements', true);
        requGetDep.send();
        
        function suppVille(e) {
        /**** Delete  */
        requDelVille.open('DELETE', 'https://localhost:44398/api/Villes/'+ this.getAttribute("id"), true);
        requDelVille.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        requDelVille.send();
        }
        
        requGetVille.onreadystatechange = function(event) {
            if (this.readyState === XMLHttpRequest.DONE) {
                if (this.status === 200) {
                    console.log("Réponse reçue: %s", this.responseText);;
                    console.log(this.responseText);
                    reponse=JSON.parse(this.responseText);
                    clear();
                    if (reponse.length == 0) {
                        alert("Pas de resultat disponible pour ce departement");
                        // selectDep.getElementsByTagName("option")[0].addAttribute("selected");
                        console.log(selectDep.getElementsByTagName("option"));
                    }else{
                        for (let i = 0; i < reponse.length; i++) {
                            var newTemp = temp.content.cloneNode(true);
                            console.log(reponse[i]);
                            newTemp.children[0].innerHTML = reponse[i].nomVille;
                            newTemp.children[1].innerHTML = reponse[i].idDepartement;
                            newTemp.children[3].firstChild.setAttribute("href", newTemp.children[3].firstChild.getAttribute("href") + reponse[i].idVille);
                            newTemp.children[4].setAttribute("id",reponse[i].idVille);
                            grid.insertBefore(newTemp, grid.lastChild);
                        }
                        recupBtn();
                    }
                } else {
                    console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
                }
            }
        };
        
        requGetDep.onreadystatechange = function(event) {
            if (this.readyState === XMLHttpRequest.DONE) {
                if (this.status === 200) {
                    console.log("Réponse reçue: %s", this.responseText);
                    console.log(this.responseText);
                    reponseDep=JSON.parse(this.responseText);
                    for (let i = 0; i < reponseDep.length; i++) {
                        console.log(reponseDep[i]);
                        var opt = document.createElement("option");
                        opt.value = reponseDep[i].idDepartement;
                        opt.text = reponseDep[i].libelle;
                        selectDep.add(opt,null);
                    }
                } else {
                    console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
                }
            }
        };
        
        requDelVille.onreadystatechange = function(event) {
            if (this.readyState === XMLHttpRequest.DONE) {
                recupVille();
            }
        };
        
        function clear() {
            var cpt = 8;
            while (grid.childElementCount > cpt + 1) {
                grid.removeChild(grid.children[8]);
            }
        }
        
        function recupBtn() {
            var btnDel = document.getElementsByClassName("btnDel");
            for (let a = 0; a < btnDel.length; a++) {
                btnDel[a].addEventListener("click",suppVille);
            }

        }
}else if(page == FormVilles && mode == Modifier){
    
}










/**** GET by ID  */
// requ.open('GET', 'https://localhost:44398/api/Ville/1', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();


// /**** POST */
// requ.open('POST', 'https://localhost:44398/api/Departements', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idDepartement": 0,
//     "libelle": "nouveau"
//   }
//   requ.send(JSON.stringify(args));

/**** PUT */
// requ.open('PUT', 'https://localhost:44398/api/Departements/1', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idDepartement": 1,
//     "libelle": "test"
//   }
// requ.send(JSON.stringify(args));

