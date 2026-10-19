
using System;

string CheckNumber(int numero)
{
    if (numero > 0)
    {
        return "El número es positivo";
    }
    else if (numero < 0)
    {
        return "El número es negativo";
    }
    else
    {
        return "El número es cero";
    }
}

Console.WriteLine(CheckNumber(5));
Console.WriteLine(CheckNumber(-3));
Console.WriteLine(CheckNumber(0));
