using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTANetworkAPI;
using Server.Player;
using Server.PlayerVehicles;

namespace Server.Admin
{
    public class Commands : Script
    {
        [Command("apark")]
        public async System.Threading.Tasks.Task CMD_apark(GTANetworkAPI.Player player)
        {
            if (!player.IsInVehicle)
            {
                player.SendChatMessage("Вы должны находиться в транспорте.");
                return;
            }
            string result = String.Format("{0}, {1}, {2}, {3}", player.Vehicle.Position.X, player.Vehicle.Position.Y, player.Vehicle.Position.Z, NAPI.Entity.GetEntityRotation(player.Vehicle).Z);
            var _id = PlayerVehicle.List.SingleOrDefault(x => x.VehID == player.Vehicle.Value);
            player.SendChatMessage($"Вы успешно перепакровали {_id.Model}({player.Vehicle.Value}).");
            player.SendChatMessage($"ID: {player.Vehicle.Value}({_id.VehID}) | Model: {_id.Model} | Pos: {player.Vehicle.Position.X}, {player.Vehicle.Position.Y}, {player.Vehicle.Position.Z}");
            _id.Position = result;
            await PlayerVehicle.SaveVehicle(_id.VehID);
        }
        [Command("getveh")]
        public void CMD_getveh(GTANetworkAPI.Player player, int vehid)
        {
            foreach (Vehicle veh in NAPI.Pools.GetAllVehicles())
            {
                if(veh.Value == vehid)
                {
                    var _id = PlayerVehicle.List.SingleOrDefault(x => x.VehID == vehid);
                    NAPI.Entity.SetEntityPosition(veh, player.Position.Around(5));
                    NAPI.Entity.SetEntityRotation(veh, NAPI.Entity.GetEntityRotation(player));
                    player.SendChatMessage($"Вы телепортировали к себе {_id.Model}({veh.Value}).");
                    return;
                }
            }
            player.SendChatMessage("Транспорт не существует.");
        }
        [Command("delveh")]
        public void CMD_delveh(GTANetworkAPI.Player player)
        {
            Vehicle veh = NAPI.Player.GetPlayerVehicle(player);
            if(!player.IsInVehicle)
            {
                player.SendChatMessage("Вы должны находиться в транспорте.");
                return;
            }
            player.SendChatMessage($"Вы удалили {veh.DisplayName}({veh.Value}).");
            NAPI.Entity.DeleteEntity(veh);
        }
        [Command("veh")]
        public void CMD_veh(GTANetworkAPI.Player player, string vehicle_name, int color1 = 255, int color2 = 255)
        {
            uint vehicle_hash = NAPI.Util.GetHashKey(vehicle_name);
            Vehicle vehicle = NAPI.Vehicle.CreateVehicle(vehicle_hash, player.Position.Around(5), 0, color1, color2, "", 255, false, false);
            NAPI.Vehicle.SetVehicleNumberPlate(vehicle, "ADMIN");
            NAPI.Player.SetPlayerIntoVehicle(player, vehicle, -1);
            player.SendChatMessage($"ID: {vehicle.Value} | PosX: {vehicle.Position.X} | PosY: {vehicle.Position.Y} | PosZ: {vehicle.Position.Z} | Rot: {NAPI.Entity.GetEntityRotation(player).Z}");
        }
        [Command("pveh")]
        public async System.Threading.Tasks.Task CMD_pveh(GTANetworkAPI.Player player, string vehicle_name, int color1 = 255, int color2 = 255)
        {
            uint vehicle_hash = NAPI.Util.GetHashKey(vehicle_name);
            Vehicle vehicle = NAPI.Vehicle.CreateVehicle(vehicle_hash, player.Position.Around(5), 0, color1, color2, "", 255, false, false);
            NAPI.Vehicle.SetVehicleNumberPlate(vehicle, "BATYA");
            NAPI.Player.SetPlayerIntoVehicle(player, vehicle, -1);
            player.SendChatMessage($"ID: {vehicle.Value} | PosX: {vehicle.Position.X} | PosY: {vehicle.Position.Y} | PosZ: {vehicle.Position.Z} | Rot: {NAPI.Entity.GetEntityRotation(player).Z}");
            var dBvehicle = new PlayerVehicle()
            {
                VehID = vehicle.Value,
                Model = vehicle_name.ToUpper(),
                Position = String.Format("{0}, {1}, {2}, {3}", vehicle.Position.X, vehicle.Position.Y, vehicle.Position.Z, NAPI.Entity.GetEntityRotation(player).Z),
                Color = String.Format("{0}, {1}", color1, color2)
            };
            PlayerVehicle.List.Add(dBvehicle);
            using var dbServer = new ServerdbServer();
            await dbServer.vehicles_p.AddAsync(dBvehicle);
            await dbServer.SaveChangesAsync();
        }


        [Command("house")]
        public void CMD_house(GTANetworkAPI.Player player)
        {
            NAPI.ClientEvent.TriggerClientEvent(player, "GetZCord", "house", player.Position.X, player.Position.Y, player.Position.Z);
        }

        [Command("test")]
        public void CMD_test(Charrs player)
        {
            //PlayerModel _player = player.GetPlayerData();
            //player.SendChatMessage($"{_player.ID} {_player.AccountID}");
            //var user = (Charrs)player;
            player.SendChatMessage($"Charrs: {player.AccountID} {player.NName}");
            //player.SendChatMessage(player.Vehicle.DisplayName);
            //player.SendChatMessage($"{player.Vehicle.MaxSpeed}");
        }
    }
}
