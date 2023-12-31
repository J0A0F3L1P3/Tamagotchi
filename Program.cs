using System;

internal class Tamagotchi
{
    static void Main()
    {
        // Variáveis globais
        Console.WriteLine("Escreva o nome do seu Tamagotchi");
        string nome = Console.ReadLine();
        nome = nome == "" ? "Tamagotchi" : nome;

        int fome = 20;
        int sede = 25;
        int feliz = 50;
        string Abandonar = "nao";

        while (Abandonar == "nao")
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
            Console.WriteLine("  {|6 6|}     fome: " + fome);
            Console.WriteLine("   (_0_)      sede: " + sede);
            Console.WriteLine("  _| ^ |_     feliz: " + feliz);
            Console.WriteLine(" (_|_|_|_)");
        }

        void Acao()
        {
            Console.WriteLine("\n========== Ação ==========");
            Console.WriteLine("1. Alimentar  2. Dar água\n3. Brincar    4. Abandonar");
            Console.Write("\nInsira o número da ação: ");
            int acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 1:
                    fome = fome >= 10 ? fome -= 10 : 0;
                    sede += 5;
                    feliz -= 5;
                    break;
                case 2:
                    sede = sede >= 5 ? sede -= 5 : 0;
                    feliz -= 5;
                    break;
                case 3:
                    fome += 10;
                    sede += 5;
                    feliz = feliz <= 90 ? feliz += 10 : 100;
                    break;
                case 4:
                    Abandonar = "sim";
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        void VerificarVida()
        {
            if (fome >= 100 || sede >= 100 || feliz <= 0)
            {
                Abandonar = "sim";
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
