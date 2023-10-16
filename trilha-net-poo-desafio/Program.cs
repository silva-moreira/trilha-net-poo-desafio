using System; // Certifique-se de que o namespace System esteja incluído para o Console.WriteLine.
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar um objeto Nokia
        var nokia = new Nokia("123456", "Nokia 8", "IMEI123", 64);

        // Criar um objeto Iphone
        var iphone = new Iphone("789012", "iPhone 12", "IMEI456",0);

        // Realizar ações com os smartphones
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
