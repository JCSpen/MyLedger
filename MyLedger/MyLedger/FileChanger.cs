using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FileChanger
{
    // Filename carries the selected date as they are used to identify files
    public string fileName;

    public void Write(string entry) // Writes the new entry to the file
                                    // Or creates a new one
    {
        //Path
        string path = Directory.GetCurrentDirectory().ToString() + fileName + ".txt";
        try
        {
            //Updates existing entries
            if (File.Exists(path))
            {
                File.AppendAllText(path, "\r\n" +  entry );
            }
            else
            {
                // Creates new file and adds new entry
                using (FileStream fs = File.Create(path))
                {
                    // Add some text to file    
                    byte[] author = new UTF8Encoding(true).GetBytes(entry);
                    fs.Write(author, 0, author.Length);
                }

            }
        }
        // Exception
        catch (Exception Fallback)
        {
            MessageBox.Show(Fallback.ToString());
        }
    }

    public string Read() // Reads value stored from previous files
    {
        string text = "";
        string path = Directory.GetCurrentDirectory().ToString() + fileName + ".txt";
        try
        {
            if (File.Exists(path))
            {
                // Reads text from specific dated file
               text = File.ReadAllText(path);
            }
            else
            {
                // Displays when an entry hasnt been made
                text = ("No entries on this date: " + fileName);
            }
        }
        catch (Exception Fallback) // Exception
        {
            text = "Unknown error";
        }
        return text;
    }
}

