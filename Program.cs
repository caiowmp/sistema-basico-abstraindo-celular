using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("91993836","Modelo Padrão","71",64);
nokia.Ligar();
nokia.InstalarAplicativo("Nubank");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone("91993836","Modelo Padrão","71",64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Banco Inter");