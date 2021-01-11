using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите ключ продукта: (1 - про, 2 - эксперт, пусто - бесплатная версия)");
            string answer = Console.ReadLine();
            Console.WriteLine("\n");

            IDocumentWorker docWorker = DocumentWorkerFactory.GetInstance(answer);

            if (docWorker == null)
            {
                Console.WriteLine("Ключ введен некорректно");
                return;
            }

            do
            {
                Console.WriteLine("Выбор пункта меню:");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Открыть документ");
                Console.WriteLine("2 - Редактировать документ");
                Console.WriteLine("3 - Сохранить документ");

                answer = Console.ReadLine();
                Console.WriteLine("\n");

                switch (answer)
                {
                    case "0":
                        Console.WriteLine("Выполняем выход из программы...");
                        break;
                    case "1":
                        docWorker.OpenDocument();
                        break;
                    case "2":
                        docWorker.EditDocument();
                        break;
                    case "3":
                        docWorker.SaveDocument();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор меню, попробуйте еще раз");
                        break;
                }
                Console.WriteLine("\n");
            } while (answer != "0");
        }
    }
}
