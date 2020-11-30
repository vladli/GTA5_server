using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;

namespace Client.Admin
{
    public class ServerEvents : Events.Script
    {
        public ServerEvents()
        {
            Events.Add("GetZCord", GetZCord);
            Events.Add("AdminEvent", AdminEvent);
        }
        private void AdminEvent(object[] args)
        {
            String s = string.Format("{0}", args[0].ToString());
            RAGE.Chat.Output(s);
            s = string.Format("{0}", args[1].ToString());
            RAGE.Chat.Output(s);
        }
        public void GetZCord(object[] args)
        {
            switch (args[0].ToString())
            {
                case "house":
                    float groundZ = 0;
                    RAGE.Game.Misc.GetGroundZFor3dCoord((float)args[1], (float)args[2], (float)args[3], ref groundZ, false);
                    Events.CallRemote("Houses.CreateHouse", groundZ);
                    break;
            }
        }
    }
}