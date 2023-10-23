using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// *FEITO*
Nokia nokia = new Nokia("9 9999-9988", "Nokia Z1", "999.999", 128);
Console.WriteLine("Bem vinde ao seu Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Hello Nokia");

Iphone iphone = new Iphone("9 9999-9987", "Iphone 13 Plus", "999.998", 250);
Console.WriteLine("Bem vinde ao seu Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Hello Apple");