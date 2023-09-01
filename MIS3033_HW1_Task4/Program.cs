// MIS3033
// Task 4
// Abigail Pidgeon 113515288

using System.Reflection.Metadata.Ecma335;

double linevalueforY(double m, double x, double b)
{
    double Y = m * x + b;
    return Y;
}

double y = linevalueforY(10.0, 5.5, 6.3);
Console.WriteLine(linevalueforY(20.0, 5.5, 6.3));

int factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

int nfactorial = factorial(5);
Console.WriteLine(nfactorial);