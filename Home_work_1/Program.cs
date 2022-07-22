/*
Задайте значения M и N. 
Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
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
//метод пересчета
string Recursion(int n, int m)
{
    if (n == m)
        return m.ToString();
    else
        return n + ", " + Recursion(n + 1, m);
}
//метод печати результата
void PrintResult(int n, int m)
{
    if (m > n)
    {
        Console.WriteLine($"{Recursion(n, m)} ");
    }
    else
    {
        if (n == m)
        {
            Console.WriteLine(n);
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