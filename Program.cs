using DesafioPOO.Models;

Smartphone c1 = new Nokia("223303", "Nokia 123", "128237c8", 390);
c1.Ligar();
c1.ReceberLigacao();
c1.InstalarAplicativo("Instagram");
Console.WriteLine();

Smartphone c2 = new Iphone("223303", "Iphone 12a3", "128237c8", 390);
c2.Ligar();
c2.ReceberLigacao();
c2.InstalarAplicativo("Instagram");
Console.WriteLine();