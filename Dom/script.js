var paragraph = document.getElementById("paragraph");
paragraph.style.color = "red";

document.getElementById("page-title").innerText = "Matrix";

let myElements = document.getElementsByClassName("classTeste");
//myElements[0].style.color = "blue";
//style.border= "solid"

for (let i = 0; i < myElements.length; i++) {
  myElements[i].innerText = 'Fabio '+[i];  
}

//sempre retorno por lista >>[index]<<
console.log(document.getElementsByTagName('p'));


console.log(document.querySelector("div .classTeste").innerText);

//document.querySelectorAll(".classTeste").style.color = "green";
