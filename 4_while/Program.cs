using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int i = 1;

        while (i < 6)
        {
            int j = 1;

            while (j <= i)
            {
                Console.Write("*");
                j++;
            }

            Console.WriteLine();
            i++;
        }
    }
}
