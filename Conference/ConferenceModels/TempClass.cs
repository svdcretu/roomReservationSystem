using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceModels
{
	public class TempClass
	{
		public void CreateNewUser()
		{
			var user = new User();
		}

		public User CreateNewUserWithInstance()
		{
			var user = new User();

			return user;
		}
	}
}
