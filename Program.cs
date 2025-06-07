using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("123456", "nokia01", "a1a1a1a1", 256);
Iphone i1 = new Iphone("33333333", "10s", "i1i1i1i1i1i1i", 128);

n1.Ligar();
n1.ApresentarInformacoes();
n1.ReceberLigacao();
n1.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

i1.Ligar();
i1.ApresentarInformacoes();
i1.ReceberLigacao();
i1.InstalarAplicativo("facebook");