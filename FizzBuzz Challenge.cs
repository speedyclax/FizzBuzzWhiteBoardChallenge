using System;
using System.Collections.Generic;
using System.LINQ;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz Whiteboard Challenge
{
    class Program
{
    static void main(string[] args)
    {

    }

    public string FizzMethod(int number)
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
        if (number % 3 == 0 || number % 5 == 0)
        {
            answer = "fizzbuzz";
        }

        return answer;
    }
}
}
//Write a public method that accepts a number
//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz
