using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTANetworkAPI;

namespace Server.Houses
{
    public class HouseInfo
    {
        [Key]
        public int ID { get; set; }
        public string Owner { get; set; }
        public string Position { get; set; }
        

        public HouseInfo()
        {
            Owner = "Unknown";
            Position = "0.0, 0.0, 0.0, 0.0";
        }
        public static List<HouseInfo> List = new List<HouseInfo>();

        public static void HouseInterior()
        {

        }

        public static void LoadHouses()
        {
            using var dbServer = new ServerdbServer();
                var houses = dbServer.houses.ToList();
                float[] newPosCoordinates;
                Vector3 newpos;
                foreach (HouseInfo v in houses)
                {
                    newPosCoordinates = v.Position.Split(new string[] { ", " }, StringSplitOptions.None).Select(x => float.Parse(x)).ToArray();
                    newpos = new Vector3(newPosCoordinates[0], newPosCoordinates[1], newPosCoordinates[2]);
                    NAPI.Marker.CreateMarker(1, newpos, new Vector3(), new Vector3(), 1f, new Color(255, 0, 0, 155));
                    var house = new HouseInfo()
                    {
                        ID = v.ID,
                        Owner = v.Owner,
                        Position = v.Position
                    };
                    List.Add(house);
                    Console.WriteLine($"Houses: {v.ID}. {v.Owner}");
                }
        }
    }
}