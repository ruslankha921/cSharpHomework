void secondNumber(){
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + " -> " + ((number - ((number / 100) * 100)) / 10));
}

secondNumber();