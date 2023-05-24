using System;

public class Program
{
    public static void Main()
    {
        SecondMaximumNumberChallenge();
        SumDigitsInStringChallenge();
    }

    public static void SecondMaximumNumberChallenge()
    {
        int tripleCount = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < tripleCount; i++)
        {
            string tripleString = Console.ReadLine();
            int[] triple = tripleString.Split(" ").Select(str => Int32.Parse(str)).ToArray();
            int mid = Mid(triple[0], triple[1], triple[2]);
            Console.WriteLine(mid);
        }
    }

    // Returns the middle number of three numbers
    public static int Mid(int a, int b, int c) 
    {
        if (a > b && a > c)
        {
            return (b > c) ? b : c;
        } 
        else if (b > a && b > c)
        {
            return (a > c) ? a : c;
        }
        else
        {
            return (a > b) ? a : b;
        }
    }

    public static void SumDigitsInStringChallenge()
    {
        int testCases = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < testCases; i++)
        {
            string str = Console.ReadLine();
            int sum = SumDigitsInString(str);
            Console.WriteLine(sum);
        }
    }

    // Returns the sum of all digits in the string
    public static int SumDigitsInString(string str)
    {
        int sum = 0;
        foreach(char c in str)
        {
            if (Char.IsDigit(c))
            {
                int digit = Int32.Parse(c.ToString());
                sum += digit;
            }
        }
        return sum;
    }
}