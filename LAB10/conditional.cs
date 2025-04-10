Console.WriteLine("Arithmetics Program!");

Console.WriteLine("Enter First Number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Operation:");
Console.WriteLine("0 : Addition");
Console.WriteLine("1 : Subtraction");
Console.WriteLine("2 : Multiplication");
Console.WriteLine("3 : Division");
string op = Console.ReadLine();

Console.WriteLine("Output: ");
int c;

if (op == "0")
{
    c = a + b;
    Console.WriteLine(a + "+" + b + "=" + c);
}
else if (op == "1")
{
    c = a - b;
    Console.WriteLine(a + "-" + b + "=" + c);
}

else if (op == "2")
{
    c = a * b;
    Console.WriteLine(a + "*" + b + "=" + c);
}

else if (op == "3")
{
    if (b == 0)
    {
        Console.WriteLine("Can not divide by 0.");
    }
    c = a / b;
    Console.WriteLine(a + "/" + b + "=" + c);
}

else
{
    Console.WriteLine("Enter a Valid Opertor");
}
