using System;
using System.Collections.Generic;
using System.Text;
using RAGE;
using RAGE.Elements;

namespace Client.Players
{
    public class Players : Events.Script
    {
        public Players()
        {
            //Player.LocalPlayer.SetConfigFlag(429, true);
            Events.Tick += Tick;
        }
        public void Tick(List<Events.TickNametagData> nametags)
        {
            RAGE.Game.Audio.SetRadioToStationName("OFF");
            /*if(RAGE.Ui.Cursor.Visible)
            {
                string pos = "X: " + RAGE.Ui.Cursor.Position.X + " " + "Y: " + RAGE.Ui.Cursor.Position.Y;
                RAGE.NUI.UIResText.Draw(pos, (int)(RAGE.Ui.Cursor.Position.X), (int)(RAGE.Ui.Cursor.Position.Y), RAGE.Game.Font.ChaletComprimeCologne, 0.40f, System.Drawing.Color.White, RAGE.NUI.UIResText.Alignment.Centered, false, false, 0);
            }*/
        } 
    }
}