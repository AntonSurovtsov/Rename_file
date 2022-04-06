using System;

namespace Rename_file
{
    public static class Symbols
    {
        public static void Get_symbols(ref string symbols, ref string newSymbols, ref string[] name)
        {
            while (symbols == "" || newSymbols == "")
            {
                Console.Write("Введите символы, которые необходимо заменить: ");
                symbols = Console.ReadLine();

                if (symbols == "" || !name[0].Contains(symbols))
                {
                    Console.Clear();
                    continue;
                }
                Console.Write("Введите символы, которые нужно вставить: ");
                newSymbols = Console.ReadLine();

                if (newSymbols == "")
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
