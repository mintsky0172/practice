using System;

class Celsius
{
    public static void Main(string[] args)
    {
        Console.Write("섭씨 온도를 입력하세요: ");
        string input = Console.ReadLine();
        double degree1 = double.Parse(input);
        double degree2 = (degree1 * 1.8) + 32;
        Console.WriteLine($"화씨로 변환한 결과: {degree2}");
    }
}

