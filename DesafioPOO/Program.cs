using DesafioPOO.Models;

Console.Clear();

// Instanciando os objetos Nokia e Iphone

Nokia nokia1 = new Nokia("11 94838-3231", "Nokia 3310", "123456789012345", 64);
Iphone iphone1 = new Iphone("11 94838-2394", "iPhone 14 Pro", "987654321098765", 128);

// Testando o Nokia

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n---------------------------------\n");
// Testando o iPhone

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("FaceTime");
// TODO: Realizar os testes com as classes Nokia e Iphone