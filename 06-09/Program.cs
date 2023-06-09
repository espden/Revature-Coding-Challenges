using System;

public class Program
{
    public static void Main()
    {
        SumNumbers();
        FindMaxElement();
        Factorial();
    }

    // Question 1
    // The function is correct, it prints out the correct value of 55
    public static void SumNumbers() 
    {
        int sum = 0;

        for (int i = 0; i <= 10; i++) {
            sum += i;
        }

        Console.WriteLine("The sum of numbers from 1 to 10 is: " + sum);
    }

    // Question 2
    // The function can be fixed if you use "<" instead of "<=" in the for loop
    // This way you will avoid an IndexOutOfRangeException
    public static void FindMaxElement() {
        int[] array = {5, 2, 9, 1, 7};
        int max = array[0];
        for (int i = 1; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
            }
        }

        Console.WriteLine("The maximum element in the array is: " + max);
    }

    // Question 3
    // The function is correct, the factorial of 5 is 120
    public static void Factorial() {
        int number = 5;
        int factorial = 1;
        for (int i = 1; i <= number; i++) {
            factorial *= i;
        }

        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}