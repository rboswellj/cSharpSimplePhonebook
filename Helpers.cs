using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PersonalInfoGui
{
    class Helpers
    {

        // Writes provided object to specifified file in JSON format
        // Replaces original
        public static void OverwriteFile(List<Person> list, string fileName)
        {
            // Checks if the file already exists, if not it creates it and writes to it
            // If it does then it appends data to the end of it.
            try
            { 
                using var stream = new StreamWriter(fileName);
                stream.Close();

                foreach (Person p in list)
                {
                    using var sw = new StreamWriter(fileName, true);
                    string jsonObject = JsonSerializer.Serialize(p);
                    sw.WriteLine(jsonObject); 
                }               
            }
            catch
            {
                Console.WriteLine($"Error reading from or writing to file {fileName}");
            }
        }

        // Writes provided object to specifified file in JSON format
        public static void WriteToFile(Person userObject, string fileName)
        {
            // Checks if the file already exists, if not it creates it and writes to it
            // If it does then it appends data to the end of it.
            try
            {
                string jsonObject = JsonSerializer.Serialize(userObject);
                if (!File.Exists(fileName))
                {
                    using StreamWriter sw = File.CreateText(fileName);
                    sw.WriteLine(jsonObject);
                }
                else
                {
                    using StreamWriter sw = File.AppendText(fileName);
                    sw.WriteLine(jsonObject);
                }  
            }
            catch
            {
                Console.WriteLine($"Error reading from or writing to file {fileName}");
            }
        }
        //Read from specified file, outputs List of Person objects from lines of file
        public static List<Person> ReadFile(string fileName)
        {
                List<Person> People = new List<Person>();
                if (!File.Exists(fileName))
                {
                    using StreamWriter sw = File.CreateText(fileName);
                    return People;
                }
                else
                {
                    using StreamReader sr = new StreamReader(fileName);
                    
                    while (true)
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                        Person jsonObject = JsonSerializer.Deserialize<Person>(line);
                            People.Add(jsonObject);
                        }
                        else
                        {
                            return People;
                        }
                    }
                }
        }

        // Removes all non numeric characters from phone number
        public static string ConvertPhone(string phoneString)
        {
            // Runs a regular expression to remove anything that isn't a digit
            string justNum = Regex.Replace(phoneString, @"[^\d]", "");
            return justNum;
        }

        // Attempts to create an email address object using the .net mailaddress class
        // If the format does not match the created address property
        public static bool IsValidEmail(string address)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(address);
                return addr.Address == address;
            }
            catch
            {
                return false;
            }
        }
    }
}
