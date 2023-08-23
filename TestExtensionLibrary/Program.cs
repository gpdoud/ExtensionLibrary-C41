// See https://aka.ms/new-console-template for more information

using ExtensionLibrary;

var s = "   $123,456.78";
var s1 = "000000000000023455";

var fn = 2;

Console.WriteLine($"fn({fn}) = X^2 + 3X + 5 evaluates to {fn.Eval()}");

s1.Writeline("The value of s1 is ", " pretty cool!!!");

Console.WriteLine($"{s} as a decimal is {s.ToDecimal():C}");
/*

var s = "kdKjlKLsjLfkd";

var sAllCaps = s.AllCaps();
var sAllSmall = sAllCaps.AllSmall();

Console.WriteLine($"{s} as all caps is {sAllCaps} and all small is {sAllSmall}");
*/