using DesafioPOO.Models;

Iphone iphone = new Iphone("88 9 8153-9093", "Modelo1", "IMEI1", 256);
Nokia nokia = new Nokia("88 9 8153-9093", "Modelo2", "IMEI2", 256);

iphone.InstalarAplicativo("whatsapp");
nokia.InstalarAplicativo("whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();

nokia.Ligar();
nokia.ReceberLigacao();

System.Console.WriteLine(iphone);
System.Console.WriteLine(nokia);