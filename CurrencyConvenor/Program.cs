using System;

namespace CurrencyConvenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub, usd, eur;
            float usdToRub = 57.02f;
            float eurToRub = 59.64f;
            float eurToUsd = 1.035f;
            float currencyCount;
            float currentOperation;
            string userInput = "";

            Console.WriteLine("Добро пожаловать в обменный пункт, укажите количество вашей валюты :");
            Console.Write("Сколько у вас рублей? : ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас доларров? : ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас евро? : ");
            eur = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите доступные операции :");
            Console.WriteLine("1 Показать обменный курс");
            Console.WriteLine("2 Показать ваш текущий баланс");
            Console.WriteLine("3 Обмен рублей на доллары");
            Console.WriteLine("4 Обмен рублей на евро");
            Console.WriteLine("5 Обмен доллары на рубли");
            Console.WriteLine("6 Обмен доллары на евро");
            Console.WriteLine("7 Обмен евро на рубли");
            Console.WriteLine("8 Обмен евро на доллары");
            Console.WriteLine("EXIT Завершить обслуживание");

            while (userInput != "EXIT")
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"Курс доллара к рублю: {usdToRub}");
                        Console.WriteLine($"Курс евро к рублю: {eurToRub} , к доллару: {eurToUsd}");
                        Console.Write("Введите команду : ");
                        break;
                    case "2":
                        Console.WriteLine($"Ваш баланс составляет: {rub} рублей , {usd} долларов , {eur} евро");
                        Console.Write("Введите команду : ");
                        break;
                    case "3":
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько рублей вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            currentOperation = currencyCount / usdToRub;
                            usd += currencyCount / usdToRub;
                            Console.WriteLine($"Преобретено : {currentOperation} долларов, остаток рублей : {rub} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "4":
                        Console.WriteLine("Обмен рублей на евро");
                        Console.Write("Сколько рублей вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            currentOperation = currencyCount / eurToRub;
                            eur += currentOperation;
                            Console.WriteLine($"Преобретено : {currentOperation} евро, остаток рублей : {rub} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "5":
                        Console.WriteLine("Обмен доллары на рубли");
                        Console.Write("Сколько долларов вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            currentOperation = currencyCount * usdToRub;
                            rub += currentOperation;
                            Console.WriteLine($"Преобретено : {currentOperation} рублей, остаток долларов : {usd} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "6":
                        Console.WriteLine("Обмен доллары на евро");
                        Console.Write("Сколько долларов вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            currentOperation = currencyCount / eurToUsd;
                            eur += currentOperation;
                            Console.WriteLine($"Преобретено : {currentOperation} евро, остаток долларов : {usd} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "7":
                        Console.WriteLine("Обмен евро на рубли");
                        Console.Write("Сколько евро вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            currentOperation = currencyCount * eurToRub;
                            rub += currentOperation;
                            Console.WriteLine($"Преобретено : {currentOperation} рублей, остаток евро : {eur} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "8":
                        Console.WriteLine("Обмен евро на доллары");
                        Console.Write("Сколько евро вы хотите обменять? : ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;

                            currentOperation = currencyCount * eurToUsd;
                            usd += currentOperation;
                            Console.WriteLine($"Преобретено : {currentOperation} долларов, остаток евро : {eur} ");
                        }
                        else
                        {
                            Console.WriteLine("Не корректное значение, выберите другую операцию!");
                        }

                        Console.Write("Введите команду : ");
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("Не известная команда, выберите другую операцию!");
                        break;
                }
            }
            Console.WriteLine($"Спасибо за визит, ваш баланс составляет: {rub} рублей , {usd} долларов , {eur} евро");
        }
    }
}
