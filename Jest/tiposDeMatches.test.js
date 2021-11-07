const sum = require('./sum')

test('sums two values', () => {
  expect(sum(2 ,3)).toBe(5);
});

test('Array and object equality', () => {
  const arr = [1, 2, 3];
  const obj = {a: 1, b: 2, c: 3};

  // expect(arr).toBe([1, 2, 3]); fails
  // expect(obj).toBe({a: 1, b: 2, c: 3}); fails 
  expect(arr).toEqual([1, 2, 3]);
  expect(obj).toEqual({a: 1, b: 2, c: 3});
});



// exemplos de matches com numeros

test('dois mais dois', () => {
  const value = 2 + 2;
  expect(value).toBeGreaterThan(3);
  expect(value).toBeGreaterThanOrEqual(3.5);
  expect(value).toBeLessThan(5);
  expect(value).toBeLessThanOrEqual(4.5);

  // toBe e toEqual são equivalentes para números
  expect(value).toBe(4);
  expect(value).toEqual(4);
});

test('adicionando números de ponto flutuante', () => {
  const value = 0.1 + 0.2;
  // expect(value).toBe(0.3);     Isso não vai funcionar por causa de um erro de arredondamento
  expect(value).toBeCloseTo(0.3); // Isso funciona.
});



// exemplos de matches com stings

test('não existe I em team', () => {
  expect('team').not.toMatch(/I/);
});

test('mas existe "stop" em Christoph', () => {
  expect('Christoph').toMatch(/stop/);
});



// exemplos de matches com array e iteraveis

const shoppingList = [
  'diapers',
  'kleenex',
  'trash bags',
  'paper towels',
  'milk',
];

test('the shopping list has milk on it', () => {
  expect(shoppingList).toContain('milk');
  expect(new Set(shoppingList)).toContain('milk');
});



// exemplos de matches com exceções e Erros

function compileAndroidCode() {
  throw new Error('você está usando o JDK errado');
}

test('compilando para android segue conforme esperado', () => {
  expect(() => compileAndroidCode()).toThrow();
  expect(() => compileAndroidCode()).toThrow(Error);

  // Você também pode usar a mensagem exata de erro ou uma regexp
  expect(() => compileAndroidCode()).toThrow('você está usando o JDK errado');
  expect(() => compileAndroidCode()).toThrow(/JDK/);
});

const multiplyByTwo = (number) => {
  if (!number) {
    throw new Error('number é indefinido')
  }
  return number * 2;
};
multiplyByTwo(4);

test('testa se multiplyByTwo retorna o resultado da multiplicação', () => {
  expect(multiplyByTwo(4)).toBe(8);
});
test('testa se é lançado um erro quando number é indefinido', () => {
  expect(() => { multiplyByTwo() }).toThrow();
});
test('testa se a mensagem de erro é "number é indefinido"', () => {
  expect(() => { multiplyByTwo() }).toThrowError(new Error('number é indefinido'));
});



// NOT

const workDays = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'];
const weekDays = ['Sunday', ...workDays, 'Saturday'];

test('Sunday is a week day', () => {
  expect(weekDays).toContain('Sunday');
});

test('Sunday is not a workday', () => {
  expect(workDays).not.toContain('Sunday');
});



// describe 

const myBeverage = {
  delicious: true,
  sour: false,
};

describe('my beverage', () => {
  test('is delicious', () => {
    expect(myBeverage.delicious).toBeTruthy();
  });

  test('is not sour', () => {
    expect(myBeverage.sour).toBeFalsy();
  });
});