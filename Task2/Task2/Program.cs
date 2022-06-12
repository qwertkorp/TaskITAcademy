using System;

namespace Task2
{
    public class Program
    {
       static string operation = "";
       static double result;
       static double numberOne;
       static double numberTwo = 0;
        static void Main(string[] args)
        {          
            byte operationNumber;            
            bool programRepeat = true;      

            while (programRepeat)
            {
                Console.WriteLine("Выберите операцию с числами");
                Console.WriteLine("Сложение (1) \t Вычитание (2) \t Умножение (3) \t Деление (4) \t Возведение в степень (5) \t Факториал (6)");
                Console.WriteLine("Введите номер операции:");
                operationNumber = EnteringAndCheckingNumberOperation();
                Console.WriteLine("Хотите использовать случайные числа?(Да-Enter; Нет-Esc)");                
               
                while (programRepeat)
                {
                    if(InputKey() == ConsoleKey.Enter)
                    {
                        RandomNumberProgram(operationNumber);
                        programRepeat = false;
                    }
                    else if(InputKey() == ConsoleKey.Escape)
                    {
                        StandartProgram(operationNumber);
                        programRepeat = false;
                    }
                    else
                    {
                        programRepeat = true;

                    }                    
                }
                Console.WriteLine("Если хотите повторить еще раз (Да-Enter; Нет-Esc)");
               programRepeat = ProgramRepeat();
                
            }            
        }

        static void RandomNumberProgram(byte operationNumber)
        {           
            Random rnd = new Random();

            if (operationNumber == 6)
            {                
                numberOne = rnd.Next(0,171); // Ограничил в связи с максимально допустимым числом.
            }
            else if(operationNumber == 5)
            {
                numberOne = rnd.NextDouble() * rnd.Next(sbyte.MinValue, sbyte.MaxValue);
                numberTwo = rnd.NextDouble() * rnd.Next(sbyte.MinValue, sbyte.MaxValue);
            }
            else
            {
                numberOne = rnd.NextDouble() * rnd.Next(int.MinValue, int.MaxValue);
                numberTwo = rnd.NextDouble() * rnd.Next(int.MinValue, int.MaxValue);
            }
            result = LogicOperation(operationNumber, numberOne, numberTwo, ref operation);
            OutputResult(numberOne, numberTwo, operation, result, operationNumber);
        }

        static void StandartProgram(byte operationNumber)
        {                          
            if(operationNumber == 6)
            {
                Console.WriteLine("Введите число:");
                numberOne = EnteringAndCheckingNumber();
            }
            else
            {
                Console.WriteLine("Введите первое число:");
                numberOne = EnteringAndCheckingNumber();
                Console.WriteLine("Введите второе число:");
                numberTwo = EnteringAndCheckingNumber();
            }                
            result = LogicOperation(operationNumber, numberOne, numberTwo, ref operation);

            OutputResult(numberOne, numberTwo, operation, result, operationNumber);            
        }
        static void OutputResult(double numberOne, double numberTwo, string operation, double result, byte operationNumber)
        {
            if (CheckIsInfinityAndDivideByZero(result))
            {
                if (operationNumber == 6)
                {
                    Console.WriteLine($"{numberOne} {operation} = {result}");                    
                }
                else
                {
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
                }                
            }            
        }
        static ConsoleKey InputKey()
        {
            ConsoleKeyInfo key;            
            key = Console.ReadKey();

            return key.Key;            
        }

        static double LogicOperation(double operationNumber, double numberOne, double numberTwo, ref string operation)
        {
            double result = 1;

            switch (operationNumber)
            {
                case 1:
                    operation = "+";
                    result = numberOne + numberTwo;
                    return result;

                case 2:
                    operation = "-";
                    result = numberOne - numberTwo;
                    return result;

                case 3:
                    operation = "*";
                    result = numberOne * numberTwo;
                    return result;

                case 4:
                    operation = "/";
                    if (numberTwo == 0)
                    {
                        return double.NaN;                        
                    }
                    result = numberOne / numberTwo;
                    return result;

                case 5:
                    operation = "^";
                    result = Math.Pow(numberOne, numberTwo);
                    return result;

                default:
                    operation = "n!";

                    for (int i = 1; i <= numberOne; i++)
                    {
                        result *= i;
                        
                    }
                    return result;
            }
        }
        static bool ProgramRepeat()
        {            
            bool result = true;            
            
            if (InputKey() == ConsoleKey.Enter)
            {                
                result = true;                    
            }
            else if (InputKey() == ConsoleKey.Escape)
            {                
                result = false;
            }
            else
            {
                ProgramRepeat();
            }
            
            return result;
        }

        static bool CheckIsInfinityAndDivideByZero(double result)
        {            

            if (double.IsInfinity(result))
            {
                Console.WriteLine("Число слишком большое (Используйте меньшие значения чисел)");               
                return false;
            }
            else if(double.IsNaN(result))
            {
                Console.WriteLine("Ошибка!! Вы использовали неправельные числа для возведение в степень либо поделили на ноль. ");                
                return false;
            }
            else
            {
                return true;
            }                  
        }

        static byte EnteringAndCheckingNumberOperation()
        {
            byte enterNumber;
            while (!byte.TryParse(Console.ReadLine(), out enterNumber) || enterNumber < 1 || enterNumber > 6)
            {
                Console.WriteLine("Введен неверный символ. Введите число от 1 до 6");

            }
            return enterNumber;
        }

        static double EnteringAndCheckingNumber()
        {
            double enterNumber;
            while (!double.TryParse(Console.ReadLine(), out enterNumber) || enterNumber < double.MinValue || enterNumber > double.MaxValue)
            {
                Console.WriteLine("Введен неверный символ. Введите число повторно");

            }
            return enterNumber;
        }
    }
}



