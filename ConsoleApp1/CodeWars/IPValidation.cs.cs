using System;

public class IPValidation
{
    // Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
    //    Valid inputs examples:

    //Examples of valid inputs:
    //1.2.3.4
    //123.45.67.89

    //Invalid input examples:

    //1.2.3
    //1.2.3.4.5
    //123.456.78.90
    //123.045.067.089

    //Notes:

    //    Leading zeros(e.g. 01.02.03.04) are considered invalid
    //    Inputs are guaranteed to be a single string

    public static void Executar()
    {
        //Console.WriteLine(IsValidIp("123.45.67.89"));
        //Console.WriteLine(IsValidIp("1.2.3"));
        //Console.WriteLine(IsValidIp("123.456.78.90"));
        //Console.WriteLine(IsValidIp("0.0.0.0"));
        Console.WriteLine(IsValidIp("0.0.0. 0"));
        //Console.WriteLine(IsValidIp("123.045.067.089"));

    }

    private static bool IsValidIp(string ipAddress)
    {

        var array = ipAddress.Split('.');

        if (array.Length != 4)
        {
            return false;
        }

        foreach (string section in array)
        {
            if(section.Contains(" "))
            {
                return false;
            }

            if (section.Length > 1 && section.StartsWith('0'))
            {
                return false;
            }

            bool success = int.TryParse(section, out int number);

            if (!success)
            {
                return false;
            }

            if (number < 0 || number > 255)
            {
                return false;
            }

        }

        return true;
    }
}
