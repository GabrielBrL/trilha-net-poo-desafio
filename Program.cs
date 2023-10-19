using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("1199999999");
Nokia nokia = new Nokia("1199999999");

Console.WriteLine(iphone.Numero);
Console.WriteLine(nokia.Numero);

nokia.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("WhatsApp");