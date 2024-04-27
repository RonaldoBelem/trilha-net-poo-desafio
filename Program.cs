using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("987654321","66123456789","Nokia",64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");


Iphone iphone = new Iphone("987654321", "66123456789", "iphone", 64);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");