const repeat = (number, action) => {
  for (let count = 0; count <= number; count += 1) {
    action(count);
  }
};

const isEven = (number) => {
  if (number % 2 === 0) {
    console.log(number, 'is even');
  }
};

const isOdd = (number) => {
  if ((number % 2) > 0) {
    console.log(number, 'is odd');
  }
};

// repeat(3, isEven); // Testa quais números serão pares;
// repeat(3, isOdd); // Testa quais números serão ímpares;

const greaterThen = (firstNum) => (secondNum) => secondNum > firstNum;

const greaterThen10 = greaterThen(10);

// console.log(greaterThen10(15));
// console.log(greaterThen(25)(20));

const acord = () => console.log('Acordando!!');
const cafe = () => console.log('Bora tomar café!!');
const dormir = () => console.log('Partiu dormir!!');

const doingThings = (action) => {
  action();
}

doingThings(acord);