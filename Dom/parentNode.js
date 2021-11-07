document.querySelector("#elementoOndeVoceEsta").parentNode.style.backgroundColor = "lightgrey";

document.querySelector("#primeiroFilhoDoFilho").innerText = "primeiroFilhoDoFilho";

// pq ?
console.log(document.querySelector("#pai").lastElementChild);

console.log(document.querySelector("#elementoOndeVoceEsta").previousElementSibling);

console.log(document.querySelector("#elementoOndeVoceEsta").parentNode.innerText);

console.log(document.querySelector("#elementoOndeVoceEsta").nextElementSibling);

// pq ?
console.log(document.querySelector("#pai").childNodes[1]);


let elementFather = document.querySelector("#pai");
let elementItem = document.createElement("div");
let conteudoDiv = "FilhoDoPaiAppend";
elementItem.innerText = conteudoDiv;
elementFather.appendChild(elementItem);

let elementOndeEstou = document.querySelector("#elementoOndeVoceEsta");
conteudoDiv = "FilhoDeOndeEstou";
elementItem.innerText = conteudoDiv;
elementOndeEstou.appendChild(elementItem);

let elemnetPrimeiroPrimeiroFilho = document.querySelector("#primeiroFilhoDoFilho");
conteudoDiv = 'FilhoDoprimeiroFilhoDoFilho';
elementItem.innerHTML = conteudoDiv;
elemnetPrimeiroPrimeiroFilho.appendChild(elementItem);

let body = document.querySelector("body");

let toRemove = elementFather.querySelector("#terceiroFilho");

elementFather.removeChild(toRemove);

//div.className adicionar uma classe e um elemente
//div.id adicionar um ID para o elemente

let divs = [];

for (let i = 0; i < 5; i++) {
  divs.push(document.createElement('div'));
}
for (let div in divs) {
  divs[div].id = "newDiv-"+[div];
  divs[div].innerText = "Div-"+[div];
  elementFather.appendChild(divs[div]);
}

console.log(elementOndeEstou.nextElementSibling);
