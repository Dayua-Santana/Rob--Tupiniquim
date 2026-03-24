class Progam
{

    static void Main(string[] args)
    {
        do
        {
            Robo.RodandoRobo();


            Console.WriteLine("Deseja continuar(s/N): ");
            string usuario = Console.ReadLine() ?? "";
            if (usuario.ToUpper() != "S")
                break;

        } while (true);


    }
}
