using System;
using System.IO;

public class Program
{
    static void create(string path)
    {
        Directory.CreateDirectory(path);

        string filePath = Path.Combine(path, "data.txt");
        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.WriteLine("Mssv: PD10306");
        streamWriter.WriteLine("Ho va Ten: Phan Van Minh Quan");
        streamWriter.Dispose();
    }

    static void copy(string sourcePath , string destinationPath)
    {
        if (Directory.Exists(destinationPath) == false)
        {
            Directory.CreateDirectory (destinationPath);

            string[] fileList = Directory.GetFiles(destinationPath);
            foreach (string file in fileList)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destinationPath, fileName);
                File.Copy(file, destFile, true);
            }
        }
    }
}