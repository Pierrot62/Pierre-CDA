var menuClique;
var ico = document.querySelector(".fa-bars");
var nav = document.querySelector("nav");
ico.addEventListener("click", afficheMenu);

var menu = document.getElementsByClassName("menu");
var menuItem = document.getElementsByClassName("menuItem");
console.log(menu);

for (let i = 0; i < menuItem.length; i++) {
    menuItem[i].addEventListener("click", afficheSousMenu);
    menuItem[i].addEventListener("MouseLeave", afficheSousMenu);
}

function afficheMenu(e) {
    for (let i = 0; i < menu.length; i++) {
        if (menu[i].classList.contains("masquer")) {
            menu[i].classList.add("affiche");
            menu[i].classList.remove("masquer");
            ico.classList.remove("fa-bars");
            ico.classList.add("fa-hamburger");
            nav.addEventListener("mouseleave", afficheMenu);
        }else{
            menu[i].classList.add("masquer");
            menu[i].classList.remove("affiche");
            ico.classList.add("fa-bars"); 
            ico.classList.remove("fa-hamburger");
            nav.removeEventListener("mouseleave", afficheMenu);
        }
    }
}

function afficheSousMenu(e){
    menuClique = e.target;
    for (let j = 0; j < menuItem.length; j++) {
        menuItem[j].nextElementSibling.classList.add("masquer");
    }
    menuClique.nextElementSibling.classList.add("affiche");
    if (e.target.nextElementSibling.classList.contains("masquer")) {
        e.target.nextElementSibling.classList.add("affiche");
        e.target.nextElementSibling.classList.remove("masquer");
    }else{
        e.target.nextElementSibling.classList.add("masquer");
        e.target.nextElementSibling.classList.remove("affiche");
    }
}




