using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;

namespace Client
{
    public class ServerEvents : Events.Script
    {
        public ServerEvents()
        {
            Events.Add("Client.Authorization.LoginDataToClient", LoginDataToClient);
            Events.Add("Authorization.LoginDataToServer", LoginDataToServer);
        }
        private void LoginDataToServer(object[] args)
        {
            Chat.Output($"{args[0]} - {args[1]} - {args[2]}");
            Chat.Activate(true);
            Chat.Show(true);
            RAGE.Game.Ui.DisplayRadar(true);
            Player.LocalPlayer.FreezePosition(false);
            RAGE.Ui.Cursor.Visible = false;
            RAGE.Game.Graphics.TransitionFromBlurred(0);
            CEF.Close();
            //Events.CallRemote("Server.Player.Authorization.CheckLoginServer", args[0], args[1], args[2]);
        }
        private void LoginDataToClient(object[] args)
        {
            switch(args[1])
            {
                case "success":
                    RAGE.Ui.Cursor.Visible = true;
                    CEF.ChangePage("Character");
                    CEF.Call("showAllert('Вы успешно авторизовались на сервере. Приятной игры!', 'success')");
                    break;
                case "registered":
                    Chat.Activate(true);
                    Chat.Show(true);
                    CEF.ShowMainCEF();
                    RAGE.Game.Ui.DisplayRadar(true);
                    RAGE.Ui.Cursor.Visible = false;
                    CEF.Call("showAllert('Вы успешно зарегистрировались на сервере. Приятной игры!', 'success')");
                    break;
                default:
                    string result = $"showAllert('{args[1]}', 'warn')";
                    CEF.Call(result);
                    break;
            }
        }
    }
}