using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp.StringBuilderSB.Easy;

public class FruitsList
{
    #region Enunciado
    /*
     Objetivo

        Fixar Append, AppendLine e evitar concatenação ingênua.

        Enunciado

        Implemente um método que receba uma lista de strings e retorne um único texto, onde cada item aparece em uma linha numerada.

        Exemplo

        Entrada:

        ["apple", "banana", "orange"]


        Saída:

        1. apple
        2. banana
        3. orange

        Regras

        Não use string +

        Use StringBuilder

        Use apenas um loop
     */
    #endregion

    public static void Executar()
    {
        string[] fruits = ["apple", "banana", "orange"];
        Console.WriteLine(FruitsListMethod(fruits));
    }

    private static string FruitsListMethod(string[] fruits)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < fruits.Length; i++)
        {
            sb.Append(i + 1);
            sb.Append(". ");
            sb.AppendLine(fruits[i]);
        }

        return sb.ToString();
    }
}
