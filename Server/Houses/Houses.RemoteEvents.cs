using System;
using GTANetworkAPI;

namespace Server.Houses
{
    public class RemoteEvents : Script
    {
        [RemoteEvent("Houses.CreateHouse")]
        public async System.Threading.Tasks.Task CreateHouseAsync(GTANetworkAPI.Player player, float groundZ)
        {
            var dBhouse = new HouseInfo()
            {
                Owner = "Unknown",
                Position = String.Format("{0}, {1}, {2}, {3}", player.Position.X, player.Position.Y, groundZ, NAPI.Entity.GetEntityRotation(player).Z)
            };
            HouseInfo.List.Add(dBhouse);
            Vector3 pos = new Vector3(player.Position.X, player.Position.Y, groundZ);
            NAPI.Marker.CreateMarker(1, pos, new Vector3(), new Vector3(), 1f, new Color(255, 0, 0, 155));
            using (var dbServer = new ServerdbServer())
            {
                await dbServer.houses.AddAsync(dBhouse);
                await dbServer.SaveChangesAsync();
            }
            player.SendChatMessage($"PosX: {player.Position.X} | PosY: {player.Position.Y} | PosZ: {groundZ} | Rot: {NAPI.Entity.GetEntityRotation(player).Z}");
        }
    }
}