using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string username = "1";
        string password = "123";
        string time = "1/10/200";
        var sw = new StringWriter();
        sw.WriteLine("UserName: " + username);
        sw.WriteLine("Password: " + password);
        var content = sw.ToString();

        var sr = new StringReader(content);
        string line1 = sr.ReadLine();
        Console.WriteLine("Line1: "+line1);
        string Line2 = sr.ReadLine();
        Console.WriteLine("Line2: " + Line2);

        string Line = sr.ReadLine();
        while(Line != null)
        {
            Console.WriteLine(Line);
            Line = sr.ReadLine();
        }
        Console.WriteLine();
    }
}