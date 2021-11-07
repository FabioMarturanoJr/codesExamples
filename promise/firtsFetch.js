const fetch = require('node-fetch');

async function verifiedFetch(url) {
  if (url === 'https://api.chucknorris.io/jokes/random?category=dev') {
    return fetch(url)
      .then((r) => r.json())
      .then((r) => (r.value));
  }
  throw new Error('endpoint não existe'); 
}

async function sendJokeToFriend(name) {
  const message = await verifiedFetch('https://api.chucknorris.io/jokes/random?category=dev')
    .then((joke) => `Oi ${name}, ouve essa: ${joke}`)
    .catch((err) => err);
  console.log(message);
}

sendJokeToFriend("Anna");


// O que é um código que é executado de modo assíncrono? Qual é a diferença disso para um código que é executado de modo síncrono?
// assincrono executa de forma paralela, não depende do resto do codigo e pode retorna depois de chamadas que viera depois dele
// Quando você tem que enfileirar várias callbacks , que problema surge?
// call hell, codigo dificil de ler e manter
// Por que as Promises são uma forma de se resolver esse problema?
// com elas vc poder deixar ela esperando a resposta sem interferir no restante do codigo
// Quando você vai se comunicar com uma API , tal comunicação deve ser síncrona ou assíncrona? Lembre-se de que o serviço ao qual você está se conectando pode demorar muito ou pouco para dar retorno, pode estar fora do ar etc.
// assincrona
// Dada a resposta anterior, o que é fetch e para que ele serve?
// ferramenta para conversar com APIs