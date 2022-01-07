using NacktBank.AgencySystem.helpers;

string URL = "https://www.bytebank.com.br/exchange?originCurrency=real&destinyCurrency=dolar&value=1500";

extratorArgumentsByUrl urlFull = new extratorArgumentsByUrl(URL);

System.Console.WriteLine(urlFull.Arguments);