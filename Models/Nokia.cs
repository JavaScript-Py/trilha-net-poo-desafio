namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria, string marca, string imei) : base(numero, memoria, marca, imei)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            // Imprimir a mensagem "Instalando aplicativo {nomeApp} na OviStore"
            System.Console.WriteLine($"Instalando aplicativo {nomeApp} na OviStore");
        }

    }
}