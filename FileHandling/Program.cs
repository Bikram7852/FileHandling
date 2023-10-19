using System;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "StudentData.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Student Data:");
                foreach (string line in lines)
                {
                    string[] studentInfo = line.Split(',');
                    if (studentInfo.Length == 2)
                    {
                        string studentName = studentInfo[0];
                        string grade = studentInfo[1];
                        Console.WriteLine($"Student: {studentName}, Grade: {grade}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Student data file not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
