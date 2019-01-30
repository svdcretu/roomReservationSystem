using System;
using System.IO;

namespace ConferenceUtils
{
    public static class PrintUtils
    {
        public static void PrintToFile(string text)
        {
            string repoName = "roomReservationSystem";
            string printFileName = "Printed.txt";

            //Location of file to print in
            string currentDirPath = Directory.GetCurrentDirectory();
            string repositoryPath = currentDirPath.Substring(0, currentDirPath.IndexOf(repoName) + repoName.Length);
            string printFilePath = Path.Combine(repositoryPath, "Resources", printFileName);

            //Print text to file
            try
            {          
            FileStream fs = new System.IO.FileStream(printFilePath, FileMode.Append);
            System.IO.TextWriter writeFile = new StreamWriter(fs);
            writeFile.WriteLine(text);
            writeFile.Flush();
            writeFile.Dispose();
        }

            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

        }

    }
}
