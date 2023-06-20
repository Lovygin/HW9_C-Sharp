//Find sum of values between m and n using a recursion.

using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal number to mark the beginning of the range");// to mark the beginning - чтобы обозначить начало
int m = int.Parse(ReadLine());

WriteLine("Please, enter decimal number to mark the end of the range");// to mark the end - чтобы обозначить конец
int n = int.Parse(ReadLine());
WriteLine();

int result = SumNumbersRange(m,n);
int SumNumbersRange(int start, int end)
{
    if(start > end) return 0;
    if(start == end) return start;
    return start + SumNumbersRange(start + 1, end);
}
WriteLine(result);