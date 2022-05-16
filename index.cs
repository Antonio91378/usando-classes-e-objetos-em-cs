using System;

public class Jogador
{
    // por ser private, eu só posso alterar o valor 'energia' dentro da classe, podendo utilizar métodos.
    private int energia;

    public bool vivo;

    public string nome;

    public Jogador(string nome)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public void info()
    {
        Console.WriteLine (nome);
        Console.WriteLine (energia);
    }
}

public class Inimigo
{
    public string nome;

    //todos os inimigos criados apontaram para o mesmo valor de alerta com o static
    public static bool alerta;

    //criando o construtor
    public Inimigo(string nome)
    {
        this.nome = nome;
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

        Console.WriteLine("escreva a energia do jogador :");
        j1.setEnergia(int.Parse(Console.ReadLine()));
        j1.info();
    }
}
