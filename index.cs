using System;

public class Jogador
{
    public int energia = 100;

    public bool vivo = true;
}

class Principal
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        Console.WriteLine("A energia do jogador 1 é : {0}", j1.energia);
    }
}
