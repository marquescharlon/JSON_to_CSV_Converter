namespace AppConverterConsole
{
    public static class Menu
    {
        public static void Visualizar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTelaMenu();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());

            if (opcao < 0 || opcao > 2)
            {
                Menu.Visualizar();
            }
            else
            {
                AcoesMenuOpcoes(opcao);
            }
        }

        public static void DesenharTelaMenu()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 9; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Opcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Conversor de JSON para CSV");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Converter");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("Opção: ");
        }

        public static void AcoesMenuOpcoes(short opcao)
        {
            switch (opcao)
            {
                case 1: Converter.JsonToCSV(); break;
                case 2:
                    {
                        Console.Clear();
                        Menu.Visualizar();
                        break;
                    }

                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        public static void LimparTela()
        {
            DesenharTelaConverter();
            Console.WriteLine("Deseja limpar a tela e realizar uma nova conversão? 1=Sim / 0=Não");
            var opcao = short.Parse(Console.ReadLine());

            if (opcao == 0 || opcao == 1)
            {
                switch (opcao)
                {
                    case 1: Converter.JsonToCSV(); break;
                    case 0: Menu.Visualizar(); break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
                Menu.LimparTela();
            }
        }

        public static void DesenharTelaConverter()
        {
            Console.Write("+");
            for (int i = 0; i <= 80; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}