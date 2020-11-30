using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using GTANetworkAPI;
using Server;
using Server.Houses;
using Server.Player;
using Server.PlayerVehicles;

namespace Main
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            RAGE.Entities.Players.CreateEntity = netHandle => new Charrs(netHandle);
            NAPI.Server.SetDefaultSpawnLocation(new Vector3(1359.97, -604.9183, 73.75807));
            NAPI.Server.SetGlobalDefaultCommandMessages(false);
            using var dbMain = new MaindbServer();
            using var dbServer = new ServerdbServer();
            NAPI.Util.ConsoleOutput("Total players in the database: " + dbMain.accounts.Count());
            //NAPI.Util.ConsoleOutput("Total characters in the database: " + dbServer.characters.Count());
            foreach (AccountModel u in dbMain.accounts.ToList())
            {
                Console.WriteLine($"{u.ID}.{u.Name} - {u.Password}");
            }
            PlayerVehicle.LoadVehicles();
            HouseInfo.LoadHouses();
        }
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
            NAPI.Entity.SetEntityTransparency(player, 0);
            NAPI.Entity.SetEntityDimension(player, Convert.ToUInt32(player.Value) + 1);
        }
    }
}