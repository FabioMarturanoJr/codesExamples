// Para utilizar o banco
use nomeDoBanco

//cria uma coleção direto no dataBase
db.createCollection( "nomeDaColecao", { collation: { locale: "pt" } } );

// insere dados dentro da coleção
db.nomeDaColecao.insertOne( { x: 1 })

//inserindo varios dados
db.nomeDaColecao.insertMany( 
  { "chave1": "valor1"},
    { "chave2": "valor2"},
    { "chave3": "valor3"}
)

//Procurar  um dado na coleção
db.collection.findOne("chave": "valor")

//Procurar  mais dados na coleção
db.collection.find("chave": "valor")

//Procurar um ou mais dados na coleção onde:
// a query define os filtros a ser consultado
// o projection define o retorno da sua consulta
db.collection.find(query, projection)

//Para filtragem dos campos solicitados
dbdb.collection.find({}, {"chave": 1, _id:0})

// Retorna o número de documentos de uma coleção
db.collection.count()

//limitar o número de documentos retornados por uma consulta
// db.collection.find(<query>).limit(<número>)
db.bios.find().limit(5)

// deixar os resultados exibidos mais legíveis
db.bios.find().limit(5).pretty()

//determinará quantos documentos serão "pulados" antes de começar a retornar
db.bios.find().skip(2)
db.bios.find().limit(10).skip(5)

// Importar/Exportar dados no mongoDB
// importar um dump
mongoimport --db nomedeDoBanco --collection nomeDaColeção <caminho_do_arquivo> 

mongoimport --db class --collection filmes ./dataset.json 

// Exportar um dump

mongoimport --db=nomedeDoBanco --collection=nomeDaColeção --out=<caminho_do_arquivo> 

// Utilizar os operadores de comparação

// $lt ( less than , menor que, <)
db.nomeDaColecao.find({ "chave": { $lt: "valorMenorQue" } })

db.inventory.find({ qty: { $lt: 20 } })

// $lte ( less than or equal , menor ou igual a, <=)
db.nomeDaColecao.find({ "chave": { $lte: "valorMenorIgualQue" } })

db.inventory.find({ qty: { $lte: 20 } })

// $gt ( greater than , maior que, >)
db.nomeDaColecao.find({ "chave": { $gt: "valorMaiorQue" } })

db.inventory.find({ qty: { $gt: 20 } })

// $gte ( greater than or equal , maior ou igual a, >=)
db.nomeDaColecao.find({ "chave": { $gte: "valorMaiorIgualQue" } })

db.inventory.find({ qty: { $gte: 20 } })

// Para valores entre, é preciso a combinação de dois operadores
db.nomeDaColecao.find({ "chave": { $gte: "valorMaiorIgualQue" $lte: "valorMenorIgualQue" } })

db.inventory.find({ qty: { $gte: 20 $lte: 50 } })

// $eq ( equal , igual a, =)
db.nomeDaColecao.find({ "chave": { $eq: "valor" } })

db.inventory.find({ qty: { $eq: 20 } })

db.inventory.find({ qty: 20 })

// $ne ( not equal , diferente de, !=, <>)
db.nomeDaColecao.find({ "chave": { $ne: "valor" } })

db.inventory.find({ qty: { $ne: 20 } })

// $in ( in , dentro de)
db.nomeDaColecao.find({ "chave": { $in: ["listaDeValoresQueEncontrar"] } })

db.inventory.find({ qty: { $in: [ 5, 15 ] } })

// $nin ( not in , não está dentro de)
db.nomeDaColecao.find({ "chave": { $nin: ["listaDeValoresQueNãoEncontrar"] } })

db.inventory.find( { qty: { $nin: [ 5, 15 ] } } )

{/* Utilizar os operadores lógicos */}

{/* $and ( and , se todas as condições forem verdadeiras retorna true ) */}
// { $and: [{ <expressão1> }, { <expressão2> } , ... , { <expressãoN> }] }
db.nomeDaColecao.find({ $and: [
          { "chave": { $ne: 1.99 } },
          { "chave": { $exists: true } }
      ]
  })

db.inventory.find({
  $and: [
          { price: { $ne: 1.99 } },
          { price: { $exists: true } }
      ]
  })

{/* $or ( or , se apenas uma condição for verdadeira retorna true ) */}
// { $or: [{ <expression1> }, { <expression2> }, ... , { <expressionN> }] }
db.nomeDaColecao.find({ $or: [{ "chave1": { $lt: 20 } }, { "chave2": 10 }] })

db.inventory.find({ $or: [{ qty: { $lt: 20 } }, { price: 10 }] })

{/* Compor filtros avançados com */}
{/* $not ( not , inverte o resultado da expressão) */}
// { campo: { $not: { <operador ou expressão> } } }
db.nomeDaColecao.find({ "chave": { $not: { $gt: 1.99 } } })

