using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceModels;

namespace Conference
{
	class Program
	{
		static void Main(string[] args)
		{
			var cr = new ConferenceRoom(12)
			{
				Description = "My Des",
				EquipmentList = new List<Equipment>()

			};

			var tempClass = new TempClass();
			tempClass.CreateNewUser();
			tempClass.CreateNewUserWithInstance();
			
			var user = new User();
			user.DoNotingPublic();

			UserExtension userExt = new UserExtension();

            Console.WriteLine(cr.Description);
            Console.ReadLine();
		}
	}
}
