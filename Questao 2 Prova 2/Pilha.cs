using System;
using System.Collections.Generic;

class Pilha
{
    private Stack<string> pilhaDePecas = new Stack<string>();

    public Pilha()
    {
        pilhaDePecas.Push("Hélice");
        pilhaDePecas.Push("Suporte");
        pilhaDePecas.Push("Hélice");
        pilhaDePecas.Push("Cúpula de vidro");
        pilhaDePecas.Push("Lâmpada");
    }

    public void ExibirPilha()
    {
        Console.WriteLine("Estado atual da pilha de peças:");
        foreach (var peca in pilhaDePecas)
        {
            Console.WriteLine(peca);
        }
        Console.WriteLine();
    }
    public void TrocarPeca(string pecaVelha, string pecaNova)
    {
        Stack<string> pecasRemovidas = new Stack<string>();
        bool encontrouPeca = false;

        Console.WriteLine($"Iniciando troca da peça '{pecaVelha}' por '{pecaNova}'...\n");

        while (pilhaDePecas.Count > 0)
        {
            string pecaAtual = pilhaDePecas.Pop();
            if (pecaAtual == pecaVelha)
            {
                Console.WriteLine($"Peça encontrada: {pecaVelha}. Realizando a troca...\n");
                pilhaDePecas.Push(pecaNova);
                encontrouPeca = true;
                break;
            }
            else
            {
                pecasRemovidas.Push(pecaAtual);
            }
        }

        if (!encontrouPeca)
        {
            Console.WriteLine($"Peça '{pecaVelha}' não encontrada. A troca não foi realizada.\n");
        }

        while (pecasRemovidas.Count > 0)
        {
            pilhaDePecas.Push(pecasRemovidas.Pop());
        }

        Console.WriteLine("Troca realizada e peças remontadas.\n");
    }
}