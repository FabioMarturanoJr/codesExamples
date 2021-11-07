
// somar todos os valores do array
const numbers = [32, 15, 3, 2, -5, 56, 10];

const getSum = (result, number) => result + number;

const sumNumber = numbers.reduce(getSum);

console.log(sumNumber);


// pegar o maior numero
const otherNumbers = [50, 85, -30, 3, 15];

const getBigger = (bigger, number) => bigger > number ? bigger : number;

// o segundo parematro do reduce é o valor inicial accumulator
const biggerNumber = otherNumbers.reduce(getBigger, 0);

console.log(biggerNumber);


// somar numeros pares
const anotherNumbers = [18, 19, 23, 53, 4, 5, 76, 23, 54];

const getEven = (number) => number % 2 === 0;
const sumPair = (currentValue, number) => currentValue + number;
const sumNumbers = (array) => array.filter(getEven).reduce(sumPair);

console.log(sumNumbers(anotherNumbers));

// retorna a materia que o estudante foi melhor
const estudantes = [
  {
    nome: 'Jorge',
    sobrenome: 'Silva',
    idade: 14,
    turno: 'Manhã',
    materias: [
      { name: 'Matemática', nota: 67 },
      { name: 'Português', nota: 79 },
      { name: 'Química', nota: 70 },
      { name: 'Biologia', nota: 65 },
    ],
  },
  {
    nome: 'Mario',
    sobrenome: 'Ferreira',
    idade: 15,
    turno: 'Tarde',
    materias: [
      { name: 'Matemática', nota: '59' },
      { name: 'Português', nota: '80' },
      { name: 'Química', nota: '78' },
      { name: 'Biologia', nota: '92' },
    ],
  },
  {
    nome: 'Jorge',
    sobrenome: 'Santos',
    idade: 15,
    turno: 'Manhã',
    materias: [
      { name: 'Matemática', nota: '76' },
      { name: 'Português', nota: '90' },
      { name: 'Química', nota: '70' },
      { name: 'Biologia', nota: '80' },
    ],
  },
  {
    nome: 'Maria',
    sobrenome: 'Silveira',
    idade: 14,
    turno: 'Manhã',
    materias: [
      { name: 'Matemática', nota: '91' },
      { name: 'Português', nota: '85' },
      { name: 'Química', nota: '92' },
      { name: 'Biologia', nota: '90' },
    ],
  },
  {
    nome: 'Natalia',
    sobrenome: 'Castro',
    idade: 14,
    turno: 'Manhã',
    materias: [
      { name: 'Matemática', nota: '70' },
      { name: 'Português', nota: '70' },
      { name: 'Química', nota: '60' },
      { name: 'Biologia', nota: '50' },
    ],
  },
  {
    nome: 'Wilson',
    sobrenome: 'Martins',
    idade: 14,
    turno: 'Manhã',
    materias: [
      { name: 'Matemática', nota: '80' },
      { name: 'Português', nota: '82' },
      { name: 'Química', nota: '79' },
      { name: 'Biologia', nota: '75' },
    ],
  },
];


const getBestMateria = (acc, materia) => acc.nota > materia.nota ? acc : materia;

const bestMateriaForStudent = (students) => students.map((student) => ({
  name: student.nome,
  materia: student.materias.reduce(getBestMateria).name,
  nota: student.materias.reduce(getBestMateria).nota,
}));

console.log(bestMateriaForStudent(estudantes));