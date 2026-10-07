using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("숫자를 입력하세요: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                Console.WriteLine("입력한 숫자는 양수입니다.");
            }
            else if (number < 0)
            {
                Console.WriteLine("입력한 숫자는 음수입니다.");
            }
            else
            {
                Console.WriteLine("입력한 숫자는 0입니다.");
            }
        }
        else
        {
            Console.WriteLine("올바른 숫자를 입력하세요.");
        }
    }
}