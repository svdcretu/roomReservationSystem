using System.Collections.Generic;

namespace ConferenceModels
{
    public class ConferenceRoom : IConferenceModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public string MapUrl { get; set; }
        public string Site { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Equipment> EquipmentList { get; set; }


        public string GetDescription
        {
            get
            {
                string description = string.Format($"Room Id: {Id}, Name: {Name}, Description: {Description}, Site: {Site}, Equipments: {string.Join(", ", EquipmentList.ToArray())}") + System.Environment.NewLine;
                return description;
            }
        }

    }

}
