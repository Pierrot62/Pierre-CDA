var inputs = document.querySelectorAll("input");
var erreur = document.getElementById("erreur");
inputs.forEach(input => {
    input.addEventListener("input", verifInput);
});

function verifInput(e) {
    if (e.target.value != "") {
         if (e.target.checkValidity) {
        e.target.style.backgroundColor = "green";    
        }else{
            e.target.style.backgroundColor = "red";
        }
    }else{
        e.target.style.backgroundColor = "whrite";
    }
}
