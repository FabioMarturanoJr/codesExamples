using NacktBank.AgencySystem.helpers;

string URL = "https://www.byteddbank.com.br/exchange?originCurrency=real&destinyCurrency=dolar&value=1500";

try
{
    extratorArgumentsByUrl urlFull = new extratorArgumentsByUrl(URL);  
    System.Console.WriteLine(urlFull.Arguments);
    System.Console.WriteLine(urlFull.GetValue("value"));
}
catch (System.Exception e)
{
    System.Console.WriteLine(e.Message);
}
