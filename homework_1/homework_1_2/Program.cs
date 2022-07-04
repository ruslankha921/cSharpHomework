Console.Clear();
Console.Write("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max;

if ((number_1 > number_2) & (number_1 > number_3))
{
    max = number_1;
    Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
}

else if ((number_2 > number_1) & (number_2 > number_3))
{
    max = number_2;
    Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
}

else
    {
    max = number_3;
    Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
}