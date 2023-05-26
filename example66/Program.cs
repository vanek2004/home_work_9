// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое целое, положительное число --> ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое, положительное число --> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


NaturalNumbers(firstNumber, secondNumber);
int sumNaturalElements = SumNaturalElements(firstNumber, secondNumber);
Console.WriteLine(sumNaturalElements + firstNumber);

void NaturalNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        Console.Write($"{firstNum} ");
        NaturalNumbers(firstNum + 1, secondNum);
    }
    else if (firstNum > secondNum)
    {
        Console.Write($"{firstNum} ");
        NaturalNumbers(firstNum - 1, secondNum);
    }
    else Console.WriteLine(firstNum);
}

int SumNaturalElements(int firstNum, int secondNum)
{
    int result = firstNum;
    if (firstNum == secondNum) return 0;
    else
    {
        firstNum++;
        result = firstNum + SumNaturalElements(firstNum, secondNum);
        return result;
    }
}