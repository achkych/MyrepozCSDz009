/*
//z0.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNums(int num)
{
   Console.Write(num + " ");
   if(num > 1) ShowNums(num - 1);
   Console.Write(num + " ");
   }

ShowNums(5);
Console.WriteLine();
*/

/*
//z1.Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfDigits(int num)
{
     if(num != 0) return SumOfDigits(num / 10) + num % 10;
     else return 0;
}

Console.WriteLine(SumOfDigits(12345));
*/
/*
f(123) -> f(12) + 3
f(12) -> f(1) + 2
f(1) -> f(0) + 1
f(0) -> 0
*/
//Console.WriteLine(SumOfDigits(123));

/*
//z2. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void getSet(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) getSet(m + 1, n);
    if (m > n) getSet(m - 1, n);
}
getSet(18, 10);
Console.WriteLine();
*/
/*
//z3.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
double AtoBDegree(double a, int b)
{
    if (b > 0) return AtoBDegree(a, b - 1) * a;
    if (b < 0) return AtoBDegree(a, b + 1) * 1 / a;
    else return 1;
}

Console.WriteLine(AtoBDegree(2,-3));
//Console.Write(AtoBDegree(2, 3) + "  " + AtoBDegree(2, -3));
*/

//MyrepozCSDz009.
/*
//z64.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
void ShowNum(int n)
{
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNum(n - 1);
    }
    else Console.Write(n);   
}
ShowNum(5);
Console.WriteLine();
*/

/*
//z68.Nesmog. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunc(m,n);


// вызов функции Аккермана
void AkkermanFunc(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
Console.WriteLine();
*/

/*
//z66.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumInterval(int n, int m)
{
    if (n > m) return m + SumInterval(n, m + 1);
    if (m > n) return n + SumInterval(n + 1, m);
    else return n;
}


Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumInterval(n, m));
*/
//Gotovo!

