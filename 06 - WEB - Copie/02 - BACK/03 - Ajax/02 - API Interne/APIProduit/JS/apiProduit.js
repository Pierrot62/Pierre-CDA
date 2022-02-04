var selectCateg = document.getElementById("selectCateg");
var temp = document.getElementsByClassName("temp")[0];
var grid = document.getElementsByClassName("gridListe")[0];
selectCateg.addEventListener("change", recupInfo);
const requ = new XMLHttpRequest();

function recupInfo() {
    requ.open('POST', 'index.php?page=ListeProduitAPI', true);
    requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    var args = "id=" + selectCateg.value;
    requ.send(args);
}

requ.onreadystatechange = function(event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {

            reponse=JSON.parse(this.responseText);
            var last = grid.lastChild;
            var enfants = grid.childNodes;
            console.log(enfants);
            // var cpt = 9;

            // while (grid.childElementCount > cpt + 1) {
            //     grid.removeChild(grid.children[9]);
            // }

            for (let i = 0; i < reponse.length; i++) {
                var newTemp = temp.content.cloneNode(true);
                console.log(reponse[i]);
                newTemp.children[0].innerHTML = reponse[i].libelleProduit;
                newTemp.children[1].innerHTML = reponse[i].prix;
                newTemp.children[2].innerHTML = reponse[i].dateDePeremption;
                newTemp.children[3].innerHTML = reponse[i].idCategorie;
                newTemp.children[4].getElementsByTagName("a")[0].href = "index.php?page=FormProduits&mode=Afficher&id="+reponse[i].idProduit;    
                newTemp.children[4].getElementsByTagName("a")[0].href = "index.php?page=FormProduits&mode=Modifier&id="+reponse[i].idProduit;                
                newTemp.children[4].getElementsByTagName("a")[0].href = "index.php?page=FormProduits&mode=Supprimer&id="+reponse[i].idProduit;
                grid.insertBefore(newTemp, last);
            }
           //on traite les éléments de la liste ....
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

