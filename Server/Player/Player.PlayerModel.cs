using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace Server.Player
{
    public class Charrs : GTANetworkAPI.Player
    {
        public int AccountID { get; set; }
        public string NName { get; set; }
        public Charrs(NetHandle netHandle) : base(netHandle)
        {
            AccountID = -1;
            NName = "ASD";
        }
    }
    public class PlayerModel
    {
        public static readonly string DataIdentifier = "CharacterInfo";

        [Key]
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Admin { get; set; }
        public int HouseKey { get; set; }

        public PlayerModel()
        {
            ID = -1;
            AccountID = -1;
            Name = "Unknown";
            Level = 0;
            Admin = -1;
            HouseKey = -1;
        }

        public static Timer VehicleSpeedometer;
    }
    public static class Extension
    {
        public static PlayerModel GetPlayerData(this GTANetworkAPI.Player player)
        {
            if (player.HasData(PlayerModel.DataIdentifier))
            {
                return player.GetData<PlayerModel>(PlayerModel.DataIdentifier);
            }
            else
            {
                player.SendChatMessage("Error: There was an error with the player data.");
                //player.Kick();
                return null;
            }
        }
    }
}