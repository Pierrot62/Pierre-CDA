var elm = document.getElementsByClassName("elmMenu");
for (let i = 0; i < elm.length; i++) {
    elm[i].addEventListener("click",afficheSousMenu);
    console.log(elm[i]);    
}
function afficheSousMenu(e){
    var listeClasse = e.target.nextElementSibling.classList;
    if (listeClasse.contains("masquer")) {
       listeClasse.add("affiche");
       listeClasse.remove("masquer");
    }else{
        listeClasse.add("masquer");
        listeClasse.remove("affiche");
    }
}
