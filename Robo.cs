using System;

class Robo
{

    public static int x;
    public static int y;
    public static char direcao;
    public static void RodandoRobo()
    {
        Console.Write("Digite a posição inicial (X Y Orientação): ");
        string inputPosicao = Console.ReadLine() ?? "";
        string[] partes = inputPosicao.Split(' ');
        if (partes.Length == 3)
        {
            int.TryParse(partes[0], out x);
            int.TryParse(partes[1], out y);
            char.TryParse(partes[2].ToUpper(), out direcao);
        }
        Console.WriteLine("Digite a sequência de comandos: ");
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