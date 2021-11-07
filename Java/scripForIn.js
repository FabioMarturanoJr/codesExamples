let pizza = {
  sabor: "palmito",
  preco: 39.90,
  bordaBacon: true
};

for (let key in pizza) {
  console.log(pizza[key]);
}

let pizzaDoce = ['chocolate', 'banata', 'morango'];

for (let key2 in pizzaDoce) {
  console.log(key2 ,pizzaDoce[key2]);   
}

let car = {
  type: "Fiat",
  model: "500",
  color: "white",
};

for (let i in car) {
  console.log(i, car[i]);
}