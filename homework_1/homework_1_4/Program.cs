Console.Clear();
Console.Write("Input first number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 1;
Console.Write(number + " -> ");
for (int index = 1; index <= number; index++)
{
    if (sum % 2 == 0) Console.Write(sum);
    if ((sum % 2 == 0) & (sum < number-1)) Console.Write(", ");
    sum++;
}