using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GTANetworkAPI;
using Server;
using Server.Houses;
using Server.Player;
using Server.PlayerVehicles;

namespace Server.Vehicles
{
    public class Main : Script
    {
        [ServerEvent(Event.PlayerEnterVehicle)]
        public void OnPlayerEnterVehicle(GTANetworkAPI.Player player, Vehicle vehicle, sbyte seatID)
        {
            player.SendChatMessage($"Enter | ID: {vehicle.Value} | seatid: {seatID}");
            // NAPI.ClientEvent.TriggerClientEvent(player, "Vehicles.UI_ShowVehicleHUD");
            //PlayerModel.VehicleSpeedometer = new Timer((obj) =>
            //{
            //    NAPI.ClientEvent.TriggerClientEvent(player, "Vehicles.UI_UpdateVehicleSpeed");
            //}, null, 0, 100);
        }
        [ServerEvent(Event.PlayerExitVehicle)]
        public void OnPlayerExitVehicle(GTANetworkAPI.Player player, Vehicle vehicle)
        {
            player.SendChatMessage($"Exit | ID: {vehicle.Value}");
            //PlayerModel.VehicleSpeedometer.Change(Timeout.Infinite, Timeout.Infinite);

            //NAPI.ClientEvent.TriggerClientEvent(player, "Vehicles.UI_HideVehicleHUD");
        }
    }
}