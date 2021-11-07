function buttonClicked() {
  alert(" Alert Button Clicked :( ");
}

let clickP = document.getElementById("toClick");

clickP.addEventListener("click", recebeClick);

function recebeClick(eventoOrigemClick) {
  console.log(eventoOrigemClick.target);
  console.log(eventoOrigemClick.type);
  alert("Nice ;) ");
}

let buttonOuver = document.getElementById("myButton");

buttonOuver.addEventListener("pointerover",  recebeOver);

function recebeOver() {
  alert(" Do you know to read ?")
}

