using System.Globalization;


Console.WriteLine("Hello, World");

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartao de Debito --");

Cartao CartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);