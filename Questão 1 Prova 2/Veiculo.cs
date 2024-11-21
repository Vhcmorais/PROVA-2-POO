public abstract class Veiculo
{
    public string Placa { get; set; }
    public int Ano { get; set; }

    public Veiculo(string placa, int ano)
    {
        Placa = placa;
        Ano = ano;
    }

    public abstract double Alugar();
}