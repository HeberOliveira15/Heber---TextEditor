using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo:");
            Console.WriteLine("2 - Criar novo arquivo:");
            Console.WriteLine("0 - Sair.");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;

            }

        }
        static void Abrir() { }
        static void Editar()
        {

            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------");
            string text = "";

            do
            {
                text += Console.ReadLine(); // vai pegar o que o usuario digitou e colocar nessa variavel, colocando += ele junta com o que ja tem no texto mais o que o usuario digitou 
                text += Environment.NewLine;
            } // Do = faça isso enquanto o usuario nao pressionar a tecla escape, quando ele digitar dai ele vai sair
            while (Console.ReadKey().Key != ConsoleKey.Escape); //só vai entrar nessa condição se ela for verdadeira
            Salvar(text);
        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo ?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com Sucesso!");
            Console.ReadLine();
            Menu();

        }
    }

}

