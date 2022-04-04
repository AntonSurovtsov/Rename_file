using System;
using System.IO;
using System.Windows.Forms;

namespace Rename_file
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            Console.Write("Нажмите Enter, чтобы продолжить...");

            while (true)
            {
                Console.ReadLine();
                Console.Clear();

                if (openFileDialog.ShowDialog() != DialogResult.OK) continue;

                string [] name = openFileDialog.FileNames;
                string symbols = "", newSymbols = "";

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
                for (int i = 0; i < name.Length; i++)
                {
                string newName = name[i].Replace(symbols, newSymbols);
                File.Move(name[i], newName);
                }
                Console.Write("Готово!");
            }
        }
    }
}
