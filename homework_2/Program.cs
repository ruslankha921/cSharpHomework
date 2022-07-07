// //homework_2_1
// Console.Clear();
// void secondNumber(){
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
// }

// secondNumber();


//homework_2_2
Console.Clear();






void thirdNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    void hundredth()
    {
    int i = 0;
        while (number > 0)
        {
            i++;
            number /= 10;
        }
    }
  
    // double mathPow = Math.Pow (10, num - 2);

    if (number < 100) Console.Write(number + " -> третьей цифры нет");

    else if (number > 99 && number < 1000)
    {
        Console.Write(number + " -> " + ((number - ((number / 100) * 100)) % 10));
    }

    else if (number > 999 && number < 10000)
    {
        Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
    }
    
    else
    {
        Console.Write(number + " -> " + ((number - ((number / 1000) * 1000)) / 100));
    }
}

thirdNumber();


