
let array = [5, 9, 3, 19, 70, 8, 100, 2, 35, 27];

//Ordenar array Crescente
let arrayOrd = array.slice();
for (let i = 1; i < arrayOrd.length; i++) {
  for (let j = 0; j < i; j++) {
    if (arrayOrd[i] < arrayOrd[j]) {
      let position = arrayOrd[i];
      arrayOrd[i] = arrayOrd[j];
      arrayOrd[j] = position;
    }
  }
}

//Ordenar array Decrescente
let arrayDesord = array.slice();
for (let i = 1; i < arrayDesord.length; i++) {
  for (let j = 0; j < i; j++) {
    if (arrayDesord[i] > arrayDesord[j]) {
      let position = arrayDesord[i];
      arrayDesord[i] = arrayDesord[j];
      arrayDesord[j] = position;
    }
  }
}

//Multiplicar pelo proximo
let numbersMult = [];
for (let i = 0; i < array.length; i++) {
  if(array[i+1]){
    numbersMult.push(array[i]*array[i+1]);
  }else{
    numbersMult.push(array[i]*2);
  }  
}

console.log(array);
console.log(arrayOrd);
console.log(arrayDesord);
console.log(numbersMult);
