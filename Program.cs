using DesafioPOO.Models;

Nokia nokia = new(numero: "991047435",modelo: "N3380",imei: "418547215848544846454",memoria: 64);
Iphone iphone = new("991000902","Pro MAX","454545412158422454",128);


System.Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine();

System.Console.WriteLine("Smartphone Iphone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");