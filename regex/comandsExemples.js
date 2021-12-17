// . o "ponto" que significa qualquer char, dentro de um conjunto [] vale '.'
// * o asterisco que serve para definir uma quantidade de chars, zero ou mais vezes
// {e } as chaves que servem para definir uma quantidade de caracteres específicas que é desejado encontrar

// Por exemplo:

// a{3} letra a 3 vezes.
// \d* um digito zero ou mais vezes
// \d{3}\. 3 numeros termina com '.' = 123.
// \d{1, 3} numero com quantidade de 1 a 3 caracteres
// [-\.]conjunto de caractes ou '-' ou '.'
// \s espeços vazios
// * aparece 0 a n vezes
// + ou {1,} 1 a n vezes
// ? ou {0,1} caracter opcional 


const endsPng = /.*png/;

const allDigits = /\d/;

const CPF = /\d{3}\.\d{3}\.\d{3}-\d{2}/;
const CPF_OPTIONAL_CHARS = /\d{3}\.?\d{3}\.?\d{3}-?\d{2}/;

const CNPJ = /\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}/;

const IP = /\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}/;

const CEP = /\d{5}-\d{3}/;

const phoneNumber = /\(\d{2,3}\) \d{4,5}-\d{4}/;

const VARIABLE_FINAL_SEPARETOR = /\d{5}[-.]\d{3}/

const code = /<\/?code>/;

// 21 de Maio de 1993
const DATE = /[0-3]?\d\s+de\s+[A-Z][a-zç]{3,8}\s+de\s+[12]\d{3}/;