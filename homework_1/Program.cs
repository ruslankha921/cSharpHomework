//homework_1_1
Console.Clear();
Console.Write("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int max;
if (number_1 > number_2){
    max = number_1;
    Console.Write("a = " + number_1 + "; b = " + number_2 + " -> max =" + max);
}
else{
    max = number_2;
    Console.Write("a = " + number_1 + "; b = " + number_2 + " -> max = " + max);
}



//homework_1_2
// Console.Clear();
// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int number_3 = Convert.ToInt32(Console.ReadLine());
// int max;

// if ((number_1 > number_2) & (number_1 > number_3))
// {
//     max = number_1;
//     Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
// }

// else if ((number_2 > number_1) & (number_2 > number_3))
// {
//     max = number_2;
//     Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
// }

// else
//     {
//     max = number_3;
//     Console.Write("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> max = " + max);
// }



//homework_1_3
// Console.Clear();
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0) Console.Write(number + " -> " + "да");
// else Console.Write(number + " -> " + "нет");



//homework_1_4
// Console.Clear();
// Console.Write("Input first number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 1;
// Console.Write(number + " -> ");
// for (int index = 1; index <= number; index++)
// {
//     if (sum % 2 == 0) Console.Write(sum);
//     if ((sum % 2 == 0) & (sum < number-1)) Console.Write(", ");
//     sum++;
// }