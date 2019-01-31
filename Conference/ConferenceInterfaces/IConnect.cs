using System;
using System.Collections.Generic;
using ConferenceModels;

namespace ConferenceInterfaces
{
    public interface IConnect<T>
    {

        T Connect(ConnectionType connectionType, string sourceName);


    }
}
