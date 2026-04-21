namespace MyLib;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;

    public int Modulu(int a, int b) => a % b;

    public double Power(int a, int b) => Math.Pow(a, b);
}