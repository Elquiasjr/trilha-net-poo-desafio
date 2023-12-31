using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
Nokia nokia = new Nokia(numero: "553212324380", modelo: "Lumia 620", imei: "546576-83-219812-9", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pou");
nokia.InstalarAplicativo("Minecraft");

Console.WriteLine("\n");

Console.WriteLine("Celular IPhone:");
Iphone iphone = new Iphone(numero: "11221122900", modelo: "13 Pro Max", imei: "123456-70-987654-3", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Chess Online");