db.inventory.find({ price: { $not: { $gt: 1.99 } } })

{/* $nor ( not or , semelhante ao or , porém trabalha com a condição false ) */}
{/* { $nor: [ { <expressão1> }, { <expressão2> }, ...  { <expressãoN> } ] } */}
db.nomeDaColecao.find({ $nor: [{ "chave1": 1.99 }, { "chave2": true }] })

db.inventory.find({ $nor: [{ price: 1.99 }, { sale: true }] })

// EXPRESSOES EM OPERADOR LIKE, usado somente em regEx
db.filmes.find({ titulo: /i/ }); //like '%i%'
db.filmes.find({ titulo: /^Me/ }); //like 'Me%'
db.filmes.find({ titulo: /as$/ }); //like '%as' 


{/* $exists ( exists , verifica a existência de um atributo) */}
{/* Operador $exists */}
{/* { campo: { $exists: <boolean> } } */}
db.nomeDaColecao.find({ "chave": { $exists: true } })

db.inventory.find({ qty: { $exists: true } })
db.inventory.find({ qty: { $exists: true, $nin: [ 5, 15 ] } })

{/* sort() ( sort , ordenar) */}
{/* Método sort() */}
db.nomeDaColecao.find().sort({ "chave": "1 para ASC ou -1 para DESC"})

db.example.find({}, { value, name }).sort({ value: -1 }, { name: 1 })

{/* Removendo documentos */}

{/* deleteOne() */}
// remove o primeiro documento da coleção inventory 
db.inventory.deleteOne()

// remove o primeiro documento da coleção inventory em que o atributo status é igual a D 
db.inventory.deleteOne({ status: "D" })

{/* deleteMany() */}
// remove todos os documentos da coleção inventory em que o atributo status é igual a A :
db.inventory.deleteMany({ status : "A" })

// Para remover todos os documentos da coleção,
// basta não passar nenhum parâmetro para o método deleteMany(
db.inventory.deleteMany({})

{/* Apagando uma coleção */}
db.nomeDaColecao.drop()

{/* Apagando um banco de dados */}

db.dropDatabase()


{/* Método updateOne */}
// Para alterar um único documento
db.colecao.updateOne()

// O primeiro deles é o filtro. Nesse caso, um filtro simples de igualdade,
// mas outros operadores podem ser utilizados aqui;
// O segundo é a operação de update em si.
// O terceiro são opções que você pode inserir na sua Query(opcional)
// Nesse caso, foi utilizado o operador de atualização $set para alterar o valor do campo
db.inventory.updateOne(
  { "chave1": "valor" },
  { $set: { "chave3": "valor3" } }
  {option}
);

db.students.updateOne(
  { school: "Escola do Futuro" },
  { $set: { school: "Trybe" } }
)

{/* Método UpdateMany */}
// O método updateMany permite que vários documentos
db.inventory.updateMany(
  { "chave1": "valor" },
  { $set: { "chave3": "valor3" } }
  {option}
);

db.inventory.updateMany(
  { "qty": { $lt: 50 } },
  { $set: { "size.uom": "in" } }
);

{/* Operador $set */}
// $set altera o valor de um campo específico
db.nomeDaColecao.update(
  { _id: 100 },
  { $set: { "chaveExistente": "valorNovo" } }
);

db.products.update(
  { _id: 100 },
  { $set: { "details.make": "zzz" } }
);

db.products.update(
  { _id: 100 },
  { $set: {
      "tags.1": "rain gear",
      "ratings.0.rating": 2
    }
  }
);

{/* Operador upsert */}
// upsert insere um novo componente/valor de um campo específico, apenas o declarado no filtro
// Pode ser usado no updateOne ou updateMany

db.nomeDaColecao.updateMany(
  { _id: "inexistente" },
  { $set: { "chaveExistente": "valorNovo" } }
  {upsert: true}
);

db.products.update(
  { _id: 101 },
  { $set: {
      "tags.1": "rain gear",
      "ratings.0.rating": 2
    }
  }
  {upsert: true}
);

{/* Operador $mul */}
// operador $mul multiplica o valor de um campo por um número especificado
// o valor do db de "chave" vai multiplicar com o valor descrito em "valor"

db.nomeDaColecao.update(
  { _id: 2 },
  { $mul: { chave: valor } }
);

db.products.update(
  { _id: 2 },
  { $mul: { price: NumberLong("100") } }
);

{/* Operador $inc */}
// operador $inc , você pode incrementar ou decrementar valores em um campo específico,
// utilizando tanto valores positivos quanto negativos

db.nomeDaColecao.update(
  { "chaveFiltro": "valorDeFiltragem" },
  { $inc: { "chave1": -2, "chave2": 1 } }
);

