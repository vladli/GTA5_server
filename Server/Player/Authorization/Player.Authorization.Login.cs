using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTANetworkAPI;
using Server;
using Server.Player;

namespace Server.Player
{
    public class Login : Script
    {
        [RemoteEvent("Server.Player.Authorization.CheckLoginServer")]
        public void CheckLoginServer(GTANetworkAPI.Player player, string name, string password, int state)
        {
            switch (state)
            {
                case 0:
                    {
                        using var dbServer = new ServerdbServer();
                        using var dbMain = new MaindbServer();
                        AccountModel Account = dbMain.accounts.SingleOrDefault(c => c.Name == name);
                        if (Account == null)
                        {
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "incorrectinfo");
                            return;
                        }
                        if (Account.Password == password)
                        {
                            AccountModel _player = new AccountModel
                            {
                                Name = player.Name,
                                Password = password
                            };
                            AccountModel.List.Add(_player);
                            NAPI.Entity.SetEntityTransparency(player, 255);
                            NAPI.Entity.SetEntityDimension(player, 0);
                            var characters = dbServer.characters.ToList().Where(a => a.AccountID == Account.ID);
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.ShowCharacters");
                            NAPI.Task.Run(() =>
                            {
                                foreach (var a in characters)
                                {
                                    NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.AddCharacterToList", a.ID, a.Name, a.Level, a.Level);
                                }
                            }, 100);
                        }
                        else
                        {
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "incorrectinfo");
                            return;
                        }
                        break;
                    }
                case 1:
                    {
                        if (name.Length < 3)
                        {
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "tooshort");
                            return;
                        }
                        if (password.Length < 6)
                        {
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "tooshort");
                            return;
                        }
                        using var dbServer = new MaindbServer();
                        AccountModel Player = dbServer.accounts.SingleOrDefault(c => c.Name == name);
                        if (Player != null)
                        {
                            NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "takeninfo");
                            return;
                        }
                        var account = new AccountModel
                        {
                            Name = name,
                            Password = password
                        };
                        dbServer.accounts.Add(account);
                        dbServer.SaveChanges();
                        NAPI.ClientEvent.TriggerClientEvent(player, "Client.Authorization.LoginDataToClient", player, "registered");
                        break;
                    }
            }
        }
    }
}