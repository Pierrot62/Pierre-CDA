var inputs = document.querySelectorAll("input");
var boutonValider = document.querySelector("button[type=submit]");
var mdp = document.getElementById("mdp");
var valideForm = {};
var icoBulle = document.querySelectorAll(".fa-question-circle");
var infoBUlle = document.getElementsByClassName("infoBulle");
var icoMdp = document.getElementsByClassName("icoMdp")[0];

icoMdp.addEventListener("click", afficheMdp);

icoBulle.forEach(ico => {
    ico.addEventListener("mouseover" , afficheInfoBulle);
    ico.addEventListener("mouseout" , masquerInfoBulle);

});

inputs.forEach(input => {
    input.addEventListener("input", verifInput);
});

for (let i = 0; i < inputs.length; i++) {
    if (inputs[i].required) {
        valideForm[inputs[i].name] = false;
    } else {
        valideForm[inputs[i].name] = true;
    }
}

function verifInput(e) {
    if (e.target.classList.contains("inputMdp")) {
        console.log(e.target.parentNode.nextElementSibling.firstChild.classList);
        var elm = e.target.parentNode.nextElementSibling.firstChild.classList;
    }else{
        var elm = e.target.nextElementSibling.firstChild.classList;
    }
    if (e.target.type == "date") {
        var date = new Date();
        var userDate = new Date(e.target.value);
        if (userDate.getTime() > date.getTime()) {
            elm.add("fa-times-circle");
            elm.remove("fa-check-circle");
            e.target.classList.remove("vert");
            e.target.classList.add("rouge");
            valideForm[e.target.name] = false;
        } else {
            console.log("ok");
            elm.remove("fa-times-circle");
            elm.add("fa-check-circle");
            e.target.classList.remove("rouge");
            e.target.classList.add("vert");
            valideForm[e.target.name] = true;
        }
    } else if (e.target.name == "confirmMdp") {
        if (e.target.value == mdp.value) {
            e.target.classList.remove("rouge");
            e.target.classList.add("vert");
            elm.remove("fa-times-circle");
            elm.add("fa-check-circle");
            valideForm[e.target.name] = true;
        } else {
            e.target.classList.remove("vert");
            e.target.classList.add("rouge");
            elm.add("fa-times-circle");
            elm.remove("fa-check-circle");
            valideForm[e.target.name] = false;
        }
    }
    else {
        if (e.target.checkValidity()) {
            e.target.classList.remove("rouge");
            e.target.classList.add("vert");
            elm.remove("fa-times-circle");
            elm.add("fa-check-circle");
            valideForm[e.target.name] = true;
        } else {
            e.target.classList.remove("vert");
            e.target.classList.add("rouge");
            elm.add("fa-times-circle");
            elm.remove("fa-check-circle");
            valideForm[e.target.name] = false;
        }
    }
    verifForm();
}

function verifForm() {
    console.log(valideForm);
    boutonValider.disabled = false;
    if (Object.values(valideForm).indexOf(false) != -1) {
        boutonValider.disabled = true;
    }
}

function afficheInfoBulle(e){
    e.target.nextElementSibling.classList.remove("masquer");
    e.target.nextElementSibling.classList.add("visible");
}
function masquerInfoBulle(e){
    e.target.nextElementSibling.classList.remove("visible");
    e.target.nextElementSibling.classList.add("masquer");
}

function afficheMdp(e){
    console.log(e.target);
    if (mdp.getAttribute("mode") == "masquer") {
        e.target.classList.add("far");
        e.target.classList.remove("fas");
        mdp.setAttribute("mode","affiche");
        mdp.type="text";
    }else{
        e.target.classList.add("fas");
        e.target.classList.remove("far");
        mdp.setAttribute("mode" ,"masquer");
        mdp.type="password";
    }
}