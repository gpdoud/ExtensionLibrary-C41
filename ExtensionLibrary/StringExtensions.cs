﻿namespace ExtensionLibrary;

public static class StringExtensions {

    public static int Eval(this int i) {
        return (i * i) + (3 * i) + 5;
    }

    public static void Writeline(this string str, string prefix = "", string suffix = "") {
        Console.WriteLine($"{prefix}{str}{suffix}");
    }

    public static decimal ToDecimal(this string str) {
        var s = str;
        s = s.Trim();
        if(s[0] == '$') {
            s = s.Substring(1);
        }
        s = s.Replace(",", "");
        decimal nbr;
        var rc = decimal.TryParse(s, out nbr);
        if(!rc) {
            throw new Exception("string contains nonnumeric characters");
        }
        return nbr;
    }

    public static string AllCaps(this string str) {
        return str.ToUpper();
    }
    public static string AllSmall(this string str) {
        return str.ToLower();
    }

}
