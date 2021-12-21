var categorie = document.getElementsByClassName("categ");

function afficheSousMenu(e) {
    if (e.target.nextElementSibling.classList.contains("masquer")) {
        e.target.nextElementSibling.classList.add("affiche");
        e.target.nextElementSibling.classList.remove("masquer");
        console.log(e.target.firstChild);
        // e.target.classList.add("affiche");
        // e.target.classList.remove("masquer");
    }else{
        e.target.nextElementSibling.classList.add("masquer");
        e.target.nextElementSibling.classList.remove("affiche");
        e.target.firstChild.classList.add("masquer");
        // e.target.firstChild.classList.remove("fa-caret-square-right");
        // e.target.classList.remove("affiche");
    }
}

for (let i = 0; i < categorie.length; i++) {
    categorie[i].addEventListener("click", afficheSousMenu);
}
