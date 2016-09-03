using System;
using System.IO;

namespace CombolistEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string currentVersionNumber = "0.1.0";
            Console.WriteLine("CombolistEditor | Version " + currentVersionNumber);
            Console.WriteLine("What would you like to do? (Enter the corresponding number)");
            Console.WriteLine("1. Edit existing Combolist");
            Console.WriteLine("x. Exit");
            MenuItemAction menu = new MenuItemAction
            {
                GetCharacter = Console.ReadLine()
            };
            Console.Clear();
            //1. Edit existing Combolist
            //Combolist file already exists
            if (menu.GetCharacter == "1")
            {
                Console.WriteLine("What is the directory of the existing Combolist?");
                menu.FileDirectory = Console.ReadLine();
                Console.WriteLine("What is the name of the file? (Example: \'comboTextlist.txt\')");
                menu.FileName = Console.ReadLine();
                //If the textfile is empty
                if (new FileInfo(menu.FileDirectoryAndName()).Length == 0)
                {
                    //Make exit function
                }
                else
                {
                    ComboList textFile = new ComboList
                    {
                        TextFileLines = ""
                    };
                    using (StreamReader reader = new StreamReader(menu.FileDirectoryAndName()))
                    {

                        textFile.AppendLine(reader.ReadLine());
                        textFile.AppendLine(reader.ReadLine());
                        textFile.AppendLine(reader.ReadLine());
                        textFile.AppendLine(reader.ReadLine());
                        textFile.AppendLine(reader.ReadLine());

                    }
                RESEPARATE:
                    Console.WriteLine("Printing sample of text file... " + Environment.NewLine);
                    Console.WriteLine(textFile.TextFileLines);
                    Console.WriteLine("What is separating the list?");
                    menu.GetCharacter = Console.ReadLine();
                    foreach (char letter in textFile.TextFileLines)
                    {
                        if (letter == Convert.ToChar(menu.GetCharacter))
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(letter);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(letter);
                        }
                    }
                    Console.WriteLine(Environment.NewLine + "What would you like to do?");
                    Console.WriteLine("1. Reselect seperating character");
                    Console.WriteLine("2. Change seperating character");
                    Console.WriteLine("x. Exit");
                    menu.GetCharacter = Console.ReadLine();
                    if (menu.GetCharacter == "1")
                    {
                        Console.Clear();
                        goto RESEPARATE;
                    }
                }

            }
            else if (menu.GetCharacter == "x")
            {
                Console.Clear();
                Environment.Exit(0);
            }






            Console.ReadKey();
        }


    }
}
