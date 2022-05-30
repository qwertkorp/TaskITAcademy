int firstNumber;
int secondNumber;

Console.WriteLine("Приветствую!\nПрограмма умножает введенное первое число на последовательность чисел от 1 до второго введенного числа.");

Console.WriteLine("Введите первое число");
firstNumber = EnteringAndCheckingNumber();

Console.WriteLine("Введите второе число");
secondNumber = EnteringAndCheckingNumber();
MultiplicationTableLogic(firstNumber,secondNumber);

static void MultiplicationTableLogic(int firstNumber,int secondNumber)
{
    long result;
    
    for(int i = 1; i <= secondNumber; i++)
    {
        result = firstNumber * i;
        Console.WriteLine($"{firstNumber}*{i} = {result}");
    }
}

static int EnteringAndCheckingNumber()
{
    int enterendNumber;

    while(!int.TryParse(Console.ReadLine(), out enterendNumber) || 1 > enterendNumber || enterendNumber > int.MaxValue)
    {
        Console.WriteLine("Введен не верный символ или отрицательное число. Введите повторно:");
    }
    return enterendNumber;
}