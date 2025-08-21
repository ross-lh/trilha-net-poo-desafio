namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"\n[{Modelo}] Instalando o aplicativo {nomeApp}..." +
            $"\n[{Modelo}] Abrindo a App Store" +
            $"\n[{Modelo}] Baixando o aplicativo {nomeApp}" +
            $"\n[{Modelo}] Instalando o aplicativo {nomeApp}" +
            $"\n[{Modelo}] Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}