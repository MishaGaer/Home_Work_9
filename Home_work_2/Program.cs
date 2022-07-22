/*Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//метод суммирования
int Recursion(int n, int m)
{
    if (n == m)
    {
        return m;
    }
    else
    {
        return m + Recursion(n, m - 1);
    }
}
//метод печати результата
void PrintResult(int n, int m)
{
    if (m > n)
    {
        Console.WriteLine(Recursion(n, m));
    }
    else
    {
        if (n == m)
        {
            Console.WriteLine("Вы ввели одинаковые числа");
        }
        else
        {
            Console.WriteLine("Число n меньше числа m");
        }
    }
}
//Основной код
int n = InputControl("введите число n");
int m = InputControl("введите число m");
PrintResult(n, m);
