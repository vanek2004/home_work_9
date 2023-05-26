// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое целое, положительное число --> ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое, положительное число --> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

AkermanFunction(firstNumber, secondNumber);

void AkermanFunction(int firstNum, int secondNum)
{
    Console.Write(Akerman(firstNum, secondNum)); 
}

int Akerman(int firstNum, int secondNum)
{
    if (firstNum == 0)
    {
        return secondNum + 1;
    }
    else if (secondNum == 0 && firstNum > 0)
    {
        return Akerman(firstNum - 1, 1);
    }
    else
    {
        return (Akerman(firstNum - 1, Akerman(firstNum, secondNum - 1)));
    }
}

