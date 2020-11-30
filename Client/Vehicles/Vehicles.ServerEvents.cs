using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using RAGE;
using RAGE.Elements;

namespace Client.Vehicles
{
    public class Main : Events.Script
    {
        public Main()
        {
            Events.Add("Vehicles.UI_ShowVehicleHUD", UI_ShowVehicleHUD);
            Events.Add("Vehicles.UI_HideVehicleHUD", UI_HideVehicleHUD);
            Events.Add("Vehicles.UI_UpdateVehicleSpeed", UI_UpdateVehicleSpeed);
        }
        private void UI_ShowVehicleHUD(object[] args)
        {
            CEF.Call($"ShowVehicleHUD(true)");
            Chat.Output("VEH HUD ON");
            CEF.Call("showAllert('Вы успешно сели в тачку!', 'success')");
        }
        private void UI_HideVehicleHUD(object[] args)
        {
            CEF.Call($"ShowVehicleHUD(false)");
            Chat.Output("VEH HUD OFF");
        }
        public void UI_UpdateVehicleSpeed(object[] args)
        {
            int speed = Convert.ToInt32(Player.LocalPlayer.Vehicle.GetSpeed()*1.609);
            CEF.Call($"UpdateVehicleSpeed('{speed}')");
        }
    }
}