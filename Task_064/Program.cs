//Ounput value between N and 1 using recursion.
using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal number for the output on the screen");
int number = int.Parse(ReadLine());

OutputNumbers(number);

void OutputNumbers(int number)
{
    Write(number + "\t");
    if(number == 1) return;
    else number--; OutputNumbers(number);
}