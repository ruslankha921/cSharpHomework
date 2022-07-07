// //homework_2_1
// void secondNumber(){
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
// }

// secondNumber();


//homework_2_2
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


