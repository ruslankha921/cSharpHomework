Console.Clear();
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.Write(number + " -> " + "да");
else Console.Write(number + " -> " + "нет");