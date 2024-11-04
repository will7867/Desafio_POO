using DesafioPOO.models;


Console.WriteLine("Smartphone Nokia:");
SmartPhone nokia = new Nokia(numero:"123445", modelo: "Modelo 1", imei:"111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
SmartPhone iphone = new Iphone(numero:"67567", modelo: "Modelo 2", imei:"222222", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegran");