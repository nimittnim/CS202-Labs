// See https://aka.ms/new-console-template for more information

Console.WriteLine("Loops and Function Program!");
Console.WriteLine("Factorial Program!");

int find_factorial(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum = sum * i;
    }
    return sum;
}
Console.WriteLine("Enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int my_fact = find_factorial(n);

Console.WriteLine("The factorial of " + n + " is: " + my_fact);