using IU.Planning.ConApp.Models;
using System;

namespace IU.Planning.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStore<Event> store = null;
           store = new EventStore();

            while (true)
            {
                Console.WriteLine("1. Добавить событие");
                Console.WriteLine("2. Показать все события");

                // получить выбор пользователя
                var select = Console.ReadLine();
                switch (select)
                {
                    case "0":
                        {
                            Console.Clear();
                            break;
                        }

                    case "1":
                        {
                            // если выбрано Добавить
                            // просим ввести title и дату
                            Console.WriteLine("Введите тему");
                            var line = Console.ReadLine();
                            // сохраняем в хранилище
                            var evt = new Event();
                            evt.Title = line;
                            store.Add(evt);
                            // пишем, что все хорошо
                            Console.WriteLine("Все хорошо");
                            break;
                        }


                    case "2":
                        {
                            // если выбрано показать
                            Console.WriteLine("События");
                            // перебираем все значения из хранилища
                            foreach (var evt in store.Entities)
                            {
                                // выводим их на экран
                                Console.WriteLine(evt.Title);
                            }
                            break;

                        }
                    default:
                        break;
                }
            }
        }
    }
}
