class Program
{
    static void Main(string[] args)
    {
        Pilha ventilador = new Pilha();

        // Exibe o estado inicial da pilha
        ventilador.ExibirPilha();

        // Realiza a troca da hélice quebrada por uma nova hélice
        ventilador.TrocarPeca("Hélice", "Hélice nova");

        // Exibe o estado da pilha após a troca
        ventilador.ExibirPilha();
    }
}
