﻿using System;

namespace ConferenceModels
{
	public class User: IConferenceModel
	{
	    public int Id { get; set; }
        public string Name { get; set; }
		public string Email { get; set; }

        
    }
}
