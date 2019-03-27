using System;

namespace ConferenceModels
{
	public class User: IConferenceModel
	{
	    public int Id { get; set; }

	    public string GetDescription
	    {
            get
            {
                string description = string.Format($"Id: {Id}, Name: {Name}, Email: {Email}") + System.Environment.NewLine;
                return description;
            }
	    }

	    public string Name { get; set; }
		public string Email { get; set; }

        
    }
}
