using System;

namespace ConferenceModels
{
	public class User
	{
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }

		public virtual void DoNotingPublic()
		{

		}

		protected internal virtual void DoNotingProtectedInternal()
		{

		}


		protected virtual void DoNotingProtected()
		{

		}

		private void DoNotingPrivate()
		{

		}
	}
}
