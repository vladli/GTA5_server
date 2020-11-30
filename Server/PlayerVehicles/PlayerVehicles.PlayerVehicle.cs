using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTANetworkAPI;
using Microsoft.EntityFrameworkCore;

namespace Server.PlayerVehicles
{
    public class PlayerVehicle
    {
        [Key]
        public int ID { get; set; }
        public int VehID { get; set; }
        public string Model { get; set; }
        public string Position { get; set; }
        public string Color { get; set; }

        public PlayerVehicle()
        {
            VehID = -1;
            Model = "Unknown";
            Position = "0.0, 0.0, 0.0, 0.0";
            Color = "255, 255";
        }
        public static List<PlayerVehicle> List = new List<PlayerVehicle>();
        public async static Task<PlayerVehicle> SaveVehicle(int vehid)
        {
            using var dbServer = new ServerdbServer();
                var veh = await dbServer.vehicles_p.FirstOrDefaultAsync(x => x.VehID == vehid);
                var _id = List.FirstOrDefault(x => x.VehID == vehid);
                veh.VehID = _id.VehID;
                veh.Model = _id.Model;
                veh.Position = _id.Position;

                await dbServer.SaveChangesAsync();
                return veh;
        }
        public static void LoadVehicles()
        {
            using var dbServer = new ServerdbServer();
                var cars = dbServer.vehicles_p.ToList();
                float[] newPosCoordinates;
                Vector3 newpos;
                int[] color;
                Vehicle vehicle;
                foreach (PlayerVehicle v in cars)
                {
                    newPosCoordinates = v.Position.Split(new string[] { ", " }, StringSplitOptions.None).Select(x => float.Parse(x)).ToArray();
                    newpos = new Vector3(newPosCoordinates[0], newPosCoordinates[1], newPosCoordinates[2]);
                    color = v.Color.Split(new string[] { ", " }, StringSplitOptions.None).Select(x => int.Parse(x)).ToArray();
                    vehicle = NAPI.Vehicle.CreateVehicle(NAPI.Util.GetHashKey(v.Model), newpos, newPosCoordinates[3], color[0], color[1], "", 255, false, false);
                    NAPI.Vehicle.SetVehicleNumberPlate(vehicle, "VEH " + vehicle.Value);
                    var veh = new PlayerVehicle()
                    {
                        VehID = vehicle.Value,
                        Model = v.Model,
                        Position = v.Position,
                        Color = v.Color
                    };
                    v.VehID = vehicle.Value;
                    dbServer.SaveChanges();
                    List.Add(veh);
                    Console.WriteLine($"Player Vehicle: {v.VehID}. {v.Model}");
                }
        }
    }
}