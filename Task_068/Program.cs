//Write a program to calculate the Ackermann function using recursion

using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal number m");// to mark the beginning - чтобы обозначить начало
int m = int.Parse(ReadLine());

WriteLine("Please, enter decimal number n");// to mark the end - чтобы обозначить конец
int n = int.Parse(ReadLine());
WriteLine();

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m-1,1);
    else return Ackermann(m-1, Ackermann(m, n -1));
}

int res = Ackermann(m,n);
WriteLine(res);