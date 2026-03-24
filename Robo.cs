using System;

class Robo
{

    public static int x;
    public static int y;
    public static char direcao;
    public static void RodandoRobo()
    {
        Console.WriteLine("-- Configuração Inicial ---");
        Console.WriteLine("Digite a posição X: ");
        int.TryParse(Console.ReadLine(), out x);

        Console.WriteLine("Digite a posição Y: ");
        int.TryParse(Console.ReadLine(), out y);

        Console.WriteLine("Digite a Direção ( N, S ,L ,O ): ");
        char.TryParse(Console.ReadLine(), out direcao);

        direcao = char.ToUpper(direcao);

        Console.Write("Digite a sequência de comandos: ");
        string comandos = Console.ReadLine() ?? "";

        foreach (char comando in comandos.ToUpper())
        {
            switch (char.ToUpper(comando))
            {
                case 'M':
                    Robo.Mover(); break;
                case 'E':
                    Robo.GirarEsquerda(); break;
                case 'D':
                    Robo.GirarDireita(); break;
            }
        }
        Console.WriteLine($"\nPosição alcançada: {x} {y} {direcao}");

    }
    public static void GirarDireita()
    {
        if (direcao == 'N')
            direcao = 'L';
        else if (direcao == 'L')
            direcao = 'S';
        else if (direcao == 'S')
            direcao = 'O';
        else if (direcao == 'O')
            direcao = 'N';
    }

    public static void GirarEsquerda()
    {
        if (direcao == 'N')
            direcao = 'O';
        else if (direcao == 'O')
            direcao = 'S';
        else if (direcao == 'S')
            direcao = 'L';
        else if (direcao == 'L')
            direcao = 'N';
    }

    public static void Mover()
    {
        if (direcao == 'N')
            y++;
        else if (direcao == 'S')
            y--;
        else if (direcao == 'L')
            x++;
        else if (direcao == 'O')
            x--;
    }

}