db.increment.update(
  { sku: "abc123" },
  { $inc: { quantity: -2, "metrics.orders": 1 } }
);

{/* Operador $min e $max */}
// Aqui temos dois operadores que também são bastante interessantes.
// Ambos fazem o mesmo tipo de comparação antes de executar a operação, porém em "sentidos" diferentes:
//$min : altera o valor do campo para o valor especificado se esse valor especificado é menor do que o atual valor do campo;
//$max : faz o mesmo, porém altera o valor do campo se o valor especificado é maior do que o atual valor do campo.

db.nomeDaColecao.updateMany({}, { $max: { "chave": 75 } });
// Atualizando todos os valores do atributo "campo"
// para 75 caso sejam menores

db.scores.update({ _id: 1 }, { $min: { lowScore: 150 } });

db.nomeDaColecao.updateMany({}, { $min: { "chave": 42 } });
// Atualizando todos os valores do atributo "campo"
// para 42 caso sejam maiores

db.scores.update({ _id: 1 }, { $min: { lowScore: 250 } })

{/* Operador $currentDate */}
// O operador $currentDate atribui ao valor de um campo a data corrente , utilizando um tipo Date ou timestamp.
// Se você não especificar o tipo, por padrão, o MongoDB atribuirá o valor do tipo Date.

db.customers.updateOne(
  { _id: 1 },
  { 
    $currentDate: {
      lastModified: true,
      "cancellation.date": { $type: "timestamp" }
    },
    $set: {
      "cancellation.reason": "user request",
      status: "D"
    }
  }
);

{/* operador $rename */}
// perador recebe um documento contendo o nome atual do campo e o novo nome. 
// Tanto no updateOne() ou updateMany()

db.nomeDaColecao.updateOne(
  { "chaveDeFiltro": "Banana" },
  { $rename: {
      "nomeAnteriorDaChave": "nomeNovoDaChave"
    }
  }
);

db.fruits.updateOne(
  { name: "Banana" },
  { $rename: {
      "name": "productName"
      "name.surname": "name.lastname"
    }
  }
);

{/* operador $unset */}
// remover um ou mais campos de um documento

db.nomeDaColecao.updateMany(
  { "chaveDoFiltro": "ValorEsperado" },
  { $unset: { "chaveASerRemovida": "" } }
);

db.fruits.updateMany(
  { productName: "Banana" },
  { $unset: { quantity: "" } }
);

{/* operador $push */}
// O operador adiciona um valor a um array. Se não existir no documento, um novo array com o valor será adicionado.
// Sintaxe: { $push: { <campo1>: <valor1>, ... } }

db.nomeDaColecao.updateOne(
  { "chaveFiltro": "valorFiltro" },
  {
push: {
      "chave": {
        "indice": "valor"
      },
    },
  },
  { upsert: true },
);

use sales;
db.supplies.updateOne(
  { _id: 1 },
  {
push: {
      items: {
        "name": "notepad",
        "price":  35.29,
        "quantity": 2,
      },
    },
  },
  { upsert: true },
);

// MODIFICADORES UTILIZAVEIS
// $each : Adiciona múltiplos valores a um array ;
// $slice : Limita o número de elementos do array . Requer o uso do modificador $each ;
// $sort : Ordena os elementos do array . Requer o uso do modificador $each ;
// $position : Especifica a posição do elemento que está sendo inserido no array .
//             Também requer o modificador $each .
//             Sem o modificador $position , o operador $push adiciona o elemento no final do array

db.supplies.updateOne(
  { _id: 1 },
  {
$push: {
      "items": {
$each: [ // multiplos campos
          {
            "name" : "notepad",
            "price" : 35.29,
            "quantity" : 2,
          },
          {
            "name": "envelopes",
            "price": 19.95,
            "quantity": 8,
          },
          {
            "name": "pens",
            "price": 56.12,
            "quantity": 5,
          },
        ],
$sort: { "quantity": -1 }, // 1 ordena em crescente, -1 ordena em decrescente
$slice: 2, // corta o resultado a partir do primeiro valor e na quantidade solicitada
      },
    },
  },
  { upsert: true },
);

{/* operador $pull */}
// remove de um array existente todos os elementos com um ou mais valores
// que atendam à condição especificada

db.nomeDaColecao.updateMany(
  {},
  {
$pull: {
      "chaveFiltro": { $in: ["valorRetirado1", "valorRetirado2"] },
    },
  },
);

db.supplies.updateMany(
  {},
  {
$pull: {
  fruits: { $in: ["apples", "oranges"] },
  vegetables: "carrots"
    },
  },
);

{/* operador $pop */}
//maneira simples de remover o primeiro ou o último elemento de um array
db.nomeDaColecao.updateOne({ "chaveFiltro": 1 }, { $pop: { "chave": "-1 para primeiro/1 para último" } });

