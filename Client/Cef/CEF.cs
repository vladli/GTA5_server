using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RAGE;
using RAGE.Elements;
using RAGE.Ui;

namespace Client
{
    class CEF
    {
        private static readonly string Url = "package://cs_packages/Cef/UI/index.html#/main";
        private static readonly int BlureTime = 500;
        private static RAGE.Ui.HtmlWindow Cef;

        public static void Create()
        {
            Cef = new RAGE.Ui.HtmlWindow(Url);
            //Cef.Active = false;
        }
        public static void ChangePage(string page)
        {
            Call($"ChangePage('{page}')");
        }
        public static void Close()
        {
            Cef.Active = false;
        }
        public static void Call(string fnc)
        {
            Cef.ExecuteJs(fnc);
        }
        public static void ShowLoginCEF()
        {
            //Chat.Activate(false);
            //Chat.Show(false);
            Chat.Output("LOGIN PAGE");
            //Cef.Active = true;
            //RAGE.Game.Ui.DisplayRadar(false);
           // Player.LocalPlayer.FreezePosition(true);
            //RAGE.Game.Graphics.TransitionToBlurred(BlureTime);
        }
        public static void ShowMainCEF()
        {
            ChangePage("Main");
            Chat.Activate(true);
            Chat.Show(true);
            RAGE.Game.Ui.DisplayRadar(true);
            Player.LocalPlayer.FreezePosition(false);
            RAGE.Ui.Cursor.Visible = false;
            RAGE.Game.Graphics.TransitionFromBlurred(0);
        }
    }
}