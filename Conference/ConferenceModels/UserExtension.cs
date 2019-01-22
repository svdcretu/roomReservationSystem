using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceModels
{
	public class UserExtension: User
	{
		public string SkypeId { get; set; }

		public override void DoNotingPublic()
		{
			base.DoNotingPublic();
		}

		protected override void DoNotingProtected()
		{
			base.DoNotingProtected();
		}
				
		protected internal override void DoNotingProtectedInternal()
		{
			base.DoNotingProtectedInternal();
		}
	}
}
