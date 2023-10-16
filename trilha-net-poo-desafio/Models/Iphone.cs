using System;// Certifique-se de que o namespace está correto.

namespace DesafioPOO.Models;
public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) 
    : base(numero, modelo, imei, memoria)
    {
    }



    // Sobrescrever o método "InstalarAplicativo" da classe base Smartphone

    public override void InstalarAplicativo(string nomeApp)
    {
        // Implemente o comportamento específico da instalação de aplicativos para um Nokia aqui.
        Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Iphone...");
        // Adicione sua lógica de instalação específica da Nokia, se houver.
    }
}
