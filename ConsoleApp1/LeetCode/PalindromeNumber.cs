using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExerciciosCSharp.LeetCode;

public class PalindromeNumber
{

    public static void Executar()
    {


        int input = 121;

        Stack(input);
        Reverse(input);
        DirectComparison(input);

    }

    private static void Stack(int input)
    {
        var stopwatch = Stopwatch.StartNew();

        string stringNumber = input.ToString();

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < stringNumber.Length; i++)
        {
            stack.Push(stringNumber[i]);
        }

        StringBuilder reverse = new StringBuilder();

        while (stack.Count > 0)
        {
            reverse.Append(stack.Pop());
        }

        if (stringNumber == reverse.ToString())
        {
            Console.WriteLine(true);
        }

        stopwatch.Stop();
        Console.WriteLine($"Tempo: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Tempo: {stopwatch.Elapsed.TotalSeconds} segundos");
    }

    private static void Reverse(int input)
    {
        var stopwatch = Stopwatch.StartNew();

        string stringNumber2 = input.ToString();
        string reversed = new string(stringNumber2.Reverse().ToArray());
        if (stringNumber2 == reversed)
        {
            Console.WriteLine(true);
        }

        stopwatch.Stop();
        Console.WriteLine($"Tempo: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Tempo: {stopwatch.Elapsed.TotalSeconds} segundos");
    }

    private static void DirectComparison(int input)
    {
        var stopwatch = Stopwatch.StartNew();

        string str = input.ToString();
        bool isPalindromo = true;
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                isPalindromo = false;
                break;
            }
        }
        Console.WriteLine(isPalindromo);

        stopwatch.Stop();
        Console.WriteLine($"Tempo: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Tempo: {stopwatch.Elapsed.TotalSeconds} segundos");
    }
}
