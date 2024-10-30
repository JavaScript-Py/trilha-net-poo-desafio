using DesafioPOO.Models;

namespace DesafioPOO
{
  class Program
  {
    static void Main()
    {
      Nokia nokia = new("123456789", 32, "Nokia", "123456789");
      Console.WriteLine(nokia.Numero);
      Console.WriteLine(nokia.Memoria);
      Console.WriteLine(nokia.Marca);
      Console.WriteLine(nokia.Imei);
      nokia.Ligar();
      nokia.ReceberLigacao();

      nokia.InstalarAplicativo("WhatsApp");

      Iphone iphone = new("987654321", 64, "Apple", "987654321");
      Console.WriteLine(iphone.Numero);
      Console.WriteLine(iphone.Memoria);
      Console.WriteLine(iphone.Marca);
      Console.WriteLine(iphone.Imei);
      iphone.InstalarAplicativo("Instagram");
      iphone.Ligar();
      iphone.ReceberLigacao();

    }
  }
}