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
            Console.WriteLine("  {|6 6|}     apetite: " + apetite);
            Console.WriteLine("   (_0_)      sede: " + sede);
            Console.WriteLine("  _| ^ |_     felicidade: " + felicidade);
            Console.WriteLine(" (_|_|_|_)");
        }

        void Acao()
        {
            Console.WriteLine("\n============= Ação =============");
            Console.WriteLine("1. Alimentar  2. Dar água\n3. Brincar    4. Abandonar");
            Console.WriteLine("    (Digite o número)");

            Console.Write("\nO que fazer? ");
            int acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 1:
                    apetite = apetite <= 90 ? apetite += 10 : 100;
                    sede = sede >= 5 ? sede += 5 : 0;
                    felicidade = felicidade <= 90 ? felicidade -= 5 : 100;
                    break;
                case 2:
                    sede = sede >= 5 ? sede -= 5 : 0;
                    felicidade = felicidade <= 95 ? felicidade -= 5 : 100;
                    break;
                case 3:
                    apetite = apetite >= 10 ? apetite -= 10 : 0;
                    sede = sede >= 5 ? sede += 5 : 0;
                    felicidade = felicidade <= 90 ? felicidade += 10 : 100;
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
            if (apetite <= 0 || sede >= 100 || felicidade <= 0)
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
