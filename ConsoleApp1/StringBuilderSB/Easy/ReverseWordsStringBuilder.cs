using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp.StringBuilderSB.Easy;

public class ReverseWordsStringBuilder
{
    /*
     Objetivo
        Reverter cada palavra de uma frase sem usar string.Concat, + ou Reverse(), apenas StringBuilder.

        Regras
        As palavras devem permanecer na mesma ordem
        Apenas os caracteres de cada palavra devem ser invertidos
        Espaços devem ser preservados
     */

    public static void Executar()
    {
        Console.WriteLine(ReverseWords("hello world"));
    }

    private static string ReverseWords(string input)
    {
        StringBuilder sb = new StringBuilder();

        List<string> words = input.Split(' ').ToList();

        foreach(var word in words)
        {
            for(int i = word.Length -1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            if(word != words.Last())
            {
                sb.Append(" ");

            }
        }

        return sb.ToString();
    }

    private static string ReverseWordsCorrected(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var sb = new StringBuilder();
        string[] words = input.Split(' ');

        for (int w = 0; w < words.Length; w++)
        {
            string word = words[w];

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            if (w < words.Length - 1)
            {
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }

}
