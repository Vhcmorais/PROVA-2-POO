public class Onibus : Veiculo
{
    public int Assentos { get; set; }

    public Onibus(string placa, int ano, int assentos) : base(placa, ano)
    {
        Assentos = assentos;
    }

    public override double Alugar()
    {
        int anoAtual = DateTime.Now.Year;
        return (30 * Assentos) - ((anoAtual - Ano) * 70);
    }
}