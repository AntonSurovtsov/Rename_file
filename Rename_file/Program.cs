using System;
using System.IO;
using System.Windows.Forms;

namespace Rename_file
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            Console.Write("Нажмите Enter, чтобы продолжить...");

            while (true)
            {
                Console.ReadLine();
                Console.Clear();

                if (openFileDialog.ShowDialog() != DialogResult.OK) continue;

                string [] name = openFileDialog.FileNames;
                string symbols = "", newSymbols = "";

                Symbols.Get_symbols(ref symbols, ref newSymbols, ref name);

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
