using System;
using static System.Console;
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

string PrintNumbers(int start, int end)
{
    if (end == start) return end.ToString();
    return (end + " " + PrintNumbers(start, end - 1));
}