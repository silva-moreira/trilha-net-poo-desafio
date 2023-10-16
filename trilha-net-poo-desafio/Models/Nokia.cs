using System; // Certifique-se de que o namespace System esteja incluído para o Console.WriteLine.

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // O construtor da classe Nokia deve chamar o construtor da classe base Smartphone
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implemente o comportamento específico da instalação de aplicativos para um Nokia aqui.
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia...");
            // Adicione sua lógica de instalação específica da Nokia, se houver.
        }
    }
}
