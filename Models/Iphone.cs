namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, int memoria, string marca, string imei) : base(numero, memoria, marca, imei)
        {

        }
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Imprimir a mensagem "Instalando aplicativo {nomeApp} na AppStore"
            System.Console.WriteLine($"Instalando aplicativo {nomeApp} na AppStore");
        }
    }
}