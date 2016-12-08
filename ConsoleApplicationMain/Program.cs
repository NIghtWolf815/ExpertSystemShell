using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMain
{
    class Program
    {
        //string Menu = "1.Добавить\r\n2.Изменить\r\n3.Удалить";

        
        static void Main(string[] args)
        {
            List<string[]> superlist= new List<string[]>();            
            string[] tempString = new string[5];
            string y="y";
            while ("y"==y)
            {
            string Menu = "1.Добавить\r\n2.Изменить\r\n3.Удалить";
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine(Menu);
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("\nВведите название проекта:");
                        tempString[0] = Console.ReadLine();
                        Console.WriteLine("Введите механизм хранения:");
                        tempString[1] = Console.ReadLine();
                        Console.WriteLine("Введите тип базы знаний:");
                        tempString[2] = Console.ReadLine();
                        Console.WriteLine("Введите механизм вывода:");
                        tempString[3] = Console.ReadLine();
                        Console.WriteLine("Введите правило:");
                        tempString[4] = Console.ReadLine();
                        superlist.Add(tempString);
                        Console.WriteLine(Menu);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nВыберите проект:");
                        int sch=1;
                        foreach(string[] a in superlist)
                        {
                            Console.WriteLine(sch +") "+ a[0]);
                            sch++;
                        }
                        
                        try
                        {
                            int a1 = int.Parse(Console.ReadLine()) - 1;
                            tempString = superlist[a1];
                            Console.WriteLine("\nВведите название проекта:");
                            tempString[0] = Console.ReadLine();
                            Console.WriteLine("Введите механизм хранения:");
                            tempString[1] = Console.ReadLine();
                            Console.WriteLine("Введите тип базы знаний:");
                            tempString[2] = Console.ReadLine();
                            Console.WriteLine("Введите механизм вывода:");
                            tempString[3] = Console.ReadLine();
                            Console.WriteLine("Введите правило:");
                            tempString[4] = Console.ReadLine();
                            superlist[a1] = tempString;
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("\nЧто-то пошло не так!");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nВыберите проект:");
                        int sch = 1;
                        foreach (string[] a in superlist)
                        {
                            Console.WriteLine(sch + ") " + a[0]);
                            sch++;
                        }
                        try
                        {
                            int a1 = int.Parse(Console.ReadLine()) - 1;
                            superlist.RemoveAt(a1);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nЧто-то пошло не так!");
                        }
                        break;
                    }

            }
            /*tempString = null;*/ tempString = new string[5];
            Console.WriteLine("\nПродолжить?[y/n]");
            y = Console.ReadLine();
        }
            Console.ReadKey();
        }
    }
}
