using System;
using System.IO;

class readFile
{
    public static void ReadFileZip()
    {
        StreamReader sr = new StreamReader("../../../data.json"); // read file

        string line = sr.ReadLine();

        while (line != null) // read all the line
        {
            Console.WriteLine(line);
            line = sr.ReadLine(); // read next line if its not null
            sr.Close();
        }
    }
}