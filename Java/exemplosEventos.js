const myButton1 = document.querySelector(".botao1");
const myButton2 = document.querySelector(".botao2");
const caixaTexto = document.querySelector('.caixa-texto');

const caixaUm = document.querySelector('.caixa1');
const caixaDois = document.querySelector('.caixa2');

myButton1.addEventListener("pointerover",  overBt1);
myButton1.addEventListener("click",  clickBt1);

myButton2.addEventListener("pointerover",  overBt2);
myButton2.addEventListener("click",  clickBt2);

caixaTexto.addEventListener("paste",  pasteText);

function overBt1() {
  caixaUm.style.backgroundColor = "green";
}
function overBt2() {
  caixaDois.style.backgroundColor = "green";
}

function clickBt1() {
  caixaUm.innerText = caixaTexto.value;
}
function clickBt2() {
  caixaDois.innerText = caixaTexto.value;
}


function pasteText() {
  alert("Go Trybe!");
}