using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExerciciosCSharp.LeetCode;

public class LongestCommonPrefix
{
    public static void Executar()
    {
        //Longest(["flower", "flow", "flight"]);
    }

    public static void LongestCommonPrefixDictionary(string[] strs)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        Dictionary<string, int> prefixes = new();

        foreach(string str in strs)
        {
            string key  = str.Substring(2);

            if (!prefixes.ContainsKey(key)){
                prefixes.Add(key, 1);
            }
            else
            {
                prefixes[key] += 1;
            }
        }


    }

    //public static string Longest(string[] strs)
    //{

    //    string results = "";
    //    foreach(var str in strs)
    //    {
    //        if (string.IsNullOrEmpty(results))
    //        {
    //            results = str;
    //            continue;
    //        }

            

    //    }
    //}




}
