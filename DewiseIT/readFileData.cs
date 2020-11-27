using System;
using System.IO;


public class readFileData
{
    public void readFileDataZip()
    {

        try {
            Console.WriteLine("Reading...");
            StreamReader sr = new StreamReader("../../../data.json"); // file path

            // loop through the file
            string line = sr.ReadLine(); // returns string

            foreach (var i in line)
            {
                Console.WriteLine(line);
            }
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }
}