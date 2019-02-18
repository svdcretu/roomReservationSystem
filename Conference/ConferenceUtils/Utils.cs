using ConferenceModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace ConferenceUtils
{
    public static class Utils
    {

        public static string GetPrintFileLocation()
        {
            string printFileName = "Printed.txt";
            string printFilePath = GetResourcesLocation();
            printFilePath = Path.Combine(printFilePath, printFileName);
            return printFilePath;
        }


        public static string GetRoomsRepoLocation()
        {
            string printFileName = "RoomsRepo.txt";
            string printFilePath = GetResourcesLocation();
            printFilePath = Path.Combine(printFilePath, printFileName);
            return printFilePath;
        }

        public static string GetUsersRepoLocation()
        {
            string printFileName = "UsersRepo.txt";
            string printFilePath = GetResourcesLocation();
            printFilePath = Path.Combine(printFilePath, printFileName);
            return printFilePath;
        }


        public static string GetResourcesLocation()
        {
            string repoName = "roomReservationSystem";
            //Location of Resources 
            string currentDirPath = Directory.GetCurrentDirectory();
            string repositoryPath = currentDirPath.Substring(0, currentDirPath.IndexOf(repoName) + repoName.Length);
            string printFilePath = Path.Combine(repositoryPath, "Resources");
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


        public static string readTextFile(string filename)
        {

            string streamFile = Path.Combine(GetResourcesLocation(), filename);
            string content = String.Empty; ;

            Stream stream = new FileStream(@streamFile, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(stream, System.Text.Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            stream.Close();
            return content;
        }

        public static List<ConferenceRoom> readTextFileToConferenceRoomObject(string filename)
        {
            List<ConferenceRoom> roomList = new List<ConferenceRoom>();
            string streamFile = Path.Combine(GetResourcesLocation(), filename);
            string content = String.Empty;
            string currentLine = string.Empty;
            char delimiter = ',';

            List<ConferenceRoom> inventory = new List<ConferenceRoom>();
            List<Equipment> equipmentList = new List<Equipment>();

            Stream stream = new FileStream(@streamFile, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(stream, System.Text.Encoding.UTF8))

                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    string[] parts = currentLine.Split(delimiter);

                    List<Equipment> equipments = new List<Equipment>();
                    for (int i = 4; i < parts.Length; i++)
                    {
                        Equipment equipment = (Equipment)Enum.Parse(typeof(Equipment), parts[i]);
                        equipments.Add(equipment);
                    }

                    roomList.Add(new ConferenceRoom()
                    {
                        RoomId = int.Parse(parts[0]),
                        Name = parts[1],
                        Description = parts[2],
                        Site = parts[3],
                        EquipmentList = equipments
                    });
                }
            return roomList;
        }



        public static List<User> readTextFileToUserObject(string filename)
        {
            List<User> userList = new List<User>();
            string streamFile = Path.Combine(GetResourcesLocation(), filename);
            string content = String.Empty;
            string currentLine = string.Empty;
            char delimiter = ',';

            List<User> inventory = new List<User>();

            Stream stream = new FileStream(@streamFile, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(stream, System.Text.Encoding.UTF8))

                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    string[] parts = currentLine.Split(delimiter);

                    userList.Add(new User()
                    {
                        UserId = int.Parse(parts[0]),
                        Name = parts[1],
                        Email = parts[2],
                    });
                }
            return userList;
        }


        public static string GetOptionsFromUser(Dictionary<string, string> validOptions, string fileLocation)
        {
            string userInput = "";
            bool invalidInput = true;
            while (!validOptions.Keys.Contains(userInput))
            {
                Console.WriteLine("Please choose an option (1/2) and press Enter to apply:");
                Console.WriteLine($"{validOptions.ElementAt(0).Key}:{validOptions.ElementAt(0).Value} ({fileLocation})");
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


        public static string GetPrintOptionFromUser()
        {
            string fileLocation = Utils.GetPrintFileLocation();
            Dictionary<string, string> validOptions = new Dictionary<string, string>()
            {
             { "1", "Print to File"},
             { "2", "Print to Console" }
            };
            return GetOptionsFromUser(validOptions, fileLocation);
        }


        public static string GetRoomsRepositoryOptionFromUser()
        {
            string fileLocation = Utils.GetRoomsRepoLocation();

            Dictionary<string, string> validOptions = new Dictionary<string, string>()
            {
             { "1", "Read from File"},
             { "2", "Read hardcoded values" }
            };
            return GetOptionsFromUser(validOptions, fileLocation);
        }


        public static string GetUsersRepositoryOptionFromUser()
        {
            string fileLocation = Utils.GetUsersRepoLocation();

            Dictionary<string, string> validOptions = new Dictionary<string, string>()
            {
             { "1", "Read from File"},
             { "2", "Read hardcoded values" }
            };
            return GetOptionsFromUser(validOptions, fileLocation);
        }



    }
}
