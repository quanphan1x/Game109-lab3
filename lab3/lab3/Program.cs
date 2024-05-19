using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string path = "../../../example.txt";

        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.write))
        {
            using (StreamWriter sr = new StreamWriter(fs))
            {
                sw.WriteLine("UserName: myUserName");
                sw.WriteLine("Password: myPassword");
            }
        }
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
        Console.ReadLine();
    }
}

