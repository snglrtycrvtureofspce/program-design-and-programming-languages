using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    // Пример выражения в префиксной форме: "* + 2 3 4"
                    string prefixExpression = "* + 2 3 4";

                    // Стек для хранения операндов
                    Stack<int> operandStack = new Stack<int>();

                    // Переворачиваем строку, чтобы разбирать ее с конца
                    char[] chars = prefixExpression.ToCharArray();
                    Array.Reverse(chars);
                    prefixExpression = new string(chars);

                    // Разбираем строку, разбивая ее на токены
                    string[] tokens = prefixExpression.Split(' ');

                    // Обрабатываем каждый токен
                    foreach (string token in tokens)
                    {
                        // Если токен - операнд, помещаем его в стек
                        if (int.TryParse(token, out int operand))
                        {
                            operandStack.Push(operand);
                        }
                        // Если токен - оператор, выполняем операцию
                        else
                        {
                            // Берем два операнда из стека
                            int operand2 = operandStack.Pop();
                            int operand1 = operandStack.Pop();

                            // Выполняем операцию
                            int result = 0;
                            switch (token)
                            {
                                case "+":
                                    result = operand1 + operand2;
                                    break;
                                case "*":
                                    result = operand1 * operand2;
                                    break;
                                case "/":
                                    result = operand1 / operand2;
                                    break;
                            }

                            // Помещаем результат обратно в стек
                            operandStack.Push(result);
                        }
                    }

                    // Результат вычисления - последний элемент в стеке
                    Console.WriteLine("Результат: " + operandStack.Pop());
                    break;
                }
                case 2:
                {

                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }
    }
}