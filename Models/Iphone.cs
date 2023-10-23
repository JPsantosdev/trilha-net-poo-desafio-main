namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // *FEITO*
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // *FEITO*
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu Iphone");
        }
    }
}