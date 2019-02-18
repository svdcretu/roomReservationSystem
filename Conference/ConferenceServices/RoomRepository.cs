using System;
using System.Collections.Generic;
using ConferenceModels;
using ConferenceInterfaces;
using ConferenceServices;

namespace ConferenceRepos
{
    public class RoomRepository 
    {

        ConnectionType _connectionType;
        IProcess _roomService;


        public RoomRepository(ConnectionType connectionType, IProcess roomService)
        {
            _connectionType = connectionType;
            _roomService = roomService;
        }
      
        public String ConnectToRepo(ConnectionType connectionType)
        {
            String results = _roomService.Connect(connectionType);
            return results;
        }


    }
       
    }
