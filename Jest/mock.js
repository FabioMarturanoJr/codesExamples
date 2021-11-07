// mocking diretamente

test('msg', () => {
  
// criar uma função fake 'mockar' funciona apenas com func explicitas no proprio arquivo
myfunction = jest.fn().mockReturnValue('meuValor');
// garante q a função fake foi chama no teste
expect(myfunction).toBecalled();
// verifica quantas vezes a funcão foi chamada
expect(myfunction).toHaveBeenCalledTimes(1);
});


//mocking real
// pega a o myFunc Real, importa para verificar se foi chamada
const { myFunc } = require('./LocalRealdoMyFunc');
// esta função mocada pode esta em outro arquivo, depende apenas da funcção chamada no teste se utilizara a myFunc em outro arquivo
jest.mock('./pathArquivo', () => ({
  // o nome da função é a igual a utilizada pela função consumida no teste
  myFunc: jest.fn().mockReturnValue('Batata'),
}));

describe('Exemplo Mock real', () => {

  it('My Test Mock', () => {
    // a função funcComMyFunc tem o uso da 'myFunc' dentro dela
    return funcComMyFunc().then((result) => {
      // não precisa importar o myFunc para funcionar 
      expect(result).toBe('Batata');
      // precisa importa a o myFunc Real
      expect(myFunc).toHaveBeenCalledTimes(1);
    });
  });

});

// mock de Api
jest.mock('myApi', () => jest.fn().mockResolvedValue({
  resultResolve: [{
    name: 'Fabio',
    age: '26',
  }, {
    name: 'Bruna',
    age: '28',
  }]
}));


// exemplo called
expect(math.somar).toHaveBeenCalled();
expect(math.somar).toHaveBeenCalledTimes(1);
expect(math.somar).toHaveBeenCalledWith(1, 2);