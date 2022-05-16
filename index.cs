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

public class Inimigo
{
    public string nome;

    public static bool alerta;

    //criando o construtor
    public Inimigo(string name)
    {
        nome = name;
        alerta = false;
    }

    public void info()
    {
        Console.WriteLine (nome);
        Console.WriteLine (alerta);
    }
}

class Principal
{
    static void Main()
    {
        Jogador j1 = new Jogador("Carlos");
        Inimigo I1 = new Inimigo("dragao");
        Inimigo I2 = new Inimigo("esqueleto");
        Inimigo I3 = new Inimigo("fadacomcirrose");

        Inimigo.alerta = true;
        I1.info();
        I2.info();
        I3.info();
    }
}
