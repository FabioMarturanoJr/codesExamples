let person = {
  name: 'Fabio',
  lastName: 'Marturano',
  age: 26
};

console.log(`Nome ${person.name} idade ${person.age}`);

person.fullName = person.name + ' ' + person.lastName;

console.table(person);

let player = {
  nameP: 'Marta',
  lastNameP: 'Silva',
  ageP: '34',
  medals: { golden: 2, silver: 3}
};

console.log(`A jogadora ${player.nameP} ${player.lastNameP} tem ${player.ageP} anos de idade.`);

player.bestInTheWorld = [2006, 2007, 2008, 2009, 2010, 2018];

console.log(`A Jogadora ${player.nameP} ${player.lastNameP} foi elseita a melhor do mundo por ${player.bestInTheWorld.length} vezes.`);

console.log(`A jogadora possui ${player.medals.golden} medalhas de ouro e ${player.medals.silver} medalhas de prata.`);