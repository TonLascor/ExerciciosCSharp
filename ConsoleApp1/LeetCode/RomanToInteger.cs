using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExerciciosCSharp.LeetCode;

public class RomanToInteger
{
    public static Dictionary<char, int> Symbols = new Dictionary<char, int>()
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000}
    };


    public static void Executar()
    {
        DictionaryWay("IV");
    }

    public static void DictionaryWay(string s)
    {
        var stopwatch = Stopwatch.StartNew();

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            char? next = (i + 1 < s.Length) ? s[i + 1] : null;

            if (Symbols.TryGetValue(c, out int number))
            {
                // Verifica se o próximo símbolo é maior (ex: lógica de números romanos)
                if (next.HasValue && Symbols.TryGetValue(next.Value, out int nextNumber) && nextNumber > number)
                {
                    result -= number; // subtrai se o próximo for maior
                }
                else
                {
                    result += number;
                }
            }
        }
        Console.WriteLine(result);

        stopwatch.Stop();
        Console.WriteLine($"Tempo: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Tempo: {stopwatch.Elapsed.TotalSeconds} segundos");
    }

    //public static Dictionary<string, int> Symbols = new Dictionary<string, int>()
    //{
    //    {"I", 1 },
    //    {"IV", 4 },
    //    {"V", 5 },
    //    {"IX", 9 },
    //    {"X", 10 },
    //    {"XL", 40 },
    //    {"L", 50 },
    //    {"XC", 90 },
    //    {"CD", 400 },
    //    {"D", 500 },
    //    {"CM", 900},
    //    {"M", 1000}
    //};

}
