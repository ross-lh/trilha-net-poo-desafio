namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"\n[{Modelo}] Instalando o aplicativo {nomeApp}..." +
            $"\n[{Modelo}] Abrindo a Google Play Store" +
            $"\n[{Modelo}] Baixando o aplicativo {nomeApp}" +
            $"\n[{Modelo}] Instalando o aplicativo {nomeApp}" +
            $"\n[{Modelo}] Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}