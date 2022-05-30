int dayNumber;

Console.WriteLine("Приветствую!\nЭта программа выдает название дня недели по его порядковому номеру.");
Console.WriteLine("Введите число от 1 до 7:");

dayNumber = EnteringAndCheckingNumber();

Console.Write("Этот день: ");

DayOfTheWeekLogic(dayNumber);

static void DayOfTheWeekLogic(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    switch (number)
    {
        case 1:
            Console.Write("Понедельник");
            break;
        case 2:
            Console.Write("Вторник");
            break;
        case 3:
            Console.Write("Среда");
            break;
        case 4:
            Console.Write("Четверг");
            break;
        case 5:
            Console.Write("Пятница");
            break;
        case 6:
            Console.Write("Суббота");
            break;
        default:
            Console.Write("Воскресенье");
            break;
    }
    Console.ResetColor();
}

static int EnteringAndCheckingNumber()
{
    int enteredNumber;
    
    while (!int.TryParse(Console.ReadLine(), out enteredNumber) || enteredNumber < 1 || enteredNumber > 7)
    {
        Console.WriteLine("Введен не верный символю Введите число от 1 до 7:");
    }
    return enteredNumber;
}


