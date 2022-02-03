// Récupération des blocs
var mainMenu = document.querySelector("#menu");
var burgerMenu = document.querySelector("#menu-burger");

/*===============================*/
/*=== Clic sur le menu burger ===*/
/*===============================*/
// Vérifie si l'événement touchstart existe et est le premier déclenché
var clickedEvent = "click"; // Au clic si "touchstart" n'est pas détecté
window.addEventListener('touchstart', function detectTouch() {
	clickedEvent = "touchstart"; // Transforme l'événement en "touchstart"
	window.removeEventListener('touchstart', detectTouch, false);
}, false);

// Créé un "toggle class" en Javascrit natif (compatible partout)
burgerMenu.addEventListener(clickedEvent, function(evt) {
	console.log(clickedEvent);
	// console.log(this.classList)
if(this.classList.contains("clicked")){
	this.classList.remove("clicked")
}else{
	this.classList.add("clicked")
}


if(mainMenu.classList.contains("invisible")){
	mainMenu.classList.add("visible")
	mainMenu.classList.remove("invisible")

}else{
	mainMenu.classList.remove("visible")
	mainMenu.classList.add("invisible")
}
	// Modification du menu burger
	// if(!this.getAttribute("class")) {
	// 	this.setAttribute("class", "clicked");
	// } else {
	// 	this.removeAttribute("class");
	// }
	// Variante avec x.classList (ou DOMTokenList), pas 100% compatible avant IE 11...
	// burgerMenu.classList.toggle("clicked");

	// Créé l'effet pour le menu slide (compatible partout)
	// if(mainMenu.getAttribute("class") != "visible") {
	// 	mainMenu.setAttribute("class", "visible");
	// } else {
	// 	mainMenu.setAttribute("class", "invisible");



	// }
}, false);


 inputDate = document.getElementById("date");
 valider = document.getElementById("valider");

 valider.addEventListener("click" , function(){
	

 });

