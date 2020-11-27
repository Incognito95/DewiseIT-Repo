using System;
using System.IO;

namespace DewiseIT
{
    public class LineByLine
    {
        public void ReadLineByLine()
        {

            try {
      
                Console.WriteLine("Reading json line by line");
                
                // using stream reader library to read file
                StreamReader sr = new StreamReader("../../../data.json"); // file path
                
                // method to read file to the end
                string line = sr.ReadToEnd(); // returns string

                // loop through the file
                foreach (var i in line)
                {
                    Console.WriteLine(line); // console log file to console
                }
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}