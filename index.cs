using System;

public class Jogador
{
    public int energia;

    public bool vivo;

    public string nome;

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
}

class Principal
{
    static void Main()
    {
        Jogador j1 = new Jogador("Carlos");
        Jogador j2 = new Jogador("Antonio");
        Jogador j3 = new Jogador("Lucas");

        Console.WriteLine("O nome do jogador 1 é : {0}", j1.nome);
        Console.WriteLine("O nome do jogador 2 é : {0}", j2.nome);
        Console.WriteLine("O nome do jogador 3 é : {0}", j3.nome);
    }
}
