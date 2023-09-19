using System;

public class Program
{
    public static void Main()
    {
        var result = FizzMethod(15);
        Console.WriteLine(result);
    }

    static string FizzMethod(int number)
    {
        var answer = "";

        if (number % 3 == 0)
        {
            answer = "fizz";
        }
        if (number % 5 == 0)
        {
            answer = "buzz";
        }
        if (number % 3 == 0 && number % 5 == 0)
        {
            answer = "fizzbuzz";
        }

        return answer;
    }
}
