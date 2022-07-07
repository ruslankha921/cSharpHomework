// //homework_2_1
// void secondNumber(){
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
// }

// secondNumber();


//homework_2_2
void bitDepth()
{
    Console.Write("Введите число : ");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    while (num > 0)
    {
        i++;
        num /= 10;
    }
    Console.WriteLine("Количество цифр введенного числа : {0}", i);
}

void thirdNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 100) Console.Write(number + " -> третьей цифры нет");

    else if (number > 100)
    {
        Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
    }

}

thirdNumber();


