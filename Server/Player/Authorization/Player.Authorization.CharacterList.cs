using GTANetworkAPI;
using System.Linq;

namespace Server.Player
{
    public class CharacterList : Script
    {
        [RemoteEvent("Server.Player.Authorization.ChoseCharacter")]
        public void ChoseCharacter(Charrs player, int characterid)
        {
            using var dbServer = new ServerdbServer();
            using var dbMain = new MaindbServer();
            PlayerModel Player = dbServer.characters.SingleOrDefault(c => c.ID == characterid);
            PlayerModel _player = new PlayerModel()
            {
                AccountID = Player.AccountID,
                Name = Player.Name,
                Level = Player.Level,
                Admin = Player.Admin,
                HouseKey = Player.HouseKey
            };
            player.NName = Player.Name;
            player.SetData(PlayerModel.DataIdentifier, _player);
            NAPI.Entity.SetEntityTransparency(player, 255);
            NAPI.Entity.SetEntityDimension(player, 0);
            NAPI.Player.SetPlayerNametag(player, Player.Name);
            player.SendChatMessage($"~g~Аккаунт выбран. Персонаж: {Player.Name}");
        }
        [RemoteEvent("Server.Player.Authorization.DeleteCharacter")]
        public void DeleteCharacter(GTANetworkAPI.Player player, string name, string password, int state)
        {
        }
    }
}
