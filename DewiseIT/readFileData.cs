using System;
using System.IO;

namespace DewiseIT
{
    public class readFileData
    {
        public void readFileDataZip()
        {

            try {
      
                Console.WriteLine("Reading json line by line");
                StreamReader sr = new StreamReader("../../../data.json"); // file path

                // loop through the file
                string line = sr.ReadToEnd(); // returns string

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
