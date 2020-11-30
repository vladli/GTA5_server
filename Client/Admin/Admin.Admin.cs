using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;

namespace Client.Admin
{
    public class Admin : Events.Script
    {
        public Admin()
        {
            Events.OnPlayerCommand += OnPlayerCommand;
            //TimerCallback timeCB = new TimerCallback(PrintTime);
            //Timer time = new Timer(timeCB, null, 0, 1000);
        }
        /*static void PrintTime(object state)
        {
            Chat.Output("Timer)a");
        }*/
        public void OnPlayerCommand(string cmd, RAGE.Events.CancelEventArgs cancel)
        {
            if (cmd == "qw")
            {
                CEF.Call($"trigger('ASD', '1')");
                Chat.Output("trigger('ASD', '1')");
                /*RAGE.Chat.Output("AAA1");
                Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    //RAGE.Ui.Cursor.Visible = true;
                    RAGE.Chat.Output("Delay AAA");
                });
                RAGE.Ui.Cursor.ShowCursor(true, true);
                RAGE.Ui.Cursor.Visible = true;
                RAGE.Chat.Output("AAA2");*/
            }
            if(cmd.Contains("asd"))
            {
                string[] sentenses = cmd.Split(' ');
                Chat.Output($"POWER: {sentenses[1]}");
                //RAGE.Game.Entity.SetEntityMaxSpeed(Player.LocalPlayer.Vehicle.Handle, 10.0f);
                RAGE.Game.Vehicle.SetVehicleEnginePowerMultiplier(Player.LocalPlayer.Vehicle.Handle, (float)Convert.ToDouble(sentenses[1]));
                //UI_ShowAdminPanel(5, Player.LocalPlayer.Name, 0, Player.LocalPlayer.Position, Player.LocalPlayer.Dimension);
            }
            if (cmd.Contains("asd2"))
            {
                string[] sentenses = cmd.Split(' ');
                Chat.Output($"TORQUE: {sentenses[1]}");
                //RAGE.Game.Entity.SetEntityMaxSpeed(Player.LocalPlayer.Vehicle.Handle, 10.0f);
                RAGE.Game.Vehicle.SetVehicleEngineTorqueMultiplier(Player.LocalPlayer.Vehicle.Handle, (float)Convert.ToDouble(sentenses[1]));
                //UI_ShowAdminPanel(5, Player.LocalPlayer.Name, 0, Player.LocalPlayer.Position, Player.LocalPlayer.Dimension);
            }
        }
        public static void UI_ShowAdminPanel(int level, string name, int gameid, Vector3 position, uint dimension)
        {
            CEF.Call($"ShowAdminPanel('{level}', '{name}', '{gameid}', '{position}', '{dimension}')");
            /*Timer positiontimer = new Timer((obj) =>
            {
                UI_UpdateAdminPosition();
            }, null, 0, 500);*/
            Chat.Output($"{level} {name} {gameid} {position} {dimension}");
        }
        public static void UI_UpdateAdminPosition()
        {
            CEF.Call($"UpdateAdminPosition('{Player.LocalPlayer.Position}')");
        }
    }
}