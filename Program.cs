using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia Smartphone");
Nokia nokia = new("77 9595959595", "1100", "123456#123456", 4);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake game");




Console.WriteLine("Iphone Smartphone");
Iphone iphone = new("77 5959595959", "iphone", "123456#123456", 8);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Orkut");