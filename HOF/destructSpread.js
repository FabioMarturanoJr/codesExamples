const person1 = {
  name: 'João',
  lastName: 'Jr',
  age: 34,
};

// const { nationality = 'Brazilian' } = person1;
// console.log(nationality); // Brazilian

const getNationality = ({ firstName, nationality }) => `${firstName} is ${nationality}`;

const person = {
    firstName: 'João',
    lastName: 'Jr II',
};

const otherPerson = {
    firstName: 'Ivan',
    lastName: 'Ivanovich',
    nationality: 'Russian',
};

// person.nationality = 'Brazilian';
const { nationality = 'Brazilian' } = person;

console.log(getNationality(otherPerson)); // Ivan is Russian
console.log(getNationality(person));

const getPosition = (latitude, longitude) => ({
  latitude,
  longitude});

// console.log(getPosition(-19.8157, -43.9542));

const greeting = (user = 'usuário') => console.log(`Welcome ${user}!`);

// greeting('Fabio'); // // Welcome usuário!

const multiply = (number, value = 1) => number * value; // Escreva aqui a sua função

// console.log(multiply(8));


function quantosParams(...args) {
  console.log('parâmetros:', args);
  return `Você passou ${args.length} parâmetros para a função.`;
}

console.log(quantosParams(0, 1, 2)); // Você passou 3 parâmetros para a função.
console.log(quantosParams('string', null, [1, 2, 3], { })); // Você passou 4 parâmetros para a função.
