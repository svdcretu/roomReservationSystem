using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace ConferenceUtils
{
    public static class PrintUtils
    {

        public static string GetPrintFileLocation()
        {
            string repoName = "roomReservationSystem";
            string printFileName = "Printed.txt";

            //Location of file to print in
            string currentDirPath = Directory.GetCurrentDirectory();
            string repositoryPath = currentDirPath.Substring(0, currentDirPath.IndexOf(repoName) + repoName.Length);
            string printFilePath = Path.Combine(repositoryPath, "Resources", printFileName);
            return printFilePath;
        }


        public static void PrintToFile(string text)
        {

            string printFilePath = GetPrintFileLocation();

            //Print text to file
            try
            {
                FileStream fs = new System.IO.FileStream(printFilePath, FileMode.Create);
                System.IO.TextWriter writeFile = new StreamWriter(fs);
                writeFile.WriteLine(text);
                writeFile.Flush();
                writeFile.Dispose();

                string readFileText = File.ReadAllText(printFilePath).Replace("\r", string.Empty).Replace("\n", string.Empty);
                if (readFileText.Length != 0)
                {
                    Console.WriteLine("Successfully printed to file.");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }


        public static string GetPrintOptionFromUser()
        {

            Dictionary<string, string> validOptions = new Dictionary<string, string>()
            {
             { "1", "Print to File"},
             { "2", "Print to Console" }
            };

            string userInput = "";
            bool invalidInput = true;
            while (!validOptions.Keys.Contains(userInput))
            {
                Console.WriteLine("Please choose an option (1/2) and press Enter to apply:");
                Console.WriteLine($"{validOptions.ElementAt(0).Key}:{validOptions.ElementAt(0).Value} ({PrintUtils.GetPrintFileLocation()})");
                Console.WriteLine($"{validOptions.ElementAt(1).Key}:{validOptions.ElementAt(1).Value}");

                userInput = Console.ReadLine().Trim();
                invalidInput = string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput) || !validOptions.Keys.Contains(userInput);

                if (!invalidInput)
                {
                    var chosenOption = validOptions.SingleOrDefault(x => x.Key == userInput);
                    userInput = chosenOption.Key;
                }

            }
            return userInput;
        }


    }
}
