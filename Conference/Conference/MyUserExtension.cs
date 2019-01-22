using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceModels;

namespace Conference
{
	public class MyUserExtension: User
	{
		protected override void DoNotingProtected()
		{
			base.DoNotingProtected();
		}

		public override void DoNotingPublic()
		{			
			base.DoNotingPublic();
		}
	}
}
