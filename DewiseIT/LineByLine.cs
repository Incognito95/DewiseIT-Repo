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
                StreamReader sr = new StreamReader("../../../data.json"); // file path
                
                // read files to the end
                string line = sr.ReadToEnd(); // returns string

                // loop through the file
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
}