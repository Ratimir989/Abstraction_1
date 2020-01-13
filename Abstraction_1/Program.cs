using System;

namespace Abstraction_1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();

            Console.WriteLine("Введите текст для записи в файл:");
            string text = Console.ReadLine();

            Console.WriteLine("Введен текст для записи в файл!");
            
        }

        public override void Create()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml создан!");
        }

        public override void Open()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml открыт!");
        }

        public override void Save()
        {
            Console.WriteLine("Метод Save(). файл сохранен");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();

            Console.WriteLine("Введите текст для записи в файл:");
            string text = Console.ReadLine();

            Console.WriteLine("Введен текст для записи в файл!");

        }

        public override void Create()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml создан!");
        }

        public override void Open()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml открыт!");
        }

        public override void Save()
        {
            Console.WriteLine("Метод Save(). файл сохранен");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();

            Console.WriteLine("Введите текст для записи в файл:");
            string text = Console.ReadLine();

            Console.WriteLine("Введен текст для записи в файл!");

        }

        public override void Create()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml создан!");
        }

        public override void Open()
        {
            Console.WriteLine("Введите название файла :");
            string name = Console.ReadLine();
            Console.WriteLine($"Файл {name}.xml открыт!");
        }

        public override void Save()
        {
            Console.WriteLine("Метод Save(). файл сохранен");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadLine();
        }

        static void MainMenu()
        {
            Console.WriteLine("Выберите формат файла:\n1) .xml\n2) .txt\n3) .doc");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SubMenu(1);
                    break;
                case "2":
                    SubMenu(2);
                    break;
                case "3":
                    SubMenu(3);
                    break;
                default:
                    Console.WriteLine("Выберите вариант из предложенных!");
                    MainMenu();
                    break;
            }
        }

        static void SubMenu(int i)
        {
            Console.WriteLine("Выберите действие с файлом:\n1) Создание.\n2) Открытие.\n3) Редактирование.\n4) Сохранение.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Create();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Create();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Create();
                            break;
                    }
                    MainMenu();
                    break;
                case "2":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Open();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Open();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Open();
                            break;
                    }
                    MainMenu();
                    break;
                case "3":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Change();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Change();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Change();
                            break;
                    }
                    MainMenu();
                    break;
                case "4":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Save();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Save();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Save();
                            break;
                    }
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Выберите вариант из предложенных!");
                    SubMenu(i);
                    break;
            }
        }
    }
}
