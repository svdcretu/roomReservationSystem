﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceInterfaces
{
    public interface IGenericRepo
    {
        List<IProcess> GetThingsToProcess();
    }
}