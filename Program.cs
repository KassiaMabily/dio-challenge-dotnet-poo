using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123123", modelo: "Modelo 1", imei: "11111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 2", imei: "22222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
