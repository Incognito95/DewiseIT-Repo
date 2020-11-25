using System;


public class showData {
    public void showDataTwitter () {

        // Read each line of the file into a string array. Each element
        // of the array is one line of the file.
        string[] lines = System.IO.File.ReadAllLines("TU_verified.json");

        // Display the file contents by using a foreach loop.
        System.Console.WriteLine("Contents of TU_verified.json = ");
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
        }
    }
}