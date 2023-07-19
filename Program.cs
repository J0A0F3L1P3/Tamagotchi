using System;

internal class Tamagotchi
{
    static void Main()
    {
        // Variáveis globais
        Console.WriteLine("Escreva o nome do seu Tamagotchi");
        string nome = Console.ReadLine();
        nome = nome == "" ? "Tamagotchi" : nome;

        int apetite = 80;
        int sede = 10;
        int felicidade = 50;
        string sair = "nao";

        while (sair == "nao")
        {
            MostrarPet();
            Acao();
            VerificarVida();
        }

        void MostrarPet()
        {
            Console.Clear();
            Console.WriteLine($"========== {nome} ==========");
            Console.WriteLine("    ,,,");
            Console.WriteLine("  {|6 6|}     apetite: " + apetite);
            Console.WriteLine("   (_0_)      sede: " + sede);
            Console.WriteLine("  _| ^ |_     felicidade: " + felicidade);
            Console.WriteLine(" (_|_|_|_)");
        }

        void Acao()
        {
            Console.WriteLine("\n============= Ação =============");
            Console.WriteLine("1. Alimentar  2. Dar água\n3. Brincar    4. Sair");

            Console.Write("\nO que fazer? ");
            int acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 1:
                    if (apetite >= 90)
                    {
                        Console.WriteLine("Não está com fome no momento.");
                    }
                    else
                    {
                        apetite += 10;
                        sede += 5;
                        felicidade -= 5;
                        if (felicidade < 0)
                        {
                            felicidade = 0;
                        }
                    }
                    break;
                case 2:
                    if (sede <= 5)
                    {
                        Console.WriteLine("Não está com sede no momento.");
                    }
                    else
                    {
                        sede -= 5;
                    }
                    break;
                case 3:
                    if (apetite <= 10)
                    {
                        Console.WriteLine("Está com fome demais para brincar.");
                    }
                    else if (sede >= 5)
                    {
                        apetite -= 10;
                        sede -= 5;
                        felicidade += 5;
                        if (felicidade > 100)
                        {
                            felicidade = 100;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Está com sede demais para brincar.");
                    }
                    break;
                case 4:
                    sair = "sim";
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        void VerificarVida()
        {
            if (apetite <= 0 || sede >= 100 || felicidade <= 0)
            {
                sair = "sim";
                Console.Clear();
                Console.WriteLine("         _____");
                Console.WriteLine("        | ~~~ |");
                Console.WriteLine("        |R.I.P|");
                Console.WriteLine("      ,,|_____|,,,");
                Console.WriteLine("\nSeu Tamagotchi morreu.\n");
            }
        }
    }
}