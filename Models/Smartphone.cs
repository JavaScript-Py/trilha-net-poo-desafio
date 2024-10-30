namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; set; }
        public string Marca { get; set; }

        public int Memoria { get; set; }
        public Smartphone(string numero, int memoria, string marca, string imei)
        {
            Numero = numero;
            Memoria = memoria;
            Marca = marca;
            Imei = imei;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}