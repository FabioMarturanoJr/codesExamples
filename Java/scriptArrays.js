/*
let tasksList = ['acordar','comer','dormir'];

tasksList.push('lavar louça');

tasksList.pop();

console.log(tasksList.length);

let searchForFirstTask = tasksList[0];
console.log(searchForFirstTask);
// acordar

let searchForLastTask = tasksList[tasksList.length - 1];
console.log(searchForLastTask);
//dormir

console.log(tasksList.indexOf('acordar'));
*/

let menu = ['Home', 'Serviços', 'Portfólio', 'Links'];
let menuServices = menu[1];

console.log(menuServices);

menu = ['Home', 'Serviços', 'Portfólio', 'Links'];
let indexOfPortfolio = menu.indexOf('Portfólio');

console.log(indexOfPortfolio);

menu.push('Contato');

console.log(menu);

let groceryList = ["\nArroz", "Feijão", "Alface", "Melancia"];

for (let i = 0; i < groceryList.length; i++) {
  console.log(groceryList[i]);  
}