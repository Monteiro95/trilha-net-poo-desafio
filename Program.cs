using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 01", imei: "111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whats");

Console.WriteLine("Smartphone Samsung: ");
Smartphone iphone = new Iphone(numero: "124", modelo: "Modelo 02", imei: "112", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");