//remover o primeiro elemento do array
db.supplies.updateOne({ _id: 1 }, { $pop: { items: -1 } });

//remover o último elemento do array</valor1>
db.supplies.updateOne({ _id: 1 }, { $pop: { items: 1 } });

{/* Operador $addToSet */}
// é utilizado quando você precisa garantir que os valores de um array não sejam duplicados.
// garantido que apenas valores únicos estejam presentes no array.

db.nomeDaColecao.updateOne(
  { "chaveFiltro": 1 },
  { $addToSet: { "chave": "valorSendoInserido"  } },
);

db.inventory.updateOne(
  { _id: 1 },
  { $addToSet: { tags: "camera"  } },
);

//com o each
db.inventory.updateOne(
  { _id: 2 },
  {
$addToSet: {
      tags: {
        $each: ["camera", "electronics", "accessories"], //caso o valor seja repetido só acrescenta o novo
      },
    },
  },
);

{/* Operador $arrayFilters */}
// Ajuda a dinâmizar a procura por um parametro, afim de localizar o item que deseja alterar
// o "elemento" descrito no set e arrayFilters é apenas um nome para localização
// não influencia o processo do operador

db.nomeDaColecao.updateMany( // Passamos de updateOne para updateMany.
  {"chaveFiltro": "valor"}, // filtro aplicado
  {
$set : {
      "chave.$[elemento].chavePraAlterar": "valorPraAlterar", // Setamos `unit` como "xícara",
    },
  },
  { $arrayFilters: [ { "elemento.chaveFiltrada": "valorFiltrado" } ] }, // Filtramos os arrays que o valor da propriedade `name` seja "Farinha".
);


db.recipes.updateMany( 
  {},
  {
$set : {
      "ingredients.$[elemento].unit": "xícara",
      "ingredients.$[elemento].name": "Farinha Integral",
    },
  },
  { $arrayFilters: [ { "elemento.name": "Farinha" } ] },
);

{/* Operador $all */}
// seleciona todos os documentos em que o valor do campo é um array que contenha
// todos os elementos especificados

db.nomeDaColecao.find(
  { "chaveFiltro": { $all: [ "valor1", "valor2" ] } }
);

db.inventory.find(
  { tags: { $all: [ "ssl", "security" ] } }
);

{/* Operador $elemMatch */}
// seleciona os documentos que contêm um campo do tipo array com pelo menos um elemento
// que satisfaça todos os critérios de seleção especificados

db.nomeDaColecao.find(
  { "chaveFiltro": { $elemMatch: { $gte: 80, $lt: 85 } } }
);

db.survey.find(
  { results: { $elemMatch: { product: "xyz", score: { $gte: 8 } } } }
);

{/* Operador $size */ }
// O operador $size seleciona documentos em que um array
// contenha um número de elementos especificado
// apenas o valor de $size: 2 pois seus campos tags são arrays e contêm exatamente 2 elementos

db.nomeDaColecao.find(
  { "chaveFiltro": { $size: 2 } }
);

db.products.find(
  { tags: { $size: 2 } }
);

{ /* Operador $expr */}
// permite que você utilize expressões de agregação 
// e construa queries que comparem campos no mesmo documento

db.nomeDaColecao.find(
  {
$expr: { $gt: [ "$valorMaxComparavel", "$valorMinComparavel" ] }
  }
);

{ /* Operador $regex */}
// fornece os "poderes" das expressões regulares ( regular expressions ) para seleção de strings

db.products.find({ sku: { $regex: /^ABC/i } });

{ /* Operador $text */}
// faz uma busca "textual" em um campo indexado por um text index.

// criação de indice para a pesquisa textual
db.nomeDaColecao.createIndex({ subject: "text"}, {default_language: "portuguese"})

db.nomeDaColecao.find({
  $text: { $search: "valorEmTexto"}
})

// opções no $text:
//  $search: <string>, para pesquisar um texto
//  $language: <string>, para definir a lingua utilizada
//  $caseSensitive: <boolean>, para definir se é case sensitive
//  $diacriticSensitive: <boolean>, para definir se os acentos serão sensitive

db.article.find({
  $text: { $search: "coffee"}
})

// para texto específico

db.article.find({
  $text: { $search: "\"coffee shop\""}
})

// para saber a proximidade do resultado, quanto maior resultado mais proximo do solicitado

db.article.find({
  {$text: { $search: "coffee"}},
  {score: { $meta: "textScore" }}
})

{ /* Operador $mod */}
// que seleciona todos os documentos em que o valor do campo dividido por um divisor
// seja igual ao valor especificado

db.nomeDaColecao.find({ "chaveFiltro": { $mod: [4, 0] } });

db.inventory.find({ qty: { $mod: [4, 0] } });

