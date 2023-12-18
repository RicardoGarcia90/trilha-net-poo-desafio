using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1195353-5353", modelo: "Modelo 1", imei: "11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1191212-1212", modelo: "Modelo 2", imei: "22222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
