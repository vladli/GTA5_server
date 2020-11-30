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
    public class Timers : Script
    {
        private static Timer _globalTimer;
        public static void StartTimer()
        {
            _globalTimer = new Timer(1000);
            _globalTimer.Elapsed += OnTimerElapsed;
            _globalTimer.AutoReset = true;
            _globalTimer.Enabled = true;
        }
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            StartTimer();
        }
        private static void OnTimerElapsed(object sender, ElapsedEventArgs args)
        {
            PlayerTimer();
        }
        private static void PlayerTimer()
        {
            foreach (Player player in NAPI.Pools.GetAllPlayers())
            {
                
            }
        }
    }
}