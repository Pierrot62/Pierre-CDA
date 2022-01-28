var selectCateg = document.getElementById("categ");
selectCateg.addEventListener("change", recupInfo);
const requ = new XMLHttpRequest();

function recupInfo() {
    console.log(selectCateg.value);
    requ.open('POST', 'index.php?page=ListeProduitAPI');
    requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    var args = "id=" + selectCateg.value;
    console.log(args);
    requ.send(args);
}

requ.onreadystatechange = function(event) {

    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // console.log("Réponse reçue: %s", this.responseText);
            reponse=JSON.parse(this.responseText);
            // console.log(reponse);
            console.log("toto");
            console.log(reponse);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


