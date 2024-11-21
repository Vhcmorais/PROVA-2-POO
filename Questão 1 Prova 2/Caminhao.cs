public class Caminhao : Veiculo
{
    public int Eixos { get; set; }

    public Caminhao(string placa, int ano, int eixos) : base(placa, ano)
    {
        Eixos = eixos;
    }

    public override double Alugar()
    {
        int anoAtual = DateTime.Now.Year;
        return (300 * Eixos) - ((anoAtual - Ano) * 50);
    }
}