using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp.LeetCode;

public class LetterCombinationsPhoneNumber
{
    public static void Executar()
    {
        LetterCombinationsBackTracking("23");
        //LetterCombinationsWithDictionary("23");
    }


    private static Dictionary<int, char[]> Letters = new Dictionary<int, char[]>
    {
        { 2, new[] {'A', 'B', 'C'} },
        { 3, new[] {'D', 'E', 'F'} },
        { 4, new[] {'G', 'H', 'I'} },
        { 5, new[] {'J', 'K', 'L'} },
        { 6, new[] {'M', 'N', 'O'} },
        { 7, new[] {'P', 'Q', 'R', 'S'} },
        { 8, new[] {'T', 'U', 'V'} },
        { 9, new[] {'W', 'X', 'Y', 'Z'} }
    };

    private static IList<string> LetterCombinationsWithDictionary(string digits)
    {
        // Caso base
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        // Estado inicial
        List<string> result = new() { "" };

        // Itera sobre cada dígito
        foreach (var c in digits)
        {
            int digit = c - '0';

            // Segurança (evita erro com 0 ou 1)
            if (!Letters.ContainsKey(digit))
                continue;

            var letters = Letters[digit];

            // Novo estado temporário
            List<string> temp = new();

            // Combinação (produto cartesiano)
            foreach (var prefix in result)
            {
                foreach (var letter in letters)
                {
                    temp.Add(prefix + letter);
                }
            }

            // Atualiza o estado
            result = temp;
        }

        return result;
    }

    private static IList<string> LetterCombinationsBackTracking(string digits)
    {
        List<string> result = new();

        if (string.IsNullOrEmpty(digits))
            return result;

        void Backtrack(int index, string current)
        {
            // Condição de parada
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            int digit = digits[index] - '0';

            if (!Letters.ContainsKey(digit))
                return;

            var letters = Letters[digit];

            // Explora possibilidades
            foreach (var letter in letters)
            {
                Backtrack(index + 1, current + letter);
            }
        }

        Backtrack(0, "");
        return result;
    }

    private static IList<string> LetterCombinationsOptimized(string digits)
    {
        List<string> result = new();

        if (string.IsNullOrEmpty(digits))
            return result;

        char[] buffer = new char[digits.Length];

        void Backtrack(int index)
        {
            // condição de parada
            if (index == digits.Length)
            {
                result.Add(new string(buffer));
                return;
            }

            int digit = digits[index] - '0';

            if (!Letters.ContainsKey(digit))
                return;

            var letters = Letters[digit];

            foreach (var letter in letters)
            {
                buffer[index] = letter;   // escreve direto no buffer
                Backtrack(index + 1);
            }
        }

        Backtrack(0);
        return result;
    }
}
