//программа принимает 2 числа и складывает все натуральные числа
// в промежутке от 1го до 2го числа

int SummOfNaturalNumbersFromMToN(int M, int N)
{
    if (M >= N)
    {
        return M;
    }

    M = M + SummOfNaturalNumbersFromMToN(M + 1, N); 

    return M;   
}

int[] nums;
Console.Write("Введите начальный и конечный элемент для сложения через пробел: ");
nums = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(SummOfNaturalNumbersFromMToN(nums[0], nums[1]));